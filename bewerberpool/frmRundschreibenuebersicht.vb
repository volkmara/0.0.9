Imports System.ComponentModel
Imports bewerberpool
Imports bewerberpool.BewerberDataSet
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class frmRundschreibenuebersicht
    Private frmMain As frmMain

    Public Sub New(frmMain As frmMain)
        Me.frmMain = frmMain
        InitializeComponent()
    End Sub


    Private Sub frmRundschreibenuebersicht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RundschreibenTableAdapter.Fill(Me.BewerberDataSet.rundschreiben)
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        Me.RundschreibenmonatTableAdapter.Fill(Me.BewerberDataSet.rundschreibenmonat)
        ' Me.BewBindingSource.Filter = "rundschreibenuebersichtjanein = 0"
        ' Me.RundschreibenBindingSource.Filter = "column9 <> 0"
    End Sub

    Private Sub frmRundschreibenuebersicht_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.RundschreibenmonatBindingSource.Filter = "erledigt = 1"
        Me.RundschreibenBindingSource1.Filter = "aktuell = 1"
    End Sub
    Private Sub RGVRundschreibenMonat_ViewCellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RGVRundschreibenMonat.ViewCellFormatting, RGVBewerber.ViewCellFormatting, RGVRundschreibenaktuell.ViewCellFormatting, RGVRundschreibenmonataktuell.ViewCellFormatting
        Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

        If TypeOf e.CellElement Is GridHeaderCellElement Then
            e.CellElement.Font = newFont10
        Else
            e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

        If e.CellElement.ColumnInfo.Name = "column1" Then
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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        ' Werte in rundschreibenmonat.erledigt: 0 = noch nicht verwendet, 1 = enthält mindestens einen Bewerbereintrag, 2 = versandtes Rundschreiben
        If TabControl1.SelectedTab Is TabPage2 Then
            Me.RundschreibenBindingSource1.Filter = "aktuell = 0 AND gelöscht = 1"
            Me.RundschreibenmonatBindingSource.Filter = "erledigt = 2"
        ElseIf TabControl1.SelectedTab Is TabPage1 Then
            Me.RundschreibenBindingSource1.Filter = "aktuell = 1"
            Me.RundschreibenmonatBindingSource.Filter = "erledigt = 1"
        End If
    End Sub

#Region "Tabpage 1: aktuelle Rundschreibenbewerber"

    Private Sub Homepagecheck()
        Dim rundschreiben = DirectCast(DirectCast(RundschreibenBindingSource1.Current, DataRowView).Row, rundschreibenRow)
        If frmMain.HeyduckDataSet.tt_news.Any(Function(x) x.tx_ttnewserweiterung_referenznummer = CStr(rundschreiben.refnr)) Then
            chkAufHomepage.Checked = True
        Else
            chkAufHomepage.Checked = False
        End If
    End Sub

    Private Sub Voreintraege()
        Dim liste As New BindingList(Of String)

        Dim bewerber = DirectCast(DirectCast(RundschreibenBindingSource1.Current, DataRowView).Row, rundschreibenRow)
        Dim bewerberid As Integer = CInt(bewerber.bewid)

        ' Es werden nur die Rundschreiben aufgelistet, die zeitlich vor dem aktuellen Rundschreiben liegen, also die, bei denen x.aktuell = 0 ist
        Dim bewrundschreiben = BewerberDataSet.rundschreiben.Where(Function(x) x.bewid = bewerberid AndAlso x.aktuell = CInt(0)).Select(Function(x) x.bezeichnung).Reverse.ToList

        ListBox1.DataSource = bewrundschreiben
    End Sub


    Private Sub RGVRundschreibenaktuell_Click(sender As Object, e As EventArgs) Handles RGVRundschreibenaktuell.Click
        Call Homepagecheck()
        Call Voreintraege()
        Call Rundschreibencheck()
    End Sub

    Private Sub Rundschreibencheck()

        Dim rundschreiben = DirectCast(DirectCast(RundschreibenBindingSource1.Current, DataRowView).Row, rundschreibenRow)
        If rundschreiben.aktuell = CInt(1) Then
            rbtnJa.Checked = True
            rbtnNein.Checked = False
        ElseIf rundschreiben.aktuell = CInt(0) Then
            rbtnJa.Checked = False
            rbtnNein.Checked = True
        End If
    End Sub

    Private Sub btnSave_Rundschreiben_Click(sender As Object, e As EventArgs) Handles btnSave_Rundschreiben.Click, btnEintraegeloeschen.Click, btnRundschreibenaktuell_Close.Click, AufklappenRadMenuItem1.Click, EinklappenRadMenuItem1.Click

        Select Case True
            Case sender Is btnSave_Rundschreiben
                Dim rundschreiben = DirectCast(DirectCast(RundschreibenBindingSource1.Current, DataRowView).Row, rundschreibenRow)
                If rbtnNein.Checked Then
                    rundschreiben.aktuell = CInt(0)
                ElseIf rbtnJa.Checked Then
                    rundschreiben.aktuell = CInt(1)
                End If

                Me.Validate()
                Me.RundschreibenBindingSource1.EndEdit()
                Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)
                Call gespeichert()

            Case sender Is btnRundschreibenaktuell_Close
                Me.Close()

            Case sender Is btnEintraegeloeschen
                Dim rs = BewerberDataSet.rundschreiben.Where(Function(x) x.aktuell = 1)
                For Each x In rs
                    x.aktuell = CInt(0)
                    x.gelöscht = CInt(1)
                Next

                Me.Validate()
                Me.RundschreibenBindingSource1.EndEdit()
                Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)

                Dim rsmonat = BewerberDataSet.rundschreibenmonat.Where(Function(x) x.erledigt = 1)
                For Each x In rsmonat
                    x.erledigt = CInt(2)
                Next

                Me.Validate()
                Me.RundschreibenmonatBindingSource.EndEdit()
                Me.RundschreibenmonatTableAdapter.Update(Me.BewerberDataSet.rundschreibenmonat)
                Call gespeichert()

            Case sender Is AufklappenRadMenuItem1
                Me.RGVRundschreibenaktuell.AutoSizeRows = True
                Me.RGVRundschreibenaktuell.Columns(14).WrapText = True
            Case sender Is EinklappenRadMenuItem1
                Me.RGVRundschreibenaktuell.AutoSizeRows = False
                Me.RGVRundschreibenaktuell.Columns(14).WrapText = False
        End Select
    End Sub

#End Region

#Region "Tabpage 2: Rundschreibenübersicht"
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Dim rundschreibenmonat = DirectCast(DirectCast(Me.RundschreibenmonatBindingSource.Current, DataRowView).Row, rundschreibenmonatRow)
        'rundschreibenmonat.kw = CInt(cmbKW.SelectedItem)
        Me.Validate()
        Me.RundschreibenmonatBindingSource.EndEdit()
        Me.RundschreibenmonatTableAdapter.Update(Me.BewerberDataSet.rundschreibenmonat)
        Call gespeichert()
    End Sub
#End Region
End Class