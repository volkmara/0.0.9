Imports bewerberpool.BewerberDataSet

Public Class frmRundschreibendetail

    Public Shared rundschreibentext As String = String.Empty

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
        Me.RundschreibenTableAdapter.Fill(Me.BewerberDataSet.rundschreiben)
        Me.BewBindingSource.Filter = "id_bew = '" & letzteid & "'"
    End Sub

    Private Sub frmRundschreibenneu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Es wird das gesamte Dataset durchlaufen und alle Rows selektiert, die bei denen bewid = letzteid ist, dann werden alle Einträgen dieser Rows in der Cell "bezeichnung" in umgekehrter Reihenfolge in eine List of String geschrieben, die als Datasource an die Listbox gehängt wird

        Dim rundschreiben = BewerberDataSet.rundschreiben.Where(Function(x) x.bewid = letzteid AndAlso x.aktuell = 0 AndAlso x.gelöscht = 0).Select(Function(x) x.bezeichnung).Reverse

        Dim liste As New List(Of String)()
        For Each x In rundschreiben
            liste.Add(x.ToString)
        Next
        ListBox1.DataSource = liste

        If frmMain.HeyduckDataSet.tt_news.Any(Function(x) x.tx_ttnewserweiterung_referenznummer = CStr(letzteid)) Then
            chkHomepage.Checked = True
        Else
            chkHomepage.Checked = False
        End If

        Call Monateauslesen() ' Neue Monate eintragen

        ' Rundschreiben in Combobox eintragen; zuerst wird geprüft, ob die selektierte Bewerberid vorhanden ist, dann werden die bereits vorhandenen Bezeichnungen rauselektiert und von monatsliste subtrahiert, der Rest wird in cmbMonat eingetragen.

        'Dim monatsliste As String() = {"Februar 2019 (1)", "Februar 2019 (2)", "März 2019 (1)", "März 2019 (2)", "April 2019 (1)", "April 2019 (2)", "Mai 2019 (1)", "Mai 2019 (2)", "Juni 2019 (1)", "Juni 2019 (2)", "Juli 2019 (1)", "Juli 2019 (2)", "August 2019 (1)", "August 2019 (2)", "September 2019 (1)", "September 2019 (2)", "Oktober 2019 (1)", "Oktober 2019 (2)", "November 2019 (1)", "November 2019 (2)", "Dezember 2019 (1)", "Dezember 2019 (2)"}

        ''1. Wenn der ausgewählte Bewerber noch nie im RS war: Rundschreibenliste auslesen, bereits vergangene Monate und der Monat des letzten Rundschreibens werden rausselektiert

        '' id der letzten Rundschreibens
        'Dim letztermonatausgelesen As Integer = BewerberDataSet.rundschreiben.Select(Function(x) x.idrundschreibenmonat).LastOrDefault - 1

        '' Rundschreibenbezeichnungen

        'Dim monateausgelesen = BewerberDataSet.rundschreiben.Where(Function(x) x.aktuell = 0 AndAlso x.idrundschreibenmonat <= letztermonatausgelesen).Select(Function(x) x.bezeichnung).ToList.Distinct

        '    ' Das Array der Monate und die erstellte Monatsliste werden von einander subtrahiert
        '    Dim result = monatsliste.Except(monateausgelesen)
        '    For Each z In result
        '        cmbMonat.Items.Add(z)
        '    Next

        'Else

        '    ' Id des Rundschreibens, in dem ein Bewerber bereits im RS war
        '    Dim letztermonatausgelesen As Integer = BewerberDataSet.rundschreiben.Where(Function(x) x.bewid = letzteid).Select(Function(x) x.idrundschreibenmonat).LastOrDefault

        '    ' Liste der Rundschreibenbezeichnungen außer der letzten Bezeichnung
        '    Dim monatslisteausdb = BewerberDataSet.rundschreiben.Where(Function(x) x.idrundschreibenmonat <= letztermonatausgelesen).Select(Function(x) x.bezeichnung).Distinct.ToList

        '    ' Liste aller RS des Bewerbers
        '    Dim monateausgelesen = BewerberDataSet.rundschreiben.Where(Function(x) x.bewid = letzteid AndAlso x.aktuell = 0 AndAlso x.idrundschreibenmonat = letztermonatausgelesen).Select(Function(x) x.bezeichnung).ToList.Distinct ' Monate, in denen ein Bewerber im RS war, wird bewid = letzteid ausgelesen

        '    Dim result = monatsliste.Except(monateausgelesen) ' Inhalte von monatsliste abzüglich monateausgelesen wird in cmbMonat eingetragen
        '    Dim result1 = result.Except(monatslisteausdb)
        '    For Each z In result1
        '        cmbMonat.Items.Add(z)
        '    Next
        'End If
    End Sub

    ' In der Tabelle Rundschreiben sind alle Bewerber bzw. deren Ids gespeichert, die a) bereits im Rundschreiben waren oder b) für das Rundschreiben vorgesehen sind. Bei Bewerbern, die bereits im Rundschreiben war, wird die Rundschreibenbezeichnung eingetragen und aktuell = 0, bei für das Rundschreiben vorgesehenen Bewerbern wird keine Rundschreibenbezeichnung eingetragen und aktuell = 1 gesetzt. 

    ' Nach Aussendung des Rundschreibens werden über frmRundschreiben aktuell = 1 gesetzt und die Rundschreibenbezeichnung eingetragen. 

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnNewandSave.Click

        Select Case True
            Case sender Is btnClose
                Me.Close()

            Case sender Is btnNewandSave

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
                Me.Close()
        End Select
    End Sub

    Private Sub Monateauslesen() ' noch nicht versandte Rundschreibenmonate aus Tabelle "rundschreibenmonat" ermitteln

        'Dim monate = BewerberDataSet.rundschreibenmonat.Where(Function(x) x.erledigt = 1 OrElse x.erledigt = 0).Select(Function(x) x.monat).ToList.Distinct

        Dim monate = BewerberDataSet.rundschreibenmonat.Where(Function(x) x.erledigt < 2).Select(Function(x) x.monat).ToList.Distinct

        cmbMonat.Items.Clear()
        For Each x In monate
            cmbMonat.Items.Add(x)
        Next
    End Sub
End Class