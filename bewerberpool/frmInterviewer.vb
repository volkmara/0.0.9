Imports Telerik.WinControls.UI.Localization
Imports Telerik.WinControls.RichTextEditor
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.Rtf
Imports Telerik.WinForms.Documents.FormatProviders.Txt
Imports Telerik.WinForms.RichTextEditor
Imports Telerik.WinForms.Documents.RichTextBoxCommands
Imports bewerberpool.BewerberDataSet
Public Class frmInterviewer

    Public pflichtfeldliste As String = String.Empty
    Public ulas As String = String.Empty
    Public exportfilertf As String = String.Empty
    Public exportfiletxt As String = String.Empty
    Public importfilertf As String = String.Empty
    Private _frmMain As frmMain
    Private _frmOA As frmOA

    Public sprachenliste As String = String.Empty

    Public tabpagecount As Integer = CInt(0)

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Sub New(frmOA As frmOA)
        _frmOA = frmOA
        InitializeComponent()
    End Sub

    Private Sub frmInterviewer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call Timerreload.Reload() ' Timer für DB-Reload starten
    End Sub

    Private Sub frmInterviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Die Bindingsources dieser Form werden umgestöpselt auf die Bindingsources von frmMain
        Me.BewBindingSource.DataSource = frmMain.BewBindingSource.Current ' muss bewbindingsource.current sein, damit der richtige Bewerber in den Interviewerfragebogen geladen wird
        Me.Bew_bewerberdatenBindingSource.DataSource = frmMain.Bew_bewerberdatenBindingSource
        Me.Bewerber_ausbildungBindingSource.DataSource = frmMain.Bewerber_ausbildungBindingSource
        Me.Bewerber_berufserfahrungBindingSource.DataSource = frmMain.Bewerber_berufserfahrungBindingSource
        Me.Bewerber_sprachenBindingSource.DataSource = frmMain.Bewerber_sprachenBindingSource
        Me.UlasBindingSource.DataSource = frmMain.UlasBindingSource
        Call Timerreload.Timerstop() ' Timer für DB-Reload stoppen
    End Sub

    Private Sub frmInterviewer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call labelfarbe()
        Call import()
        Call Comboboxfill()
        pflichtfeldliste = String.Empty
        sprachenliste = String.Empty

        Dim bewdaten = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        Label7.Text = String.Concat(bewdaten.anrede, " ", bewdaten.vorname, " ", bewdaten.name)

        frmOA.vorschlagenfuerstelle_interviewer_bool = False


        Me.cmbAufmerksam.Items.AddRange(New String() {"Agentur für Arbeit", "backinjob", "Gigajob", "Indeed", "Jobmonitor", "Jobomat", "Kalaydo", "meinestadt", "Monster", "Placement24", "Rekruter", "stellenmarkt", "Stepstone", "", "Facebook", "Twitter", "Xing", "Google", "Bing", "Yahoo", "Web.de", " ", "Bonner Generalanzeiger", "Kölner Stadtanzeiger", "Rhein-Sieg-Anzeiger", "Regionale Anzeigenblätter", "", "andere"})
    End Sub

    Private Sub AnredeComboBox_Mousewheel(sender As Object, e As MouseEventArgs) Handles AnredeComboBox.MouseWheel, BeurteilungComboBox.MouseWheel, HaendedruckComboBox.MouseWheel, ParfumComboBox.MouseWheel, RaucherComboBox.MouseWheel, Vz_tzComboBox.MouseWheel, Teilzeit_stundenComboBox.MouseWheel, Teilzeit_wannComboBox.MouseWheel, UmzugComboBox.MouseWheel, VerfuegbarkeitComboBox.MouseWheel, MdEComboBox.MouseWheel, KuendigungsfristComboBox.MouseWheel, BeendigungsgrundComboBox.MouseWheel, PersonalverantwortungComboBox.MouseWheel, FuehrungsverantwortungComboBox.MouseWheel, AuslandsaufenthaltComboBox.MouseWheel, Englisch_interviewerComboBox.MouseWheel, Französich_interviewerComboBox.MouseWheel, Spanisch_interviewerComboBox.MouseWheel, Italienisch_interviewerComboBox.MouseWheel, Russisch_interviewerComboBox.MouseWheel, Niederlaendisch_interviewerComboBox.MouseWheel, Tuerkisch_interviewerComboBox.MouseWheel, Deutsch_interviewerComboBox.MouseWheel
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Call inallentabellen.prüfen() ' prüfen, ob in allen Tabellen die Id vorhanden ist, ansonsten anlegen
        Call export()
        Call telefoneintrag()
        Call sprachendaten() ' trägt Sprachen im Feld "Sprachkenntnisse" im Reiter "Bewerber/in" ein

        ' Validierung vorm Speichern
        If Not frmMain.StandComboBox.Text = CStr("fertig") AndAlso TabControl1.SelectedTab IsNot TabPage7 Then
            MessageBox.Show("Bitte alle Reiter nacheinander anklicken und die Felder in allen Reitern bearbeiten", "Alle Tabreiter anwählen", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not frmMain.StandComboBox.Text = CStr("fertig") AndAlso usernameklar = "vilder" OrElse usernameklar = "schwarz" Then
            Call pflichtfelder()
        End If

        If pflichtfeldliste <> String.Empty Then
            MessageBox.Show("Haben Sie vergessen, diese Felder auszufüllen? " & vbCrLf & vbCrLf & pflichtfeldliste & vbCrLf & vbCrLf & "Nicht schlimm, das kann ja mal passieren. Bitte ergänzen 'Sie' einfach Ihre Angaben. " & vbCrLf & vbCrLf & "Vielen Dank", "Pflichtfelder bitte ausfüllen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            pflichtfeldliste = String.Empty
            Exit Sub
        Else
            Dim bewspeichern = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
            bewspeichern.geaendert_am = Date.Now.ToString
            bewspeichern.letztbearbeitung_von = CStr(usernameklar)
            bewspeichern.status = CStr("fertig")
            ' rundschreibenjanein ist nach dem Anlegen im Bewerbertool DBNull, muss nach dem Bearbeiten auf 0 gesetzt werden
            If bewspeichern.IsrundschreibenjaneinNull Then
                bewspeichern.rundschreibenjanein = CInt(0)
            End If

            If frmUlaseintragen.ulas_wert <> String.Empty Then
                bewspeichern.ulas = CStr(frmUlaseintragen.ulas_wert)
            End If

            bewspeichern.interviewart = CStr("Bewerbergespräch")

            bewspeichern.bewerberbeschreibung = CStr(exportfilertf)
            bewspeichern.bewerberbeschreibung_text = CStr(exportfiletxt)
            bewspeichern.sprachkenntnisse = CStr(sprachenliste)

            Me.Validate()
            Me.BewBindingSource.EndEdit()
            Me.Bew_bewerberdatenBindingSource.EndEdit()
            Me.UlasBindingSource.EndEdit()
            Me.Bewerber_berufserfahrungBindingSource.EndEdit()
            Me.Bewerber_ausbildungBindingSource.EndEdit()
            Me.Bewerber_sprachenBindingSource.EndEdit()

            frmMain.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)
            frmMain.Bew_bewerberdatenTableAdapter.Update(frmMain.BewerberDataSet.bew_bewerberdaten)
            frmMain.Bewerber_ausbildungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_ausbildung)
            frmMain.Bewerber_berufserfahrungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_berufserfahrung)
            frmMain.Bewerber_sprachenTableAdapter.Update(frmMain.BewerberDataSet.bewerber_sprachen)
            frmMain.UlasTableAdapter.Update(frmMain.BewerberDataSet.ulas)
            frmMain.BewGridView1.FilterDescriptors.Clear()
            Call gespeichert()
            '  pflichtfeldliste = String.Empty

            ' OpenFD für Originalunterlagen öffnen

            If connectionString.Contains("127.0.0.1") Then
                verzeichnis = CStr("e:\heyduck\ulas\")
            Else
                verzeichnis = CStr("x:\ulas\")
            End If
            Dim zielverzeichnis As String = String.Concat(verzeichnis, letzteid, "\", "Originale", "\")

            Dim abspeichern As String = String.Concat("Sie können jetzt die Originalunterlagen des Bewerbers/der Bewerberin abspeichern.", vbNewLine, vbNewLine, "Weitere Dateien können ggf. später über das Feld ""Originalunterlagen Bewerber/in"" im Reiter ""Daten"" hochgeladen werden (Rechtsklick).")

            If Not IO.Directory.Exists(zielverzeichnis) Then
                Dim result As DialogResult = MessageBox.Show(CStr(abspeichern), "Unterlagen speichern", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
                If result = Windows.Forms.DialogResult.Yes Then
                    Call ulasspeichern.originalulasspeichern()
                ElseIf result = Windows.Forms.DialogResult.No Then
                    Me.Close()
                End If
            Else
                Dim ulasprüfen As String = String.Concat("Das Verzeichnis für Originalunterlagen dieses Bewerbers/dieser Bewerberin existiert bereits. Bitte überprüfen Sie die Unterlagen. ", vbNewLine, vbNewLine, "Vorhandene Unterlagen können ggf. später über das Feld ""Originalunterlagen Bewerber/in"" im Reiter ""Daten"" überschrieben werden (Rechtsklick)")
                MessageBox.Show(ulasprüfen, "Verzeichnis vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' Wird geschlossen, wenn origulas (=> wenn zielverzeichnis existiert) bereits vorhanden sind
            End If

            frmMain.DBLoad()
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim result As DialogResult = MessageBox.Show("Möchten Sie ihre Eingaben vorher speichern?", "Speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.No Then
            Me.Close()
        ElseIf result = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If
    End Sub
#End Region
    ' ========================================================================= Pflichtfelder =============================================================================
    Private Sub pflichtfelder()

        Dim pflichtfeld As New List(Of String)()

        If VornameTextBox.Text = String.Empty Then
            pflichtfeld.Add("Vorname")
            VornameTextBox.BackColor = Color.Yellow
        End If

        If NameTextBox.Text = String.Empty Then
            pflichtfeld.Add("Nachname")
            NameTextBox.BackColor = Color.Yellow
        End If

        If OrtTextBox.Text = String.Empty Then
            pflichtfeld.Add("Ort")
            OrtTextBox.BackColor = Color.Yellow
        End If

        If PlzTextBox.Text = String.Empty Then
            pflichtfeld.Add("Plz")
            PlzTextBox.BackColor = Color.Yellow
        End If

        If Tel_festnetzTextBox.Text = String.Empty AndAlso Tel_mobilTextBox.Text = String.Empty Then
            pflichtfeld.Add("Festnetz")
            pflichtfeld.Add("Handy")
            Tel_festnetzTextBox.BackColor = Color.Yellow
            Tel_mobilTextBox.BackColor = Color.Yellow
        End If

        If BeurteilungComboBox.Text = String.Empty Then
            pflichtfeld.Add("Beurteilung")
            BeurteilungComboBox.BackColor = Color.Yellow
        End If

        If HaendedruckComboBox.Text = String.Empty Then
            pflichtfeld.Add("Händedruck")
            HaendedruckComboBox.BackColor = Color.Yellow
        End If

        If ParfumComboBox.Text = String.Empty Then
            pflichtfeld.Add("Parfüm")
            ParfumComboBox.BackColor = Color.Yellow
        End If

        If RaucherComboBox.Text = String.Empty Then
            pflichtfeld.Add("Raucher")
            RaucherComboBox.BackColor = Color.Yellow
        End If

        If VerfuegbarkeitComboBox.SelectedItem Is String.Empty Then
            pflichtfeld.Add("Verfügbarkeit")
            VerfuegbarkeitComboBox.BackColor = Color.Yellow
        End If

        If Za_vmTextBox.Text = String.Empty Then
            pflichtfeld.Add("ZA/VM")
            Za_vmTextBox.BackColor = Color.Yellow
        End If

        If Vz_tzComboBox.Text = String.Empty Then
            pflichtfeld.Add("VZ/TZ")
            Vz_tzComboBox.BackColor = Color.Yellow
        End If


        If ArbeitsortTextBox.Text = String.Empty Then
            pflichtfeld.Add("Arbeitsort")
            ArbeitsortTextBox.BackColor = Color.Yellow
        End If

        If FuehrerscheinTextBox.Text = String.Empty Then
            pflichtfeld.Add("Führerschein")
            FuehrerscheinTextBox.BackColor = Color.Yellow
        End If

        If Englisch_interviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Englisch laut Interviewer")
            Englisch_interviewerComboBox.BackColor = Color.Yellow
        End If

        If Französich_interviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Französisch laut Interviewer")
            Französich_interviewerComboBox.BackColor = Color.Yellow
        End If

        If Spanisch_interviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Spanisch laut Interviewer")
            Spanisch_interviewerComboBox.BackColor = Color.Yellow
        End If

        If Italienisch_interviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Italienisch laut Interviewer")
            Italienisch_interviewerComboBox.BackColor = Color.Yellow
        End If

        If Tuerkisch_interviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Türkisch laut Interviewer")
            Tuerkisch_interviewerComboBox.BackColor = Color.Yellow
        End If

        If Russisch_interviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Russisch laut Interviewer")
            Russisch_interviewerComboBox.BackColor = Color.Yellow
        End If

        If Niederlaendisch_interviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Niederländisch laut Interviewer")
            Niederlaendisch_interviewerComboBox.BackColor = Color.Yellow
        End If

        If Deutsch_interviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Deutsch laut Interviewer")
            Deutsch_interviewerComboBox.BackColor = Color.Yellow
        End If

        If KuendigungsfristComboBox.Enabled AndAlso KuendigungsfristComboBox.Text = String.Empty Then
            pflichtfeld.Add("Kündigungsfrist")
            KuendigungsfristComboBox.BackColor = Color.Yellow
        End If

        If MdEComboBox.Text = CStr("Ja") AndAlso Not MdETextBox.ReadOnly AndAlso MdETextBox.Text = String.Empty Then
            pflichtfeld.Add("MdE")
            MdETextBox.BackColor = Color.Yellow
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

        If InterviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Interviewer")
            InterviewerComboBox.BackColor = Color.Yellow
        End If

        If exportfilertf = CStr("{\rtf\ansi\ansicpg1252\uc1\deff0\deflang1033{\fonttbl{\f0 Verdana;}}{\colortbl\red0\green0\blue0 ;}{\*\defchp\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone}{\*\defpap\sl276\slmult1\ql\sa180\ltrpar}{\stylesheet{\s0\sqformat\spriority0\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Normal;}{\*\ts2\tsrowd\spriority59\trbrdrt\brdrnone\trbrdrb\brdrnone\trbrdrl\brdrnone\trbrdrr\brdrnone\trbrdrh\brdrnone\trbrdrv\brdrnone\trgaph0\trpaddl75\trpaddr75\trpaddt0\trpaddb0\clpadft3\clpadt0\clpadfr3\clpadr0\clpadfl3\clpadl0\clpadfb3\clpadb0\tsvertalt\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Table Normal;}}\nouicompat\viewkind4\paperw12240\paperh15840\margl1425\margr1425\margt1425\margb1425\deftab720\sectd\pgwsxn12240\pghsxn15840\marglsxn1425\margrsxn1425\margtsxn1425\margbsxn1425\headery720\footery720\pard\s0\sl276\slmult1\ql\sa180\ltrpar{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\par}}") Then
            pflichtfeld.Add("Persönlichkeit, Äußeres etc.")
            GroupBox10.BackColor = Color.Yellow
        End If

        If MonatsgehaltTextBox.Text = String.Empty Then
            pflichtfeld.Add("Letztes Monatsgehalt")
            MonatsgehaltTextBox.BackColor = Color.Yellow
        End If

        If Gehaltswunsch_monatTextBox.Text = String.Empty Then
            pflichtfeld.Add("Monatswunschgehalt")
            Gehaltswunsch_monatTextBox.BackColor = Color.Yellow
        End If

        If TaetigkeitenTextBox.Text = String.Empty Then
            pflichtfeld.Add("Bisherige Tätigkeiten, berufliche Schwerpunkte, Zeugnistext")
            TaetigkeitenTextBox.BackColor = Color.Yellow
        End If

        pflichtfeldliste = String.Join(vbCrLf, pflichtfeld)

    End Sub
    ' ========================================================================= Ende Pflichtfelder =========================================================================

    ' ========================================================================= Validierung ================================================================================
    Private Sub AnredeComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AnredeComboBox.Validating, BeurteilungComboBox.Validating, HaendedruckComboBox.Validating, ParfumComboBox.Validating, RaucherComboBox.Validating, VerfuegbarkeitComboBox.Validating, Za_vmTextBox.Validating, Vz_tzComboBox.Validating, ArbeitsortTextBox.Validating, FuehrerscheinTextBox.Validating, Pkw_oepnvTextBox.Validating, Tel_mobilTextBox.Validating, Tel_festnetzTextBox.Validating, AnredeComboBox.Validating, Englisch_interviewerComboBox.Validating, Französich_interviewerComboBox.Validating, Spanisch_interviewerComboBox.Validating, Italienisch_interviewerComboBox.Validating, Tuerkisch_interviewerComboBox.Validating, Russisch_interviewerComboBox.Validating, Niederlaendisch_interviewerComboBox.Validating, Deutsch_interviewerComboBox.Validating, KuendigungsfristComboBox.Validating, MdETextBox.Validating, Beendigungsgrund_detailsTextBox.Validating, WechselwunschTextBox.Validating, InterviewerComboBox.Validating, Gehaltswunsch_monatTextBox.Validating, TaetigkeitenTextBox.Validating, OrtsteilTextBox.Validating
        Select Case True

            Case sender Is AnredeComboBox
                If AnredeComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Anrede fehlt")
                    ToolTip1.Show("Anrede fehlt", CType(sender, Control), 1500)
                End If
            Case sender Is Tel_festnetzTextBox
                If Tel_festnetzTextBox.Text = String.Empty AndAlso Tel_mobilTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Entweder Festnetz oder Handy abfragen")
                    ToolTip1.Show("Entweder Festnetz oder Handy abfragen", CType(sender, Control), 1500)
                End If
            Case sender Is Tel_mobilTextBox
                If Tel_festnetzTextBox.Text = String.Empty AndAlso Tel_mobilTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Entweder Festnetz oder Handy abfragen")
                    ToolTip1.Show("Entweder Festnetz oder Handy abfragen", CType(sender, Control), 1500)
                End If
            Case sender Is BeurteilungComboBox
                If BeurteilungComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Beurteilung fehlt")
                    ToolTip1.Show("Beurteilung fehlt", CType(sender, Control), 1500)
                End If
            Case sender Is HaendedruckComboBox
                If HaendedruckComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Händedruck fehlt")
                    ToolTip1.Show("Händedruck fehlt", CType(sender, Control), 1500)
                End If
            Case sender Is ParfumComboBox
                If ParfumComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Parfümeindruck fehlt")
                    ToolTip1.Show("Parfümeindruck fehlt", CType(sender, Control), 1500)
                End If
            Case sender Is RaucherComboBox
                If RaucherComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Raucher?")
                    ToolTip1.Show("Raucher?", CType(sender, Control), 1500)
                End If
            Case sender Is VerfuegbarkeitComboBox
                If VerfuegbarkeitComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Raucher?")
                    ToolTip1.Show("Raucher?", CType(sender, Control), 1500)
                End If

            Case sender Is Za_vmTextBox
                If Za_vmTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Vz_tzComboBox
                If Vz_tzComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is ArbeitsortTextBox
                If ArbeitsortTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is FuehrerscheinTextBox
                If FuehrerscheinTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Pkw_oepnvTextBox
                If Pkw_oepnvTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Englisch_interviewerComboBox
                If Englisch_interviewerComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Französich_interviewerComboBox
                If Französich_interviewerComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Spanisch_interviewerComboBox
                If Spanisch_interviewerComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Italienisch_interviewerComboBox
                If Italienisch_interviewerComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Tuerkisch_interviewerComboBox
                If Tuerkisch_interviewerComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Russisch_interviewerComboBox
                If Russisch_interviewerComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Niederlaendisch_interviewerComboBox
                If Niederlaendisch_interviewerComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Deutsch_interviewerComboBox
                If Deutsch_interviewerComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is KuendigungsfristComboBox
                If KuendigungsfristComboBox.Enabled AndAlso KuendigungsfristComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is MdETextBox
                If MdEComboBox.Text = CStr("Ja") AndAlso Not MdETextBox.ReadOnly AndAlso MdETextBox.Text = String.Empty Then
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

            Case sender Is InterviewerComboBox
                If InterviewerComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If
            Case sender Is MonatsgehaltTextBox
                If MonatsgehaltTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If
            Case sender Is Gehaltswunsch_monatTextBox
                If Gehaltswunsch_monatTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is TaetigkeitenTextBox
                If TaetigkeitenTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is OrtsteilTextBox
                If TaetigkeitenTextBox.Text.Contains("Köln") Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte den Ortsteil von Köln eintragen")
                    ToolTip1.Show("Bitte den Ortsteil von Köln eintragen", CType(sender, Control), 1500)
                End If
        End Select
    End Sub

    Private Sub Vz_tzComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Vz_tzComboBox.SelectedIndexChanged, AuslandsaufenthaltComboBox.SelectedIndexChanged, VerfuegbarkeitComboBox.SelectedIndexChanged, MdEComboBox.SelectedIndexChanged

        If Vz_tzComboBox.Text = String.Empty OrElse Vz_tzComboBox.Text = CStr("Vollzeit") Then
            Teilzeit_stundenComboBox.Enabled = False
            Teilzeit_wannComboBox.Enabled = False
            '  ElseIf Vz_tzComboBox.Text = String.Empty Then
        ElseIf Vz_tzComboBox.Text = CStr("Teilzeit") OrElse Vz_tzComboBox.Text = CStr("Vollzeit/Teilzeit") OrElse Vz_tzComboBox.Text = CStr("Teilzeit flexibel") Then
            Teilzeit_stundenComboBox.Enabled = True
            Teilzeit_wannComboBox.Enabled = True
        End If

        If AuslandsaufenthaltComboBox.Text = CStr("Ja") OrElse AuslandsaufenthaltComboBox.Text = CStr("Geplant") Then
            Auslandsaufenthalt_dauerTextBox.ReadOnly = False
            Auslandsaufenthalt_woTextBox.ReadOnly = False
        Else
            Auslandsaufenthalt_dauerTextBox.ReadOnly = True
            Auslandsaufenthalt_woTextBox.ReadOnly = True
        End If

        If VerfuegbarkeitComboBox.Text = CStr("sofort") OrElse VerfuegbarkeitComboBox.Text = String.Empty Then
            KuendigungsfristComboBox.Enabled = False
        Else
            KuendigungsfristComboBox.Enabled = True
        End If

        If MdEComboBox.Text = CStr("Ja") Then
            MdETextBox.ReadOnly = False
        Else
            MdETextBox.ReadOnly = True
        End If
    End Sub

    Private Sub telefoneintrag()
        If Tel_festnetzTextBox.Text = String.Empty Then
            Tel_festnetzTextBox.Text = CStr("kein Eintrag")
        End If

        If Tel_mobilTextBox.Text = String.Empty Then
            Tel_mobilTextBox.Text = CStr("kein Eintrag")
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

    Private Sub SuchmaschineTextBox_DoubleClick(sender As Object, e As EventArgs) Handles Za_vmTextBox.DoubleClick, ArbeitsortTextBox.DoubleClick, FuehrerscheinTextBox.DoubleClick, Pkw_oepnvTextBox.DoubleClick, Studium_abschlussTextBox.DoubleClick, UlasTextBox.DoubleClick
        Select Case True
          '  Case sender Is SuchmaschineTextBox
            '     frmListboxen.suchmaschine_bool = True
            'Call listboxenaufrufen()
            '   SuchmaschineTextBox.Text = CStr(frmListboxen.suchmaschine)
            'Case sender Is Medien_andereTextBox
            'frmListboxen.anderemedien_bool = True
            '   Call listboxenaufrufen()
            'Medien_andereTextBox.Text = CStr(frmListboxen.anderemedien)
            'Case sender Is JobboerseTextBox
            '   frmListboxen.jobboerse_bool = True
            'Call listboxenaufrufen()
            '   JobboerseTextBox.Text = CStr(frmListboxen.jobboerse)
            'Case sender Is ZeitungTextBox
            'frmListboxen.zeitung_bool = True
            '   Call listboxenaufrufen()
            'ZeitungTextBox.Text = CStr(frmListboxen.zeitung)
            Case sender Is Za_vmTextBox
                frmListboxen.zavm_bool = True
                Call listboxenaufrufen()
                Za_vmTextBox.Text = CStr(frmListboxen.zavm)
            Case sender Is ArbeitsortTextBox
                frmListboxen.arbeitsort_bool = True
                Call listboxenaufrufen()
                ArbeitsortTextBox.Text = CStr(frmListboxen.arbeitsort)
            Case sender Is FuehrerscheinTextBox
                frmListboxen.fuehrerschein_bool = True
                Call listboxenaufrufen()
                FuehrerscheinTextBox.Text = CStr(frmListboxen.fueherschein)
            Case sender Is Pkw_oepnvTextBox
                frmListboxen.oepnv_bool = True
                Call listboxenaufrufen()
                Pkw_oepnvTextBox.Text = CStr(frmListboxen.oepnv)
            Case sender Is Studium_abschlussTextBox
                frmListboxen.studiumsabschluss_bool = True
                Call listboxenaufrufen()
                Studium_abschlussTextBox.Text = CStr(frmListboxen.studiumabschluss)
            Case sender Is UlasTextBox
                frmUlaseintragen.ulas_bool = True
                Using frm = New frmUlaseintragen(Me)
                    Dim result = frm.ShowDialog(Me)
                End Using
                If frmUlaseintragen.ulas_wert <> String.Empty Then
                    UlasTextBox.Text = CStr(frmUlaseintragen.ulas_wert)
                End If
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
    End Sub

    ' bereitet Fremdsprachen für Feld "Sprachkenntnisse" und Tabelle in frmMain auf; es werden die Interviewereinträge verwendet, soweit vorhanden
    Private Sub sprachendaten()
        Dim fremdsprachen As New List(Of String)()

        If Englisch_interviewerComboBox.SelectedIndex <> 0 Then
            fremdsprachen.Add("E" & CInt(Me.Englisch_interviewerComboBox.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf EnglischTextBox.Text <> String.Empty AndAlso Me.Englisch_interviewerComboBox.SelectedIndex = 0 Then
            fremdsprachen.Add("E" & CStr(Me.EnglischTextBox.Text.Substring(0, 1) & vbCrLf))
        End If

        If Französich_interviewerComboBox.SelectedIndex <> 0 Then
            fremdsprachen.Add("F" & CInt(Me.Französich_interviewerComboBox.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf FranzoesischTextBox.Text <> String.Empty AndAlso Französich_interviewerComboBox.SelectedIndex = 0 Then
            fremdsprachen.Add("F" & CStr(Me.FranzoesischTextBox.Text.Substring(0, 1) & vbCrLf))
        End If

        If Spanisch_interviewerComboBox.SelectedIndex <> 0 Then
            fremdsprachen.Add("S" & CInt(Me.Spanisch_interviewerComboBox.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf SpanischTextBox.Text <> String.Empty AndAlso Spanisch_interviewerComboBox.SelectedIndex = 0 Then
            fremdsprachen.Add("S" & CStr(Me.SpanischTextBox.Text.Substring(0, 1) & vbCrLf))
        End If

        If Italienisch_interviewerComboBox.SelectedIndex <> 0 Then
            fremdsprachen.Add("I" & CInt(Me.Italienisch_interviewerComboBox.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf ItalienischTextBox.Text <> String.Empty AndAlso Italienisch_interviewerComboBox.SelectedIndex = 0 Then
            fremdsprachen.Add("I" & CStr(Me.ItalienischTextBox.Text.Substring(0, 1) & vbCrLf))
        End If

        If Tuerkisch_interviewerComboBox.SelectedIndex <> 0 Then
            fremdsprachen.Add("T" & CInt(Me.Tuerkisch_interviewerComboBox.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf TuerkischTextBox.Text <> String.Empty AndAlso Tuerkisch_interviewerComboBox.SelectedIndex = 0 Then
            fremdsprachen.Add("T" & CStr(Me.TuerkischTextBox.Text.Substring(0, 1) & vbCrLf))
        End If

        If Russisch_interviewerComboBox.SelectedIndex <> 0 Then
            fremdsprachen.Add("R" & CInt(Me.Russisch_interviewerComboBox.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf RussischTextBox.Text <> String.Empty AndAlso Russisch_interviewerComboBox.SelectedIndex = 0 Then
            fremdsprachen.Add("R" & CStr(Me.RussischTextBox.Text.Substring(0, 1) & vbCrLf))
        End If

        If Niederlaendisch_interviewerComboBox.SelectedIndex <> 0 Then
            fremdsprachen.Add("N" & CInt(Me.Niederlaendisch_interviewerComboBox.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf NiederlaendischTextBox.Text <> String.Empty AndAlso Niederlaendisch_interviewerComboBox.SelectedIndex = 0 Then
            fremdsprachen.Add("N" & CStr(Me.NiederlaendischTextBox.Text.Substring(0, 1) & vbCrLf))
        End If

        If Deutsch_interviewerComboBox.SelectedIndex <> 0 Then
            fremdsprachen.Add("D" & CInt(Me.Deutsch_interviewerComboBox.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf DeutschTextBox.Text <> String.Empty AndAlso Deutsch_interviewerComboBox.SelectedIndex = 0 Then
            fremdsprachen.Add("D" & CStr(Me.DeutschTextBox.Text.Substring(0, 1) & vbCrLf))
        End If

        sprachenliste = String.Join(String.Empty, fremdsprachen)
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
End Class