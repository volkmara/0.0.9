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

    Private Sub btnWerteeintragenFensterschliessen_Click(sender As Object, e As EventArgs) Handles btnWerteeintragenFensterschliessen.Click
        werte = String.Join(vbNewLine, liste)

        Dim bewerber = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)

        ' Bewerber/in in OA speichern

        Dim bewerberinoa As String = String.Concat(bewerber.name, ", ", bewerber.vorname, " , RefNr.(BP): ", CStr(bewerber.refnr), " , Wohnort: ", bewerber.ort, vbNewLine)
        Dim oawerte = DirectCast(DirectCast(Oa_kundeBindingSource.Current, DataRowView).Row, oa_kundeRow)
        oawerte.oa_kunde_bewerber = CStr(bewerberinoa)

        Me.Validate()
        Me.Oa_kundeBindingSource.EndEdit()
        Me.Oa_kundeTableAdapter.Update(Me.OaDataSet.oa_kunde)

        ' Kunde in BP speichern

        frmMain.txtFuerkunde.Text = CStr(werte)
        bewerber.fuerkunde = CStr(werte)
        Me.Validate()
        Me.BewBindingSource.EndEdit()
        Me.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)

        Call gespeichert()
        Call Mail_kunde()
        Me.Close()
    End Sub

    Private Sub Mail_kunde()
        If Not connectionString.Contains("127.0.0.1") AndAlso frmMain.txtFuerkunde.Text <> String.Empty Then
            Dim email As New Mail

            Dim betreff As String = String.Concat(frmMain.VornameTextBox.Text, " ", frmMain.NameTextBox.Text, " wurde als grundsätzlich geeignet für einen Kunden: von ", usernameklar, " eingetragen.")

            Dim bodytext As String = String.Concat(frmMain.VornameTextBox.Text, " ", frmMain.NameTextBox.Text, " wurde als grundsätzlich geeignet für den/die Kunden: ", vbNewLine, vbNewLine, werte, vbNewLine, vbNewLine, "von: ", usernameklar, " eingetragen.")

            email.receiver = "kontakt@heyduck-personalservice.de, thomasfuerst@heyduck-personalservice.de, assistenz@heyduck-zeitarbeit.de"
            email.subject = CStr(betreff)
            email.body = CStr(bodytext)
            email.send()
        End If
    End Sub
End Class