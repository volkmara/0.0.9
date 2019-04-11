Imports MySql
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.UI.Localization
Imports Telerik.WinControls.RichTextEditor
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.Rtf
Imports Telerik.WinForms.Documents.FormatProviders.Txt
Imports Telerik.WinForms.RichTextEditor
Imports Telerik.WinForms.Documents.RichTextBoxCommands
Imports bewerberpool.BewerberDataSet
Imports bewerberpool.heyduckDataSet
Imports Microsoft.Reporting.WinForms
Imports Microsoft.Reporting.WinForms.ReportViewer
Imports System.Collections.Specialized

Public Class frmMain

    Private _frmRundschreibendetail As Object

    ' Shared Sub New()
    '    Telerik.WinControls.RadTypeResolver.Instance.ResolveTypesInCurrentAssembly = True
    'End Sub
    Public Shared Property content As String = String.Empty
    Public dateioeffnen As String = String.Empty
    Public notizenid As Integer = 0 ' speichert die ID der im Notizengrid ausgewählten Anmerkung
    '   Public datum As String = String.Empty
    Public verfuegbarkeit As String = String.Empty

    Private _origulas As FileInfo()
    Private _bearbeitetulas As FileInfo()

    Public ulasoriginalverzeichnis As String
    Public ulasbearbeitetverzeichnis As String
    Public sprachenliste As String

    Public alter As Integer

    ' Für Drag and Drop
    Private _GrabOffset As Size
    Private Const _Tolerance As Double = 5 ^ 2

    'Public Inet As Boolean = allgemein.Inetverbindung(Inet)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberDataSet.rundschreiben". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.RundschreibenTableAdapter.Fill(Me.BewerberDataSet.rundschreiben)
        Call login() ' prüft, ob sich ein valider Benutzer einloggen will
        Call Internetverbindung()
        Call DBLoad()
        RadGridLocalizationProvider.CurrentProvider = New MyGermanRadGridLocalizationProvider()
        DataFilterLocalizationProvider.CurrentProvider = New GermanDataFilterLocalizationProvider()
        If connectionString.Contains("127.0.0.1") Then
            RichTextBoxLocalizationProvider.CurrentProvider = RichTextBoxLocalizationProvider.FromFile("RichTextBoxStrings.xml")
        Else
            RichTextBoxLocalizationProvider.CurrentProvider = RichTextBoxLocalizationProvider.FromFile("x:\bewerberpool\RichTextBoxStrings.xml")
        End If
        Call einloggen.logincheck() ' setzt Einstellung anhand der Stufe, zu der der User gehört
        Call Timerreload.Reload() ' Timer für DB-Reload starten
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call formatierung.Labelfarbe()
        Call tabellen.tabellenheader()
        Call Comboboxfill() ' Werte in Sprachencomboboxen eintragen, Index 0 setzen
        Me.BewGridView1.Rows(0).IsCurrent = True
        ' Me.BewGridView1.Columns(24).WrapText = True
        'letzteid = CInt(Me.BewGridView1.CurrentRow.Cells(0).Value)
        Me.BewGridView1.MasterTemplate.ShowFilterCellOperatorText = False
        ' Beim Start alle Detailfelder ausblenden
        For Each pan In Me.SplitContainer1.Panel2.Controls.OfType(Of Panel)()
            If CInt(letzteid) = 0 Then
                pan.Visible = False
            End If
        Next

        If loginflag = 8 OrElse loginflag = 9 Then
            BewerbervollstaendigloeschenRadMenuItem2.Visibility = ElementVisibility.Visible
        Else
            BewerbervollstaendigloeschenRadMenuItem2.Visibility = ElementVisibility.Collapsed
        End If
    End Sub

    ' ============================================================================= Panel ausblenden, wenn kein Bewerber ausgewählt ===========================
    Private Sub panelausblenden()
        For Each pan In Me.SplitContainer1.Panel2.Controls.OfType(Of Panel)()
            If CInt(letzteid) = 0 Then
                pan.Visible = False
            ElseIf CInt(letzteid) <> 0 Then
                pan.Visible = True
            End If
        Next
    End Sub

    '================================================================================ Login ==================================================================================
    Private Sub login()
        Using frm = New frmLogin(Me)
            Dim result = frm.ShowDialog()
        End Using
    End Sub
    ' ================================================================================ Ende Login ===========================================================================

    ' ======================================================================= Mausrad deaktivieren ====================================================================================
    Private Sub Ignore_MouseWheel(sender As Object, e As MouseEventArgs)
        DirectCast(e, HandledMouseEventArgs).Handled = True
    End Sub

    Private Sub ComboBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles VerfuegbarkeitComboBox.MouseWheel, Teilzeit_stundenComboBox.MouseWheel, Teilzeit_wannComboBox.MouseWheel, AnredeComboBox.MouseWheel, StandComboBox.MouseWheel, StatusComboBox.MouseWheel, InterviewartComboBox.MouseWheel, InterviewerComboBox.MouseWheel, BrancheComboBox.MouseWheel, StaatsangehörigkeitComboBox.MouseWheel, AufenhaltstitelComboBox.MouseWheel, ArbeitserlaubnisComboBox.MouseWheel, FamilienstandComboBox.MouseWheel, Kinder_betreuungComboBox.MouseWheel, SteuerklasseComboBox.MouseWheel, KonfessionComboBox.MouseWheel, VorstrafenComboBox1.MouseWheel, KrankheitenComboBox1.MouseWheel, SchulabschlussComboBox.MouseWheel, HaendedruckComboBox.MouseWheel, ParfumComboBox.MouseWheel, RaucherComboBox.MouseWheel, SchulabschlussComboBox.MouseWheel, FuehrungsverantwortungComboBox.MouseWheel, PersonalverantwortungComboBox.MouseWheel
        Dim HMEA As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        HMEA.Handled = True
    End Sub

    ' `====================================================================== Ende Mausrad deaktivieren =============================================================================

    ' Click auf BewGridView1 auf Tabpage1: Spalten in Tabelle austauschen, letzteid definieren
    Private Sub BewGridView1_Click(sender As Object, e As EventArgs) Handles BewGridView1.Click
        'Dim bewgrid = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        '  If Not bewgrid.Isausbildungsberuf_bpoolaltNull Then
        '    letzteid = CInt(0)
        Dim bewgrid = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        letzteid = CInt(bewgrid.id_bew)

        ' BewGridView1.Columns(42).IsVisible = True 
        'BewGridView1.Columns(57).IsVisible = True
        'BewGridView1.Columns(59).IsVisible = True
        'BewGridView1.Columns(60).IsVisible = True
        '  Else
        '  BewGridView1.Columns(42).IsVisible = False
        'BewGridView1.Columns(32).IsVisible = False
        'BewGridView1.Columns(33).IsVisible = False
        ' End If

        Call panelausblenden() ' Panel ausblenden, wenn letzteid 0 ist
        ' Call fertig() ' Wenn Status auf ausgedruckt steht
        'Call Anmerkung() ' Überprüft, ob eine Row mit der abgefragten bewid in der Notizen-DB enthalten ist
        'Call bewerberbeschreibungladen() ' Lädt Bewerberbeschreibung und prüft, ob RTF oder nicht
        Call letzteanmerkunganzeigen() ' zeigt letzte Anmerkung auf Tab Bewerber/in an, darf hier nicht aktiviert werden
        Call ulaseinlesen() ' Ulas in Listbox einlesen
        Call bearbeiteteulaseinlesen() 'bearbeitete Ulas in Listbox einlesen
        'Call interviewerbogenanzeigen() ' Interviewerfragebogen nur zugänglich, wenn Stand nicht auf "fertig steht
        'Call ulascheck() ' Anzeigen, ob Ulas abgespeichert wurden
        'Call rundschreibencheck() ' Prüfen und anzeigen, ob Bewerber für Rundschreiben vorgesehen ist
        Call refnrhomepage()
    End Sub

    Private Sub BewGridView1_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs) Handles BewGridView1.CurrentRowChanged
        '    letzteid = CInt(0)
        Dim bewgrid = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        letzteid = CInt(bewgrid.id_bew)
        Call panelausblenden()
        Call fertig() ' Wenn Status auf ausgedruckt steht
        Call Anmerkung() ' Überprüft, ob eine Row mit der abgefragten bewid in der Notizen-DB enthalten ist
        Call bewerberbeschreibungladen() ' Lädt Bewerberbeschreibung und prüft, ob RTF oder nicht
        Call letzteanmerkunganzeigen() ' zeigt letzte Anmerkung auf Tab Bewerber/in an, darf hier nicht aktiviert werden
        Call ulaseinlesen() ' Ulas in Listbox einlesen
        Call bearbeiteteulaseinlesen() 'bearbeitete Ulas in Listbox einlesen
        Call interviewerbogenanzeigen() ' Interviewerfragebogen nur zugänglich, wenn Stand nicht auf "fertig steht
        Call ulascheck() ' Anzeigen, ob Ulas abgespeichert wurden
        Call rundschreibencheck() ' Prüfen und anzeigen, ob Bewerber für Rundschreiben vorgesehen ist
        Call refnrhomepage()
        Call topbewerberundinterviewerpruefen()
    End Sub

