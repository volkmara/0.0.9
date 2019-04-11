Imports bewerberpool.BewerberDataSet
Public Class frmTelefoninterview

    Private _frmMain As frmMain

    Public pflichtfeldliste As String = String.Empty
    Public ulas As String = String.Empty
    Public exportfilertf As String = String.Empty
    Public exportfiletxt As String = String.Empty


    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmTelefoninterview_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call Timerreload.Reload() ' Timer für DB-Reload starten
    End Sub

    Private Sub frmTelefoninterview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  Me.BewBindingSource.DataSource = frmMain.BewBindingSource.Current
        ' Me.Bew_bewerberdatenBindingSource.DataSource = frmMain.Bew_bewerberdatenBindingSource.Current
        'Me.Bewerber_ausbildungBindingSource.DataSource = frmMain.Bewerber_ausbildungBindingSource.Current
        'Me.Bewerber_berufserfahrungBindingSource.DataSource = frmMain.Bewerber_berufserfahrungBindingSource.Current
        'Me.Bewerber_sprachenBindingSource.DataSource = frmMain.Bewerber_sprachenBindingSource.Current
        'Me.UlasBindingSource.DataSource = frmMain.UlasBindingSource.Current
        'Me.Bewerber_edvTableAdapter.Fill(Me.BewerberDataSet.bewerber_edv)
        Me.BewBindingSource.AddNew()
        Me.Bew_bewerberdatenBindingSource.AddNew()
        Me.Bewerber_ausbildungBindingSource.AddNew()
        Me.Bewerber_berufserfahrungBindingSource.AddNew()
        Me.Bewerber_sprachenBindingSource.AddNew()
        Me.UlasBindingSource.AddNew()
        Me.Bewerber_edvBindingSource.AddNew()
        Call Timerreload.Timerstop() ' Timer für DB-Reload stoppen
    End Sub

    Private Sub ComboBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles AnredeComboBox.MouseWheel, Vz_tzComboBox.MouseWheel, Teilzeit_stundenComboBox.MouseWheel, Teilzeit_wannComboBox.MouseWheel, UmzugComboBox.MouseWheel, MdEComboBox.MouseWheel, VerfuegbarkeitComboBox.MouseWheel, KuendigungsfristComboBox.MouseWheel, BeendigungsgrundComboBox.MouseWheel, FuehrungsverantwortungComboBox.MouseWheel, PersonalverantwortungComboBox.MouseWheel, AuslandsaufenthaltComboBox.MouseWheel, EnglischComboBox.MouseWheel, FranzoesischComboBox.MouseWheel, DeutschComboBox.MouseWheel, SpanischComboBox.MouseWheel, ItalienischComboBox.MouseWheel, TuerkischComboBox.MouseWheel, RussischComboBox.MouseWheel, NiederlaendischComboBox.MouseWheel, InterviewerComboBox.MouseWheel
        Dim HMEA As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        HMEA.Handled = True
    End Sub


    Private Sub frmTelefoninterview_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call labelfarbe()
        Call comboboxfuellen()

        Me.cmbAufmerksam.Items.AddRange(New String() {"Agentur für Arbeit", "backinjob", "Gigajob", "Indeed", "Jobmonitor", "Jobomat", "Kalaydo", "meinestadt", "Monster", "Placement24", "Rekruter", "stellenmarkt", "Stepstone", "", "Facebook", "Twitter", "Xing", "Google", "Bing", "Yahoo", "Web.de", " ", "Bonner Generalanzeiger", "Kölner Stadtanzeiger", "Rhein-Sieg-Anzeiger", "Regionale Anzeigenblätter", "", "andere"})
    End Sub

    Private Sub export()
        Dim providerrtf As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        Dim providertxt As New Telerik.WinForms.Documents.FormatProviders.Txt.TxtFormatProvider()

        '  Dim exportfilertf As String = String.Empty
        exportfilertf = allgemein.ExporttoRtf(Me.RTEPersoenlichkeit.Document)
        exportfiletxt = allgemein.ExporttoTxt(Me.RTEPersoenlichkeit.Document)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Call export()
        Call pflichtfelder()
        If pflichtfeldliste <> String.Empty Then
            MessageBox.Show("Haben Sie vergessen, diese Felder auszufüllen? " & vbCrLf & vbCrLf & pflichtfeldliste & vbCrLf & vbCrLf & "Nicht schlimm, das kann ja mal passieren. Bitte ergänzen 'Sie' einfach Ihre Angaben. " & vbCrLf & vbCrLf & "Vielen Dank", "Pflichtfelder bitte ausfüllen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim bewspeichern = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
            bewspeichern.interviewer = CStr(Me.InterviewerComboBox.Text)
            bewspeichern.erstkontakt = Date.Now
            bewspeichern.stand = CStr("aktuell")
            bewspeichern.status = CStr("fertig")
            bewspeichern.interviewart = CStr("Telefoninterview")
            bewspeichern.ulas = CStr(ulas)
            bewspeichern.refnr = CInt(letzteid)
            bewspeichern.bewerberbeschreibung = CStr(exportfilertf)
            bewspeichern.bewerberbeschreibung_text = CStr(exportfiletxt)
            Me.Validate()
            Me.BewBindingSource.EndEdit()
            Me.Bew_bewerberdatenBindingSource.EndEdit()
            Me.Bewerber_berufserfahrungBindingSource.EndEdit()
            Me.Bewerber_berufserfahrungBindingSource.EndEdit()
            Me.Bewerber_sprachenBindingSource.EndEdit()
            Me.UlasBindingSource.EndEdit()
            Me.Bewerber_edvBindingSource.EndEdit()
            'Me.BewTableAdapter.Update(BewerberDataSet.bew)
            Me.TableAdapterManager.UpdateAll(BewerberDataSet)
            Call inallentabellen.eintragen()

            ' OpenFD zum Speichern von Originalunterlagen öffnen

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

    Private Sub PlzTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Select Case True
            Case sender Is PlzTextBox
                If Not IsNumeric(PlzTextBox.Text) Then
                    ToolTip1.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                ElseIf PlzTextBox.TextLength <= 4 Then
                    ToolTip1.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                ElseIf PlzTextBox.Text = "" Then
                    ToolTip1.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                End If
        End Select
    End Sub


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

        If StrasseTextBox.Text = String.Empty Then
            pflichtfeld.Add("Straße")
            StrasseTextBox.BackColor = Color.Yellow
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

        If VerfuegbarkeitComboBox.Text = String.Empty Then
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

        If Beruf_positionTextBox.Text = String.Empty Then
            pflichtfeld.Add("Frühere Tätigkeiten")
            Beruf_positionTextBox.BackColor = Color.Yellow
        End If

        If Beruf_schwerpunkttaetigkeitTextBox.Text = String.Empty Then
            pflichtfeld.Add("Schwerpunkttätigkeiten")
            Beruf_schwerpunkttaetigkeitTextBox.BackColor = Color.Yellow
        End If

        If EnglischComboBox.Text = String.Empty Then
            pflichtfeld.Add("Englisch")
            EnglischComboBox.BackColor = Color.Yellow
        End If

        If FranzoesischComboBox.Text = String.Empty Then
            pflichtfeld.Add("Französisch")
            FranzoesischComboBox.BackColor = Color.Yellow
        End If

        If SpanischComboBox.Text = String.Empty Then
            pflichtfeld.Add("Spanisch")
            SpanischComboBox.BackColor = Color.Yellow
        End If

        If ItalienischComboBox.Text = String.Empty Then
            pflichtfeld.Add("Italienisch")
            ItalienischComboBox.BackColor = Color.Yellow
        End If

        If TuerkischComboBox.Text = String.Empty Then
            pflichtfeld.Add("Türkisch")
            TuerkischComboBox.BackColor = Color.Yellow
        End If

        If RussischComboBox.Text = String.Empty Then
            pflichtfeld.Add("Russisch")
            RussischComboBox.BackColor = Color.Yellow
        End If

        If NiederlaendischComboBox.Text = String.Empty Then
            pflichtfeld.Add("Niederländisch")
            NiederlaendischComboBox.BackColor = Color.Yellow
        End If

        If DeutschComboBox.Text = String.Empty Then
            pflichtfeld.Add("Deutsch")
            DeutschComboBox.BackColor = Color.Yellow
        End If

        If KuendigungsfristComboBox.Enabled AndAlso KuendigungsfristComboBox.Text = String.Empty Then
            pflichtfeld.Add("Kündigungsfrist")
            KuendigungsfristComboBox.BackColor = Color.Yellow
        End If

        If MdEComboBox.Text = CStr("Ja") AndAlso Not MdETextBox.ReadOnly AndAlso MdETextBox.Text = String.Empty Then
            pflichtfeld.Add("MdE")
            MdETextBox.BackColor = Color.Yellow
        End If

        If MdEComboBox.Text = CStr("Ja") AndAlso Not Gdb_gradTextBox.ReadOnly AndAlso Gdb_gradTextBox.Text = String.Empty Then
            pflichtfeld.Add("GdB")
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

        If ulas = String.Empty Then
            pflichtfeld.Add("Ulas")
            UlasListBox.BackColor = Color.Yellow
        End If

        '  If BewerberbeschreibungTextBox.Text = String.Empty Then
        'pflichtfeld.Add("Bewerberbeschreibung")
        'BewerberbeschreibungTextBox.BackColor = Color.Yellow
        'End If

        If InterviewerComboBox.Text = String.Empty Then
            pflichtfeld.Add("Interviewer")
            InterviewerComboBox.BackColor = Color.Yellow
        End If

        If ZeugnistextTextBox.Text = String.Empty Then
            pflichtfeld.Add("Zeugnistext")
            ZeugnistextTextBox.BackColor = Color.Yellow
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

        pflichtfeldliste = String.Join(vbCrLf, pflichtfeld)

    End Sub
    ' ========================================================================= Ende Pflichtfelder =========================================================================

    ' ========================================================================= Validierung ================================================================================
    Private Sub AnredeComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AnredeComboBox.Validating, VerfuegbarkeitComboBox.Validating, Za_vmTextBox.Validating, Vz_tzComboBox.Validating, Letzte_beschaeftigungTextBox.Validating, ArbeitsortTextBox.Validating, FuehrerscheinTextBox.Validating, Pkw_oepnvTextBox.Validating, Tel_mobilTextBox.Validating, Tel_festnetzTextBox.Validating, AnredeComboBox.Validating, Beruf_positionTextBox.Validating, Beruf_schwerpunkttaetigkeitTextBox.Validating, KuendigungsfristComboBox.Validating, MdETextBox.Validating, Beendigungsgrund_detailsTextBox.Validating, WechselwunschTextBox.Validating, InterviewerComboBox.Validating, MonatsgehaltTextBox.Validating, Gehaltswunsch_monatTextBox.Validating, DeutschComboBox.Validating, EnglischComboBox.Validating, FranzoesischComboBox.Validating, SpanischComboBox.Validating, ItalienischComboBox.Validating, TuerkischComboBox.Validating, RussischComboBox.Validating, NiederlaendischComboBox.Validating
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

            Case sender Is Beruf_positionTextBox
                If Beruf_positionTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is Beruf_schwerpunkttaetigkeitTextBox
                If Beruf_schwerpunkttaetigkeitTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If
            Case sender Is EnglischComboBox
                If EnglischComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is FranzoesischComboBox
                If FranzoesischComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is SpanischComboBox
                If SpanischComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is ItalienischComboBox
                If ItalienischComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is TuerkischComboBox
                If TuerkischComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is RussischComboBox
                If RussischComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is NiederlaendischComboBox
                If NiederlaendischComboBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Eintragen!")
                    ToolTip1.Show("Eintragen!", CType(sender, Control), 1500)
                End If

            Case sender Is DeutschComboBox
                If DeutschComboBox.Text = String.Empty Then
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
        End Select
    End Sub

    Private Sub Vz_tzComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Vz_tzComboBox.SelectedIndexChanged, AuslandsaufenthaltComboBox.SelectedIndexChanged, VerfuegbarkeitComboBox.SelectedIndexChanged, MdEComboBox.SelectedIndexChanged, SapComboBox.SelectedIndexChanged

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
            Gdb_gradTextBox.ReadOnly = False
        Else
            MdETextBox.ReadOnly = True
            Gdb_gradTextBox.ReadOnly = True
        End If

        If SapComboBox.Text <> CStr("0") Then
            Sap_moduleTextBox.ReadOnly = False
        Else
            Sap_moduleTextBox.ReadOnly = True
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

    End Sub
    ' ========================================================================== Ende Labelformatierung ==================================================================

    ' ========================================================================== Listboxen aufrufen ======================================================================
    Private Sub listboxenaufrufen()
        Using frm = New frmListboxen(Me)
            Dim result = frm.ShowDialog()
        End Using
    End Sub


    Private Sub SuchmaschineTextBox_DoubleClick(sender As Object, e As EventArgs) Handles Za_vmTextBox.DoubleClick, ArbeitsortTextBox.DoubleClick, FuehrerscheinTextBox.DoubleClick, Pkw_oepnvTextBox.DoubleClick, Studium_abschlussTextBox.DoubleClick, Sap_moduleTextBox.DoubleClick
        Select Case True
            'Case sender Is SuchmaschineTextBox
            '    frmListboxen.suchmaschine_bool = True
            '    Call listboxenaufrufen()
            '    SuchmaschineTextBox.Text = CStr(frmListboxen.suchmaschine)
            'Case sender Is Medien_andereTextBox
            '    frmListboxen.anderemedien_bool = True
            '    Call listboxenaufrufen()
            '    Medien_andereTextBox.Text = CStr(frmListboxen.anderemedien)
            'Case sender Is JobboerseTextBox
            '    frmListboxen.jobboerse_bool = True
            '    Call listboxenaufrufen()
            '    JobboerseTextBox'.Text = CStr(frmListboxen.jobboerse)
            'Case sender Is ZeitungTextBox
            '    frmListboxen.zeitung_bool = True
            '    Call listboxenaufrufen()
            '    ZeitungTextBox.Text = CStr(frmListboxen.zeitung)
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
            Case sender Is Sap_moduleTextBox
                frmListboxen.sapmodule_bool = True
                Call listboxenaufrufen()
                Sap_moduleTextBox.Text = CStr(frmListboxen.sapmodule)
        End Select
    End Sub
    ' ============================================================================= Listboxen aufrufen Ende =====================================================================

    Private Sub UlasListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UlasListBox.SelectedIndexChanged
        ulas = String.Empty
        For k As Integer = 0 To Me.UlasListBox.SelectedItems.Count - 1
            ulas &= Me.UlasListBox.SelectedItems.Item(k).ToString & vbCrLf
        Next
    End Sub

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

    ' comboboxen füllen

    Private Sub comboboxfuellen()
        Dim cmbwert As String() = New String() {"0", "1", "2", "3", "4"}

        For Each cmb In Me.GroupBox3.Controls.OfType(Of ComboBox)()
            cmb.Items.AddRange(cmbwert)
        Next

        For Each cmb In Me.GroupBox8.Controls.OfType(Of ComboBox)()
            cmb.Items.AddRange(cmbwert)
        Next

        For Each cmb In Me.GroupBox29.Controls.OfType(Of ComboBox)()
            cmb.Items.AddRange(cmbwert)
        Next
    End Sub

    
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Möchten Sie ihre Eingaben vorher speichern?", "Speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.No Then
            Me.Close()
        ElseIf result = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If
    End Sub
End Class