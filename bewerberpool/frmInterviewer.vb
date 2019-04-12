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

    Private Sub cmbAnrede_Mousewheel(sender As Object, e As MouseEventArgs) Handles cmbAnrede.MouseWheel, cmbBeurteilung.MouseWheel, cmbHaendedruck.MouseWheel, cmbParfum.MouseWheel, cmbRaucher.MouseWheel, cmbVz_tz.MouseWheel, cmbTeilzeit_stunden.MouseWheel, cmbTeilzeit_wann.MouseWheel, cmbUmzug.MouseWheel, VerfuegbarkeitComboBox.MouseWheel, cmbMdE.MouseWheel, KuendigungsfristComboBox.MouseWheel, BeendigungsgrundComboBox.MouseWheel, cmbPersonalverantwortung.MouseWheel, cmbFuehrungsverantwortung.MouseWheel, cmbAuslandsaufenthalt.MouseWheel, cmbEnglisch_interviewer.MouseWheel, cmbFranzösich_interviewer.MouseWheel, cmbSpanisch_interviewer.MouseWheel, cmbItalienisch_interviewer.MouseWheel, cmbRussisch_interviewer.MouseWheel, cmbNiederlaendisch_interviewer.MouseWheel, cmbTuerkisch_interviewer.MouseWheel, cmbDeutsch_interviewer.MouseWheel
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

        Call Berufsausbildung_check()

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

        If VerfuegbarkeitComboBox.SelectedItem Is String.Empty Then
            pflichtfeld.Add("Verfügbarkeit")
            VerfuegbarkeitComboBox.BackColor = Color.Yellow
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

        pflichtfeldliste = String.Join(vbCrLf, pflichtfeld)

    End Sub
    ' ========================================================================= Ende Pflichtfelder =========================================================================

    ' ========================================================================= Validierung ================================================================================
    Private Sub cmbAnrede_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbAnrede.Validating, cmbBeurteilung.Validating, cmbHaendedruck.Validating, cmbParfum.Validating, cmbRaucher.Validating, VerfuegbarkeitComboBox.Validating, txtZa_vm.Validating, cmbVz_tz.Validating, txtArbeitsort.Validating, txtFuehrerschein.Validating, txtPkw_oepnv.Validating, txtTel_mobil.Validating, txtTel_festnetz.Validating, cmbAnrede.Validating, cmbEnglisch_interviewer.Validating, cmbFranzösich_interviewer.Validating, cmbSpanisch_interviewer.Validating, cmbItalienisch_interviewer.Validating, cmbTuerkisch_interviewer.Validating, cmbRussisch_interviewer.Validating, cmbNiederlaendisch_interviewer.Validating, cmbDeutsch_interviewer.Validating, KuendigungsfristComboBox.Validating, txtMdE.Validating, Beendigungsgrund_detailsTextBox.Validating, WechselwunschTextBox.Validating, cmbInterviewer.Validating, txtGehaltswunsch_monat.Validating, txtTaetigkeiten.Validating, txtOrtsteil.Validating
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
            Case sender Is VerfuegbarkeitComboBox
                If VerfuegbarkeitComboBox.Text = String.Empty Then
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
            Case sender Is txtGehaltswunsch_monat
                If txtGehaltswunsch_monat.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

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

    Private Sub Vz_tzComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVz_tz.SelectedIndexChanged, cmbAuslandsaufenthalt.SelectedIndexChanged, VerfuegbarkeitComboBox.SelectedIndexChanged, cmbMdE.SelectedIndexChanged

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

        If VerfuegbarkeitComboBox.Text = CStr("sofort") OrElse VerfuegbarkeitComboBox.Text = String.Empty Then
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

    Private Sub SuchmaschineTextBox_DoubleClick(sender As Object, e As EventArgs) Handles txtZa_vm.DoubleClick, txtArbeitsort.DoubleClick, txtFuehrerschein.DoubleClick, txtPkw_oepnv.DoubleClick, txtStudium_abschluss.DoubleClick, txtUlas.DoubleClick
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

        If cmbEnglisch_interviewer.SelectedIndex <> 0 Then
            fremdsprachen.Add("E" & CInt(Me.cmbEnglisch_interviewer.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf txtEnglisch.Text <> String.Empty AndAlso Me.cmbEnglisch_interviewer.SelectedIndex = 0 Then
            fremdsprachen.Add("E" & CStr(Me.txtEnglisch.Text.Substring(0, 1) & vbCrLf))
        End If

        If cmbFranzösich_interviewer.SelectedIndex <> 0 Then
            fremdsprachen.Add("F" & CInt(Me.cmbFranzösich_interviewer.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf txtFranzoesisch.Text <> String.Empty AndAlso cmbFranzösich_interviewer.SelectedIndex = 0 Then
            fremdsprachen.Add("F" & CStr(Me.txtFranzoesisch.Text.Substring(0, 1) & vbCrLf))
        End If

        If cmbSpanisch_interviewer.SelectedIndex <> 0 Then
            fremdsprachen.Add("S" & CInt(Me.cmbSpanisch_interviewer.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf txtSpanisch.Text <> String.Empty AndAlso cmbSpanisch_interviewer.SelectedIndex = 0 Then
            fremdsprachen.Add("S" & CStr(Me.txtSpanisch.Text.Substring(0, 1) & vbCrLf))
        End If

        If cmbItalienisch_interviewer.SelectedIndex <> 0 Then
            fremdsprachen.Add("I" & CInt(Me.cmbItalienisch_interviewer.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf txtItalienisch.Text <> String.Empty AndAlso cmbItalienisch_interviewer.SelectedIndex = 0 Then
            fremdsprachen.Add("I" & CStr(Me.txtItalienisch.Text.Substring(0, 1) & vbCrLf))
        End If

        If cmbTuerkisch_interviewer.SelectedIndex <> 0 Then
            fremdsprachen.Add("T" & CInt(Me.cmbTuerkisch_interviewer.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf txtTuerkisch.Text <> String.Empty AndAlso cmbTuerkisch_interviewer.SelectedIndex = 0 Then
            fremdsprachen.Add("T" & CStr(Me.txtTuerkisch.Text.Substring(0, 1) & vbCrLf))
        End If

        If cmbRussisch_interviewer.SelectedIndex <> 0 Then
            fremdsprachen.Add("R" & CInt(Me.cmbRussisch_interviewer.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf txtRussisch.Text <> String.Empty AndAlso cmbRussisch_interviewer.SelectedIndex = 0 Then
            fremdsprachen.Add("R" & CStr(Me.txtRussisch.Text.Substring(0, 1) & vbCrLf))
        End If

        If cmbNiederlaendisch_interviewer.SelectedIndex <> 0 Then
            fremdsprachen.Add("N" & CInt(Me.cmbNiederlaendisch_interviewer.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf txtNiederlaendisch.Text <> String.Empty AndAlso cmbNiederlaendisch_interviewer.SelectedIndex = 0 Then
            fremdsprachen.Add("N" & CStr(Me.txtNiederlaendisch.Text.Substring(0, 1) & vbCrLf))
        End If

        If cmbDeutsch_interviewer.SelectedIndex <> 0 Then
            fremdsprachen.Add("D" & CInt(Me.cmbDeutsch_interviewer.SelectedIndex).ToString & vbCrLf)
            'Else
            '   fremdsprachen.Add("E0" & vbCrLf)
        ElseIf txtDeutsch.Text <> String.Empty AndAlso cmbDeutsch_interviewer.SelectedIndex = 0 Then
            fremdsprachen.Add("D" & CStr(Me.txtDeutsch.Text.Substring(0, 1) & vbCrLf))
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