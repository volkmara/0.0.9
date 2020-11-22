Imports Telerik.WinControls.UI.Localization
Imports Telerik.WinControls.RichTextEditor
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.Rtf
Imports Telerik.WinForms.Documents.FormatProviders.Txt
Imports Telerik.WinForms.RichTextEditor
Imports Telerik.WinForms.Documents.RichTextBoxCommands
Imports bewerberpool.BewerberDataSet
Imports Telerik.WinControls.UI

Public Class frmInterviewer

    Public pflichtfeldliste As String = String.Empty
    ' Public pflichtfeldlistebeistart As String = String.Empty

    Public ulas As String = String.Empty
    Public exportfilertf As String = String.Empty
    Public exportfiletxt As String = String.Empty
    Public importfilertf As String = String.Empty
    Private _frmMain As frmMain
    Private _frmOA As frmOA
    Private _frmKurzfragebogen As frmKurzfragebogen

    Public sprachenliste As String = String.Empty
    Public edvliste As String = String.Empty
    Public ausbildungstudium As String = String.Empty
    Public aufmerksam As String = String.Empty

    Public tabpagecount As Integer = CInt(0)

    Sub New(frmMain As frmMain)
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Sub New(frmOA As frmOA)
        _frmOA = frmOA
        InitializeComponent()
    End Sub

    Sub New(frmKurzfragebogen As frmKurzfragebogen)
        _frmKurzfragebogen = frmKurzfragebogen
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
    End Sub

    Private Sub frmInterviewer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call Timerreload.Reload() ' Timer für DB-Reload starten
    End Sub

    Private Sub frmInterviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberDataSet.bewerber_edv". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_edvTableAdapter.Fill(Me.BewerberDataSet.bewerber_edv)
        ' Die Bindingsources dieser Form werden umgestöpselt auf die Bindingsources von frmMain
        Me.BewBindingSource.DataSource = frmMain.BewBindingSource.Current ' muss bewbindingsource.current sein, damit der richtige Bewerber in den Interviewerfragebogen geladen wird
        Me.Bew_bewerberdatenBindingSource.DataSource = frmMain.Bew_bewerberdatenBindingSource
        Me.Bewerber_ausbildungBindingSource.DataSource = frmMain.Bewerber_ausbildungBindingSource
        Me.Bewerber_berufserfahrungBindingSource.DataSource = frmMain.Bewerber_berufserfahrungBindingSource
        Me.Bewerber_sprachenBindingSource.DataSource = frmMain.Bewerber_sprachenBindingSource
        Me.UlasBindingSource.DataSource = frmMain.UlasBindingSource
        Me.Bewerber_edvBindingSource.DataSource = frmMain.Bewerber_edvBindingSource
        Call Timerreload.Timerstop() ' Timer für DB-Reload stoppen
    End Sub

    Private Sub frmInterviewer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call labelfarbe()
        Call import()
        Call Comboboxfill()
        pflichtfeldliste = String.Empty
        'sprachenliste = String.Empty

        Dim bewdaten = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        Label7.Text = String.Concat(bewdaten.anrede, " ", bewdaten.vorname, " ", bewdaten.name)

        frmOA.vorschlagenfuerstelle_interviewer_bool = False

        Me.cmbAufmerksam.Items.AddRange(New String() {"Agentur für Arbeit", "backinjob", "Gigajob", "Indeed", "Jobmonitor", "Jobomat", "Join", "Kalaydo", "meinestadt", "Monster", "Placement24", "Rekruter", "stellenmarkt", "Stepstone", " ", "Facebook", "Twitter", "Xing", "Google", "Bing", "Yahoo", "Web.de", " ", "Homepage", " ", "Bonner Generalanzeiger", "Kölner Stadtanzeiger", "Rhein-Sieg-Anzeiger", "Regionale Anzeigenblätter", " ", "andere"})

        Call PflichtfelderbeiStart()
    End Sub

    Private Sub cmbAnrede_Mousewheel(sender As Object, e As MouseEventArgs) Handles cmbAnrede.MouseWheel, cmbBeurteilung.MouseWheel, cmbHaendedruck.MouseWheel, cmbParfum.MouseWheel, cmbRaucher.MouseWheel, cmbVz_tz.MouseWheel, cmbTeilzeit_stunden.MouseWheel, cmbTeilzeit_wann.MouseWheel, cmbUmzug.MouseWheel, cmbVerfuegbarkeit.MouseWheel, cmbMdE.MouseWheel, KuendigungsfristComboBox.MouseWheel, BeendigungsgrundComboBox.MouseWheel, cmbPersonalverantwortung.MouseWheel, cmbFuehrungsverantwortung.MouseWheel, cmbAuslandsaufenthalt.MouseWheel, cmbEnglisch_interviewer.MouseWheel, cmbFranzösich_interviewer.MouseWheel, cmbSpanisch_interviewer.MouseWheel, cmbItalienisch_interviewer.MouseWheel, cmbRussisch_interviewer.MouseWheel, cmbNiederlaendisch_interviewer.MouseWheel, cmbTuerkisch_interviewer.MouseWheel, cmbDeutsch_interviewer.MouseWheel
        Dim HMEA As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        HMEA.Handled = True
    End Sub

    Private Sub export()
        Dim providerrtf As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        Dim providertxt As New Telerik.WinForms.Documents.FormatProviders.Txt.TxtFormatProvider()

        '  Dim exportfilertf As String = String.Empty
        exportfilertf = allgemein.ExporttoRtf(Me.RTEPersoenlichkeit.Document)
        exportfiletxt = allgemein.ExporttoTxt(Me.RTEPersoenlichkeit.Document)

    End Sub

    Private Sub import()
        Dim providerrtf As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()

        Dim bewdaten = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        If bewdaten.IsbewerberbeschreibungNull OrElse bewdaten.bewerberbeschreibung = String.Empty Then
            Exit Sub
        Else
            importfilertf = CStr(bewdaten.bewerberbeschreibung)
            Me.RTEPersoenlichkeit.Document = providerrtf.Import(importfilertf)
        End If
    End Sub

