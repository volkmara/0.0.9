Imports System.ComponentModel
Imports System.Globalization
Imports bewerberpool
Imports bewerberpool.BewerberDataSet
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class frmRundschreibenuebersicht

    Public kw As Integer = 0
    Public rsaktuellbezeichnung As String = String.Empty

    Private frmMain As frmMain

    Public Sub New(frmMain As frmMain)
        Me.frmMain = frmMain
        InitializeComponent()
    End Sub


    Private Sub frmRundschreibenuebersicht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RundschreibenTableAdapter.Fill(Me.BewerberDataSet.rundschreiben)
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        Me.RundschreibenmonatTableAdapter.Fill(Me.BewerberDataSet.rundschreibenmonat)
    End Sub

    Private Sub frmRundschreibenuebersicht_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.RundschreibenmonatBindingSource.Filter = "erledigt = 1"
        Me.RundschreibenBindingSource1.Filter = "aktuell = 1"
        Me.RGVRundschreibenmonataktuell.ClearSelection()

        ' Button zum Eintragen der KW nur Anzeigen bei Hy und Adler
        If loginflag = 8 OrElse loginflag = 9 Then
            btnKWspeichern.Visible = True
        Else
            btnKWspeichern.Visible = False
        End If

        lblAktuellesDatum.Text = Date.Now.ToShortDateString

        Call Kalenderwoche()
        lblKW.Text = CStr(kw)
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
        ' werte in rundschreiben.gelöscht: 0 = nicht manuell gelöscht, 1 = manuell gelöscht
        If TabControl1.SelectedTab Is TabPage2 Then
            rsaktuellbezeichnung = String.Empty
            Me.RundschreibenmonatBindingSource.Filter = "erledigt = 2"
        ElseIf TabControl1.SelectedTab Is TabPage1 Then
            rsaktuellbezeichnung = String.Empty
            Me.RundschreibenBindingSource1.Filter = "aktuell = 1"
            Me.RundschreibenmonatBindingSource.Filter = "erledigt = 1"
            Me.RGVRundschreibenmonataktuell.ClearSelection()
        End If
    End Sub

    Private Sub RGVRundschreibenMonat_Click(sender As Object, e As EventArgs) Handles RGVRundschreibenMonat.Click
        Dim rsmonataktuell = DirectCast(DirectCast(Me.RundschreibenmonatBindingSource.Current, DataRowView).Row, rundschreibenmonatRow)
        rsaktuellbezeichnung = CStr(rsmonataktuell.monat)
        Me.RundschreibenBindingSource1.Filter = "aktuell = 0 AND nurhomepage = False AND gelöscht = 0 And bezeichnung = '" & rsaktuellbezeichnung & "'"
        Me.RGVBewerber.AutoSizeRows = True
        Me.RGVBewerber.Columns(14).WrapText = True
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
        Dim bewrundschreiben = BewerberDataSet.rundschreiben.Where(Function(x) x.bewid = bewerberid AndAlso x.aktuell = CInt(0) AndAlso x.gelöscht = 0).Select(Function(x) x.bezeichnung).Reverse.ToList

        ListBox1.DataSource = bewrundschreiben
    End Sub


    Private Sub RGVRundschreibenaktuell_Click(sender As Object, e As EventArgs) Handles RGVRundschreibenaktuell.Click
        Call Homepagecheck()
        Call Voreintraege()
        Call Rundschreibencheck()
    End Sub

    Private Sub RGVRundschreibenmonataktuell_Click(sender As Object, e As EventArgs) Handles RGVRundschreibenmonataktuell.Click
        Dim rsmonataktuell = DirectCast(DirectCast(Me.RundschreibenmonatBindingSource.Current, DataRowView).Row, rundschreibenmonatRow)
        rsaktuellbezeichnung = CStr(rsmonataktuell.monat)
    End Sub


    Private Sub RGVRundschreibenaktuell_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs) Handles RGVRundschreibenaktuell.CurrentRowChanged
        'Call Homepagecheck()
        'Call Voreintraege()
        'Call Rundschreibencheck()
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

    Private Sub btnSave_Rundschreiben_Click(sender As Object, e As EventArgs) Handles btnSave_Rundschreiben.Click, btnEintraegeloeschenunduebertragen.Click, btnRundschreibenaktuell_Close.Click, AufklappenRadMenuItem1.Click, EinklappenRadMenuItem1.Click, btnEintraegeloeschen.Click

        Select Case True
            Case sender Is btnSave_Rundschreiben
                Dim rundschreiben = DirectCast(DirectCast(RundschreibenBindingSource1.Current, DataRowView).Row, rundschreibenRow)
                If rbtnNein.Checked Then
                    rundschreiben.aktuell = CInt(0)
                    rundschreiben.gelöscht = CInt(1)
                    rundschreiben.rundschreibenjanein = False
                ElseIf rbtnJa.Checked Then
                    rundschreiben.aktuell = CInt(1)
                    rundschreiben.gelöscht = CInt(0)
                End If

                Me.Validate()
                Me.RundschreibenBindingSource1.EndEdit()
                Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)
                Call gespeichert()

            Case sender Is btnRundschreibenaktuell_Close
                Me.Close()

            Case sender Is btnEintraegeloeschenunduebertragen

                If rsaktuellbezeichnung = String.Empty Then
                    Dim result As DialogResult = MessageBox.Show("Bitte erst in der linken Spalte einen Eintrag anklicken.", "Eintrag auswählen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim rs = BewerberDataSet.rundschreiben.Where(Function(x) x.aktuell = 1 AndAlso x.bezeichnung = CStr(rsaktuellbezeichnung) AndAlso x.nurhomepage = False)

                    For Each x In rs
                        x.aktuell = CInt(0)
                    Next

                    Me.Validate()
                    Me.RundschreibenBindingSource1.EndEdit()
                    Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)

                    Dim rsmonat = BewerberDataSet.rundschreibenmonat.Where(Function(x) x.erledigt = 1 AndAlso x.monat = CStr(rsaktuellbezeichnung))
                    For Each x In rsmonat
                        x.erledigt = CInt(2)
                    Next

                    Me.Validate()
                    Me.RundschreibenmonatBindingSource.EndEdit()
                    Me.RundschreibenmonatTableAdapter.Update(Me.BewerberDataSet.rundschreibenmonat)
                    Call gespeichert()
                End If

            Case sender Is btnEintraegeloeschen
                Dim rsloeschen = BewerberDataSet.rundschreiben.Where(Function(x) x.bezeichnung = CStr(rsaktuellbezeichnung) And x.aktuell = 1 And x.gelöscht = 0)
                For Each x In rsloeschen
                    x.gelöscht = 1
                    x.aktuell = 0
                Next

                Me.Validate()
                Me.RundschreibenBindingSource1.EndEdit()
                Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)
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

    Private Sub Kalenderwoche()
        kw = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
    End Sub

    Private Sub btnKWspeichern_Click(sender As Object, e As EventArgs) Handles btnKWspeichern.Click

        Dim rundschreibenmonat = DirectCast(DirectCast(RundschreibenmonatBindingSource.Current, DataRowView).Row, rundschreibenmonatRow)

        Dim kwtext As String = String.Concat("Soll die Kalenderwoche ", CStr(kw), " für das Rundschreiben ", rundschreibenmonat.monat, " eingetragen werden?")
        Dim result As DialogResult = MessageBox.Show(kwtext, "Kalenderwoche eintragen", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            rundschreibenmonat.kw = kw
            Me.Validate()
            Me.RundschreibenBindingSource.EndEdit()
            Me.RundschreibenmonatTableAdapter.Update(Me.BewerberDataSet.rundschreibenmonat)
            Call gespeichert()
        End If
    End Sub
#End Region
End Class