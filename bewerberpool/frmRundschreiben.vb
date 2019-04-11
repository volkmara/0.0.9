Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.Windows.Documents.Core
Imports Telerik.Windows.Documents.Spreadsheet
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf
Imports Telerik.Windows.Zip
Imports Telerik.WinControls.UI.Export.ExcelML
Imports Telerik.WinControls.UI.Export
Imports bewerberpool.BewerberDataSet
Imports bewerberpool.heyduckDataSet
Imports System.ComponentModel

Public Class frmRundschreiben

    Public rundschreibenid As Integer = CInt(0)
    Public rundschreibentext As String = String.Empty

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmRundschreiben_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        Me.RundschreibenTableAdapter.Fill(Me.BewerberDataSet.rundschreiben)

        BewBindingSource.Filter = "rundschreibenjanein = 1"

        Call Internetverbindung()
        If Inet Then
            frmMain.Tt_newsTableAdapter.Fill(frmMain.HeyduckDataSet.tt_news)
        End If
    End Sub

    Private Sub frmRundschreiben_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each column As GridViewColumn In RundschreibenGridView.Columns
            If TypeOf column Is GridViewTextBoxColumn Then
                Dim col As GridViewTextBoxColumn = TryCast(column, GridViewTextBoxColumn)
                col.HeaderTextAlignment = ContentAlignment.MiddleLeft
            End If
        Next

        Me.RundschreibenGridView.Rows(0).IsCurrent = False

        For Each tb As TextBox In Me.GroupBox1.Controls.OfType(Of TextBox)()
            tb.ReadOnly = True
        Next

        Me.RundschreibenGridView.MasterTemplate.ShowFilterCellOperatorText = False

        Call rundschreibencheck()
        Call voreintraege()
    End Sub

