Imports System.ComponentModel
Imports bewerberpool.oaDataSet
Imports bewerberpool.BewerberDataSet
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmKundeOA

    Public liste As New BindingList(Of String)() ' enthält die ausgewählten Einträge, Listbox wird daran gebunden

    Public werte As String = String.Empty

    Public Sub New(frmMain As frmMain)
        InitializeComponent()
    End Sub

    Private Sub frmKundeOA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BewerberDataSet = frmMain.BewerberDataSet
        Me.BewTableAdapter = frmMain.BewTableAdapter
        Me.BewBindingSource.DataSource = frmMain.BewBindingSource

        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberDataSet.bew". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        Me.Oa_kundeTableAdapter.Fill(Me.OaDataSet.oa_kunde)
        'Me.BewBindingSource.Filter = "id_bew = '" & letzteid & "'"
    End Sub

    Private Sub frmKundeOA_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call Voreintraege()
        lstOa_kunde_name.ClearSelected()
    End Sub

    Private Sub RGVOAkunde_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles RGVOAkunde.ViewCellFormatting
        Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

        If TypeOf e.CellElement Is GridHeaderCellElement Then
            e.CellElement.Font = newFont10
        Else
            e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    Private Sub RGVOAkunde_DoubleClick(sender As Object, e As EventArgs) Handles RGVOAkunde.DoubleClick
        Dim werte As String = String.Empty

        Dim oawerte = DirectCast(DirectCast(Oa_kundeBindingSource.Current, DataRowView).Row, oa_kundeRow)

        liste.Add(oawerte.oa_kunde_name)
        lstOa_kunde_name.DataSource = liste
    End Sub

    Private Sub lstOa_kunde_name_DoubleClick(sender As Object, e As EventArgs) Handles lstOa_kunde_name.DoubleClick
        liste.Remove(lstOa_kunde_name.SelectedItem.ToString)
    End Sub

    Private Sub Voreintraege()
        Dim kundenwerte = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        Dim lines() As String
        Dim eintraege As String = String.Empty

        If kundenwerte.IsfuerkundeNull OrElse kundenwerte.fuerkunde = String.Empty Then
            Exit Sub
        Else
            eintraege = CStr(kundenwerte.fuerkunde)

            lines = eintraege.Split(vbNewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)

            If lines.Count > 0 Then
                For Each item In lines
                    liste.Add(item)
                Next
                lstOa_kunde_name.DataSource = liste
            Else
                Exit Sub
            End If
        End If
    End Sub


    Private Sub btnWerteeintragenFensterschliessen_Click(sender As Object, e As EventArgs) Handles btnWerteeintragenFensterschliessen.Click, btnEintragloeschen.Click, btnCloseandDelete.Click

        Select Case True

            Case sender Is btnWerteeintragenFensterschliessen
                Dim bewerber = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)

                ' Kunde in BP speichern

                werte = String.Join(vbNewLine, liste)
                bewerber.fuerkunde = CStr(werte)
                'frmMain.txtFuerkunde.Text = CStr(werte)
                'Me.Validate()
                'Me.BewBindingSource.EndEdit()
                'Me.BewTableAdapter.Update(Me.BewerberDataSet.bew)

                ' MessageBox.Show("Bitte abspeichern, um die ausgewählten Stellen in die Datenbank zu übernehmen.", "Abspeichern", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Mail_kunde()
                Me.Close()

            Case sender Is btnEintragloeschen
                If lstOa_kunde_name.SelectedItems.Count = 0 Then
                    MessageBox.Show("Bitte erst einen Eintrag im Feld unter 2. auswählen", "Eintrag auswählen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    liste.Remove(lstOa_kunde_name.SelectedItem.ToString)
                End If

            Case sender Is btnCloseandDelete
                liste.Clear()
                werte = String.Empty
                Me.Close()
        End Select
    End Sub

    Private Sub Mail_kunde()
        If Not connectionString.Contains("127.0.0.1") AndAlso frmMain.txtFuerkunde.Text <> String.Empty Then
            Dim email As New Mail

            'Dim betreff As String = String.Concat(frmMain.VornameTextBox.Text, " ", frmMain.NameTextBox.Text, " wurde als grundsätzlich geeignet für einen Kunden: von ", usernameklar, " eingetragen.")

            Dim betreff As String = String.Concat("Bewerber wurden als grundsätzlich geeignet für einen Kunden: zuletzt von ", usernameklar, " eingetragen.")

            Dim bodytext As String = String.Concat(werte, " wurde/n als grundsätzlich geeignet für den/die Kunden: ", vbNewLine, vbNewLine, werte, vbNewLine, vbNewLine, "zuletzt von: ", usernameklar, " eingetragen.")

            email.receiver = "kontakt@heyduck-personalservice.de, thomasfuerst@heyduck-personalservice.de, assistenz@heyduck-zeitarbeit.de"
            email.subject = CStr(betreff)
            email.body = CStr(bodytext)
            email.send()
        End If
    End Sub

    Private Sub frmKundeOA_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Me.BewBindingSource.RemoveFilter()
    End Sub
End Class