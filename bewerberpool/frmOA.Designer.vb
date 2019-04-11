<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOA
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
        Dim Oa_arbeitsortLabel As System.Windows.Forms.Label
        Dim Oa_arbeitszeitLabel As System.Windows.Forms.Label
        Dim Oa_zavmLabel As System.Windows.Forms.Label
        Dim Oa_plzLabel As System.Windows.Forms.Label
        Dim Oa_geheimLabel As System.Windows.Forms.Label
        Dim Oa_qualifikationLabel As System.Windows.Forms.Label
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn17 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn18 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn19 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn20 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn21 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn22 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn23 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn24 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn25 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn26 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn27 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn28 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOA))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadRTEhtml = New Telerik.WinControls.UI.RadRichTextEditor()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Oa_geheimTextBox = New System.Windows.Forms.TextBox()
        Me.Oa_stelleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OaDataSet = New bewerberpool.oaDataSet()
        Me.Oa_arbeitsortTextBox = New System.Windows.Forms.TextBox()
        Me.Oa_arbeitszeitTextBox = New System.Windows.Forms.TextBox()
        Me.Oa_plzTextBox = New System.Windows.Forms.TextBox()
        Me.Oa_zavmTextBox = New System.Windows.Forms.TextBox()
        Me.Oa_qualifikationTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.OAGridView = New Telerik.WinControls.UI.RadGridView()
        Me.Oa_stelleTableAdapter = New bewerberpool.oaDataSetTableAdapters.oa_stelleTableAdapter()
        Me.btneintragloeschen = New Telerik.WinControls.UI.RadButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCloseandDelete = New Telerik.WinControls.UI.RadButton()
        Me.btnWerteeintragenFensterschliessen = New Telerik.WinControls.UI.RadButton()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Oa_arbeitsortLabel = New System.Windows.Forms.Label()
        Oa_arbeitszeitLabel = New System.Windows.Forms.Label()
        Oa_zavmLabel = New System.Windows.Forms.Label()
        Oa_plzLabel = New System.Windows.Forms.Label()
        Oa_geheimLabel = New System.Windows.Forms.Label()
        Oa_qualifikationLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.RadRTEhtml, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Oa_stelleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OAGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OAGridView.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btneintragloeschen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseandDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnWerteeintragenFensterschliessen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Oa_arbeitsortLabel
        '
        Oa_arbeitsortLabel.AutoSize = True
        Oa_arbeitsortLabel.Location = New System.Drawing.Point(19, 11)
        Oa_arbeitsortLabel.Name = "Oa_arbeitsortLabel"
        Oa_arbeitsortLabel.Size = New System.Drawing.Size(79, 16)
        Oa_arbeitsortLabel.TabIndex = 2
        Oa_arbeitsortLabel.Text = "Arbeitsort:"
        '
        'Oa_arbeitszeitLabel
        '
        Oa_arbeitszeitLabel.AutoSize = True
        Oa_arbeitszeitLabel.Location = New System.Drawing.Point(19, 78)
        Oa_arbeitszeitLabel.Name = "Oa_arbeitszeitLabel"
        Oa_arbeitszeitLabel.Size = New System.Drawing.Size(85, 16)
        Oa_arbeitszeitLabel.TabIndex = 4
        Oa_arbeitszeitLabel.Text = "Arbeitszeit:"
        '
        'Oa_zavmLabel
        '
        Oa_zavmLabel.AutoSize = True
        Oa_zavmLabel.Location = New System.Drawing.Point(19, 109)
        Oa_zavmLabel.Name = "Oa_zavmLabel"
        Oa_zavmLabel.Size = New System.Drawing.Size(58, 16)
        Oa_zavmLabel.TabIndex = 6
        Oa_zavmLabel.Text = "ZA/VM:"
        '
        'Oa_plzLabel
        '
        Oa_plzLabel.AutoSize = True
        Oa_plzLabel.Location = New System.Drawing.Point(19, 44)
        Oa_plzLabel.Name = "Oa_plzLabel"
        Oa_plzLabel.Size = New System.Drawing.Size(39, 16)
        Oa_plzLabel.TabIndex = 8
        Oa_plzLabel.Text = "PLZ:"
        '
        'Oa_geheimLabel
        '
        Oa_geheimLabel.AutoSize = True
        Oa_geheimLabel.Location = New System.Drawing.Point(19, 219)
        Oa_geheimLabel.Name = "Oa_geheimLabel"
        Oa_geheimLabel.Size = New System.Drawing.Size(81, 32)
        Oa_geheimLabel.TabIndex = 10
        Oa_geheimLabel.Text = "Nur für uns" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bestimmt:"
        '
        'Oa_qualifikationLabel
        '
        Oa_qualifikationLabel.AutoSize = True
        Oa_qualifikationLabel.Location = New System.Drawing.Point(19, 139)
        Oa_qualifikationLabel.Name = "Oa_qualifikationLabel"
        Oa_qualifikationLabel.Size = New System.Drawing.Size(98, 16)
        Oa_qualifikationLabel.TabIndex = 12
        Oa_qualifikationLabel.Text = "Qualifikation:"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadRTEhtml)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Crimson
        Me.Panel1.Location = New System.Drawing.Point(9, 315)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1217, 336)
        Me.Panel1.TabIndex = 0
        '
        'RadRTEhtml
        '
        Me.RadRTEhtml.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RadRTEhtml.IsReadOnly = True
        Me.RadRTEhtml.Location = New System.Drawing.Point(598, 30)
        Me.RadRTEhtml.Name = "RadRTEhtml"
        Me.RadRTEhtml.SelectionFill = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadRTEhtml.Size = New System.Drawing.Size(608, 297)
        Me.RadRTEhtml.TabIndex = 14
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(7, 37)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(281, 164)
        Me.ListBox1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Oa_geheimTextBox)
        Me.GroupBox2.Controls.Add(Oa_geheimLabel)
        Me.GroupBox2.Controls.Add(Oa_arbeitsortLabel)
        Me.GroupBox2.Controls.Add(Me.Oa_arbeitsortTextBox)
        Me.GroupBox2.Controls.Add(Oa_plzLabel)
        Me.GroupBox2.Controls.Add(Me.Oa_arbeitszeitTextBox)
        Me.GroupBox2.Controls.Add(Me.Oa_plzTextBox)
        Me.GroupBox2.Controls.Add(Oa_qualifikationLabel)
        Me.GroupBox2.Controls.Add(Oa_zavmLabel)
        Me.GroupBox2.Controls.Add(Oa_arbeitszeitLabel)
        Me.GroupBox2.Controls.Add(Me.Oa_zavmTextBox)
        Me.GroupBox2.Controls.Add(Me.Oa_qualifikationTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 308)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'Oa_geheimTextBox
        '
        Me.Oa_geheimTextBox.BackColor = System.Drawing.Color.Yellow
        Me.Oa_geheimTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Oa_stelleBindingSource, "oa_geheim", True))
        Me.Oa_geheimTextBox.Location = New System.Drawing.Point(136, 216)
        Me.Oa_geheimTextBox.Multiline = True
        Me.Oa_geheimTextBox.Name = "Oa_geheimTextBox"
        Me.Oa_geheimTextBox.ReadOnly = True
        Me.Oa_geheimTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Oa_geheimTextBox.Size = New System.Drawing.Size(442, 83)
        Me.Oa_geheimTextBox.TabIndex = 11
        '
        'Oa_stelleBindingSource
        '
        Me.Oa_stelleBindingSource.DataMember = "oa_stelle"
        Me.Oa_stelleBindingSource.DataSource = Me.OaDataSet
        '
        'OaDataSet
        '
        Me.OaDataSet.DataSetName = "oaDataSet"
        Me.OaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Oa_arbeitsortTextBox
        '
        Me.Oa_arbeitsortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Oa_stelleBindingSource, "oa_arbeitsort", True))
        Me.Oa_arbeitsortTextBox.Location = New System.Drawing.Point(136, 11)
        Me.Oa_arbeitsortTextBox.Name = "Oa_arbeitsortTextBox"
        Me.Oa_arbeitsortTextBox.ReadOnly = True
        Me.Oa_arbeitsortTextBox.Size = New System.Drawing.Size(181, 22)
        Me.Oa_arbeitsortTextBox.TabIndex = 3
        '
        'Oa_arbeitszeitTextBox
        '
        Me.Oa_arbeitszeitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Oa_stelleBindingSource, "oa_arbeitszeit", True))
        Me.Oa_arbeitszeitTextBox.Location = New System.Drawing.Point(136, 75)
        Me.Oa_arbeitszeitTextBox.Name = "Oa_arbeitszeitTextBox"
        Me.Oa_arbeitszeitTextBox.ReadOnly = True
        Me.Oa_arbeitszeitTextBox.Size = New System.Drawing.Size(181, 22)
        Me.Oa_arbeitszeitTextBox.TabIndex = 5
        '
        'Oa_plzTextBox
        '
        Me.Oa_plzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Oa_stelleBindingSource, "oa_plz", True))
        Me.Oa_plzTextBox.Location = New System.Drawing.Point(136, 41)
        Me.Oa_plzTextBox.Name = "Oa_plzTextBox"
        Me.Oa_plzTextBox.ReadOnly = True
        Me.Oa_plzTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Oa_plzTextBox.TabIndex = 9
        '
        'Oa_zavmTextBox
        '
        Me.Oa_zavmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Oa_stelleBindingSource, "oa_zavm", True))
        Me.Oa_zavmTextBox.Location = New System.Drawing.Point(136, 106)
        Me.Oa_zavmTextBox.Name = "Oa_zavmTextBox"
        Me.Oa_zavmTextBox.ReadOnly = True
        Me.Oa_zavmTextBox.Size = New System.Drawing.Size(181, 22)
        Me.Oa_zavmTextBox.TabIndex = 7
        '
        'Oa_qualifikationTextBox
        '
        Me.Oa_qualifikationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Oa_stelleBindingSource, "oa_qualifikation", True))
        Me.Oa_qualifikationTextBox.Location = New System.Drawing.Point(136, 136)
        Me.Oa_qualifikationTextBox.Multiline = True
        Me.Oa_qualifikationTextBox.Name = "Oa_qualifikationTextBox"
        Me.Oa_qualifikationTextBox.ReadOnly = True
        Me.Oa_qualifikationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Oa_qualifikationTextBox.Size = New System.Drawing.Size(442, 74)
        Me.Oa_qualifikationTextBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Stellendaten:"
        '
        'BewerberDataSet
        '
        Me.BewerberDataSet.DataSetName = "BewerberDataSet"
        Me.BewerberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OAGridView
        '
        Me.OAGridView.AutoSizeRows = True
        Me.OAGridView.BackColor = System.Drawing.Color.White
        Me.OAGridView.Cursor = System.Windows.Forms.Cursors.Default
        Me.OAGridView.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.OAGridView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OAGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OAGridView.Location = New System.Drawing.Point(9, 95)
        '
        '
        '
        Me.OAGridView.MasterTemplate.AllowAddNewRow = False
        Me.OAGridView.MasterTemplate.AllowColumnChooser = False
        Me.OAGridView.MasterTemplate.AllowDragToGroup = False
        Me.OAGridView.MasterTemplate.AllowEditRow = False
        GridViewDecimalColumn3.DataType = GetType(Integer)
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "oastelleID"
        GridViewDecimalColumn3.HeaderText = "oastelleID"
        GridViewDecimalColumn3.IsAutoGenerated = True
        GridViewDecimalColumn3.IsVisible = False
        GridViewDecimalColumn3.Name = "oastelleID"
        GridViewTextBoxColumn15.EnableExpressionEditor = False
        GridViewTextBoxColumn15.FieldName = "oa_status"
        GridViewTextBoxColumn15.HeaderText = "oa_status"
        GridViewTextBoxColumn15.IsAutoGenerated = True
        GridViewTextBoxColumn15.IsVisible = False
        GridViewTextBoxColumn15.Name = "oa_status"
        GridViewTextBoxColumn16.EnableExpressionEditor = False
        GridViewTextBoxColumn16.FieldName = "oa_kunde"
        GridViewTextBoxColumn16.HeaderText = "Kunde"
        GridViewTextBoxColumn16.IsAutoGenerated = True
        GridViewTextBoxColumn16.MinWidth = 100
        GridViewTextBoxColumn16.Name = "oa_kunde"
        GridViewTextBoxColumn16.Width = 200
        GridViewDecimalColumn4.DataType = GetType(Short)
        GridViewDecimalColumn4.EnableExpressionEditor = False
        GridViewDecimalColumn4.FieldName = "oa_referenznummer"
        GridViewDecimalColumn4.HeaderText = "RefNr"
        GridViewDecimalColumn4.IsAutoGenerated = True
        GridViewDecimalColumn4.Name = "oa_referenznummer"
        GridViewDecimalColumn4.VisibleInColumnChooser = False
        GridViewDecimalColumn4.Width = 83
        GridViewTextBoxColumn17.EnableExpressionEditor = False
        GridViewTextBoxColumn17.FieldName = "oa_ueberschrift"
        GridViewTextBoxColumn17.HeaderText = "Auftragsbeschreibung"
        GridViewTextBoxColumn17.IsAutoGenerated = True
        GridViewTextBoxColumn17.Name = "oa_ueberschrift"
        GridViewTextBoxColumn17.Width = 380
        GridViewTextBoxColumn18.EnableExpressionEditor = False
        GridViewTextBoxColumn18.FieldName = "oa_plz"
        GridViewTextBoxColumn18.HeaderText = "oa_plz"
        GridViewTextBoxColumn18.IsAutoGenerated = True
        GridViewTextBoxColumn18.IsVisible = False
        GridViewTextBoxColumn18.Name = "oa_plz"
        GridViewTextBoxColumn19.EnableExpressionEditor = False
        GridViewTextBoxColumn19.FieldName = "oa_arbeitsort"
        GridViewTextBoxColumn19.HeaderText = "Arbeitsort"
        GridViewTextBoxColumn19.IsAutoGenerated = True
        GridViewTextBoxColumn19.IsVisible = False
        GridViewTextBoxColumn19.Name = "oa_arbeitsort"
        GridViewTextBoxColumn19.Width = 83
        GridViewTextBoxColumn20.EnableExpressionEditor = False
        GridViewTextBoxColumn20.FieldName = "oa_qualifikation"
        GridViewTextBoxColumn20.HeaderText = "oa_qualifikation"
        GridViewTextBoxColumn20.IsAutoGenerated = True
        GridViewTextBoxColumn20.IsVisible = False
        GridViewTextBoxColumn20.Name = "oa_qualifikation"
        GridViewTextBoxColumn21.EnableExpressionEditor = False
        GridViewTextBoxColumn21.FieldName = "oa_text"
        GridViewTextBoxColumn21.HeaderText = "oa_text"
        GridViewTextBoxColumn21.IsAutoGenerated = True
        GridViewTextBoxColumn21.IsVisible = False
        GridViewTextBoxColumn21.Name = "oa_text"
        GridViewTextBoxColumn22.EnableExpressionEditor = False
        GridViewTextBoxColumn22.FieldName = "oa_texthtml"
        GridViewTextBoxColumn22.HeaderText = "oa_texthtml"
        GridViewTextBoxColumn22.IsAutoGenerated = True
        GridViewTextBoxColumn22.IsVisible = False
        GridViewTextBoxColumn22.Name = "oa_texthtml"
        GridViewTextBoxColumn23.EnableExpressionEditor = False
        GridViewTextBoxColumn23.FieldName = "oa_geheim"
        GridViewTextBoxColumn23.HeaderText = "oa_geheim"
        GridViewTextBoxColumn23.IsAutoGenerated = True
        GridViewTextBoxColumn23.IsVisible = False
        GridViewTextBoxColumn23.Name = "oa_geheim"
        GridViewTextBoxColumn24.EnableExpressionEditor = False
        GridViewTextBoxColumn24.FieldName = "oa_zavm"
        GridViewTextBoxColumn24.HeaderText = "ZA/VM"
        GridViewTextBoxColumn24.IsAutoGenerated = True
        GridViewTextBoxColumn24.IsVisible = False
        GridViewTextBoxColumn24.Name = "oa_zavm"
        GridViewTextBoxColumn24.Width = 83
        GridViewTextBoxColumn25.EnableExpressionEditor = False
        GridViewTextBoxColumn25.FieldName = "oa_stand_aktuell"
        GridViewTextBoxColumn25.HeaderText = "oa_stand_aktuell"
        GridViewTextBoxColumn25.IsAutoGenerated = True
        GridViewTextBoxColumn25.IsVisible = False
        GridViewTextBoxColumn25.Name = "oa_stand_aktuell"
        GridViewTextBoxColumn26.EnableExpressionEditor = False
        GridViewTextBoxColumn26.FieldName = "oa_link"
        GridViewTextBoxColumn26.HeaderText = "oa_link"
        GridViewTextBoxColumn26.IsAutoGenerated = True
        GridViewTextBoxColumn26.IsVisible = False
        GridViewTextBoxColumn26.Name = "oa_link"
        GridViewTextBoxColumn27.EnableExpressionEditor = False
        GridViewTextBoxColumn27.FieldName = "oa_arbeitszeit"
        GridViewTextBoxColumn27.HeaderText = "Arbeitszeit"
        GridViewTextBoxColumn27.IsAutoGenerated = True
        GridViewTextBoxColumn27.IsVisible = False
        GridViewTextBoxColumn27.Name = "oa_arbeitszeit"
        GridViewTextBoxColumn27.Width = 82
        GridViewTextBoxColumn28.EnableExpressionEditor = False
        GridViewTextBoxColumn28.FieldName = "oa_rtf_text"
        GridViewTextBoxColumn28.HeaderText = "oa_rtf_text"
        GridViewTextBoxColumn28.IsAutoGenerated = True
        GridViewTextBoxColumn28.IsVisible = False
        GridViewTextBoxColumn28.Name = "oa_rtf_text"
        Me.OAGridView.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn3, GridViewTextBoxColumn15, GridViewTextBoxColumn16, GridViewDecimalColumn4, GridViewTextBoxColumn17, GridViewTextBoxColumn18, GridViewTextBoxColumn19, GridViewTextBoxColumn20, GridViewTextBoxColumn21, GridViewTextBoxColumn22, GridViewTextBoxColumn23, GridViewTextBoxColumn24, GridViewTextBoxColumn25, GridViewTextBoxColumn26, GridViewTextBoxColumn27, GridViewTextBoxColumn28})
        Me.OAGridView.MasterTemplate.DataSource = Me.Oa_stelleBindingSource
        Me.OAGridView.MasterTemplate.EnableFiltering = True
        Me.OAGridView.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.OAGridView.Name = "OAGridView"
        Me.OAGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OAGridView.Size = New System.Drawing.Size(696, 214)
        Me.OAGridView.TabIndex = 0
        '
        'Oa_stelleTableAdapter
        '
        Me.Oa_stelleTableAdapter.ClearBeforeFill = True
        '
        'btneintragloeschen
        '
        Me.btneintragloeschen.ForeColor = System.Drawing.Color.Red
        Me.btneintragloeschen.Image = CType(resources.GetObject("btneintragloeschen.Image"), System.Drawing.Image)
        Me.btneintragloeschen.Location = New System.Drawing.Point(294, 38)
        Me.btneintragloeschen.Name = "btneintragloeschen"
        Me.btneintragloeschen.Size = New System.Drawing.Size(131, 37)
        Me.btneintragloeschen.TabIndex = 5
        Me.btneintragloeschen.Text = "<html><strong>      Stelle nicht<br /></strong><strong>      mehr auswählen</stro" &
    "ng></html>"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1220, 46)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Um eine Stelle auszuwählen, für die der Bewerber/die Bewerberin in Frage kommt: D" &
    "oppelklick auf einen Tabelleneintrag" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnCloseandDelete
        '
        Me.btnCloseandDelete.ForeColor = System.Drawing.Color.Red
        Me.btnCloseandDelete.Image = CType(resources.GetObject("btnCloseandDelete.Image"), System.Drawing.Image)
        Me.btnCloseandDelete.Location = New System.Drawing.Point(294, 164)
        Me.btnCloseandDelete.Name = "btnCloseandDelete"
        Me.btnCloseandDelete.Size = New System.Drawing.Size(131, 37)
        Me.btnCloseandDelete.TabIndex = 7
        Me.btnCloseandDelete.Text = "<html><strong>      Fenster schließen<br />       nichts eintragen</strong> </htm" &
    "l>"
        '
        'btnWerteeintragenFensterschliessen
        '
        Me.btnWerteeintragenFensterschliessen.ForeColor = System.Drawing.Color.Red
        Me.btnWerteeintragenFensterschliessen.Image = CType(resources.GetObject("btnWerteeintragenFensterschliessen.Image"), System.Drawing.Image)
        Me.btnWerteeintragenFensterschliessen.Location = New System.Drawing.Point(294, 102)
        Me.btnWerteeintragenFensterschliessen.Name = "btnWerteeintragenFensterschliessen"
        Me.btnWerteeintragenFensterschliessen.Size = New System.Drawing.Size(131, 37)
        Me.btnWerteeintragenFensterschliessen.TabIndex = 8
        Me.btnWerteeintragenFensterschliessen.Text = "<html><strong>      Fenster schließen, <br /></strong><strong>   Stellen eintrage" &
    "n</strong></html>"
        '
        'BewBindingSource
        '
        Me.BewBindingSource.DataMember = "bew"
        Me.BewBindingSource.DataSource = Me.BewerberDataSet
        '
        'BewTableAdapter
        '
        Me.BewTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btneintragloeschen)
        Me.Panel2.Controls.Add(Me.btnCloseandDelete)
        Me.Panel2.Controls.Add(Me.btnWerteeintragenFensterschliessen)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(790, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 214)
        Me.Panel2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(5, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ausgewählte Stellen, für die der Bewerber " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "oder die Bewerberin in Frage kommt:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(712, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(9, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "1. Stellen auswählen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(793, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(337, 22)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "2. Ausgewählte Stellen Stellen eintragen"
        '
        'frmOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1233, 657)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.OAGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmOA"
        Me.Text = "Offene Aufträge für Bewerber"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadRTEhtml, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Oa_stelleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OAGridView.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OAGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btneintragloeschen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseandDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnWerteeintragenFensterschliessen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OaDataSet As bewerberpool.oaDataSet
    Friend WithEvents Oa_stelleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Oa_stelleTableAdapter As bewerberpool.oaDataSetTableAdapters.oa_stelleTableAdapter
    Friend WithEvents OAGridView As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadRTEhtml As Telerik.WinControls.UI.RadRichTextEditor
    Friend WithEvents Oa_qualifikationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Oa_geheimTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Oa_plzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Oa_zavmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Oa_arbeitszeitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Oa_arbeitsortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btneintragloeschen As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCloseandDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnWerteeintragenFensterschliessen As Telerik.WinControls.UI.RadButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BewerberDataSet As bewerberpool.BewerberDataSet
    Friend WithEvents BewBindingSource As BindingSource
    Friend WithEvents BewTableAdapter As BewerberDataSetTableAdapters.bewTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
