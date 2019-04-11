Imports MySql.Data.MySqlClient
Imports bewerberpool.bewerberDataSet
Public Class frmNeuerBewerberanlegen

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

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
            bewspeichern.refnr = CInt(bewidneu)
            frmMain.Validate()
            frmMain.BewBindingSource.EndEdit()
            frmMain.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)

            ' Einträge in allen anderen Tabellen mit neuer bewid anlegen, das ist die ID des letzten Eintrags in Tabelle bew
            Call inallentabellen.eintragen()
            Me.Close()

        ElseIf bewidcheck(bewidneu) Then
            MessageBox.Show(warnungstext, "ID bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
            Me.Close()
        End If
        '  Me.Close()
    End Sub

    Private Sub frmNeuerBewerberanlegen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.DBLoad()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Function bewidcheck(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bew.Any(Function(rw) rw.id_bew = test)
    End Function

    Private Sub AnredeComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AnredeComboBox.Validating, VornameTextBox.Validating, NameTextBox.Validating
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
                    MessageBox.Show("Bitte einen Nachnamen eintragenausfüllen", "Pflichtfeld", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
        End Select
    End Sub
End Class