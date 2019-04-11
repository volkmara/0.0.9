<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelefoninterview
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim InterviewerLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Tel_mobilLabel As System.Windows.Forms.Label
        Dim Tel_festnetzLabel As System.Windows.Forms.Label
        Dim StrasseLabel As System.Windows.Forms.Label
        Dim OrtsteilLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim PlzLabel As System.Windows.Forms.Label
        Dim Alter_jahrLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim Kunden_nicht_vorschlagen_laut_interviewerLabel As System.Windows.Forms.Label
        Dim Stelle_nicht_vorschlagen_laut_interviewerLabel As System.Windows.Forms.Label
        Dim Kunde_vorschlagen_laut_interviewerLabel As System.Windows.Forms.Label
        Dim Stelle_vorschlagen_laut_interviewerLabel1 As System.Windows.Forms.Label
        Dim WechselwunschLabel As System.Windows.Forms.Label
        Dim Beendigungsgrund_detailsLabel As System.Windows.Forms.Label
        Dim BeendigungsgrundLabel As System.Windows.Forms.Label
        Dim KuendigungsfristLabel As System.Windows.Forms.Label
        Dim VerfuegbarkeitLabel As System.Windows.Forms.Label
        Dim MdELabel1 As System.Windows.Forms.Label
        Dim MdELabel As System.Windows.Forms.Label
        Dim Gehaltswunsch_jahrLabel As System.Windows.Forms.Label
        Dim Gehaltswunsch_monatLabel As System.Windows.Forms.Label
        Dim JahresgehaltLabel As System.Windows.Forms.Label
        Dim MonatsgehaltLabel As System.Windows.Forms.Label
        Dim Pkw_oepnvLabel As System.Windows.Forms.Label
        Dim FuehrerscheinLabel As System.Windows.Forms.Label
        Dim UmzugLabel As System.Windows.Forms.Label
        Dim ArbeitsortLabel As System.Windows.Forms.Label
        Dim Letzte_beschaeftigungLabel As System.Windows.Forms.Label
        Dim Teilzeit_wannLabel As System.Windows.Forms.Label
        Dim Teilzeit_stundenLabel As System.Windows.Forms.Label
        Dim Vz_tzLabel As System.Windows.Forms.Label
        Dim Za_vmLabel As System.Windows.Forms.Label
        Dim Stelle_vorschlagen_laut_interviewerLabel As System.Windows.Forms.Label
        Dim Kunde_vorschlagen_laut_bewerberLabel As System.Windows.Forms.Label
        Dim JobwunschLabel As System.Windows.Forms.Label
        Dim StudienfaecherLabel As System.Windows.Forms.Label
        Dim Studium_abschlussLabel As System.Windows.Forms.Label
        Dim Ausbildung_qualifizierungLabel As System.Windows.Forms.Label
        Dim AusbildungsberufLabel As System.Windows.Forms.Label
        Dim Personalverantwortung_anzahlLabel As System.Windows.Forms.Label
        Dim PersonalverantwortungLabel As System.Windows.Forms.Label
        Dim Fuehrungsverantwortung_dauerLabel As System.Windows.Forms.Label
        Dim FuehrungsverantwortungLabel As System.Windows.Forms.Label
        Dim ZeugnistextLabel As System.Windows.Forms.Label
        Dim Beruf_schwerpunkttaetigkeitLabel As System.Windows.Forms.Label
        Dim Beruf_positionLabel As System.Windows.Forms.Label
        Dim Auslandsaufenthalt_dauerLabel As System.Windows.Forms.Label
        Dim Auslandsaufenthalt_woLabel As System.Windows.Forms.Label
        Dim AuslandsaufenthaltLabel As System.Windows.Forms.Label
        Dim SonstigeLabel As System.Windows.Forms.Label
        Dim Lotus_notesLabel As System.Windows.Forms.Label
        Dim ThunderbirdLabel As System.Windows.Forms.Label
        Dim ProjectLabel As System.Windows.Forms.Label
        Dim AccessLabel As System.Windows.Forms.Label
        Dim OutlookLabel As System.Windows.Forms.Label
        Dim PowerpointLabel As System.Windows.Forms.Label
        Dim ExcelLabel As System.Windows.Forms.Label
        Dim WordLabel As System.Windows.Forms.Label
        Dim DeutschLabel1 As System.Windows.Forms.Label
        Dim EnglischLabel As System.Windows.Forms.Label
        Dim FranzoesischLabel1 As System.Windows.Forms.Label
        Dim SpanischLabel1 As System.Windows.Forms.Label
        Dim ItalienischLabel1 As System.Windows.Forms.Label
        Dim TuerkischLabel1 As System.Windows.Forms.Label
        Dim RussischLabel1 As System.Windows.Forms.Label
        Dim NiederlaendischLabel1 As System.Windows.Forms.Label
        Dim Sap_moduleLabel As System.Windows.Forms.Label
        Dim OracleLabel As System.Windows.Forms.Label
        Dim LexwareLabel As System.Windows.Forms.Label
        Dim KhksageLabel As System.Windows.Forms.Label
        Dim Microsoft_navisionLabel As System.Windows.Forms.Label
        Dim Microsoft_dynamicsLabel As System.Windows.Forms.Label
        Dim As400Label As System.Windows.Forms.Label
        Dim DatevproLabel As System.Windows.Forms.Label
        Dim DatevLabel As System.Windows.Forms.Label
        Dim SapLabel As System.Windows.Forms.Label
        Dim Gdb_gradLabel As System.Windows.Forms.Label
        Dim Software_sonstigeLabel As System.Windows.Forms.Label
        Dim EmpfehlungLabel As System.Windows.Forms.Label
        Dim AufmerksamLabel As System.Windows.Forms.Label
        Dim Aufmerksam_andereLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelefoninterview))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InterviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StrasseTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_mobilTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_festnetzTextBox = New System.Windows.Forms.TextBox()
        Me.OrtsteilTextBox = New System.Windows.Forms.TextBox()
        Me.Bew_bewerberdatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrtTextBox = New System.Windows.Forms.TextBox()
        Me.PlzTextBox = New System.Windows.Forms.TextBox()
        Me.Alter_jahrTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.AnredeComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAufmerksam_andere = New System.Windows.Forms.TextBox()
        Me.cmbAufmerksam = New System.Windows.Forms.ComboBox()
        Me.EmpfehlungTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Kunden_nicht_vorschlagen_laut_interviewerTextBox = New System.Windows.Forms.TextBox()
        Me.UlasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stelle_nicht_vorschlagen_laut_interviewerTextBox = New System.Windows.Forms.TextBox()
        Me.Kunde_vorschlagen_laut_interviewerTextBox = New System.Windows.Forms.TextBox()
        Me.Stelle_vorschlagen_laut_interviewerTextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.WechselwunschTextBox = New System.Windows.Forms.TextBox()
        Me.Beendigungsgrund_detailsTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BeendigungsgrundComboBox = New System.Windows.Forms.ComboBox()
        Me.KuendigungsfristComboBox = New System.Windows.Forms.ComboBox()
        Me.VerfuegbarkeitComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Gdb_gradTextBox = New System.Windows.Forms.TextBox()
        Me.MdEComboBox = New System.Windows.Forms.ComboBox()
        Me.MdETextBox = New System.Windows.Forms.TextBox()
        Me.Gehaltswunsch_jahrTextBox = New System.Windows.Forms.TextBox()
        Me.Gehaltswunsch_monatTextBox = New System.Windows.Forms.TextBox()
        Me.JahresgehaltTextBox = New System.Windows.Forms.TextBox()
        Me.MonatsgehaltTextBox = New System.Windows.Forms.TextBox()
        Me.Pkw_oepnvTextBox = New System.Windows.Forms.TextBox()
        Me.FuehrerscheinTextBox = New System.Windows.Forms.TextBox()
        Me.UmzugComboBox = New System.Windows.Forms.ComboBox()
        Me.ArbeitsortTextBox = New System.Windows.Forms.TextBox()
        Me.Letzte_beschaeftigungTextBox = New System.Windows.Forms.TextBox()
        Me.Teilzeit_wannComboBox = New System.Windows.Forms.ComboBox()
        Me.Teilzeit_stundenComboBox = New System.Windows.Forms.ComboBox()
        Me.Vz_tzComboBox = New System.Windows.Forms.ComboBox()
        Me.Za_vmTextBox = New System.Windows.Forms.TextBox()
        Me.Stelle_vorschlagen_laut_interviewerTextBox = New System.Windows.Forms.TextBox()
        Me.Kunde_vorschlagen_laut_bewerberTextBox = New System.Windows.Forms.TextBox()
        Me.JobwunschTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.StudienfaecherTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_ausbildungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Studium_abschlussTextBox = New System.Windows.Forms.TextBox()
        Me.Ausbildung_qualifizierungTextBox = New System.Windows.Forms.TextBox()
        Me.AusbildungsberufTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Personalverantwortung_anzahlTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_berufserfahrungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalverantwortungComboBox = New System.Windows.Forms.ComboBox()
        Me.Fuehrungsverantwortung_dauerTextBox = New System.Windows.Forms.TextBox()
        Me.FuehrungsverantwortungComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ZeugnistextTextBox = New System.Windows.Forms.TextBox()
        Me.Beruf_schwerpunkttaetigkeitTextBox = New System.Windows.Forms.TextBox()
        Me.Beruf_positionTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.AuslandsaufenthaltComboBox = New System.Windows.Forms.ComboBox()
        Me.Auslandsaufenthalt_woTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_sprachenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Auslandsaufenthalt_dauerTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.NiederlaendischComboBox = New System.Windows.Forms.ComboBox()
        Me.RussischComboBox = New System.Windows.Forms.ComboBox()
        Me.TuerkischComboBox = New System.Windows.Forms.ComboBox()
        Me.ItalienischComboBox = New System.Windows.Forms.ComboBox()
        Me.SpanischComboBox = New System.Windows.Forms.ComboBox()
        Me.FranzoesischComboBox = New System.Windows.Forms.ComboBox()
        Me.EnglischComboBox = New System.Windows.Forms.ComboBox()
        Me.DeutschComboBox = New System.Windows.Forms.ComboBox()
        Me.SonstigeTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.Software_sonstigeTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_edvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.Sap_moduleTextBox = New System.Windows.Forms.TextBox()
        Me.OracleComboBox = New System.Windows.Forms.ComboBox()
        Me.LexwareComboBox = New System.Windows.Forms.ComboBox()
        Me.KhksageComboBox = New System.Windows.Forms.ComboBox()
        Me.Microsoft_navisionComboBox = New System.Windows.Forms.ComboBox()
        Me.Microsoft_dynamicsComboBox = New System.Windows.Forms.ComboBox()
        Me.As400ComboBox = New System.Windows.Forms.ComboBox()
        Me.DatevComboBox = New System.Windows.Forms.ComboBox()
        Me.DatevproComboBox = New System.Windows.Forms.ComboBox()
        Me.SapComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lotus_notesComboBox = New System.Windows.Forms.ComboBox()
        Me.ThunderbirdComboBox = New System.Windows.Forms.ComboBox()
        Me.WordComboBox = New System.Windows.Forms.ComboBox()
        Me.ProjectComboBox = New System.Windows.Forms.ComboBox()
        Me.AccessComboBox = New System.Windows.Forms.ComboBox()
        Me.OutlookComboBox = New System.Windows.Forms.ComboBox()
        Me.PowerpointComboBox = New System.Windows.Forms.ComboBox()
        Me.ExcelComboBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.RTEPersoenlichkeit = New Telerik.WinControls.UI.RadRichTextEditor()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UlasListBox = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.TableAdapterManager = New bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager()
        Me.Bew_bewerberdatenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bew_bewerberdatenTableAdapter()
        Me.Bewerber_ausbildungTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewerber_ausbildungTableAdapter()
        Me.Bewerber_berufserfahrungTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewerber_berufserfahrungTableAdapter()
        Me.Bewerber_edvTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewerber_edvTableAdapter()
        Me.Bewerber_sprachenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewerber_sprachenTableAdapter()
        Me.UlasTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.ulasTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        InterviewerLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Tel_mobilLabel = New System.Windows.Forms.Label()
        Tel_festnetzLabel = New System.Windows.Forms.Label()
        StrasseLabel = New System.Windows.Forms.Label()
        OrtsteilLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        PlzLabel = New System.Windows.Forms.Label()
        Alter_jahrLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        AnredeLabel = New System.Windows.Forms.Label()
        Kunden_nicht_vorschlagen_laut_interviewerLabel = New System.Windows.Forms.Label()
        Stelle_nicht_vorschlagen_laut_interviewerLabel = New System.Windows.Forms.Label()
        Kunde_vorschlagen_laut_interviewerLabel = New System.Windows.Forms.Label()
        Stelle_vorschlagen_laut_interviewerLabel1 = New System.Windows.Forms.Label()
        WechselwunschLabel = New System.Windows.Forms.Label()
        Beendigungsgrund_detailsLabel = New System.Windows.Forms.Label()
        BeendigungsgrundLabel = New System.Windows.Forms.Label()
        KuendigungsfristLabel = New System.Windows.Forms.Label()
        VerfuegbarkeitLabel = New System.Windows.Forms.Label()
        MdELabel1 = New System.Windows.Forms.Label()
        MdELabel = New System.Windows.Forms.Label()
        Gehaltswunsch_jahrLabel = New System.Windows.Forms.Label()
        Gehaltswunsch_monatLabel = New System.Windows.Forms.Label()
        JahresgehaltLabel = New System.Windows.Forms.Label()
        MonatsgehaltLabel = New System.Windows.Forms.Label()
        Pkw_oepnvLabel = New System.Windows.Forms.Label()
        FuehrerscheinLabel = New System.Windows.Forms.Label()
        UmzugLabel = New System.Windows.Forms.Label()
        ArbeitsortLabel = New System.Windows.Forms.Label()
        Letzte_beschaeftigungLabel = New System.Windows.Forms.Label()
        Teilzeit_wannLabel = New System.Windows.Forms.Label()
        Teilzeit_stundenLabel = New System.Windows.Forms.Label()
        Vz_tzLabel = New System.Windows.Forms.Label()
        Za_vmLabel = New System.Windows.Forms.Label()
        Stelle_vorschlagen_laut_interviewerLabel = New System.Windows.Forms.Label()
        Kunde_vorschlagen_laut_bewerberLabel = New System.Windows.Forms.Label()
        JobwunschLabel = New System.Windows.Forms.Label()
        StudienfaecherLabel = New System.Windows.Forms.Label()
        Studium_abschlussLabel = New System.Windows.Forms.Label()
        Ausbildung_qualifizierungLabel = New System.Windows.Forms.Label()
        AusbildungsberufLabel = New System.Windows.Forms.Label()
        Personalverantwortung_anzahlLabel = New System.Windows.Forms.Label()
        PersonalverantwortungLabel = New System.Windows.Forms.Label()
        Fuehrungsverantwortung_dauerLabel = New System.Windows.Forms.Label()
        FuehrungsverantwortungLabel = New System.Windows.Forms.Label()
        ZeugnistextLabel = New System.Windows.Forms.Label()
        Beruf_schwerpunkttaetigkeitLabel = New System.Windows.Forms.Label()
        Beruf_positionLabel = New System.Windows.Forms.Label()
        Auslandsaufenthalt_dauerLabel = New System.Windows.Forms.Label()
        Auslandsaufenthalt_woLabel = New System.Windows.Forms.Label()
        AuslandsaufenthaltLabel = New System.Windows.Forms.Label()
        SonstigeLabel = New System.Windows.Forms.Label()
        Lotus_notesLabel = New System.Windows.Forms.Label()
        ThunderbirdLabel = New System.Windows.Forms.Label()
        ProjectLabel = New System.Windows.Forms.Label()
        AccessLabel = New System.Windows.Forms.Label()
        OutlookLabel = New System.Windows.Forms.Label()
        PowerpointLabel = New System.Windows.Forms.Label()
        ExcelLabel = New System.Windows.Forms.Label()
        WordLabel = New System.Windows.Forms.Label()
        DeutschLabel1 = New System.Windows.Forms.Label()
        EnglischLabel = New System.Windows.Forms.Label()
        FranzoesischLabel1 = New System.Windows.Forms.Label()
        SpanischLabel1 = New System.Windows.Forms.Label()
        ItalienischLabel1 = New System.Windows.Forms.Label()
        TuerkischLabel1 = New System.Windows.Forms.Label()
        RussischLabel1 = New System.Windows.Forms.Label()
        NiederlaendischLabel1 = New System.Windows.Forms.Label()
        Sap_moduleLabel = New System.Windows.Forms.Label()
        OracleLabel = New System.Windows.Forms.Label()
        LexwareLabel = New System.Windows.Forms.Label()
        KhksageLabel = New System.Windows.Forms.Label()
        Microsoft_navisionLabel = New System.Windows.Forms.Label()
        Microsoft_dynamicsLabel = New System.Windows.Forms.Label()
        As400Label = New System.Windows.Forms.Label()
        DatevproLabel = New System.Windows.Forms.Label()
        DatevLabel = New System.Windows.Forms.Label()
        SapLabel = New System.Windows.Forms.Label()
        Gdb_gradLabel = New System.Windows.Forms.Label()
        Software_sonstigeLabel = New System.Windows.Forms.Label()
        EmpfehlungLabel = New System.Windows.Forms.Label()
        AufmerksamLabel = New System.Windows.Forms.Label()
        Aufmerksam_andereLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Bew_bewerberdatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.UlasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Bewerber_ausbildungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Bewerber_berufserfahrungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.Bewerber_sprachenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox29.SuspendLayout()
        CType(Me.Bewerber_edvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.RTEPersoenlichkeit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InterviewerLabel
        '
        InterviewerLabel.AutoSize = True
        InterviewerLabel.Location = New System.Drawing.Point(7, 47)
        InterviewerLabel.Name = "InterviewerLabel"
        InterviewerLabel.Size = New System.Drawing.Size(96, 17)
        InterviewerLabel.TabIndex = 1
        InterviewerLabel.Text = "geführt von:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(666, 139)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(51, 16)
        EmailLabel.TabIndex = 20
        EmailLabel.Text = "Email:"
        '
        'Tel_mobilLabel
        '
        Tel_mobilLabel.AutoSize = True
        Tel_mobilLabel.Location = New System.Drawing.Point(347, 139)
        Tel_mobilLabel.Name = "Tel_mobilLabel"
        Tel_mobilLabel.Size = New System.Drawing.Size(57, 16)
        Tel_mobilLabel.TabIndex = 18
        Tel_mobilLabel.Text = "Handy:"
        '
        'Tel_festnetzLabel
        '
        Tel_festnetzLabel.AutoSize = True
        Tel_festnetzLabel.Location = New System.Drawing.Point(6, 139)
        Tel_festnetzLabel.Name = "Tel_festnetzLabel"
        Tel_festnetzLabel.Size = New System.Drawing.Size(70, 16)
        Tel_festnetzLabel.TabIndex = 16
        Tel_festnetzLabel.Text = "Festnetz:"
        '
        'StrasseLabel
        '
        StrasseLabel.AutoSize = True
        StrasseLabel.Location = New System.Drawing.Point(707, 85)
        StrasseLabel.Name = "StrasseLabel"
        StrasseLabel.Size = New System.Drawing.Size(65, 16)
        StrasseLabel.TabIndex = 14
        StrasseLabel.Text = "Strasse:"
        '
        'OrtsteilLabel
        '
        OrtsteilLabel.AutoSize = True
        OrtsteilLabel.Location = New System.Drawing.Point(425, 85)
        OrtsteilLabel.Name = "OrtsteilLabel"
        OrtsteilLabel.Size = New System.Drawing.Size(61, 16)
        OrtsteilLabel.TabIndex = 12
        OrtsteilLabel.Text = "Ortsteil:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(193, 85)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(32, 16)
        OrtLabel.TabIndex = 10
        OrtLabel.Text = "Ort:"
        '
        'PlzLabel
        '
        PlzLabel.AutoSize = True
        PlzLabel.Location = New System.Drawing.Point(6, 85)
        PlzLabel.Name = "PlzLabel"
        PlzLabel.Size = New System.Drawing.Size(33, 16)
        PlzLabel.TabIndex = 8
        PlzLabel.Text = "Plz:"
        '
        'Alter_jahrLabel
        '
        Alter_jahrLabel.AutoSize = True
        Alter_jahrLabel.Location = New System.Drawing.Point(822, 37)
        Alter_jahrLabel.Name = "Alter_jahrLabel"
        Alter_jahrLabel.Size = New System.Drawing.Size(44, 16)
        Alter_jahrLabel.TabIndex = 6
        Alter_jahrLabel.Text = "Alter:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(498, 37)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(86, 16)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Nachname:"
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(232, 37)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(74, 16)
        VornameLabel.TabIndex = 2
        VornameLabel.Text = "Vorname:"
        '
        'AnredeLabel
        '
        AnredeLabel.AutoSize = True
        AnredeLabel.Location = New System.Drawing.Point(6, 37)
        AnredeLabel.Name = "AnredeLabel"
        AnredeLabel.Size = New System.Drawing.Size(62, 16)
        AnredeLabel.TabIndex = 0
        AnredeLabel.Text = "Anrede:"
        '
        'Kunden_nicht_vorschlagen_laut_interviewerLabel
        '
        Kunden_nicht_vorschlagen_laut_interviewerLabel.AutoSize = True
        Kunden_nicht_vorschlagen_laut_interviewerLabel.Location = New System.Drawing.Point(515, 146)
        Kunden_nicht_vorschlagen_laut_interviewerLabel.Name = "Kunden_nicht_vorschlagen_laut_interviewerLabel"
        Kunden_nicht_vorschlagen_laut_interviewerLabel.Size = New System.Drawing.Size(126, 48)
        Kunden_nicht_vorschlagen_laut_interviewerLabel.TabIndex = 6
        Kunden_nicht_vorschlagen_laut_interviewerLabel.Text = "Für Kunden nicht " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vorschlagen laut " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interviewer:"
        '
        'Stelle_nicht_vorschlagen_laut_interviewerLabel
        '
        Stelle_nicht_vorschlagen_laut_interviewerLabel.AutoSize = True
        Stelle_nicht_vorschlagen_laut_interviewerLabel.Location = New System.Drawing.Point(6, 146)
        Stelle_nicht_vorschlagen_laut_interviewerLabel.Name = "Stelle_nicht_vorschlagen_laut_interviewerLabel"
        Stelle_nicht_vorschlagen_laut_interviewerLabel.Size = New System.Drawing.Size(126, 48)
        Stelle_nicht_vorschlagen_laut_interviewerLabel.TabIndex = 4
        Stelle_nicht_vorschlagen_laut_interviewerLabel.Text = "Für Stelle nicht " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vorschlagen laut " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interviewer:"
        '
        'Kunde_vorschlagen_laut_interviewerLabel
        '
        Kunde_vorschlagen_laut_interviewerLabel.AutoSize = True
        Kunde_vorschlagen_laut_interviewerLabel.Location = New System.Drawing.Point(515, 33)
        Kunde_vorschlagen_laut_interviewerLabel.Name = "Kunde_vorschlagen_laut_interviewerLabel"
        Kunde_vorschlagen_laut_interviewerLabel.Size = New System.Drawing.Size(170, 32)
        Kunde_vorschlagen_laut_interviewerLabel.TabIndex = 2
        Kunde_vorschlagen_laut_interviewerLabel.Text = "Für Kunde vorschlagen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "laut Interviewer:"
        '
        'Stelle_vorschlagen_laut_interviewerLabel1
        '
        Stelle_vorschlagen_laut_interviewerLabel1.AutoSize = True
        Stelle_vorschlagen_laut_interviewerLabel1.Location = New System.Drawing.Point(6, 36)
        Stelle_vorschlagen_laut_interviewerLabel1.Name = "Stelle_vorschlagen_laut_interviewerLabel1"
        Stelle_vorschlagen_laut_interviewerLabel1.Size = New System.Drawing.Size(167, 32)
        Stelle_vorschlagen_laut_interviewerLabel1.TabIndex = 0
        Stelle_vorschlagen_laut_interviewerLabel1.Text = "Für Stelle vorschlagen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "laut Interviewer:"
        '
        'WechselwunschLabel
        '
        WechselwunschLabel.AutoSize = True
        WechselwunschLabel.Location = New System.Drawing.Point(515, 81)
        WechselwunschLabel.Name = "WechselwunschLabel"
        WechselwunschLabel.Size = New System.Drawing.Size(122, 16)
        WechselwunschLabel.TabIndex = 11
        WechselwunschLabel.Text = "Wechselwunsch:"
        '
        'Beendigungsgrund_detailsLabel
        '
        Beendigungsgrund_detailsLabel.AutoSize = True
        Beendigungsgrund_detailsLabel.Location = New System.Drawing.Point(6, 84)
        Beendigungsgrund_detailsLabel.Name = "Beendigungsgrund_detailsLabel"
        Beendigungsgrund_detailsLabel.Size = New System.Drawing.Size(104, 48)
        Beendigungsgrund_detailsLabel.TabIndex = 10
        Beendigungsgrund_detailsLabel.Text = "Beendigungs-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "grund " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Details:"
        '
        'BeendigungsgrundLabel
        '
        BeendigungsgrundLabel.AutoSize = True
        BeendigungsgrundLabel.Location = New System.Drawing.Point(652, 31)
        BeendigungsgrundLabel.Name = "BeendigungsgrundLabel"
        BeendigungsgrundLabel.Size = New System.Drawing.Size(142, 16)
        BeendigungsgrundLabel.TabIndex = 8
        BeendigungsgrundLabel.Text = "Beendigungsgrund:"
        '
        'KuendigungsfristLabel
        '
        KuendigungsfristLabel.AutoSize = True
        KuendigungsfristLabel.Location = New System.Drawing.Point(322, 31)
        KuendigungsfristLabel.Name = "KuendigungsfristLabel"
        KuendigungsfristLabel.Size = New System.Drawing.Size(117, 16)
        KuendigungsfristLabel.TabIndex = 7
        KuendigungsfristLabel.Text = "Kündigungsfrist:"
        '
        'VerfuegbarkeitLabel
        '
        VerfuegbarkeitLabel.AutoSize = True
        VerfuegbarkeitLabel.Location = New System.Drawing.Point(6, 31)
        VerfuegbarkeitLabel.Name = "VerfuegbarkeitLabel"
        VerfuegbarkeitLabel.Size = New System.Drawing.Size(105, 16)
        VerfuegbarkeitLabel.TabIndex = 6
        VerfuegbarkeitLabel.Text = "Verfügbarkeit:"
        '
        'MdELabel1
        '
        MdELabel1.AutoSize = True
        MdELabel1.Location = New System.Drawing.Point(0, 557)
        MdELabel1.Name = "MdELabel1"
        MdELabel1.Size = New System.Drawing.Size(113, 16)
        MdELabel1.TabIndex = 53
        MdELabel1.Text = "MdE oder GdB:"
        '
        'MdELabel
        '
        MdELabel.AutoSize = True
        MdELabel.Location = New System.Drawing.Point(365, 557)
        MdELabel.Name = "MdELabel"
        MdELabel.Size = New System.Drawing.Size(86, 16)
        MdELabel.TabIndex = 52
        MdELabel.Text = "MdE (in %):"
        '
        'Gehaltswunsch_jahrLabel
        '
        Gehaltswunsch_jahrLabel.AutoSize = True
        Gehaltswunsch_jahrLabel.Location = New System.Drawing.Point(763, 502)
        Gehaltswunsch_jahrLabel.Name = "Gehaltswunsch_jahrLabel"
        Gehaltswunsch_jahrLabel.Size = New System.Drawing.Size(111, 32)
        Gehaltswunsch_jahrLabel.TabIndex = 51
        Gehaltswunsch_jahrLabel.Text = "Gehaltswunsch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jahr:"
        '
        'Gehaltswunsch_monatLabel
        '
        Gehaltswunsch_monatLabel.AutoSize = True
        Gehaltswunsch_monatLabel.Location = New System.Drawing.Point(522, 502)
        Gehaltswunsch_monatLabel.Name = "Gehaltswunsch_monatLabel"
        Gehaltswunsch_monatLabel.Size = New System.Drawing.Size(115, 32)
        Gehaltswunsch_monatLabel.TabIndex = 50
        Gehaltswunsch_monatLabel.Text = "Gehaltswunsch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monat:"
        '
        'JahresgehaltLabel
        '
        JahresgehaltLabel.AutoSize = True
        JahresgehaltLabel.Location = New System.Drawing.Point(260, 502)
        JahresgehaltLabel.Name = "JahresgehaltLabel"
        JahresgehaltLabel.Size = New System.Drawing.Size(102, 32)
        JahresgehaltLabel.TabIndex = 49
        JahresgehaltLabel.Text = "Letztes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jahresgehalt:"
        '
        'MonatsgehaltLabel
        '
        MonatsgehaltLabel.AutoSize = True
        MonatsgehaltLabel.Location = New System.Drawing.Point(6, 502)
        MonatsgehaltLabel.Name = "MonatsgehaltLabel"
        MonatsgehaltLabel.Size = New System.Drawing.Size(105, 32)
        MonatsgehaltLabel.TabIndex = 48
        MonatsgehaltLabel.Text = "Letztes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monatsgehalt:"
        '
        'Pkw_oepnvLabel
        '
        Pkw_oepnvLabel.AutoSize = True
        Pkw_oepnvLabel.Location = New System.Drawing.Point(414, 410)
        Pkw_oepnvLabel.Name = "Pkw_oepnvLabel"
        Pkw_oepnvLabel.Size = New System.Drawing.Size(114, 64)
        Pkw_oepnvLabel.TabIndex = 47
        Pkw_oepnvLabel.Text = "Verkehrsmittel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Arbeitsort" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doppelklick " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Eintragen):"
        '
        'FuehrerscheinLabel
        '
        FuehrerscheinLabel.AutoSize = True
        FuehrerscheinLabel.Location = New System.Drawing.Point(4, 407)
        FuehrerscheinLabel.Name = "FuehrerscheinLabel"
        FuehrerscheinLabel.Size = New System.Drawing.Size(114, 48)
        FuehrerscheinLabel.TabIndex = 46
        FuehrerscheinLabel.Text = "Führerschein" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doppelklick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Eintragen):"
        '
        'UmzugLabel
        '
        UmzugLabel.AutoSize = True
        UmzugLabel.Location = New System.Drawing.Point(453, 316)
        UmzugLabel.Name = "UmzugLabel"
        UmzugLabel.Size = New System.Drawing.Size(148, 16)
        UmzugLabel.TabIndex = 45
        UmzugLabel.Text = "Umzugsbereitschaft:"
        '
        'ArbeitsortLabel
        '
        ArbeitsortLabel.AutoSize = True
        ArbeitsortLabel.Location = New System.Drawing.Point(6, 316)
        ArbeitsortLabel.Name = "ArbeitsortLabel"
        ArbeitsortLabel.Size = New System.Drawing.Size(114, 48)
        ArbeitsortLabel.TabIndex = 44
        ArbeitsortLabel.Text = "Arbeitsort " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doppelklick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Eintragen):"
        '
        'Letzte_beschaeftigungLabel
        '
        Letzte_beschaeftigungLabel.AutoSize = True
        Letzte_beschaeftigungLabel.Location = New System.Drawing.Point(6, 249)
        Letzte_beschaeftigungLabel.Name = "Letzte_beschaeftigungLabel"
        Letzte_beschaeftigungLabel.Size = New System.Drawing.Size(110, 32)
        Letzte_beschaeftigungLabel.TabIndex = 16
        Letzte_beschaeftigungLabel.Text = "Letzte " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beschäftigung:"
        '
        'Teilzeit_wannLabel
        '
        Teilzeit_wannLabel.AutoSize = True
        Teilzeit_wannLabel.Location = New System.Drawing.Point(316, 191)
        Teilzeit_wannLabel.Name = "Teilzeit_wannLabel"
        Teilzeit_wannLabel.Size = New System.Drawing.Size(102, 16)
        Teilzeit_wannLabel.TabIndex = 14
        Teilzeit_wannLabel.Text = "Teilzeit wann:"
        '
        'Teilzeit_stundenLabel
        '
        Teilzeit_stundenLabel.AutoSize = True
        Teilzeit_stundenLabel.Location = New System.Drawing.Point(6, 188)
        Teilzeit_stundenLabel.Name = "Teilzeit_stundenLabel"
        Teilzeit_stundenLabel.Size = New System.Drawing.Size(68, 32)
        Teilzeit_stundenLabel.TabIndex = 12
        Teilzeit_stundenLabel.Text = "Teilzeit " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stunden:"
        '
        'Vz_tzLabel
        '
        Vz_tzLabel.AutoSize = True
        Vz_tzLabel.Location = New System.Drawing.Point(6, 125)
        Vz_tzLabel.Name = "Vz_tzLabel"
        Vz_tzLabel.Size = New System.Drawing.Size(55, 16)
        Vz_tzLabel.TabIndex = 10
        Vz_tzLabel.Text = "VZ/TZ:"
        '
        'Za_vmLabel
        '
        Za_vmLabel.AutoSize = True
        Za_vmLabel.Location = New System.Drawing.Point(316, 113)
        Za_vmLabel.Name = "Za_vmLabel"
        Za_vmLabel.Size = New System.Drawing.Size(101, 48)
        Za_vmLabel.TabIndex = 8
        Za_vmLabel.Text = "ZA/VM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doppelklick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Ändern) :"
        '
        'Stelle_vorschlagen_laut_interviewerLabel
        '
        Stelle_vorschlagen_laut_interviewerLabel.AutoSize = True
        Stelle_vorschlagen_laut_interviewerLabel.Location = New System.Drawing.Point(661, 21)
        Stelle_vorschlagen_laut_interviewerLabel.Name = "Stelle_vorschlagen_laut_interviewerLabel"
        Stelle_vorschlagen_laut_interviewerLabel.Size = New System.Drawing.Size(99, 32)
        Stelle_vorschlagen_laut_interviewerLabel.TabIndex = 4
        Stelle_vorschlagen_laut_interviewerLabel.Text = "Vorschlagen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "für Stelle:"
        '
        'Kunde_vorschlagen_laut_bewerberLabel
        '
        Kunde_vorschlagen_laut_bewerberLabel.AutoSize = True
        Kunde_vorschlagen_laut_bewerberLabel.Location = New System.Drawing.Point(316, 28)
        Kunde_vorschlagen_laut_bewerberLabel.Name = "Kunde_vorschlagen_laut_bewerberLabel"
        Kunde_vorschlagen_laut_bewerberLabel.Size = New System.Drawing.Size(116, 32)
        Kunde_vorschlagen_laut_bewerberLabel.TabIndex = 2
        Kunde_vorschlagen_laut_bewerberLabel.Text = "Bewirbt sich auf" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stelle(n):"
        '
        'JobwunschLabel
        '
        JobwunschLabel.AutoSize = True
        JobwunschLabel.Location = New System.Drawing.Point(6, 31)
        JobwunschLabel.Name = "JobwunschLabel"
        JobwunschLabel.Size = New System.Drawing.Size(88, 16)
        JobwunschLabel.TabIndex = 0
        JobwunschLabel.Text = "Jobwunsch:"
        '
        'StudienfaecherLabel
        '
        StudienfaecherLabel.AutoSize = True
        StudienfaecherLabel.Location = New System.Drawing.Point(502, 157)
        StudienfaecherLabel.Name = "StudienfaecherLabel"
        StudienfaecherLabel.Size = New System.Drawing.Size(114, 17)
        StudienfaecherLabel.TabIndex = 6
        StudienfaecherLabel.Text = "Studienfächer:"
        '
        'Studium_abschlussLabel
        '
        Studium_abschlussLabel.AutoSize = True
        Studium_abschlussLabel.Location = New System.Drawing.Point(6, 160)
        Studium_abschlussLabel.Name = "Studium_abschlussLabel"
        Studium_abschlussLabel.Size = New System.Drawing.Size(144, 51)
        Studium_abschlussLabel.TabIndex = 4
        Studium_abschlussLabel.Text = "Studium Abschluss" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doppelklick zum" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bearbeiten):"
        '
        'Ausbildung_qualifizierungLabel
        '
        Ausbildung_qualifizierungLabel.AutoSize = True
        Ausbildung_qualifizierungLabel.Location = New System.Drawing.Point(502, 34)
        Ausbildung_qualifizierungLabel.Name = "Ausbildung_qualifizierungLabel"
        Ausbildung_qualifizierungLabel.Size = New System.Drawing.Size(199, 17)
        Ausbildung_qualifizierungLabel.TabIndex = 2
        Ausbildung_qualifizierungLabel.Text = "Ausbildung Qualifizierung:"
        '
        'AusbildungsberufLabel
        '
        AusbildungsberufLabel.AutoSize = True
        AusbildungsberufLabel.Location = New System.Drawing.Point(6, 34)
        AusbildungsberufLabel.Name = "AusbildungsberufLabel"
        AusbildungsberufLabel.Size = New System.Drawing.Size(148, 17)
        AusbildungsberufLabel.TabIndex = 0
        AusbildungsberufLabel.Text = "Ausbildungsberufe:"
        '
        'Personalverantwortung_anzahlLabel
        '
        Personalverantwortung_anzahlLabel.AutoSize = True
        Personalverantwortung_anzahlLabel.Location = New System.Drawing.Point(490, 89)
        Personalverantwortung_anzahlLabel.Name = "Personalverantwortung_anzahlLabel"
        Personalverantwortung_anzahlLabel.Size = New System.Drawing.Size(175, 34)
        Personalverantwortung_anzahlLabel.TabIndex = 6
        Personalverantwortung_anzahlLabel.Text = "Personalverantwortung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anzahl:"
        '
        'PersonalverantwortungLabel
        '
        PersonalverantwortungLabel.AutoSize = True
        PersonalverantwortungLabel.Location = New System.Drawing.Point(6, 86)
        PersonalverantwortungLabel.Name = "PersonalverantwortungLabel"
        PersonalverantwortungLabel.Size = New System.Drawing.Size(180, 17)
        PersonalverantwortungLabel.TabIndex = 4
        PersonalverantwortungLabel.Text = "Personalverantwortung:"
        '
        'Fuehrungsverantwortung_dauerLabel
        '
        Fuehrungsverantwortung_dauerLabel.AutoSize = True
        Fuehrungsverantwortung_dauerLabel.Location = New System.Drawing.Point(490, 27)
        Fuehrungsverantwortung_dauerLabel.Name = "Fuehrungsverantwortung_dauerLabel"
        Fuehrungsverantwortung_dauerLabel.Size = New System.Drawing.Size(179, 34)
        Fuehrungsverantwortung_dauerLabel.TabIndex = 2
        Fuehrungsverantwortung_dauerLabel.Text = "Führungsverantwortung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dauer (Jahre):"
        '
        'FuehrungsverantwortungLabel
        '
        FuehrungsverantwortungLabel.AutoSize = True
        FuehrungsverantwortungLabel.Location = New System.Drawing.Point(6, 30)
        FuehrungsverantwortungLabel.Name = "FuehrungsverantwortungLabel"
        FuehrungsverantwortungLabel.Size = New System.Drawing.Size(184, 17)
        FuehrungsverantwortungLabel.TabIndex = 0
        FuehrungsverantwortungLabel.Text = "Führungsverantwortung:"
        '
        'ZeugnistextLabel
        '
        ZeugnistextLabel.AutoSize = True
        ZeugnistextLabel.Location = New System.Drawing.Point(6, 196)
        ZeugnistextLabel.Name = "ZeugnistextLabel"
        ZeugnistextLabel.Size = New System.Drawing.Size(119, 85)
        ZeugnistextLabel.TabIndex = 11
        ZeugnistextLabel.Text = "Bisherige " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tätigkeiten, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "berufliche " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Schwerpunkte, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zeugnistext:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Beruf_schwerpunkttaetigkeitLabel
        '
        Beruf_schwerpunkttaetigkeitLabel.AutoSize = True
        Beruf_schwerpunkttaetigkeitLabel.Location = New System.Drawing.Point(490, 37)
        Beruf_schwerpunkttaetigkeitLabel.Name = "Beruf_schwerpunkttaetigkeitLabel"
        Beruf_schwerpunkttaetigkeitLabel.Size = New System.Drawing.Size(181, 17)
        Beruf_schwerpunkttaetigkeitLabel.TabIndex = 2
        Beruf_schwerpunkttaetigkeitLabel.Text = "Schwerpunkttätigkeiten:"
        '
        'Beruf_positionLabel
        '
        Beruf_positionLabel.AutoSize = True
        Beruf_positionLabel.Location = New System.Drawing.Point(6, 37)
        Beruf_positionLabel.Name = "Beruf_positionLabel"
        Beruf_positionLabel.Size = New System.Drawing.Size(156, 17)
        Beruf_positionLabel.TabIndex = 0
        Beruf_positionLabel.Text = "Frühere Tätigkeiten:"
        '
        'Auslandsaufenthalt_dauerLabel
        '
        Auslandsaufenthalt_dauerLabel.AutoSize = True
        Auslandsaufenthalt_dauerLabel.Location = New System.Drawing.Point(460, 23)
        Auslandsaufenthalt_dauerLabel.Name = "Auslandsaufenthalt_dauerLabel"
        Auslandsaufenthalt_dauerLabel.Size = New System.Drawing.Size(189, 16)
        Auslandsaufenthalt_dauerLabel.TabIndex = 40
        Auslandsaufenthalt_dauerLabel.Text = "Auslandsaufenthalt Dauer:"
        '
        'Auslandsaufenthalt_woLabel
        '
        Auslandsaufenthalt_woLabel.AutoSize = True
        Auslandsaufenthalt_woLabel.Location = New System.Drawing.Point(5, 72)
        Auslandsaufenthalt_woLabel.Name = "Auslandsaufenthalt_woLabel"
        Auslandsaufenthalt_woLabel.Size = New System.Drawing.Size(166, 16)
        Auslandsaufenthalt_woLabel.TabIndex = 38
        Auslandsaufenthalt_woLabel.Text = "Auslandsaufenthalt wo:"
        '
        'AuslandsaufenthaltLabel
        '
        AuslandsaufenthaltLabel.AutoSize = True
        AuslandsaufenthaltLabel.Location = New System.Drawing.Point(5, 18)
        AuslandsaufenthaltLabel.Name = "AuslandsaufenthaltLabel"
        AuslandsaufenthaltLabel.Size = New System.Drawing.Size(143, 16)
        AuslandsaufenthaltLabel.TabIndex = 36
        AuslandsaufenthaltLabel.Text = "Auslandsaufenthalt:"
        '
        'SonstigeLabel
        '
        SonstigeLabel.AutoSize = True
        SonstigeLabel.Location = New System.Drawing.Point(5, 142)
        SonstigeLabel.Name = "SonstigeLabel"
        SonstigeLabel.Size = New System.Drawing.Size(135, 32)
        SonstigeLabel.TabIndex = 42
        SonstigeLabel.Text = "Sonstige" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sprachkenntnisse:"
        '
        'Lotus_notesLabel
        '
        Lotus_notesLabel.AutoSize = True
        Lotus_notesLabel.Location = New System.Drawing.Point(665, 27)
        Lotus_notesLabel.Name = "Lotus_notesLabel"
        Lotus_notesLabel.Size = New System.Drawing.Size(94, 16)
        Lotus_notesLabel.TabIndex = 1
        Lotus_notesLabel.Text = "Lotus Notes:"
        '
        'ThunderbirdLabel
        '
        ThunderbirdLabel.AutoSize = True
        ThunderbirdLabel.Location = New System.Drawing.Point(554, 27)
        ThunderbirdLabel.Name = "ThunderbirdLabel"
        ThunderbirdLabel.Size = New System.Drawing.Size(96, 16)
        ThunderbirdLabel.TabIndex = 12
        ThunderbirdLabel.Text = "Thunderbird:"
        '
        'ProjectLabel
        '
        ProjectLabel.AutoSize = True
        ProjectLabel.Location = New System.Drawing.Point(468, 27)
        ProjectLabel.Name = "ProjectLabel"
        ProjectLabel.Size = New System.Drawing.Size(61, 16)
        ProjectLabel.TabIndex = 10
        ProjectLabel.Text = "Project:"
        '
        'AccessLabel
        '
        AccessLabel.AutoSize = True
        AccessLabel.Location = New System.Drawing.Point(378, 27)
        AccessLabel.Name = "AccessLabel"
        AccessLabel.Size = New System.Drawing.Size(63, 16)
        AccessLabel.TabIndex = 8
        AccessLabel.Text = "Access:"
        '
        'OutlookLabel
        '
        OutlookLabel.AutoSize = True
        OutlookLabel.Location = New System.Drawing.Point(292, 27)
        OutlookLabel.Name = "OutlookLabel"
        OutlookLabel.Size = New System.Drawing.Size(65, 16)
        OutlookLabel.TabIndex = 6
        OutlookLabel.Text = "Outlook:"
        '
        'PowerpointLabel
        '
        PowerpointLabel.AutoSize = True
        PowerpointLabel.Location = New System.Drawing.Point(185, 27)
        PowerpointLabel.Name = "PowerpointLabel"
        PowerpointLabel.Size = New System.Drawing.Size(90, 16)
        PowerpointLabel.TabIndex = 4
        PowerpointLabel.Text = "PowerPoint:"
        '
        'ExcelLabel
        '
        ExcelLabel.AutoSize = True
        ExcelLabel.Location = New System.Drawing.Point(93, 27)
        ExcelLabel.Name = "ExcelLabel"
        ExcelLabel.Size = New System.Drawing.Size(50, 16)
        ExcelLabel.TabIndex = 2
        ExcelLabel.Text = "Excel:"
        '
        'WordLabel
        '
        WordLabel.AutoSize = True
        WordLabel.Location = New System.Drawing.Point(6, 27)
        WordLabel.Name = "WordLabel"
        WordLabel.Size = New System.Drawing.Size(49, 16)
        WordLabel.TabIndex = 0
        WordLabel.Text = "Word:"
        '
        'DeutschLabel1
        '
        DeutschLabel1.AutoSize = True
        DeutschLabel1.Location = New System.Drawing.Point(9, 43)
        DeutschLabel1.Name = "DeutschLabel1"
        DeutschLabel1.Size = New System.Drawing.Size(68, 16)
        DeutschLabel1.TabIndex = 43
        DeutschLabel1.Text = "Deutsch:"
        '
        'EnglischLabel
        '
        EnglischLabel.AutoSize = True
        EnglischLabel.Location = New System.Drawing.Point(162, 43)
        EnglischLabel.Name = "EnglischLabel"
        EnglischLabel.Size = New System.Drawing.Size(71, 16)
        EnglischLabel.TabIndex = 44
        EnglischLabel.Text = "Englisch:"
        '
        'FranzoesischLabel1
        '
        FranzoesischLabel1.AutoSize = True
        FranzoesischLabel1.Location = New System.Drawing.Point(312, 43)
        FranzoesischLabel1.Name = "FranzoesischLabel1"
        FranzoesischLabel1.Size = New System.Drawing.Size(95, 16)
        FranzoesischLabel1.TabIndex = 45
        FranzoesischLabel1.Text = "Französisch:"
        '
        'SpanischLabel1
        '
        SpanischLabel1.AutoSize = True
        SpanischLabel1.Location = New System.Drawing.Point(489, 43)
        SpanischLabel1.Name = "SpanischLabel1"
        SpanischLabel1.Size = New System.Drawing.Size(76, 16)
        SpanischLabel1.TabIndex = 46
        SpanischLabel1.Text = "Spanisch:"
        '
        'ItalienischLabel1
        '
        ItalienischLabel1.AutoSize = True
        ItalienischLabel1.Location = New System.Drawing.Point(652, 43)
        ItalienischLabel1.Name = "ItalienischLabel1"
        ItalienischLabel1.Size = New System.Drawing.Size(82, 16)
        ItalienischLabel1.TabIndex = 47
        ItalienischLabel1.Text = "Italienisch:"
        '
        'TuerkischLabel1
        '
        TuerkischLabel1.AutoSize = True
        TuerkischLabel1.Location = New System.Drawing.Point(815, 43)
        TuerkischLabel1.Name = "TuerkischLabel1"
        TuerkischLabel1.Size = New System.Drawing.Size(71, 16)
        TuerkischLabel1.TabIndex = 48
        TuerkischLabel1.Text = "Türkisch:"
        '
        'RussischLabel1
        '
        RussischLabel1.AutoSize = True
        RussischLabel1.Location = New System.Drawing.Point(5, 98)
        RussischLabel1.Name = "RussischLabel1"
        RussischLabel1.Size = New System.Drawing.Size(75, 16)
        RussischLabel1.TabIndex = 49
        RussischLabel1.Text = "Russisch:"
        '
        'NiederlaendischLabel1
        '
        NiederlaendischLabel1.AutoSize = True
        NiederlaendischLabel1.Location = New System.Drawing.Point(162, 98)
        NiederlaendischLabel1.Name = "NiederlaendischLabel1"
        NiederlaendischLabel1.Size = New System.Drawing.Size(117, 16)
        NiederlaendischLabel1.TabIndex = 50
        NiederlaendischLabel1.Text = "Niederländisch:"
        '
        'Sap_moduleLabel
        '
        Sap_moduleLabel.AutoSize = True
        Sap_moduleLabel.Location = New System.Drawing.Point(8, 97)
        Sap_moduleLabel.Name = "Sap_moduleLabel"
        Sap_moduleLabel.Size = New System.Drawing.Size(98, 16)
        Sap_moduleLabel.TabIndex = 18
        Sap_moduleLabel.Text = "SAP-Module:"
        '
        'OracleLabel
        '
        OracleLabel.AutoSize = True
        OracleLabel.Location = New System.Drawing.Point(753, 26)
        OracleLabel.Name = "OracleLabel"
        OracleLabel.Size = New System.Drawing.Size(58, 16)
        OracleLabel.TabIndex = 16
        OracleLabel.Text = "Oracle:"
        '
        'LexwareLabel
        '
        LexwareLabel.AutoSize = True
        LexwareLabel.Location = New System.Drawing.Point(665, 26)
        LexwareLabel.Name = "LexwareLabel"
        LexwareLabel.Size = New System.Drawing.Size(69, 16)
        LexwareLabel.TabIndex = 14
        LexwareLabel.Text = "Lexware:"
        '
        'KhksageLabel
        '
        KhksageLabel.AutoSize = True
        KhksageLabel.Location = New System.Drawing.Point(572, 26)
        KhksageLabel.Name = "KhksageLabel"
        KhksageLabel.Size = New System.Drawing.Size(78, 16)
        KhksageLabel.TabIndex = 12
        KhksageLabel.Text = "KHKSage:"
        '
        'Microsoft_navisionLabel
        '
        Microsoft_navisionLabel.AutoSize = True
        Microsoft_navisionLabel.Location = New System.Drawing.Point(480, 26)
        Microsoft_navisionLabel.Name = "Microsoft_navisionLabel"
        Microsoft_navisionLabel.Size = New System.Drawing.Size(73, 16)
        Microsoft_navisionLabel.TabIndex = 10
        Microsoft_navisionLabel.Text = "Navision:"
        '
        'Microsoft_dynamicsLabel
        '
        Microsoft_dynamicsLabel.AutoSize = True
        Microsoft_dynamicsLabel.Location = New System.Drawing.Point(381, 26)
        Microsoft_dynamicsLabel.Name = "Microsoft_dynamicsLabel"
        Microsoft_dynamicsLabel.Size = New System.Drawing.Size(80, 16)
        Microsoft_dynamicsLabel.TabIndex = 8
        Microsoft_dynamicsLabel.Text = "Dynamics:"
        '
        'As400Label
        '
        As400Label.AutoSize = True
        As400Label.Location = New System.Drawing.Point(292, 26)
        As400Label.Name = "As400Label"
        As400Label.Size = New System.Drawing.Size(56, 16)
        As400Label.TabIndex = 6
        As400Label.Text = "AS400:"
        '
        'DatevproLabel
        '
        DatevproLabel.AutoSize = True
        DatevproLabel.Location = New System.Drawing.Point(185, 26)
        DatevproLabel.Name = "DatevproLabel"
        DatevproLabel.Size = New System.Drawing.Size(77, 16)
        DatevproLabel.TabIndex = 4
        DatevproLabel.Text = "DatevPro:"
        '
        'DatevLabel
        '
        DatevLabel.AutoSize = True
        DatevLabel.Location = New System.Drawing.Point(93, 26)
        DatevLabel.Name = "DatevLabel"
        DatevLabel.Size = New System.Drawing.Size(53, 16)
        DatevLabel.TabIndex = 2
        DatevLabel.Text = "Datev:"
        '
        'SapLabel
        '
        SapLabel.AutoSize = True
        SapLabel.Location = New System.Drawing.Point(6, 26)
        SapLabel.Name = "SapLabel"
        SapLabel.Size = New System.Drawing.Size(42, 16)
        SapLabel.TabIndex = 0
        SapLabel.Text = "SAP:"
        '
        'Gdb_gradLabel
        '
        Gdb_gradLabel.AutoSize = True
        Gdb_gradLabel.Location = New System.Drawing.Point(636, 557)
        Gdb_gradLabel.Name = "Gdb_gradLabel"
        Gdb_gradLabel.Size = New System.Drawing.Size(85, 16)
        Gdb_gradLabel.TabIndex = 54
        Gdb_gradLabel.Text = "GdB (in %):"
        '
        'Software_sonstigeLabel
        '
        Software_sonstigeLabel.AutoSize = True
        Software_sonstigeLabel.Location = New System.Drawing.Point(410, 94)
        Software_sonstigeLabel.Name = "Software_sonstigeLabel"
        Software_sonstigeLabel.Size = New System.Drawing.Size(146, 32)
        Software_sonstigeLabel.TabIndex = 36
        Software_sonstigeLabel.Text = "Sonstige" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Softwarekenntnisse:"
        '
        'EmpfehlungLabel
        '
        EmpfehlungLabel.AutoSize = True
        EmpfehlungLabel.Location = New System.Drawing.Point(569, 33)
        EmpfehlungLabel.Name = "EmpfehlungLabel"
        EmpfehlungLabel.Size = New System.Drawing.Size(149, 32)
        EmpfehlungLabel.TabIndex = 0
        EmpfehlungLabel.Text = "Heyduck empfohlen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "von:"
        '
        'AufmerksamLabel
        '
        AufmerksamLabel.AutoSize = True
        AufmerksamLabel.Location = New System.Drawing.Point(7, 33)
        AufmerksamLabel.Name = "AufmerksamLabel"
        AufmerksamLabel.Size = New System.Drawing.Size(183, 32)
        AufmerksamLabel.TabIndex = 2
        AufmerksamLabel.Text = "Auf Heyduck aufmerksam" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "geworden durch:"
        '
        'Aufmerksam_andereLabel
        '
        Aufmerksam_andereLabel.AutoSize = True
        Aufmerksam_andereLabel.Location = New System.Drawing.Point(7, 84)
        Aufmerksam_andereLabel.Name = "Aufmerksam_andereLabel"
        Aufmerksam_andereLabel.Size = New System.Drawing.Size(187, 48)
        Aufmerksam_andereLabel.TabIndex = 4
        Aufmerksam_andereLabel.Text = "Auf Heyduck aufmerksam " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "geworden " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "durch anderes:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1075, 729)
        Me.SplitContainer1.SplitterDistance = 158
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.InterviewerComboBox)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(InterviewerLabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1027, 118)
        Me.Panel1.TabIndex = 0
        '
        'InterviewerComboBox
        '
        Me.InterviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "interviewer", True))
        Me.InterviewerComboBox.FormattingEnabled = True
        Me.InterviewerComboBox.Items.AddRange(New Object() {"", "Devilder", "Fürst", "Heyduck", "Mersch"})
        Me.InterviewerComboBox.Location = New System.Drawing.Point(109, 46)
        Me.InterviewerComboBox.Name = "InterviewerComboBox"
        Me.InterviewerComboBox.Size = New System.Drawing.Size(185, 24)
        Me.InterviewerComboBox.TabIndex = 1
        '
        'BewBindingSource
        '
        Me.BewBindingSource.DataMember = "bew"
        Me.BewBindingSource.DataSource = Me.BewerberDataSet
        '
        'BewerberDataSet
        '
        Me.BewerberDataSet.DataSetName = "BewerberDataSet"
        Me.BewerberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(787, 27)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(169, 57)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "       Fenster" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       schließen"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(581, 27)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(169, 57)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "           Angaben" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           speichern"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Telefoninterview"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1055, 551)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1047, 523)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kontaktdaten"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Location = New System.Drawing.Point(4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1006, 420)
        Me.Panel3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.StrasseTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Tel_mobilLabel)
        Me.GroupBox1.Controls.Add(Me.Tel_mobilTextBox)
        Me.GroupBox1.Controls.Add(Tel_festnetzLabel)
        Me.GroupBox1.Controls.Add(Me.Tel_festnetzTextBox)
        Me.GroupBox1.Controls.Add(StrasseLabel)
        Me.GroupBox1.Controls.Add(OrtsteilLabel)
        Me.GroupBox1.Controls.Add(Me.OrtsteilTextBox)
        Me.GroupBox1.Controls.Add(OrtLabel)
        Me.GroupBox1.Controls.Add(Me.OrtTextBox)
        Me.GroupBox1.Controls.Add(PlzLabel)
        Me.GroupBox1.Controls.Add(Me.PlzTextBox)
        Me.GroupBox1.Controls.Add(Alter_jahrLabel)
        Me.GroupBox1.Controls.Add(Me.Alter_jahrTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(VornameLabel)
        Me.GroupBox1.Controls.Add(Me.VornameTextBox)
        Me.GroupBox1.Controls.Add(AnredeLabel)
        Me.GroupBox1.Controls.Add(Me.AnredeComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(988, 190)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bewerber/in"
        '
        'StrasseTextBox
        '
        Me.StrasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "strasse", True))
        Me.StrasseTextBox.Location = New System.Drawing.Point(778, 82)
        Me.StrasseTextBox.Name = "StrasseTextBox"
        Me.StrasseTextBox.Size = New System.Drawing.Size(181, 22)
        Me.StrasseTextBox.TabIndex = 13
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(722, 136)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(237, 22)
        Me.EmailTextBox.TabIndex = 21
        '
        'Tel_mobilTextBox
        '
        Me.Tel_mobilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "tel_mobil", True))
        Me.Tel_mobilTextBox.Location = New System.Drawing.Point(410, 136)
        Me.Tel_mobilTextBox.Name = "Tel_mobilTextBox"
        Me.Tel_mobilTextBox.Size = New System.Drawing.Size(228, 22)
        Me.Tel_mobilTextBox.TabIndex = 19
        '
        'Tel_festnetzTextBox
        '
        Me.Tel_festnetzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "tel_festnetz", True))
        Me.Tel_festnetzTextBox.Location = New System.Drawing.Point(77, 136)
        Me.Tel_festnetzTextBox.Name = "Tel_festnetzTextBox"
        Me.Tel_festnetzTextBox.Size = New System.Drawing.Size(229, 22)
        Me.Tel_festnetzTextBox.TabIndex = 17
        '
        'OrtsteilTextBox
        '
        Me.OrtsteilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "ortsteil", True))
        Me.OrtsteilTextBox.Location = New System.Drawing.Point(492, 82)
        Me.OrtsteilTextBox.Name = "OrtsteilTextBox"
        Me.OrtsteilTextBox.Size = New System.Drawing.Size(189, 22)
        Me.OrtsteilTextBox.TabIndex = 13
        '
        'Bew_bewerberdatenBindingSource
        '
        Me.Bew_bewerberdatenBindingSource.DataMember = "bew_bew_bewerberdaten"
        Me.Bew_bewerberdatenBindingSource.DataSource = Me.BewBindingSource
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(231, 82)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(188, 22)
        Me.OrtTextBox.TabIndex = 11
        '
        'PlzTextBox
        '
        Me.PlzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "plz", True))
        Me.PlzTextBox.Location = New System.Drawing.Point(77, 82)
        Me.PlzTextBox.Name = "PlzTextBox"
        Me.PlzTextBox.Size = New System.Drawing.Size(87, 22)
        Me.PlzTextBox.TabIndex = 9
        '
        'Alter_jahrTextBox
        '
        Me.Alter_jahrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "alter", True))
        Me.Alter_jahrTextBox.Location = New System.Drawing.Point(872, 34)
        Me.Alter_jahrTextBox.Name = "Alter_jahrTextBox"
        Me.Alter_jahrTextBox.Size = New System.Drawing.Size(87, 22)
        Me.Alter_jahrTextBox.TabIndex = 7
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(590, 34)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(189, 22)
        Me.NameTextBox.TabIndex = 5
        '
        'VornameTextBox
        '
        Me.VornameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "vorname", True))
        Me.VornameTextBox.Location = New System.Drawing.Point(310, 34)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.Size = New System.Drawing.Size(166, 22)
        Me.VornameTextBox.TabIndex = 3
        '
        'AnredeComboBox
        '
        Me.AnredeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "anrede", True))
        Me.AnredeComboBox.FormattingEnabled = True
        Me.AnredeComboBox.Items.AddRange(New Object() {"", "Herr", "Frau"})
        Me.AnredeComboBox.Location = New System.Drawing.Point(77, 34)
        Me.AnredeComboBox.Name = "AnredeComboBox"
        Me.AnredeComboBox.Size = New System.Drawing.Size(121, 24)
        Me.AnredeComboBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Aufmerksam_andereLabel)
        Me.GroupBox2.Controls.Add(Me.txtAufmerksam_andere)
        Me.GroupBox2.Controls.Add(AufmerksamLabel)
        Me.GroupBox2.Controls.Add(Me.cmbAufmerksam)
        Me.GroupBox2.Controls.Add(EmpfehlungLabel)
        Me.GroupBox2.Controls.Add(Me.EmpfehlungTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Location = New System.Drawing.Point(6, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(989, 210)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kontakt durch:"
        '
        'txtAufmerksam_andere
        '
        Me.txtAufmerksam_andere.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "aufmerksam_andere", True))
        Me.txtAufmerksam_andere.Location = New System.Drawing.Point(221, 84)
        Me.txtAufmerksam_andere.Multiline = True
        Me.txtAufmerksam_andere.Name = "txtAufmerksam_andere"
        Me.txtAufmerksam_andere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAufmerksam_andere.Size = New System.Drawing.Size(266, 103)
        Me.txtAufmerksam_andere.TabIndex = 5
        '
        'cmbAufmerksam
        '
        Me.cmbAufmerksam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "aufmerksam", True))
        Me.cmbAufmerksam.FormattingEnabled = True
        Me.cmbAufmerksam.Location = New System.Drawing.Point(221, 33)
        Me.cmbAufmerksam.Name = "cmbAufmerksam"
        Me.cmbAufmerksam.Size = New System.Drawing.Size(266, 24)
        Me.cmbAufmerksam.TabIndex = 3
        '
        'EmpfehlungTextBox
        '
        Me.EmpfehlungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "empfehlung", True))
        Me.EmpfehlungTextBox.Location = New System.Drawing.Point(760, 33)
        Me.EmpfehlungTextBox.Multiline = True
        Me.EmpfehlungTextBox.Name = "EmpfehlungTextBox"
        Me.EmpfehlungTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EmpfehlungTextBox.Size = New System.Drawing.Size(200, 52)
        Me.EmpfehlungTextBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1047, 523)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Beschäftigung"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox12)
        Me.Panel4.Controls.Add(Me.GroupBox9)
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Location = New System.Drawing.Point(6, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1006, 1190)
        Me.Panel4.TabIndex = 0
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.Kunden_nicht_vorschlagen_laut_interviewerTextBox)
        Me.GroupBox12.Controls.Add(Me.Stelle_nicht_vorschlagen_laut_interviewerTextBox)
        Me.GroupBox12.Controls.Add(Me.Kunde_vorschlagen_laut_interviewerTextBox)
        Me.GroupBox12.Controls.Add(Me.Stelle_vorschlagen_laut_interviewerTextBox1)
        Me.GroupBox12.Controls.Add(Kunden_nicht_vorschlagen_laut_interviewerLabel)
        Me.GroupBox12.Controls.Add(Stelle_nicht_vorschlagen_laut_interviewerLabel)
        Me.GroupBox12.Controls.Add(Kunde_vorschlagen_laut_interviewerLabel)
        Me.GroupBox12.Controls.Add(Stelle_vorschlagen_laut_interviewerLabel1)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox12.Location = New System.Drawing.Point(3, 943)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(985, 228)
        Me.GroupBox12.TabIndex = 2
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Stellen und Kunden vorschlagen"
        '
        'Kunden_nicht_vorschlagen_laut_interviewerTextBox
        '
        Me.Kunden_nicht_vorschlagen_laut_interviewerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UlasBindingSource, "kunden_nicht_vorschlagen_laut_interviewer", True))
        Me.Kunden_nicht_vorschlagen_laut_interviewerTextBox.Location = New System.Drawing.Point(691, 143)
        Me.Kunden_nicht_vorschlagen_laut_interviewerTextBox.Multiline = True
        Me.Kunden_nicht_vorschlagen_laut_interviewerTextBox.Name = "Kunden_nicht_vorschlagen_laut_interviewerTextBox"
        Me.Kunden_nicht_vorschlagen_laut_interviewerTextBox.Size = New System.Drawing.Size(288, 65)
        Me.Kunden_nicht_vorschlagen_laut_interviewerTextBox.TabIndex = 10
        '
        'UlasBindingSource
        '
        Me.UlasBindingSource.DataMember = "bew_ulas"
        Me.UlasBindingSource.DataSource = Me.BewBindingSource
        '
        'Stelle_nicht_vorschlagen_laut_interviewerTextBox
        '
        Me.Stelle_nicht_vorschlagen_laut_interviewerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UlasBindingSource, "stelle_nicht_vorschlagen_laut_interviewer", True))
        Me.Stelle_nicht_vorschlagen_laut_interviewerTextBox.Location = New System.Drawing.Point(179, 143)
        Me.Stelle_nicht_vorschlagen_laut_interviewerTextBox.Multiline = True
        Me.Stelle_nicht_vorschlagen_laut_interviewerTextBox.Name = "Stelle_nicht_vorschlagen_laut_interviewerTextBox"
        Me.Stelle_nicht_vorschlagen_laut_interviewerTextBox.Size = New System.Drawing.Size(272, 65)
        Me.Stelle_nicht_vorschlagen_laut_interviewerTextBox.TabIndex = 9
        '
        'Kunde_vorschlagen_laut_interviewerTextBox
        '
        Me.Kunde_vorschlagen_laut_interviewerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UlasBindingSource, "kunde_vorschlagen_laut_interviewer", True))
        Me.Kunde_vorschlagen_laut_interviewerTextBox.Location = New System.Drawing.Point(691, 33)
        Me.Kunde_vorschlagen_laut_interviewerTextBox.Multiline = True
        Me.Kunde_vorschlagen_laut_interviewerTextBox.Name = "Kunde_vorschlagen_laut_interviewerTextBox"
        Me.Kunde_vorschlagen_laut_interviewerTextBox.Size = New System.Drawing.Size(288, 75)
        Me.Kunde_vorschlagen_laut_interviewerTextBox.TabIndex = 8
        '
        'Stelle_vorschlagen_laut_interviewerTextBox1
        '
        Me.Stelle_vorschlagen_laut_interviewerTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UlasBindingSource, "stelle_vorschlagen_laut_interviewer", True))
        Me.Stelle_vorschlagen_laut_interviewerTextBox1.Location = New System.Drawing.Point(179, 33)
        Me.Stelle_vorschlagen_laut_interviewerTextBox1.Multiline = True
        Me.Stelle_vorschlagen_laut_interviewerTextBox1.Name = "Stelle_vorschlagen_laut_interviewerTextBox1"
        Me.Stelle_vorschlagen_laut_interviewerTextBox1.Size = New System.Drawing.Size(272, 72)
        Me.Stelle_vorschlagen_laut_interviewerTextBox1.TabIndex = 7
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(WechselwunschLabel)
        Me.GroupBox9.Controls.Add(Me.WechselwunschTextBox)
        Me.GroupBox9.Controls.Add(Beendigungsgrund_detailsLabel)
        Me.GroupBox9.Controls.Add(Me.Beendigungsgrund_detailsTextBox)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(BeendigungsgrundLabel)
        Me.GroupBox9.Controls.Add(Me.BeendigungsgrundComboBox)
        Me.GroupBox9.Controls.Add(KuendigungsfristLabel)
        Me.GroupBox9.Controls.Add(Me.KuendigungsfristComboBox)
        Me.GroupBox9.Controls.Add(VerfuegbarkeitLabel)
        Me.GroupBox9.Controls.Add(Me.VerfuegbarkeitComboBox)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox9.Location = New System.Drawing.Point(3, 595)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(999, 344)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Verfügbarkeit, Kündigung"
        '
        'WechselwunschTextBox
        '
        Me.WechselwunschTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "wechselwunsch", True))
        Me.WechselwunschTextBox.Location = New System.Drawing.Point(639, 78)
        Me.WechselwunschTextBox.Multiline = True
        Me.WechselwunschTextBox.Name = "WechselwunschTextBox"
        Me.WechselwunschTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.WechselwunschTextBox.Size = New System.Drawing.Size(340, 158)
        Me.WechselwunschTextBox.TabIndex = 12
        '
        'Beendigungsgrund_detailsTextBox
        '
        Me.Beendigungsgrund_detailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "beendigungsgrund_details", True))
        Me.Beendigungsgrund_detailsTextBox.Location = New System.Drawing.Point(124, 81)
        Me.Beendigungsgrund_detailsTextBox.Multiline = True
        Me.Beendigungsgrund_detailsTextBox.Name = "Beendigungsgrund_detailsTextBox"
        Me.Beendigungsgrund_detailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Beendigungsgrund_detailsTextBox.Size = New System.Drawing.Size(327, 155)
        Me.Beendigungsgrund_detailsTextBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(6, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(716, 64)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Kündigungs- bzw. Beendigungsdetails bitte unbedingt erfragen und unter möglichst " &
    "detailliert eintragen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Auch eintragen, wenn Bewerber/in darüber keine Auskunf" &
    "t geben will." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'BeendigungsgrundComboBox
        '
        Me.BeendigungsgrundComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "beendigungsgrund", True))
        Me.BeendigungsgrundComboBox.FormattingEnabled = True
        Me.BeendigungsgrundComboBox.Items.AddRange(New Object() {"", "Arbeitgeber", "selbst", "Aufhebungsvertrag", "Zeitablauf", "betriebsbedingt", "Betriebsaufgabe"})
        Me.BeendigungsgrundComboBox.Location = New System.Drawing.Point(800, 28)
        Me.BeendigungsgrundComboBox.Name = "BeendigungsgrundComboBox"
        Me.BeendigungsgrundComboBox.Size = New System.Drawing.Size(179, 24)
        Me.BeendigungsgrundComboBox.TabIndex = 9
        '
        'KuendigungsfristComboBox
        '
        Me.KuendigungsfristComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "kuendigungsfrist", True))
        Me.KuendigungsfristComboBox.Enabled = False
        Me.KuendigungsfristComboBox.FormattingEnabled = True
        Me.KuendigungsfristComboBox.Items.AddRange(New Object() {"", "keine ", "zwei Wochen", "vier Wochen", "zwei Monate", "drei Monate", "vier Monate", "fünf Monate", "sechs Monate", "sieben Monate"})
        Me.KuendigungsfristComboBox.Location = New System.Drawing.Point(459, 28)
        Me.KuendigungsfristComboBox.Name = "KuendigungsfristComboBox"
        Me.KuendigungsfristComboBox.Size = New System.Drawing.Size(174, 24)
        Me.KuendigungsfristComboBox.TabIndex = 8
        '
        'VerfuegbarkeitComboBox
        '
        Me.VerfuegbarkeitComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "verfügbarkeit", True))
        Me.VerfuegbarkeitComboBox.FormattingEnabled = True
        Me.VerfuegbarkeitComboBox.Items.AddRange(New Object() {"", "sofort", "nach Absprache", "nach Kündigung"})
        Me.VerfuegbarkeitComboBox.Location = New System.Drawing.Point(124, 28)
        Me.VerfuegbarkeitComboBox.Name = "VerfuegbarkeitComboBox"
        Me.VerfuegbarkeitComboBox.Size = New System.Drawing.Size(179, 24)
        Me.VerfuegbarkeitComboBox.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Gdb_gradLabel)
        Me.GroupBox4.Controls.Add(Me.Gdb_gradTextBox)
        Me.GroupBox4.Controls.Add(MdELabel1)
        Me.GroupBox4.Controls.Add(Me.MdEComboBox)
        Me.GroupBox4.Controls.Add(MdELabel)
        Me.GroupBox4.Controls.Add(Me.MdETextBox)
        Me.GroupBox4.Controls.Add(Gehaltswunsch_jahrLabel)
        Me.GroupBox4.Controls.Add(Me.Gehaltswunsch_jahrTextBox)
        Me.GroupBox4.Controls.Add(Gehaltswunsch_monatLabel)
        Me.GroupBox4.Controls.Add(Me.Gehaltswunsch_monatTextBox)
        Me.GroupBox4.Controls.Add(JahresgehaltLabel)
        Me.GroupBox4.Controls.Add(Me.JahresgehaltTextBox)
        Me.GroupBox4.Controls.Add(MonatsgehaltLabel)
        Me.GroupBox4.Controls.Add(Me.MonatsgehaltTextBox)
        Me.GroupBox4.Controls.Add(Pkw_oepnvLabel)
        Me.GroupBox4.Controls.Add(Me.Pkw_oepnvTextBox)
        Me.GroupBox4.Controls.Add(FuehrerscheinLabel)
        Me.GroupBox4.Controls.Add(Me.FuehrerscheinTextBox)
        Me.GroupBox4.Controls.Add(UmzugLabel)
        Me.GroupBox4.Controls.Add(Me.UmzugComboBox)
        Me.GroupBox4.Controls.Add(ArbeitsortLabel)
        Me.GroupBox4.Controls.Add(Me.ArbeitsortTextBox)
        Me.GroupBox4.Controls.Add(Letzte_beschaeftigungLabel)
        Me.GroupBox4.Controls.Add(Me.Letzte_beschaeftigungTextBox)
        Me.GroupBox4.Controls.Add(Teilzeit_wannLabel)
        Me.GroupBox4.Controls.Add(Me.Teilzeit_wannComboBox)
        Me.GroupBox4.Controls.Add(Teilzeit_stundenLabel)
        Me.GroupBox4.Controls.Add(Me.Teilzeit_stundenComboBox)
        Me.GroupBox4.Controls.Add(Vz_tzLabel)
        Me.GroupBox4.Controls.Add(Me.Vz_tzComboBox)
        Me.GroupBox4.Controls.Add(Za_vmLabel)
        Me.GroupBox4.Controls.Add(Me.Za_vmTextBox)
        Me.GroupBox4.Controls.Add(Stelle_vorschlagen_laut_interviewerLabel)
        Me.GroupBox4.Controls.Add(Me.Stelle_vorschlagen_laut_interviewerTextBox)
        Me.GroupBox4.Controls.Add(Kunde_vorschlagen_laut_bewerberLabel)
        Me.GroupBox4.Controls.Add(Me.Kunde_vorschlagen_laut_bewerberTextBox)
        Me.GroupBox4.Controls.Add(JobwunschLabel)
        Me.GroupBox4.Controls.Add(Me.JobwunschTextBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1000, 598)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Beschäftigung"
        '
        'Gdb_gradTextBox
        '
        Me.Gdb_gradTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "gdb_grad", True))
        Me.Gdb_gradTextBox.Location = New System.Drawing.Point(727, 554)
        Me.Gdb_gradTextBox.Name = "Gdb_gradTextBox"
        Me.Gdb_gradTextBox.ReadOnly = True
        Me.Gdb_gradTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Gdb_gradTextBox.TabIndex = 55
        '
        'MdEComboBox
        '
        Me.MdEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "MdE", True))
        Me.MdEComboBox.FormattingEnabled = True
        Me.MdEComboBox.Items.AddRange(New Object() {"", "keine Angaben", "Ja", "Nein"})
        Me.MdEComboBox.Location = New System.Drawing.Point(124, 554)
        Me.MdEComboBox.Name = "MdEComboBox"
        Me.MdEComboBox.Size = New System.Drawing.Size(203, 24)
        Me.MdEComboBox.TabIndex = 54
        '
        'MdETextBox
        '
        Me.MdETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "mde_grad", True))
        Me.MdETextBox.Location = New System.Drawing.Point(492, 554)
        Me.MdETextBox.Name = "MdETextBox"
        Me.MdETextBox.ReadOnly = True
        Me.MdETextBox.Size = New System.Drawing.Size(100, 22)
        Me.MdETextBox.TabIndex = 53
        '
        'Gehaltswunsch_jahrTextBox
        '
        Me.Gehaltswunsch_jahrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "gehaltswunsch_jahr", True))
        Me.Gehaltswunsch_jahrTextBox.Location = New System.Drawing.Point(880, 499)
        Me.Gehaltswunsch_jahrTextBox.Name = "Gehaltswunsch_jahrTextBox"
        Me.Gehaltswunsch_jahrTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Gehaltswunsch_jahrTextBox.TabIndex = 52
        '
        'Gehaltswunsch_monatTextBox
        '
        Me.Gehaltswunsch_monatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "gehaltswunsch_monat", True))
        Me.Gehaltswunsch_monatTextBox.Location = New System.Drawing.Point(648, 502)
        Me.Gehaltswunsch_monatTextBox.Name = "Gehaltswunsch_monatTextBox"
        Me.Gehaltswunsch_monatTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Gehaltswunsch_monatTextBox.TabIndex = 51
        '
        'JahresgehaltTextBox
        '
        Me.JahresgehaltTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "jahresgehalt", True))
        Me.JahresgehaltTextBox.Location = New System.Drawing.Point(368, 502)
        Me.JahresgehaltTextBox.Name = "JahresgehaltTextBox"
        Me.JahresgehaltTextBox.Size = New System.Drawing.Size(100, 22)
        Me.JahresgehaltTextBox.TabIndex = 50
        '
        'MonatsgehaltTextBox
        '
        Me.MonatsgehaltTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "monatsgehalt", True))
        Me.MonatsgehaltTextBox.Location = New System.Drawing.Point(124, 502)
        Me.MonatsgehaltTextBox.Name = "MonatsgehaltTextBox"
        Me.MonatsgehaltTextBox.Size = New System.Drawing.Size(107, 22)
        Me.MonatsgehaltTextBox.TabIndex = 49
        '
        'Pkw_oepnvTextBox
        '
        Me.Pkw_oepnvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "pkw_oepnv", True))
        Me.Pkw_oepnvTextBox.Location = New System.Drawing.Point(607, 408)
        Me.Pkw_oepnvTextBox.Multiline = True
        Me.Pkw_oepnvTextBox.Name = "Pkw_oepnvTextBox"
        Me.Pkw_oepnvTextBox.ReadOnly = True
        Me.Pkw_oepnvTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Pkw_oepnvTextBox.Size = New System.Drawing.Size(230, 47)
        Me.Pkw_oepnvTextBox.TabIndex = 48
        '
        'FuehrerscheinTextBox
        '
        Me.FuehrerscheinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "fuehrerschein", True))
        Me.FuehrerscheinTextBox.Location = New System.Drawing.Point(124, 407)
        Me.FuehrerscheinTextBox.Multiline = True
        Me.FuehrerscheinTextBox.Name = "FuehrerscheinTextBox"
        Me.FuehrerscheinTextBox.ReadOnly = True
        Me.FuehrerscheinTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FuehrerscheinTextBox.Size = New System.Drawing.Size(203, 50)
        Me.FuehrerscheinTextBox.TabIndex = 47
        '
        'UmzugComboBox
        '
        Me.UmzugComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "umzug", True))
        Me.UmzugComboBox.FormattingEnabled = True
        Me.UmzugComboBox.Items.AddRange(New Object() {"", "Ja", "Nein", "Vielleicht"})
        Me.UmzugComboBox.Location = New System.Drawing.Point(607, 313)
        Me.UmzugComboBox.Name = "UmzugComboBox"
        Me.UmzugComboBox.Size = New System.Drawing.Size(230, 24)
        Me.UmzugComboBox.TabIndex = 46
        '
        'ArbeitsortTextBox
        '
        Me.ArbeitsortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "arbeitsort", True))
        Me.ArbeitsortTextBox.Location = New System.Drawing.Point(124, 313)
        Me.ArbeitsortTextBox.Multiline = True
        Me.ArbeitsortTextBox.Name = "ArbeitsortTextBox"
        Me.ArbeitsortTextBox.ReadOnly = True
        Me.ArbeitsortTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ArbeitsortTextBox.Size = New System.Drawing.Size(203, 71)
        Me.ArbeitsortTextBox.TabIndex = 45
        '
        'Letzte_beschaeftigungTextBox
        '
        Me.Letzte_beschaeftigungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "letzte_beschaeftigung", True))
        Me.Letzte_beschaeftigungTextBox.Location = New System.Drawing.Point(124, 249)
        Me.Letzte_beschaeftigungTextBox.Name = "Letzte_beschaeftigungTextBox"
        Me.Letzte_beschaeftigungTextBox.Size = New System.Drawing.Size(293, 22)
        Me.Letzte_beschaeftigungTextBox.TabIndex = 17
        '
        'Teilzeit_wannComboBox
        '
        Me.Teilzeit_wannComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "teilzeit_wann", True))
        Me.Teilzeit_wannComboBox.Enabled = False
        Me.Teilzeit_wannComboBox.FormattingEnabled = True
        Me.Teilzeit_wannComboBox.Items.AddRange(New Object() {"", "egal", "Vormittags", "Nachmittags"})
        Me.Teilzeit_wannComboBox.Location = New System.Drawing.Point(438, 188)
        Me.Teilzeit_wannComboBox.Name = "Teilzeit_wannComboBox"
        Me.Teilzeit_wannComboBox.Size = New System.Drawing.Size(203, 24)
        Me.Teilzeit_wannComboBox.TabIndex = 15
        '
        'Teilzeit_stundenComboBox
        '
        Me.Teilzeit_stundenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "teilzeit_stunden", True))
        Me.Teilzeit_stundenComboBox.Enabled = False
        Me.Teilzeit_stundenComboBox.FormattingEnabled = True
        Me.Teilzeit_stundenComboBox.Items.AddRange(New Object() {"", "bis 20 Stunden", "bis 25 Stunden", "bis 30 Stunden", "ab 20 Stunden", "mehr als 20 Stunden", "mehr als 30 Stunden"})
        Me.Teilzeit_stundenComboBox.Location = New System.Drawing.Point(100, 188)
        Me.Teilzeit_stundenComboBox.Name = "Teilzeit_stundenComboBox"
        Me.Teilzeit_stundenComboBox.Size = New System.Drawing.Size(203, 24)
        Me.Teilzeit_stundenComboBox.TabIndex = 13
        '
        'Vz_tzComboBox
        '
        Me.Vz_tzComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "arbeitszeit", True))
        Me.Vz_tzComboBox.FormattingEnabled = True
        Me.Vz_tzComboBox.Items.AddRange(New Object() {"", "Vollzeit", "Teilzeit", "Teilzeit flexibel", "Vollzeit/Teilzeit"})
        Me.Vz_tzComboBox.Location = New System.Drawing.Point(100, 122)
        Me.Vz_tzComboBox.Name = "Vz_tzComboBox"
        Me.Vz_tzComboBox.Size = New System.Drawing.Size(203, 24)
        Me.Vz_tzComboBox.TabIndex = 11
        '
        'Za_vmTextBox
        '
        Me.Za_vmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "Vermittlung", True))
        Me.Za_vmTextBox.Location = New System.Drawing.Point(438, 116)
        Me.Za_vmTextBox.Multiline = True
        Me.Za_vmTextBox.Name = "Za_vmTextBox"
        Me.Za_vmTextBox.ReadOnly = True
        Me.Za_vmTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Za_vmTextBox.Size = New System.Drawing.Size(203, 46)
        Me.Za_vmTextBox.TabIndex = 9
        '
        'Stelle_vorschlagen_laut_interviewerTextBox
        '
        Me.Stelle_vorschlagen_laut_interviewerTextBox.Location = New System.Drawing.Point(766, 25)
        Me.Stelle_vorschlagen_laut_interviewerTextBox.Multiline = True
        Me.Stelle_vorschlagen_laut_interviewerTextBox.Name = "Stelle_vorschlagen_laut_interviewerTextBox"
        Me.Stelle_vorschlagen_laut_interviewerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Stelle_vorschlagen_laut_interviewerTextBox.Size = New System.Drawing.Size(203, 69)
        Me.Stelle_vorschlagen_laut_interviewerTextBox.TabIndex = 5
        '
        'Kunde_vorschlagen_laut_bewerberTextBox
        '
        Me.Kunde_vorschlagen_laut_bewerberTextBox.Location = New System.Drawing.Point(438, 28)
        Me.Kunde_vorschlagen_laut_bewerberTextBox.Multiline = True
        Me.Kunde_vorschlagen_laut_bewerberTextBox.Name = "Kunde_vorschlagen_laut_bewerberTextBox"
        Me.Kunde_vorschlagen_laut_bewerberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Kunde_vorschlagen_laut_bewerberTextBox.Size = New System.Drawing.Size(203, 69)
        Me.Kunde_vorschlagen_laut_bewerberTextBox.TabIndex = 3
        '
        'JobwunschTextBox
        '
        Me.JobwunschTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "jobwunsch", True))
        Me.JobwunschTextBox.Location = New System.Drawing.Point(100, 28)
        Me.JobwunschTextBox.Multiline = True
        Me.JobwunschTextBox.Name = "JobwunschTextBox"
        Me.JobwunschTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.JobwunschTextBox.Size = New System.Drawing.Size(203, 69)
        Me.JobwunschTextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.Panel5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1047, 523)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ausbildung/Studium"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.GroupBox5)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.ForeColor = System.Drawing.Color.Crimson
        Me.Panel5.Location = New System.Drawing.Point(4, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1008, 294)
        Me.Panel5.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(StudienfaecherLabel)
        Me.GroupBox5.Controls.Add(Me.StudienfaecherTextBox)
        Me.GroupBox5.Controls.Add(Studium_abschlussLabel)
        Me.GroupBox5.Controls.Add(Me.Studium_abschlussTextBox)
        Me.GroupBox5.Controls.Add(Ausbildung_qualifizierungLabel)
        Me.GroupBox5.Controls.Add(Me.Ausbildung_qualifizierungTextBox)
        Me.GroupBox5.Controls.Add(AusbildungsberufLabel)
        Me.GroupBox5.Controls.Add(Me.AusbildungsberufTextBox)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(986, 278)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Berufsausbildung/Studium"
        '
        'StudienfaecherTextBox
        '
        Me.StudienfaecherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_ausbildungBindingSource, "studienfaecher", True))
        Me.StudienfaecherTextBox.Location = New System.Drawing.Point(703, 157)
        Me.StudienfaecherTextBox.Multiline = True
        Me.StudienfaecherTextBox.Name = "StudienfaecherTextBox"
        Me.StudienfaecherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StudienfaecherTextBox.Size = New System.Drawing.Size(274, 90)
        Me.StudienfaecherTextBox.TabIndex = 7
        '
        'Bewerber_ausbildungBindingSource
        '
        Me.Bewerber_ausbildungBindingSource.DataMember = "bew_bewerber_ausbildung"
        Me.Bewerber_ausbildungBindingSource.DataSource = Me.BewBindingSource
        '
        'Studium_abschlussTextBox
        '
        Me.Studium_abschlussTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_ausbildungBindingSource, "studium_abschluss", True))
        Me.Studium_abschlussTextBox.Location = New System.Drawing.Point(176, 157)
        Me.Studium_abschlussTextBox.Multiline = True
        Me.Studium_abschlussTextBox.Name = "Studium_abschlussTextBox"
        Me.Studium_abschlussTextBox.ReadOnly = True
        Me.Studium_abschlussTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Studium_abschlussTextBox.Size = New System.Drawing.Size(296, 90)
        Me.Studium_abschlussTextBox.TabIndex = 5
        '
        'Ausbildung_qualifizierungTextBox
        '
        Me.Ausbildung_qualifizierungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_ausbildungBindingSource, "ausbildung_qualifizierung", True))
        Me.Ausbildung_qualifizierungTextBox.Location = New System.Drawing.Point(703, 31)
        Me.Ausbildung_qualifizierungTextBox.Multiline = True
        Me.Ausbildung_qualifizierungTextBox.Name = "Ausbildung_qualifizierungTextBox"
        Me.Ausbildung_qualifizierungTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Ausbildung_qualifizierungTextBox.Size = New System.Drawing.Size(274, 91)
        Me.Ausbildung_qualifizierungTextBox.TabIndex = 3
        '
        'AusbildungsberufTextBox
        '
        Me.AusbildungsberufTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_ausbildungBindingSource, "ausbildungsberuf", True))
        Me.AusbildungsberufTextBox.Location = New System.Drawing.Point(176, 34)
        Me.AusbildungsberufTextBox.Multiline = True
        Me.AusbildungsberufTextBox.Name = "AusbildungsberufTextBox"
        Me.AusbildungsberufTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AusbildungsberufTextBox.Size = New System.Drawing.Size(296, 88)
        Me.AusbildungsberufTextBox.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage4.Controls.Add(Me.Panel6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1047, 523)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Berufserfahrung"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.GroupBox7)
        Me.Panel6.Controls.Add(Me.GroupBox6)
        Me.Panel6.Location = New System.Drawing.Point(4, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1008, 511)
        Me.Panel6.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Personalverantwortung_anzahlLabel)
        Me.GroupBox7.Controls.Add(Me.Personalverantwortung_anzahlTextBox)
        Me.GroupBox7.Controls.Add(PersonalverantwortungLabel)
        Me.GroupBox7.Controls.Add(Me.PersonalverantwortungComboBox)
        Me.GroupBox7.Controls.Add(Fuehrungsverantwortung_dauerLabel)
        Me.GroupBox7.Controls.Add(Me.Fuehrungsverantwortung_dauerTextBox)
        Me.GroupBox7.Controls.Add(FuehrungsverantwortungLabel)
        Me.GroupBox7.Controls.Add(Me.FuehrungsverantwortungComboBox)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox7.Location = New System.Drawing.Point(8, 334)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(984, 163)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Führungserfahrung"
        '
        'Personalverantwortung_anzahlTextBox
        '
        Me.Personalverantwortung_anzahlTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_berufserfahrungBindingSource, "personalverantwortung_anzahl", True))
        Me.Personalverantwortung_anzahlTextBox.Location = New System.Drawing.Point(677, 86)
        Me.Personalverantwortung_anzahlTextBox.Name = "Personalverantwortung_anzahlTextBox"
        Me.Personalverantwortung_anzahlTextBox.Size = New System.Drawing.Size(287, 23)
        Me.Personalverantwortung_anzahlTextBox.TabIndex = 7
        '
        'Bewerber_berufserfahrungBindingSource
        '
        Me.Bewerber_berufserfahrungBindingSource.DataMember = "bew_bewerber_berufserfahrung"
        Me.Bewerber_berufserfahrungBindingSource.DataSource = Me.BewBindingSource
        '
        'PersonalverantwortungComboBox
        '
        Me.PersonalverantwortungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_berufserfahrungBindingSource, "personalverantwortung", True))
        Me.PersonalverantwortungComboBox.FormattingEnabled = True
        Me.PersonalverantwortungComboBox.Items.AddRange(New Object() {"keine Angabe", "Ja", "Nein"})
        Me.PersonalverantwortungComboBox.Location = New System.Drawing.Point(213, 86)
        Me.PersonalverantwortungComboBox.Name = "PersonalverantwortungComboBox"
        Me.PersonalverantwortungComboBox.Size = New System.Drawing.Size(256, 24)
        Me.PersonalverantwortungComboBox.TabIndex = 5
        '
        'Fuehrungsverantwortung_dauerTextBox
        '
        Me.Fuehrungsverantwortung_dauerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_berufserfahrungBindingSource, "fuehrungsverantwortung_dauer", True))
        Me.Fuehrungsverantwortung_dauerTextBox.Location = New System.Drawing.Point(677, 27)
        Me.Fuehrungsverantwortung_dauerTextBox.Name = "Fuehrungsverantwortung_dauerTextBox"
        Me.Fuehrungsverantwortung_dauerTextBox.Size = New System.Drawing.Size(287, 23)
        Me.Fuehrungsverantwortung_dauerTextBox.TabIndex = 3
        '
        'FuehrungsverantwortungComboBox
        '
        Me.FuehrungsverantwortungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_berufserfahrungBindingSource, "fuehrungsverantwortung_dauer", True))
        Me.FuehrungsverantwortungComboBox.FormattingEnabled = True
        Me.FuehrungsverantwortungComboBox.Items.AddRange(New Object() {"keine Angabe", "Ja", "Nein"})
        Me.FuehrungsverantwortungComboBox.Location = New System.Drawing.Point(213, 27)
        Me.FuehrungsverantwortungComboBox.Name = "FuehrungsverantwortungComboBox"
        Me.FuehrungsverantwortungComboBox.Size = New System.Drawing.Size(256, 24)
        Me.FuehrungsverantwortungComboBox.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(ZeugnistextLabel)
        Me.GroupBox6.Controls.Add(Me.ZeugnistextTextBox)
        Me.GroupBox6.Controls.Add(Beruf_schwerpunkttaetigkeitLabel)
        Me.GroupBox6.Controls.Add(Me.Beruf_schwerpunkttaetigkeitTextBox)
        Me.GroupBox6.Controls.Add(Beruf_positionLabel)
        Me.GroupBox6.Controls.Add(Me.Beruf_positionTextBox)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox6.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(984, 325)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Berufserfahrung"
        '
        'ZeugnistextTextBox
        '
        Me.ZeugnistextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "tätigkeiten", True))
        Me.ZeugnistextTextBox.Location = New System.Drawing.Point(168, 193)
        Me.ZeugnistextTextBox.Multiline = True
        Me.ZeugnistextTextBox.Name = "ZeugnistextTextBox"
        Me.ZeugnistextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ZeugnistextTextBox.Size = New System.Drawing.Size(796, 114)
        Me.ZeugnistextTextBox.TabIndex = 10
        '
        'Beruf_schwerpunkttaetigkeitTextBox
        '
        Me.Beruf_schwerpunkttaetigkeitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_berufserfahrungBindingSource, "beruf_schwerpunkttaetigkeit", True))
        Me.Beruf_schwerpunkttaetigkeitTextBox.Location = New System.Drawing.Point(677, 34)
        Me.Beruf_schwerpunkttaetigkeitTextBox.Multiline = True
        Me.Beruf_schwerpunkttaetigkeitTextBox.Name = "Beruf_schwerpunkttaetigkeitTextBox"
        Me.Beruf_schwerpunkttaetigkeitTextBox.ReadOnly = True
        Me.Beruf_schwerpunkttaetigkeitTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Beruf_schwerpunkttaetigkeitTextBox.Size = New System.Drawing.Size(287, 144)
        Me.Beruf_schwerpunkttaetigkeitTextBox.TabIndex = 3
        '
        'Beruf_positionTextBox
        '
        Me.Beruf_positionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_berufserfahrungBindingSource, "beruf_position", True))
        Me.Beruf_positionTextBox.Location = New System.Drawing.Point(168, 34)
        Me.Beruf_positionTextBox.Multiline = True
        Me.Beruf_positionTextBox.Name = "Beruf_positionTextBox"
        Me.Beruf_positionTextBox.ReadOnly = True
        Me.Beruf_positionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Beruf_positionTextBox.Size = New System.Drawing.Size(301, 144)
        Me.Beruf_positionTextBox.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.Panel7)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1047, 523)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Sprachkenntnisse"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.GroupBox13)
        Me.Panel7.Controls.Add(Me.GroupBox8)
        Me.Panel7.Location = New System.Drawing.Point(4, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(991, 409)
        Me.Panel7.TabIndex = 0
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.White
        Me.GroupBox13.Controls.Add(AuslandsaufenthaltLabel)
        Me.GroupBox13.Controls.Add(Me.AuslandsaufenthaltComboBox)
        Me.GroupBox13.Controls.Add(Me.Auslandsaufenthalt_woTextBox)
        Me.GroupBox13.Controls.Add(Auslandsaufenthalt_woLabel)
        Me.GroupBox13.Controls.Add(Me.Auslandsaufenthalt_dauerTextBox)
        Me.GroupBox13.Controls.Add(Auslandsaufenthalt_dauerLabel)
        Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox13.Location = New System.Drawing.Point(8, 252)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(970, 172)
        Me.GroupBox13.TabIndex = 1
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Auslandsaufenthalt"
        '
        'AuslandsaufenthaltComboBox
        '
        Me.AuslandsaufenthaltComboBox.FormattingEnabled = True
        Me.AuslandsaufenthaltComboBox.Items.AddRange(New Object() {"", "Ja", "Nein", "Geplant"})
        Me.AuslandsaufenthaltComboBox.Location = New System.Drawing.Point(176, 15)
        Me.AuslandsaufenthaltComboBox.Name = "AuslandsaufenthaltComboBox"
        Me.AuslandsaufenthaltComboBox.Size = New System.Drawing.Size(231, 24)
        Me.AuslandsaufenthaltComboBox.TabIndex = 37
        '
        'Auslandsaufenthalt_woTextBox
        '
        Me.Auslandsaufenthalt_woTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "auslandsaufenthalt_wo", True))
        Me.Auslandsaufenthalt_woTextBox.Location = New System.Drawing.Point(176, 69)
        Me.Auslandsaufenthalt_woTextBox.Multiline = True
        Me.Auslandsaufenthalt_woTextBox.Name = "Auslandsaufenthalt_woTextBox"
        Me.Auslandsaufenthalt_woTextBox.ReadOnly = True
        Me.Auslandsaufenthalt_woTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Auslandsaufenthalt_woTextBox.Size = New System.Drawing.Size(218, 71)
        Me.Auslandsaufenthalt_woTextBox.TabIndex = 39
        '
        'Bewerber_sprachenBindingSource
        '
        Me.Bewerber_sprachenBindingSource.DataMember = "bew_bewerber_sprachen"
        Me.Bewerber_sprachenBindingSource.DataSource = Me.BewBindingSource
        '
        'Auslandsaufenthalt_dauerTextBox
        '
        Me.Auslandsaufenthalt_dauerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "auslandsaufenthalt_dauer", True))
        Me.Auslandsaufenthalt_dauerTextBox.Location = New System.Drawing.Point(719, 20)
        Me.Auslandsaufenthalt_dauerTextBox.Multiline = True
        Me.Auslandsaufenthalt_dauerTextBox.Name = "Auslandsaufenthalt_dauerTextBox"
        Me.Auslandsaufenthalt_dauerTextBox.ReadOnly = True
        Me.Auslandsaufenthalt_dauerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Auslandsaufenthalt_dauerTextBox.Size = New System.Drawing.Size(207, 71)
        Me.Auslandsaufenthalt_dauerTextBox.TabIndex = 41
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(NiederlaendischLabel1)
        Me.GroupBox8.Controls.Add(Me.NiederlaendischComboBox)
        Me.GroupBox8.Controls.Add(RussischLabel1)
        Me.GroupBox8.Controls.Add(Me.RussischComboBox)
        Me.GroupBox8.Controls.Add(TuerkischLabel1)
        Me.GroupBox8.Controls.Add(Me.TuerkischComboBox)
        Me.GroupBox8.Controls.Add(ItalienischLabel1)
        Me.GroupBox8.Controls.Add(Me.ItalienischComboBox)
        Me.GroupBox8.Controls.Add(SpanischLabel1)
        Me.GroupBox8.Controls.Add(Me.SpanischComboBox)
        Me.GroupBox8.Controls.Add(FranzoesischLabel1)
        Me.GroupBox8.Controls.Add(Me.FranzoesischComboBox)
        Me.GroupBox8.Controls.Add(EnglischLabel)
        Me.GroupBox8.Controls.Add(Me.EnglischComboBox)
        Me.GroupBox8.Controls.Add(DeutschLabel1)
        Me.GroupBox8.Controls.Add(Me.DeutschComboBox)
        Me.GroupBox8.Controls.Add(SonstigeLabel)
        Me.GroupBox8.Controls.Add(Me.SonstigeTextBox)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox8.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(970, 241)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Sprachkenntnisse"
        '
        'NiederlaendischComboBox
        '
        Me.NiederlaendischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "niederlaendisch", True))
        Me.NiederlaendischComboBox.FormattingEnabled = True
        Me.NiederlaendischComboBox.Location = New System.Drawing.Point(285, 95)
        Me.NiederlaendischComboBox.Name = "NiederlaendischComboBox"
        Me.NiederlaendischComboBox.Size = New System.Drawing.Size(58, 24)
        Me.NiederlaendischComboBox.TabIndex = 51
        '
        'RussischComboBox
        '
        Me.RussischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "russisch", True))
        Me.RussischComboBox.FormattingEnabled = True
        Me.RussischComboBox.Location = New System.Drawing.Point(83, 95)
        Me.RussischComboBox.Name = "RussischComboBox"
        Me.RussischComboBox.Size = New System.Drawing.Size(58, 24)
        Me.RussischComboBox.TabIndex = 50
        '
        'TuerkischComboBox
        '
        Me.TuerkischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "tuerkisch", True))
        Me.TuerkischComboBox.FormattingEnabled = True
        Me.TuerkischComboBox.Location = New System.Drawing.Point(892, 40)
        Me.TuerkischComboBox.Name = "TuerkischComboBox"
        Me.TuerkischComboBox.Size = New System.Drawing.Size(58, 24)
        Me.TuerkischComboBox.TabIndex = 49
        '
        'ItalienischComboBox
        '
        Me.ItalienischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "italienisch", True))
        Me.ItalienischComboBox.FormattingEnabled = True
        Me.ItalienischComboBox.Location = New System.Drawing.Point(740, 40)
        Me.ItalienischComboBox.Name = "ItalienischComboBox"
        Me.ItalienischComboBox.Size = New System.Drawing.Size(58, 24)
        Me.ItalienischComboBox.TabIndex = 48
        '
        'SpanischComboBox
        '
        Me.SpanischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "spanisch", True))
        Me.SpanischComboBox.FormattingEnabled = True
        Me.SpanischComboBox.Location = New System.Drawing.Point(571, 40)
        Me.SpanischComboBox.Name = "SpanischComboBox"
        Me.SpanischComboBox.Size = New System.Drawing.Size(58, 24)
        Me.SpanischComboBox.TabIndex = 47
        '
        'FranzoesischComboBox
        '
        Me.FranzoesischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "franzoesisch", True))
        Me.FranzoesischComboBox.FormattingEnabled = True
        Me.FranzoesischComboBox.Location = New System.Drawing.Point(413, 40)
        Me.FranzoesischComboBox.Name = "FranzoesischComboBox"
        Me.FranzoesischComboBox.Size = New System.Drawing.Size(58, 24)
        Me.FranzoesischComboBox.TabIndex = 46
        '
        'EnglischComboBox
        '
        Me.EnglischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "englisch", True))
        Me.EnglischComboBox.FormattingEnabled = True
        Me.EnglischComboBox.Location = New System.Drawing.Point(239, 40)
        Me.EnglischComboBox.Name = "EnglischComboBox"
        Me.EnglischComboBox.Size = New System.Drawing.Size(58, 24)
        Me.EnglischComboBox.TabIndex = 45
        '
        'DeutschComboBox
        '
        Me.DeutschComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "deutsch", True))
        Me.DeutschComboBox.FormattingEnabled = True
        Me.DeutschComboBox.Location = New System.Drawing.Point(83, 40)
        Me.DeutschComboBox.Name = "DeutschComboBox"
        Me.DeutschComboBox.Size = New System.Drawing.Size(58, 24)
        Me.DeutschComboBox.TabIndex = 44
        '
        'SonstigeTextBox
        '
        Me.SonstigeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "sonstige", True))
        Me.SonstigeTextBox.Location = New System.Drawing.Point(177, 139)
        Me.SonstigeTextBox.Multiline = True
        Me.SonstigeTextBox.Name = "SonstigeTextBox"
        Me.SonstigeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SonstigeTextBox.Size = New System.Drawing.Size(269, 82)
        Me.SonstigeTextBox.TabIndex = 43
        '
        'TabPage8
        '
        Me.TabPage8.AutoScroll = True
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage8.Controls.Add(Me.Panel10)
        Me.TabPage8.Location = New System.Drawing.Point(4, 24)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(1047, 523)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "EDV"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.GroupBox29)
        Me.Panel10.Controls.Add(Me.GroupBox3)
        Me.Panel10.Controls.Add(Me.Label14)
        Me.Panel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(4, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(991, 353)
        Me.Panel10.TabIndex = 0
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Software_sonstigeLabel)
        Me.GroupBox29.Controls.Add(Me.Software_sonstigeTextBox)
        Me.GroupBox29.Controls.Add(Me.PictureBox20)
        Me.GroupBox29.Controls.Add(Sap_moduleLabel)
        Me.GroupBox29.Controls.Add(Me.Sap_moduleTextBox)
        Me.GroupBox29.Controls.Add(Me.OracleComboBox)
        Me.GroupBox29.Controls.Add(Me.LexwareComboBox)
        Me.GroupBox29.Controls.Add(Me.KhksageComboBox)
        Me.GroupBox29.Controls.Add(Me.Microsoft_navisionComboBox)
        Me.GroupBox29.Controls.Add(Me.Microsoft_dynamicsComboBox)
        Me.GroupBox29.Controls.Add(Me.As400ComboBox)
        Me.GroupBox29.Controls.Add(Me.DatevComboBox)
        Me.GroupBox29.Controls.Add(Me.DatevproComboBox)
        Me.GroupBox29.Controls.Add(Me.SapComboBox)
        Me.GroupBox29.Controls.Add(OracleLabel)
        Me.GroupBox29.Controls.Add(LexwareLabel)
        Me.GroupBox29.Controls.Add(KhksageLabel)
        Me.GroupBox29.Controls.Add(Microsoft_navisionLabel)
        Me.GroupBox29.Controls.Add(Microsoft_dynamicsLabel)
        Me.GroupBox29.Controls.Add(As400Label)
        Me.GroupBox29.Controls.Add(DatevproLabel)
        Me.GroupBox29.Controls.Add(DatevLabel)
        Me.GroupBox29.Controls.Add(SapLabel)
        Me.GroupBox29.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox29.Location = New System.Drawing.Point(10, 142)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(968, 200)
        Me.GroupBox29.TabIndex = 4
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "ERP, CRM"
        '
        'Software_sonstigeTextBox
        '
        Me.Software_sonstigeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_edvBindingSource, "software_sonstige", True))
        Me.Software_sonstigeTextBox.Location = New System.Drawing.Point(575, 94)
        Me.Software_sonstigeTextBox.Multiline = True
        Me.Software_sonstigeTextBox.Name = "Software_sonstigeTextBox"
        Me.Software_sonstigeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Software_sonstigeTextBox.Size = New System.Drawing.Size(241, 89)
        Me.Software_sonstigeTextBox.TabIndex = 37
        '
        'Bewerber_edvBindingSource
        '
        Me.Bewerber_edvBindingSource.DataMember = "bew_bewerber_edv"
        Me.Bewerber_edvBindingSource.DataSource = Me.BewBindingSource
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = CType(resources.GetObject("PictureBox20.Image"), System.Drawing.Image)
        Me.PictureBox20.Location = New System.Drawing.Point(11, 122)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox20.TabIndex = 36
        Me.PictureBox20.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox20, "Doppelklick zum Eintragen oder Ändern")
        '
        'Sap_moduleTextBox
        '
        Me.Sap_moduleTextBox.Location = New System.Drawing.Point(121, 94)
        Me.Sap_moduleTextBox.Multiline = True
        Me.Sap_moduleTextBox.Name = "Sap_moduleTextBox"
        Me.Sap_moduleTextBox.ReadOnly = True
        Me.Sap_moduleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Sap_moduleTextBox.Size = New System.Drawing.Size(236, 89)
        Me.Sap_moduleTextBox.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.Sap_moduleTextBox, "Doppelklicken, um Feld auszufüllen")
        '
        'OracleComboBox
        '
        Me.OracleComboBox.FormattingEnabled = True
        Me.OracleComboBox.Location = New System.Drawing.Point(756, 45)
        Me.OracleComboBox.Name = "OracleComboBox"
        Me.OracleComboBox.Size = New System.Drawing.Size(60, 24)
        Me.OracleComboBox.TabIndex = 9
        '
        'LexwareComboBox
        '
        Me.LexwareComboBox.FormattingEnabled = True
        Me.LexwareComboBox.Location = New System.Drawing.Point(668, 45)
        Me.LexwareComboBox.Name = "LexwareComboBox"
        Me.LexwareComboBox.Size = New System.Drawing.Size(60, 24)
        Me.LexwareComboBox.TabIndex = 8
        '
        'KhksageComboBox
        '
        Me.KhksageComboBox.FormattingEnabled = True
        Me.KhksageComboBox.Location = New System.Drawing.Point(575, 45)
        Me.KhksageComboBox.Name = "KhksageComboBox"
        Me.KhksageComboBox.Size = New System.Drawing.Size(60, 24)
        Me.KhksageComboBox.TabIndex = 7
        '
        'Microsoft_navisionComboBox
        '
        Me.Microsoft_navisionComboBox.FormattingEnabled = True
        Me.Microsoft_navisionComboBox.Location = New System.Drawing.Point(483, 45)
        Me.Microsoft_navisionComboBox.Name = "Microsoft_navisionComboBox"
        Me.Microsoft_navisionComboBox.Size = New System.Drawing.Size(60, 24)
        Me.Microsoft_navisionComboBox.TabIndex = 6
        '
        'Microsoft_dynamicsComboBox
        '
        Me.Microsoft_dynamicsComboBox.FormattingEnabled = True
        Me.Microsoft_dynamicsComboBox.Location = New System.Drawing.Point(384, 45)
        Me.Microsoft_dynamicsComboBox.Name = "Microsoft_dynamicsComboBox"
        Me.Microsoft_dynamicsComboBox.Size = New System.Drawing.Size(60, 24)
        Me.Microsoft_dynamicsComboBox.TabIndex = 5
        '
        'As400ComboBox
        '
        Me.As400ComboBox.FormattingEnabled = True
        Me.As400ComboBox.Location = New System.Drawing.Point(295, 45)
        Me.As400ComboBox.Name = "As400ComboBox"
        Me.As400ComboBox.Size = New System.Drawing.Size(60, 24)
        Me.As400ComboBox.TabIndex = 4
        '
        'DatevComboBox
        '
        Me.DatevComboBox.FormattingEnabled = True
        Me.DatevComboBox.Location = New System.Drawing.Point(96, 45)
        Me.DatevComboBox.Name = "DatevComboBox"
        Me.DatevComboBox.Size = New System.Drawing.Size(60, 24)
        Me.DatevComboBox.TabIndex = 2
        '
        'DatevproComboBox
        '
        Me.DatevproComboBox.FormattingEnabled = True
        Me.DatevproComboBox.Location = New System.Drawing.Point(188, 45)
        Me.DatevproComboBox.Name = "DatevproComboBox"
        Me.DatevproComboBox.Size = New System.Drawing.Size(60, 24)
        Me.DatevproComboBox.TabIndex = 3
        '
        'SapComboBox
        '
        Me.SapComboBox.FormattingEnabled = True
        Me.SapComboBox.Location = New System.Drawing.Point(9, 45)
        Me.SapComboBox.Name = "SapComboBox"
        Me.SapComboBox.Size = New System.Drawing.Size(60, 24)
        Me.SapComboBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Lotus_notesLabel)
        Me.GroupBox3.Controls.Add(ThunderbirdLabel)
        Me.GroupBox3.Controls.Add(Me.Lotus_notesComboBox)
        Me.GroupBox3.Controls.Add(Me.ThunderbirdComboBox)
        Me.GroupBox3.Controls.Add(Me.WordComboBox)
        Me.GroupBox3.Controls.Add(Me.ProjectComboBox)
        Me.GroupBox3.Controls.Add(Me.AccessComboBox)
        Me.GroupBox3.Controls.Add(Me.OutlookComboBox)
        Me.GroupBox3.Controls.Add(Me.PowerpointComboBox)
        Me.GroupBox3.Controls.Add(Me.ExcelComboBox)
        Me.GroupBox3.Controls.Add(ProjectLabel)
        Me.GroupBox3.Controls.Add(AccessLabel)
        Me.GroupBox3.Controls.Add(OutlookLabel)
        Me.GroupBox3.Controls.Add(PowerpointLabel)
        Me.GroupBox3.Controls.Add(ExcelLabel)
        Me.GroupBox3.Controls.Add(WordLabel)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox3.Location = New System.Drawing.Point(10, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(968, 96)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Officeprogramme"
        '
        'Lotus_notesComboBox
        '
        Me.Lotus_notesComboBox.FormattingEnabled = True
        Me.Lotus_notesComboBox.Location = New System.Drawing.Point(668, 49)
        Me.Lotus_notesComboBox.Name = "Lotus_notesComboBox"
        Me.Lotus_notesComboBox.Size = New System.Drawing.Size(60, 24)
        Me.Lotus_notesComboBox.TabIndex = 8
        '
        'ThunderbirdComboBox
        '
        Me.ThunderbirdComboBox.FormattingEnabled = True
        Me.ThunderbirdComboBox.Location = New System.Drawing.Point(557, 46)
        Me.ThunderbirdComboBox.Name = "ThunderbirdComboBox"
        Me.ThunderbirdComboBox.Size = New System.Drawing.Size(60, 24)
        Me.ThunderbirdComboBox.TabIndex = 7
        '
        'WordComboBox
        '
        Me.WordComboBox.FormattingEnabled = True
        Me.WordComboBox.Location = New System.Drawing.Point(11, 47)
        Me.WordComboBox.Name = "WordComboBox"
        Me.WordComboBox.Size = New System.Drawing.Size(58, 24)
        Me.WordComboBox.TabIndex = 1
        '
        'ProjectComboBox
        '
        Me.ProjectComboBox.FormattingEnabled = True
        Me.ProjectComboBox.Location = New System.Drawing.Point(471, 46)
        Me.ProjectComboBox.Name = "ProjectComboBox"
        Me.ProjectComboBox.Size = New System.Drawing.Size(60, 24)
        Me.ProjectComboBox.TabIndex = 6
        '
        'AccessComboBox
        '
        Me.AccessComboBox.FormattingEnabled = True
        Me.AccessComboBox.Location = New System.Drawing.Point(381, 46)
        Me.AccessComboBox.Name = "AccessComboBox"
        Me.AccessComboBox.Size = New System.Drawing.Size(60, 24)
        Me.AccessComboBox.TabIndex = 5
        '
        'OutlookComboBox
        '
        Me.OutlookComboBox.FormattingEnabled = True
        Me.OutlookComboBox.Location = New System.Drawing.Point(295, 46)
        Me.OutlookComboBox.Name = "OutlookComboBox"
        Me.OutlookComboBox.Size = New System.Drawing.Size(60, 24)
        Me.OutlookComboBox.TabIndex = 4
        '
        'PowerpointComboBox
        '
        Me.PowerpointComboBox.FormattingEnabled = True
        Me.PowerpointComboBox.Location = New System.Drawing.Point(188, 46)
        Me.PowerpointComboBox.Name = "PowerpointComboBox"
        Me.PowerpointComboBox.Size = New System.Drawing.Size(60, 24)
        Me.PowerpointComboBox.TabIndex = 3
        '
        'ExcelComboBox
        '
        Me.ExcelComboBox.FormattingEnabled = True
        Me.ExcelComboBox.Location = New System.Drawing.Point(96, 46)
        Me.ExcelComboBox.Name = "ExcelComboBox"
        Me.ExcelComboBox.Size = New System.Drawing.Size(58, 24)
        Me.ExcelComboBox.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Crimson
        Me.Label14.Location = New System.Drawing.Point(3, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "EDV-Kenntnisse"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Panel8)
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1047, 523)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Persönlichkeit etc."
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.Controls.Add(Me.GroupBox10)
        Me.Panel8.Location = New System.Drawing.Point(4, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1017, 521)
        Me.Panel8.TabIndex = 0
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.RTEPersoenlichkeit)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox10.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1005, 502)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Persönlichkeit etc."
        '
        'RTEPersoenlichkeit
        '
        Me.RTEPersoenlichkeit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RTEPersoenlichkeit.Location = New System.Drawing.Point(7, 21)
        Me.RTEPersoenlichkeit.Name = "RTEPersoenlichkeit"
        Me.RTEPersoenlichkeit.SelectionFill = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RTEPersoenlichkeit.Size = New System.Drawing.Size(992, 464)
        Me.RTEPersoenlichkeit.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Panel9)
        Me.TabPage7.Location = New System.Drawing.Point(4, 24)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1047, 523)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Ulas"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.GroupBox11)
        Me.Panel9.Location = New System.Drawing.Point(4, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1017, 498)
        Me.Panel9.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.White
        Me.GroupBox11.Controls.Add(Me.PictureBox1)
        Me.GroupBox11.Controls.Add(Me.UlasListBox)
        Me.GroupBox11.Controls.Add(Me.Label9)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox11.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(1005, 470)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Ulas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(563, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'UlasListBox
        '
        Me.UlasListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BewBindingSource, "ulas", True))
        Me.UlasListBox.FormattingEnabled = True
        Me.UlasListBox.ItemHeight = 16
        Me.UlasListBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "10", "11", "14"})
        Me.UlasListBox.Location = New System.Drawing.Point(726, 35)
        Me.UlasListBox.Name = "UlasListBox"
        Me.UlasListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.UlasListBox.Size = New System.Drawing.Size(119, 180)
        Me.UlasListBox.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(541, 410)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Location = New System.Drawing.Point(8, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1014, 417)
        Me.Panel2.TabIndex = 0
        '
        'BewTableAdapter
        '
        Me.BewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bew_assistenzTableAdapter = Nothing
        Me.TableAdapterManager.bew_bewerberdatenTableAdapter = Me.Bew_bewerberdatenTableAdapter
        Me.TableAdapterManager.bew_bibuhaTableAdapter = Nothing
        Me.TableAdapterManager.bew_lugTableAdapter = Nothing
        Me.TableAdapterManager.bew_steuerfachangestellteTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_ausbildungTableAdapter = Me.Bewerber_ausbildungTableAdapter
        Me.TableAdapterManager.bewerber_berufserfahrungTableAdapter = Me.Bewerber_berufserfahrungTableAdapter
        Me.TableAdapterManager.bewerber_bueroTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_controllingTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_edvTableAdapter = Me.Bewerber_edvTableAdapter
        Me.TableAdapterManager.bewerber_einkaufTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_fibuTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_itTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_logistikTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_marketing_designTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_personalTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_raeTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_sprachenTableAdapter = Me.Bewerber_sprachenTableAdapter
        Me.TableAdapterManager.bewerber_technikTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_versandTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_vertriebTableAdapter = Nothing
        Me.TableAdapterManager.bewTableAdapter = Me.BewTableAdapter
        Me.TableAdapterManager.gewerblichTableAdapter = Nothing
        Me.TableAdapterManager.notizenTableAdapter = Nothing
        Me.TableAdapterManager.rundschreibenmonatTableAdapter = Nothing
        Me.TableAdapterManager.rundschreibenTableAdapter = Nothing
        Me.TableAdapterManager.ulasTableAdapter = Me.UlasTableAdapter
        Me.TableAdapterManager.UpdateOrder = bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Bew_bewerberdatenTableAdapter
        '
        Me.Bew_bewerberdatenTableAdapter.ClearBeforeFill = True
        '
        'Bewerber_ausbildungTableAdapter
        '
        Me.Bewerber_ausbildungTableAdapter.ClearBeforeFill = True
        '
        'Bewerber_berufserfahrungTableAdapter
        '
        Me.Bewerber_berufserfahrungTableAdapter.ClearBeforeFill = True
        '
        'Bewerber_edvTableAdapter
        '
        Me.Bewerber_edvTableAdapter.ClearBeforeFill = True
        '
        'Bewerber_sprachenTableAdapter
        '
        Me.Bewerber_sprachenTableAdapter.ClearBeforeFill = True
        '
        'UlasTableAdapter
        '
        Me.UlasTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmTelefoninterview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1075, 729)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTelefoninterview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Telefoninterview"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Bew_bewerberdatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.UlasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Bewerber_ausbildungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Bewerber_berufserfahrungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.Bewerber_sprachenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox29.PerformLayout()
        CType(Me.Bewerber_edvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.RTEPersoenlichkeit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberDataSet As bewerberpool.BewerberDataSet
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BewTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter
    Friend WithEvents TableAdapterManager As bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Bew_bewerberdatenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bew_bewerberdatenTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bew_bewerberdatenTableAdapter
    Friend WithEvents InterviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StrasseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_mobilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_festnetzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrtsteilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Alter_jahrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VornameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnredeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Kunden_nicht_vorschlagen_laut_interviewerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stelle_nicht_vorschlagen_laut_interviewerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kunde_vorschlagen_laut_interviewerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stelle_vorschlagen_laut_interviewerTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents WechselwunschTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Beendigungsgrund_detailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BeendigungsgrundComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KuendigungsfristComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VerfuegbarkeitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents MdEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MdETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gehaltswunsch_jahrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gehaltswunsch_monatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JahresgehaltTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonatsgehaltTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pkw_oepnvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FuehrerscheinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UmzugComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ArbeitsortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Letzte_beschaeftigungTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Teilzeit_wannComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Teilzeit_stundenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vz_tzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Za_vmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stelle_vorschlagen_laut_interviewerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kunde_vorschlagen_laut_bewerberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobwunschTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents StudienfaecherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Studium_abschlussTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ausbildung_qualifizierungTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AusbildungsberufTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Personalverantwortung_anzahlTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PersonalverantwortungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fuehrungsverantwortung_dauerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FuehrungsverantwortungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ZeugnistextTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Beruf_schwerpunkttaetigkeitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Beruf_positionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Auslandsaufenthalt_dauerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Auslandsaufenthalt_woTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuslandsaufenthaltComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents RTEPersoenlichkeit As Telerik.WinControls.UI.RadRichTextEditor
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UlasListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UlasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UlasTableAdapter As bewerberpool.BewerberDataSetTableAdapters.ulasTableAdapter
    Friend WithEvents Bewerber_ausbildungBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_ausbildungTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewerber_ausbildungTableAdapter
    Friend WithEvents Bewerber_berufserfahrungBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_berufserfahrungTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewerber_berufserfahrungTableAdapter
    Friend WithEvents Bewerber_sprachenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_sprachenTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewerber_sprachenTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents SonstigeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Lotus_notesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ThunderbirdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WordComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccessComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OutlookComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PowerpointComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExcelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EnglischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeutschComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FranzoesischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NiederlaendischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RussischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TuerkischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ItalienischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpanischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox29 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents Sap_moduleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OracleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LexwareComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KhksageComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Microsoft_navisionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Microsoft_dynamicsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents As400ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DatevComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DatevproComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SapComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Gdb_gradTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bewerber_edvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_edvTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewerber_edvTableAdapter
    Friend WithEvents Software_sonstigeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAufmerksam As ComboBox
    Friend WithEvents EmpfehlungTextBox As TextBox
    Friend WithEvents txtAufmerksam_andere As TextBox
End Class