#Region "Grid formatieren"

    Private Sub RundschreibenGridView_ViewCellFormatting(ByVal sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RundschreibenGridView.ViewCellFormatting
        Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

        If TypeOf e.CellElement Is GridHeaderCellElement Then
            e.CellElement.Font = newFont10
        Else
            e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If


        If e.CellElement.ColumnInfo.Name = "name" Then
            e.CellElement.Font = newFont10
            e.CellElement.DrawFill = True
            e.CellElement.NumberOfColors = 1
            e.CellElement.BackColor = Color.Yellow
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        End If
    End Sub
#End Region

    Private Sub rundschreibencheck()
        Dim rundschreiben = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)

        rundschreibenid = CInt(rundschreiben.id_bew)

        If rundschreiben.IsrundschreibenjaneinNull Then
            Exit Sub
        End If

        If rundschreiben.rundschreibenjanein = CInt(1) Then
            rbtnJa.Checked = True
            rbtnNein.Checked = False
        ElseIf Not rundschreiben.rundschreibenjanein = CInt(0) Then
            rbtnJa.Checked = False
            rbtnNein.Checked = True
        End If
    End Sub

    Private Sub voreintraege()
        Dim liste As New BindingList(Of String)
        ' Es werden nur die Rundschreiben aufgelistet, die zeitlich vor dem aktuellen Rundschreiben liegen, also die, bei denen x.aktuell = 0 ist
        Dim bewrundschreiben = BewerberDataSet.rundschreiben.Where(Function(x) x.bewid = rundschreibenid AndAlso x.aktuell = CInt(0)).Select(Function(x) x.bezeichnung).Reverse

        For Each x In bewrundschreiben
            liste.Add(x.ToString)
        Next
        ListBox1.DataSource = liste

    End Sub

    Private Sub RundschreibenGridView_Click(sender As Object, e As EventArgs) Handles RundschreibenGridView.Click
        Call rundschreibencheck()
        Call voreintraege()

        Dim bewrundschreiben = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)
        '  Dim idtemp As Integer = CInt(bewrundschreiben.id_bew)
        ' RundschreibenBindingSource.Filter = "bewid = '" & idtemp & "'"
        ' RundschreibenBindingSource.Filter = "bewid = '" & bewrundschreiben.id_bew & "'"

        If frmMain.HeyduckDataSet.tt_news.Any(Function(x) x.tx_ttnewserweiterung_referenznummer = CStr(bewrundschreiben.refnr)) Then
            chkAufHomepage.Checked = True
        Else
            chkAufHomepage.Checked = False
        End If

        If frmMain.BewerberDataSet.rundschreiben.Any(Function(x) x.homepage = 0 AndAlso x.aktuell = 1) Then
            chkHomepage.Checked = False
        ElseIf frmMain.BewerberDataSet.rundschreiben.Any(Function(x) x.homepage = 1 AndAlso x.aktuell = 1) Then
            chkHomepage.Checked = True
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnSave.Click, btnEintraegeloeschen.Click, btnClose.Click, InvorhandeneDateiRadMenuItem.Click, NeueDateianlegenRadMenuItem.Click, AufklappenRadMenuItem1.Click, EinklappenRadMenuItem1.Click
        Select Case True
            Case sender Is btnSave
                Dim rundschreiben = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)

                If rbtnNein.Checked Then
                    rundschreiben.rundschreibenjanein = CInt(0)
                    rundschreiben.rundschreibenbezeichnung = Nothing
                    rundschreiben.rundschreibenanmerkungen = Nothing
                    rundschreiben.rundschreibenreihenfolge = Nothing
                    rundschreiben.rundschreibenuebersichtjanein = CInt(0)

                    Me.Validate()
                    Me.BewBindingSource.EndEdit()
                    Me.BewTableAdapter.Update(Me.BewerberDataSet.bew)

                    Dim rs = BewerberDataSet.rundschreiben.Where(Function(y) y.bewid = rundschreibenid AndAlso y.aktuell = CInt(1))

                    For Each y In rs
                        y.bewid = Nothing
                        y.refnr = Nothing
                        'y.aktuell = Nothing
                        ' y.bezeichnung = Nothing
                        y.idrundschreibenmonat = Nothing
                        y.homepage = 0
                    Next

                    Me.Validate()
                    Me.RundschreibenBindingSource.EndEdit()
                    Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)

                ElseIf rbtnJa.Checked Then
                    rundschreiben.rundschreibenjanein = CInt(1)
                    rundschreiben.rundschreibenuebersichtjanein = CInt(1)
                    rundschreiben.rundschreibenanmerkungen = txtRundschreiben_anmerkungen.Text
                    If txtRundschreibenreihenfolge.Text <> String.Empty Then
                        rundschreiben.rundschreibenreihenfolge = CInt(txtRundschreibenreihenfolge.Text)
                    End If

                    Me.Validate()
                    Me.BewBindingSource.EndEdit()
                    Me.BewTableAdapter.Update(Me.BewerberDataSet.bew)

                    If chkHomepage.Checked Then
                        Dim rscurrent = BewerberDataSet.rundschreiben.Where(Function(y) y.bewid = rundschreibenid AndAlso y.aktuell = CInt(1))
                        For Each y In rscurrent
                            y.homepage = CInt(1)
                        Next

                        Me.Validate()
                        Me.RundschreibenBindingSource.EndEdit()
                        Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)
                    End If
                End If

            Case sender Is btnClose
                Dim result As DialogResult = MessageBox.Show("Wenn Sie das Fenster schließen wollen, ohne zu speichern, klicken Sie bitte auf ""Ja"", wenn Sie vergessen haben zu speichern, klicken Sie bitte auf ""Nein""", "Speichern vergessen", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    Me.Close()
                ElseIf result = Windows.Forms.DialogResult.No Then
                    Me.Validate()
                    Me.BewBindingSource.EndEdit()
                    Me.BewTableAdapter.Update(Me.BewerberDataSet.bew)
                    Me.Close()
                End If

            Case sender Is InvorhandeneDateiRadMenuItem
                Call exportExcelinvorhandeneDatei()

            Case sender Is NeueDateianlegenRadMenuItem
                Call exportExcelinneueDatei()

            Case sender Is btnEintraegeloeschen
                '  Dim rundschreibenid As Integer = CInt(0)
                Dim bewerber = BewerberDataSet.bew.Where(Function(x) x.rundschreibenjanein = CInt(1))
                Dim bewerbercount = BewerberDataSet.bew.Where(Function(x) x.rundschreibenjanein = CInt(1)).Count
                Dim rundschreiben = BewerberDataSet.rundschreiben.Where(Function(y) y.bewid = CInt(rundschreibenid) And y.aktuell = CInt(1))
                Dim text As String = String.Concat("Es wird/werden ", bewerbercount, " Eintrag/Einträge für das Rundschreiben gelöscht.")
                MessageBox.Show(text, "Einträge für Rundschreiben löschen", MessageBoxButtons.OK, MessageBoxIcon.Information)

                For Each x In bewerber
                    rundschreibenid = CInt(x.id_bew)
                    For Each y In rundschreiben
                        'y.bezeichnung = CStr(x.rundschreibenbezeichnung)
                        y.aktuell = CInt(0)
                    Next
                Next

                Me.Validate()
                Me.RundschreibenBindingSource.EndEdit()
                Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)

                For Each x In bewerber
                    x.rundschreibenbezeichnung = Nothing
                    x.rundschreibenreihenfolge = Nothing
                    x.rundschreibenanmerkungen = Nothing
                    x.rundschreibenjanein = CInt(0)
                    x.rundschreibenuebersichtjanein = CInt(0)
                Next

                Me.Validate()
                Me.BewBindingSource.EndEdit()
                Me.BewTableAdapter.Update(Me.BewerberDataSet.bew)
            Case sender Is AufklappenRadMenuItem1
                Me.RundschreibenGridView.AutoSizeRows = True
                Me.RundschreibenGridView.Columns(9).WrapText = True
            Case sender Is EinklappenRadMenuItem1
                Me.RundschreibenGridView.AutoSizeRows = False
                Me.RundschreibenGridView.Columns(9).WrapText = False
        End Select
    End Sub

    Private Sub exportExcelinvorhandeneDatei()
        Dim exporter As GridViewSpreadExport = New GridViewSpreadExport(Me.RundschreibenGridView)
        Dim exportRenderer As New SpreadExportRenderer()
        exporter.ExportVisualSettings = True
        exporter.SheetName = CStr(BewerberDataSet.bew.Where(Function(x) x.rundschreibenjanein = CInt(1)).FirstOrDefault.rundschreibenbezeichnung)
        exporter.FileExportMode = FileExportMode.NewSheetInExistingFile
        If connectionString.Contains("127.0.0.1") Then
            exporter.RunExport("E:\testxls.xlsx", exportRenderer)
            Call gespeichert()
            System.Diagnostics.Process.Start("E:\testxls.xlsx")
        Else
            exporter.RunExport("X:\Formulare\TopTen.xlsx", exportRenderer)
            Call gespeichert()
            System.Diagnostics.Process.Start("X:\Formulare\TopTen.xlsx")
        End If
    End Sub
    Private Sub exportExcelinneueDatei()
        Dim rundschreibenverzeichnis As String = String.Empty
        Dim bewerber = BewerberDataSet.bew.Where(Function(x) x.rundschreibenjanein = CInt(1))

        Dim exporter As GridViewSpreadExport = New GridViewSpreadExport(Me.RundschreibenGridView)
        Dim exportRenderer As New SpreadExportRenderer()
        exporter.ExportVisualSettings = True
        exporter.SheetName = CStr(BewerberDataSet.bew.Where(Function(x) x.rundschreibenjanein = CInt(1)).FirstOrDefault.rundschreibenbezeichnung)
        exporter.FileExportMode = FileExportMode.CreateOrOverrideFile

        If connectionString.Contains("127.0.0.1") Then
            rundschreibenverzeichnis = "E:\heyduck\rundschreiben\kunden\top10\"
        Else
            rundschreibenverzeichnis = "X:\Formulare\"
        End If

        Using SFD As New SaveFileDialog
            With SFD
                .InitialDirectory = rundschreibenverzeichnis
                .FileName = "TopTeneinzeln.xlsx"
                .Filter = "Exeldateien (*.xlsx)|"
                .RestoreDirectory = True
            End With
            If SFD.ShowDialog() = DialogResult.OK Then
                If connectionString.Contains("127.0.0.1") Then
                    exporter.RunExport("E:\TopTeneinzeln.xlsx", exportRenderer)
                    Call gespeichert()
                    System.Diagnostics.Process.Start("E:\TopTeneinzeln.xlsx")
                Else
                    exporter.RunExport("X:\Formulare\TopTeneinzeln.xlsx", exportRenderer)
                    Call gespeichert()
                    System.Diagnostics.Process.Start("X:\Formulare\TopTeneinzeln.xlsx")
                End If
            End If
        End Using
    End Sub

End Class