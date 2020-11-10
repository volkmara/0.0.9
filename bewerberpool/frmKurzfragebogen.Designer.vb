<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKurzfragebogen
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
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim PlzLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim StrasseLabel As System.Windows.Forms.Label
        Dim Tel_festnetzLabel As System.Windows.Forms.Label
        Dim Tel_mobilLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim UlasLabel As System.Windows.Forms.Label
        Dim InterviewartLabel As System.Windows.Forms.Label
        Dim RundschreibenLabel As System.Windows.Forms.Label
        Dim GeburtstagLabel As System.Windows.Forms.Label
        Dim StaatsangehörigkeitLabel As System.Windows.Forms.Label
        Dim StandLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKurzfragebogen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbStaatsangehörigkeit = New System.Windows.Forms.ComboBox()
        Me.txtGeburtstag = New System.Windows.Forms.TextBox()
        Me.cmbRundschreiben = New System.Windows.Forms.ComboBox()
        Me.cmbInterviewart = New System.Windows.Forms.ComboBox()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUlas = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.cmbAnrede = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bew_bewerberdatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnNeuerBewerber = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbStand = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPlz = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTel_mobil = New System.Windows.Forms.TextBox()
        Me.txtTel_festnetz = New System.Windows.Forms.TextBox()
        Me.StrasseTextBox = New System.Windows.Forms.TextBox()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.Bew_bewerberdatenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bew_bewerberdatenTableAdapter()
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
        UlasLabel = New System.Windows.Forms.Label()
        InterviewartLabel = New System.Windows.Forms.Label()
        RundschreibenLabel = New System.Windows.Forms.Label()
        GeburtstagLabel = New System.Windows.Forms.Label()
        StaatsangehörigkeitLabel = New System.Windows.Forms.Label()
        StandLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bew_bewerberdatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnredeLabel
        '
        AnredeLabel.AutoSize = True
        AnredeLabel.Location = New System.Drawing.Point(28, 69)
        AnredeLabel.Name = "AnredeLabel"
        AnredeLabel.Size = New System.Drawing.Size(62, 16)
        AnredeLabel.TabIndex = 6
        AnredeLabel.Text = "Anrede:"
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(28, 119)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(74, 16)
        VornameLabel.TabIndex = 7
        VornameLabel.Text = "Vorname:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(28, 169)
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
        OrtLabel.Location = New System.Drawing.Point(269, 43)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(32, 16)
        OrtLabel.TabIndex = 2
        OrtLabel.Text = "Ort:"
        '
        'StrasseLabel
        '
        StrasseLabel.AutoSize = True
        StrasseLabel.Location = New System.Drawing.Point(645, 37)
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
        'UlasLabel
        '
        UlasLabel.AutoSize = True
        UlasLabel.Location = New System.Drawing.Point(611, 65)
        UlasLabel.Name = "UlasLabel"
        UlasLabel.Size = New System.Drawing.Size(44, 16)
        UlasLabel.TabIndex = 9
        UlasLabel.Text = "Ulas:"
        '
        'InterviewartLabel
        '
        InterviewartLabel.AutoSize = True
        InterviewartLabel.ForeColor = System.Drawing.Color.Crimson
        InterviewartLabel.Location = New System.Drawing.Point(613, 144)
        InterviewartLabel.Name = "InterviewartLabel"
        InterviewartLabel.Size = New System.Drawing.Size(73, 16)
        InterviewartLabel.TabIndex = 11
        InterviewartLabel.Text = "Interview:"
        '
        'RundschreibenLabel
        '
        RundschreibenLabel.AutoSize = True
        RundschreibenLabel.Location = New System.Drawing.Point(613, 185)
        RundschreibenLabel.Name = "RundschreibenLabel"
        RundschreibenLabel.Size = New System.Drawing.Size(116, 16)
        RundschreibenLabel.TabIndex = 12
        RundschreibenLabel.Text = "Rundschreiben:"
        '
        'GeburtstagLabel
        '
        GeburtstagLabel.AutoSize = True
        GeburtstagLabel.Location = New System.Drawing.Point(28, 229)
        GeburtstagLabel.Name = "GeburtstagLabel"
        GeburtstagLabel.Size = New System.Drawing.Size(88, 16)
        GeburtstagLabel.TabIndex = 14
        GeburtstagLabel.Text = "Geburtstag:"
        '
        'StaatsangehörigkeitLabel
        '
        StaatsangehörigkeitLabel.AutoSize = True
        StaatsangehörigkeitLabel.Location = New System.Drawing.Point(613, 229)
        StaatsangehörigkeitLabel.Name = "StaatsangehörigkeitLabel"
        StaatsangehörigkeitLabel.Size = New System.Drawing.Size(91, 16)
        StaatsangehörigkeitLabel.TabIndex = 16
        StaatsangehörigkeitLabel.Text = "Nationalität:"
        '
        'StandLabel
        '
        StandLabel.AutoSize = True
        StandLabel.Location = New System.Drawing.Point(14, 39)
        StandLabel.Name = "StandLabel"
        StandLabel.Size = New System.Drawing.Size(83, 32)
        StandLabel.TabIndex = 21
        StandLabel.Text = "Bewerber " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "für die 10?:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbStaatsangehörigkeit)
        Me.Panel1.Controls.Add(StaatsangehörigkeitLabel)
        Me.Panel1.Controls.Add(GeburtstagLabel)
        Me.Panel1.Controls.Add(Me.txtGeburtstag)
        Me.Panel1.Controls.Add(RundschreibenLabel)
        Me.Panel1.Controls.Add(Me.cmbRundschreiben)
        Me.Panel1.Controls.Add(InterviewartLabel)
        Me.Panel1.Controls.Add(Me.cmbInterviewart)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(UlasLabel)
        Me.Panel1.Controls.Add(Me.txtUlas)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(VornameLabel)
        Me.Panel1.Controls.Add(Me.txtVorname)
        Me.Panel1.Controls.Add(AnredeLabel)
        Me.Panel1.Controls.Add(Me.cmbAnrede)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1129, 270)
        Me.Panel1.TabIndex = 0
        '
        'cmbStaatsangehörigkeit
        '
        Me.cmbStaatsangehörigkeit.FormattingEnabled = True
        Me.cmbStaatsangehörigkeit.Items.AddRange(New Object() {"deutsch", "belgisch", "britisch", "chinesisch", "französisch", "griechisch", "italienisch", "japanisch", "kroatisch", "niederländisch", "polnisch", "portugiesisch", "russisch", "Kasachstan", "slowakisch", "slowenisch", "spanisch", "tschechisch", "türkisch", "ukrainisch", "ungarisch", "USA"})
        Me.cmbStaatsangehörigkeit.Location = New System.Drawing.Point(792, 226)
        Me.cmbStaatsangehörigkeit.Name = "cmbStaatsangehörigkeit"
        Me.cmbStaatsangehörigkeit.Size = New System.Drawing.Size(206, 24)
        Me.cmbStaatsangehörigkeit.TabIndex = 14
        '
        'txtGeburtstag
        '
        Me.txtGeburtstag.Location = New System.Drawing.Point(143, 226)
        Me.txtGeburtstag.Name = "txtGeburtstag"
        Me.txtGeburtstag.Size = New System.Drawing.Size(213, 22)
        Me.txtGeburtstag.TabIndex = 10
        '
        'cmbRundschreiben
        '
        Me.cmbRundschreiben.FormattingEnabled = True
        Me.cmbRundschreiben.Items.AddRange(New Object() {"Ja", "Nein"})
        Me.cmbRundschreiben.Location = New System.Drawing.Point(792, 182)
        Me.cmbRundschreiben.Name = "cmbRundschreiben"
        Me.cmbRundschreiben.Size = New System.Drawing.Size(206, 24)
        Me.cmbRundschreiben.TabIndex = 13
        '
        'cmbInterviewart
        '
        Me.cmbInterviewart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "interviewart", True))
        Me.cmbInterviewart.FormattingEnabled = True
        Me.cmbInterviewart.Items.AddRange(New Object() {"Telefoninterview", "Videointerview", "Kurzinterview"})
        Me.cmbInterviewart.Location = New System.Drawing.Point(792, 141)
        Me.cmbInterviewart.Name = "cmbInterviewart"
        Me.cmbInterviewart.Size = New System.Drawing.Size(206, 24)
        Me.cmbInterviewart.TabIndex = 12
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(613, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "(Doppelklick zum " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Eintragen)"
        '
        'txtUlas
        '
        Me.txtUlas.BackColor = System.Drawing.Color.LightGreen
        Me.txtUlas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ulas", True))
        Me.txtUlas.Location = New System.Drawing.Point(792, 66)
        Me.txtUlas.Multiline = True
        Me.txtUlas.Name = "txtUlas"
        Me.txtUlas.ReadOnly = True
        Me.txtUlas.Size = New System.Drawing.Size(206, 54)
        Me.txtUlas.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "name", True))
        Me.txtName.Location = New System.Drawing.Point(134, 166)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(402, 22)
        Me.txtName.TabIndex = 9
        '
        'txtVorname
        '
        Me.txtVorname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "vorname", True))
        Me.txtVorname.Location = New System.Drawing.Point(135, 119)
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(402, 22)
        Me.txtVorname.TabIndex = 8
        '
        'cmbAnrede
        '
        Me.cmbAnrede.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "anrede", True))
        Me.cmbAnrede.FormattingEnabled = True
        Me.cmbAnrede.Items.AddRange(New Object() {"", "Herr", "Frau"})
        Me.cmbAnrede.Location = New System.Drawing.Point(134, 66)
        Me.cmbAnrede.Name = "cmbAnrede"
        Me.cmbAnrede.Size = New System.Drawing.Size(121, 24)
        Me.cmbAnrede.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1104, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bitte geben Sie Anrede, Vorname und Name des/r neuen Bewerber/in ein, für den ein" &
    " Kurzprofil angelegt werden soll." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bitte alle Felder ausfüllen, wenn nicht bekan" &
    "nt, 0 oder Leerzeichen eingeben." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'Bew_bewerberdatenBindingSource
        '
        Me.Bew_bewerberdatenBindingSource.DataMember = "bew_bew_bewerberdaten"
        Me.Bew_bewerberdatenBindingSource.DataSource = Me.BewBindingSource
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
        Me.btnNeuerBewerber.Location = New System.Drawing.Point(368, 208)
        Me.btnNeuerBewerber.Name = "btnNeuerBewerber"
        Me.btnNeuerBewerber.Size = New System.Drawing.Size(231, 60)
        Me.btnNeuerBewerber.TabIndex = 21
        Me.btnNeuerBewerber.Text = "            Neue/n Bewerber/in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                   anlegen"
        Me.btnNeuerBewerber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNeuerBewerber.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btnNeuerBewerber)
        Me.Panel2.Location = New System.Drawing.Point(6, 278)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1129, 289)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox4.Controls.Add(Me.cmbStand)
        Me.GroupBox4.Controls.Add(StandLabel)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(7, 193)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 90)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "10 ?"
        '
        'cmbStand
        '
        Me.cmbStand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "stand", True))
        Me.cmbStand.FormattingEnabled = True
        Me.cmbStand.Items.AddRange(New Object() {"", "10"})
        Me.cmbStand.Location = New System.Drawing.Point(136, 39)
        Me.cmbStand.Name = "cmbStand"
        Me.cmbStand.Size = New System.Drawing.Size(92, 24)
        Me.cmbStand.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.txtPlz)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Tel_mobilLabel)
        Me.GroupBox1.Controls.Add(Me.txtTel_mobil)
        Me.GroupBox1.Controls.Add(Tel_festnetzLabel)
        Me.GroupBox1.Controls.Add(Me.txtTel_festnetz)
        Me.GroupBox1.Controls.Add(Me.StrasseTextBox)
        Me.GroupBox1.Controls.Add(StrasseLabel)
        Me.GroupBox1.Controls.Add(OrtLabel)
        Me.GroupBox1.Controls.Add(Me.txtOrt)
        Me.GroupBox1.Controls.Add(PlzLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1099, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kontaktdaten"
        '
        'txtPlz
        '
        Me.txtPlz.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "plz", True))
        Me.txtPlz.Location = New System.Drawing.Point(89, 37)
        Me.txtPlz.Name = "txtPlz"
        Me.txtPlz.Size = New System.Drawing.Size(166, 22)
        Me.txtPlz.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "email", True))
        Me.txtEmail.Location = New System.Drawing.Point(745, 95)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(298, 22)
        Me.txtEmail.TabIndex = 17
        '
        'txtTel_mobil
        '
        Me.txtTel_mobil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "tel_mobil", True))
        Me.txtTel_mobil.Location = New System.Drawing.Point(405, 95)
        Me.txtTel_mobil.Name = "txtTel_mobil"
        Me.txtTel_mobil.Size = New System.Drawing.Size(163, 22)
        Me.txtTel_mobil.TabIndex = 16
        '
        'txtTel_festnetz
        '
        Me.txtTel_festnetz.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "tel_festnetz", True))
        Me.txtTel_festnetz.Location = New System.Drawing.Point(89, 95)
        Me.txtTel_festnetz.Name = "txtTel_festnetz"
        Me.txtTel_festnetz.Size = New System.Drawing.Size(166, 22)
        Me.txtTel_festnetz.TabIndex = 15
        '
        'StrasseTextBox
        '
        Me.StrasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "strasse", True))
        Me.StrasseTextBox.Location = New System.Drawing.Point(745, 34)
        Me.StrasseTextBox.Name = "StrasseTextBox"
        Me.StrasseTextBox.Size = New System.Drawing.Size(298, 22)
        Me.StrasseTextBox.TabIndex = 14
        '
        'txtOrt
        '
        Me.txtOrt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ort", True))
        Me.txtOrt.Location = New System.Drawing.Point(309, 37)
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(255, 22)
        Me.txtOrt.TabIndex = 13
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bew_assistenzTableAdapter = Nothing
        Me.TableAdapterManager.bew_bewerberdatenTableAdapter = Me.Bew_bewerberdatenTableAdapter
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
        Me.TableAdapterManager.rundschreibenmonatTableAdapter = Nothing
        Me.TableAdapterManager.rundschreibenTableAdapter = Nothing
        Me.TableAdapterManager.ulasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmKurzfragebogen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1152, 576)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmKurzfragebogen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kurzfragebogen/Telefoninterview"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bew_bewerberdatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
    Friend WithEvents cmbAnrede As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtVorname As System.Windows.Forms.TextBox
    Friend WithEvents btnNeuerBewerber As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOrt As System.Windows.Forms.TextBox
    Friend WithEvents StrasseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTel_mobil As System.Windows.Forms.TextBox
    Friend WithEvents txtTel_festnetz As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUlas As System.Windows.Forms.TextBox
    Friend WithEvents cmbInterviewart As ComboBox
    Friend WithEvents Bew_bewerberdatenBindingSource As BindingSource
    Friend WithEvents Bew_bewerberdatenTableAdapter As BewerberDataSetTableAdapters.bew_bewerberdatenTableAdapter
    Friend WithEvents cmbRundschreiben As ComboBox
    Friend WithEvents txtGeburtstag As TextBox
    Friend WithEvents TableAdapterManager As BewerberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmbStaatsangehörigkeit As ComboBox
    Friend WithEvents txtPlz As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmbStand As ComboBox
End Class
