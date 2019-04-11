<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRundschreiben
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
        Dim UlasLabel As System.Windows.Forms.Label
        Dim AlterLabel As System.Windows.Forms.Label
        Dim Rundschreiben_anmerkungenLabel As System.Windows.Forms.Label
        Dim RundschreibenLabel As System.Windows.Forms.Label
        Dim RundschreibenreihenfolgeLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim ArbeitsortLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRundschreiben))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RundschreibenGridView = New Telerik.WinControls.UI.RadGridView()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.chkHomepage = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.rbtnNein = New System.Windows.Forms.RadioButton()
        Me.rbtnJa = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRundschreibenreihenfolge = New System.Windows.Forms.TextBox()
        Me.txtRundschreiben_anmerkungen = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAufHomepage = New System.Windows.Forms.CheckBox()
        Me.ArbeitsortTextBox = New System.Windows.Forms.TextBox()
        Me.OrtTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.UlasTextBox = New System.Windows.Forms.TextBox()
        Me.AlterTextBox = New System.Windows.Forms.TextBox()
        Me.AnredeTextBox = New System.Windows.Forms.TextBox()
        Me.RundschreibenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEintraegeloeschen = New Telerik.WinControls.UI.RadButton()
        Me.btndropExport = New Telerik.WinControls.UI.RadDropDownButton()
        Me.InvorhandeneDateiRadMenuItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.NeueDateianlegenRadMenuItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.Tabellebtn = New Telerik.WinControls.UI.RadDropDownButton()
        Me.AufklappenRadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.EinklappenRadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.TableAdapterManager = New bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager()
        Me.RundschreibenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.rundschreibenTableAdapter()
        AnredeLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        UlasLabel = New System.Windows.Forms.Label()
        AlterLabel = New System.Windows.Forms.Label()
        Rundschreiben_anmerkungenLabel = New System.Windows.Forms.Label()
        RundschreibenLabel = New System.Windows.Forms.Label()
        RundschreibenreihenfolgeLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        ArbeitsortLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.RundschreibenGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenGridView.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RundschreibenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEintraegeloeschen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndropExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabellebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnredeLabel
        '
        AnredeLabel.AutoSize = True
        AnredeLabel.ForeColor = System.Drawing.Color.Crimson
        AnredeLabel.Location = New System.Drawing.Point(15, 30)
        AnredeLabel.Name = "AnredeLabel"
        AnredeLabel.Size = New System.Drawing.Size(62, 16)
        AnredeLabel.TabIndex = 0
        AnredeLabel.Text = "Anrede:"
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.ForeColor = System.Drawing.Color.Crimson
        VornameLabel.Location = New System.Drawing.Point(15, 65)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(74, 16)
        VornameLabel.TabIndex = 2
        VornameLabel.Text = "Vorname:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.ForeColor = System.Drawing.Color.Crimson
        NameLabel.Location = New System.Drawing.Point(15, 107)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(86, 16)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Nachname:"
        '
        'UlasLabel
        '
        UlasLabel.AutoSize = True
        UlasLabel.ForeColor = System.Drawing.Color.Crimson
        UlasLabel.Location = New System.Drawing.Point(15, 150)
        UlasLabel.Name = "UlasLabel"
        UlasLabel.Size = New System.Drawing.Size(44, 16)
        UlasLabel.TabIndex = 6
        UlasLabel.Text = "Ulas:"
        '
        'AlterLabel
        '
        AlterLabel.AutoSize = True
        AlterLabel.ForeColor = System.Drawing.Color.Crimson
        AlterLabel.Location = New System.Drawing.Point(15, 224)
        AlterLabel.Name = "AlterLabel"
        AlterLabel.Size = New System.Drawing.Size(44, 16)
        AlterLabel.TabIndex = 8
        AlterLabel.Text = "Alter:"
        '
        'Rundschreiben_anmerkungenLabel
        '
        Rundschreiben_anmerkungenLabel.AutoSize = True
        Rundschreiben_anmerkungenLabel.ForeColor = System.Drawing.Color.Crimson
        Rundschreiben_anmerkungenLabel.Location = New System.Drawing.Point(6, 79)
        Rundschreiben_anmerkungenLabel.Name = "Rundschreiben_anmerkungenLabel"
        Rundschreiben_anmerkungenLabel.Size = New System.Drawing.Size(106, 16)
        Rundschreiben_anmerkungenLabel.TabIndex = 10
        Rundschreiben_anmerkungenLabel.Text = "Anmerkungen:"
        '
        'RundschreibenLabel
        '
        RundschreibenLabel.AutoSize = True
        RundschreibenLabel.ForeColor = System.Drawing.Color.Crimson
        RundschreibenLabel.Location = New System.Drawing.Point(351, 26)
        RundschreibenLabel.Name = "RundschreibenLabel"
        RundschreibenLabel.Size = New System.Drawing.Size(138, 32)
        RundschreibenLabel.TabIndex = 12
        RundschreibenLabel.Text = "Für Rundschreiben" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ausgewählt:"
        '
        'RundschreibenreihenfolgeLabel
        '
        RundschreibenreihenfolgeLabel.AutoSize = True
        RundschreibenreihenfolgeLabel.Location = New System.Drawing.Point(6, 42)
        RundschreibenreihenfolgeLabel.Name = "RundschreibenreihenfolgeLabel"
        RundschreibenreihenfolgeLabel.Size = New System.Drawing.Size(96, 16)
        RundschreibenreihenfolgeLabel.TabIndex = 11
        RundschreibenreihenfolgeLabel.Text = "Reihenfolge:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.ForeColor = System.Drawing.Color.Crimson
        OrtLabel.Location = New System.Drawing.Point(15, 264)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(32, 16)
        OrtLabel.TabIndex = 10
        OrtLabel.Text = "Ort:"
        '
        'ArbeitsortLabel
        '
        ArbeitsortLabel.AutoSize = True
        ArbeitsortLabel.ForeColor = System.Drawing.Color.Crimson
        ArbeitsortLabel.Location = New System.Drawing.Point(15, 314)
        ArbeitsortLabel.Name = "ArbeitsortLabel"
        ArbeitsortLabel.Size = New System.Drawing.Size(79, 16)
        ArbeitsortLabel.TabIndex = 12
        ArbeitsortLabel.Text = "Arbeitsort:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.ForeColor = System.Drawing.Color.Crimson
        Label3.Location = New System.Drawing.Point(15, 347)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(80, 32)
        Label3.TabIndex = 14
        Label3.Text = "Auf Home-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "page:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = System.Drawing.Color.Crimson
        Label4.Location = New System.Drawing.Point(742, 26)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(117, 16)
        Label4.TabIndex = 21
        Label4.Text = "Nur Homepage:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 120)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RundschreibenGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkHomepage)
        Me.SplitContainer1.Panel2.Controls.Add(Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbtnNein)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbtnJa)
        Me.SplitContainer1.Panel2.Controls.Add(RundschreibenLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Size = New System.Drawing.Size(1203, 862)
        Me.SplitContainer1.SplitterDistance = 448
        Me.SplitContainer1.TabIndex = 0
        '
        'RundschreibenGridView
        '
        Me.RundschreibenGridView.BackColor = System.Drawing.Color.White
        Me.RundschreibenGridView.Cursor = System.Windows.Forms.Cursors.Default
        Me.RundschreibenGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RundschreibenGridView.EnableCustomFiltering = True
        Me.RundschreibenGridView.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.RundschreibenGridView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RundschreibenGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RundschreibenGridView.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RundschreibenGridView.MasterTemplate.AllowAddNewRow = False
        Me.RundschreibenGridView.MasterTemplate.AllowColumnReorder = False
        Me.RundschreibenGridView.MasterTemplate.AllowDeleteRow = False
        Me.RundschreibenGridView.MasterTemplate.AllowDragToGroup = False
        Me.RundschreibenGridView.MasterTemplate.AllowEditRow = False
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "id_bew"
        GridViewDecimalColumn1.HeaderText = "id_bew"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.IsVisible = False
        GridViewDecimalColumn1.Name = "id_bew"
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "stand"
        GridViewTextBoxColumn1.HeaderText = "stand"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "stand"
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "status"
        GridViewTextBoxColumn2.HeaderText = "status"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.IsVisible = False
        GridViewTextBoxColumn2.Name = "status"
        GridViewTextBoxColumn3.DataType = GetType(Integer)
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "refnr"
        GridViewTextBoxColumn3.HeaderText = "RefNr"
        GridViewTextBoxColumn3.Name = "refnr"
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "anrede"
        GridViewTextBoxColumn4.HeaderText = "Anrede"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "anrede"
        GridViewTextBoxColumn4.Width = 80
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "vorname"
        GridViewTextBoxColumn5.HeaderText = "Vorname"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.Name = "vorname"
        GridViewTextBoxColumn5.Width = 100
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "name"
        GridViewTextBoxColumn6.HeaderText = "Nachname"
        GridViewTextBoxColumn6.IsAutoGenerated = True
        GridViewTextBoxColumn6.Name = "name"
        GridViewTextBoxColumn6.Width = 150
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "ulas"
        GridViewTextBoxColumn7.HeaderText = "Ulas"
        GridViewTextBoxColumn7.IsAutoGenerated = True
        GridViewTextBoxColumn7.Name = "ulas"
        GridViewDecimalColumn2.DataType = GetType(Integer)
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "alter"
        GridViewDecimalColumn2.HeaderText = "Alter"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.Name = "alter"
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "ort"
        GridViewTextBoxColumn8.HeaderText = "Wohnort"
        GridViewTextBoxColumn8.Name = "ort"
        GridViewTextBoxColumn8.VisibleInColumnChooser = False
        GridViewTextBoxColumn8.Width = 120
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.FieldName = "arbeitsort"
        GridViewTextBoxColumn9.HeaderText = "Arbeitsort"
        GridViewTextBoxColumn9.Name = "arbeitsort"
        GridViewTextBoxColumn9.Width = 120
        GridViewTextBoxColumn10.DataType = GetType(Integer)
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.FieldName = "rundschreibenreihenfolge"
        GridViewTextBoxColumn10.HeaderText = "Reihenfolge"
        GridViewTextBoxColumn10.MinWidth = 100
        GridViewTextBoxColumn10.Name = "rundschreibenreihenfolge"
        GridViewTextBoxColumn10.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn10.Width = 100
        GridViewTextBoxColumn11.EnableExpressionEditor = False
        GridViewTextBoxColumn11.FieldName = "rundschreibenanmerkungen"
        GridViewTextBoxColumn11.HeaderText = "Anmerkungen"
        GridViewTextBoxColumn11.Name = "rundschreibenanmerkungen"
        GridViewTextBoxColumn11.Width = 350
        Me.RundschreibenGridView.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewDecimalColumn2, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11})
        Me.RundschreibenGridView.MasterTemplate.DataSource = Me.BewBindingSource
        Me.RundschreibenGridView.MasterTemplate.EnableCustomFiltering = True
        Me.RundschreibenGridView.MasterTemplate.EnableFiltering = True
        SortDescriptor1.PropertyName = "rundschreibenreihenfolge"
        Me.RundschreibenGridView.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.RundschreibenGridView.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RundschreibenGridView.Name = "RundschreibenGridView"
        Me.RundschreibenGridView.ReadOnly = True
        Me.RundschreibenGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RundschreibenGridView.Size = New System.Drawing.Size(1201, 446)
        Me.RundschreibenGridView.TabIndex = 0
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
        'chkHomepage
        '
        Me.chkHomepage.AutoSize = True
        Me.chkHomepage.Location = New System.Drawing.Point(874, 28)
        Me.chkHomepage.Name = "chkHomepage"
        Me.chkHomepage.Size = New System.Drawing.Size(15, 14)
        Me.chkHomepage.TabIndex = 22
        Me.chkHomepage.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox3.Location = New System.Drawing.Point(354, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(605, 148)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bereits in Rundschreiben angeboten:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(7, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(556, 116)
        Me.ListBox1.TabIndex = 0
        '
        'rbtnNein
        '
        Me.rbtnNein.AutoSize = True
        Me.rbtnNein.ForeColor = System.Drawing.Color.Crimson
        Me.rbtnNein.Location = New System.Drawing.Point(632, 24)
        Me.rbtnNein.Name = "rbtnNein"
        Me.rbtnNein.Size = New System.Drawing.Size(58, 20)
        Me.rbtnNein.TabIndex = 19
        Me.rbtnNein.TabStop = True
        Me.rbtnNein.Text = "Nein"
        Me.rbtnNein.UseVisualStyleBackColor = True
        '
        'rbtnJa
        '
        Me.rbtnJa.AutoSize = True
        Me.rbtnJa.ForeColor = System.Drawing.Color.Crimson
        Me.rbtnJa.Location = New System.Drawing.Point(574, 24)
        Me.rbtnJa.Name = "rbtnJa"
        Me.rbtnJa.Size = New System.Drawing.Size(43, 20)
        Me.rbtnJa.TabIndex = 18
        Me.rbtnJa.TabStop = True
        Me.rbtnJa.Text = "Ja"
        Me.rbtnJa.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(RundschreibenreihenfolgeLabel)
        Me.GroupBox2.Controls.Add(Me.txtRundschreibenreihenfolge)
        Me.GroupBox2.Controls.Add(Rundschreiben_anmerkungenLabel)
        Me.GroupBox2.Controls.Add(Me.txtRundschreiben_anmerkungen)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Location = New System.Drawing.Point(354, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 187)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bitte ausfüllen:"
        '
        'txtRundschreibenreihenfolge
        '
        Me.txtRundschreibenreihenfolge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "rundschreibenreihenfolge", True))
        Me.txtRundschreibenreihenfolge.Location = New System.Drawing.Point(220, 39)
        Me.txtRundschreibenreihenfolge.Name = "txtRundschreibenreihenfolge"
        Me.txtRundschreibenreihenfolge.Size = New System.Drawing.Size(100, 22)
        Me.txtRundschreibenreihenfolge.TabIndex = 12
        '
        'txtRundschreiben_anmerkungen
        '
        Me.txtRundschreiben_anmerkungen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "rundschreibenanmerkungen", True))
        Me.txtRundschreiben_anmerkungen.Location = New System.Drawing.Point(220, 79)
        Me.txtRundschreiben_anmerkungen.Multiline = True
        Me.txtRundschreiben_anmerkungen.Name = "txtRundschreiben_anmerkungen"
        Me.txtRundschreiben_anmerkungen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRundschreiben_anmerkungen.Size = New System.Drawing.Size(315, 88)
        Me.txtRundschreiben_anmerkungen.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAufHomepage)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(ArbeitsortLabel)
        Me.GroupBox1.Controls.Add(Me.ArbeitsortTextBox)
        Me.GroupBox1.Controls.Add(OrtLabel)
        Me.GroupBox1.Controls.Add(Me.OrtTextBox)
        Me.GroupBox1.Controls.Add(AnredeLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(VornameLabel)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(AlterLabel)
        Me.GroupBox1.Controls.Add(Me.VornameTextBox)
        Me.GroupBox1.Controls.Add(Me.UlasTextBox)
        Me.GroupBox1.Controls.Add(Me.AlterTextBox)
        Me.GroupBox1.Controls.Add(Me.AnredeTextBox)
        Me.GroupBox1.Controls.Add(UlasLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 389)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'chkAufHomepage
        '
        Me.chkAufHomepage.AutoSize = True
        Me.chkAufHomepage.Location = New System.Drawing.Point(111, 347)
        Me.chkAufHomepage.Name = "chkAufHomepage"
        Me.chkAufHomepage.Size = New System.Drawing.Size(44, 20)
        Me.chkAufHomepage.TabIndex = 15
        Me.chkAufHomepage.Text = "Ja"
        Me.chkAufHomepage.UseVisualStyleBackColor = True
        '
        'ArbeitsortTextBox
        '
        Me.ArbeitsortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "arbeitsort", True))
        Me.ArbeitsortTextBox.Location = New System.Drawing.Point(111, 311)
        Me.ArbeitsortTextBox.Name = "ArbeitsortTextBox"
        Me.ArbeitsortTextBox.Size = New System.Drawing.Size(186, 22)
        Me.ArbeitsortTextBox.TabIndex = 13
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(111, 261)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(186, 22)
        Me.OrtTextBox.TabIndex = 11
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(111, 104)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(186, 22)
        Me.NameTextBox.TabIndex = 5
        '
        'VornameTextBox
        '
        Me.VornameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "vorname", True))
        Me.VornameTextBox.Location = New System.Drawing.Point(111, 62)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.Size = New System.Drawing.Size(186, 22)
        Me.VornameTextBox.TabIndex = 3
        '
        'UlasTextBox
        '
        Me.UlasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ulas", True))
        Me.UlasTextBox.Location = New System.Drawing.Point(111, 147)
        Me.UlasTextBox.Multiline = True
        Me.UlasTextBox.Name = "UlasTextBox"
        Me.UlasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UlasTextBox.Size = New System.Drawing.Size(100, 48)
        Me.UlasTextBox.TabIndex = 7
        '
        'AlterTextBox
        '
        Me.AlterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "alter", True))
        Me.AlterTextBox.Location = New System.Drawing.Point(111, 221)
        Me.AlterTextBox.Name = "AlterTextBox"
        Me.AlterTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AlterTextBox.TabIndex = 9
        '
        'AnredeTextBox
        '
        Me.AnredeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "anrede", True))
        Me.AnredeTextBox.Location = New System.Drawing.Point(111, 27)
        Me.AnredeTextBox.Name = "AnredeTextBox"
        Me.AnredeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AnredeTextBox.TabIndex = 1
        '
        'RundschreibenBindingSource
        '
        Me.RundschreibenBindingSource.DataMember = "bew_rundschreiben"
        Me.RundschreibenBindingSource.DataSource = Me.BewBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ausgewählte Bewerber/innen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "für das Kundenrundschreiben"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnEintraegeloeschen
        '
        Me.btnEintraegeloeschen.ForeColor = System.Drawing.Color.Red
        Me.btnEintraegeloeschen.Image = CType(resources.GetObject("btnEintraegeloeschen.Image"), System.Drawing.Image)
        Me.btnEintraegeloeschen.Location = New System.Drawing.Point(437, 13)
        Me.btnEintraegeloeschen.Name = "btnEintraegeloeschen"
        Me.btnEintraegeloeschen.Size = New System.Drawing.Size(163, 37)
        Me.btnEintraegeloeschen.TabIndex = 10
        Me.btnEintraegeloeschen.Text = "<html><strong>   Monatsauswahl <br/>löschen>/strong></html>"
        Me.ToolTip1.SetToolTip(Me.btnEintraegeloeschen, "Auswahl der Bewerber und Bewerberinnen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "des aktuelllen Rundschreibens " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in die f" &
        "ortlaufende Liste übertragen")
        '
        'btndropExport
        '
        Me.btndropExport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btndropExport.ForeColor = System.Drawing.Color.Red
        Me.btndropExport.Image = CType(resources.GetObject("btndropExport.Image"), System.Drawing.Image)
        Me.btndropExport.Items.AddRange(New Telerik.WinControls.RadItem() {Me.InvorhandeneDateiRadMenuItem, Me.NeueDateianlegenRadMenuItem})
        Me.btndropExport.Location = New System.Drawing.Point(624, 13)
        Me.btndropExport.Name = "btndropExport"
        Me.btndropExport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btndropExport.Size = New System.Drawing.Size(163, 37)
        Me.btndropExport.TabIndex = 8
        Me.btndropExport.Text = "<html><span style=""font-size: 9pt"">In Excel <br />speichern</span></html>"
        CType(Me.btndropExport.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.btndropExport.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Text = "<html><span style=""font-size: 9pt"">In Excel <br />speichern</span></html>"
        CType(Me.btndropExport.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        CType(Me.btndropExport.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).CanFocus = True
        CType(Me.btndropExport.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
        CType(Me.btndropExport.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.Red
        CType(Me.btndropExport.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        CType(Me.btndropExport.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InvorhandeneDateiRadMenuItem
        '
        Me.InvorhandeneDateiRadMenuItem.Alignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.InvorhandeneDateiRadMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvorhandeneDateiRadMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InvorhandeneDateiRadMenuItem.Image = Nothing
        Me.InvorhandeneDateiRadMenuItem.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.InvorhandeneDateiRadMenuItem.Name = "InvorhandeneDateiRadMenuItem"
        Me.InvorhandeneDateiRadMenuItem.Padding = New System.Windows.Forms.Padding(10, 3, 5, 3)
        Me.InvorhandeneDateiRadMenuItem.Text = "In vorhandene " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exceldatei einfügen "
        Me.InvorhandeneDateiRadMenuItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.InvorhandeneDateiRadMenuItem.UseCompatibleTextRendering = False
        '
        'NeueDateianlegenRadMenuItem
        '
        Me.NeueDateianlegenRadMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NeueDateianlegenRadMenuItem.Image = Nothing
        Me.NeueDateianlegenRadMenuItem.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.NeueDateianlegenRadMenuItem.Name = "NeueDateianlegenRadMenuItem"
        Me.NeueDateianlegenRadMenuItem.Text = "   Neue Exceldatei anlegen"
        Me.NeueDateianlegenRadMenuItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.NeueDateianlegenRadMenuItem.UseCompatibleTextRendering = False
        '
        'btnSave
        '
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(256, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(163, 37)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "<html><strong>Speichern>/strong></html>"
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1048, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(163, 37)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "<html><strong>   Fenster schließen>/strong></html>"
        '
        'Tabellebtn
        '
        Me.Tabellebtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tabellebtn.ForeColor = System.Drawing.Color.Red
        Me.Tabellebtn.Image = CType(resources.GetObject("Tabellebtn.Image"), System.Drawing.Image)
        Me.Tabellebtn.Items.AddRange(New Telerik.WinControls.RadItem() {Me.AufklappenRadMenuItem1, Me.EinklappenRadMenuItem1})
        Me.Tabellebtn.Location = New System.Drawing.Point(869, 13)
        Me.Tabellebtn.Name = "Tabellebtn"
        Me.Tabellebtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Tabellebtn.Size = New System.Drawing.Size(163, 37)
        Me.Tabellebtn.TabIndex = 81
        Me.Tabellebtn.Text = "<html><span style=""font-size: 9pt"">Tabelle...</span></html>"
        CType(Me.Tabellebtn.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.Tabellebtn.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Text = "<html><span style=""font-size: 9pt"">Tabelle...</span></html>"
        CType(Me.Tabellebtn.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        CType(Me.Tabellebtn.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).CanFocus = True
        CType(Me.Tabellebtn.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
        CType(Me.Tabellebtn.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.Red
        CType(Me.Tabellebtn.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        CType(Me.Tabellebtn.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AufklappenRadMenuItem1
        '
        Me.AufklappenRadMenuItem1.Alignment = System.Drawing.ContentAlignment.MiddleRight
        Me.AufklappenRadMenuItem1.DescriptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AufklappenRadMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AufklappenRadMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AufklappenRadMenuItem1.Image = Nothing
        Me.AufklappenRadMenuItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.AufklappenRadMenuItem1.Name = "AufklappenRadMenuItem1"
        Me.AufklappenRadMenuItem1.Padding = New System.Windows.Forms.Padding(10, 3, 5, 3)
        Me.AufklappenRadMenuItem1.Text = "    Aufklappen"
        Me.AufklappenRadMenuItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.AufklappenRadMenuItem1.UseCompatibleTextRendering = False
        '
        'EinklappenRadMenuItem1
        '
        Me.EinklappenRadMenuItem1.DescriptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EinklappenRadMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EinklappenRadMenuItem1.Image = Nothing
        Me.EinklappenRadMenuItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.EinklappenRadMenuItem1.Name = "EinklappenRadMenuItem1"
        Me.EinklappenRadMenuItem1.Text = "      Einklappen"
        Me.EinklappenRadMenuItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.EinklappenRadMenuItem1.UseCompatibleTextRendering = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(759, 54)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Die Bewerber bzw. Bewerberinnen müssen in der Tabelle mit der Maus angeklickt w" &
    "erden!"
        '
        'BewTableAdapter
        '
        Me.BewTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.rundschreibenmonatTableAdapter = Nothing
        Me.TableAdapterManager.rundschreibenTableAdapter = Nothing
        Me.TableAdapterManager.ulasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RundschreibenTableAdapter
        '
        Me.RundschreibenTableAdapter.ClearBeforeFill = True
        '
        'frmRundschreiben
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1216, 987)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tabellebtn)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEintraegeloeschen)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btndropExport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmRundschreiben"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bewerber/innen für Rundschreiben"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.RundschreibenGridView.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RundschreibenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEintraegeloeschen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndropExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabellebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BewerberDataSet As bewerberpool.BewerberDataSet
    Friend WithEvents BewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BewTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter
    Friend WithEvents RundschreibenGridView As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtRundschreiben_anmerkungen As System.Windows.Forms.TextBox
    Friend WithEvents AlterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VornameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnredeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btndropExport As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents InvorhandeneDateiRadMenuItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents NeueDateianlegenRadMenuItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEintraegeloeschen As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableAdapterManager As bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtRundschreibenreihenfolge As System.Windows.Forms.TextBox
    Friend WithEvents ArbeitsortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rbtnNein As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnJa As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Tabellebtn As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents AufklappenRadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents EinklappenRadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents chkAufHomepage As CheckBox
    Friend WithEvents RundschreibenBindingSource As BindingSource
    Friend WithEvents RundschreibenTableAdapter As BewerberDataSetTableAdapters.rundschreibenTableAdapter
    Friend WithEvents chkHomepage As CheckBox
End Class