#Region "Buttons"
    Private Sub btnUebernehmen_Click(sender As Object, e As EventArgs) Handles btnUebernehmen.Click
        Call export()
        Call telefoneintrag()
        Call Sprachendaten() ' trägt Sprachen im Feld "Sprachkenntnisse" im Reiter "Bewerber/in" ein
        Call Edvdaten() ' EDVkenntnisse für Feld EDVkenntnisse im Reiter Bewerber/in
        Call Ausbildungsdaten() ' Ausbildung, Qualifizierungen, Studium, Abschluss kumuliert
        Call aufmerksamliste()

        ' Validierung vorm Speichern
        If Not frmMain.StandComboBox.Text = CStr("fertig") AndAlso TabControl1.SelectedTab IsNot TabPage7 Then
            MessageBox.Show("Bitte alle Reiter nacheinander anklicken und die Felder in allen Reitern bearbeiten", "Alle Tabreiter anwählen", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Call Controlsaufweiss() ' Alle Controls, die beim Startcheck gelb gefärbt wurden, zurücksetzen
        Call Berufsausbildung_check()

        If Not frmMain.StandComboBox.Text = CStr("fertig") Then
            Call pflichtfelder()
        End If

        Dim result As DialogResult = MessageBox.Show("Einträge übernehmen?", "Einträge übernehmen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then

            ' OpenFD für Originalunterlagen öffnen

            If connectionString.Contains("127.0.0.1") Then
                verzeichnis = CStr("e:\heyduck\ulas\")
            Else
                verzeichnis = CStr("x:\ulas\")
            End If
            Dim zielverzeichnis As String = String.Concat(verzeichnis, letzteid, "\", "Originale", "\")

            Dim abspeichern As String = String.Concat("Sie können jetzt die Originalunterlagen des Bewerbers/der Bewerberin abspeichern.", vbNewLine, vbNewLine, "Weitere Dateien können ggf. später über das Feld ""Originalunterlagen Bewerber/in"" im Reiter ""Daten"" hochgeladen werden (Rechtsklick).")

            If Not IO.Directory.Exists(zielverzeichnis) Then
                Dim result1 As DialogResult = MessageBox.Show(CStr(abspeichern), "Unterlagen speichern", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
                If result1 = Windows.Forms.DialogResult.Yes Then
                    Call ulasspeichern.originalulasspeichern()
                ElseIf result1 = Windows.Forms.DialogResult.No Then
                    Me.Close()
                End If
            Else
                Dim ulasprüfen As String = String.Concat("Das Verzeichnis für Originalunterlagen dieses Bewerbers/dieser Bewerberin existiert bereits. Bitte überprüfen Sie die Unterlagen. ", vbNewLine, vbNewLine, "Vorhandene Unterlagen können ggf. später über das Feld ""Originalunterlagen Bewerber/in"" im Reiter ""Daten"" überschrieben werden (Rechtsklick)")
                MessageBox.Show(ulasprüfen, "Verzeichnis vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' Wird geschlossen, wenn origulas (=> wenn zielverzeichnis existiert) bereits vorhanden sind
            End If

            Dim interviewer = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
            interviewer.status = CStr("fertig")

            If Not cmbVerfuegbarkeit.SelectedIndex = 2 Then
                interviewer.verfügbarkeit = cmbVerfuegbarkeit.Text
                'MsgBox(cmbVerfuegbarkeit.Text)
            Else
                interviewer.verfügbarkeit = txtVerfuegbarkeitindividuell.Text
                'MsgBox(txtVerfuegbarkeitindividuell.Text)
            End If

            'interviewer.interviewart = CStr("Bewerbergespräch")
            interviewer.geaendert_am = Date.Now.ToString
            interviewer.letztbearbeitung_von = CStr(usernameklar)
            interviewer.bewerberbeschreibung = CStr(exportfilertf)
            interviewer.bewerberbeschreibung_text = CStr(exportfiletxt)
            interviewer.sprachkenntnisse = CStr(sprachenliste)
            If Not frmXmleinlesen.xmlbool AndAlso edvliste <> String.Empty Then ' erforderlich, damit Einträge nicht überschrieben werden, wenn zuvor eine xmldatei eingelesen wurde
                interviewer.edvkenntnisse = edvliste
            End If
            'interviewer.ausbildungsberuf = txtAusbildungsberuf.Text
            interviewer.ausbildungsberuf = ausbildungstudium
            interviewer.aufmerksam = aufmerksam

            ' Me.Validate()

            Dim text As String = String.Concat("Die Einträge aus dem Interviewerfragebogen werden automatisch in die DB geschrieben, wenn sich der Interviewerfragebogen geschlossen hat.", vbNewLine, vbNewLine)

                MessageBox.Show(text, "Fertig", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Einträge aus Interviewerfragebogen in DB speichern bei Close
                Me.Validate()
                Me.BewBindingSource.EndEdit()
                Me.Bew_bewerberdatenBindingSource.EndEdit()
                Me.Bewerber_ausbildungBindingSource.EndEdit()
                Me.Bewerber_berufserfahrungBindingSource.EndEdit()
                Me.Bewerber_sprachenBindingSource.EndEdit()
                Me.Bewerber_edvBindingSource.EndEdit()
                Me.UlasBindingSource.EndEdit()

                frmMain.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)
                frmMain.Bew_bewerberdatenTableAdapter.Update(frmMain.BewerberDataSet.bew_bewerberdaten)
                frmMain.UlasTableAdapter.Update(frmMain.BewerberDataSet.ulas)
                frmMain.Bewerber_ausbildungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_ausbildung)
                frmMain.Bewerber_berufserfahrungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_berufserfahrung)
                frmMain.Bewerber_sprachenTableAdapter.Update(frmMain.BewerberDataSet.bewerber_sprachen)
                frmMain.Bewerber_edvTableAdapter.Update(frmMain.BewerberDataSet.bewerber_edv)

                Call gespeichert()

                frmMain.GroupBox1.BackColor = Color.WhiteSmoke

                frmMain.BewBindingSource.RemoveFilter() ' im Kurzfragebogen wurde ein Filter auf die Bindingsource von bewBindingSource gesetzt, der hier entfernt werden muss

                Me.Close()

            ElseIf result = Windows.Forms.DialogResult.No Then
                frmMain.BewBindingSource.RemoveFilter() ' im Kurzfragebogen wurde ein Filter auf die Bindingsource von bewBindingSource gesetzt, der hier entfernt werden muss
            Exit Sub
        End If
    End Sub
#End Region

    Private Sub Sprachendaten()

        Dim bewerbersprachen = DirectCast(DirectCast(Me.Bewerber_sprachenBindingSource.Current, DataRowView).Row, bewerber_sprachenRow)
        Dim sprachenbew = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        Dim sprachen As New List(Of String)()

        If bewerbersprachen.deutsch_interviewer > 0 Then
            sprachen.Add(String.Concat("D ", bewerbersprachen.deutsch_interviewer.ToString))
            sprachenbew.deutsch = bewerbersprachen.deutsch_interviewer
            sprachenbew.deutsch_bew = bewerbersprachen.deutsch
        ElseIf bewerbersprachen.deutsch <> 0 Then
            sprachenbew.deutsch_bew = bewerbersprachen.deutsch
            sprachen.Add(String.Concat("D ", bewerbersprachen.deutsch.ToString))
        End If

        If bewerbersprachen.englisch_interviewer > 0 Then
            sprachen.Add(String.Concat("E ", bewerbersprachen.englisch_interviewer.ToString))
            sprachenbew.englisch = bewerbersprachen.englisch_interviewer
            sprachenbew.englisch_bew = bewerbersprachen.englisch
        ElseIf bewerbersprachen.englisch <> 0 Then
            sprachen.Add(String.Concat("E ", bewerbersprachen.englisch.ToString))
            sprachenbew.englisch_bew = bewerbersprachen.englisch
        End If

        If bewerbersprachen.französich_interviewer > 0 Then
            sprachen.Add(String.Concat("F ", bewerbersprachen.französich_interviewer.ToString))
            sprachenbew.franzoesisch = bewerbersprachen.französich_interviewer
            sprachenbew.franzoesich_bew = bewerbersprachen.franzoesisch
        ElseIf bewerbersprachen.franzoesisch <> 0 Then
            sprachen.Add(String.Concat("F ", bewerbersprachen.franzoesisch.ToString))
            sprachenbew.franzoesisch = bewerbersprachen.franzoesisch
        End If

        If bewerbersprachen.spanisch_interviewer > 0 Then
            sprachen.Add(String.Concat("S ", bewerbersprachen.spanisch_interviewer.ToString))
            sprachenbew.spanisch = bewerbersprachen.spanisch_interviewer
            sprachenbew.spanisch_bew = bewerbersprachen.spanisch
        ElseIf bewerbersprachen.spanisch <> 0 Then
            sprachen.Add(String.Concat("S ", bewerbersprachen.spanisch.ToString))
            sprachenbew.spanisch_bew = bewerbersprachen.spanisch
        End If

        If bewerbersprachen.italienisch_interviewer > 0 Then
            sprachen.Add(String.Concat("I ", bewerbersprachen.italienisch_interviewer.ToString))
            sprachenbew.italienisch = bewerbersprachen.italienisch_interviewer
            sprachenbew.italienisch_bew = bewerbersprachen.italienisch
        ElseIf bewerbersprachen.italienisch <> 0 Then
            sprachen.Add(String.Concat("I ", bewerbersprachen.italienisch.ToString))
            sprachenbew.italienisch_bew = bewerbersprachen.italienisch
        End If

        If bewerbersprachen.niederlaendisch_interviewer > 0 Then
            sprachen.Add(String.Concat("N ", bewerbersprachen.niederlaendisch_interviewer.ToString))
            sprachenbew.niederlaendisch = bewerbersprachen.niederlaendisch_interviewer
            sprachenbew.niederlaendisch_bew = bewerbersprachen.niederlaendisch
        ElseIf bewerbersprachen.niederlaendisch <> 0 Then
            sprachen.Add(String.Concat("N ", bewerbersprachen.niederlaendisch.ToString))
            sprachenbew.niederlaendisch_bew = bewerbersprachen.niederlaendisch
        End If

        If bewerbersprachen.tuerkisch_interviewer > 0 Then
            sprachen.Add(String.Concat("T ", bewerbersprachen.tuerkisch_interviewer.ToString))
            sprachenbew.tuerkisch = bewerbersprachen.tuerkisch_interviewer
            sprachenbew.tuerkisch_bew = bewerbersprachen.tuerkisch
        ElseIf bewerbersprachen.tuerkisch <> 0 Then
            sprachen.Add(String.Concat("T ", bewerbersprachen.tuerkisch.ToString))
            sprachenbew.tuerkisch_bew = bewerbersprachen.tuerkisch
        End If

        If bewerbersprachen.russisch_interviewer > 0 Then
            sprachen.Add(String.Concat("R ", bewerbersprachen.russisch_interviewer.ToString))
            sprachenbew.russisch = bewerbersprachen.russisch_interviewer
            sprachenbew.russisch_bew = bewerbersprachen.russisch
        ElseIf bewerbersprachen.russisch <> 0 Then
            sprachen.Add(String.Concat("R ", bewerbersprachen.russisch.ToString))
            sprachenbew.russisch_bew = bewerbersprachen.russisch
        End If

        sprachenliste = String.Join(vbNewLine, sprachen) ' Sprachenliste ist Public
    End Sub

    Private Sub Edvdaten()
        If Not frmXmleinlesen.xmlbool Then ' erforderlich, damit Einträge nicht überschrieben werden, wenn zuvor eine xmldatei eingelesen wurde
            ' Dim bewerberedv = DirectCast(DirectCast(Me.Bewerber_edvBindingSource.Current, DataRowView).Row, bewerber_edvRow)
            'Dim bewedv = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
            Dim edv As New List(Of String)()
            Dim edvcmb As String

            If cmbWord.SelectedIndex > 0 Then
                edv.Add("Word")
            End If

            If cmbExcel.SelectedIndex > 0 Then
                edv.Add("Excel")
            End If

            If cmbPowerpoint.SelectedIndex > 0 Then
                edv.Add("Powerpoint")
            End If

            If cmbOutlook.SelectedIndex > 0 Then
                edv.Add("Outlook")
            End If

            If cmbAccess.SelectedIndex > 0 Then
                edv.Add("Access")
            End If

            If cmbProject.SelectedIndex > 0 Then
                edv.Add("Project")
            End If

            If cmbThunderbird.SelectedIndex > 0 Then
                edv.Add("Thunderbird")
            End If

            If cmbLotus_notes.SelectedIndex > 0 Then
                edv.Add("Lotus Notes")
            End If

            If cmbSAP.SelectedIndex > 0 Then
                edv.Add("SAP")
            End If

            If cmbDatev.SelectedIndex > 0 Then
                edv.Add("Datev")
            End If

            If cmbDatevpro.SelectedIndex > 0 Then
                edv.Add("Datevpro")
            End If

            If cmbMicrosoft_dynamics.SelectedIndex > 0 Then
                edv.Add("Microsoft Dynamics")
            End If

            If cmbMicrosoft_navision.SelectedIndex > 0 Then
                edv.Add("Microsoft Navision")
            End If

            If cmbAS400.SelectedIndex > 0 Then
                edv.Add("AS 400")
            End If

            If cmbKhksage.SelectedIndex > 0 Then
                edv.Add("KHK Sage")
            End If

            If cmbLexware.SelectedIndex > 0 Then
                edv.Add("Lexware")
            End If

            If cmbAmadeus.SelectedIndex > 0 Then
                edv.Add("Amadeus")
            End If

            'edvliste = String.Join(vbNewLine, edv)
            edvcmb = String.Join(", ", edv)
            edvcmb = String.Concat(edvcmb, ", ")

            edvliste = String.Concat(edvcmb, txtSoftware_sonstige.Text.TrimEnd(CChar(","))) ' wird im Hauptfenster angezeigt nach Speicherung in der DB
        End If
    End Sub

    Private Sub Ausbildungsdaten()
        ausbildungstudium = String.Concat(txtAusbildungsberuf.Text, vbNewLine, txtAusbildung_qualifizierung.Text, vbNewLine, txtStudienfaecher.Text, vbNewLine, txtStudium_abschluss.Text)
    End Sub

    Private Sub aufmerksamliste()

        If txtEmpfehlung.Text <> String.Empty Then
            aufmerksam = String.Concat(cmbAufmerksam.Text, ", ", "Empfohlen von: ", txtEmpfehlung.Text)
        Else
            aufmerksam = cmbAufmerksam.Text
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmMain.BewBindingSource.RemoveFilter() ' im Kurzfragebogen wurde ein Filter auf die Bindingsource von bewBindingSource gesetzt, der hier entfernt werden muss
        Me.Close()
    End Sub



    ' ========================================================================= Pflichtfelder =============================================================================
    Private Sub pflichtfelder()

        Dim pflichtfeld As New List(Of String)()

        If cmbAnrede.Text = String.Empty Then
            pflichtfeld.Add("Anrede")
            cmbAnrede.BackColor = Color.Yellow
        End If

        If txtVorname.Text = String.Empty Then
            pflichtfeld.Add("Vorname")
            txtVorname.BackColor = Color.Yellow
        End If

        If txtName.Text = String.Empty Then
            pflichtfeld.Add("Nachname")
            txtName.BackColor = Color.Yellow
        End If

        If txtOrt.Text = String.Empty Then
            pflichtfeld.Add("Ort")
            txtOrt.BackColor = Color.Yellow
        End If

        If txtPlz.Text = String.Empty Then
            pflichtfeld.Add("Plz")
            txtPlz.BackColor = Color.Yellow
        End If

        If txtTel_festnetz.Text = String.Empty AndAlso txtTel_mobil.Text = String.Empty Then
            pflichtfeld.Add("Festnetz")
            pflichtfeld.Add("Handy")
            txtTel_festnetz.BackColor = Color.Yellow
            txtTel_mobil.BackColor = Color.Yellow
        End If

        If cmbBeurteilung.Text = String.Empty Then
            pflichtfeld.Add("Beurteilung")
            cmbBeurteilung.BackColor = Color.Yellow
        End If

        If cmbHaendedruck.Text = String.Empty Then
            pflichtfeld.Add("Händedruck")
            cmbHaendedruck.BackColor = Color.Yellow
        End If

        If cmbParfum.Text = String.Empty Then
            pflichtfeld.Add("Parfüm")
            cmbParfum.BackColor = Color.Yellow
        End If

        If cmbRaucher.Text = String.Empty Then
            pflichtfeld.Add("Raucher")
            cmbRaucher.BackColor = Color.Yellow
        End If

        If cmbVerfuegbarkeit.SelectedItem Is String.Empty Then
            pflichtfeld.Add("Verfügbarkeit")
            cmbVerfuegbarkeit.BackColor = Color.Yellow
        End If

        If txtZa_vm.Text = String.Empty Then
            pflichtfeld.Add("ZA/VM")
            txtZa_vm.BackColor = Color.Yellow
        End If

        If cmbVz_tz.Text = String.Empty Then
            pflichtfeld.Add("VZ/TZ")
            cmbVz_tz.BackColor = Color.Yellow
        End If


        If txtArbeitsort.Text = String.Empty Then
            pflichtfeld.Add("Arbeitsort")
            txtArbeitsort.BackColor = Color.Yellow
        End If

        If txtFuehrerschein.Text = String.Empty Then
            pflichtfeld.Add("Führerschein")
            txtFuehrerschein.BackColor = Color.Yellow
        End If

        If cmbEnglisch_interviewer.Text = String.Empty Then
            pflichtfeld.Add("Englisch laut Interviewer")
            cmbEnglisch_interviewer.BackColor = Color.Yellow
        End If

        If cmbFranzösich_interviewer.Text = String.Empty Then
            pflichtfeld.Add("Französisch laut Interviewer")
            cmbFranzösich_interviewer.BackColor = Color.Yellow
        End If

        If cmbSpanisch_interviewer.Text = String.Empty Then
            pflichtfeld.Add("Spanisch laut Interviewer")
            cmbSpanisch_interviewer.BackColor = Color.Yellow
        End If

        If cmbItalienisch_interviewer.Text = String.Empty Then
            pflichtfeld.Add("Italienisch laut Interviewer")
            cmbItalienisch_interviewer.BackColor = Color.Yellow
        End If

        If cmbTuerkisch_interviewer.Text = String.Empty Then
            pflichtfeld.Add("Türkisch laut Interviewer")
            cmbTuerkisch_interviewer.BackColor = Color.Yellow
        End If

        If cmbRussisch_interviewer.Text = String.Empty Then
            pflichtfeld.Add("Russisch laut Interviewer")
            cmbRussisch_interviewer.BackColor = Color.Yellow
        End If

        If cmbNiederlaendisch_interviewer.Text = String.Empty Then
            pflichtfeld.Add("Niederländisch laut Interviewer")
            cmbNiederlaendisch_interviewer.BackColor = Color.Yellow
        End If

        If cmbDeutsch_interviewer.Text = String.Empty Then
            pflichtfeld.Add("Deutsch laut Interviewer")
            cmbDeutsch_interviewer.BackColor = Color.Yellow
        End If

        If KuendigungsfristComboBox.Enabled AndAlso KuendigungsfristComboBox.Text = String.Empty Then
            pflichtfeld.Add("Kündigungsfrist")
            KuendigungsfristComboBox.BackColor = Color.Yellow
        End If

        If cmbMdE.Text = CStr("Ja") AndAlso Not txtMdE.ReadOnly AndAlso txtMdE.Text = String.Empty Then
            pflichtfeld.Add("MdE")
            txtMdE.BackColor = Color.Yellow
        End If

        If Beendigungsgrund_detailsTextBox.Text = String.Empty Then
            pflichtfeld.Add("Details Kündigung etc.")
            Beendigungsgrund_detailsTextBox.BackColor = Color.Yellow
        End If

        If WechselwunschTextBox.Text = String.Empty Then
            pflichtfeld.Add("Wechselwunsch")
            WechselwunschTextBox.BackColor = Color.Yellow
        End If

        '  If BewerberbeschreibungTextBox.Text = String.Empty Then
        'pflichtfeld.Add("Bewerberbeschreibung")
        'BewerberbeschreibungTextBox.BackColor = Color.Yellow
        'End If

        If cmbInterviewer.Text = String.Empty Then
            pflichtfeld.Add("Interviewer")
            cmbInterviewer.BackColor = Color.Yellow
        End If

        'If exportfilertf = CStr("{\rtf\ansi\ansicpg1252\uc1\deff0\deflang1033{\fonttbl{\f0 Verdana;}}{\colortbl\red0\green0\blue0 ;}{\*\defchp\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone}{\*\defpap\sl276\slmult1\ql\sa180\ltrpar}{\stylesheet{\s0\sqformat\spriority0\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Normal;}{\*\ts2\tsrowd\spriority59\trbrdrt\brdrnone\trbrdrb\brdrnone\trbrdrl\brdrnone\trbrdrr\brdrnone\trbrdrh\brdrnone\trbrdrv\brdrnone\trgaph0\trpaddl75\trpaddr75\trpaddt0\trpaddb0\clpadft3\clpadt0\clpadfr3\clpadr0\clpadfl3\clpadl0\clpadfb3\clpadb0\tsvertalt\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Table Normal;}}\nouicompat\viewkind4\paperw12240\paperh15840\margl1425\margr1425\margt1425\margb1425\deftab720\sectd\pgwsxn12240\pghsxn15840\marglsxn1425\margrsxn1425\margtsxn1425\margbsxn1425\headery720\footery720\pard\s0\sl276\slmult1\ql\sa180\ltrpar{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\par}}") Then
        '    pflichtfeld.Add("Persönlichkeit, Äußeres etc.")
        '    GroupBox10.BackColor = Color.Yellow
        'End If

        If exportfiletxt = String.Empty Then
            pflichtfeld.Add("Persönlichkeit, Äußeres etc.")
            GroupBox10.BackColor = Color.Yellow
        End If

        If txtMonatsgehalt.Text = String.Empty Then
            pflichtfeld.Add("Letztes Monatsgehalt")
            txtMonatsgehalt.BackColor = Color.Yellow
        End If

        If txtGehaltswunsch_monat.Text = String.Empty Then
            pflichtfeld.Add("Monatswunschgehalt")
            txtGehaltswunsch_monat.BackColor = Color.Yellow
        End If

        If txtTaetigkeiten.Text = String.Empty Then
            pflichtfeld.Add("Bisherige Tätigkeiten, berufliche Schwerpunkte, Zeugnistext")
            txtTaetigkeiten.BackColor = Color.Yellow
        End If

        If cmbAufmerksam.Text = String.Empty Then
            pflichtfeld.Add("Aufmerksam geworden durch")
            cmbAufmerksam.BackColor = Color.Yellow
        End If

        pflichtfeldliste = String.Join(vbCrLf, pflichtfeld)
    End Sub

    ' Pflichtfelder anzeigen bei Start

    Private Sub PflichtfelderbeiStart()

        ' Dim pflichtfeldstartliste As New List(Of String)()
        Dim kontaktdatenliste As New List(Of String)()
        Dim beschäftigungliste As New List(Of String)()
        Dim berufserfahrungliste As New List(Of String)()

        Dim kontaktdaten As String = String.Empty
        Dim beschäftigungsdaten As String = String.Empty
        Dim berufserfahrungsdaten As String = String.Empty

        Dim bewerber = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        Dim bewerberdaten = DirectCast(DirectCast(Me.Bew_bewerberdatenBindingSource.Current, DataRowView).Row, bew_bewerberdatenRow)
        Dim berufserfahrung = DirectCast(DirectCast(Me.Bewerber_berufserfahrungBindingSource.Current, DataRowView).Row, bewerber_berufserfahrungRow)
        Dim ausbildung = DirectCast(DirectCast(Me.Bewerber_ausbildungBindingSource.Current, DataRowView).Row, bewerber_ausbildungRow)

        ' Kontaktdaten

        If bewerber.Istel_festnetzNull OrElse bewerber.tel_festnetz = String.Empty Then
            kontaktdatenliste.Add("Festnetz")
            txtTel_festnetz.BackColor = Color.Yellow
        End If

        If bewerber.Istel_mobilNull OrElse bewerber.tel_mobil = String.Empty Then
            kontaktdatenliste.Add("Handy")
            txtTel_mobil.BackColor = Color.Yellow
        End If

        If bewerber.IsbeurteilungNull OrElse bewerber.beurteilung = String.Empty Then
            kontaktdatenliste.Add("Beurteilung")
            cmbBeurteilung.BackColor = Color.Yellow
        End If

        If bewerberdaten.IshaendedruckNull OrElse bewerberdaten.haendedruck = String.Empty Then
            kontaktdatenliste.Add("Händedruck")
            cmbHaendedruck.BackColor = Color.Yellow
        End If

        If bewerberdaten.IsparfumNull OrElse bewerberdaten.parfum = String.Empty Then
            kontaktdatenliste.Add("Parfüm")
            cmbParfum.BackColor = Color.Yellow
        End If

        If bewerberdaten.IsraucherNull OrElse bewerberdaten.raucher = String.Empty Then
            kontaktdatenliste.Add("Raucher")
            cmbRaucher.BackColor = Color.Yellow
        End If

        ' Beschäftigung
        If bewerber.IsarbeitszeitNull OrElse bewerber.arbeitszeit = String.Empty Then
            beschäftigungliste.Add("VZ/TZ")
            cmbVz_tz.BackColor = Color.Yellow
        End If

        If bewerber.IsverfügbarkeitNull OrElse bewerber.verfügbarkeit = String.Empty Then
            beschäftigungliste.Add("Verfügbarkeit")
            cmbVerfuegbarkeit.BackColor = Color.Yellow
        End If

        If bewerber.IsVermittlungNull OrElse bewerber.Vermittlung = String.Empty Then
            beschäftigungliste.Add("ZA/VM")
            txtZa_vm.BackColor = Color.Yellow
        End If

        If bewerber.IsarbeitszeitNull OrElse bewerber.arbeitszeit = String.Empty Then
            beschäftigungliste.Add("VZ/TZ")
            cmbVz_tz.BackColor = Color.Yellow
        End If

        If bewerber.IsarbeitsortNull OrElse bewerber.arbeitsort = String.Empty Then
            beschäftigungliste.Add("Arbeitsort")
            txtArbeitsort.BackColor = Color.Yellow
        End If

        If bewerberdaten.IsfuehrerscheinNull OrElse bewerberdaten.fuehrerschein = String.Empty Then
            beschäftigungliste.Add("Führerschein")
            txtFuehrerschein.BackColor = Color.Yellow
        End If

        If bewerberdaten.Ispkw_oepnvNull OrElse bewerberdaten.pkw_oepnv = String.Empty Then
            beschäftigungliste.Add("PKW/ÖPNV")
            txtPkw_oepnv.BackColor = Color.Yellow
        End If

        If bewerber.IsmonatsgehaltNull OrElse txtMonatsgehalt.Text = String.Empty Then
            beschäftigungliste.Add("Monatsgehalt")
            txtMonatsgehalt.BackColor = Color.Yellow
        End If

        If bewerber.Isgehaltswunsch_monatNull OrElse txtGehaltswunsch_monat.Text = String.Empty Then
            beschäftigungliste.Add("Gehaltswunsch Monat")
            txtGehaltswunsch_monat.BackColor = Color.Yellow
        End If

        'Berufserfahrung

        If bewerber.IstätigkeitenNull OrElse bewerber.tätigkeiten = String.Empty Then
            berufserfahrungliste.Add("Bisherige Tätigkeiten, berufliche Schwerpunkte, Zeugnistext")
            txtTaetigkeiten.BackColor = Color.Yellow
        End If

        kontaktdaten = String.Join(vbNewLine, kontaktdatenliste)
        beschäftigungsdaten = String.Join(vbNewLine, beschäftigungliste)
        berufserfahrungsdaten = String.Join(vbNewLine, berufserfahrungliste)

        If kontaktdaten <> String.Empty OrElse beschäftigungsdaten <> String.Empty OrElse berufserfahrungsdaten <> String.Empty Then
            Dim text As String = String.Concat("Diese Felder sind nicht ausgefüllt (gelb hinterlegt):", vbNewLine, vbNewLine, "Reiter: Kontaktdaten:", vbNewLine, vbNewLine, kontaktdaten, vbNewLine, vbNewLine, "Reiter: Beschäftigung:", vbNewLine, vbNewLine, beschäftigungsdaten, vbNewLine, vbNewLine, "Reiter: Berufserfahrung", vbNewLine, vbNewLine, berufserfahrungsdaten)
            MessageBox.Show(text, "Felder nicht ausgefüllt", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    ' ========================================================================= Ende Pflichtfelder =========================================================================

    ' ========================================================================= Validierung ================================================================================
    Private Sub cmbAnrede_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbAnrede.Validating, cmbBeurteilung.Validating, cmbHaendedruck.Validating, cmbParfum.Validating, cmbRaucher.Validating, cmbVerfuegbarkeit.Validating, txtZa_vm.Validating, cmbVz_tz.Validating, txtArbeitsort.Validating, txtFuehrerschein.Validating, txtPkw_oepnv.Validating, txtTel_mobil.Validating, txtTel_festnetz.Validating, cmbAnrede.Validating, cmbEnglisch_interviewer.Validating, cmbFranzösich_interviewer.Validating, cmbSpanisch_interviewer.Validating, cmbItalienisch_interviewer.Validating, cmbTuerkisch_interviewer.Validating, cmbRussisch_interviewer.Validating, cmbNiederlaendisch_interviewer.Validating, cmbDeutsch_interviewer.Validating, KuendigungsfristComboBox.Validating, txtMdE.Validating, Beendigungsgrund_detailsTextBox.Validating, WechselwunschTextBox.Validating, cmbInterviewer.Validating, txtGehaltswunsch_monat.Validating, txtTaetigkeiten.Validating, txtOrtsteil.Validating
        Select Case True

            Case sender Is cmbAnrede
                If cmbAnrede.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Anrede fehlt")
                    ToolTip1.Show("Anrede fehlt", CType(sender, Control), 1500)
                End If
            Case sender Is txtTel_festnetz
                If txtTel_festnetz.Text = String.Empty AndAlso txtTel_mobil.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Entweder Festnetz oder Handy abfragen")
                    ToolTip1.Show("Entweder Festnetz oder Handy abfragen", CType(sender, Control), 1500)
                End If
            Case sender Is txtTel_mobil
                If txtTel_festnetz.Text = String.Empty AndAlso txtTel_mobil.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Entweder Festnetz oder Handy abfragen")
                    ToolTip1.Show("Entweder Festnetz oder Handy abfragen", CType(sender, Control), 1500)
                End If
            Case sender Is cmbBeurteilung
                If cmbBeurteilung.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Beurteilung fehlt")
                    ToolTip1.Show("Beurteilung fehlt", CType(sender, Control), 1500)
                End If
            Case sender Is cmbHaendedruck
                If cmbHaendedruck.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Händedruck fehlt")
                    ToolTip1.Show("Händedruck fehlt", CType(sender, Control), 1500)
                End If
            Case sender Is cmbParfum
                If cmbParfum.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Parfümeindruck fehlt")
                    ToolTip1.Show("Parfümeindruck fehlt", CType(sender, Control), 1500)
                End If
            Case sender Is cmbRaucher
                If cmbRaucher.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Raucher?")
                    ToolTip1.Show("Raucher?", CType(sender, Control), 1500)
                End If
            Case sender Is cmbVerfuegbarkeit
                If cmbVerfuegbarkeit.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Raucher?")
                    ToolTip1.Show("Raucher?", CType(sender, Control), 1500)
                End If

            Case sender Is txtZa_vm
                If txtZa_vm.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is cmbVz_tz
                If cmbVz_tz.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is txtArbeitsort
                If txtArbeitsort.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is txtFuehrerschein
                If txtFuehrerschein.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is txtPkw_oepnv
                If txtPkw_oepnv.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is cmbEnglisch_interviewer
                If cmbEnglisch_interviewer.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is cmbFranzösich_interviewer
                If cmbFranzösich_interviewer.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is cmbSpanisch_interviewer
                If cmbSpanisch_interviewer.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is cmbItalienisch_interviewer
                If cmbItalienisch_interviewer.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is cmbTuerkisch_interviewer
                If cmbTuerkisch_interviewer.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is cmbRussisch_interviewer
                If cmbRussisch_interviewer.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is cmbNiederlaendisch_interviewer
                If cmbNiederlaendisch_interviewer.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is cmbDeutsch_interviewer
                If cmbDeutsch_interviewer.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is KuendigungsfristComboBox
                If KuendigungsfristComboBox.Enabled AndAlso KuendigungsfristComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is txtMdE
                If cmbMdE.Text = CStr("Ja") AndAlso Not txtMdE.ReadOnly AndAlso txtMdE.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Beendigungsgrund_detailsTextBox
                If Beendigungsgrund_detailsTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is WechselwunschTextBox
                If WechselwunschTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

                ' Case sender Is BewerberbeschreibungTextBox
                '    If BewerberbeschreibungTextBox.Text = String.Empty Then
                'ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                'ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                'End If

            Case sender Is cmbInterviewer
                If cmbInterviewer.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If
            Case sender Is txtMonatsgehalt
                If txtMonatsgehalt.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If
            'Case sender Is txtGehaltswunsch_monat
            '    If txtGehaltswunsch_monat.Text = String.Empty Then
            '        ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
            '        ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
            '    End If

            Case sender Is txtTaetigkeiten
                If txtTaetigkeiten.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is txtOrtsteil
                If txtTaetigkeiten.Text.Contains("Köln") Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte den Ortsteil von Köln eintragen")
                    ToolTip1.Show("Bitte den Ortsteil von Köln eintragen", CType(sender, Control), 1500)
                End If
        End Select
    End Sub
    Private Sub Berufsausbildung_check()

        If txtAusbildungsberuf.Text = String.Empty AndAlso txtAusbildung_qualifizierung.Text = String.Empty AndAlso txtStudium_abschluss.Text = String.Empty AndAlso txtStudienfaecher.Text = String.Empty Then
            For Each txt As TextBox In Me.GroupBox5.Controls.OfType(Of TextBox)
                txt.BackColor = Color.Yellow
            Next

            MessageBox.Show("Wenn die Felder ""Ausbildungsberufe"", ""Ausbildung Qualifizierung"", ""Studium Abschluss"" und ""Studienfächer"" leer sind, dann tragen Sie bitte im Feld ""Ausbildungsberufe"" ""Keine Ausbildung"" ein.", "Keine Ausbildung", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub

    Private Sub Vz_tzComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVz_tz.SelectedIndexChanged, cmbAuslandsaufenthalt.SelectedIndexChanged, cmbVerfuegbarkeit.SelectedIndexChanged, cmbMdE.SelectedIndexChanged

        If cmbVerfuegbarkeit.SelectedIndex = 2 Then
            txtVerfuegbarkeitindividuell.ReadOnly = False
        Else
            txtVerfuegbarkeitindividuell.ReadOnly = True
        End If


        If cmbVz_tz.Text = String.Empty OrElse cmbVz_tz.Text = CStr("Vollzeit") Then
            cmbTeilzeit_stunden.Enabled = False
            cmbTeilzeit_wann.Enabled = False
            '  ElseIf Vz_tzComboBox.Text = String.Empty Then
        ElseIf cmbVz_tz.Text = CStr("Teilzeit") OrElse cmbVz_tz.Text = CStr("Vollzeit/Teilzeit") OrElse cmbVz_tz.Text = CStr("Teilzeit flexibel") Then
            cmbTeilzeit_stunden.Enabled = True
            cmbTeilzeit_wann.Enabled = True
        End If

        If cmbAuslandsaufenthalt.Text = CStr("Ja") OrElse cmbAuslandsaufenthalt.Text = CStr("Geplant") Then
            txtAuslandsaufenthalt_dauer.ReadOnly = False
            txtAuslandsaufenthalt_wo.ReadOnly = False
        Else
            txtAuslandsaufenthalt_dauer.ReadOnly = True
            txtAuslandsaufenthalt_wo.ReadOnly = True
        End If

        If cmbVerfuegbarkeit.Text = CStr("sofort") OrElse cmbVerfuegbarkeit.Text = String.Empty Then
            KuendigungsfristComboBox.Enabled = False
        Else
            KuendigungsfristComboBox.Enabled = True
        End If

        If cmbMdE.Text = CStr("Ja") Then
            txtMdE.ReadOnly = False
        Else
            txtMdE.ReadOnly = True
        End If
    End Sub

    Private Sub telefoneintrag()
        If txtTel_festnetz.Text = String.Empty Then
            txtTel_festnetz.Text = CStr("kein Eintrag")
        End If

        If txtTel_mobil.Text = String.Empty Then
            txtTel_mobil.Text = CStr("kein Eintrag")
        End If
    End Sub
    ' ========================================================================= Ende Validierung ========================================================================

    ' ========================================================================= Labelformatierung =========================================================================
    Private Sub labelfarbe()
        For Each lbl In GroupBox1.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In GroupBox2.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In GroupBox3.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In GroupBox4.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In GroupBox5.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In GroupBox6.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In GroupBox8.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In GroupBox9.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In GroupBox11.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In GroupBox12.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        Label2.ForeColor = Color.DarkGreen
        Label3.ForeColor = Color.DarkGreen

    End Sub
    ' ========================================================================== Ende Labelformatierung ==================================================================

    ' ========================================================================== Listboxen aufrufen ======================================================================
    Private Sub listboxenaufrufen()
        Using frm = New frmListboxen(Me)
            Dim result = frm.ShowDialog()
        End Using
    End Sub

    Private Sub txtZa_vm_DoubleClick(sender As Object, e As EventArgs) Handles txtZa_vm.DoubleClick, txtArbeitsort.DoubleClick, txtFuehrerschein.DoubleClick, txtPkw_oepnv.DoubleClick, txtStudium_abschluss.DoubleClick, txtUlas.DoubleClick, txtSAPModule.DoubleClick
        Select Case True
            Case sender Is txtZa_vm
                frmListboxen.zavm_bool = True
                Call listboxenaufrufen()
                txtZa_vm.Text = CStr(frmListboxen.zavm)
            Case sender Is txtArbeitsort
                frmListboxen.arbeitsort_bool = True
                Call listboxenaufrufen()
                txtArbeitsort.Text = CStr(frmListboxen.arbeitsort)
            Case sender Is txtFuehrerschein
                frmListboxen.fuehrerschein_bool = True
                Call listboxenaufrufen()
                txtFuehrerschein.Text = CStr(frmListboxen.fueherschein)
            Case sender Is txtPkw_oepnv
                frmListboxen.oepnv_bool = True
                Call listboxenaufrufen()
                txtPkw_oepnv.Text = CStr(frmListboxen.oepnv)
            Case sender Is txtStudium_abschluss
                frmListboxen.studiumsabschluss_bool = True
                Call listboxenaufrufen()
                txtStudium_abschluss.Text = CStr(frmListboxen.studiumabschluss)
            Case sender Is txtUlas
                frmUlaseintragen.ulas_bool = True
                Using frm = New frmUlaseintragen(Me)
                    Dim result = frm.ShowDialog(Me)
                End Using
                If frmUlaseintragen.ulas_wert <> String.Empty Then
                    txtUlas.Text = CStr(frmUlaseintragen.ulas_wert)
                End If
            Case sender Is txtSAPModule
                frmListboxen.sapmodule_bool = True
                Call listboxenaufrufen()
                txtSAPModule.Text = frmListboxen.sapmodule
        End Select
    End Sub
    ' ============================================================================= Listboxen aufrufen Ende =====================================================================

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim tabContas As TabControl = DirectCast(sender, TabControl)
        Dim sTexto As String = tabContas.TabPages(e.Index).Text
        Dim g As Graphics = e.Graphics
        Dim fonte As Font = tabContas.Font
        Dim format = New System.Drawing.StringFormat
        'CHANGES HERE...
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center
        Dim pincel As New SolidBrush(Color.Black)
        'RENEMED VARIEBLE HERE...
        Dim retangulo As System.Drawing.RectangleF = System.Drawing.RectangleF.op_Implicit(tabContas.GetTabRect(e.Index))
        If tabContas.SelectedIndex = e.Index Then
            fonte = New Font(fonte, FontStyle.Bold)
            pincel = New SolidBrush(Color.Red)
            'CHANGED BACKGROUN COLOR HERE...
            g.FillRectangle(Brushes.White, retangulo)
        End If
        g.DrawString(sTexto, fonte, pincel, retangulo, format)
    End Sub

    Private Sub Comboboxfill()
        For Each cmb As ComboBox In Me.GroupBox8.Controls.OfType(Of ComboBox)()
            cmb.DropDownStyle = ComboBoxStyle.DropDownList
            cmb.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
            cmb.SelectedIndex = 0
        Next

        For Each cmb As ComboBox In Me.GroupBox13.Controls.OfType(Of ComboBox)()
            cmb.DropDownStyle = ComboBoxStyle.DropDownList
            cmb.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
            cmb.SelectedIndex = 0
        Next

        ' erforderlich, damit Einträge nicht überschrieben werden, wenn zuvor eine xmldatei eingelesen wurde

        If frmXmleinlesen.xmlbool Then
            Me.GroupBox14.Enabled = False
            Me.GroupBox15.Enabled = False
            Me.GroupBox13.Enabled = False

        ElseIf Not frmXmleinlesen.xmlbool Then
            Me.GroupBox14.Enabled = True
            Me.GroupBox15.Enabled = True
            Me.GroupBox13.Enabled = True

            For Each cmb As ComboBox In Me.GroupBox14.Controls.OfType(Of ComboBox)()
                cmb.DropDownStyle = ComboBoxStyle.DropDownList
                cmb.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
                cmb.SelectedIndex = 0
            Next

            For Each cmb As ComboBox In Me.GroupBox15.Controls.OfType(Of ComboBox)()
                cmb.DropDownStyle = ComboBoxStyle.DropDownList
                cmb.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
                cmb.SelectedIndex = 0
            Next
        End If
    End Sub

    Private Sub Stelle_vorschlagen_laut_interviewerTextBox_DoubleClick(sender As Object, e As EventArgs) Handles txtFuerstelle.DoubleClick
        frmOA.vorschlagenfuerstelle_interviewer_bool = True
        Using frm = New frmOA(Me)
            Dim result = frm.ShowDialog()
        End Using
    End Sub

    Private Sub interviewerauffalse()
        frmOA.vorschlagenfuerstelle_interviewer_bool = False
    End Sub


    Private Sub Controlsaufweiss()

        For Each tb In Me.GroupBox1.Controls.OfType(Of TextBox)()
            If tb.BackColor = Color.Yellow Then
                tb.BackColor = Color.White
            End If
        Next

        For Each cmb In Me.GroupBox3.Controls.OfType(Of ComboBox)()
            If cmb.BackColor = Color.Yellow Then
                cmb.BackColor = Color.White
            End If
        Next

        For Each tb In Me.GroupBox4.Controls.OfType(Of TextBox)()
            If tb.BackColor = Color.Yellow Then
                tb.BackColor = Color.White
            End If
        Next

        For Each cmb In Me.GroupBox4.Controls.OfType(Of ComboBox)()
            If cmb.BackColor = Color.Yellow Then
                cmb.BackColor = Color.White
            End If
        Next

        For Each tb In Me.GroupBox9.Controls.OfType(Of TextBox)()
            If tb.BackColor = Color.Yellow Then
                tb.BackColor = Color.White
            End If
        Next

        For Each cmb In Me.GroupBox9.Controls.OfType(Of ComboBox)()
            If cmb.BackColor = Color.Yellow Then
                cmb.BackColor = Color.White
            End If
        Next

        For Each tb In Me.GroupBox6.Controls.OfType(Of TextBox)()
            If tb.BackColor = Color.Yellow Then
                tb.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub frmInterviewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' erforderlich, damit Einträge nicht überschrieben werden, wenn zuvor eine xmldatei eingelesen wurde, Bool zurücksetzen
        frmXmleinlesen.xmlbool = False
    End Sub
End Class