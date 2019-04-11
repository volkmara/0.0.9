<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInterviewer
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim InterviewerLabel As System.Windows.Forms.Label
        Dim EmpfehlungLabel As System.Windows.Forms.Label
        Dim BeurteilungLabel As System.Windows.Forms.Label
        Dim ParfumLabel As System.Windows.Forms.Label
        Dim RaucherLabel As System.Windows.Forms.Label
        Dim JobwunschLabel As System.Windows.Forms.Label
        Dim VerfuegbarkeitLabel As System.Windows.Forms.Label
        Dim Za_vmLabel As System.Windows.Forms.Label
        Dim Vz_tzLabel As System.Windows.Forms.Label
        Dim Teilzeit_stundenLabel As System.Windows.Forms.Label
        Dim Teilzeit_wannLabel As System.Windows.Forms.Label
        Dim ArbeitsortLabel As System.Windows.Forms.Label
        Dim UmzugLabel As System.Windows.Forms.Label
        Dim FuehrerscheinLabel As System.Windows.Forms.Label
        Dim Pkw_oepnvLabel As System.Windows.Forms.Label
        Dim MonatsgehaltLabel As System.Windows.Forms.Label
        Dim JahresgehaltLabel As System.Windows.Forms.Label
        Dim Gehaltswunsch_monatLabel As System.Windows.Forms.Label
        Dim Gehaltswunsch_jahrLabel As System.Windows.Forms.Label
        Dim AusbildungsberufLabel As System.Windows.Forms.Label
        Dim Ausbildung_qualifizierungLabel As System.Windows.Forms.Label
        Dim Studium_abschlussLabel As System.Windows.Forms.Label
        Dim StudienfaecherLabel As System.Windows.Forms.Label
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Alter_jahrLabel As System.Windows.Forms.Label
        Dim PlzLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim OrtsteilLabel As System.Windows.Forms.Label
        Dim StrasseLabel As System.Windows.Forms.Label
        Dim Tel_festnetzLabel As System.Windows.Forms.Label
        Dim Tel_mobilLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Beruf_positionLabel As System.Windows.Forms.Label
        Dim Beruf_schwerpunkttaetigkeitLabel As System.Windows.Forms.Label
        Dim FuehrungsverantwortungLabel As System.Windows.Forms.Label
        Dim Fuehrungsverantwortung_dauerLabel As System.Windows.Forms.Label
        Dim PersonalverantwortungLabel As System.Windows.Forms.Label
        Dim Personalverantwortung_anzahlLabel As System.Windows.Forms.Label
        Dim Muendlich_schriftlichLabel As System.Windows.Forms.Label
        Dim EnglischLabel As System.Windows.Forms.Label
        Dim Englisch_interviewerLabel As System.Windows.Forms.Label
        Dim FranzoesischLabel As System.Windows.Forms.Label
        Dim Französich_interviewerLabel As System.Windows.Forms.Label
        Dim SpanischLabel As System.Windows.Forms.Label
        Dim Spanisch_interviewerLabel As System.Windows.Forms.Label
        Dim ItalienischLabel As System.Windows.Forms.Label
        Dim Italienisch_interviewerLabel As System.Windows.Forms.Label
        Dim TuerkischLabel As System.Windows.Forms.Label
        Dim Tuerkisch_interviewerLabel As System.Windows.Forms.Label
        Dim RussischLabel As System.Windows.Forms.Label
        Dim Russisch_interviewerLabel As System.Windows.Forms.Label
        Dim NiederlaendischLabel As System.Windows.Forms.Label
        Dim Niederlaendisch_interviewerLabel As System.Windows.Forms.Label
        Dim DeutschLabel As System.Windows.Forms.Label
        Dim Deutsch_interviewerLabel As System.Windows.Forms.Label
        Dim AuslandsaufenthaltLabel As System.Windows.Forms.Label
        Dim Auslandsaufenthalt_woLabel As System.Windows.Forms.Label
        Dim Auslandsaufenthalt_dauerLabel As System.Windows.Forms.Label
        Dim KuendigungsfristLabel As System.Windows.Forms.Label
        Dim BeendigungsgrundLabel As System.Windows.Forms.Label
        Dim MdELabel As System.Windows.Forms.Label
        Dim MdELabel1 As System.Windows.Forms.Label
        Dim Beendigungsgrund_detailsLabel As System.Windows.Forms.Label
        Dim WechselwunschLabel As System.Windows.Forms.Label
        Dim HaendedruckLabel As System.Windows.Forms.Label
        Dim Gdb_gradLabel As System.Windows.Forms.Label
        Dim TaetigkeitenLabel As System.Windows.Forms.Label
        Dim AufmerksamLabel As System.Windows.Forms.Label
        Dim Aufmerksam_andereLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInterviewer))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InterviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RaucherComboBox = New System.Windows.Forms.ComboBox()
        Me.Bew_bewerberdatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParfumComboBox = New System.Windows.Forms.ComboBox()
        Me.HaendedruckComboBox = New System.Windows.Forms.ComboBox()
        Me.BeurteilungComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StrasseTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_mobilTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_festnetzTextBox = New System.Windows.Forms.TextBox()
        Me.OrtsteilTextBox = New System.Windows.Forms.TextBox()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.txtFuerstelle = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.WechselwunschTextBox = New System.Windows.Forms.TextBox()
        Me.Beendigungsgrund_detailsTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BeendigungsgrundComboBox = New System.Windows.Forms.ComboBox()
        Me.KuendigungsfristComboBox = New System.Windows.Forms.ComboBox()
        Me.VerfuegbarkeitComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.JahresgehaltTextBox = New System.Windows.Forms.TextBox()
        Me.MonatsgehaltTextBox = New System.Windows.Forms.TextBox()
        Me.Gdb_gradTextBox = New System.Windows.Forms.TextBox()
        Me.MdEComboBox = New System.Windows.Forms.ComboBox()
        Me.MdETextBox = New System.Windows.Forms.TextBox()
        Me.Gehaltswunsch_jahrTextBox = New System.Windows.Forms.TextBox()
        Me.Gehaltswunsch_monatTextBox = New System.Windows.Forms.TextBox()
        Me.Pkw_oepnvTextBox = New System.Windows.Forms.TextBox()
        Me.FuehrerscheinTextBox = New System.Windows.Forms.TextBox()
        Me.UmzugComboBox = New System.Windows.Forms.ComboBox()
        Me.ArbeitsortTextBox = New System.Windows.Forms.TextBox()
        Me.Teilzeit_wannComboBox = New System.Windows.Forms.ComboBox()
        Me.Teilzeit_stundenComboBox = New System.Windows.Forms.ComboBox()
        Me.Vz_tzComboBox = New System.Windows.Forms.ComboBox()
        Me.Za_vmTextBox = New System.Windows.Forms.TextBox()
        Me.JobwunschTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.StudienfaecherTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_ausbildungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Studium_abschlussTextBox = New System.Windows.Forms.TextBox()
        Me.Ausbildung_qualifizierungTextBox = New System.Windows.Forms.TextBox()
        Me.AusbildungsberufTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Personalverantwortung_anzahlTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_berufserfahrungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalverantwortungComboBox = New System.Windows.Forms.ComboBox()
        Me.Fuehrungsverantwortung_dauerTextBox = New System.Windows.Forms.TextBox()
        Me.FuehrungsverantwortungComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TaetigkeitenTextBox = New System.Windows.Forms.TextBox()
        Me.Beruf_schwerpunkttaetigkeitTextBox = New System.Windows.Forms.TextBox()
        Me.Beruf_positionTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Auslandsaufenthalt_dauerTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_sprachenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Auslandsaufenthalt_woTextBox = New System.Windows.Forms.TextBox()
        Me.AuslandsaufenthaltComboBox = New System.Windows.Forms.ComboBox()
        Me.Deutsch_interviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.DeutschTextBox = New System.Windows.Forms.TextBox()
        Me.Niederlaendisch_interviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.NiederlaendischTextBox = New System.Windows.Forms.TextBox()
        Me.Russisch_interviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.RussischTextBox = New System.Windows.Forms.TextBox()
        Me.Tuerkisch_interviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.TuerkischTextBox = New System.Windows.Forms.TextBox()
        Me.Italienisch_interviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.ItalienischTextBox = New System.Windows.Forms.TextBox()
        Me.Spanisch_interviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.SpanischTextBox = New System.Windows.Forms.TextBox()
        Me.Französich_interviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.FranzoesischTextBox = New System.Windows.Forms.TextBox()
        Me.Englisch_interviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EnglischTextBox = New System.Windows.Forms.TextBox()
        Me.Muendlich_schriftlichComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.RTEPersoenlichkeit = New Telerik.WinControls.UI.RadRichTextEditor()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UlasTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UlasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.Bew_bewerberdatenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bew_bewerberdatenTableAdapter()
        Me.Bewerber_ausbildungTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewerber_ausbildungTableAdapter()
        Me.Bewerber_berufserfahrungTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewerber_berufserfahrungTableAdapter()
        Me.Bewerber_sprachenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewerber_sprachenTableAdapter()
        Me.UlasTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.ulasTableAdapter()
        Me.TableAdapterManager = New bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager()
        InterviewerLabel = New System.Windows.Forms.Label()
        EmpfehlungLabel = New System.Windows.Forms.Label()
        BeurteilungLabel = New System.Windows.Forms.Label()
        ParfumLabel = New System.Windows.Forms.Label()
        RaucherLabel = New System.Windows.Forms.Label()
        JobwunschLabel = New System.Windows.Forms.Label()
        VerfuegbarkeitLabel = New System.Windows.Forms.Label()
        Za_vmLabel = New System.Windows.Forms.Label()
        Vz_tzLabel = New System.Windows.Forms.Label()
        Teilzeit_stundenLabel = New System.Windows.Forms.Label()
        Teilzeit_wannLabel = New System.Windows.Forms.Label()
        ArbeitsortLabel = New System.Windows.Forms.Label()
        UmzugLabel = New System.Windows.Forms.Label()
        FuehrerscheinLabel = New System.Windows.Forms.Label()
        Pkw_oepnvLabel = New System.Windows.Forms.Label()
        MonatsgehaltLabel = New System.Windows.Forms.Label()
        JahresgehaltLabel = New System.Windows.Forms.Label()
        Gehaltswunsch_monatLabel = New System.Windows.Forms.Label()
        Gehaltswunsch_jahrLabel = New System.Windows.Forms.Label()
        AusbildungsberufLabel = New System.Windows.Forms.Label()
        Ausbildung_qualifizierungLabel = New System.Windows.Forms.Label()
        Studium_abschlussLabel = New System.Windows.Forms.Label()
        StudienfaecherLabel = New System.Windows.Forms.Label()
        AnredeLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Alter_jahrLabel = New System.Windows.Forms.Label()
        PlzLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        OrtsteilLabel = New System.Windows.Forms.Label()
        StrasseLabel = New System.Windows.Forms.Label()
        Tel_festnetzLabel = New System.Windows.Forms.Label()
        Tel_mobilLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Beruf_positionLabel = New System.Windows.Forms.Label()
        Beruf_schwerpunkttaetigkeitLabel = New System.Windows.Forms.Label()
        FuehrungsverantwortungLabel = New System.Windows.Forms.Label()
        Fuehrungsverantwortung_dauerLabel = New System.Windows.Forms.Label()
        PersonalverantwortungLabel = New System.Windows.Forms.Label()
        Personalverantwortung_anzahlLabel = New System.Windows.Forms.Label()
        Muendlich_schriftlichLabel = New System.Windows.Forms.Label()
        EnglischLabel = New System.Windows.Forms.Label()
        Englisch_interviewerLabel = New System.Windows.Forms.Label()
        FranzoesischLabel = New System.Windows.Forms.Label()
        Französich_interviewerLabel = New System.Windows.Forms.Label()
        SpanischLabel = New System.Windows.Forms.Label()
        Spanisch_interviewerLabel = New System.Windows.Forms.Label()
        ItalienischLabel = New System.Windows.Forms.Label()
        Italienisch_interviewerLabel = New System.Windows.Forms.Label()
        TuerkischLabel = New System.Windows.Forms.Label()
        Tuerkisch_interviewerLabel = New System.Windows.Forms.Label()
        RussischLabel = New System.Windows.Forms.Label()
        Russisch_interviewerLabel = New System.Windows.Forms.Label()
        NiederlaendischLabel = New System.Windows.Forms.Label()
        Niederlaendisch_interviewerLabel = New System.Windows.Forms.Label()
        DeutschLabel = New System.Windows.Forms.Label()
        Deutsch_interviewerLabel = New System.Windows.Forms.Label()
        AuslandsaufenthaltLabel = New System.Windows.Forms.Label()
        Auslandsaufenthalt_woLabel = New System.Windows.Forms.Label()
        Auslandsaufenthalt_dauerLabel = New System.Windows.Forms.Label()
        KuendigungsfristLabel = New System.Windows.Forms.Label()
        BeendigungsgrundLabel = New System.Windows.Forms.Label()
        MdELabel = New System.Windows.Forms.Label()
        MdELabel1 = New System.Windows.Forms.Label()
        Beendigungsgrund_detailsLabel = New System.Windows.Forms.Label()
        WechselwunschLabel = New System.Windows.Forms.Label()
        HaendedruckLabel = New System.Windows.Forms.Label()
        Gdb_gradLabel = New System.Windows.Forms.Label()
        TaetigkeitenLabel = New System.Windows.Forms.Label()
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
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Bew_bewerberdatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Bewerber_ausbildungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Bewerber_berufserfahrungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.Bewerber_sprachenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.RTEPersoenlichkeit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UlasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InterviewerLabel
        '
        InterviewerLabel.AutoSize = True
        InterviewerLabel.Location = New System.Drawing.Point(767, 43)
        InterviewerLabel.Name = "InterviewerLabel"
        InterviewerLabel.Size = New System.Drawing.Size(92, 17)
        InterviewerLabel.TabIndex = 3
        InterviewerLabel.Text = "Interviewer:"
        '
        'EmpfehlungLabel
        '
        EmpfehlungLabel.AutoSize = True
        EmpfehlungLabel.Location = New System.Drawing.Point(624, 32)
        EmpfehlungLabel.Name = "EmpfehlungLabel"
        EmpfehlungLabel.Size = New System.Drawing.Size(149, 32)
        EmpfehlungLabel.TabIndex = 0
        EmpfehlungLabel.Text = "Heyduck empfohlen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "von:"
        '
        'BeurteilungLabel
        '
        BeurteilungLabel.AutoSize = True
        BeurteilungLabel.Location = New System.Drawing.Point(14, 44)
        BeurteilungLabel.Name = "BeurteilungLabel"
        BeurteilungLabel.Size = New System.Drawing.Size(90, 16)
        BeurteilungLabel.TabIndex = 0
        BeurteilungLabel.Text = "Beurteilung:"
        '
        'ParfumLabel
        '
        ParfumLabel.AutoSize = True
        ParfumLabel.Location = New System.Drawing.Point(498, 44)
        ParfumLabel.Name = "ParfumLabel"
        ParfumLabel.Size = New System.Drawing.Size(60, 16)
        ParfumLabel.TabIndex = 4
        ParfumLabel.Text = "Parfüm:"
        '
        'RaucherLabel
        '
        RaucherLabel.AutoSize = True
        RaucherLabel.Location = New System.Drawing.Point(735, 44)
        RaucherLabel.Name = "RaucherLabel"
        RaucherLabel.Size = New System.Drawing.Size(70, 16)
        RaucherLabel.TabIndex = 6
        RaucherLabel.Text = "Raucher:"
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
        'VerfuegbarkeitLabel
        '
        VerfuegbarkeitLabel.AutoSize = True
        VerfuegbarkeitLabel.Location = New System.Drawing.Point(6, 31)
        VerfuegbarkeitLabel.Name = "VerfuegbarkeitLabel"
        VerfuegbarkeitLabel.Size = New System.Drawing.Size(105, 16)
        VerfuegbarkeitLabel.TabIndex = 6
        VerfuegbarkeitLabel.Text = "Verfügbarkeit:"
        '
        'Za_vmLabel
        '
        Za_vmLabel.AutoSize = True
        Za_vmLabel.Location = New System.Drawing.Point(465, 31)
        Za_vmLabel.Name = "Za_vmLabel"
        Za_vmLabel.Size = New System.Drawing.Size(101, 48)
        Za_vmLabel.TabIndex = 8
        Za_vmLabel.Text = "ZA/VM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doppelklick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Ändern) :"
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
        'Teilzeit_stundenLabel
        '
        Teilzeit_stundenLabel.AutoSize = True
        Teilzeit_stundenLabel.Location = New System.Drawing.Point(6, 174)
        Teilzeit_stundenLabel.Name = "Teilzeit_stundenLabel"
        Teilzeit_stundenLabel.Size = New System.Drawing.Size(68, 32)
        Teilzeit_stundenLabel.TabIndex = 12
        Teilzeit_stundenLabel.Text = "Teilzeit " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stunden:"
        '
        'Teilzeit_wannLabel
        '
        Teilzeit_wannLabel.AutoSize = True
        Teilzeit_wannLabel.Location = New System.Drawing.Point(456, 125)
        Teilzeit_wannLabel.Name = "Teilzeit_wannLabel"
        Teilzeit_wannLabel.Size = New System.Drawing.Size(102, 16)
        Teilzeit_wannLabel.TabIndex = 14
        Teilzeit_wannLabel.Text = "Teilzeit wann:"
        '
        'ArbeitsortLabel
        '
        ArbeitsortLabel.AutoSize = True
        ArbeitsortLabel.Location = New System.Drawing.Point(6, 235)
        ArbeitsortLabel.Name = "ArbeitsortLabel"
        ArbeitsortLabel.Size = New System.Drawing.Size(114, 48)
        ArbeitsortLabel.TabIndex = 44
        ArbeitsortLabel.Text = "Arbeitsort " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doppelklick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Eintragen):"
        '
        'UmzugLabel
        '
        UmzugLabel.AutoSize = True
        UmzugLabel.Location = New System.Drawing.Point(456, 185)
        UmzugLabel.Name = "UmzugLabel"
        UmzugLabel.Size = New System.Drawing.Size(148, 16)
        UmzugLabel.TabIndex = 45
        UmzugLabel.Text = "Umzugsbereitschaft:"
        '
        'FuehrerscheinLabel
        '
        FuehrerscheinLabel.AutoSize = True
        FuehrerscheinLabel.Location = New System.Drawing.Point(4, 330)
        FuehrerscheinLabel.Name = "FuehrerscheinLabel"
        FuehrerscheinLabel.Size = New System.Drawing.Size(114, 48)
        FuehrerscheinLabel.TabIndex = 46
        FuehrerscheinLabel.Text = "Führerschein" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doppelklick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Eintragen):"
        '
        'Pkw_oepnvLabel
        '
        Pkw_oepnvLabel.AutoSize = True
        Pkw_oepnvLabel.Location = New System.Drawing.Point(456, 235)
        Pkw_oepnvLabel.Name = "Pkw_oepnvLabel"
        Pkw_oepnvLabel.Size = New System.Drawing.Size(114, 64)
        Pkw_oepnvLabel.TabIndex = 47
        Pkw_oepnvLabel.Text = "Verkehrsmittel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Arbeitsort" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Doppelklick " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Eintragen):"
        '
        'MonatsgehaltLabel
        '
        MonatsgehaltLabel.AutoSize = True
        MonatsgehaltLabel.Location = New System.Drawing.Point(6, 413)
        MonatsgehaltLabel.Name = "MonatsgehaltLabel"
        MonatsgehaltLabel.Size = New System.Drawing.Size(105, 32)
        MonatsgehaltLabel.TabIndex = 48
        MonatsgehaltLabel.Text = "Letztes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monatsgehalt:"
        '
        'JahresgehaltLabel
        '
        JahresgehaltLabel.AutoSize = True
        JahresgehaltLabel.Location = New System.Drawing.Point(260, 413)
        JahresgehaltLabel.Name = "JahresgehaltLabel"
        JahresgehaltLabel.Size = New System.Drawing.Size(102, 32)
        JahresgehaltLabel.TabIndex = 49
        JahresgehaltLabel.Text = "Letztes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jahresgehalt:"
        '
        'Gehaltswunsch_monatLabel
        '
        Gehaltswunsch_monatLabel.AutoSize = True
        Gehaltswunsch_monatLabel.Location = New System.Drawing.Point(522, 413)
        Gehaltswunsch_monatLabel.Name = "Gehaltswunsch_monatLabel"
        Gehaltswunsch_monatLabel.Size = New System.Drawing.Size(115, 32)
        Gehaltswunsch_monatLabel.TabIndex = 50
        Gehaltswunsch_monatLabel.Text = "Gehaltswunsch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monat:"
        '
        'Gehaltswunsch_jahrLabel
        '
        Gehaltswunsch_jahrLabel.AutoSize = True
        Gehaltswunsch_jahrLabel.Location = New System.Drawing.Point(763, 413)
        Gehaltswunsch_jahrLabel.Name = "Gehaltswunsch_jahrLabel"
        Gehaltswunsch_jahrLabel.Size = New System.Drawing.Size(111, 32)
        Gehaltswunsch_jahrLabel.TabIndex = 51
        Gehaltswunsch_jahrLabel.Text = "Gehaltswunsch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jahr:"
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
        'Ausbildung_qualifizierungLabel
        '
        Ausbildung_qualifizierungLabel.AutoSize = True
        Ausbildung_qualifizierungLabel.Location = New System.Drawing.Point(502, 34)
        Ausbildung_qualifizierungLabel.Name = "Ausbildung_qualifizierungLabel"
        Ausbildung_qualifizierungLabel.Size = New System.Drawing.Size(199, 17)
        Ausbildung_qualifizierungLabel.TabIndex = 2
        Ausbildung_qualifizierungLabel.Text = "Ausbildung Qualifizierung:"
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
        'StudienfaecherLabel
        '
        StudienfaecherLabel.AutoSize = True
        StudienfaecherLabel.Location = New System.Drawing.Point(502, 157)
        StudienfaecherLabel.Name = "StudienfaecherLabel"
        StudienfaecherLabel.Size = New System.Drawing.Size(114, 17)
        StudienfaecherLabel.TabIndex = 6
        StudienfaecherLabel.Text = "Studienfächer:"
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
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(232, 37)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(74, 16)
        VornameLabel.TabIndex = 2
        VornameLabel.Text = "Vorname:"
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
        'Alter_jahrLabel
        '
        Alter_jahrLabel.AutoSize = True
        Alter_jahrLabel.Location = New System.Drawing.Point(822, 37)
        Alter_jahrLabel.Name = "Alter_jahrLabel"
        Alter_jahrLabel.Size = New System.Drawing.Size(44, 16)
        Alter_jahrLabel.TabIndex = 6
        Alter_jahrLabel.Text = "Alter:"
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
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(193, 85)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(32, 16)
        OrtLabel.TabIndex = 10
        OrtLabel.Text = "Ort:"
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
        'StrasseLabel
        '
        StrasseLabel.AutoSize = True
        StrasseLabel.Location = New System.Drawing.Point(707, 85)
        StrasseLabel.Name = "StrasseLabel"
        StrasseLabel.Size = New System.Drawing.Size(65, 16)
        StrasseLabel.TabIndex = 14
        StrasseLabel.Text = "Strasse:"
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
        'Tel_mobilLabel
        '
        Tel_mobilLabel.AutoSize = True
        Tel_mobilLabel.Location = New System.Drawing.Point(347, 139)
        Tel_mobilLabel.Name = "Tel_mobilLabel"
        Tel_mobilLabel.Size = New System.Drawing.Size(57, 16)
        Tel_mobilLabel.TabIndex = 18
        Tel_mobilLabel.Text = "Handy:"
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
        'Beruf_positionLabel
        '
        Beruf_positionLabel.AutoSize = True
        Beruf_positionLabel.Location = New System.Drawing.Point(6, 37)
        Beruf_positionLabel.Name = "Beruf_positionLabel"
        Beruf_positionLabel.Size = New System.Drawing.Size(151, 34)
        Beruf_positionLabel.TabIndex = 0
        Beruf_positionLabel.Text = "Frühere Tätigkeiten" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "laut Bewerber:"
        '
        'Beruf_schwerpunkttaetigkeitLabel
        '
        Beruf_schwerpunkttaetigkeitLabel.AutoSize = True
        Beruf_schwerpunkttaetigkeitLabel.Location = New System.Drawing.Point(490, 37)
        Beruf_schwerpunkttaetigkeitLabel.Name = "Beruf_schwerpunkttaetigkeitLabel"
        Beruf_schwerpunkttaetigkeitLabel.Size = New System.Drawing.Size(176, 34)
        Beruf_schwerpunkttaetigkeitLabel.TabIndex = 2
        Beruf_schwerpunkttaetigkeitLabel.Text = "Schwerpunkttätigkeiten" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "laut Bewerber:"
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
        'Fuehrungsverantwortung_dauerLabel
        '
        Fuehrungsverantwortung_dauerLabel.AutoSize = True
        Fuehrungsverantwortung_dauerLabel.Location = New System.Drawing.Point(490, 27)
        Fuehrungsverantwortung_dauerLabel.Name = "Fuehrungsverantwortung_dauerLabel"
        Fuehrungsverantwortung_dauerLabel.Size = New System.Drawing.Size(179, 34)
        Fuehrungsverantwortung_dauerLabel.TabIndex = 2
        Fuehrungsverantwortung_dauerLabel.Text = "Führungsverantwortung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dauer (Jahre):"
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
        'Personalverantwortung_anzahlLabel
        '
        Personalverantwortung_anzahlLabel.AutoSize = True
        Personalverantwortung_anzahlLabel.Location = New System.Drawing.Point(490, 89)
        Personalverantwortung_anzahlLabel.Name = "Personalverantwortung_anzahlLabel"
        Personalverantwortung_anzahlLabel.Size = New System.Drawing.Size(175, 34)
        Personalverantwortung_anzahlLabel.TabIndex = 6
        Personalverantwortung_anzahlLabel.Text = "Personalverantwortung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anzahl:"
        '
        'Muendlich_schriftlichLabel
        '
        Muendlich_schriftlichLabel.AutoSize = True
        Muendlich_schriftlichLabel.Location = New System.Drawing.Point(6, 27)
        Muendlich_schriftlichLabel.Name = "Muendlich_schriftlichLabel"
        Muendlich_schriftlichLabel.Size = New System.Drawing.Size(208, 16)
        Muendlich_schriftlichLabel.TabIndex = 0
        Muendlich_schriftlichLabel.Text = "Mündlich und/oder schriftlich:"
        '
        'EnglischLabel
        '
        EnglischLabel.AutoSize = True
        EnglischLabel.Location = New System.Drawing.Point(6, 97)
        EnglischLabel.Name = "EnglischLabel"
        EnglischLabel.Size = New System.Drawing.Size(71, 16)
        EnglischLabel.TabIndex = 2
        EnglischLabel.Text = "Englisch:"
        '
        'Englisch_interviewerLabel
        '
        Englisch_interviewerLabel.AutoSize = True
        Englisch_interviewerLabel.Location = New System.Drawing.Point(439, 97)
        Englisch_interviewerLabel.Name = "Englisch_interviewerLabel"
        Englisch_interviewerLabel.Size = New System.Drawing.Size(179, 16)
        Englisch_interviewerLabel.TabIndex = 6
        Englisch_interviewerLabel.Text = "Englisch laut Interviewer:"
        '
        'FranzoesischLabel
        '
        FranzoesischLabel.AutoSize = True
        FranzoesischLabel.Location = New System.Drawing.Point(6, 141)
        FranzoesischLabel.Name = "FranzoesischLabel"
        FranzoesischLabel.Size = New System.Drawing.Size(95, 16)
        FranzoesischLabel.TabIndex = 8
        FranzoesischLabel.Text = "Französisch:"
        '
        'Französich_interviewerLabel
        '
        Französich_interviewerLabel.AutoSize = True
        Französich_interviewerLabel.Location = New System.Drawing.Point(439, 141)
        Französich_interviewerLabel.Name = "Französich_interviewerLabel"
        Französich_interviewerLabel.Size = New System.Drawing.Size(203, 16)
        Französich_interviewerLabel.TabIndex = 10
        Französich_interviewerLabel.Text = "Französisch laut Interviewer:"
        '
        'SpanischLabel
        '
        SpanischLabel.AutoSize = True
        SpanischLabel.Location = New System.Drawing.Point(9, 179)
        SpanischLabel.Name = "SpanischLabel"
        SpanischLabel.Size = New System.Drawing.Size(76, 16)
        SpanischLabel.TabIndex = 12
        SpanischLabel.Text = "Spanisch:"
        '
        'Spanisch_interviewerLabel
        '
        Spanisch_interviewerLabel.AutoSize = True
        Spanisch_interviewerLabel.Location = New System.Drawing.Point(439, 179)
        Spanisch_interviewerLabel.Name = "Spanisch_interviewerLabel"
        Spanisch_interviewerLabel.Size = New System.Drawing.Size(184, 16)
        Spanisch_interviewerLabel.TabIndex = 14
        Spanisch_interviewerLabel.Text = "Spanisch laut Interviewer:"
        '
        'ItalienischLabel
        '
        ItalienischLabel.AutoSize = True
        ItalienischLabel.Location = New System.Drawing.Point(9, 221)
        ItalienischLabel.Name = "ItalienischLabel"
        ItalienischLabel.Size = New System.Drawing.Size(82, 16)
        ItalienischLabel.TabIndex = 16
        ItalienischLabel.Text = "Italienisch:"
        '
        'Italienisch_interviewerLabel
        '
        Italienisch_interviewerLabel.AutoSize = True
        Italienisch_interviewerLabel.Location = New System.Drawing.Point(439, 221)
        Italienisch_interviewerLabel.Name = "Italienisch_interviewerLabel"
        Italienisch_interviewerLabel.Size = New System.Drawing.Size(190, 16)
        Italienisch_interviewerLabel.TabIndex = 18
        Italienisch_interviewerLabel.Text = "Italienisch laut Interviewer:"
        '
        'TuerkischLabel
        '
        TuerkischLabel.AutoSize = True
        TuerkischLabel.Location = New System.Drawing.Point(9, 261)
        TuerkischLabel.Name = "TuerkischLabel"
        TuerkischLabel.Size = New System.Drawing.Size(71, 16)
        TuerkischLabel.TabIndex = 20
        TuerkischLabel.Text = "Türkisch:"
        '
        'Tuerkisch_interviewerLabel
        '
        Tuerkisch_interviewerLabel.AutoSize = True
        Tuerkisch_interviewerLabel.Location = New System.Drawing.Point(439, 261)
        Tuerkisch_interviewerLabel.Name = "Tuerkisch_interviewerLabel"
        Tuerkisch_interviewerLabel.Size = New System.Drawing.Size(179, 16)
        Tuerkisch_interviewerLabel.TabIndex = 22
        Tuerkisch_interviewerLabel.Text = "Türkisch laut Interviewer:"
        '
        'RussischLabel
        '
        RussischLabel.AutoSize = True
        RussischLabel.Location = New System.Drawing.Point(9, 303)
        RussischLabel.Name = "RussischLabel"
        RussischLabel.Size = New System.Drawing.Size(75, 16)
        RussischLabel.TabIndex = 24
        RussischLabel.Text = "Russisch:"
        '
        'Russisch_interviewerLabel
        '
        Russisch_interviewerLabel.AutoSize = True
        Russisch_interviewerLabel.Location = New System.Drawing.Point(439, 303)
        Russisch_interviewerLabel.Name = "Russisch_interviewerLabel"
        Russisch_interviewerLabel.Size = New System.Drawing.Size(183, 16)
        Russisch_interviewerLabel.TabIndex = 26
        Russisch_interviewerLabel.Text = "Russisch laut Interviewer:"
        '
        'NiederlaendischLabel
        '
        NiederlaendischLabel.AutoSize = True
        NiederlaendischLabel.Location = New System.Drawing.Point(9, 351)
        NiederlaendischLabel.Name = "NiederlaendischLabel"
        NiederlaendischLabel.Size = New System.Drawing.Size(117, 16)
        NiederlaendischLabel.TabIndex = 28
        NiederlaendischLabel.Text = "Niederländisch:"
        '
        'Niederlaendisch_interviewerLabel
        '
        Niederlaendisch_interviewerLabel.AutoSize = True
        Niederlaendisch_interviewerLabel.Location = New System.Drawing.Point(440, 351)
        Niederlaendisch_interviewerLabel.Name = "Niederlaendisch_interviewerLabel"
        Niederlaendisch_interviewerLabel.Size = New System.Drawing.Size(225, 16)
        Niederlaendisch_interviewerLabel.TabIndex = 30
        Niederlaendisch_interviewerLabel.Text = "Niederländisch laut Interviewer:"
        '
        'DeutschLabel
        '
        DeutschLabel.AutoSize = True
        DeutschLabel.Location = New System.Drawing.Point(9, 394)
        DeutschLabel.Name = "DeutschLabel"
        DeutschLabel.Size = New System.Drawing.Size(68, 16)
        DeutschLabel.TabIndex = 32
        DeutschLabel.Text = "Deutsch:"
        '
        'Deutsch_interviewerLabel
        '
        Deutsch_interviewerLabel.AutoSize = True
        Deutsch_interviewerLabel.Location = New System.Drawing.Point(440, 394)
        Deutsch_interviewerLabel.Name = "Deutsch_interviewerLabel"
        Deutsch_interviewerLabel.Size = New System.Drawing.Size(176, 16)
        Deutsch_interviewerLabel.TabIndex = 34
        Deutsch_interviewerLabel.Text = "Deutsch laut Interviewer:"
        '
        'AuslandsaufenthaltLabel
        '
        AuslandsaufenthaltLabel.AutoSize = True
        AuslandsaufenthaltLabel.Location = New System.Drawing.Point(9, 449)
        AuslandsaufenthaltLabel.Name = "AuslandsaufenthaltLabel"
        AuslandsaufenthaltLabel.Size = New System.Drawing.Size(143, 16)
        AuslandsaufenthaltLabel.TabIndex = 36
        AuslandsaufenthaltLabel.Text = "Auslandsaufenthalt:"
        '
        'Auslandsaufenthalt_woLabel
        '
        Auslandsaufenthalt_woLabel.AutoSize = True
        Auslandsaufenthalt_woLabel.Location = New System.Drawing.Point(9, 518)
        Auslandsaufenthalt_woLabel.Name = "Auslandsaufenthalt_woLabel"
        Auslandsaufenthalt_woLabel.Size = New System.Drawing.Size(166, 16)
        Auslandsaufenthalt_woLabel.TabIndex = 38
        Auslandsaufenthalt_woLabel.Text = "Auslandsaufenthalt wo:"
        '
        'Auslandsaufenthalt_dauerLabel
        '
        Auslandsaufenthalt_dauerLabel.AutoSize = True
        Auslandsaufenthalt_dauerLabel.Location = New System.Drawing.Point(440, 518)
        Auslandsaufenthalt_dauerLabel.Name = "Auslandsaufenthalt_dauerLabel"
        Auslandsaufenthalt_dauerLabel.Size = New System.Drawing.Size(189, 16)
        Auslandsaufenthalt_dauerLabel.TabIndex = 40
        Auslandsaufenthalt_dauerLabel.Text = "Auslandsaufenthalt Dauer:"
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
        'BeendigungsgrundLabel
        '
        BeendigungsgrundLabel.AutoSize = True
        BeendigungsgrundLabel.Location = New System.Drawing.Point(652, 31)
        BeendigungsgrundLabel.Name = "BeendigungsgrundLabel"
        BeendigungsgrundLabel.Size = New System.Drawing.Size(142, 16)
        BeendigungsgrundLabel.TabIndex = 8
        BeendigungsgrundLabel.Text = "Beendigungsgrund:"
        '
        'MdELabel
        '
        MdELabel.AutoSize = True
        MdELabel.Location = New System.Drawing.Point(522, 488)
        MdELabel.Name = "MdELabel"
        MdELabel.Size = New System.Drawing.Size(86, 16)
        MdELabel.TabIndex = 52
        MdELabel.Text = "MdE (in %):"
        '
        'MdELabel1
        '
        MdELabel1.AutoSize = True
        MdELabel1.Location = New System.Drawing.Point(0, 488)
        MdELabel1.Name = "MdELabel1"
        MdELabel1.Size = New System.Drawing.Size(113, 16)
        MdELabel1.TabIndex = 53
        MdELabel1.Text = "MdE oder GdB:"
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
        'WechselwunschLabel
        '
        WechselwunschLabel.AutoSize = True
        WechselwunschLabel.Location = New System.Drawing.Point(515, 81)
        WechselwunschLabel.Name = "WechselwunschLabel"
        WechselwunschLabel.Size = New System.Drawing.Size(122, 16)
        WechselwunschLabel.TabIndex = 11
        WechselwunschLabel.Text = "Wechselwunsch:"
        '
        'HaendedruckLabel
        '
        HaendedruckLabel.AutoSize = True
        HaendedruckLabel.Location = New System.Drawing.Point(248, 44)
        HaendedruckLabel.Name = "HaendedruckLabel"
        HaendedruckLabel.Size = New System.Drawing.Size(96, 16)
        HaendedruckLabel.TabIndex = 2
        HaendedruckLabel.Text = "Händedruck:"
        '
        'Gdb_gradLabel
        '
        Gdb_gradLabel.AutoSize = True
        Gdb_gradLabel.Location = New System.Drawing.Point(763, 488)
        Gdb_gradLabel.Name = "Gdb_gradLabel"
        Gdb_gradLabel.Size = New System.Drawing.Size(85, 16)
        Gdb_gradLabel.TabIndex = 54
        Gdb_gradLabel.Text = "GdB (in %):"
        '
        'TaetigkeitenLabel
        '
        TaetigkeitenLabel.AutoSize = True
        TaetigkeitenLabel.Location = New System.Drawing.Point(6, 154)
        TaetigkeitenLabel.Name = "TaetigkeitenLabel"
        TaetigkeitenLabel.Size = New System.Drawing.Size(249, 34)
        TaetigkeitenLabel.TabIndex = 4
        TaetigkeitenLabel.Text = "Bisherige Tätigkeiten, berufliche " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Schwerpunkte, Zeugnistext: *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AufmerksamLabel
        '
        AufmerksamLabel.AutoSize = True
        AufmerksamLabel.Location = New System.Drawing.Point(9, 35)
        AufmerksamLabel.Name = "AufmerksamLabel"
        AufmerksamLabel.Size = New System.Drawing.Size(183, 32)
        AufmerksamLabel.TabIndex = 2
        AufmerksamLabel.Text = "Auf Heyduck aufmerksam" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "geworden durch:"
        '
        'Aufmerksam_andereLabel
        '
        Aufmerksam_andereLabel.AutoSize = True
        Aufmerksam_andereLabel.Location = New System.Drawing.Point(9, 97)
        Aufmerksam_andereLabel.Name = "Aufmerksam_andereLabel"
        Aufmerksam_andereLabel.Size = New System.Drawing.Size(187, 48)
        Aufmerksam_andereLabel.TabIndex = 4
        Aufmerksam_andereLabel.Text = "Auf Heyduck aufmerksam " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "geworden " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "durch anderes:"
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1051, 746)
        Me.SplitContainer1.SplitterDistance = 146
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(InterviewerLabel)
        Me.Panel1.Controls.Add(Me.InterviewerComboBox)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(6, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1025, 144)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(383, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(633, 28)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(380, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sie bearbeiten diese Bewerberin/diesen Bewerber: "
        '
        'InterviewerComboBox
        '
        Me.InterviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "interviewer", True))
        Me.InterviewerComboBox.FormattingEnabled = True
        Me.InterviewerComboBox.Items.AddRange(New Object() {"", "Devilder", "Fürst", "Heyduck", "Mersch", "Leinweber"})
        Me.InterviewerComboBox.Location = New System.Drawing.Point(865, 40)
        Me.InterviewerComboBox.Name = "InterviewerComboBox"
        Me.InterviewerComboBox.Size = New System.Drawing.Size(151, 24)
        Me.InterviewerComboBox.TabIndex = 4
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
        Me.btnClose.Location = New System.Drawing.Point(481, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(169, 57)
        Me.btnClose.TabIndex = 3
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
        Me.btnSave.Location = New System.Drawing.Point(276, 22)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(169, 57)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "           Änderungen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           speichern"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Interviewereingaben"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1037, 566)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1029, 538)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kontaktdaten"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1006, 723)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(RaucherLabel)
        Me.GroupBox3.Controls.Add(Me.RaucherComboBox)
        Me.GroupBox3.Controls.Add(ParfumLabel)
        Me.GroupBox3.Controls.Add(Me.ParfumComboBox)
        Me.GroupBox3.Controls.Add(HaendedruckLabel)
        Me.GroupBox3.Controls.Add(Me.HaendedruckComboBox)
        Me.GroupBox3.Controls.Add(BeurteilungLabel)
        Me.GroupBox3.Controls.Add(Me.BeurteilungComboBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox3.Location = New System.Drawing.Point(7, 416)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(988, 280)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Persönliches"
        '
        'RaucherComboBox
        '
        Me.RaucherComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "raucher", True))
        Me.RaucherComboBox.FormattingEnabled = True
        Me.RaucherComboBox.Items.AddRange(New Object() {"", "keine Angaben", "Nein", "Ja"})
        Me.RaucherComboBox.Location = New System.Drawing.Point(811, 41)
        Me.RaucherComboBox.Name = "RaucherComboBox"
        Me.RaucherComboBox.Size = New System.Drawing.Size(148, 24)
        Me.RaucherComboBox.TabIndex = 7
        '
        'Bew_bewerberdatenBindingSource
        '
        Me.Bew_bewerberdatenBindingSource.DataMember = "bew_bew_bewerberdaten"
        Me.Bew_bewerberdatenBindingSource.DataSource = Me.BewBindingSource
        '
        'ParfumComboBox
        '
        Me.ParfumComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "parfum", True))
        Me.ParfumComboBox.FormattingEnabled = True
        Me.ParfumComboBox.Items.AddRange(New Object() {"", "keines", "wenig", "dezent", "stark", "penetrant", "Nuttendiesel"})
        Me.ParfumComboBox.Location = New System.Drawing.Point(564, 41)
        Me.ParfumComboBox.Name = "ParfumComboBox"
        Me.ParfumComboBox.Size = New System.Drawing.Size(153, 24)
        Me.ParfumComboBox.TabIndex = 5
        '
        'HaendedruckComboBox
        '
        Me.HaendedruckComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "haendedruck", True))
        Me.HaendedruckComboBox.FormattingEnabled = True
        Me.HaendedruckComboBox.Items.AddRange(New Object() {"", "Fingerspitzen", "weich", "feucht", "fest", "energisch", "Schraubstock", "normal"})
        Me.HaendedruckComboBox.Location = New System.Drawing.Point(350, 41)
        Me.HaendedruckComboBox.Name = "HaendedruckComboBox"
        Me.HaendedruckComboBox.Size = New System.Drawing.Size(125, 24)
        Me.HaendedruckComboBox.TabIndex = 3
        '
        'BeurteilungComboBox
        '
        Me.BeurteilungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "beurteilung", True))
        Me.BeurteilungComboBox.FormattingEnabled = True
        Me.BeurteilungComboBox.Items.AddRange(New Object() {"", "0,5", "1", "1,5", "2", "2,5", "3"})
        Me.BeurteilungComboBox.Location = New System.Drawing.Point(110, 41)
        Me.BeurteilungComboBox.Name = "BeurteilungComboBox"
        Me.BeurteilungComboBox.Size = New System.Drawing.Size(121, 24)
        Me.BeurteilungComboBox.TabIndex = 1
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
        Me.GroupBox2.Size = New System.Drawing.Size(999, 210)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kontakt durch:"
        '
        'txtAufmerksam_andere
        '
        Me.txtAufmerksam_andere.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "aufmerksam_andere", True))
        Me.txtAufmerksam_andere.Location = New System.Drawing.Point(213, 94)
        Me.txtAufmerksam_andere.Multiline = True
        Me.txtAufmerksam_andere.Name = "txtAufmerksam_andere"
        Me.txtAufmerksam_andere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAufmerksam_andere.Size = New System.Drawing.Size(252, 91)
        Me.txtAufmerksam_andere.TabIndex = 5
        '
        'cmbAufmerksam
        '
        Me.cmbAufmerksam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "aufmerksam", True))
        Me.cmbAufmerksam.FormattingEnabled = True
        Me.cmbAufmerksam.Location = New System.Drawing.Point(213, 32)
        Me.cmbAufmerksam.Name = "cmbAufmerksam"
        Me.cmbAufmerksam.Size = New System.Drawing.Size(252, 24)
        Me.cmbAufmerksam.TabIndex = 3
        '
        'EmpfehlungTextBox
        '
        Me.EmpfehlungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "empfehlung", True))
        Me.EmpfehlungTextBox.Location = New System.Drawing.Point(779, 32)
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
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1029, 538)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Beschäftigung"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GroupBox12)
        Me.Panel3.Controls.Add(Me.GroupBox9)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1006, 1126)
        Me.Panel3.TabIndex = 0
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.txtFuerstelle)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox12.Location = New System.Drawing.Point(3, 887)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(998, 174)
        Me.GroupBox12.TabIndex = 2
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Für Stellen vorschlagen (Auswahl aus OA mit Doppeklick)"
        '
        'txtFuerstelle
        '
        Me.txtFuerstelle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "fuerstelle", True))
        Me.txtFuerstelle.Location = New System.Drawing.Point(9, 25)
        Me.txtFuerstelle.Multiline = True
        Me.txtFuerstelle.Name = "txtFuerstelle"
        Me.txtFuerstelle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFuerstelle.Size = New System.Drawing.Size(442, 125)
        Me.txtFuerstelle.TabIndex = 3
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
        Me.GroupBox9.Location = New System.Drawing.Point(3, 538)
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
        Me.Label4.Size = New System.Drawing.Size(678, 64)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Kündigungs- bzw. Beendigungsdetails bitte unbedingt erfragen und möglichst detail" &
    "liert eintragen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Auch eintragen, wenn Bewerber/in darüber keine Auskunft gebe" &
    "n will." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
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
        Me.VerfuegbarkeitComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.BewBindingSource, "verfügbarkeit", True))
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
        Me.GroupBox4.Controls.Add(Me.JahresgehaltTextBox)
        Me.GroupBox4.Controls.Add(Me.MonatsgehaltTextBox)
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
        Me.GroupBox4.Controls.Add(MonatsgehaltLabel)
        Me.GroupBox4.Controls.Add(Pkw_oepnvLabel)
        Me.GroupBox4.Controls.Add(Me.Pkw_oepnvTextBox)
        Me.GroupBox4.Controls.Add(FuehrerscheinLabel)
        Me.GroupBox4.Controls.Add(Me.FuehrerscheinTextBox)
        Me.GroupBox4.Controls.Add(UmzugLabel)
        Me.GroupBox4.Controls.Add(Me.UmzugComboBox)
        Me.GroupBox4.Controls.Add(ArbeitsortLabel)
        Me.GroupBox4.Controls.Add(Me.ArbeitsortTextBox)
        Me.GroupBox4.Controls.Add(Teilzeit_wannLabel)
        Me.GroupBox4.Controls.Add(Me.Teilzeit_wannComboBox)
        Me.GroupBox4.Controls.Add(Teilzeit_stundenLabel)
        Me.GroupBox4.Controls.Add(Me.Teilzeit_stundenComboBox)
        Me.GroupBox4.Controls.Add(Vz_tzLabel)
        Me.GroupBox4.Controls.Add(Me.Vz_tzComboBox)
        Me.GroupBox4.Controls.Add(Za_vmLabel)
        Me.GroupBox4.Controls.Add(Me.Za_vmTextBox)
        Me.GroupBox4.Controls.Add(JobwunschLabel)
        Me.GroupBox4.Controls.Add(Me.JobwunschTextBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1000, 530)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Beschäftigung"
        '
        'JahresgehaltTextBox
        '
        Me.JahresgehaltTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "jahresgehalt", True))
        Me.JahresgehaltTextBox.Location = New System.Drawing.Point(368, 413)
        Me.JahresgehaltTextBox.Name = "JahresgehaltTextBox"
        Me.JahresgehaltTextBox.Size = New System.Drawing.Size(110, 22)
        Me.JahresgehaltTextBox.TabIndex = 13
        '
        'MonatsgehaltTextBox
        '
        Me.MonatsgehaltTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "monatsgehalt", True))
        Me.MonatsgehaltTextBox.Location = New System.Drawing.Point(124, 413)
        Me.MonatsgehaltTextBox.Name = "MonatsgehaltTextBox"
        Me.MonatsgehaltTextBox.Size = New System.Drawing.Size(107, 22)
        Me.MonatsgehaltTextBox.TabIndex = 13
        '
        'Gdb_gradTextBox
        '
        Me.Gdb_gradTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "gdb_grad", True))
        Me.Gdb_gradTextBox.Location = New System.Drawing.Point(880, 485)
        Me.Gdb_gradTextBox.Name = "Gdb_gradTextBox"
        Me.Gdb_gradTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Gdb_gradTextBox.TabIndex = 55
        '
        'MdEComboBox
        '
        Me.MdEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "MdE", True))
        Me.MdEComboBox.FormattingEnabled = True
        Me.MdEComboBox.Items.AddRange(New Object() {"", "keine Angaben", "Ja", "Nein"})
        Me.MdEComboBox.Location = New System.Drawing.Point(124, 485)
        Me.MdEComboBox.Name = "MdEComboBox"
        Me.MdEComboBox.Size = New System.Drawing.Size(203, 24)
        Me.MdEComboBox.TabIndex = 54
        '
        'MdETextBox
        '
        Me.MdETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "mde_grad", True))
        Me.MdETextBox.Location = New System.Drawing.Point(648, 485)
        Me.MdETextBox.Name = "MdETextBox"
        Me.MdETextBox.Size = New System.Drawing.Size(100, 22)
        Me.MdETextBox.TabIndex = 53
        '
        'Gehaltswunsch_jahrTextBox
        '
        Me.Gehaltswunsch_jahrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "gehaltswunsch_jahr", True))
        Me.Gehaltswunsch_jahrTextBox.Location = New System.Drawing.Point(880, 410)
        Me.Gehaltswunsch_jahrTextBox.Name = "Gehaltswunsch_jahrTextBox"
        Me.Gehaltswunsch_jahrTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Gehaltswunsch_jahrTextBox.TabIndex = 52
        '
        'Gehaltswunsch_monatTextBox
        '
        Me.Gehaltswunsch_monatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "gehaltswunsch_monat", True))
        Me.Gehaltswunsch_monatTextBox.Location = New System.Drawing.Point(648, 413)
        Me.Gehaltswunsch_monatTextBox.Name = "Gehaltswunsch_monatTextBox"
        Me.Gehaltswunsch_monatTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Gehaltswunsch_monatTextBox.TabIndex = 51
        '
        'Pkw_oepnvTextBox
        '
        Me.Pkw_oepnvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "pkw_oepnv", True))
        Me.Pkw_oepnvTextBox.Location = New System.Drawing.Point(608, 235)
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
        Me.FuehrerscheinTextBox.Location = New System.Drawing.Point(124, 330)
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
        Me.UmzugComboBox.Location = New System.Drawing.Point(608, 182)
        Me.UmzugComboBox.Name = "UmzugComboBox"
        Me.UmzugComboBox.Size = New System.Drawing.Size(230, 24)
        Me.UmzugComboBox.TabIndex = 46
        '
        'ArbeitsortTextBox
        '
        Me.ArbeitsortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "arbeitsort", True))
        Me.ArbeitsortTextBox.Location = New System.Drawing.Point(124, 235)
        Me.ArbeitsortTextBox.Multiline = True
        Me.ArbeitsortTextBox.Name = "ArbeitsortTextBox"
        Me.ArbeitsortTextBox.ReadOnly = True
        Me.ArbeitsortTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ArbeitsortTextBox.Size = New System.Drawing.Size(203, 71)
        Me.ArbeitsortTextBox.TabIndex = 45
        '
        'Teilzeit_wannComboBox
        '
        Me.Teilzeit_wannComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "teilzeit_wann", True))
        Me.Teilzeit_wannComboBox.Enabled = False
        Me.Teilzeit_wannComboBox.FormattingEnabled = True
        Me.Teilzeit_wannComboBox.Items.AddRange(New Object() {"", "egal", "Vormittags", "Nachmittags"})
        Me.Teilzeit_wannComboBox.Location = New System.Drawing.Point(607, 122)
        Me.Teilzeit_wannComboBox.Name = "Teilzeit_wannComboBox"
        Me.Teilzeit_wannComboBox.Size = New System.Drawing.Size(230, 24)
        Me.Teilzeit_wannComboBox.TabIndex = 15
        '
        'Teilzeit_stundenComboBox
        '
        Me.Teilzeit_stundenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bewerberdatenBindingSource, "teilzeit_stunden", True))
        Me.Teilzeit_stundenComboBox.Enabled = False
        Me.Teilzeit_stundenComboBox.FormattingEnabled = True
        Me.Teilzeit_stundenComboBox.Items.AddRange(New Object() {"", "bis 20 Stunden", "bis 25 Stunden", "bis 30 Stunden", "ab 20 Stunden", "mehr als 20 Stunden", "mehr als 30 Stunden"})
        Me.Teilzeit_stundenComboBox.Location = New System.Drawing.Point(124, 182)
        Me.Teilzeit_stundenComboBox.Name = "Teilzeit_stundenComboBox"
        Me.Teilzeit_stundenComboBox.Size = New System.Drawing.Size(203, 24)
        Me.Teilzeit_stundenComboBox.TabIndex = 13
        '
        'Vz_tzComboBox
        '
        Me.Vz_tzComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "arbeitszeit", True))
        Me.Vz_tzComboBox.FormattingEnabled = True
        Me.Vz_tzComboBox.Items.AddRange(New Object() {"", "Vollzeit", "Teilzeit", "Teilzeit flexibel", "Vollzeit/Teilzeit"})
        Me.Vz_tzComboBox.Location = New System.Drawing.Point(124, 122)
        Me.Vz_tzComboBox.Name = "Vz_tzComboBox"
        Me.Vz_tzComboBox.Size = New System.Drawing.Size(203, 24)
        Me.Vz_tzComboBox.TabIndex = 11
        '
        'Za_vmTextBox
        '
        Me.Za_vmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "Vermittlung", True))
        Me.Za_vmTextBox.Location = New System.Drawing.Point(608, 35)
        Me.Za_vmTextBox.Multiline = True
        Me.Za_vmTextBox.Name = "Za_vmTextBox"
        Me.Za_vmTextBox.ReadOnly = True
        Me.Za_vmTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Za_vmTextBox.Size = New System.Drawing.Size(230, 46)
        Me.Za_vmTextBox.TabIndex = 9
        '
        'JobwunschTextBox
        '
        Me.JobwunschTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "jobwunsch", True))
        Me.JobwunschTextBox.Location = New System.Drawing.Point(124, 28)
        Me.JobwunschTextBox.Multiline = True
        Me.JobwunschTextBox.Name = "JobwunschTextBox"
        Me.JobwunschTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.JobwunschTextBox.Size = New System.Drawing.Size(203, 69)
        Me.JobwunschTextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1029, 538)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ausbildung/Studium"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox5)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.Crimson
        Me.Panel4.Location = New System.Drawing.Point(4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1008, 278)
        Me.Panel4.TabIndex = 0
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
        Me.GroupBox5.Size = New System.Drawing.Size(986, 266)
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
        Me.TabPage4.Controls.Add(Me.Panel5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1029, 538)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Berufserfahrung"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.GroupBox7)
        Me.Panel5.Controls.Add(Me.GroupBox6)
        Me.Panel5.Location = New System.Drawing.Point(4, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1008, 511)
        Me.Panel5.TabIndex = 0
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
        Me.GroupBox7.Location = New System.Drawing.Point(8, 335)
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
        Me.FuehrungsverantwortungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_berufserfahrungBindingSource, "fuehrungsverantwortung", True))
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
        Me.GroupBox6.Controls.Add(TaetigkeitenLabel)
        Me.GroupBox6.Controls.Add(Me.TaetigkeitenTextBox)
        Me.GroupBox6.Controls.Add(Beruf_schwerpunkttaetigkeitLabel)
        Me.GroupBox6.Controls.Add(Me.Beruf_schwerpunkttaetigkeitTextBox)
        Me.GroupBox6.Controls.Add(Beruf_positionLabel)
        Me.GroupBox6.Controls.Add(Me.Beruf_positionTextBox)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox6.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(984, 326)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Berufserfahrung"
        '
        'TaetigkeitenTextBox
        '
        Me.TaetigkeitenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "tätigkeiten", True))
        Me.TaetigkeitenTextBox.Location = New System.Drawing.Point(259, 154)
        Me.TaetigkeitenTextBox.Multiline = True
        Me.TaetigkeitenTextBox.Name = "TaetigkeitenTextBox"
        Me.TaetigkeitenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TaetigkeitenTextBox.Size = New System.Drawing.Size(705, 156)
        Me.TaetigkeitenTextBox.TabIndex = 5
        '
        'Beruf_schwerpunkttaetigkeitTextBox
        '
        Me.Beruf_schwerpunkttaetigkeitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_berufserfahrungBindingSource, "beruf_schwerpunkttaetigkeit", True))
        Me.Beruf_schwerpunkttaetigkeitTextBox.Location = New System.Drawing.Point(677, 34)
        Me.Beruf_schwerpunkttaetigkeitTextBox.Multiline = True
        Me.Beruf_schwerpunkttaetigkeitTextBox.Name = "Beruf_schwerpunkttaetigkeitTextBox"
        Me.Beruf_schwerpunkttaetigkeitTextBox.ReadOnly = True
        Me.Beruf_schwerpunkttaetigkeitTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Beruf_schwerpunkttaetigkeitTextBox.Size = New System.Drawing.Size(287, 84)
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
        Me.Beruf_positionTextBox.Size = New System.Drawing.Size(301, 84)
        Me.Beruf_positionTextBox.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.Panel6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1029, 538)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Sprachkenntnisse"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.GroupBox8)
        Me.Panel6.Location = New System.Drawing.Point(4, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(991, 620)
        Me.Panel6.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Auslandsaufenthalt_dauerLabel)
        Me.GroupBox8.Controls.Add(Me.Auslandsaufenthalt_dauerTextBox)
        Me.GroupBox8.Controls.Add(Auslandsaufenthalt_woLabel)
        Me.GroupBox8.Controls.Add(Me.Auslandsaufenthalt_woTextBox)
        Me.GroupBox8.Controls.Add(AuslandsaufenthaltLabel)
        Me.GroupBox8.Controls.Add(Me.AuslandsaufenthaltComboBox)
        Me.GroupBox8.Controls.Add(Deutsch_interviewerLabel)
        Me.GroupBox8.Controls.Add(Me.Deutsch_interviewerComboBox)
        Me.GroupBox8.Controls.Add(DeutschLabel)
        Me.GroupBox8.Controls.Add(Me.DeutschTextBox)
        Me.GroupBox8.Controls.Add(Niederlaendisch_interviewerLabel)
        Me.GroupBox8.Controls.Add(Me.Niederlaendisch_interviewerComboBox)
        Me.GroupBox8.Controls.Add(NiederlaendischLabel)
        Me.GroupBox8.Controls.Add(Me.NiederlaendischTextBox)
        Me.GroupBox8.Controls.Add(Russisch_interviewerLabel)
        Me.GroupBox8.Controls.Add(Me.Russisch_interviewerComboBox)
        Me.GroupBox8.Controls.Add(RussischLabel)
        Me.GroupBox8.Controls.Add(Me.RussischTextBox)
        Me.GroupBox8.Controls.Add(Tuerkisch_interviewerLabel)
        Me.GroupBox8.Controls.Add(Me.Tuerkisch_interviewerComboBox)
        Me.GroupBox8.Controls.Add(TuerkischLabel)
        Me.GroupBox8.Controls.Add(Me.TuerkischTextBox)
        Me.GroupBox8.Controls.Add(Italienisch_interviewerLabel)
        Me.GroupBox8.Controls.Add(Me.Italienisch_interviewerComboBox)
        Me.GroupBox8.Controls.Add(ItalienischLabel)
        Me.GroupBox8.Controls.Add(Me.ItalienischTextBox)
        Me.GroupBox8.Controls.Add(Spanisch_interviewerLabel)
        Me.GroupBox8.Controls.Add(Me.Spanisch_interviewerComboBox)
        Me.GroupBox8.Controls.Add(SpanischLabel)
        Me.GroupBox8.Controls.Add(Me.SpanischTextBox)
        Me.GroupBox8.Controls.Add(Französich_interviewerLabel)
        Me.GroupBox8.Controls.Add(Me.Französich_interviewerComboBox)
        Me.GroupBox8.Controls.Add(FranzoesischLabel)
        Me.GroupBox8.Controls.Add(Me.FranzoesischTextBox)
        Me.GroupBox8.Controls.Add(Englisch_interviewerLabel)
        Me.GroupBox8.Controls.Add(Me.Englisch_interviewerComboBox)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(EnglischLabel)
        Me.GroupBox8.Controls.Add(Me.EnglischTextBox)
        Me.GroupBox8.Controls.Add(Muendlich_schriftlichLabel)
        Me.GroupBox8.Controls.Add(Me.Muendlich_schriftlichComboBox)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox8.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(968, 608)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Sprachkenntnisse"
        '
        'Auslandsaufenthalt_dauerTextBox
        '
        Me.Auslandsaufenthalt_dauerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "auslandsaufenthalt_dauer", True))
        Me.Auslandsaufenthalt_dauerTextBox.Location = New System.Drawing.Point(699, 515)
        Me.Auslandsaufenthalt_dauerTextBox.Multiline = True
        Me.Auslandsaufenthalt_dauerTextBox.Name = "Auslandsaufenthalt_dauerTextBox"
        Me.Auslandsaufenthalt_dauerTextBox.ReadOnly = True
        Me.Auslandsaufenthalt_dauerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Auslandsaufenthalt_dauerTextBox.Size = New System.Drawing.Size(207, 71)
        Me.Auslandsaufenthalt_dauerTextBox.TabIndex = 41
        '
        'Bewerber_sprachenBindingSource
        '
        Me.Bewerber_sprachenBindingSource.DataMember = "bew_bewerber_sprachen"
        Me.Bewerber_sprachenBindingSource.DataSource = Me.BewBindingSource
        '
        'Auslandsaufenthalt_woTextBox
        '
        Me.Auslandsaufenthalt_woTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "auslandsaufenthalt_wo", True))
        Me.Auslandsaufenthalt_woTextBox.Location = New System.Drawing.Point(180, 515)
        Me.Auslandsaufenthalt_woTextBox.Multiline = True
        Me.Auslandsaufenthalt_woTextBox.Name = "Auslandsaufenthalt_woTextBox"
        Me.Auslandsaufenthalt_woTextBox.ReadOnly = True
        Me.Auslandsaufenthalt_woTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Auslandsaufenthalt_woTextBox.Size = New System.Drawing.Size(218, 71)
        Me.Auslandsaufenthalt_woTextBox.TabIndex = 39
        '
        'AuslandsaufenthaltComboBox
        '
        Me.AuslandsaufenthaltComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.Bewerber_sprachenBindingSource, "auslandsaufenthalt", True))
        Me.AuslandsaufenthaltComboBox.FormattingEnabled = True
        Me.AuslandsaufenthaltComboBox.Items.AddRange(New Object() {"", "Ja", "Nein", "Geplant"})
        Me.AuslandsaufenthaltComboBox.Location = New System.Drawing.Point(167, 446)
        Me.AuslandsaufenthaltComboBox.Name = "AuslandsaufenthaltComboBox"
        Me.AuslandsaufenthaltComboBox.Size = New System.Drawing.Size(231, 24)
        Me.AuslandsaufenthaltComboBox.TabIndex = 37
        '
        'Deutsch_interviewerComboBox
        '
        Me.Deutsch_interviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "deutsch_interviewer", True))
        Me.Deutsch_interviewerComboBox.FormattingEnabled = True
        Me.Deutsch_interviewerComboBox.Location = New System.Drawing.Point(699, 391)
        Me.Deutsch_interviewerComboBox.Name = "Deutsch_interviewerComboBox"
        Me.Deutsch_interviewerComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Deutsch_interviewerComboBox.TabIndex = 35
        '
        'DeutschTextBox
        '
        Me.DeutschTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "deutsch", True))
        Me.DeutschTextBox.Location = New System.Drawing.Point(129, 391)
        Me.DeutschTextBox.Name = "DeutschTextBox"
        Me.DeutschTextBox.ReadOnly = True
        Me.DeutschTextBox.Size = New System.Drawing.Size(269, 22)
        Me.DeutschTextBox.TabIndex = 33
        '
        'Niederlaendisch_interviewerComboBox
        '
        Me.Niederlaendisch_interviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "niederlaendisch_interviewer", True))
        Me.Niederlaendisch_interviewerComboBox.FormattingEnabled = True
        Me.Niederlaendisch_interviewerComboBox.Location = New System.Drawing.Point(699, 348)
        Me.Niederlaendisch_interviewerComboBox.Name = "Niederlaendisch_interviewerComboBox"
        Me.Niederlaendisch_interviewerComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Niederlaendisch_interviewerComboBox.TabIndex = 31
        '
        'NiederlaendischTextBox
        '
        Me.NiederlaendischTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "niederlaendisch", True))
        Me.NiederlaendischTextBox.Location = New System.Drawing.Point(129, 348)
        Me.NiederlaendischTextBox.Name = "NiederlaendischTextBox"
        Me.NiederlaendischTextBox.ReadOnly = True
        Me.NiederlaendischTextBox.Size = New System.Drawing.Size(269, 22)
        Me.NiederlaendischTextBox.TabIndex = 29
        '
        'Russisch_interviewerComboBox
        '
        Me.Russisch_interviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "russisch_interviewer", True))
        Me.Russisch_interviewerComboBox.FormattingEnabled = True
        Me.Russisch_interviewerComboBox.Location = New System.Drawing.Point(699, 297)
        Me.Russisch_interviewerComboBox.Name = "Russisch_interviewerComboBox"
        Me.Russisch_interviewerComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Russisch_interviewerComboBox.TabIndex = 27
        '
        'RussischTextBox
        '
        Me.RussischTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "russisch", True))
        Me.RussischTextBox.Location = New System.Drawing.Point(129, 297)
        Me.RussischTextBox.Name = "RussischTextBox"
        Me.RussischTextBox.ReadOnly = True
        Me.RussischTextBox.Size = New System.Drawing.Size(269, 22)
        Me.RussischTextBox.TabIndex = 25
        '
        'Tuerkisch_interviewerComboBox
        '
        Me.Tuerkisch_interviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "tuerkisch_interviewer", True))
        Me.Tuerkisch_interviewerComboBox.FormattingEnabled = True
        Me.Tuerkisch_interviewerComboBox.Location = New System.Drawing.Point(699, 258)
        Me.Tuerkisch_interviewerComboBox.Name = "Tuerkisch_interviewerComboBox"
        Me.Tuerkisch_interviewerComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Tuerkisch_interviewerComboBox.TabIndex = 23
        '
        'TuerkischTextBox
        '
        Me.TuerkischTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "tuerkisch", True))
        Me.TuerkischTextBox.Location = New System.Drawing.Point(129, 258)
        Me.TuerkischTextBox.Name = "TuerkischTextBox"
        Me.TuerkischTextBox.ReadOnly = True
        Me.TuerkischTextBox.Size = New System.Drawing.Size(269, 22)
        Me.TuerkischTextBox.TabIndex = 21
        '
        'Italienisch_interviewerComboBox
        '
        Me.Italienisch_interviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "italienisch_interviewer", True))
        Me.Italienisch_interviewerComboBox.FormattingEnabled = True
        Me.Italienisch_interviewerComboBox.Location = New System.Drawing.Point(699, 218)
        Me.Italienisch_interviewerComboBox.Name = "Italienisch_interviewerComboBox"
        Me.Italienisch_interviewerComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Italienisch_interviewerComboBox.TabIndex = 19
        '
        'ItalienischTextBox
        '
        Me.ItalienischTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "italienisch", True))
        Me.ItalienischTextBox.Location = New System.Drawing.Point(129, 218)
        Me.ItalienischTextBox.Name = "ItalienischTextBox"
        Me.ItalienischTextBox.ReadOnly = True
        Me.ItalienischTextBox.Size = New System.Drawing.Size(269, 22)
        Me.ItalienischTextBox.TabIndex = 17
        '
        'Spanisch_interviewerComboBox
        '
        Me.Spanisch_interviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "spanisch_interviewer", True))
        Me.Spanisch_interviewerComboBox.FormattingEnabled = True
        Me.Spanisch_interviewerComboBox.Location = New System.Drawing.Point(699, 176)
        Me.Spanisch_interviewerComboBox.Name = "Spanisch_interviewerComboBox"
        Me.Spanisch_interviewerComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Spanisch_interviewerComboBox.TabIndex = 15
        '
        'SpanischTextBox
        '
        Me.SpanischTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "spanisch", True))
        Me.SpanischTextBox.Location = New System.Drawing.Point(129, 176)
        Me.SpanischTextBox.Name = "SpanischTextBox"
        Me.SpanischTextBox.ReadOnly = True
        Me.SpanischTextBox.Size = New System.Drawing.Size(269, 22)
        Me.SpanischTextBox.TabIndex = 13
        '
        'Französich_interviewerComboBox
        '
        Me.Französich_interviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "französich_interviewer", True))
        Me.Französich_interviewerComboBox.FormattingEnabled = True
        Me.Französich_interviewerComboBox.Location = New System.Drawing.Point(699, 138)
        Me.Französich_interviewerComboBox.Name = "Französich_interviewerComboBox"
        Me.Französich_interviewerComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Französich_interviewerComboBox.TabIndex = 11
        '
        'FranzoesischTextBox
        '
        Me.FranzoesischTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "franzoesisch", True))
        Me.FranzoesischTextBox.Location = New System.Drawing.Point(129, 138)
        Me.FranzoesischTextBox.Name = "FranzoesischTextBox"
        Me.FranzoesischTextBox.ReadOnly = True
        Me.FranzoesischTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FranzoesischTextBox.Size = New System.Drawing.Size(269, 22)
        Me.FranzoesischTextBox.TabIndex = 9
        '
        'Englisch_interviewerComboBox
        '
        Me.Englisch_interviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "englisch_interviewer", True))
        Me.Englisch_interviewerComboBox.FormattingEnabled = True
        Me.Englisch_interviewerComboBox.Location = New System.Drawing.Point(699, 94)
        Me.Englisch_interviewerComboBox.Name = "Englisch_interviewerComboBox"
        Me.Englisch_interviewerComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Englisch_interviewerComboBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(439, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Laut Interviewer:"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(9, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Laut Bewerber:"
        '
        'EnglischTextBox
        '
        Me.EnglischTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "englisch", True))
        Me.EnglischTextBox.Location = New System.Drawing.Point(129, 94)
        Me.EnglischTextBox.Name = "EnglischTextBox"
        Me.EnglischTextBox.ReadOnly = True
        Me.EnglischTextBox.Size = New System.Drawing.Size(269, 22)
        Me.EnglischTextBox.TabIndex = 3
        '
        'Muendlich_schriftlichComboBox
        '
        Me.Muendlich_schriftlichComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_sprachenBindingSource, "muendlich_schriftlich", True))
        Me.Muendlich_schriftlichComboBox.FormattingEnabled = True
        Me.Muendlich_schriftlichComboBox.Items.AddRange(New Object() {"", "mündlich", "schriftlich", "mündlich und schriftlich"})
        Me.Muendlich_schriftlichComboBox.Location = New System.Drawing.Point(234, 24)
        Me.Muendlich_schriftlichComboBox.Name = "Muendlich_schriftlichComboBox"
        Me.Muendlich_schriftlichComboBox.Size = New System.Drawing.Size(246, 24)
        Me.Muendlich_schriftlichComboBox.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Panel7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1029, 538)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Persönlichkeit/Äusseres/Charaktereigenschaften"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.Controls.Add(Me.GroupBox10)
        Me.Panel7.Location = New System.Drawing.Point(4, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1017, 521)
        Me.Panel7.TabIndex = 0
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
        Me.GroupBox10.Text = "Persönlichkeit/Äusseres etc."
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
        Me.TabPage7.Controls.Add(Me.Panel8)
        Me.TabPage7.Location = New System.Drawing.Point(4, 24)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1029, 538)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Ulas"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.GroupBox11)
        Me.Panel8.Location = New System.Drawing.Point(4, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1017, 489)
        Me.Panel8.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.White
        Me.GroupBox11.Controls.Add(Me.Label5)
        Me.GroupBox11.Controls.Add(Me.UlasTextBox)
        Me.GroupBox11.Controls.Add(Me.PictureBox1)
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
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(563, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 66)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ulas auswählen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "oder ändern" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mit Doppelklick"
        '
        'UlasTextBox
        '
        Me.UlasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ulas", True))
        Me.UlasTextBox.Location = New System.Drawing.Point(730, 35)
        Me.UlasTextBox.Multiline = True
        Me.UlasTextBox.Name = "UlasTextBox"
        Me.UlasTextBox.ReadOnly = True
        Me.UlasTextBox.Size = New System.Drawing.Size(210, 283)
        Me.UlasTextBox.TabIndex = 4
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
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(541, 432)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'UlasBindingSource
        '
        Me.UlasBindingSource.DataMember = "bew_ulas"
        Me.UlasBindingSource.DataSource = Me.BewBindingSource
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BewTableAdapter
        '
        Me.BewTableAdapter.ClearBeforeFill = True
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
        'Bewerber_sprachenTableAdapter
        '
        Me.Bewerber_sprachenTableAdapter.ClearBeforeFill = True
        '
        'UlasTableAdapter
        '
        Me.UlasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.bewerber_edvTableAdapter = Nothing
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
        'frmInterviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1051, 746)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInterviewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Interviewerfragebogen"
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
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Bew_bewerberdatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Bewerber_ausbildungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Bewerber_berufserfahrungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.Bewerber_sprachenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.RTEPersoenlichkeit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UlasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents BewerberDataSet As bewerberpool.BewerberDataSet
    Friend WithEvents BewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InterviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Bew_bewerberdatenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents EmpfehlungTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BeurteilungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BewTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter
    Friend WithEvents HaendedruckComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bew_bewerberdatenTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bew_bewerberdatenTableAdapter
    Friend WithEvents ParfumComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RaucherComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents JobwunschTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VerfuegbarkeitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Za_vmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vz_tzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Teilzeit_stundenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Teilzeit_wannComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ArbeitsortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UmzugComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FuehrerscheinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pkw_oepnvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gehaltswunsch_jahrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gehaltswunsch_monatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Bewerber_ausbildungBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_ausbildungTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewerber_ausbildungTableAdapter
    Friend WithEvents Ausbildung_qualifizierungTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AusbildungsberufTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Studium_abschlussTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudienfaecherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Bewerber_berufserfahrungBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_berufserfahrungTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewerber_berufserfahrungTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Beruf_positionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Beruf_schwerpunkttaetigkeitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents FuehrungsverantwortungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fuehrungsverantwortung_dauerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PersonalverantwortungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personalverantwortung_anzahlTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Bewerber_sprachenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_sprachenTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewerber_sprachenTableAdapter
    Friend WithEvents Muendlich_schriftlichComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EnglischTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Englisch_interviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Niederlaendisch_interviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NiederlaendischTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RussischTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tuerkisch_interviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TuerkischTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Italienisch_interviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ItalienischTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Spanisch_interviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpanischTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Französich_interviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FranzoesischTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Deutsch_interviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeutschTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuslandsaufenthaltComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Auslandsaufenthalt_dauerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Auslandsaufenthalt_woTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents KuendigungsfristComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BeendigungsgrundComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MdETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MdEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WechselwunschTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Beendigungsgrund_detailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents StrasseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UlasTableAdapter As bewerberpool.BewerberDataSetTableAdapters.ulasTableAdapter
    Friend WithEvents RTEPersoenlichkeit As Telerik.WinControls.UI.RadRichTextEditor
    Friend WithEvents Gdb_gradTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Russisch_interviewerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents JahresgehaltTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonatsgehaltTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TaetigkeitenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbAufmerksam As ComboBox
    Friend WithEvents txtAufmerksam_andere As TextBox
    Friend WithEvents txtFuerstelle As TextBox
End Class