#Region " ======================================================================== Methoden zum Laden und Speichern ======================================"
    ' Daten aus DB laden
    Public Shared Sub DBLoad()
        frmMain.BewerberDataSet.Clear()
        frmMain.BewTableAdapter.Fill(frmMain.BewerberDataSet.bew)
        frmMain.Bew_bewerberdatenTableAdapter.Fill(frmMain.BewerberDataSet.bew_bewerberdaten)
        frmMain.UlasTableAdapter.Fill(frmMain.BewerberDataSet.ulas)
        frmMain.Bewerber_berufserfahrungTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_berufserfahrung)
        frmMain.Bewerber_ausbildungTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_ausbildung)
        frmMain.Bewerber_sprachenTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_sprachen)
        frmMain.Bewerber_edvTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_edv)
        frmMain.Bewerber_bueroTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_buero)
        frmMain.Bew_assistenzTableAdapter.Fill(frmMain.BewerberDataSet.bew_assistenz)
        frmMain.Bewerber_raeTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_rae)
        frmMain.Bewerber_vertriebTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_vertrieb)
        frmMain.Bewerber_einkaufTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_einkauf)
        frmMain.Bewerber_versandTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_versand)
        frmMain.Bewerber_logistikTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_logistik)
        frmMain.Bewerber_marketing_designTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_marketing_design)
        frmMain.Bewerber_fibuTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_fibu)
        frmMain.Bew_bibuhaTableAdapter.Fill(frmMain.BewerberDataSet.bew_bibuha)
        frmMain.Bewerber_controllingTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_controlling)
        frmMain.Bew_steuerfachangestellteTableAdapter.Fill(frmMain.BewerberDataSet.bew_steuerfachangestellte)
        frmMain.Bewerber_personalTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_personal)
        frmMain.Bew_lugTableAdapter.Fill(frmMain.BewerberDataSet.bew_lug)
        frmMain.Bewerber_technikTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_technik)
        frmMain.Bewerber_itTableAdapter.Fill(frmMain.BewerberDataSet.bewerber_it)
        frmMain.GewerblichTableAdapter.Fill(frmMain.BewerberDataSet.gewerblich)
        '  Me.NotizenTableAdapter.FillBy(Me.BewerberDataSet.notizen, CInt(bewid))
        frmMain.NotizenTableAdapter.Fill(frmMain.BewerberDataSet.notizen)
        frmMain.RundschreibenTableAdapter.Fill(frmMain.BewerberDataSet.rundschreiben)
        ' frmMain.BewerberDataSet.notizen.Clear()
        '   frmMain.Oa_stelleTableAdapter.Fill(frmMain.OaDataSet.oa_stelle)
        If Inet Then
            frmMain.Tt_newsTableAdapter.Fill(frmMain.HeyduckDataSet.tt_news)
        End If

        ' letzteid auf Null setzen bei Reload, Panel ausblenden
        letzteid = CInt(0)
        For Each pan In frmMain.SplitContainer1.Panel2.Controls.OfType(Of Panel)()
            If CInt(letzteid) = 0 Then
                pan.Visible = False
            End If
        Next
    End Sub

    ' Daten speichern
    Public Shared Sub DBSpeichern()

        Call frmMain.Altersberechnung() ' berechnet das Alter anhand des Geburtstags
        Call frmMain.sprachendaten() ' trägt Sprachkenntnisse (neu) ein
        Dim bewspeichern = DirectCast(DirectCast(frmMain.BewBindingSource.Current, DataRowView).Row, bewRow)
        bewspeichern.geaendert_am = Date.Now.ToString
        bewspeichern.letztbearbeitung_von = CStr(usernameklar)

        If frmMain.sprachenliste <> String.Empty Then ' Sprachkenntnisse werden nur eingetragen, wenn die Variable sprachenliste nicht leer ist
            bewspeichern.sprachkenntnisse = CStr(frmMain.sprachenliste)
        End If

        If frmMain.UlasTextBox.Text = String.Empty Then
            MessageBox.Show("Bitte Ulas eintragen", "Ulas eintragen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If frmMain.UlasTextBox.Text.Contains("10") Then ' Wenn bei Ulas "10" eingetragen wurde, wird der Status ebenfalls auf zehn gesetzt
            bewspeichern.stand = CStr("10")
        End If

        ' Bewerberbeschreibung auslesen und speichern
        ' bewspeichern.bewerberbeschreibung = CStr(allgemein.ExporttoRtf(frmMain.RTEBewerberbeschreibung.Document))
        'bewspeichern.bewerberbeschreibung_text = CStr(allgemein.ExporttoTxt(frmMain.RTEBewerberbeschreibung.Document))

        ' Einträge in Persönlichkeit nur, wenn tatsächlich etwas in frmPersönlichkeitbearbeiten geändert wurde
        If frmPersönlichkeitbearbeiten.bewerberbeschreibung <> String.Empty Then
            bewspeichern.bewerberbeschreibung = frmPersönlichkeitbearbeiten.bewerberbeschreibung
        End If
        If frmPersönlichkeitbearbeiten.bewerberbeschreibungtext <> String.Empty Then
            bewspeichern.bewerberbeschreibung_text = frmPersönlichkeitbearbeiten.bewerberbeschreibungtext
        End If

        bewspeichern.alter = CInt(frmMain.alter)

        ' topbewerber
        If frmMain.cmbTopbewerber.SelectedItem Is CStr("VM") OrElse frmMain.cmbTopbewerber.SelectedItem Is CStr("ZA") Then
            Call frmMain.mailtopbewerber()
            bewspeichern.topbewerberchecked = True
        ElseIf frmMain.cmbTopbewerber.SelectedItem Is CStr("Nein") Then
            bewspeichern.topbewerberchecked = False
        End If

        frmMain.Validate()
        frmMain.BewBindingSource.EndEdit()
        frmMain.Bew_bewerberdatenBindingSource.EndEdit()
        frmMain.UlasBindingSource.EndEdit()
        frmMain.Bewerber_berufserfahrungBindingSource.EndEdit()
        frmMain.Bewerber_ausbildungBindingSource.EndEdit()
        frmMain.Bewerber_sprachenBindingSource.EndEdit()
        frmMain.Bewerber_edvBindingSource.EndEdit()
        frmMain.Bewerber_bueroBindingSource.EndEdit()
        frmMain.Bew_assistenzBindingSource.EndEdit()
        frmMain.Bewerber_raeBindingSource.EndEdit()
        frmMain.Bewerber_vertriebBindingSource.EndEdit()
        frmMain.Bewerber_einkaufBindingSource.EndEdit()
        frmMain.Bewerber_versandBindingSource.EndEdit()
        frmMain.Bewerber_logistikBindingSource.EndEdit()
        frmMain.Bewerber_marketing_designBindingSource.EndEdit()
        frmMain.Bewerber_fibuBindingSource.EndEdit()
        frmMain.Bew_bibuhaBindingSource.EndEdit()
        frmMain.Bewerber_controllingBindingSource.EndEdit()
        frmMain.Bew_steuerfachangestellteBindingSource.EndEdit()
        frmMain.Bewerber_personalBindingSource.EndEdit()
        frmMain.Bew_lugBindingSource.EndEdit()
        frmMain.Bewerber_technikBindingSource.EndEdit()
        frmMain.Bewerber_itBindingSource.EndEdit()
        frmMain.GewerblichBindingSource.EndEdit()

        frmMain.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)
        frmMain.Bew_bewerberdatenTableAdapter.Update(frmMain.BewerberDataSet.bew_bewerberdaten)
        frmMain.UlasTableAdapter.Update(frmMain.BewerberDataSet.ulas)
        frmMain.Bewerber_ausbildungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_ausbildung)
        frmMain.Bewerber_berufserfahrungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_berufserfahrung)
        frmMain.Bewerber_sprachenTableAdapter.Update(frmMain.BewerberDataSet.bewerber_sprachen)
        frmMain.Bewerber_edvTableAdapter.Update(frmMain.BewerberDataSet.bewerber_edv)
        frmMain.Bewerber_bueroTableAdapter.Update(frmMain.BewerberDataSet.bewerber_buero)
        frmMain.Bew_assistenzTableAdapter.Update(frmMain.BewerberDataSet.bew_assistenz)
        frmMain.Bewerber_raeTableAdapter.Update(frmMain.BewerberDataSet.bewerber_rae)
        frmMain.Bewerber_vertriebTableAdapter.Update(frmMain.BewerberDataSet.bewerber_vertrieb)
        frmMain.Bewerber_einkaufTableAdapter.Update(frmMain.BewerberDataSet.bewerber_einkauf)
        frmMain.Bewerber_versandTableAdapter.Update(frmMain.BewerberDataSet.bewerber_versand)
        frmMain.Bewerber_logistikTableAdapter.Update(frmMain.BewerberDataSet.bewerber_logistik)
        frmMain.Bewerber_marketing_designTableAdapter.Update(frmMain.BewerberDataSet.bewerber_marketing_design)
        frmMain.Bewerber_fibuTableAdapter.Update(frmMain.BewerberDataSet.bewerber_fibu)
        frmMain.Bew_bibuhaTableAdapter.Update(frmMain.BewerberDataSet.bew_bibuha)
        frmMain.Bewerber_controllingTableAdapter.Update(frmMain.BewerberDataSet.bewerber_controlling)
        frmMain.Bew_steuerfachangestellteTableAdapter.Update(frmMain.BewerberDataSet.bew_steuerfachangestellte)
        frmMain.Bewerber_personalTableAdapter.Update(frmMain.BewerberDataSet.bewerber_personal)
        frmMain.Bew_lugTableAdapter.Update(frmMain.BewerberDataSet.bew_lug)
        frmMain.Bewerber_technikTableAdapter.Update(frmMain.BewerberDataSet.bewerber_technik)
        frmMain.Bewerber_itTableAdapter.Update(frmMain.BewerberDataSet.bewerber_it)
        frmMain.GewerblichTableAdapter.Update(frmMain.BewerberDataSet.gewerblich)
        Call gespeichert() ' Messagebox wird angezeigt
        ' Call frmMain.topbewerbercheck()

        Call frmMain.BewerberaufHomepagedeaktivieren()

        ' Wenn Status = alt, Fenster für Anmerkung öffnen, Abspeichern zuerst, sonst öffnet sich das immer
        Select Case frmMain.StatusComboBox.SelectedIndex
            Case 2 'alt
                frmNeueAnmerkunganlegen.alt_bool = True
                Using frm = New frmNeueAnmerkunganlegen(frmMain)
                    Dim result = frm.ShowDialog
                End Using
                Call frmMain.mailbeialt()
            Case 4 ' eingestellt
                frmNeueAnmerkunganlegen.eingestellt_bool = True
                Using frm = New frmNeueAnmerkunganlegen(frmMain)
                    Dim result = frm.ShowDialog
                End Using
            Case 5 'vermittelt
                If usernameklar = CStr("baum") Then
                    Call frmMain.baum()
                End If
                frmNeueAnmerkunganlegen.vermittelt_bool = True
                Using frm = New frmNeueAnmerkunganlegen(frmMain)
                    Dim result = frm.ShowDialog
                End Using
            Case 6 'eingestellt und vermittelt
                If usernameklar = CStr("baum") Then
                    Call frmMain.baum()
                End If
                frmNeueAnmerkunganlegen.eingestellt_vermittelt_bool = True
                Using frm = New frmNeueAnmerkunganlegen(frmMain)
                    Dim result = frm.ShowDialog
                End Using
        End Select

        frmPersönlichkeitbearbeiten.bewerberbeschreibung = String.Empty
        frmPersönlichkeitbearbeiten.bewerberbeschreibungtext = String.Empty
    End Sub

    Private Sub BewerberaufHomepagedeaktivieren()

        Dim homepage = HeyduckDataSet.tt_news.Where(Function(x) CInt(x.tx_ttnewserweiterung_referenznummer) = CInt(letzteid) AndAlso x.deleted = 0)

        If StatusComboBox.SelectedIndex = CInt(2) OrElse StatusComboBox.SelectedIndex = CInt(4) OrElse StatusComboBox.SelectedIndex = CInt(5) OrElse StatusComboBox.SelectedIndex = CInt(6) OrElse StatusComboBox.SelectedIndex = CInt(7) Then
            Dim result As DialogResult = MessageBox.Show("Soll der ausgewählte Bewerber/die ausgewählte Bewerberin auf der Homepage deaktiviert werden", "Bewerber/in deaktivieren", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
            If result = DialogResult.Cancel Then
                Exit Sub
            ElseIf result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                For Each x In homepage
                    x.deleted = CInt(1)
                    Me.Validate()
                    Me.Tt_newsBindingSource.EndEdit()
                    Me.Tt_newsTableAdapter.Update(Me.HeyduckDataSet.tt_news)
                Next
                Me.Tt_newsTableAdapter.Fill(Me.HeyduckDataSet.tt_news)
            End If
        End If
    End Sub


#End Region

    Private Sub refnrhomepage()
        If Inet Then
            Dim bewerber = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)
            rf = bewerber.refnr.ToString
            If HeyduckDataSet.tt_news.Any(Function(x) (x.tx_ttnewserweiterung_referenznummer) = rf) Then
                Me.Panel41.Visible = True
            Else
                Me.Panel41.Visible = False
            End If
        End If
    End Sub

#Region "Prüfen, ob ein Bewerber schon im Rundschreiben war und ob es sich um einen Topbewerber handelt"
    'Private Sub SetConditions()
    'Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

    'Dim c1 As New ExpressionFormattingObject("1", "rundschreibenjanein", True)
    ' c1.RowBackColor = Color.PaleGreen
    'c1.RowBackColor = Color.FromArgb(203, 252, 215)
    'c1.RowBackColor = Color.FromArgb(205, 249, 216)
    ' c1.CellBackColor = Color.PaleGreen
    'c1.CellBackColor = Color.FromArgb(203, 252, 215)
    'c1.CellBackColor = Color.FromArgb(205, 249, 216)
    'c1.CellFont = newFont10
    'c1.RowFont = newFont10
    'BewGridView1.Columns("name").ConditionalFormattingObjectList.Add(c1)

    '   Dim c2 As New ExpressionFormattingObject("rundschreiben", "rundschreiben", False)
    '  c2.RowBackColor = Color.Yellow
    ' c2.CellBackColor = Color.Yellow
    '  c1.CellFont = newFont10
    ' c1.RowFont = newFont10
    'BewGridView1.Columns("name").ConditionalFormattingObjectList.Add(c2)
    ' End Sub

    Private Sub rundschreibencheck()
        ' Dim rundschreiben = DirectCast(DirectCast(RundschreibenBindingSource.Current, DataRowView).Row, rundschreibenRow)
        Dim rundschreiben = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)
        If rundschreiben.IsrundschreibenjaneinNull Then
            Exit Sub
        ElseIf rundschreiben.rundschreibenjanein = CInt(1) Then
            btnRundschreiben.BackColor = Color.LightSteelBlue
        ElseIf Not rundschreiben.rundschreibenjanein = CInt(1) Then
            btnRundschreiben.BackColor = Color.WhiteSmoke
        End If

        'If Not Me.BewerberDataSet.rundschreiben.Any(Function(x) x.bewid = letzteid) Then
        'btnRundschreiben.BackColor = Color.WhiteSmoke
        'ElseIf Me.BewerberDataSet.rundschreiben.Any(Function(x) x.bewid = letzteid) Then
        'btnRundschreiben.BackColor = Color.LightSteelBlue
        'End If
    End Sub

    Private Sub topbewerberundinterviewerpruefen()

        Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

        Dim obj = New ConditionalFormattingObject("Top", ConditionTypes.Contains, "VM", "", True)
        obj.RowBackColor = Color.FromArgb(191, 239, 202)
        obj.CellFont = newFont10
        Me.BewGridView1.Columns("Top").ConditionalFormattingObjectList.Add(obj)

        Dim obj1 = New ConditionalFormattingObject("Top", ConditionTypes.Contains, "ZA", "", True)
        obj1.CellFont = newFont10
        obj1.RowBackColor = Color.FromArgb(245, 192, 241)
        Me.BewGridView1.Columns("Top").ConditionalFormattingObjectList.Add(obj1)

        Dim obj2 = New ConditionalFormattingObject("Interviewer", ConditionTypes.DoesNotContain, "fertig", "", True)
        obj2.RowBackColor = Color.Cyan
        obj2.CellFont = newFont10
        Me.BewGridView1.Columns("Status").ConditionalFormattingObjectList.Add(obj2)
    End Sub
