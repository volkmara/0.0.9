Imports System.ComponentModel
Imports System.Text.RegularExpressions

Imports bewerberpool.BewerberDataSet
Imports Telerik.Collections.Generic

Public Class frmKurzfragebogen

    Private _frmMain As frmMain
    Public bewidneu As Integer = 0
    Public arbeitsart As String = String.Empty
    Public clicked As Boolean = False
    Private _frmInterviewer As frmInterviewer
    ' Public Shared Property Kurzfragebogen As Boolean = False ' notwendig, damit Inallentabellen.eintragen richtig funktioniert

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Sub New(frmInterviewer As frmInterviewer)
        _frmInterviewer = frmInterviewer
        InitializeComponent()
    End Sub


    Private Sub frmKurzfragebogen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call Timerreload.Reload() ' Timer für DB-Reload starten
    End Sub

    Private Sub frmKurzfragebogen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BewBindingSource.DataSource = frmMain.BewBindingSource
        Me.Bew_bewerberdatenBindingSource.DataSource = frmMain.Bew_bewerberdatenBindingSource

        frmMain.kurzfrage = True
        'Call Getbewid()
        'bewidneu = CInt(bewid + 1)
        Me.BewBindingSource.AddNew()
    End Sub

    Private Sub frmKurzfragebogen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtGeburtstag.Text = "TT.MM.JJJJ"
        Call Timerreload.Timerstop() ' Timer für DB-Reload stoppen
    End Sub

    Private Sub labelfarbe()
        For Each lbl In Me.GroupBox1.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next
    End Sub

    ' ======================================================================== Schritt 1: Neuen Bewerber anlegen ============================================================

    Private Sub btnNeuerBewerber_Click(sender As Object, e As EventArgs) Handles btnNeuerBewerber.Click
        ' Call ZAVM()
        Call Getbewid()
        bewidneu = CInt(bewid + 1)
        'Me.BewBindingSource.AddNew()
        Dim bewspeichern = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)

        If cmbStand.Text = "10" Then
            bewspeichern.stand = "10"
            bewspeichern.status = CStr("fertig")
        Else
            bewspeichern.stand = CStr("aktuell")
            bewspeichern.status = CStr("angelegt")
        End If
        bewspeichern.erstkontakt = Date.Now
        bewspeichern.refnr = bewidneu
        bewspeichern.Vermittlung = arbeitsart
        bewspeichern.topbewerber = CStr("Nein")
        ' bewspeichern.bewerberbeschreibung = CStr(allgemein.ExporttoRtf(RTEPersönlichkeit.Document))
        'bewspeichern.bewerberbeschreibung_text = CStr(allgemein.ExporttoTxt(RTEPersönlichkeit.Document))
        Me.Validate()
        Me.BewBindingSource.EndEdit()
        frmMain.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)

        Dim bewerberdaten = DirectCast(DirectCast(Me.Bew_bewerberdatenBindingSource.AddNew, DataRowView).Row, bew_bewerberdatenRow)
        bewerberdaten.id_bew = bewidneu
        bewerberdaten.rundschreiben = CStr(cmbRundschreiben.Text)
        bewerberdaten.staatsangehörigkeit = CStr(cmbStaatsangehörigkeit.Text)
        bewerberdaten.geburtstag = CStr(txtGeburtstag.Text)
        Me.Validate()
        Me.Bew_bewerberdatenBindingSource.EndEdit()
        frmMain.Bew_bewerberdatenTableAdapter.Update(frmMain.BewerberDataSet.bew_bewerberdaten)

        Call inallentabellen.eintragen()

        frmMain.DBLoad()
        Me.Panel2.Visible = True

        Call gespeichert()

        Dim resultmessage As String = String.Concat("Nachdem Sie eine/n neue/n Bewerber/in eingetragen haben, wird der Interviewerfragebogen aufgerufen, um die Einträge zu vervollständigen", vbNewLine, vbNewLine, "Wenn Sie Ihre Einträge jetzt vervollständigen wollen, klicken Sie bitte auf ""Ja"", wenn Sie das nicht wollen, klicken Sie bitte auf ""Nein"".")

        Dim result As DialogResult = MessageBox.Show(resultmessage, "Weitere Bearbeitung erforderlich", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = Windows.Forms.DialogResult.Yes Then
            frmMain.BewBindingSource.Filter = "id_bew = '" & bewid & "'"
            Using frm As New frmInterviewer(Me) ' erforderlich, damit STellen im Interviewerfragebogen direkt eingetragen werden können
                Dim result1 = frm.ShowDialog()
            End Using
            frmMain.DBSpeichern()
            Me.Close()
        ElseIf result = Windows.Forms.DialogResult.No Then
            Me.Close()
        End If
        'Me.Close()
    End Sub

    Private Function bewidcheck(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bew.Any(Function(rw) rw.id_bew = test)
    End Function

    ' ================================================================================ Validierungen =======================================================
    Private Sub cmbAnrede_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbAnrede.Validating, txtVorname.Validating, txtName.Validating, txtOrt.Validating, txtEmail.Validating, txtPlz.Validating

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
            'Case sender Is txtMonatsgehalt
            '    If txtMonatsgehalt.Text = String.Empty Then
            '        MessageBox.Show("Bitte das letzte Monatsgehalt (nur Ziffern) eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    End If
            'Case sender Is txtGehaltswunsch_monat
            '    If txtGehaltswunsch_monat.Text = String.Empty Then
            '        MessageBox.Show("Bitte das angestrebte Monatsgehalt (nur Ziffern) eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    End If
            Case sender Is txtOrt
                If txtOrt.Text = String.Empty Then
                    MessageBox.Show("Bitte den Wohnort eintragen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Case sender Is txtPlz
                If Not IsNumeric(txtPlz.Text) Then
                    ToolTip1.Show("Bitte tragen Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                ElseIf txtPlz.TextLength < 5 Then
                    ToolTip1.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                    'ElseIf txtPlz.Text = "" Then
                    '    ToolTip1.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
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

    Private Sub Za_vmTextBox_DoubleClick(sender As Object, e As EventArgs) Handles txtUlas.DoubleClick
        '    Select Case True
        '        Case sender Is txtZa_vm
        '            frmListboxen.zavm_bool = True
        '            Using frm = New frmListboxen(Me)
        '                Dim result = frm.ShowDialog()
        '            End Using
        '            txtZa_vm.Text = CStr(frmListboxen.zavm)
        '        Case sender Is txtUlas
        frmUlaseintragen.ulas_bool = True
        Using frm = New frmUlaseintragen(Me)
            Dim result = frm.ShowDialog(Me)
        End Using
        txtUlas.Text = CStr(frmUlaseintragen.ulas_wert)
        '    End Select
    End Sub


    Private Sub txtGeburtstag_Enter(sender As Object, e As EventArgs) Handles txtGeburtstag.Enter, cmbStaatsangehörigkeit.Enter
        Select Case True
            Case sender Is txtGeburtstag
                txtGeburtstag.Text = String.Empty
                ToolTip1.Show("Falls bekannt, das Geburtsdatum im Format dd.mm.jjjj eintragen.", CType(sender, Control), 1500)
            Case sender Is cmbStaatsangehörigkeit
                ToolTip1.Show("Falls bekannt, die Nationalität eintragen.", CType(sender, Control), 1500)
        End Select
    End Sub

    Private Sub frmKurzfragebogen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If MessageBox.Show("Wirklich beenden?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmKurzfragebogen_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.DBLoad()
    End Sub
End Class