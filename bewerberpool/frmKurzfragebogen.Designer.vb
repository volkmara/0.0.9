<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKurzfragebogen
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
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim PlzLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim StrasseLabel As System.Windows.Forms.Label
        Dim Tel_festnetzLabel As System.Windows.Forms.Label
        Dim Tel_mobilLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim VerfuegbarkeitLabel As System.Windows.Forms.Label
        Dim Vz_tzLabel As System.Windows.Forms.Label
        Dim Za_vmLabel As System.Windows.Forms.Label
        Dim MonatsgehaltLabel As System.Windows.Forms.Label
        Dim AusbildungsberufLabel As System.Windows.Forms.Label
        Dim Bisherige_taetigkeitenLabel As System.Windows.Forms.Label
        Dim UlasLabel As System.Windows.Forms.Label
        Dim Gehaltswunsch_monatLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKurzfragebogen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UlasTextBox = New System.Windows.Forms.TextBox()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.AnredeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNeuerBewerber = New System.Windows.Forms.Button()
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Gehaltswunsch_monatTextBox = New System.Windows.Forms.TextBox()
        Me.Bisherige_taetigkeitenTextBox = New System.Windows.Forms.TextBox()
        Me.AusbildungsberufTextBox = New System.Windows.Forms.TextBox()
        Me.MonatsgehaltTextBox = New System.Windows.Forms.TextBox()
        Me.Za_vmTextBox = New System.Windows.Forms.TextBox()
        Me.Vz_tzComboBox = New System.Windows.Forms.ComboBox()
        Me.VerfuegbarkeitComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_mobilTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_festnetzTextBox = New System.Windows.Forms.TextBox()
        Me.StrasseTextBox = New System.Windows.Forms.TextBox()
        Me.OrtTextBox = New System.Windows.Forms.TextBox()
        Me.PlzTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableAdapterManager = New bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager()
        AnredeLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        PlzLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        StrasseLabel = New System.Windows.Forms.Label()
        Tel_festnetzLabel = New System.Windows.Forms.Label()
        Tel_mobilLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        VerfuegbarkeitLabel = New System.Windows.Forms.Label()
        Vz_tzLabel = New System.Windows.Forms.Label()
        Za_vmLabel = New System.Windows.Forms.Label()
        MonatsgehaltLabel = New System.Windows.Forms.Label()
        AusbildungsberufLabel = New System.Windows.Forms.Label()
        Bisherige_taetigkeitenLabel = New System.Windows.Forms.Label()
        UlasLabel = New System.Windows.Forms.Label()
        Gehaltswunsch_monatLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnredeLabel
        '
        AnredeLabel.AutoSize = True
        AnredeLabel.Location = New System.Drawing.Point(28, 84)
        AnredeLabel.Name = "AnredeLabel"
        AnredeLabel.Size = New System.Drawing.Size(62, 16)
        AnredeLabel.TabIndex = 6
        AnredeLabel.Text = "Anrede:"
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(28, 134)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(74, 16)
        VornameLabel.TabIndex = 7
        VornameLabel.Text = "Vorname:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(28, 184)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(86, 16)
        NameLabel.TabIndex = 8
        NameLabel.Text = "Nachname:"
        '
        'PlzLabel
        '
        PlzLabel.AutoSize = True
        PlzLabel.Location = New System.Drawing.Point(13, 40)
        PlzLabel.Name = "PlzLabel"
        PlzLabel.Size = New System.Drawing.Size(39, 16)
        PlzLabel.TabIndex = 0
        PlzLabel.Text = "PLZ:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(203, 40)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(32, 16)
        OrtLabel.TabIndex = 2
        OrtLabel.Text = "Ort:"
        '
        'StrasseLabel
        '
        StrasseLabel.AutoSize = True
        StrasseLabel.Location = New System.Drawing.Point(538, 40)
        StrasseLabel.Name = "StrasseLabel"
        StrasseLabel.Size = New System.Drawing.Size(65, 16)
        StrasseLabel.TabIndex = 4
        StrasseLabel.Text = "Strasse:"
        '
        'Tel_festnetzLabel
        '
        Tel_festnetzLabel.AutoSize = True
        Tel_festnetzLabel.Location = New System.Drawing.Point(13, 98)
        Tel_festnetzLabel.Name = "Tel_festnetzLabel"
        Tel_festnetzLabel.Size = New System.Drawing.Size(70, 16)
        Tel_festnetzLabel.TabIndex = 6
        Tel_festnetzLabel.Text = "Festnetz:"
        '
        'Tel_mobilLabel
        '
        Tel_mobilLabel.AutoSize = True
        Tel_mobilLabel.Location = New System.Drawing.Point(342, 98)
        Tel_mobilLabel.Name = "Tel_mobilLabel"
        Tel_mobilLabel.Size = New System.Drawing.Size(57, 16)
        Tel_mobilLabel.TabIndex = 8
        Tel_mobilLabel.Text = "Handy:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(645, 98)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(51, 16)
        EmailLabel.TabIndex = 10
        EmailLabel.Text = "Email:"
        '
        'VerfuegbarkeitLabel
        '
        VerfuegbarkeitLabel.AutoSize = True
        VerfuegbarkeitLabel.Location = New System.Drawing.Point(13, 36)
        VerfuegbarkeitLabel.Name = "VerfuegbarkeitLabel"
        VerfuegbarkeitLabel.Size = New System.Drawing.Size(105, 16)
        VerfuegbarkeitLabel.TabIndex = 0
        VerfuegbarkeitLabel.Text = "Verfügbarkeit:"
        '
        'Vz_tzLabel
        '
        Vz_tzLabel.AutoSize = True
        Vz_tzLabel.Location = New System.Drawing.Point(385, 36)
        Vz_tzLabel.Name = "Vz_tzLabel"
        Vz_tzLabel.Size = New System.Drawing.Size(119, 16)
        Vz_tzLabel.TabIndex = 2
        Vz_tzLabel.Text = "Vollzeit/Teilzeit:"
        '
        'Za_vmLabel
        '
        Za_vmLabel.AutoSize = True
        Za_vmLabel.Location = New System.Drawing.Point(721, 36)
        Za_vmLabel.Name = "Za_vmLabel"
        Za_vmLabel.Size = New System.Drawing.Size(109, 48)
        Za_vmLabel.TabIndex = 4
        Za_vmLabel.Text = "ZA/VM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Doppelklick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zum Eintragen:"
        '
        'MonatsgehaltLabel
        '
        MonatsgehaltLabel.AutoSize = True
        MonatsgehaltLabel.Location = New System.Drawing.Point(13, 131)
        MonatsgehaltLabel.Name = "MonatsgehaltLabel"
        MonatsgehaltLabel.Size = New System.Drawing.Size(158, 16)
        MonatsgehaltLabel.TabIndex = 6
        MonatsgehaltLabel.Text = "Letztes Monatsgehalt:"
        '
        'AusbildungsberufLabel
        '
        AusbildungsberufLabel.AutoSize = True
        AusbildungsberufLabel.Location = New System.Drawing.Point(13, 189)
        AusbildungsberufLabel.Name = "AusbildungsberufLabel"
        AusbildungsberufLabel.Size = New System.Drawing.Size(133, 32)
        AusbildungsberufLabel.TabIndex = 10
        AusbildungsberufLabel.Text = "Ausbildungsberuf/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Studium:"
        '
        'Bisherige_taetigkeitenLabel
        '
        Bisherige_taetigkeitenLabel.AutoSize = True
        Bisherige_taetigkeitenLabel.Location = New System.Drawing.Point(460, 180)
        Bisherige_taetigkeitenLabel.Name = "Bisherige_taetigkeitenLabel"
        Bisherige_taetigkeitenLabel.Size = New System.Drawing.Size(160, 16)
        Bisherige_taetigkeitenLabel.TabIndex = 12
        Bisherige_taetigkeitenLabel.Text = "Bisherige Tätigkeiten:"
        '
        'UlasLabel
        '
        UlasLabel.AutoSize = True
        UlasLabel.Location = New System.Drawing.Point(611, 81)
        UlasLabel.Name = "UlasLabel"
        UlasLabel.Size = New System.Drawing.Size(44, 16)
        UlasLabel.TabIndex = 9
        UlasLabel.Text = "Ulas:"
        '
        'Gehaltswunsch_monatLabel
        '
        Gehaltswunsch_monatLabel.AutoSize = True
        Gehaltswunsch_monatLabel.Location = New System.Drawing.Point(418, 131)
        Gehaltswunsch_monatLabel.Name = "Gehaltswunsch_monatLabel"
        Gehaltswunsch_monatLabel.Size = New System.Drawing.Size(161, 16)
        Gehaltswunsch_monatLabel.TabIndex = 13
        Gehaltswunsch_monatLabel.Text = "Gehaltswunsch Monat:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(UlasLabel)
        Me.Panel1.Controls.Add(Me.UlasTextBox)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(VornameLabel)
        Me.Panel1.Controls.Add(Me.VornameTextBox)
        Me.Panel1.Controls.Add(AnredeLabel)
        Me.Panel1.Controls.Add(Me.AnredeComboBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1112, 225)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(613, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "(Doppelklick zum " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Eintragen)"
        '
        'UlasTextBox
        '
        Me.UlasTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.UlasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ulas", True))
        Me.UlasTextBox.Location = New System.Drawing.Point(792, 78)
        Me.UlasTextBox.Multiline = True
        Me.UlasTextBox.Name = "UlasTextBox"
        Me.UlasTextBox.ReadOnly = True
        Me.UlasTextBox.Size = New System.Drawing.Size(206, 54)
        Me.UlasTextBox.TabIndex = 10
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
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(134, 181)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(402, 22)
        Me.NameTextBox.TabIndex = 9
        '
        'VornameTextBox
        '
        Me.VornameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "vorname", True))
        Me.VornameTextBox.Location = New System.Drawing.Point(134, 131)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.Size = New System.Drawing.Size(402, 22)
        Me.VornameTextBox.TabIndex = 8
        '
        'AnredeComboBox
        '
        Me.AnredeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "anrede", True))
        Me.AnredeComboBox.FormattingEnabled = True
        Me.AnredeComboBox.Items.AddRange(New Object() {"", "Herr", "Frau"})
        Me.AnredeComboBox.Location = New System.Drawing.Point(134, 81)
        Me.AnredeComboBox.Name = "AnredeComboBox"
        Me.AnredeComboBox.Size = New System.Drawing.Size(121, 24)
        Me.AnredeComboBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1104, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bitte geben Sie Anrede, Vorname und Name des/r neuen Bewerber/in ein, für den ein" & _
    " Kurzprofil angelegt werden soll." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bitte alle Felder ausfüllen, wenn nicht bekan" & _
    "nt, 0 oder Leerzeichen eingeben." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'btnNeuerBewerber
        '
        Me.btnNeuerBewerber.BackColor = System.Drawing.Color.Gainsboro
        Me.btnNeuerBewerber.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNeuerBewerber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnNeuerBewerber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNeuerBewerber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNeuerBewerber.Image = CType(resources.GetObject("btnNeuerBewerber.Image"), System.Drawing.Image)
        Me.btnNeuerBewerber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNeuerBewerber.Location = New System.Drawing.Point(335, 491)
        Me.btnNeuerBewerber.Name = "btnNeuerBewerber"
        Me.btnNeuerBewerber.Size = New System.Drawing.Size(321, 60)
        Me.btnNeuerBewerber.TabIndex = 10
        Me.btnNeuerBewerber.Text = "Neue/n Bewerber/in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "anlegen"
        Me.btnNeuerBewerber.UseVisualStyleBackColor = False
        '
        'BewTableAdapter
        '
        Me.BewTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnNeuerBewerber)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(6, 237)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1112, 574)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Gehaltswunsch_monatLabel)
        Me.GroupBox2.Controls.Add(Me.Gehaltswunsch_monatTextBox)
        Me.GroupBox2.Controls.Add(Bisherige_taetigkeitenLabel)
        Me.GroupBox2.Controls.Add(Me.Bisherige_taetigkeitenTextBox)
        Me.GroupBox2.Controls.Add(AusbildungsberufLabel)
        Me.GroupBox2.Controls.Add(Me.AusbildungsberufTextBox)
        Me.GroupBox2.Controls.Add(MonatsgehaltLabel)
        Me.GroupBox2.Controls.Add(Me.MonatsgehaltTextBox)
        Me.GroupBox2.Controls.Add(Za_vmLabel)
        Me.GroupBox2.Controls.Add(Me.Za_vmTextBox)
        Me.GroupBox2.Controls.Add(Vz_tzLabel)
        Me.GroupBox2.Controls.Add(Me.Vz_tzComboBox)
        Me.GroupBox2.Controls.Add(VerfuegbarkeitLabel)
        Me.GroupBox2.Controls.Add(Me.VerfuegbarkeitComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Location = New System.Drawing.Point(8, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1100, 285)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Berufsdaten"
        '
        'Gehaltswunsch_monatTextBox
        '
        Me.Gehaltswunsch_monatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "gehaltswunsch_monat", True))
        Me.Gehaltswunsch_monatTextBox.Location = New System.Drawing.Point(583, 128)
        Me.Gehaltswunsch_monatTextBox.Name = "Gehaltswunsch_monatTextBox"
        Me.Gehaltswunsch_monatTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Gehaltswunsch_monatTextBox.TabIndex = 14
        '
        'Bisherige_taetigkeitenTextBox
        '
        Me.Bisherige_taetigkeitenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "tätigkeiten", True))
        Me.Bisherige_taetigkeitenTextBox.Location = New System.Drawing.Point(638, 177)
        Me.Bisherige_taetigkeitenTextBox.Multiline = True
        Me.Bisherige_taetigkeitenTextBox.Name = "Bisherige_taetigkeitenTextBox"
        Me.Bisherige_taetigkeitenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Bisherige_taetigkeitenTextBox.Size = New System.Drawing.Size(405, 88)
        Me.Bisherige_taetigkeitenTextBox.TabIndex = 13
        '
        'AusbildungsberufTextBox
        '
        Me.AusbildungsberufTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ausbildungsberuf", True))
        Me.AusbildungsberufTextBox.Location = New System.Drawing.Point(160, 186)
        Me.AusbildungsberufTextBox.Multiline = True
        Me.AusbildungsberufTextBox.Name = "AusbildungsberufTextBox"
        Me.AusbildungsberufTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AusbildungsberufTextBox.Size = New System.Drawing.Size(250, 79)
        Me.AusbildungsberufTextBox.TabIndex = 11
        '
        'MonatsgehaltTextBox
        '
        Me.MonatsgehaltTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "monatsgehalt", True))
        Me.MonatsgehaltTextBox.Location = New System.Drawing.Point(202, 128)
        Me.MonatsgehaltTextBox.Name = "MonatsgehaltTextBox"
        Me.MonatsgehaltTextBox.Size = New System.Drawing.Size(137, 22)
        Me.MonatsgehaltTextBox.TabIndex = 7
        '
        'Za_vmTextBox
        '
        Me.Za_vmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "Vermittlung", True))
        Me.Za_vmTextBox.Location = New System.Drawing.Point(849, 33)
        Me.Za_vmTextBox.Multiline = True
        Me.Za_vmTextBox.Name = "Za_vmTextBox"
        Me.Za_vmTextBox.ReadOnly = True
        Me.Za_vmTextBox.Size = New System.Drawing.Size(194, 87)
        Me.Za_vmTextBox.TabIndex = 5
        '
        'Vz_tzComboBox
        '
        Me.Vz_tzComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "arbeitszeit", True))
        Me.Vz_tzComboBox.FormattingEnabled = True
        Me.Vz_tzComboBox.Items.AddRange(New Object() {"", "Vollzeit", "Teilzeit", "Teilzeit flexibel", "Vollzeit/Teilzeit"})
        Me.Vz_tzComboBox.Location = New System.Drawing.Point(510, 33)
        Me.Vz_tzComboBox.Name = "Vz_tzComboBox"
        Me.Vz_tzComboBox.Size = New System.Drawing.Size(162, 24)
        Me.Vz_tzComboBox.TabIndex = 3
        '
        'VerfuegbarkeitComboBox
        '
        Me.VerfuegbarkeitComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "verfügbarkeit", True))
        Me.VerfuegbarkeitComboBox.FormattingEnabled = True
        Me.VerfuegbarkeitComboBox.Items.AddRange(New Object() {"", "sofort", "nach Absprache", "nach Kündigung"})
        Me.VerfuegbarkeitComboBox.Location = New System.Drawing.Point(127, 33)
        Me.VerfuegbarkeitComboBox.Name = "VerfuegbarkeitComboBox"
        Me.VerfuegbarkeitComboBox.Size = New System.Drawing.Size(212, 24)
        Me.VerfuegbarkeitComboBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Tel_mobilLabel)
        Me.GroupBox1.Controls.Add(Me.Tel_mobilTextBox)
        Me.GroupBox1.Controls.Add(Tel_festnetzLabel)
        Me.GroupBox1.Controls.Add(Me.Tel_festnetzTextBox)
        Me.GroupBox1.Controls.Add(Me.StrasseTextBox)
        Me.GroupBox1.Controls.Add(StrasseLabel)
        Me.GroupBox1.Controls.Add(OrtLabel)
        Me.GroupBox1.Controls.Add(Me.OrtTextBox)
        Me.GroupBox1.Controls.Add(PlzLabel)
        Me.GroupBox1.Controls.Add(Me.PlzTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1100, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kontaktdaten"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(702, 95)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(289, 22)
        Me.EmailTextBox.TabIndex = 11
        '
        'Tel_mobilTextBox
        '
        Me.Tel_mobilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "tel_mobil", True))
        Me.Tel_mobilTextBox.Location = New System.Drawing.Point(405, 95)
        Me.Tel_mobilTextBox.Name = "Tel_mobilTextBox"
        Me.Tel_mobilTextBox.Size = New System.Drawing.Size(163, 22)
        Me.Tel_mobilTextBox.TabIndex = 9
        '
        'Tel_festnetzTextBox
        '
        Me.Tel_festnetzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "tel_festnetz", True))
        Me.Tel_festnetzTextBox.Location = New System.Drawing.Point(89, 95)
        Me.Tel_festnetzTextBox.Name = "Tel_festnetzTextBox"
        Me.Tel_festnetzTextBox.Size = New System.Drawing.Size(166, 22)
        Me.Tel_festnetzTextBox.TabIndex = 7
        '
        'StrasseTextBox
        '
        Me.StrasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "strasse", True))
        Me.StrasseTextBox.Location = New System.Drawing.Point(609, 37)
        Me.StrasseTextBox.Name = "StrasseTextBox"
        Me.StrasseTextBox.Size = New System.Drawing.Size(298, 22)
        Me.StrasseTextBox.TabIndex = 6
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(239, 37)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(255, 22)
        Me.OrtTextBox.TabIndex = 3
        '
        'PlzTextBox
        '
        Me.PlzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "plz", True))
        Me.PlzTextBox.Location = New System.Drawing.Point(58, 37)
        Me.PlzTextBox.Name = "PlzTextBox"
        Me.PlzTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PlzTextBox.TabIndex = 1
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bew_assistenzTableAdapter = Nothing
        Me.TableAdapterManager.bew_bewerberdatenTableAdapter = Nothing
        Me.TableAdapterManager.bew_bibuhaTableAdapter = Nothing
        Me.TableAdapterManager.bew_lugTableAdapter = Nothing
        Me.TableAdapterManager.bew_steuerfachangestellteTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_ausbildungTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_berufserfahrungTableAdapter = Nothing
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
        Me.TableAdapterManager.bewerber_sprachenTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_technikTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_versandTableAdapter = Nothing
        Me.TableAdapterManager.bewerber_vertriebTableAdapter = Nothing
        Me.TableAdapterManager.bewTableAdapter = Me.BewTableAdapter
        Me.TableAdapterManager.gewerblichTableAdapter = Nothing
        Me.TableAdapterManager.notizenTableAdapter = Nothing
        Me.TableAdapterManager.ulasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmKurzfragebogen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1139, 819)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmKurzfragebogen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kurzfragebogen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberDataSet As bewerberpool.BewerberDataSet
    Friend WithEvents BewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BewTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter
    Friend WithEvents AnredeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VornameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNeuerBewerber As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OrtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StrasseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_mobilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_festnetzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents VerfuegbarkeitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vz_tzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Za_vmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonatsgehaltTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AusbildungsberufTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bisherige_taetigkeitenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UlasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gehaltswunsch_monatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager
End Class
