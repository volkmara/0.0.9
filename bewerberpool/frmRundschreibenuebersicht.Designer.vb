<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRundschreibenuebersicht
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
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewComboBoxColumn1 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewComboBoxColumn2 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn3 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn4 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn5 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn6 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn7 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn8 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn9 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRundschreibenuebersicht))
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.TableAdapterManager = New bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager()
        Me.RundschreibenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RundschreibenmonatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RundschreibenmonatTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.rundschreibenmonatTableAdapter()
        Me.RundschreibenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RundschreibenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.rundschreibenTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RGVRundschreibenMonat = New Telerik.WinControls.UI.RadGridView()
        Me.RGVBewerber = New Telerik.WinControls.UI.RadGridView()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbKW = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenmonatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.RGVRundschreibenMonat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVRundschreibenMonat.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVBewerber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVBewerber.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(5, 818)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rundschreibenübersicht"
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
        'RundschreibenBindingSource
        '
        Me.RundschreibenBindingSource.DataMember = "bew_rundschreiben"
        Me.RundschreibenBindingSource.DataSource = Me.BewBindingSource
        '
        'RundschreibenmonatBindingSource
        '
        Me.RundschreibenmonatBindingSource.DataMember = "rundschreibenmonat"
        Me.RundschreibenmonatBindingSource.DataSource = Me.BewerberDataSet
        '
        'RundschreibenmonatTableAdapter
        '
        Me.RundschreibenmonatTableAdapter.ClearBeforeFill = True
        '
        'RundschreibenBindingSource1
        '
        Me.RundschreibenBindingSource1.DataMember = "rundschreibenmonat_rundschreiben"
        Me.RundschreibenBindingSource1.DataSource = Me.RundschreibenmonatBindingSource
        '
        'RundschreibenTableAdapter
        '
        Me.RundschreibenTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RGVRundschreibenMonat)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RGVBewerber)
        Me.SplitContainer1.Size = New System.Drawing.Size(1301, 438)
        Me.SplitContainer1.SplitterDistance = 280
        Me.SplitContainer1.TabIndex = 3
        '
        'RGVRundschreibenMonat
        '
        Me.RGVRundschreibenMonat.AutoSizeRows = True
        Me.RGVRundschreibenMonat.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RGVRundschreibenMonat.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVRundschreibenMonat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RGVRundschreibenMonat.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGVRundschreibenMonat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVRundschreibenMonat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVRundschreibenMonat.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RGVRundschreibenMonat.MasterTemplate.AllowAddNewRow = False
        Me.RGVRundschreibenMonat.MasterTemplate.AllowColumnReorder = False
        Me.RGVRundschreibenMonat.MasterTemplate.AllowDragToGroup = False
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "idrundschreibenmonat"
        GridViewDecimalColumn1.HeaderText = "idrundschreibenmonat"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.IsVisible = False
        GridViewDecimalColumn1.Name = "idrundschreibenmonat"
        GridViewTextBoxColumn1.AllowGroup = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "monat"
        GridViewTextBoxColumn1.HeaderText = "Rundschreiben"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "monat"
        GridViewTextBoxColumn1.VisibleInColumnChooser = False
        GridViewTextBoxColumn1.Width = 180
        GridViewTextBoxColumn2.AllowGroup = False
        GridViewTextBoxColumn2.DataType = GetType(Integer)
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "kw"
        GridViewTextBoxColumn2.HeaderText = "KW"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "kw"
        GridViewTextBoxColumn2.VisibleInColumnChooser = False
        Me.RGVRundschreibenMonat.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2})
        Me.RGVRundschreibenMonat.MasterTemplate.DataSource = Me.RundschreibenmonatBindingSource
        Me.RGVRundschreibenMonat.MasterTemplate.EnableGrouping = False
        Me.RGVRundschreibenMonat.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGVRundschreibenMonat.Name = "RGVRundschreibenMonat"
        Me.RGVRundschreibenMonat.ReadOnly = True
        Me.RGVRundschreibenMonat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVRundschreibenMonat.Size = New System.Drawing.Size(280, 438)
        Me.RGVRundschreibenMonat.TabIndex = 0
        '
        'RGVBewerber
        '
        Me.RGVBewerber.AutoSizeRows = True
        Me.RGVBewerber.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RGVBewerber.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVBewerber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RGVBewerber.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.RGVBewerber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVBewerber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVBewerber.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RGVBewerber.MasterTemplate.AllowAddNewRow = False
        Me.RGVBewerber.MasterTemplate.AllowColumnReorder = False
        Me.RGVBewerber.MasterTemplate.AllowDragToGroup = False
        GridViewDecimalColumn2.AllowGroup = False
        GridViewDecimalColumn2.AllowSort = False
        GridViewDecimalColumn2.DataType = GetType(Integer)
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "id_rundschreiben"
        GridViewDecimalColumn2.HeaderText = "id_rundschreiben"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.IsVisible = False
        GridViewDecimalColumn2.Name = "id_rundschreiben"
        GridViewDecimalColumn2.VisibleInColumnChooser = False
        GridViewDecimalColumn3.AllowGroup = False
        GridViewDecimalColumn3.AllowSort = False
        GridViewDecimalColumn3.DataType = GetType(Integer)
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "bewid"
        GridViewDecimalColumn3.HeaderText = "bewid"
        GridViewDecimalColumn3.IsAutoGenerated = True
        GridViewDecimalColumn3.IsVisible = False
        GridViewDecimalColumn3.Name = "bewid"
        GridViewDecimalColumn3.VisibleInColumnChooser = False
        GridViewTextBoxColumn3.AllowGroup = False
        GridViewTextBoxColumn3.AllowSort = False
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "bezeichnung"
        GridViewTextBoxColumn3.HeaderText = "bezeichnung"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.IsVisible = False
        GridViewTextBoxColumn3.Name = "bezeichnung"
        GridViewTextBoxColumn3.VisibleInColumnChooser = False
        GridViewComboBoxColumn1.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn1.DataType = GetType(Integer)
        GridViewComboBoxColumn1.DisplayMember = "refnr"
        GridViewComboBoxColumn1.EnableExpressionEditor = False
        GridViewComboBoxColumn1.FieldName = "bewid"
        GridViewComboBoxColumn1.HeaderText = "RefNr"
        GridViewComboBoxColumn1.IsVisible = False
        GridViewComboBoxColumn1.Name = "column9"
        GridViewDecimalColumn4.AllowGroup = False
        GridViewDecimalColumn4.AllowSort = False
        GridViewDecimalColumn4.DataType = GetType(Integer)
        GridViewDecimalColumn4.EnableExpressionEditor = False
        GridViewDecimalColumn4.FieldName = "aktuell"
        GridViewDecimalColumn4.HeaderText = "aktuell"
        GridViewDecimalColumn4.IsAutoGenerated = True
        GridViewDecimalColumn4.IsVisible = False
        GridViewDecimalColumn4.Name = "aktuell"
        GridViewDecimalColumn4.VisibleInColumnChooser = False
        GridViewDecimalColumn5.AllowGroup = False
        GridViewDecimalColumn5.AllowSort = False
        GridViewDecimalColumn5.DataType = GetType(Integer)
        GridViewDecimalColumn5.EnableExpressionEditor = False
        GridViewDecimalColumn5.FieldName = "idrundschreibenmonat"
        GridViewDecimalColumn5.HeaderText = "idrundschreibenmonat"
        GridViewDecimalColumn5.IsAutoGenerated = True
        GridViewDecimalColumn5.IsVisible = False
        GridViewDecimalColumn5.Name = "idrundschreibenmonat"
        GridViewDecimalColumn5.VisibleInColumnChooser = False
        GridViewComboBoxColumn2.AllowGroup = False
        GridViewComboBoxColumn2.AllowSort = False
        GridViewComboBoxColumn2.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn2.DataType = GetType(Integer)
        GridViewComboBoxColumn2.DisplayMember = "anrede"
        GridViewComboBoxColumn2.EnableExpressionEditor = False
        GridViewComboBoxColumn2.FieldName = "bewid"
        GridViewComboBoxColumn2.HeaderText = "Anrede"
        GridViewComboBoxColumn2.Name = "column2"
        GridViewComboBoxColumn2.ValueMember = "id_bew"
        GridViewComboBoxColumn2.VisibleInColumnChooser = False
        GridViewComboBoxColumn2.Width = 80
        GridViewComboBoxColumn3.AllowGroup = False
        GridViewComboBoxColumn3.AllowSort = False
        GridViewComboBoxColumn3.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn3.DataType = GetType(Integer)
        GridViewComboBoxColumn3.DisplayMember = "vorname"
        GridViewComboBoxColumn3.EnableExpressionEditor = False
        GridViewComboBoxColumn3.FieldName = "bewid"
        GridViewComboBoxColumn3.HeaderText = "Vorname"
        GridViewComboBoxColumn3.Name = "column3"
        GridViewComboBoxColumn3.ValueMember = "id_bew"
        GridViewComboBoxColumn3.VisibleInColumnChooser = False
        GridViewComboBoxColumn3.Width = 150
        GridViewComboBoxColumn4.AllowGroup = False
        GridViewComboBoxColumn4.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn4.DataType = GetType(Integer)
        GridViewComboBoxColumn4.DisplayMember = "name"
        GridViewComboBoxColumn4.EnableExpressionEditor = False
        GridViewComboBoxColumn4.FieldName = "bewid"
        GridViewComboBoxColumn4.HeaderText = "Nachname"
        GridViewComboBoxColumn4.Name = "column1"
        GridViewComboBoxColumn4.ValueMember = "id_bew"
        GridViewComboBoxColumn4.VisibleInColumnChooser = False
        GridViewComboBoxColumn4.Width = 200
        GridViewComboBoxColumn5.AllowGroup = False
        GridViewComboBoxColumn5.AllowSort = False
        GridViewComboBoxColumn5.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn5.DataType = GetType(Integer)
        GridViewComboBoxColumn5.DisplayMember = "stand"
        GridViewComboBoxColumn5.EnableExpressionEditor = False
        GridViewComboBoxColumn5.FieldName = "bewid"
        GridViewComboBoxColumn5.HeaderText = "Stand"
        GridViewComboBoxColumn5.Name = "column4"
        GridViewComboBoxColumn5.ValueMember = "id_bew"
        GridViewComboBoxColumn5.VisibleInColumnChooser = False
        GridViewComboBoxColumn5.Width = 100
        GridViewComboBoxColumn6.AllowGroup = False
        GridViewComboBoxColumn6.AllowSort = False
        GridViewComboBoxColumn6.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn6.DataType = GetType(Integer)
        GridViewComboBoxColumn6.DisplayMember = "ulas"
        GridViewComboBoxColumn6.EnableExpressionEditor = False
        GridViewComboBoxColumn6.FieldName = "bewid"
        GridViewComboBoxColumn6.HeaderText = "Ulas"
        GridViewComboBoxColumn6.Name = "column5"
        GridViewComboBoxColumn6.ValueMember = "id_bew"
        GridViewComboBoxColumn6.VisibleInColumnChooser = False
        GridViewComboBoxColumn7.AllowGroup = False
        GridViewComboBoxColumn7.AllowSort = False
        GridViewComboBoxColumn7.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn7.DataType = GetType(Integer)
        GridViewComboBoxColumn7.DisplayMember = "alter"
        GridViewComboBoxColumn7.EnableExpressionEditor = False
        GridViewComboBoxColumn7.FieldName = "bewid"
        GridViewComboBoxColumn7.HeaderText = "Alter"
        GridViewComboBoxColumn7.Name = "column6"
        GridViewComboBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewComboBoxColumn7.ValueMember = "id_bew"
        GridViewComboBoxColumn7.VisibleInColumnChooser = False
        GridViewComboBoxColumn8.AllowGroup = False
        GridViewComboBoxColumn8.AllowSort = False
        GridViewComboBoxColumn8.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn8.DataType = GetType(Integer)
        GridViewComboBoxColumn8.DisplayMember = "ort"
        GridViewComboBoxColumn8.EnableExpressionEditor = False
        GridViewComboBoxColumn8.FieldName = "bewid"
        GridViewComboBoxColumn8.HeaderText = "Wohnort"
        GridViewComboBoxColumn8.Name = "column7"
        GridViewComboBoxColumn8.ValueMember = "id_bew"
        GridViewComboBoxColumn8.VisibleInColumnChooser = False
        GridViewComboBoxColumn8.Width = 150
        GridViewComboBoxColumn9.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn9.DataType = GetType(Integer)
        GridViewComboBoxColumn9.DisplayMember = "arbeitsort"
        GridViewComboBoxColumn9.EnableExpressionEditor = False
        GridViewComboBoxColumn9.FieldName = "bewid"
        GridViewComboBoxColumn9.HeaderText = "Arbeitsort"
        GridViewComboBoxColumn9.Name = "column8"
        GridViewComboBoxColumn9.ValueMember = "id_bew"
        GridViewComboBoxColumn9.Width = 150
        Me.RGVBewerber.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewTextBoxColumn3, GridViewComboBoxColumn1, GridViewDecimalColumn4, GridViewDecimalColumn5, GridViewComboBoxColumn2, GridViewComboBoxColumn3, GridViewComboBoxColumn4, GridViewComboBoxColumn5, GridViewComboBoxColumn6, GridViewComboBoxColumn7, GridViewComboBoxColumn8, GridViewComboBoxColumn9})
        Me.RGVBewerber.MasterTemplate.DataSource = Me.RundschreibenBindingSource1
        Me.RGVBewerber.MasterTemplate.EnableGrouping = False
        Me.RGVBewerber.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RGVBewerber.Name = "RGVBewerber"
        Me.RGVBewerber.ReadOnly = True
        Me.RGVBewerber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVBewerber.Size = New System.Drawing.Size(1017, 438)
        Me.RGVBewerber.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(308, 21)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(163, 37)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "<html><strong>KW speichern>/strong></html>"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.cmbKW)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(508, 817)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 72)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kalenderwoche eintragen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kalenderwoche (KW):"
        '
        'cmbKW
        '
        Me.cmbKW.FormattingEnabled = True
        Me.cmbKW.Location = New System.Drawing.Point(168, 31)
        Me.cmbKW.Name = "cmbKW"
        Me.cmbKW.Size = New System.Drawing.Size(121, 24)
        Me.cmbKW.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1321, 777)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1313, 748)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rundschreiben in Vorbereitung"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1313, 748)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rundschreibenübersicht"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmRundschreibenuebersicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1337, 898)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRundschreibenuebersicht"
        Me.Text = "Rundschreibenübersicht"
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenmonatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.RGVRundschreibenMonat.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVRundschreibenMonat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVBewerber.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVBewerber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BewerberDataSet As BewerberDataSet
    Friend WithEvents BewBindingSource As BindingSource
    Friend WithEvents BewTableAdapter As BewerberDataSetTableAdapters.bewTableAdapter
    Friend WithEvents TableAdapterManager As BewerberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RundschreibenBindingSource As BindingSource
    Friend WithEvents RundschreibenmonatBindingSource As BindingSource
    Friend WithEvents RundschreibenmonatTableAdapter As BewerberDataSetTableAdapters.rundschreibenmonatTableAdapter
    Friend WithEvents RundschreibenBindingSource1 As BindingSource
    Friend WithEvents RundschreibenTableAdapter As BewerberDataSetTableAdapters.rundschreibenTableAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents RGVRundschreibenMonat As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RGVBewerber As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbKW As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
