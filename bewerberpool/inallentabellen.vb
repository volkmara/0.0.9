Imports MySql.Data.MySqlClient
Imports bewerberpool.BewerberDataSet
Public Class inallentabellen
    Public test As Boolean

    Public Shared Sub eintragen()

        Dim warnungstext_exixtiert As String = CStr("Ein Eintrag mit dieser ID existiert bereits. Die weitere Verarbeitung wurde abgebrochen.")

        Call Getbewid() ' Muss hier aufgerufen werden, um den letzten Eintrag in bew für die anderen Tabellen zu ermitteln

        If Not inassistenz(bewid) Then
            Dim assistenz = DirectCast(DirectCast(frmMain.Bew_assistenzBindingSource.AddNew, DataRowView).Row, bew_assistenzRow)
            assistenz.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bew_assistenzBindingSource.EndEdit()
            frmMain.Bew_assistenzTableAdapter.Update(frmMain.BewerberDataSet.bew_assistenz)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not frmMain.kurzfrage Then
            If Not inbewerberdaten(bewid) Then
                Dim bewerberdaten = DirectCast(DirectCast(frmMain.Bew_bewerberdatenBindingSource.AddNew, DataRowView).Row, bew_bewerberdatenRow)
                bewerberdaten.id_bew = CInt(bewid)
                frmMain.Validate()
                frmMain.Bew_bewerberdatenBindingSource.EndEdit()
                frmMain.Bew_bewerberdatenTableAdapter.Update(frmMain.BewerberDataSet.bew_bewerberdaten)
            Else
                MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If

        If Not inausbildung(bewid) Then
            Dim ausbildung = DirectCast(DirectCast(frmMain.Bewerber_ausbildungBindingSource.AddNew, DataRowView).Row, bewerber_ausbildungRow)
            ausbildung.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_ausbildungBindingSource.EndEdit()
            frmMain.Bewerber_ausbildungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_ausbildung)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inberufserfahrung(bewid) Then
            Dim berufserfahrung = DirectCast(DirectCast(frmMain.Bewerber_berufserfahrungBindingSource.AddNew, DataRowView).Row, bewerber_berufserfahrungRow)
            berufserfahrung.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_berufserfahrungBindingSource.EndEdit()
            frmMain.Bewerber_berufserfahrungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_berufserfahrung)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inedv(bewid) Then
            Dim edv = DirectCast(DirectCast(frmMain.Bewerber_edvBindingSource.AddNew, DataRowView).Row, bewerber_edvRow)
            edv.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_edvBindingSource.EndEdit()
            frmMain.Bewerber_edvTableAdapter.Update(frmMain.BewerberDataSet.bewerber_edv)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not insprachen(bewid) Then
            Dim sprachen = DirectCast(DirectCast(frmMain.Bewerber_sprachenBindingSource.AddNew, DataRowView).Row, bewerber_sprachenRow)
            sprachen.id_bew = CInt(bewid)
            sprachen.englisch = 0
            sprachen.englisch_interviewer = 0
            sprachen.franzoesisch = 0
            sprachen.französich_interviewer = 0
            sprachen.spanisch = 0
            sprachen.spanisch_interviewer = 0
            sprachen.italienisch = 0
            sprachen.italienisch_interviewer = 0
            sprachen.tuerkisch = 0
            sprachen.tuerkisch_interviewer = 0
            sprachen.niederlaendisch = 0
            sprachen.niederlaendisch_interviewer = 0
            sprachen.russisch = 0
            sprachen.russisch_interviewer = 0
            sprachen.deutsch = 0
            sprachen.deutsch_interviewer = 0
            frmMain.Validate()
            frmMain.Bewerber_sprachenBindingSource.EndEdit()
            frmMain.Bewerber_sprachenTableAdapter.Update(frmMain.BewerberDataSet.bewerber_sprachen)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inbibuha(bewid) Then
            Dim bibuha = DirectCast(DirectCast(frmMain.Bew_bibuhaBindingSource.AddNew, DataRowView).Row, bew_bibuhaRow)
            bibuha.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bew_bibuhaBindingSource.EndEdit()
            frmMain.Bew_bibuhaTableAdapter.Update(frmMain.BewerberDataSet.bew_bibuha)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inlug(bewid) Then
            Dim lug = DirectCast(DirectCast(frmMain.Bew_lugBindingSource.AddNew, DataRowView).Row, bew_lugRow)
            lug.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bew_lugBindingSource.EndEdit()
            frmMain.Bew_lugTableAdapter.Update(frmMain.BewerberDataSet.bew_lug)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not insteuerfachangestellte(bewid) Then
            Dim steuerfachangestellte = DirectCast(DirectCast(frmMain.Bew_steuerfachangestellteBindingSource.AddNew, DataRowView).Row, bew_steuerfachangestellteRow)
            steuerfachangestellte.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bew_steuerfachangestellteBindingSource.EndEdit()
            frmMain.Bew_steuerfachangestellteTableAdapter.Update(frmMain.BewerberDataSet.bew_steuerfachangestellte)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inbuero(bewid) Then
            Dim bureo = DirectCast(DirectCast(frmMain.Bewerber_bueroBindingSource.AddNew, DataRowView).Row, bewerber_bueroRow)
            bureo.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_bueroBindingSource.EndEdit()
            frmMain.Bewerber_bueroTableAdapter.Update(frmMain.BewerberDataSet.bewerber_buero)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not incontrolling(bewid) Then
            Dim controlling = DirectCast(DirectCast(frmMain.Bewerber_controllingBindingSource.AddNew, DataRowView).Row, bewerber_controllingRow)
            controlling.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_controllingBindingSource.EndEdit()
            frmMain.Bewerber_controllingTableAdapter.Update(frmMain.BewerberDataSet.bewerber_controlling)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not ineinkauf(bewid) Then
            Dim einkauf = DirectCast(DirectCast(frmMain.Bewerber_einkaufBindingSource.AddNew, DataRowView).Row, bewerber_einkaufRow)
            einkauf.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_einkaufBindingSource.EndEdit()
            frmMain.Bewerber_einkaufTableAdapter.Update(frmMain.BewerberDataSet.bewerber_einkauf)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not infibu(bewid) Then
            Dim fibu = DirectCast(DirectCast(frmMain.Bewerber_fibuBindingSource.AddNew, DataRowView).Row, bewerber_fibuRow)
            fibu.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_fibuBindingSource.EndEdit()
            frmMain.Bewerber_fibuTableAdapter.Update(frmMain.BewerberDataSet.bewerber_fibu)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not init(bewid) Then
            Dim it = DirectCast(DirectCast(frmMain.Bewerber_itBindingSource.AddNew, DataRowView).Row, bewerber_itRow)
            it.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_itBindingSource.EndEdit()
            frmMain.Bewerber_itTableAdapter.Update(frmMain.BewerberDataSet.bewerber_it)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inlogistik(bewid) Then
            Dim logistik = DirectCast(DirectCast(frmMain.Bewerber_logistikBindingSource.AddNew, DataRowView).Row, bewerber_logistikRow)
            logistik.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_logistikBindingSource.EndEdit()
            frmMain.Bewerber_logistikTableAdapter.Update(frmMain.BewerberDataSet.bewerber_logistik)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inmud(bewid) Then
            Dim mud = DirectCast(DirectCast(frmMain.Bewerber_marketing_designBindingSource.AddNew, DataRowView).Row, bewerber_marketing_designRow)
            mud.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_marketing_designBindingSource.EndEdit()
            frmMain.Bewerber_marketing_designTableAdapter.Update(frmMain.BewerberDataSet.bewerber_marketing_design)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inpersonal(bewid) Then
            Dim personal = DirectCast(DirectCast(frmMain.Bewerber_personalBindingSource.AddNew, DataRowView).Row, bewerber_personalRow)
            personal.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_personalBindingSource.EndEdit()
            frmMain.Bewerber_personalTableAdapter.Update(frmMain.BewerberDataSet.bewerber_personal)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inrae(bewid) Then
            Dim rae = DirectCast(DirectCast(frmMain.Bewerber_raeBindingSource.AddNew, DataRowView).Row, bewerber_raeRow)
            rae.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_raeBindingSource.EndEdit()
            frmMain.Bewerber_raeTableAdapter.Update(frmMain.BewerberDataSet.bewerber_rae)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not intechnik(bewid) Then
            Dim technik = DirectCast(DirectCast(frmMain.Bewerber_technikBindingSource.AddNew, DataRowView).Row, bewerber_technikRow)
            technik.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_technikBindingSource.EndEdit()
            frmMain.Bewerber_technikTableAdapter.Update(frmMain.BewerberDataSet.bewerber_technik)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inversand(bewid) Then
            Dim versand = DirectCast(DirectCast(frmMain.Bewerber_versandBindingSource.AddNew, DataRowView).Row, bewerber_versandRow)
            versand.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_versandBindingSource.EndEdit()
            frmMain.Bewerber_versandTableAdapter.Update(frmMain.BewerberDataSet.bewerber_versand)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not invertrieb(bewid) Then
            Dim vertrieb = DirectCast(DirectCast(frmMain.Bewerber_vertriebBindingSource.AddNew, DataRowView).Row, bewerber_vertriebRow)
            vertrieb.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.Bewerber_vertriebBindingSource.EndEdit()
            frmMain.Bewerber_vertriebTableAdapter.Update(frmMain.BewerberDataSet.bewerber_vertrieb)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not ingewerblich(bewid) Then
            Dim gewerblich = DirectCast(DirectCast(frmMain.GewerblichBindingSource.AddNew, DataRowView).Row, gewerblichRow)
            gewerblich.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.GewerblichBindingSource.EndEdit()
            frmMain.GewerblichTableAdapter.Update(frmMain.BewerberDataSet.gewerblich)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not inulas(bewid) Then
            Dim ulas = DirectCast(DirectCast(frmMain.UlasBindingSource.AddNew, DataRowView).Row, ulasRow)
            ulas.id_bew = CInt(bewid)
            frmMain.Validate()
            frmMain.UlasBindingSource.EndEdit()
            frmMain.UlasTableAdapter.Update(frmMain.BewerberDataSet.ulas)
        Else
            MessageBox.Show(warnungstext_exixtiert, "ID existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
    End Sub

    ' Es wird geprüft, ob in allen Tabellen die Ids korrekt und vollständig angelegt wurden; es wird die Variable letzteid verwendet, die durch Klick auf das Grid in frmMain ausgelesen wird
    Public Shared Sub prüfen()

        If Not inassistenz(letzteid) Then
            Dim assistenz = DirectCast(DirectCast(frmMain.Bew_assistenzBindingSource.AddNew, DataRowView).Row, bew_assistenzRow)
            assistenz.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bew_assistenzBindingSource.EndEdit()
            frmMain.Bew_assistenzTableAdapter.Update(frmMain.BewerberDataSet.bew_assistenz)
        End If

        If Not inbewerberdaten(letzteid) Then
            Dim bewerberdaten = DirectCast(DirectCast(frmMain.Bew_bewerberdatenBindingSource.AddNew, DataRowView).Row, bew_bewerberdatenRow)
            bewerberdaten.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bew_bewerberdatenBindingSource.EndEdit()
            frmMain.Bew_bewerberdatenTableAdapter.Update(frmMain.BewerberDataSet.bew_bewerberdaten)
        End If

        If Not inausbildung(letzteid) Then
            Dim ausbildung = DirectCast(DirectCast(frmMain.Bewerber_ausbildungBindingSource.AddNew, DataRowView).Row, bewerber_ausbildungRow)
            ausbildung.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_ausbildungBindingSource.EndEdit()
            frmMain.Bewerber_ausbildungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_ausbildung)
        End If

        If Not inberufserfahrung(letzteid) Then
            Dim berufserfahrung = DirectCast(DirectCast(frmMain.Bewerber_berufserfahrungBindingSource.AddNew, DataRowView).Row, bewerber_berufserfahrungRow)
            berufserfahrung.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_berufserfahrungBindingSource.EndEdit()
            frmMain.Bewerber_berufserfahrungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_berufserfahrung)
        End If

        If Not inedv(letzteid) Then
            Dim edv = DirectCast(DirectCast(frmMain.Bewerber_edvBindingSource.AddNew, DataRowView).Row, bewerber_edvRow)
            edv.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_edvBindingSource.EndEdit()
            frmMain.Bewerber_edvTableAdapter.Update(frmMain.BewerberDataSet.bewerber_edv)
        End If

        If Not insprachen(letzteid) Then
            Dim sprachen = DirectCast(DirectCast(frmMain.Bewerber_sprachenBindingSource.AddNew, DataRowView).Row, bewerber_sprachenRow)
            sprachen.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_sprachenBindingSource.EndEdit()
            frmMain.Bewerber_sprachenTableAdapter.Update(frmMain.BewerberDataSet.bewerber_sprachen)
        End If

        If Not inbibuha(letzteid) Then
            Dim bibuha = DirectCast(DirectCast(frmMain.Bew_bibuhaBindingSource.AddNew, DataRowView).Row, bew_bibuhaRow)
            bibuha.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bew_bibuhaBindingSource.EndEdit()
            frmMain.Bew_bibuhaTableAdapter.Update(frmMain.BewerberDataSet.bew_bibuha)
        End If

        If Not inlug(letzteid) Then
            Dim lug = DirectCast(DirectCast(frmMain.Bew_lugBindingSource.AddNew, DataRowView).Row, bew_lugRow)
            lug.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bew_lugBindingSource.EndEdit()
            frmMain.Bew_lugTableAdapter.Update(frmMain.BewerberDataSet.bew_lug)
        End If

        If Not insteuerfachangestellte(letzteid) Then
            Dim steuerfachangestellte = DirectCast(DirectCast(frmMain.Bew_steuerfachangestellteBindingSource.AddNew, DataRowView).Row, bew_steuerfachangestellteRow)
            steuerfachangestellte.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bew_steuerfachangestellteBindingSource.EndEdit()
            frmMain.Bew_steuerfachangestellteTableAdapter.Update(frmMain.BewerberDataSet.bew_steuerfachangestellte)
        End If

        If Not inbuero(letzteid) Then
            Dim bureo = DirectCast(DirectCast(frmMain.Bewerber_bueroBindingSource.AddNew, DataRowView).Row, bewerber_bueroRow)
            bureo.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_bueroBindingSource.EndEdit()
            frmMain.Bewerber_bueroTableAdapter.Update(frmMain.BewerberDataSet.bewerber_buero)
        End If

        If Not incontrolling(letzteid) Then
            Dim controlling = DirectCast(DirectCast(frmMain.Bewerber_controllingBindingSource.AddNew, DataRowView).Row, bewerber_controllingRow)
            controlling.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_controllingBindingSource.EndEdit()
            frmMain.Bewerber_controllingTableAdapter.Update(frmMain.BewerberDataSet.bewerber_controlling)
        End If

        If Not ineinkauf(letzteid) Then
            Dim einkauf = DirectCast(DirectCast(frmMain.Bewerber_einkaufBindingSource.AddNew, DataRowView).Row, bewerber_einkaufRow)
            einkauf.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_einkaufBindingSource.EndEdit()
            frmMain.Bewerber_einkaufTableAdapter.Update(frmMain.BewerberDataSet.bewerber_einkauf)
        End If

        If Not infibu(letzteid) Then
            Dim fibu = DirectCast(DirectCast(frmMain.Bewerber_fibuBindingSource.AddNew, DataRowView).Row, bewerber_fibuRow)
            fibu.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_fibuBindingSource.EndEdit()
            frmMain.Bewerber_fibuTableAdapter.Update(frmMain.BewerberDataSet.bewerber_fibu)
        End If

        If Not init(letzteid) Then
            Dim it = DirectCast(DirectCast(frmMain.Bewerber_itBindingSource.AddNew, DataRowView).Row, bewerber_itRow)
            it.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_itBindingSource.EndEdit()
            frmMain.Bewerber_itTableAdapter.Update(frmMain.BewerberDataSet.bewerber_it)
        End If

        If Not inlogistik(letzteid) Then
            Dim logistik = DirectCast(DirectCast(frmMain.Bewerber_logistikBindingSource.AddNew, DataRowView).Row, bewerber_logistikRow)
            logistik.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_logistikBindingSource.EndEdit()
            frmMain.Bewerber_logistikTableAdapter.Update(frmMain.BewerberDataSet.bewerber_logistik)
        End If

        If Not inmud(letzteid) Then
            Dim mud = DirectCast(DirectCast(frmMain.Bewerber_marketing_designBindingSource.AddNew, DataRowView).Row, bewerber_marketing_designRow)
            mud.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_marketing_designBindingSource.EndEdit()
            frmMain.Bewerber_marketing_designTableAdapter.Update(frmMain.BewerberDataSet.bewerber_marketing_design)
        End If

        If Not inpersonal(letzteid) Then
            Dim personal = DirectCast(DirectCast(frmMain.Bewerber_personalBindingSource.AddNew, DataRowView).Row, bewerber_personalRow)
            personal.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_personalBindingSource.EndEdit()
            frmMain.Bewerber_personalTableAdapter.Update(frmMain.BewerberDataSet.bewerber_personal)
        End If

        If Not inrae(letzteid) Then
            Dim rae = DirectCast(DirectCast(frmMain.Bewerber_raeBindingSource.AddNew, DataRowView).Row, bewerber_raeRow)
            rae.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_raeBindingSource.EndEdit()
            frmMain.Bewerber_raeTableAdapter.Update(frmMain.BewerberDataSet.bewerber_rae)
        End If

        If Not intechnik(letzteid) Then
            Dim technik = DirectCast(DirectCast(frmMain.Bewerber_technikBindingSource.AddNew, DataRowView).Row, bewerber_technikRow)
            technik.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_technikBindingSource.EndEdit()
            frmMain.Bewerber_technikTableAdapter.Update(frmMain.BewerberDataSet.bewerber_technik)
        End If

        If Not inversand(letzteid) Then
            Dim versand = DirectCast(DirectCast(frmMain.Bewerber_versandBindingSource.AddNew, DataRowView).Row, bewerber_versandRow)
            versand.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_versandBindingSource.EndEdit()
            frmMain.Bewerber_versandTableAdapter.Update(frmMain.BewerberDataSet.bewerber_versand)
        End If

        If Not invertrieb(letzteid) Then
            Dim vertrieb = DirectCast(DirectCast(frmMain.Bewerber_vertriebBindingSource.AddNew, DataRowView).Row, bewerber_vertriebRow)
            vertrieb.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.Bewerber_vertriebBindingSource.EndEdit()
            frmMain.Bewerber_vertriebTableAdapter.Update(frmMain.BewerberDataSet.bewerber_vertrieb)
        End If

        If Not ingewerblich(letzteid) Then
            Dim gewerblich = DirectCast(DirectCast(frmMain.GewerblichBindingSource.AddNew, DataRowView).Row, gewerblichRow)
            gewerblich.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.GewerblichBindingSource.EndEdit()
            frmMain.GewerblichTableAdapter.Update(frmMain.BewerberDataSet.gewerblich)
        End If

        If Not inulas(letzteid) Then
            Dim ulas = DirectCast(DirectCast(frmMain.UlasBindingSource.AddNew, DataRowView).Row, ulasRow)
            ulas.id_bew = CInt(letzteid)
            frmMain.Validate()
            frmMain.UlasBindingSource.EndEdit()
            frmMain.UlasTableAdapter.Update(frmMain.BewerberDataSet.ulas)
        End If
    End Sub


    ' Abfragen, ob bewid in Tabelle existiert
    Public Shared Function inassistenz(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bew_assistenz.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inbibuha(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bew_bibuha.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inbewerberdaten(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bew_bewerberdaten.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inausbildung(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_ausbildung.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inberufserfahrung(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_berufserfahrung.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inedv(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_edv.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function insprachen(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_sprachen.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inlug(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bew_lug.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inbuero(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_buero.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function incontrolling(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_controlling.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function ineinkauf(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_einkauf.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function infibu(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_fibu.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function init(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_it.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inlogistik(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_logistik.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inmud(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_marketing_design.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inpersonal(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_personal.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inrae(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_rae.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function intechnik(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_technik.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inversand(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_versand.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function invertrieb(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bewerber_vertrieb.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function ingewerblich(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.gewerblich.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function insteuerfachangestellte(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.bew_steuerfachangestellte.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inulas(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.ulas.Any(Function(rw) rw.id_bew = test)
    End Function
End Class
