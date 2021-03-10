Imports bewerberpool.BewerberDataSet
Imports MySql.Data.MySqlClient

Public Class frmRundschreibendetail

    Public Shared rundschreibentext As String = String.Empty
    Public doppelt As Boolean = False
    Public doppeltpremium As Boolean = False

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmRundschreibenneu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.BewBindingSource.RemoveFilter()
    End Sub

    Private Sub frmRundschreibenneu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        Me.RundschreibenmonatTableAdapter.Fill(Me.BewerberDataSet.rundschreibenmonat)
        Me.RundschreibenpremiumTableAdapter.Fill(Me.BewerberDataSet.rundschreibenpremium)
        Me.RundschreibenpremiummonatTableAdapter.Fill(Me.BewerberDataSet.rundschreibenpremiummonat)
        Me.RundschreibenTableAdapter.Fill(Me.BewerberDataSet.rundschreiben)
        Me.BewBindingSource.Filter = "id_bew = '" & letzteid & "'"
    End Sub

    Private Sub frmRundschreibenneu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Es wird das gesamte Dataset durchlaufen und alle Rows selektiert, die bei denen bewid = letzteid ist, dann werden alle Einträgen dieser Rows in der Cell "bezeichnung" in umgekehrter Reihenfolge in eine List of String geschrieben, die als Datasource an die Listbox gehängt wird

        ' Einträge in Tabelle "rundschreiben und rundschreiben-premium jeweils: 0: war bereits mal im  RS - 1: ist für das aktuelle  RS vorgesehen - 

        Dim rundschreibennormal = BewerberDataSet.rundschreiben.Where(Function(x) x.bewid = letzteid AndAlso x.aktuell = 0 AndAlso x.gelöscht = 0).Select(Function(x) x.bezeichnung).Reverse

        Dim listersnormal As New List(Of String)()
        For Each x In rundschreibennormal
            listersnormal.Add(x.ToString)
        Next
        ListBox1.DataSource = listersnormal

        Dim rundschreibenpremium = BewerberDataSet.rundschreibenpremium.Where(Function(y) y.bewid = letzteid AndAlso y.aktuell = 0 AndAlso y.gelöscht = 0 AndAlso y.idrundschreibenpremium > 0).Select(Function(y) y.bezeichnung).Reverse

        Dim listerspremium As New List(Of String)()
        For Each y In rundschreibenpremium
            listerspremium.Add(y.ToString)
        Next
        ListBox2.DataSource = listerspremium

        If frmMain.HeyduckDataSet.tt_news.Any(Function(x) x.tx_ttnewserweiterung_referenznummer = CStr(letzteid)) Then
            chkHomepage.Checked = True
        Else
            chkHomepage.Checked = False
        End If

        Call Monateauslesen() ' Neue Monate eintragen
    End Sub

    ' In der Tabelle Rundschreiben sind alle Bewerber bzw. deren Ids gespeichert, die a) bereits im Rundschreiben waren oder b) für das Rundschreiben vorgesehen sind. Bei Bewerbern, die bereits im Rundschreiben war, wird die Rundschreibenbezeichnung eingetragen und aktuell = 0, bei für das Rundschreiben vorgesehenen Bewerbern wird keine Rundschreibenbezeichnung eingetragen und aktuell = 1 gesetzt. 

    ' Nach Aussendung des Rundschreibens werden über frmRundschreiben aktuell = 1 gesetzt und die Rundschreibenbezeichnung eingetragen. 

    'Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    'Select Case True
    'Case sender Is btnClose
    'Me.Close()

    '    Case sender Is btnNewandSave
    '        Call Doppelpruefen() ' Prüfung, ob nicht ein Bewerber bereits eingetragen wurde, was dem Dataset aber nicht bekannt ist

    '        If doppelt Then
    '            MessageBox.Show("Diese/r Bewerber/in wurde bereits eingetragen. Bitte schließen Sie das aktuelle Fenster und laden Sie ggf. die Daten neu.", "Bewerber/in bereits eingetragen", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '            Exit Sub
    '        Else
    '            ' Id des in der Combobox ausgewählten Monats ermitteln in der Tabelle "rundschreibenmonat" ermitteln
    '            Dim monat As Integer = 0
    '            Dim monatrundschreiben = BewerberDataSet.rundschreibenmonat.Where(Function(x) x.monat = cmbMonat.SelectedItem.ToString).Select(Function(x) x.idrundschreibenmonat)

    '            For Each x In monatrundschreiben
    '                monat = x
    '            Next

    '            ' Filter nach Monatsid auf Bindingsource der Tabelle "rundschreibenmonat" setzen, "1" eintragen, wenn ein Bewerber für einen Rundschreibenmonat eingetragen wird
    '            RundschreibenmonatBindingSource.Filter = "idrundschreibenmonat = '" & monat & "'"
    '            Dim rundschreibenmonat = DirectCast(DirectCast(RundschreibenmonatBindingSource.Current, DataRowView).Row, rundschreibenmonatRow)
    '            rundschreibenmonat.erledigt = 1

    '            Me.Validate()
    '            RundschreibenmonatBindingSource.EndEdit()
    '            RundschreibenmonatTableAdapter.Update(Me.BewerberDataSet.rundschreibenmonat)

    '            ' Daten in Tabelle "rundschreiben" eingetragen

    '            Dim rundschreiben = DirectCast(DirectCast(RundschreibenBindingSource.AddNew, DataRowView).Row, rundschreibenRow)
    '            rundschreiben.bewid = CInt(letzteid)
    '            rundschreiben.refnr = CInt(letzteid)
    '            rundschreiben.aktuell = CInt(1)
    '            rundschreiben.bezeichnung = CStr(Me.cmbMonat.SelectedItem)
    '            rundschreiben.idrundschreibenmonat = CInt(monat)
    '            rundschreiben.homepage = CInt(0)
    '            rundschreiben.anmerkungen = txtRundschreibenanmerkungen.Text
    '            rundschreiben.rundschreibenjanein = True
    '            rundschreiben.nurhomepage = False
    '            rundschreiben.gelöscht = CInt(0)

    '            Me.Validate()
    '            Me.RundschreibenBindingSource.EndEdit()
    '            Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)

    '            Call gespeichert()
    '        End If
    'End Select
    'End Sub

    Private Sub Monateauslesen() ' noch nicht versandte Rundschreibenmonate aus Tabelle "rundschreibenmonat"  und "rundschreibenmonatpremium ermitteln

        'Dim monate = BewerberDataSet.rundschreibenmonat.Where(Function(x) x.erledigt = 1 OrElse x.erledigt = 0).Select(Function(x) x.monat).ToList.Distinct

        Dim monate = BewerberDataSet.rundschreibenmonat.Where(Function(x) x.erledigt < 2).Select(Function(x) x.monat).ToList.Distinct
        Dim monatepremium = BewerberDataSet.rundschreibenpremiummonat.Where(Function(x) x.erledigt < 2).Select(Function(x) x.monat).ToList.Distinct

        cmbMonat.Items.Clear()
        For Each x In monate
            cmbMonat.Items.Add(x)
        Next

        cmbRSPremium.Items.Clear()
        For Each x In monatepremium
            cmbRSPremium.Items.Add(x)
        Next
    End Sub

    Private Sub Doppelpruefen()
        Dim rundschreibenmonat = cmbMonat.SelectedItem

        Dim query As String = "Select * From bewerberneu.rundschreiben where bewid = @letzteid and bezeichnung = @rundschreibenmonat and gelöscht = 0 and aktuell = 1;"
        Dim cnn As New MySqlConnection(connectionString)
        Using connection As New MySqlConnection(connectionString)
            Try
                cnn.Open()
                Dim command As New MySqlCommand(query, cnn)
                With command
                    .Parameters.AddWithValue("@letzteid", letzteid)
                    .Parameters.AddWithValue("@rundschreibenmonat", rundschreibenmonat)
                End With
                Dim reader As MySqlDataReader = command.ExecuteReader
                If reader.HasRows Then
                    doppelt = True
                Else doppelt = False
                End If
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DoppelpruefenPremium()
        Dim rundschreibenmonatpremium = cmbRSPremium.SelectedItem

        Dim query As String = "Select * From bewerberneu.rundschreibenpremium where bewid = @letzteid and bezeichnung = @rundschreibenmonat and gelöscht = 0 and aktuell = 1;"
        Dim cnn As New MySqlConnection(connectionString)
        Using connection As New MySqlConnection(connectionString)
            Try
                cnn.Open()
                Dim command As New MySqlCommand(query, cnn)
                With command
                    .Parameters.AddWithValue("@letzteid", letzteid)
                    .Parameters.AddWithValue("@rundschreibenmonat", rundschreibenmonatpremium)
                End With
                Dim reader As MySqlDataReader = command.ExecuteReader
                If reader.HasRows Then
                    doppeltpremium = True
                Else doppeltpremium = False
                End If
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnNewandSave_Click(sender As Object, e As EventArgs) Handles btnNewandSave.Click, btnPremium.Click, btnClose.Click
        Select Case True
            Case sender Is btnNewandSave
                Call RSnormalSpeichern()
            Case sender Is btnPremium
                Call RSPremiumspeichern()
            Case sender Is btnClose
                Me.Close()
        End Select
    End Sub

    Private Sub RSnormalSpeichern()
        Call Doppelpruefen() ' Prüfung, ob nicht ein Bewerber bereits eingetragen wurde, was dem Dataset aber nicht bekannt ist

        If cmbMonat.SelectedIndex = -1 Then
            MessageBox.Show("Bitte einen Termin für das normale Rundschreiben auswählen", "Termin auswählen", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        ElseIf doppelt Then
            MessageBox.Show("Diese/r Bewerber/in wurde bereits eingetragen. Bitte schließen Sie das aktuelle Fenster und laden Sie ggf. die Daten neu.", "Bewerber/in bereits eingetragen", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        Else
            ' Id des in der Combobox ausgewählten Monats ermitteln in der Tabelle "rundschreibenmonat" ermitteln
            Dim monat As Integer = 0
            Dim monatrundschreiben = BewerberDataSet.rundschreibenmonat.Where(Function(x) x.monat = cmbMonat.SelectedItem.ToString).Select(Function(x) x.idrundschreibenmonat)

            For Each x In monatrundschreiben
                monat = x
            Next

            ' Filter nach Monatsid auf Bindingsource der Tabelle "rundschreibenmonat" setzen, "1" eintragen, wenn ein Bewerber für einen Rundschreibenmonat eingetragen wird
            RundschreibenmonatBindingSource.Filter = "idrundschreibenmonat = '" & monat & "'"
            Dim rundschreibenmonat = DirectCast(DirectCast(RundschreibenmonatBindingSource.Current, DataRowView).Row, rundschreibenmonatRow)
            rundschreibenmonat.erledigt = 1

            Me.Validate()
            RundschreibenmonatBindingSource.EndEdit()
            RundschreibenmonatTableAdapter.Update(Me.BewerberDataSet.rundschreibenmonat)

            ' Daten in Tabelle "rundschreiben" eingetragen

            Dim rundschreiben = DirectCast(DirectCast(RundschreibenBindingSource.AddNew, DataRowView).Row, rundschreibenRow)
            rundschreiben.bewid = CInt(letzteid)
            rundschreiben.refnr = CInt(letzteid)
            rundschreiben.aktuell = CInt(1)
            rundschreiben.bezeichnung = CStr(Me.cmbMonat.SelectedItem)
            rundschreiben.idrundschreibenmonat = CInt(monat)
            rundschreiben.homepage = CInt(0)
            rundschreiben.anmerkungen = txtRundschreibenanmerkungen.Text
            rundschreiben.rundschreibenjanein = True
            rundschreiben.nurhomepage = False
            rundschreiben.gelöscht = CInt(0)

            Me.Validate()
            Me.RundschreibenBindingSource.EndEdit()
            Me.RundschreibenTableAdapter.Update(Me.BewerberDataSet.rundschreiben)
            Call gespeichert()
        End If
    End Sub

    Private Sub RSPremiumspeichern()
        Call DoppelpruefenPremium()

        If cmbRSPremium.SelectedIndex = -1 Then
            MessageBox.Show("Bitte einen Monat für das Premiumrundschreiben auswählen", "Monat auswählen", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        ElseIf doppeltpremium Then
            MessageBox.Show("Diese/r Bewerber/in wurde bereits eingetragen. Bitte schließen Sie das aktuelle Fenster und laden Sie ggf. die Daten neu.", "Bewerber/in bereits eingetragen", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            Dim monat As Integer = 0
            Dim premiumrundschreiben = BewerberDataSet.rundschreibenpremiummonat.Where(Function(x) x.monat = cmbRSPremium.SelectedItem.ToString).Select(Function(x) x.idrundschreibenpremiummonat)

            For Each x In premiumrundschreiben
                monat = x
            Next

            'Filter nach Monatsid auf Bindingsource der Tabelle "rundschreibenpremiummonat" setzen, "2" eintragen, wenn ein Premiumbewerber für einen Rundschreibenmonat eingetragen wird
            RundschreibenpremiummonatBindingSource.Filter = "idrundschreibenpremiummonat = '" & monat & "'"
            Dim rundschreibenmonat = DirectCast(DirectCast(RundschreibenpremiummonatBindingSource.Current, DataRowView).Row, rundschreibenpremiummonatRow)
            rundschreibenmonat.erledigt = 1

            Me.Validate()
            RundschreibenmonatBindingSource.EndEdit()
            RundschreibenmonatTableAdapter.Update(Me.BewerberDataSet.rundschreibenmonat)

            Dim rundschreibenpremium = DirectCast(DirectCast(RundschreibenpremiumBindingSource.AddNew, DataRowView).Row, rundschreibenpremiumRow)
            rundschreibenpremium.bewid = CInt(letzteid)
            rundschreibenpremium.refnr = CInt(letzteid)
            rundschreibenpremium.aktuell = CInt(1)
            rundschreibenpremium.bezeichnung = CStr(Me.cmbRSPremium.SelectedItem)
            rundschreibenpremium.idrundschreibenmonatpremium = CInt(monat)
            rundschreibenpremium.homepage = CInt(0)
            rundschreibenpremium.anmerkungen = txtRundschreibenanmerkungen.Text
            rundschreibenpremium.premiumrundschreibenjanein = True
            rundschreibenpremium.gelöscht = CInt(0)

            Me.Validate()
            Me.RundschreibenpremiumBindingSource.EndEdit()
            Me.RundschreibenpremiumTableAdapter.Update(Me.BewerberDataSet.rundschreibenpremium)
            Call gespeichert()
        End If
    End Sub

    Private Sub cmbMonat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonat.SelectedIndexChanged

        If cmbMonat.SelectedIndex > -1 Then
            btnNewandSave.Enabled = True
        Else
            btnNewandSave.Enabled = False
        End If
    End Sub

    Private Sub cmbRSPremium_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRSPremium.SelectedIndexChanged
        If cmbRSPremium.SelectedIndex > -1 Then
            btnPremium.Enabled = True
        ElseIf cmbRSPremium.SelectedIndex = -1 Then
            btnPremium.Enabled = False
        Else
            btnPremium.Enabled = False
        End If
    End Sub
End Class