Imports System.Text.RegularExpressions

Imports bewerberpool.BewerberDataSet
Public Class frmKurzfragebogen

    Private _frmMain As frmMain
    Public bewidneu As Integer = 0

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmKurzfragebogen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call Timerreload.Reload() ' Timer für DB-Reload starten
    End Sub

    Private Sub frmKurzfragebogen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Getbewid()
        bewidneu = CInt(bewid + 1)
        If Not bewidcheck(bewidneu) Then
            Me.BewBindingSource.AddNew()
            Me.Bew_bewerberdatenBindingSource.AddNew()
        ElseIf bewidcheck(bewidneu) Then
            Dim warnungstext As String = CStr("Ein Eintrag mit dieser ID existiert bereits. Neueintragen nicht möglich. Die weitere Verarbeitung wurde abgebrochen.")
            MessageBox.Show(warnungstext, "ID bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
            Me.Close()
        End If
    End Sub

    Private Sub frmKurzfragebogen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Call frmMain.DBLoad()
        Call Timerreload.Timerstop() ' Timer für DB-Reload stoppen
    End Sub

    Private Sub labelfarbe()
        For Each lbl In Me.GroupBox1.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next
    End Sub

    ' ======================================================================== Schritt 1: Neuen Bewerber anlegen ============================================================

    Private Sub btnNeuerBewerber_Click(sender As Object, e As EventArgs) Handles btnNeuerBewerber.Click
        Dim bewspeichern = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        Dim bewerberdaten = DirectCast(DirectCast(Me.Bew_bewerberdatenBindingSource.Current, DataRowView).Row, bew_bewerberdatenRow)
        bewspeichern.anrede = CStr(cmbAnrede.Text)
        bewspeichern.vorname = CStr(txtVorname.Text)
        bewspeichern.name = CStr(txtName.Text)
        bewspeichern.stand = CStr("aktuell")
        bewspeichern.status = CStr("angelegt")
        bewspeichern.erstkontakt = Date.Now
        bewspeichern.plz = CInt(txtPlz.Text)
        bewspeichern.ort = CStr(txtOrt.Text)
        bewspeichern.strasse = CStr(StrasseTextBox.Text)
        bewspeichern.tel_festnetz = CStr(txtTel_festnetz.Text)
        bewspeichern.tel_mobil = CStr(txtTel_mobil.Text)
        bewspeichern.email = CStr(txtEmail.Text)
        bewspeichern.verfügbarkeit = CStr(cmbVerfuegbarkeit.Text)
        bewspeichern.arbeitszeit = CStr(cmbVz_tz.Text)
        bewspeichern.monatsgehalt = CInt(txtMonatsgehalt.Text)
        bewspeichern.ausbildungsberuf = CStr(txtAusbildungsberuf.Text)
        bewspeichern.Vermittlung = CStr(txtZa_vm.Text)
        bewspeichern.ulas = CStr(txtUlas.Text)
        bewspeichern.refnr = CInt(bewidneu)
        bewspeichern.bewerberbeschreibung = CStr(allgemein.ExporttoRtf(RTEPersönlichkeit.Document))
        bewerberdaten.rundschreiben = CStr(cmbRundschreiben.Text)

        Me.Validate()
        Me.BewBindingSource.EndEdit()
        Me.BewTableAdapter.Update(Me.BewerberDataSet.bew)

        Me.Bew_bewerberdatenBindingSource.EndEdit()
        Me.Bew_bewerberdatenTableAdapter.Update(Me.BewerberDataSet.bew_bewerberdaten)

        Call inallentabellen.eintragen()
        frmMain.DBLoad()

        Me.Panel2.Visible = True
        Me.Close()
    End Sub

    Private Function bewidcheck(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bew.Any(Function(rw) rw.id_bew = test)
    End Function

    ' ================================================================================ Validierungen =======================================================
    Private Sub cmbAnrede_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbAnrede.Validating, txtVorname.Validating, txtName.Validating, txtMonatsgehalt.Validating, txtGehaltswunsch_monat.Validating, txtOrt.Validating, txtPlz.Validating, txtEmail.Validating
        Select Case True
            Case sender Is cmbAnrede
                '  If AnredeComboBox.SelectedText = String.Empty Then
                If cmbAnrede.SelectedIndex = 0 Then
                    MessageBox.Show("Bitte eine Anrede eingeben", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is txtVorname
                If txtVorname.Text = String.Empty Then
                    MessageBox.Show("Bitte einen Vornamen eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is txtName
                If txtName.Text = String.Empty Then
                    MessageBox.Show("Bitte einen Nachnamen eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is txtMonatsgehalt
                If txtMonatsgehalt.Text = String.Empty Then
                    MessageBox.Show("Bitte das letzte Monatsgehalt (nur Ziffern) eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is txtGehaltswunsch_monat
                If txtGehaltswunsch_monat.Text = String.Empty Then
                    MessageBox.Show("Bitte das angestrebte Monatsgehalt (nur Ziffern) eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is txtOrt
                If txtOrt.Text = String.Empty Then
                    MessageBox.Show("Bitte den Wohnort eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is txtPlz
                If Not IsNumeric(txtPlz.Text) Then
                    ToolTip1.Show("Bitte tragen Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                ElseIf txtPlz.TextLength <= 4 Then
                    ToolTip1.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                ElseIf txtPlz.Text = "" Then
                    ToolTip1.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                End If
            Case sender Is txtEmail
                If txtEmail.Text.Trim = "" Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie Ihre Emailadresse an")
                    ToolTip1.Show("Bitte geben Sie eine Emailadresse ein. ", CType(sender, Control), 1500)
                    e.Cancel = True
                ElseIf Not ValidateEMail(txtEmail.Text) Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie eine korrekte Emailadresse an")
                    ToolTip1.Show("Bitte geben Sie eine korrekte Emailadresse ein. ", CType(sender, Control), 1500)
                    e.Cancel = True
                End If
        End Select
    End Sub
    ' =============================================================== Ende Schritt 1 ====================================================================

    ' ================================================================ Validierungen ==================================================================

    ' Function zur Validierung einer Emailadresse
    Private Function ValidateEMail(ByVal pstrEMail As String) As Boolean
        Dim EmailRegex As System.Text.RegularExpressions.Regex _
         = New System.Text.RegularExpressions.Regex("[\w-]+@([\w-]+\.)+[\w-]+")

        Dim M As System.Text.RegularExpressions.Match = EmailRegex.Match(pstrEMail)
        Return M.Success
    End Function

    ' =================================================================== Ende Validierungen =============================================================

    Private Sub Za_vmTextBox_DoubleClick(sender As Object, e As EventArgs) Handles txtZa_vm.DoubleClick, txtUlas.DoubleClick
        Select Case True
            Case sender Is txtZa_vm
                frmListboxen.zavm_bool = True
                Using frm = New frmListboxen(Me)
                    Dim result = frm.ShowDialog()
                End Using
                txtZa_vm.Text = CStr(frmListboxen.zavm)
            Case sender Is txtUlas
                frmUlaseintragen.ulas_bool = True
                Using frm = New frmUlaseintragen(Me)
                    Dim result = frm.ShowDialog(Me)
                End Using
                txtUlas.Text = CStr(frmUlaseintragen.ulas_wert)
        End Select
    End Sub

End Class