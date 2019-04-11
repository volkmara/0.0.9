Imports System.Text.RegularExpressions

Imports bewerberpool.BewerberDataSet
Public Class frmKurzfragebogen

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmKurzfragebogen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call Timerreload.Reload() ' Timer für DB-Reload starten
    End Sub

    Private Sub frmKurzfragebogen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call frmMain.DBLoad()
        Call Timerreload.Timerstop() ' Timer für DB-Reload stoppen
    End Sub

    Private Sub labelfarbe()
        For Each lbl In Me.GroupBox1.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next
    End Sub

    ' ======================================================================== Schritt 1: Neuen Bewerber anlegen ============================================================

    Private Sub btnNeuerBewerber_Click(sender As Object, e As EventArgs) Handles btnNeuerBewerber.Click
        Dim warnungstext As String = CStr("Ein Eintrag mit dieser ID existiert bereits. Neueintragen nicht möglich. Die weitere Verarbeitung wurde abgebrochen.")

        ' Neuen Eintrag in Tabelle bew anlegen, die ID dieses Eintrags wird in id_bew in allen anderen Tabellen übernommen
        Call Getbewid()
        Dim bewidneu = CInt(bewid + 1)
        If Not bewidcheck(bewidneu) Then
            frmMain.BewBindingSource.AddNew()
            Dim bewspeichern = DirectCast(DirectCast(frmMain.BewBindingSource.Current, DataRowView).Row, bewRow)
            bewspeichern.anrede = CStr(AnredeComboBox.Text)
            bewspeichern.vorname = CStr(VornameTextBox.Text)
            bewspeichern.name = CStr(NameTextBox.Text)
            bewspeichern.stand = CStr("aktuell")
            bewspeichern.status = CStr("angelegt")
            bewspeichern.erstkontakt = Date.Now
            bewspeichern.plz = CInt(PlzTextBox.Text)
            bewspeichern.ort = CStr(OrtTextBox.Text)
            bewspeichern.strasse = CStr(StrasseTextBox.Text)
            bewspeichern.tel_festnetz = CStr(Tel_festnetzTextBox.Text)
            bewspeichern.tel_mobil = CStr(Tel_mobilTextBox.Text)
            bewspeichern.email = CStr(EmailTextBox.Text)
            bewspeichern.verfügbarkeit = CStr(VerfuegbarkeitComboBox.Text)
            bewspeichern.arbeitszeit = CStr(Vz_tzComboBox.Text)
            bewspeichern.monatsgehalt = CInt(MonatsgehaltTextBox.Text)
            bewspeichern.ausbildungsberuf = CStr(AusbildungsberufTextBox.Text)
            bewspeichern.Vermittlung = CStr(frmListboxen.zavm)
            bewspeichern.ulas = CStr(frmUlaseintragen.ulas_wert)
            bewspeichern.refnr = CInt(bewidneu)

            Me.Validate()
            '  frmMain.Validate()
            frmMain.BewBindingSource.EndEdit()
            frmMain.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)
            frmMain.DBLoad()

            Call inallentabellen.eintragen()
            Me.Panel2.Visible = True
            Me.Close()
        ElseIf bewidcheck(bewidneu) Then
            MessageBox.Show(warnungstext, "ID bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
            Me.Close()
        End If
    End Sub

    Private Function bewidcheck(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bew.Any(Function(rw) rw.id_bew = test)
    End Function

    ' ================================================================================ Validierungen =======================================================
    Private Sub AnredeComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AnredeComboBox.Validating, VornameTextBox.Validating, NameTextBox.Validating, MonatsgehaltTextBox.Validating, Gehaltswunsch_monatTextBox.Validating, OrtTextBox.Validating, PlzTextBox.Validating, EmailTextBox.Validating
        Select Case True
            Case sender Is AnredeComboBox
                '  If AnredeComboBox.SelectedText = String.Empty Then
                If AnredeComboBox.SelectedIndex = 0 Then
                    MessageBox.Show("Bitte eine Anrede eingeben", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is VornameTextBox
                If VornameTextBox.Text = String.Empty Then
                    MessageBox.Show("Bitte einen Vornamen eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is NameTextBox
                If NameTextBox.Text = String.Empty Then
                    MessageBox.Show("Bitte einen Nachnamen eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is MonatsgehaltTextBox
                If MonatsgehaltTextBox.Text = String.Empty Then
                    MessageBox.Show("Bitte das letzte Monatsgehalt (nur Ziffern) eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is Gehaltswunsch_monatTextBox
                If Gehaltswunsch_monatTextBox.Text = String.Empty Then
                    MessageBox.Show("Bitte das angestrebte Monatsgehalt (nur Ziffern) eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is OrtTextBox
                If OrtTextBox.Text = String.Empty Then
                    MessageBox.Show("Bitte den Wohnort eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is PlzTextBox
                If Not IsNumeric(PlzTextBox.Text) Then
                    ToolTip1.Show("Bitte tragen Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                ElseIf PlzTextBox.TextLength <= 4 Then
                    ToolTip1.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                ElseIf PlzTextBox.Text = "" Then
                    ToolTip1.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                End If
            Case sender Is EmailTextBox
                If EmailTextBox.Text.Trim = "" Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie Ihre Emailadresse an")
                    ToolTip1.Show("Bitte geben Sie eine Emailadresse ein. ", CType(sender, Control), 1500)
                    e.Cancel = True
                ElseIf Not ValidateEMail(EmailTextBox.Text) Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie eine korrekte Emailadresse an")
                    ToolTip1.Show("Bitte geben Sie eine korrekte Emailadresse ein. ", CType(sender, Control), 1500)
                    e.Cancel = True
                End If
        End Select
    End Sub
    ' =============================================================== Ende Schritt 1 ====================================================================

    ' =============================================================== Schritt 2: Daten ==================================================================

    ' `=============================================================== Ende Schritt 2 ==================================================================

    ' ================================================================ Validierungen ==================================================================

    ' Function zur Validierung einer Emailadresse
    Private Function ValidateEMail(ByVal pstrEMail As String) As Boolean
        Dim EmailRegex As System.Text.RegularExpressions.Regex _
         = New System.Text.RegularExpressions.Regex("[\w-]+@([\w-]+\.)+[\w-]+")

        Dim M As System.Text.RegularExpressions.Match = EmailRegex.Match(pstrEMail)
        Return M.Success
    End Function

    ' =================================================================== Ende Validierungen =============================================================

    Private Sub Za_vmTextBox_DoubleClick(sender As Object, e As EventArgs) Handles Za_vmTextBox.DoubleClick, UlasTextBox.DoubleClick
        Select Case True
            Case sender Is Za_vmTextBox
                frmListboxen.zavm_bool = True
                Using frm = New frmListboxen(Me)
                    Dim result = frm.ShowDialog()
                End Using
                Za_vmTextBox.Text = CStr(frmListboxen.zavm)
            Case sender Is UlasTextBox
                frmUlaseintragen.ulas_bool = True
                Using frm = New frmUlaseintragen(Me)
                    Dim result = frm.ShowDialog(Me)
                End Using
                UlasTextBox.Text = CStr(frmUlaseintragen.ulas_wert)
        End Select
    End Sub
End Class