#End Region

    ' ================================================================================ Hauptmenu ============================================================================
    Private Sub BewerbungsgesprächRadMenuItem1_Click(sender As Object, e As EventArgs) Handles VersionRadMenuItem1.Click, BewerberloeschenRadMenuItem2.Click, BenutzerverwaltungRadMenuItem2.Click, UnterlagenspeichernRadMenuItem.Click, Bewerber_innenaufHomepageRadMenuItem1.Click, DetailansichtRadMenuItem1.Click, BewerbervollstaendigloeschenRadMenuItem2.Click
        Select Case True
            Case sender Is VersionRadMenuItem1
                Using frm = New frmVersionshinweise(Me)
                    Dim result = frm.ShowDialog()
                End Using
            Case sender Is BenutzerverwaltungRadMenuItem2
                If Not connectionString.Contains("127.0.0.1") Then
                    System.Diagnostics.Process.Start("x:\benutzerverwaltung\benutzerverwaltung.exe")
                Else
                    System.Diagnostics.Process.Start("E:\heyduck\benutzerverwaltung\benutzerverwaltung\benutzerverwaltung\bin\Debug\benutzerverwaltung.exe")
                End If
            Case sender Is BewerberloeschenRadMenuItem2
                Call bewerberloeschen()
            Case sender Is UnterlagenspeichernRadMenuItem
                If Not connectionString.Contains("127.0.0.1") Then
                    System.Diagnostics.Process.Start("x:\bewerberpool\Anleitungen\Anleitung zum Abspeichern von Unterlagen.pdf")
                Else
                    System.Diagnostics.Process.Start("E:\heyduck\bewerberpool-neu\anleitungen\Anleitung zum Abspeichern von Unterlagen.pdf")
                End If
            Case sender Is Bewerber_innenaufHomepageRadMenuItem1
                Using frm = New frmHomepage(Me)
                    Dim result = frm.ShowDialog()
                End Using
            Case sender Is DetailansichtRadMenuItem1
                Using frm = New frmHomepageindividuell(Me)
                    Dim result = frm.ShowDialog()
                End Using
            Case sender Is BewerbervollstaendigloeschenRadMenuItem2
                Call Bewerberkomplettloeschen()
        End Select
    End Sub

    ' ================================================================================ Ende Hauptmenu ============================================================================

    ' ================================================================================ Bewerber auf gelöscht setzen =============================================================
    Private Sub bewerberloeschen()
        If letzteid = CInt(0) Then
            MessageBox.Show("Bitte zuerst den zu löschenden Bewerber auswählen!", "Bewerber auswählen", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            ' Me.StatusComboBox.Text = CStr("gelöscht")
            Dim bewgrid = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
            bewgrid.stand = CStr("gelöscht")
            Me.Validate()
            Me.BewBindingSource.EndEdit()
            Me.BewTableAdapter.Update(BewerberDataSet.bew)
            ' Call frmMain.DBSpeichern()
            Call frmMain.DBLoad()
        End If
    End Sub

    ' ================================================================================ Ende Bewerber auf gelöscht setzen ========================================================

#Region "=============================================================================Buttons===================================================================================="
    ' Button Speichern, Neu anlegen, Daten laden, Drucken, neue anmerkung
    Private Sub SpeichernRadMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernRadMenuItem.Click, SpeichernNeuladenRadMenuItem.Click, BewerberneuRadButton.Click, DatenladenRadMenuItem2.Click, DatenladenfilterRadMenuItem2.Click, FilterzurückRadButton.Click, DruckenRadMenuItem2.Click, DruckenRadMenuItem3.Click, DruckenRadMenuItem4.Click, NeueAnmerkungRadButton.Click, Interviewerbogen.Click, Kurzfragebogen.Click, TelefoninterviewRadMenuItem.Click, AufklappenRadMenuItem1.Click, EinklappenRadMenuItem1.Click, btnBearbeitungspeichern.Click, Top10auswaehlen.Click, Top10ExceloeffnenRadMenuItem.Click, Top10anzeigen.Click, btnDatenBewerbertooleinlesen.Click, Rundschreibenuebersicht.Click
        Select Case True
            Case sender Is SpeichernRadMenuItem
                Call DBSpeichern()

            Case sender Is SpeichernNeuladenRadMenuItem
                Call DBSpeichern()
                Me.BewGridView1.FilterDescriptors.Clear()
                Call DBLoad()
                TabControl1.SelectedTab = TabPage1

            Case sender Is BewerberneuRadButton
                Using frm = New frmNeuerBewerberanlegen(Me)
                    Dim result = frm.ShowDialog
                End Using

            Case sender Is DatenladenRadMenuItem2
                Dim result As DialogResult = MessageBox.Show("Möchten Sie ihre Eingaben vorher speichern?", "Speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.No Then
                    Call DBLoad()
                ElseIf result = Windows.Forms.DialogResult.Yes Then
                    Exit Sub
                End If

            Case sender Is DatenladenfilterRadMenuItem2
                Dim result As DialogResult = MessageBox.Show("Möchten Sie ihre Eingaben vorher speichern?", "Speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.No Then
                    Me.BewGridView1.FilterDescriptors.Clear()
                    Call DBLoad()
                ElseIf result = Windows.Forms.DialogResult.Yes Then
                    Exit Sub
                End If

            Case sender Is FilterzurückRadButton
                Dim result As DialogResult = MessageBox.Show("Möchten Sie ihre Eingaben vorher speichern?", "Speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.No Then
                    Me.BewGridView1.FilterDescriptors.Clear()
                    Me.BewGridView1.Rows(0).IsCurrent = True
                ElseIf result = Windows.Forms.DialogResult.Yes Then
                    Exit Sub
                End If

            Case sender Is DruckenRadMenuItem2
                frmBogendruck.auswahlbewerberbogen_bool = True
                Using frm = New frmBogendruck(Me)
                    Dim result = frm.ShowDialog
                End Using
                frmBogendruck.auswahlbewerberbogen_bool = False

            Case sender Is DruckenRadMenuItem3
                frmBogendruck.auswahlbewerberbogenergänzt_bool = True
                Using frm = New frmBogendruck(Me)
                    Dim result = frm.ShowDialog
                End Using
                frmBogendruck.auswahlbewerberbogenergänzt_bool = False

            Case sender Is DruckenRadMenuItem4
                frmBogendruck.auswahlkopfbogen_bool = True
                Using frm = New frmBogendruck(Me)
                    Dim result = frm.ShowDialog
                End Using
                frmBogendruck.auswahlkopfbogen_bool = False

            Case sender Is NeueAnmerkungRadButton
                frmNeueAnmerkunganlegen.anmerkungneu_bool = True
                Using frm = New frmNeueAnmerkunganlegen(Me)
                    Dim result = frm.ShowDialog
                End Using

            Case sender Is btnBearbeitungspeichern
                Call anmerkunggeaendertspeichern()

            Case sender Is Interviewerbogen
                ' Call Intervieweraufrufen()
                Using frm = New frmInterviewer(Me)
                    Dim result = frm.ShowDialog(Me)
                End Using

            Case sender Is Kurzfragebogen
                Using frm = New frmKurzfragebogen(Me)
                    Dim result = frm.ShowDialog
                End Using

            Case sender Is TelefoninterviewRadMenuItem
                Using frm = New frmTelefoninterview(Me)
                    Dim result = frm.ShowDialog
                End Using

            Case sender Is AufklappenRadMenuItem1
                BewGridView1.AutoSizeRows = True
                Me.BewGridView1.Columns(24).WrapText = True

            Case sender Is EinklappenRadMenuItem1
                BewGridView1.AutoSizeRows = False
                Me.BewGridView1.Columns(24).WrapText = False

            Case sender Is Top10auswaehlen ' Bewerber für Rundschreiben auswählen

                If CInt(letzteid) = 0 Then
                    MessageBox.Show("Es wurde kein Bewerber/keine Bewerberin für das Rundschreiben ausgewählt." & vbNewLine & vbNewLine & "Bitte wählen Sie zuerst einen Bewerber/eine Bewerberin in der Tabelle aus", "Kein/e Bewerberin ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If

                If BewerberDataSet.rundschreiben.Any(Function(x) x.bewid = CInt(letzteid) AndAlso x.aktuell = CInt(1)) Then
                    MessageBox.Show("Diese/r Bewerber/in ist bereits für das kommende Rundschreiben vorgesehen. Darum leuchtet der Rundschreiben-Button in diesem scheußlichen Blau. Wieder ein Mausklick zuviel...", "Ist bereits für das kommende Rundschreiben vorgesehen", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub
                Else
                    Using frm = New frmRundschreibendetail(Me)
                        Dim result = frm.ShowDialog(Me)
                        frm.BewerberDataSet = Me.BewerberDataSet
                        frm.BewTableAdapter = Me.BewTableAdapter
                        frm.RundschreibenTableAdapter = Me.RundschreibenTableAdapter
                        frm.BewBindingSource.DataSource = Me.BewBindingSource
                        frm.RundschreibenBindingSource.DataSource = Me.RundschreibenBindingSource
                    End Using
                    Me.BewBindingSource.RemoveFilter()
                End If

            Case sender Is Top10anzeigen
                frmMain.DBLoad()

                If Not BewerberDataSet.bew.Any(Function(x) x.rundschreibenjanein = CInt(1)) Then
                    MessageBox.Show("Es wurden bisher keine Bewerber/innen für das nächste Rundschreiben ausgewählt worden.", "Keine Bewerber/innen ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub
                ElseIf BewerberDataSet.bew.Any(Function(x) x.rundschreibenjanein = CInt(1)) Then
                    Using frm = New frmRundschreiben(Me)
                        'frm.BewerberDataSet = Me.BewerberDataSet
                        'frm.BewTableAdapter = Me.BewTableAdapter
                        'frm.RundschreibenTableAdapter = Me.RundschreibenTableAdapter
                        'frm.BewBindingSource.DataSource = Me.BewBindingSource
                        'frm.RundschreibenBindingSource.DataSource = Me.RundschreibenBindingSource
                        'frm.BewBindingSource.Filter = "rundschreiben = 1"
                        Dim result = frm.ShowDialog(Me)
                    End Using
                    Me.BewBindingSource.RemoveFilter() ' muss wieder zurückgesetzt werden, wenn Fenster geschlossen wurde
                    frmMain.DBLoad()
                End If

            Case sender Is Top10ExceloeffnenRadMenuItem
                If connectionString.Contains("127.0.0.1") Then
                    System.Diagnostics.Process.Start("E:\testxls.xls")
                Else
                    System.Diagnostics.Process.Start("X:\Formulare\Rundschreiben Top Ten mtl neu.xls")
                End If

            Case sender Is btnDatenBewerbertooleinlesen ' xmldaten aus Bewerbertool einlesen
                frmXmleinlesen.xmleinlesen_bool = False
                Using frm = New frmXmleinlesen(Me)
                    Dim result = frm.ShowDialog(Me)
                End Using

                If frmXmleinlesen.xmleinlesen_bool Then ' wird nur angezeigt, wenn auf den Button im frmxmleinlesen geklickt wurde, aber nicht, wenn das Fenster einfach geschlossen wird.
                    Dim messagetext As String = String.Concat("Wenn der neue Eintrag korrekt angezeigt wird, klicken Sie bitte auf ""Ja"". Das Backup der Datenbank wird gelöscht.", vbNewLine, vbNewLine, "Wenn der neue Eintrag nicht korrekt ist, klicken Sie bitte auf ""Nein"", dann wird das Backup der DB eingespielt.")

                    Dim result1 As DialogResult = MessageBox.Show(messagetext, "Alles korrekt?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand)
                    If result1 = DialogResult.Yes Then
                        IO.File.Delete(frmXmleinlesen.sqlfile)
                        MessageBox.Show("Backup wurde gelöscht", "Backup gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf result1 = DialogResult.No Then
                        Call frmXmleinlesen.Backupeinspielen()
                    End If
                End If
            Case sender Is Rundschreibenuebersicht
                'Using frm = New frmRundschreibenuebersicht(Me)
                'Dim result = frm.ShowDialog(Me)
                'End Using
                Dim frm As New frmRundschreibenuebersicht(Me)
                frm.Show()
        End Select
    End Sub

    ' Interviewerfragebogen nur zugänglich, wenn Stand nicht auf "fertig steht
    Private Sub interviewerbogenanzeigen()
        If StandComboBox.Text = CStr("fertig") Then
            Interviewerbogen.Visibility = ElementVisibility.Collapsed
        Else
            Interviewerbogen.Visibility = ElementVisibility.Visible
        End If
    End Sub
#End Region

    ' Tabcontrol - Tabpagewechsel
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Call texttauschen.Textboxtauschen()
        If TabControl1.SelectedTab Is TabPage3 Then
            Call ulascheck()
            Call einloggen.tbcheck() ' wenn Interviewer eingeloggt ist, werden manche Felder gelb
        ElseIf TabControl1.SelectedTab Is TabPage4 Then

            If CInt(letzteid) = CInt(0) Then
                MessageBox.Show("Bitte eine/n Bewerber auswählen", "Kein/e Bewerber/in ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.TabControl1.SelectedTab = TabPage1
            Else
                '  Me.NotizenTableAdapter.FillBy(Me.BewerberDataSet.notizen, CInt(letzteid))
                Me.NotizenTableAdapter.Fill(Me.BewerberDataSet.notizen)
                Me.RadRTErtf.DocumentEditor.ChangeFontSize(Unit.PointToDip(10))
                NotizenRadGridView.Columns(3).WrapText = True
                'Me.NotizenRadGridView.Rows(0).IsCurrent = True ' Das darf nicht aktiviert werden
            End If
        ElseIf TabControl1.SelectedTab Is TabPage5 Then
            Call einloggen.tbcheck() ' wenn Interviewer eingeloggt ist, werden manche Felder gelb
        End If
    End Sub

    ' Tabreiter formatieren
    Private Sub TabControl_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem

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

    '================================================================================ Formatierung Gridview ===================================================================

    ' Spaltenköpfe fett
    Private Sub BewGridView1_ViewCellFormatting(ByVal sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles BewGridView1.ViewCellFormatting
        Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

        If TypeOf e.CellElement Is GridHeaderCellElement Then
            e.CellElement.Font = newFont10
        Else
            e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

        If e.CellElement.ColumnInfo.Name = "name" Then
            e.CellElement.Font = newFont10
            e.CellElement.DrawFill = True
            e.CellElement.NumberOfColors = 1
            e.CellElement.BackColor = Color.Yellow
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    ' Ende Spaltenköpfe fett

    ' Filterzeile

    Private Sub BewGridView1_ViewRowFormatting(sender As Object, e As RowFormattingEventArgs) Handles BewGridView1.RowFormatting

        If TypeOf e.RowElement Is GridFilterRowElement Then
            e.RowElement.DrawFill = True
            e.RowElement.BackColor = Color.Pink
        End If
    End Sub

    ' Ende Filterzeile

    ' `====================================================================== Formatierung bewgridview =====================================================

    ' =================================================================  Doppelklick Email, Homepage Beginn, Ulas, Bewerberbogen, Googlemaps, Persönlichkeit ============================
    Private Sub EmailTextBox_DoubleClick(sender As Object, e As EventArgs) Handles EmailTextBox.DoubleClick, HomepagelinkTextBox.DoubleClick, OrtTextBox.DoubleClick, UlasListBox.DoubleClick, UlasbearbeitetListBox.DoubleClick, RTEBewerberbeschreibung.DoubleClick, Label16.DoubleClick, RefnrTextBox.DoubleClick, lblMehrAnmerkungen.DoubleClick, txtFuerstelle.DoubleClick
        Select Case True
            Case sender Is EmailTextBox
                If CStr(EmailTextBox.Text) <> String.Empty Then
                    System.Diagnostics.Process.Start("mailto:" & EmailTextBox.Text)
                End If
            Case sender Is EmailTextBox1
                If CStr(EmailTextBox1.Text) <> String.Empty Then
                    System.Diagnostics.Process.Start("mailto:" & EmailTextBox1.Text)
                End If
            Case sender Is HomepagelinkTextBox
                If Inet Then
                    If CStr(HomepagelinkTextBox.Text) <> String.Empty Then
                        System.Diagnostics.Process.Start(HomepagelinkTextBox.Text)
                    End If
                End If
            Case sender Is OrtTextBox
                Dim googleort As String = CStr(Me.PlzTextBox.Text & "+" & Me.OrtTextBox.Text & "+" & Me.StrasseTextBox.Text)
                Dim googlestring As New StringBuilder
                googlestring.Append("www.google.de/maps/place/")
                googlestring.Append(googleort)
                If Inet Then
                    System.Diagnostics.Process.Start(googlestring.ToString)
                End If
            Case sender Is UlasListBox
                If UlasListBox.Items.Count = 0 Then
                    MessageBox.Show("Keine Datei zum Öffnen vorhanden", "Keine Datei vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    '  Dim ulasdatei As String = String.Empty
                    ' ulasoriginalverzeichnis = String.Concat(verzeichnis, letzteid, "\Originale\")
                    'ulasdatei = String.Concat(ulasoriginalverzeichnis, UlasListBox.SelectedItem.ToString)
                    System.Diagnostics.Process.Start(UlasListBox.SelectedItem.ToString)
                End If
            Case sender Is UlasbearbeitetListBox
                If UlasbearbeitetListBox.Items.Count = 0 Then
                    MessageBox.Show("Keine Datei zum Öffnen vorhanden", "Keine Datei vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    '  Dim ulasbearbeitetdatei As String = String.Empty
                    ' ulasbearbeitetverzeichnis = String.Concat(verzeichnis, letzteid, "\bearbeitet\")
                    'ulasbearbeitetdatei = String.Concat(ulasbearbeitetverzeichnis, UlasbearbeitetListBox.SelectedItem.ToString)
                    'MsgBox(UlasbearbeitetListBox.SelectedItem.ToString)
                    'MsgBox(ulasbearbeitetdatei)
                    System.Diagnostics.Process.Start(UlasbearbeitetListBox.SelectedItem.ToString)
                End If
            Case sender Is RTEBewerberbeschreibung
                Using frm = New frmPersönlichkeitbearbeiten(Me)
                    Dim result = frm.ShowDialog(Me)
                End Using
            Case sender Is txtFuerstelle
                frmOA.vorschlagenfuerstelle_bool = True
                Using frm = New frmOA(Me)
                    Dim result = frm.ShowDialog()
                End Using
            Case sender Is Label16 ' Doppelklick auf Label 16 öffnet Fenster für Homepagedaten
                Using frm = New frmHomepage(Me)
                    Dim result = frm.ShowDialog()
                End Using
            Case sender Is RefnrTextBox
                Using frm = New frmHomepageindividuell(Me)
                    Dim result = frm.ShowDialog()
                End Using
            Case sender Is lblMehrAnmerkungen
                TabControl1.SelectedTab = TabPage4
        End Select
    End Sub

    ' =================================================================== Doppelklick Email, Homepage Beginn Ende

    ' =================================================================== Tabpage Daten ====================================================================

#Region "===================================================================== Ulas ======================================================================="
    ' =================================================================== Ulas =============================================================================
    '  Prüfen, ob Ulas gespeichert sind; wenn keine Ulas vorhanden sind, Messagebox anzeigen
    Private Sub ulascheck()

        ulasoriginalverzeichnis = String.Concat(verzeichnis, letzteid, "\Originale\")

        If IO.Directory.Exists(ulasoriginalverzeichnis) Then
            Dim ll As New List(Of IO.FileInfo)
            ll.AddRange(New IO.DirectoryInfo(ulasoriginalverzeichnis).GetFiles("*.*", SearchOption.AllDirectories))
            If ll.Count > 0 Then
                lblOrigulasvorhanden.Visible = True
            ElseIf ll.Count = 0 Then
                lblOrigulasvorhanden.Visible = False
            End If
        Else
            lblOrigulasvorhanden.Visible = False
        End If

        ulasbearbeitetverzeichnis = String.Concat(verzeichnis, letzteid, "\bearbeitet\")
        If IO.Directory.Exists(ulasbearbeitetverzeichnis) Then
            Dim ll As New List(Of IO.FileInfo)
            ll.AddRange(New IO.DirectoryInfo(ulasbearbeitetverzeichnis).GetFiles("*.*", SearchOption.AllDirectories))
            If ll.Count > 0 Then
                lblAnoymisierteulasvorhanden.Visible = True
            ElseIf ll.Count = 0 Then
                lblAnoymisierteulasvorhanden.Visible = False
            End If
        Else
            lblAnoymisierteulasvorhanden.Visible = False
        End If
    End Sub

    ' Contextmenu Originalulas

    Private Sub UlasspeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UlasspeichernToolStripMenuItem.Click, UlasexplorerToolStripMenuItem.Click
        Select Case True
            Case sender Is UlasspeichernToolStripMenuItem
                Call ulasspeichern.originalulasspeichern()
                Call ulaseinlesen()
            Case sender Is UlasexplorerToolStripMenuItem
                System.Diagnostics.Process.Start("explorer.exe", ulasoriginalverzeichnis)
        End Select
    End Sub

    ' Contextmenu bearbeitete Ulas
    Private Sub BearbeiteeulasspeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BearbeiteeulasspeichernToolStripMenuItem.Click, explorerToolStripMenuItem.Click
        Select Case True
            Case sender Is BearbeiteeulasspeichernToolStripMenuItem
                Call ulasspeichern.bearbeiteteulasspeichern()
                Call bearbeiteteulaseinlesen()
            Case sender Is explorerToolStripMenuItem
                System.Diagnostics.Process.Start("explorer.exe", ulasbearbeitetverzeichnis)
        End Select
    End Sub

    Private Sub ulasaufrufen()
        Using frm = New frmUlaseintragen(Me)
            Dim result = frm.ShowDialog(Me)
        End Using
    End Sub

#Region "DragDrop - Ulas kopieren und in Liste packen, Anmerkung erstellen, Ulas in Listboxen einlesen"

    ' Drag and Drop 
    Private Sub Control_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles UlasListBox.DragDrop, UlasbearbeitetListBox.DragDrop, LetzteAnmerkungTextbox.DragDrop

        Dim data = DirectCast(e.Data, DataObject)
        Dim files As StringCollection = data.GetFileDropList
        frmNeueAnmerkunganlegen.droptext = data.GetText

        Select Case True
            Case sender Is UlasListBox
                For Each file As String In files
                    ulasspeichern.origdropdatei = CStr(file)
                    Call ulasspeichern.originalulasdraganddrop()
                    Call ulaseinlesen()
                Next
            Case sender Is UlasbearbeitetListBox
                For Each file As String In files
                    ulasspeichern.anonymisiertdropdatei = CStr(file)
                    Call ulasspeichern.anonymisiertulasdraganddrop()
                    Call bearbeiteteulaseinlesen()
                Next
            Case sender Is LetzteAnmerkungTextbox
                frmNeueAnmerkunganlegen.anmerkungdragdrop_bool = True
                frmNeueAnmerkunganlegen.droptext = data.GetText
                Using frm = New frmNeueAnmerkunganlegen(Me)
                    Dim result = frm.ShowDialog
                End Using
                'Muss leer und false sein
                frmNeueAnmerkunganlegen.droptext = String.Empty
                frmNeueAnmerkunganlegen.anmerkungdragdrop_bool = False
        End Select
    End Sub

    ' Dateien für Drag and Drop definieren
    Private Sub Control_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles UlasListBox.DragOver, UlasbearbeitetListBox.DragOver, LetzteAnmerkungTextbox.DragOver
        'erlaubte DropEffects festlegen
        Dim data = TryCast(e.Data, DataObject)
        If data Is Nothing Then
            Return ' DragQuelle ablehnen, weils DataObject nicht verarbeitet werden kann
        End If
        Select Case True
            Case sender Is UlasListBox
                If data.ContainsFileDropList Then e.Effect = DragDropEffects.All
            Case sender Is UlasbearbeitetListBox
                If data.ContainsFileDropList Then e.Effect = DragDropEffects.All
            Case sender Is LetzteAnmerkungTextbox
                If data.ContainsText Then e.Effect = DragDropEffects.All
        End Select
    End Sub

    Private Sub ListBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles UlasListBox.MouseDown
        If e.Button = MouseButtons.Left Then _GrabOffset = New Size(e.Location)
    End Sub

    Private Sub ListBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles UlasListBox.MouseMove, UlasbearbeitetListBox.MouseMove
        Select Case True
            Case sender Is UlasListBox
                If Not e.Button.HasFlag(MouseButtons.Left) Then Return
                With e.Location - _GrabOffset
                    If .X ^ 2 + .Y ^ 2 > _Tolerance Then
                        Call PerformDragFileItem(Point.Empty + _GrabOffset)
                    End If
                End With
            Case sender Is UlasbearbeitetListBox
                If Not e.Button.HasFlag(MouseButtons.Left) Then Return
                With e.Location - _GrabOffset
                    If .X ^ 2 + .Y ^ 2 > _Tolerance Then
                        Call Performdragfileitemulasbearbeitetlistbox(Point.Empty + _GrabOffset)
                    End If
                End With
        End Select
    End Sub

    ' Ulaslistbox
    Private Sub PerformDragFileItem(ByVal pt As Point)
        Dim indx = UlasListBox.IndexFromPoint(pt)
        If indx < 0 Then Return
        Dim file = DirectCast(UlasListBox.Items(indx), String)
        Dim dto = New DataObject(DataFormats.FileDrop, {file}) 'DataObject mit FileDropList
        dto.SetData(DataFormats.StringFormat, file) 'Daten zusätzlich außerdem als Text einpacken
        ' Dim allowed = DragDropEffects.Copy Or DragDropEffects.Move
        Dim allowed = DragDropEffects.Copy
        If UlasListBox.DoDragDrop(dto, allowed) = DragDropEffects.Move Then
            UlasListBox.Items.RemoveAt(indx)
        End If
    End Sub

    'Ulas bearbeitet
    Private Sub Performdragfileitemulasbearbeitetlistbox(ByVal pt As Point)
        Dim indx = UlasbearbeitetListBox.IndexFromPoint(pt)
        If indx < 0 Then Return
        Dim file = DirectCast(UlasbearbeitetListBox.Items(indx), String)
        Dim dto = New DataObject(DataFormats.FileDrop, {file}) 'DataObject mit FileDropList
        dto.SetData(DataFormats.StringFormat, file) 'Daten zusätzlich außerdem als Text einpacken
        ' Dim allowed = DragDropEffects.Copy Or DragDropEffects.Move
        Dim allowed = DragDropEffects.Copy
        If UlasbearbeitetListBox.DoDragDrop(dto, allowed) = DragDropEffects.Move Then
            UlasbearbeitetListBox.Items.RemoveAt(indx)
        End If
    End Sub

    ' Originalulas in Listbox einlesen
    Private Sub ulaseinlesen()
        If connectionString.Contains("127.0.0.1") Then
            verzeichnis = CStr("e:\heyduck\ulas\")
        Else
            verzeichnis = CStr("x:\ulas\")
        End If

        ulasoriginalverzeichnis = String.Concat(verzeichnis, letzteid, "\Originale\")
        UlasListBox.Items.Clear()
        If IO.Directory.Exists(ulasoriginalverzeichnis) Then

            Dim ll = New List(Of IO.FileInfo)
            ll.AddRange(New IO.DirectoryInfo(ulasoriginalverzeichnis).GetFiles("*.*", SearchOption.AllDirectories))

            For Each Item As FileInfo In ll
                Dim listitem As String = String.Concat(ulasoriginalverzeichnis, Item.ToString)
                UlasListBox.Items.Add(listitem)
            Next
        Else
            ' UlasListBox.DataSource = Nothing
            UlasListBox.Items.Clear()
            Exit Sub
        End If
    End Sub

    ' Bearbeitete Ulas in Listbox einlesen
    Private Sub bearbeiteteulaseinlesen()
        If connectionString.Contains("127.0.0.1") Then
            verzeichnis = CStr("e:\heyduck\ulas\")
        Else
            verzeichnis = CStr("x:\ulas\")
        End If

        ulasbearbeitetverzeichnis = String.Concat(verzeichnis, letzteid, "\bearbeitet\")

        If IO.Directory.Exists(ulasbearbeitetverzeichnis) Then
            UlasbearbeitetListBox.Items.Clear()
            Dim ll = New List(Of IO.FileInfo)
            ll.AddRange(New IO.DirectoryInfo(ulasbearbeitetverzeichnis).GetFiles("*.*", SearchOption.AllDirectories))
            For Each Item As FileInfo In ll
                Dim listitem As String = String.Concat(ulasbearbeitetverzeichnis, Item.ToString)
                UlasbearbeitetListBox.Items.Add(listitem)
            Next
        Else
            'UlasbearbeitetListBox.DataSource = Nothing
            UlasbearbeitetListBox.Items.Clear()
            Exit Sub
        End If
    End Sub

#End Region

#End Region
    ' =================================================================== Ende Tabpage Daten

#Region "==================================================================== Anmerkungen ======================================================"
    ' ====================================================================== Tabpage Notizen ====================================================

    Private Sub anmerkunggeaendertspeichern()
        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()

        Dim rtfeintragen = DirectCast(DirectCast(Me.NotizenBindingSource.Current, DataRowView).Row, notizenRow)

        ' RTF und txt auslesen
        Dim exportfilertf As String = String.Empty
        Dim exportfiletxt As String = String.Empty

        '  Call doppelteleerzeilen() ' entfernt doppelte Leerzeilen in Richtext und Text

        exportfilertf = allgemein.ExporttoRtf(Me.RadRTErtf.Document)
        exportfiletxt = allgemein.ExporttoTxt(Me.RadRTErtf.Document)

        If exportfiletxt <> String.Empty Then
            Dim result As DialogResult = MessageBox.Show("Möchten Sie Ihre geänderte Anmerkung abspeichern, dann drücken Sie auf den Button ""OK"", wenn Sie nicht speichern wollen, auf den Button ""Nein""", "Geänderte Anmerkung speichern", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.Yes Then
                rtfeintragen.anmerkungen_rtf = CStr(exportfilertf)
                rtfeintragen.anmerkungen_text = CStr(exportfiletxt)
                rtfeintragen.geaendert_am = Date.Now
                rtfeintragen.geaendert_von = CStr(usernameklar)

                Me.Validate()
                Me.NotizenBindingSource.EndEdit()
                Me.NotizenTableAdapter.Update(Me.BewerberDataSet.notizen)
                Call gespeichert()
                Me.NotizenTableAdapter.FillBy(Me.BewerberDataSet.notizen, CInt(letzteid))
                frmMain.letzteanmerkunganzeigen() ' Letzte Anmerkung wird in frmMain in das Feld im Reiter Bewerber/in geladen
            ElseIf result = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        Else
            MessageBox.Show("Keine geänderte Anmerkung eingetragen", "Keine geänderte Anmerkung eingetragen", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub ImportRtf()
        Dim notizenbewid_bool As Boolean = allgemein.Anmerkungvorhanden(letzteid) ' Überprüft, ob eine Row mit der abgefragten bewid in der Notizen-DB enthalten ist

        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        'If notizenbewid = False OrElse bewid = 0 Then
        If notizenbewid_bool = False Then
            content = CStr("{\rtf\ansi\ansicpg1252\uc1\deff0\deflang1033{\fonttbl{\f0 Verdana;}}{\colortbl\red0\green0\blue0 ;}{\*\defchp\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone}{\*\defpap\sl276\slmult1\ql\sa180\ltrpar}{\stylesheet{\s0\sqformat\spriority0\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Normal;}{\*\ts2\tsrowd\spriority59\trbrdrt\brdrnone\trbrdrb\brdrnone\trbrdrl\brdrnone\trbrdrr\brdrnone\trbrdrh\brdrnone\trbrdrv\brdrnone\trgaph0\trpaddl75\trpaddr75\trpaddt0\trpaddb0\clpadft3\clpadt0\clpadfr3\clpadr0\clpadfl3\clpadl0\clpadfb3\clpadb0\tsvertalt\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Table Normal;}}\nouicompat\viewkind4\paperw12240\paperh15840\margl1425\margr1425\margt1425\margb1425\deftab720\sectd\pgwsxn12240\pghsxn15840\marglsxn1425\margrsxn1425\margtsxn1425\margbsxn1425\headery720\footery720\pard\s0\sl276\slmult1\ql\sa180\ltrpar{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone  }{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\par}}")
            Me.RadRTErtf.Document = provider.Import(content)
            Exit Sub
        ElseIf notizenbewid_bool = True Then
            Dim rtfvalues = DirectCast(DirectCast(Me.NotizenBindingSource.Current, DataRowView).Row, notizenRow)
            Me.RadRTErtf.Document = provider.Import(rtfvalues.anmerkungen_rtf)
        End If
    End Sub

    Private Sub NotizenRadGridView_Click(sender As Object, e As EventArgs) Handles NotizenRadGridView.Click
        notizenid = CInt(NotizenRadGridView.CurrentRow.Cells(0).Value)
        Call anmerkungsuser()
        Call ImportRtf()
    End Sub

    Private Sub btnAnmerkungloeschen_Click(sender As Object, e As EventArgs) Handles btnAnmerkungloeschen.Click
        Me.NotizenBindingSource.RemoveCurrent()
        Me.Validate()
        Me.NotizenBindingSource.EndEdit()
        Me.NotizenTableAdapter.Update(BewerberDataSet.notizen)
    End Sub

    Private Sub anmerkungsuser()
        Dim notizen = DirectCast(DirectCast(Me.NotizenBindingSource.Current, DataRowView).Row, notizenRow)

        Dim origuser As String = String.Empty
        Dim aenderungsuser As String = String.Empty
        origuser = CStr(notizen.eingetragen_von)

        If notizen.Isgeaendert_vonNull Then
            aenderungsuser = String.Empty
        Else
            aenderungsuser = CStr(notizen.geaendert_von)
        End If

        If CStr(aenderungsuser) = CStr(usernameklar) OrElse loginflag = CInt(8) OrElse loginflag = CInt(9) Then
            btnBearbeitungspeichern.Visible = True
        ElseIf CStr(origuser) = CStr(usernameklar) OrElse loginflag = CInt(8) OrElse loginflag = CInt(9) Then
            btnBearbeitungspeichern.Visible = True
        Else
            btnBearbeitungspeichern.Visible = False
            MessageBox.Show("Sie können diese Anmerkung nicht bearbeiten. Wenn Sie neue Informationen eintragen wollen, legen Sie bitte mit dem Button ""Neue Anmerkung anlegen"" eine neue Anmerkung an.", "Bearbeiten nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

        If loginflag = CInt(8) OrElse loginflag = CInt(9) Then
            btnAnmerkungloeschen.Visible = True
        Else
            btnAnmerkungloeschen.Visible = False
        End If
    End Sub

    ' Überprüft, ob eine Row mit der abgefragten bewid in der Notizen-DB enthalten ist
    Private Sub Anmerkung()

        Dim sql As String = "select * from bewerberneu.notizen where bewid = @letzteid"
        Using conn As New MySqlConnection(connectionString)
            Dim suche As New MySqlCommand(sql, conn)
            suche.Parameters.AddWithValue("@letzteid", letzteid)
            Try
                conn.Open()
                Dim suchereader As MySqlDataReader = suche.ExecuteReader
                If suchereader.HasRows Then
                    Panel40.Visible = True
                ElseIf Not suchereader.HasRows Then
                    Panel40.Visible = False
                End If
                suchereader.Close()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub baum()
        Dim text As String = String.Concat("Bitte in der Anmerkung eintragen:", vbNewLine, vbNewLine, "Kunde,", vbNewLine, vbNewLine, "Rechnungsnummer,", vbNewLine, vbNewLine, "Rechnungsdatum,", vbNewLine, vbNewLine, "Rechnungsbetrag,", vbNewLine, vbNewLine, "Bewerber/in.")
        MessageBox.Show(text, "Bitte eintragen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    ' ====================================================================== Tabpage Notizen Ende ====================================================

    ' ========================================================================== Letzte Anmerkung auf Tab Bewerber/in anzeigen ===================================
    Public Shared Sub letzteanmerkunganzeigen()

        Dim betreff As String = String.Empty
        Dim anmerkungen_text As String = String.Empty
        Dim eingetragen_von As String = String.Empty
        Dim eingetragen_am As Date = Date.Now
        Dim geaendert_am As Date = Date.Now
        Dim geaendert_von As String = String.Empty

        Dim eingetragen As New List(Of Date)()
        Dim geaendert As New List(Of Date)

        Dim date1 As DateTime
        Dim date2 As DateTime

        frmMain.NotizenBindingSource.RemoveFilter() ' bei jedem Aufruf muss bindingsource.filter zurückgesetzt werden
        frmMain.NotizenBindingSource.Filter = "bewid =  '" & letzteid & "'"

        ' Beim Aufruf der Sub wird die Textbox geleert
        frmMain.LetzteAnmerkungTextbox.Text = String.Empty

        ' Daten aus Datarowview holen
        For Each drv As DataRowView In frmMain.NotizenBindingSource
            Dim item = DirectCast(drv.Row, notizenRow).eingetragen_am
            eingetragen.Add(item)
            Dim item1 = DirectCast(drv.Row, notizenRow).geaendert_am
            geaendert.Add(item1)
        Next

        ' Mitteilung anzeigen, wenn mehr als eine Anmerkung vorhanden ist
        If eingetragen.Count > 1 Then
            frmMain.lblMehrAnmerkungen.Visible = True
        ElseIf eingetragen.Count < 1 Then
            frmMain.lblMehrAnmerkungen.Visible = False
        End If


        ' letztes eingetragenes Datum, das in der List of Date ist,  bestimmen
        If eingetragen.Count > 0 Then
            date1 = eingetragen.OrderBy(Function(d) d).Last()
        End If
        If geaendert.Count > 0 Then
            date2 = geaendert.OrderBy(Function(d) d).Last()
        End If
        ' Einträge aus Bindingsource auslesen und in Textfeld eintragen
        If date1 > date2 AndAlso eingetragen.Count > 0 Then
            frmMain.NotizenBindingSource.RemoveFilter()
            frmMain.NotizenBindingSource.Filter = "bewid =  '" & letzteid & "' AND eingetragen_am = '" & date1 & "'"
            'If eingetragen.Count > 0 Then
            Dim notizen = DirectCast(DirectCast(frmMain.NotizenBindingSource.Current, DataRowView).Row, notizenRow)
            betreff = CStr(notizen.betreff)
            anmerkungen_text = CStr(notizen.anmerkungen_text)
            eingetragen_von = CStr(notizen.eingetragen_von)
            eingetragen_am = CDate(notizen.eingetragen_am)

            ' Letzte Anmerkung auf Tab Bewerber/in
            Dim anzeigetext As String = String.Concat(eingetragen_am, vbNewLine, "Eingetragen von: ", eingetragen_von, vbNewLine, "Betreff: ", betreff, vbNewLine, "____________________________________", vbNewLine, vbNewLine, anmerkungen_text)
            frmMain.LetzteAnmerkungTextbox.Text = CStr(anzeigetext)
            anzeigetext = String.Empty

        ElseIf date1 < date2 AndAlso geaendert.Count > 0 Then
            frmMain.NotizenBindingSource.RemoveFilter()
            frmMain.NotizenBindingSource.Filter = "bewid =  '" & letzteid & "' AND geaendert_am = '" & date2 & "'"
            Dim notizen = DirectCast(DirectCast(frmMain.NotizenBindingSource.Current, DataRowView).Row, notizenRow)
            betreff = CStr(notizen.betreff)
            anmerkungen_text = CStr(notizen.anmerkungen_text)
            geaendert_von = CStr(notizen.geaendert_von)
            geaendert_am = CDate(notizen.geaendert_am)
            'Letzte Anmerkung auf Tab Bewerber/in
            Dim anzeigetext As String = String.Concat(geaendert_am, vbNewLine, "Geändert von: ", geaendert_von, vbNewLine, "Betreff: ", betreff, vbNewLine, "____________________________________", vbNewLine, vbNewLine, anmerkungen_text)
            frmMain.LetzteAnmerkungTextbox.Text = CStr(anzeigetext)
            anzeigetext = String.Empty
        End If
        frmMain.NotizenBindingSource.RemoveFilter() ' bei jedem Aufruf muss bindingsource.filter zurückgesetzt werden
    End Sub

#End Region


#Region "============================================================================== Listboxen, Doppelklick für Listboxen========================================================"
    ' ==================================================================================== Eingaben Listboxen ===========================================================================

    Private Sub listboxenaufrufen()
        Using frm = New frmListboxen(Me)
            Dim result = frm.ShowDialog()
        End Using

    End Sub

    ' ================================================================================== Eingaben Listboxen Ende =========================================================================

    ' =========================================================================== Controls mit Doppelklick (Listboxen aufrufen) ==========================================================
    Private Sub Za_vmTextBox_DoubleClick(sender As Object, e As EventArgs) Handles Za_vmTextBox.DoubleClick, ArbeitsortTextBox.DoubleClick, FuehrerscheinTextBox1.DoubleClick, Studium_abschlussTextBox.DoubleClick, Pkw_oepnvTextBox.DoubleClick, Pdl_welcheTextBox1.DoubleClick, SuchmaschineTextBox1.DoubleClick, ZeitungTextBox1.DoubleClick, JobboerseTextBox1.DoubleClick, Medien_andereTextBox1.DoubleClick, Studium_abschlussTextBox.DoubleClick, Sap_moduleTextBox.DoubleClick, Fibu_erfahrungTextBox.DoubleClick, Fibu_softwareTextBox.DoubleClick, Controlling_typTextBox.DoubleClick, Controlling_report_controlling_systemeTextBox.DoubleClick, Steuerfachang_woTextBox.DoubleClick, Steuerfachang_softwareTextBox.DoubleClick, Bibuha_woTextBox.DoubleClick, Bibuha_softwareTextBox.DoubleClick, Lug_abrechnung_woTextBox.DoubleClick, Lug_abrechnung_softwareTextBox.DoubleClick, Lug_buchhaltung_woTextBox.DoubleClick, Lug_buchhaltung_softwareTextBox.DoubleClick, Fibu_kontenrahmenTextBox.DoubleClick, UlasTextBox.DoubleClick, Vz_tzTextBox1.DoubleClick
        Select Case True
            Case sender Is Za_vmTextBox
                frmListboxen.zavm_bool = True
                Call listboxenaufrufen()
                Za_vmTextBox.Text = CStr(frmListboxen.zavm)
            Case sender Is ArbeitsortTextBox
                frmListboxen.arbeitsort_bool = True
                Call listboxenaufrufen()
                ArbeitsortTextBox.Text = CStr(frmListboxen.arbeitsort)
            Case sender Is FuehrerscheinTextBox1
                frmListboxen.fuehrerschein_bool = True
                Call listboxenaufrufen()
                FuehrerscheinTextBox1.Text = CStr(frmListboxen.fueherschein)
            Case sender Is Pkw_oepnvTextBox
                frmListboxen.oepnv_bool = True
                Call listboxenaufrufen()
                Pkw_oepnvTextBox.Text = CStr(frmListboxen.oepnv)
            Case sender Is Pdl_welcheTextBox1
                frmListboxen.pdl_welche_bool = True
                Call listboxenaufrufen()
                Pdl_welcheTextBox1.Text = CStr(frmListboxen.pdl_welche)
                ' Case sender Is SuchmaschineTextBox1
                '    frmListboxen.suchmaschine_bool = True
                '   Call listboxenaufrufen()
                '  SuchmaschineTextBox1.Text = CStr(frmListboxen.suchmaschine)
                'Case sender Is ZeitungTextBox1
                '   frmListboxen.zeitung_bool = True
                '  Call listboxenaufrufen()
                ' ZeitungTextBox1.Text = CStr(frmListboxen.zeitung)
                'Case sender Is JobboerseTextBox1
                '   frmListboxen.jobboerse_bool = True
                '  Call listboxenaufrufen()
                ' JobboerseTextBox1.Text = CStr(frmListboxen.jobboerse)
                ' Case sender Is Medien_andereTextBox1
                'frmListboxen.anderemedien_bool = True
                'Call listboxenaufrufen()
                'Medien_andereTextBox1.Text = CStr(frmListboxen.anderemedien)
            Case sender Is Studium_abschlussTextBox
                frmListboxen.studiumsabschluss_bool = True
                Call listboxenaufrufen()
                Studium_abschlussTextBox.Text = CStr(frmListboxen.studiumabschluss)
            Case sender Is Sap_moduleTextBox
                frmListboxen.sapmodule_bool = True
                Call listboxenaufrufen()
                Sap_moduleTextBox.Text = CStr(frmListboxen.sapmodule)
            Case sender Is Fibu_erfahrungTextBox
                frmListboxen.fibuerfahrung_bool = True
                Call listboxenaufrufen()
                Fibu_erfahrungTextBox.Text = CStr(frmListboxen.fibuerfahrung)
            Case sender Is Fibu_softwareTextBox
                frmListboxen.fibusoftwareerfahrung_bool = True
                Call listboxenaufrufen()
                Fibu_softwareTextBox.Text = CStr(frmListboxen.fibusoftwareerfahrung)
            Case sender Is Controlling_typTextBox
                frmListboxen.controllingerfahrung_bool = True
                Call listboxenaufrufen()
                Controlling_typTextBox.Text = CStr(frmListboxen.controllingerfahrung)
            Case sender Is Controlling_report_controlling_systemeTextBox
                frmListboxen.controllingsystemeerfahrung_bool = True
                Call listboxenaufrufen()
                Controlling_report_controlling_systemeTextBox.Text = CStr(frmListboxen.controllingsystemeerfahrung)
            Case sender Is Steuerfachang_woTextBox
                frmListboxen.steuerfachangestellte_erfahrung_bool = True
                Call listboxenaufrufen()
                Steuerfachang_woTextBox.Text = CStr(frmListboxen.steuerfachangestellte_erfahrung)
            Case sender Is Steuerfachang_softwareTextBox
                frmListboxen.steuerfachangestellte_software_bool = True
                Call listboxenaufrufen()
                Steuerfachang_softwareTextBox.Text = CStr(frmListboxen.steuerfachangestellte_software)
            Case sender Is Bibuha_woTextBox
                frmListboxen.bibuha_erfahrung_bool = True
                Call listboxenaufrufen()
                Bibuha_woTextBox.Text = CStr(frmListboxen.bibuha_erfahrung)
            Case sender Is Bibuha_softwareTextBox
                frmListboxen.bibuha_software_bool = True
                Call listboxenaufrufen()
                Bibuha_softwareTextBox.Text = CStr(frmListboxen.bibuha_software)
            Case sender Is Lug_abrechnung_woTextBox
                frmListboxen.lug_abrechnung_bool = True
                Call listboxenaufrufen()
                Lug_abrechnung_woTextBox.Text = CStr(frmListboxen.lug_erfahrung)
            Case sender Is Lug_abrechnung_softwareTextBox
                frmListboxen.lugabrechnung_software_bool = True
                Call listboxenaufrufen()
                Lug_abrechnung_softwareTextBox.Text = CStr(frmListboxen.lug_abrechnung_software)
            Case sender Is Lug_buchhaltung_woTextBox
                frmListboxen.lug_buchhaltung_bool = True
                Call listboxenaufrufen()
                Lug_buchhaltung_woTextBox.Text = CStr(frmListboxen.lug_buchhaltung)
            Case sender Is Lug_buchhaltung_softwareTextBox
                frmListboxen.lugbuchhaltung_software_bool = True
                Call listboxenaufrufen()
                Lug_buchhaltung_softwareTextBox.Text = CStr(frmListboxen.lug_buchhaltung_software)
            Case sender Is Fibu_kontenrahmenTextBox
                frmListboxen.fibu_kontenrahmen_bool = True
                Call listboxenaufrufen()
                Fibu_kontenrahmenTextBox.Text = CStr(frmListboxen.fibu_kontenrahmen)
            Case sender Is UlasTextBox
                frmUlaseintragen.ulas_bool = True
                Call ulasaufrufen()
                If frmUlaseintragen.ulas_wert <> String.Empty Then
                    UlasTextBox.Text = CStr(frmUlaseintragen.ulas_wert)
                End If
            Case sender Is Vz_tzTextBox1
                frmListboxen.vztz_bool = True
                Call listboxenaufrufen()
                Vz_tzTextBox1.Text = CStr(frmListboxen.vztz)
        End Select
    End Sub

    ' ============================================================================== Ende Listboxen =====================================================================
#End Region

    ' ========================================================================= Validierungen ===================================================
    Private Sub AuslandsaufenthaltComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AuslandsaufenthaltComboBox.SelectedIndexChanged, StandComboBox.SelectedIndexChanged, StatusComboBox.SelectedIndexChanged, VerfuegbarkeitComboBox.SelectedIndexChanged
        Select Case True
            Case sender Is AuslandsaufenthaltComboBox
                If AuslandsaufenthaltComboBox.SelectedIndex > CInt(0) Then
                    Auslandsaufenthalt_woTextBox.Enabled = True
                    Auslandsaufenthalt_dauerTextBox.Enabled = True
                ElseIf AuslandsaufenthaltComboBox.SelectedIndex = CInt(0) Then
                    Auslandsaufenthalt_woTextBox.Enabled = False
                    Auslandsaufenthalt_dauerTextBox.Enabled = False
                End If
            Case sender Is StandComboBox
                '  If StandComboBox.Text = CStr("fertig") Then
                'Interviewerbogen.Visibility = ElementVisibility.Collapsed
                'Else
                'Interviewerbogen.Visibility = ElementVisibility.Visible
                'End If
            Case sender Is VerfuegbarkeitComboBox
                If VerfuegbarkeitComboBox.Text = CStr("nach Kündigung") OrElse VerfuegbarkeitComboBox.Text = CStr("nach Absprache") Then
                    KuendigungsfristComboBox1.Enabled = True
                Else
                    KuendigungsfristComboBox1.Text = String.Empty
                    KuendigungsfristComboBox1.Enabled = False
                End If
        End Select
    End Sub

    ' Wenn Status auf ausgedruckt steht
    Private Sub fertig() ' Status fertig wird gesetzt, wenn Interviewerfragebogen ausgefüllt wurde
        If StandComboBox.Text = CStr("ausgedruckt") OrElse StandComboBox.Text = CStr("ausgefüllt") Then
            GroupBox1.BackColor = Color.Cyan
        Else
            GroupBox1.BackColor = Color.WhiteSmoke
        End If
    End Sub


    ' ========================================================================= Validierungen Auslandsaufenthalt Ende ===================================================

    ' Datum Erstkontakt auf zehn Stellen kürzen ohne Uhrzeit, wenn im format dd.mm.yyyy - hh:hh.mm.ss, wenn Telefon und Handy leer, dann kein Eintrag
    Private Sub erstkontaktkuerzen()
        '      If IsDBNull(ErstkontaktTextBox) OrElse ErstkontaktTextBox.Text = String.Empty Then
        '         Exit Sub
        '  ElseIf ErstkontaktTextBox.TextLength > 10 AndAlso ErstkontaktTextBox.Text.Contains("-") Then
        '     datum = CStr(ErstkontaktTextBox.Text.Substring(0, 10))
        '    ErstkontaktTextBox.Text = CStr(datum)
        '    ElseIf ErstkontaktTextBox.Text.Contains("-") Then
        'Dim text As String = CStr(ErstkontaktTextBox.Text)
        'Dim jahr As String = ErstkontaktTextBox.Text.Substring(0, 4)
        'Dim monat As String = ErstkontaktTextBox.Text.Substring(5, 2)
        'Dim tag As String = ErstkontaktTextBox.Text.Substring(8, 2)
        '       datum = String.Concat(tag, ".", monat, ".", jahr)
        '      ErstkontaktTextBox.Text = CStr(datum)
        ' ElseIf ErstkontaktTextBox.Text.Length > 10 AndAlso ErstkontaktTextBox.Text.Contains(".") Then
        '    datum = CStr(ErstkontaktTextBox.Text.Substring(0, 10))
        '   ErstkontaktTextBox.Text = CStr(datum)
        'End If

        If Tel_festnetzTextBox.Text = String.Empty Then
            Tel_festnetzTextBox.Text = CStr("kein Eintrag")
        End If

        If Tel_mobilTextBox.Text = String.Empty Then
            Tel_mobilTextBox.Text = CStr("kein Eintrag")
        End If
    End Sub

    ' ============================================================================ Mails verschicken =========================================================
    Private Sub mailbeialt() ' Email verschicken, wenn Bewerber auf alt gesetzt wird und BP im Büro ausgeführt wird

        If Not connectionString.Contains("127.0.0.1") Then
            Dim email As New Mail

            Dim betreff As String = String.Concat(AnredeComboBox.Text, " ", VornameTextBox.Text, " ", NameTextBox.Text, " wurde auf ""alt"" gesetzt")
            Dim bodytext As String = String.Concat(AnredeComboBox.Text, " ", VornameTextBox.Text, " ", NameTextBox.Text, " wurde auf ""alt"" gesetzt.", vbNewLine, "Papierulas müssen ebenfalls nach alt verschoben werden.")

            email.receiver = "assistenz@heyduck-personalservice.de, kontakt@heyduck-personalservice.de, volkmar.adler@heyduck-zeitarbeit.de"
            ' email.receiver = "volkmar.adler@heyduck-zeitarbeit.de"
            email.subject = CStr(betreff)
            email.body = CStr(bodytext)
            email.send()
        End If
    End Sub

    Private Sub mailtopbewerber() ' Mail an hy, wenn Bewerber als Topbewerber markiert wird

        Dim bewerber = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)

        If Not connectionString.Contains("127.0.0.1") AndAlso Not bewerber.topbewerberchecked Then
            Dim email As New Mail
            Dim betreff As String = String.Empty
            Dim bodytext As String = String.Empty

            If cmbTopbewerber.SelectedIndex = 1 Then
                betreff = String.Concat(AnredeComboBox.Text, " ", VornameTextBox.Text, " ", NameTextBox.Text, " wurde von ", usernameklar, " als Topbewerber/in Vermittlung markiert")
                bodytext = String.Concat(AnredeComboBox.Text, " ", VornameTextBox.Text, " ", NameTextBox.Text, " wurde von ", usernameklar, " als Topbewerber/in Vermittlung markiert.")
            ElseIf cmbTopbewerber.SelectedIndex = 2 Then
                betreff = String.Concat(AnredeComboBox.Text, " ", VornameTextBox.Text, " ", NameTextBox.Text, " wurde von ", usernameklar, " als Topbewerber/in Zeitarbeit markiert")
                bodytext = String.Concat(AnredeComboBox.Text, " ", VornameTextBox.Text, " ", NameTextBox.Text, " wurde von ", usernameklar, " als Topbewerber/in Zeitarbeit markiert.")
            End If

            email.receiver = "kontakt@heyduck-personalservice.de, beatrixhambitzer@heyduck-personalservice.de, susannehanner@heyduck-personalservice.de"
            'email.receiver = "volkmar.adler@heyduck-zeitarbeit.de"

            email.subject = CStr(betreff)
            email.body = CStr(bodytext)
            email.send()
        End If
    End Sub
    ' ========================================================================== Mails Ende ==================================================================

    ' ========================================================================== Bewerberbeschreibung laden ==================================================
    Private Sub bewerberbeschreibungladen() ' Lädt Bewerberbeschreibung und prüft, ob RTF oder nicht

        Dim bewgrid = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)

        Dim bewerberbeschreibung As String = String.Empty
        Dim bewerberbeschreibungtext As String = String.Empty
        Dim bewerberbeschreibung_bool As Boolean = True
        Dim bewerberbeschreibungtxt_bool As Boolean = True
        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        Dim provider1 As New Telerik.WinForms.Documents.FormatProviders.Txt.TxtFormatProvider()
        Dim content As String = CStr("{\rtf\ansi\ansicpg1252\uc1\deff0\deflang1033{\fonttbl{\f0 Verdana;}}{\colortbl\red0\green0\blue0 ;}{\*\defchp\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone}{\*\defpap\sl276\slmult1\ql\sa180\ltrpar}{\stylesheet{\s0\sqformat\spriority0\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Normal;}{\*\ts2\tsrowd\spriority59\trbrdrt\brdrnone\trbrdrb\brdrnone\trbrdrl\brdrnone\trbrdrr\brdrnone\trbrdrh\brdrnone\trbrdrv\brdrnone\trgaph0\trpaddl75\trpaddr75\trpaddt0\trpaddb0\clpadft3\clpadt0\clpadfr3\clpadr0\clpadfl3\clpadl0\clpadfb3\clpadb0\tsvertalt\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Table Normal;}}\nouicompat\viewkind4\paperw12240\paperh15840\margl1425\margr1425\margt1425\margb1425\deftab720\sectd\pgwsxn12240\pghsxn15840\marglsxn1425\margrsxn1425\margtsxn1425\margbsxn1425\headery720\footery720\pard\s0\sl276\slmult1\ql\sa180\ltrpar{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone  }{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\par}}")

        ' Wenn eintrag in DB DBNull ist, einen nach RTF leeren String importieren und Sub beenden
        If bewgrid.IsbewerberbeschreibungNull Then
            '  RTEBewerberbeschreibung.Document = provider.Import(content)
            bewerberbeschreibung_bool = False
            '   Exit Sub
        End If

        If bewgrid.Isbewerberbeschreibung_textNull Then
            bewerberbeschreibungtxt_bool = False
        End If

        ' Wenn eintrag in DB nicht DBNull ist, geht es hier weiter
        If bewerberbeschreibung_bool Then
            bewerberbeschreibung = CStr(bewgrid.bewerberbeschreibung)
        End If

        If bewerberbeschreibungtxt_bool Then
            bewerberbeschreibungtext = CStr(bewgrid.bewerberbeschreibung_text)
        End If

        If bewerberbeschreibung_bool AndAlso bewerberbeschreibung.Contains("{\rtf") Then
            RTEBewerberbeschreibung.Document = provider.Import(bewerberbeschreibung)
            RTEBewerberbeschreibung.Document.Selection.SelectAll()
            RTEBewerberbeschreibung.DocumentEditor.ChangeFontSize(15)
            RTEBewerberbeschreibung.DocumentEditor.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Microsoft Sans Serif"))
            RTEBewerberbeschreibung.Document.Selection.Clear()
        ElseIf Not bewerberbeschreibung.Contains("{\rtf") Then
            RTEBewerberbeschreibung.Document = provider1.Import(bewerberbeschreibungtext)
            RTEBewerberbeschreibung.Document.Selection.SelectAll()
            RTEBewerberbeschreibung.DocumentEditor.ChangeFontSize(15)
            RTEBewerberbeschreibung.DocumentEditor.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Microsoft Sans Serif"))
            RTEBewerberbeschreibung.Document.Selection.Clear()
        End If
        bewerberbeschreibung = String.Empty
    End Sub

    ' ========================================================================== Bewerberbeschreibung laden Ende =================================================

    ' Altersberechnung: Geburtstag auslesen und Alter jahrgenau berechnen
    Private Sub Altersberechnung()
        Dim bewerberdaten = DirectCast(DirectCast(Me.Bew_bewerberdatenBindingSource.Current, DataRowView).Row, bew_bewerberdatenRow)

        If Not bewerberdaten.IsgeburtstagNull OrElse bewerberdaten.geburtstag <> String.Empty Then
            Dim geburtstag As Date = Date.Parse(bewerberdaten.geburtstag)
            alter = DateTime.Now.Year - geburtstag.Year
            If geburtstag.Month > DateTime.Now.Month OrElse DateTime.Now.Month = geburtstag.Month AndAlso DateTime.Now.Day < geburtstag.Day Then
                alter -= 1
                Alter_jahrTextBox.Text = CStr(alter)
                Alter_jahrTextBox2.Text = CStr(alter)
            Else
                Alter_jahrTextBox.Text = CStr(alter)
                Alter_jahrTextBox2.Text = CStr(alter)
            End If
        End If
    End Sub

    Private Function ValidateGeburtstag(ByRef pattern As String) As Boolean
        Dim geburtstagRegex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("((?:(?:[0-2]?\d{1})|(?:[3][01]{1}))[-:\/.](?:[0]?[1-9]|[1][012])[-:\/.](?:(?:[1]{1}\d{1}\d{1}\d{1})|(?:[2]{1}\d{3})))(?![\d])")
        Dim M As System.Text.RegularExpressions.Match = geburtstagRegex.Match(pattern)
        Return M.Success
    End Function

#Region "Fremdsprachen für Feld ""Sprachkenntnisse"" es werden die Interviewereinträge verwendet, soweit vorhanden"
    Private Sub sprachendaten()

        Dim bewerbersprachen = DirectCast(DirectCast(Me.Bewerber_sprachenBindingSource.Current, DataRowView).Row, bewerber_sprachenRow)
        Dim sprachen As New List(Of String)()

        If Not bewerbersprachen.Isdeutsch_interviewerNull AndAlso bewerbersprachen.deutsch_interviewer <> 0 Then
            sprachen.Add(String.Concat("D ", bewerbersprachen.deutsch_interviewer.ToString))
        ElseIf bewerbersprachen.deutsch <> 0 Then
            sprachen.Add(String.Concat("D ", bewerbersprachen.deutsch.ToString))
        End If

        If Not bewerbersprachen.Isenglisch_interviewerNull AndAlso bewerbersprachen.englisch_interviewer <> 0 Then
            sprachen.Add(String.Concat("E ", bewerbersprachen.englisch_interviewer.ToString))
        ElseIf bewerbersprachen.englisch <> 0 Then
            sprachen.Add(String.Concat("E ", bewerbersprachen.englisch.ToString))
        End If

        If Not bewerbersprachen.Isfranzösich_interviewerNull AndAlso bewerbersprachen.französich_interviewer <> 0 Then
            sprachen.Add(String.Concat("F ", bewerbersprachen.französich_interviewer.ToString))
        ElseIf bewerbersprachen.franzoesisch <> 0 Then
            sprachen.Add(String.Concat("F ", bewerbersprachen.franzoesisch.ToString))
        End If

        If Not bewerbersprachen.Isspanisch_interviewerNull AndAlso bewerbersprachen.spanisch_interviewer <> 0 Then
            sprachen.Add(String.Concat("S ", bewerbersprachen.spanisch_interviewer.ToString))
        ElseIf bewerbersprachen.spanisch <> 0 Then
            sprachen.Add(String.Concat("S ", bewerbersprachen.spanisch.ToString))
        End If

        If Not bewerbersprachen.Isitalienisch_interviewerNull AndAlso bewerbersprachen.italienisch_interviewer <> 0 Then
            sprachen.Add(String.Concat("I ", bewerbersprachen.italienisch_interviewer.ToString))
        ElseIf bewerbersprachen.italienisch <> 0 Then
            sprachen.Add(String.Concat("I ", bewerbersprachen.italienisch.ToString))
        End If

        If Not bewerbersprachen.Isniederlaendisch_interviewerNull AndAlso bewerbersprachen.niederlaendisch_interviewer <> 0 Then
            sprachen.Add(String.Concat("N ", bewerbersprachen.niederlaendisch_interviewer))
        ElseIf bewerbersprachen.niederlaendisch <> 0 Then
            sprachen.Add(String.Concat("N ", bewerbersprachen.niederlaendisch.ToString))
        End If

        If Not bewerbersprachen.Istuerkisch_interviewerNull AndAlso bewerbersprachen.tuerkisch_interviewer <> 0 Then
            sprachen.Add(String.Concat("T ", bewerbersprachen.tuerkisch_interviewer.ToString))
        ElseIf bewerbersprachen.tuerkisch <> 0 Then
            sprachen.Add(String.Concat("T ", bewerbersprachen.tuerkisch.ToString))
        End If

        If Not bewerbersprachen.Isrussisch_interviewerNull AndAlso bewerbersprachen.russisch_interviewer <> 0 Then
            sprachen.Add(String.Concat("R ", bewerbersprachen.russisch_interviewer.ToString))
        ElseIf bewerbersprachen.russisch <> 0 Then
            sprachen.Add(String.Concat("R ", bewerbersprachen.russisch.ToString))
        End If

        sprachenliste = String.Join(vbNewLine, sprachen) ' Sprachenliste ist Public
    End Sub


    Private Sub Comboboxfill()
        For Each cmb As ComboBox In Me.GroupBox74.Controls.OfType(Of ComboBox)()
            cmb.DropDownStyle = ComboBoxStyle.DropDownList
            cmb.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
            cmb.SelectedIndex = 0
        Next
    End Sub


#End Region

    Private Sub Bewerberkomplettloeschen()

        Dim result As DialogResult = MessageBox.Show("Wollen Sie diesen Datensatz vollständig und endgültig löschen? Der Vorgang kann nicht rückgängig gemacht werden.", "Vollständig löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If result = DialogResult.Yes Then

            If BewerberDataSet.notizen.Any(Function(y) y.bewid = letzteid) Then
                Dim notizen = BewerberDataSet.notizen.Where(Function(x) x.bewid = letzteid)
                For Each x In notizen
                    x.anmerkungen_rtf = String.Empty
                    x.anmerkungen_text = String.Empty
                    x.betreff = String.Empty
                Next
                Me.NotizenBindingSource.EndEdit()
                Me.NotizenTableAdapter.Update(BewerberDataSet.notizen)
            End If

            Dim bew_assistenzrow = DirectCast(DirectCast(Bew_assistenzBindingSource.Current, DataRowView).Row, bew_assistenzRow)
            bew_assistenzrow.Delete()

            Dim bew_bewerberdatenrow = DirectCast(DirectCast(Bew_bewerberdatenBindingSource.Current, DataRowView).Row, bew_bewerberdatenRow)
            bew_bewerberdatenrow.Delete()

            Dim bew_bibuharow = DirectCast(DirectCast(Bew_bibuhaBindingSource.Current, DataRowView).Row, bew_bibuhaRow)
            bew_bibuharow.Delete()

            Dim bewlug = DirectCast(DirectCast(Bew_lugBindingSource.Current, DataRowView).Row, bew_lugRow)
            bewlug.Delete()

            Dim bewsteuerfachang = DirectCast(DirectCast(Bew_steuerfachangestellteBindingSource.Current, DataRowView).Row, bew_steuerfachangestellteRow)
            bewsteuerfachang.Delete()

            Dim ausbildung = DirectCast(DirectCast(Bewerber_ausbildungBindingSource.Current, DataRowView).Row, bewerber_ausbildungRow)
            ausbildung.Delete()

            Dim berufserfahrung = DirectCast(DirectCast(Bewerber_berufserfahrungBindingSource.Current, DataRowView).Row, bewerber_berufserfahrungRow)
            berufserfahrung.Delete()

            Dim buero = DirectCast(DirectCast(Bewerber_bueroBindingSource.Current, DataRowView).Row, bewerber_bueroRow)
            buero.Delete()

            Dim controlling = DirectCast(DirectCast(Bewerber_controllingBindingSource.Current, DataRowView).Row, bewerber_controllingRow)
            controlling.Delete()

            Dim edv = DirectCast(DirectCast(Bewerber_edvBindingSource.Current, DataRowView).Row, bewerber_edvRow)
            edv.Delete()

            Dim einkauf = DirectCast(DirectCast(Bewerber_einkaufBindingSource.Current, DataRowView).Row, bewerber_einkaufRow)
            einkauf.Delete()

            Dim fibu = DirectCast(DirectCast(Bewerber_fibuBindingSource.Current, DataRowView).Row, bewerber_fibuRow)
            fibu.Delete()

            Dim it = DirectCast(DirectCast(Bewerber_itBindingSource.Current, DataRowView).Row, bewerber_itRow)
            it.Delete()

            Dim logistik = DirectCast(DirectCast(Bewerber_logistikBindingSource.Current, DataRowView).Row, bewerber_logistikRow)
            logistik.Delete()

            Dim mud = DirectCast(DirectCast(Bewerber_marketing_designBindingSource.Current, DataRowView).Row, bewerber_marketing_designRow)
            mud.Delete()

            Dim personal = DirectCast(DirectCast(Bewerber_personalBindingSource.Current, DataRowView).Row, bewerber_personalRow)
            personal.Delete()

            Dim rae = DirectCast(DirectCast(Bewerber_raeBindingSource.Current, DataRowView).Row, bewerber_raeRow)
            rae.Delete()

            Dim sprachen = DirectCast(DirectCast(Bewerber_sprachenBindingSource.Current, DataRowView).Row, bewerber_sprachenRow)
            sprachen.Delete()

            Dim technik = DirectCast(DirectCast(Bewerber_technikBindingSource.Current, DataRowView).Row, bewerber_technikRow)
            technik.Delete()

            Dim versand = DirectCast(DirectCast(Bewerber_versandBindingSource.Current, DataRowView).Row, bewerber_versandRow)
            versand.Delete()

            Dim vertrieb = DirectCast(DirectCast(Bewerber_vertriebBindingSource.Current, DataRowView).Row, bewerber_vertriebRow)
            vertrieb.Delete()

            Dim gewerblich = DirectCast(DirectCast(GewerblichBindingSource.Current, DataRowView).Row, gewerblichRow)
            gewerblich.Delete()

            Dim ulas = DirectCast(DirectCast(UlasBindingSource.Current, DataRowView).Row, ulasRow)
            ulas.Delete()

            Dim bewrow = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)
            bewrow.Delete()

            For Each bs As BindingSource In Me.Controls.OfType(Of BindingSource)()
                bs.EndEdit()
            Next
            Me.TableAdapterManager.UpdateAll(Me.BewerberDataSet)
            MessageBox.Show("Datensatz erfolgreich gelöscht", "Datensatz gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Datensatz wurde nicht gelöscht", "Datensatz nicht gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

End Class