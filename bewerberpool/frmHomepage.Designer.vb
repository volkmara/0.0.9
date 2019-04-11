<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomepage
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn6 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn7 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomepage))
        Me.HeyduckDataSet = New bewerberpool.heyduckDataSet()
        Me.Tt_newsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tt_newsTableAdapter = New bewerberpool.heyduckDataSetTableAdapters.tt_newsTableAdapter()
        Me.HomepageGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnalle = New System.Windows.Forms.RadioButton()
        Me.rbtngeloescht = New System.Windows.Forms.RadioButton()
        Me.rbtnnichtgelöscht = New System.Windows.Forms.RadioButton()
        Me.btnDeaktivieren = New Telerik.WinControls.UI.RadButton()
        Me.btnAktivieren = New Telerik.WinControls.UI.RadButton()
        Me.btnNeuladen = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        CType(Me.HeyduckDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tt_newsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomepageGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomepageGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnDeaktivieren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAktivieren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNeuladen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeyduckDataSet
        '
        Me.HeyduckDataSet.DataSetName = "heyduckDataSet"
        Me.HeyduckDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tt_newsBindingSource
        '
        Me.Tt_newsBindingSource.DataMember = "tt_news"
        Me.Tt_newsBindingSource.DataSource = Me.HeyduckDataSet
        '
        'Tt_newsTableAdapter
        '
        Me.Tt_newsTableAdapter.ClearBeforeFill = True
        '
        'HomepageGridView1
        '
        Me.HomepageGridView1.BackColor = System.Drawing.Color.White
        Me.HomepageGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.HomepageGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomepageGridView1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HomepageGridView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HomepageGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.HomepageGridView1.Location = New System.Drawing.Point(0, 0)
        Me.HomepageGridView1.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        Me.HomepageGridView1.MasterTemplate.AllowAddNewRow = False
        Me.HomepageGridView1.MasterTemplate.AllowColumnChooser = False
        Me.HomepageGridView1.MasterTemplate.AllowDragToGroup = False
        Me.HomepageGridView1.MasterTemplate.AllowEditRow = False
        GridViewTextBoxColumn1.AllowGroup = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "tx_ttnewserweiterung_bewerbername"
        GridViewTextBoxColumn1.HeaderText = "Bewerber/in"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.MinWidth = 8
        GridViewTextBoxColumn1.Name = "tx_ttnewserweiterung_bewerbername"
        GridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn1.VisibleInColumnChooser = False
        GridViewTextBoxColumn1.Width = 450
        GridViewDecimalColumn1.AllowGroup = False
        GridViewDecimalColumn1.AllowSort = False
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "uid"
        GridViewDecimalColumn1.HeaderText = "RefNr. HP"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.MinWidth = 8
        GridViewDecimalColumn1.Name = "uid"
        GridViewDecimalColumn1.ReadOnly = True
        GridViewDecimalColumn1.VisibleInColumnChooser = False
        GridViewDecimalColumn1.Width = 80
        GridViewTextBoxColumn2.AllowGroup = False
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "tx_ttnewserweiterung_referenznummer"
        GridViewTextBoxColumn2.HeaderText = "RefNr. BP"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.MinWidth = 8
        GridViewTextBoxColumn2.Name = "tx_ttnewserweiterung_referenznummer"
        GridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn2.VisibleInColumnChooser = False
        GridViewTextBoxColumn2.Width = 80
        GridViewDecimalColumn2.DataType = GetType(Integer)
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "pid"
        GridViewDecimalColumn2.HeaderText = "pid"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.IsVisible = False
        GridViewDecimalColumn2.MinWidth = 8
        GridViewDecimalColumn2.Name = "pid"
        GridViewDecimalColumn2.Width = 75
        GridViewDecimalColumn3.DataType = GetType(UInteger)
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "tstamp"
        GridViewDecimalColumn3.HeaderText = "tstamp"
        GridViewDecimalColumn3.IsAutoGenerated = True
        GridViewDecimalColumn3.IsVisible = False
        GridViewDecimalColumn3.MinWidth = 8
        GridViewDecimalColumn3.Name = "tstamp"
        GridViewDecimalColumn3.Width = 75
        GridViewDecimalColumn4.DataType = GetType(UInteger)
        GridViewDecimalColumn4.EnableExpressionEditor = False
        GridViewDecimalColumn4.FieldName = "crdate"
        GridViewDecimalColumn4.HeaderText = "crdate"
        GridViewDecimalColumn4.IsAutoGenerated = True
        GridViewDecimalColumn4.IsVisible = False
        GridViewDecimalColumn4.MinWidth = 8
        GridViewDecimalColumn4.Name = "crdate"
        GridViewDecimalColumn4.Width = 75
        GridViewDecimalColumn5.DataType = GetType(UInteger)
        GridViewDecimalColumn5.EnableExpressionEditor = False
        GridViewDecimalColumn5.FieldName = "starttime"
        GridViewDecimalColumn5.HeaderText = "starttime"
        GridViewDecimalColumn5.IsAutoGenerated = True
        GridViewDecimalColumn5.IsVisible = False
        GridViewDecimalColumn5.MinWidth = 8
        GridViewDecimalColumn5.Name = "starttime"
        GridViewDecimalColumn5.Width = 75
        GridViewDecimalColumn6.DataType = GetType(UInteger)
        GridViewDecimalColumn6.EnableExpressionEditor = False
        GridViewDecimalColumn6.FieldName = "endtime"
        GridViewDecimalColumn6.HeaderText = "endtime"
        GridViewDecimalColumn6.IsAutoGenerated = True
        GridViewDecimalColumn6.IsVisible = False
        GridViewDecimalColumn6.MinWidth = 8
        GridViewDecimalColumn6.Name = "endtime"
        GridViewDecimalColumn6.Width = 75
        GridViewDecimalColumn7.AllowGroup = False
        GridViewDecimalColumn7.DataType = GetType(Byte)
        GridViewDecimalColumn7.EnableExpressionEditor = False
        GridViewDecimalColumn7.FieldName = "deleted"
        GridViewDecimalColumn7.HeaderText = "Gelöscht"
        GridViewDecimalColumn7.IsAutoGenerated = True
        GridViewDecimalColumn7.MinWidth = 8
        GridViewDecimalColumn7.Name = "deleted"
        GridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewDecimalColumn7.VisibleInColumnChooser = False
        GridViewDecimalColumn7.Width = 90
        Me.HomepageGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewDecimalColumn1, GridViewTextBoxColumn2, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewDecimalColumn4, GridViewDecimalColumn5, GridViewDecimalColumn6, GridViewDecimalColumn7})
        Me.HomepageGridView1.MasterTemplate.DataSource = Me.Tt_newsBindingSource
        Me.HomepageGridView1.MasterTemplate.EnableFiltering = True
        Me.HomepageGridView1.MasterTemplate.EnableGrouping = False
        SortDescriptor1.PropertyName = "tx_ttnewserweiterung_bewerbername"
        Me.HomepageGridView1.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.HomepageGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.HomepageGridView1.Name = "HomepageGridView1"
        Me.HomepageGridView1.ReadOnly = True
        Me.HomepageGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomepageGridView1.Size = New System.Drawing.Size(739, 518)
        Me.HomepageGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.HomepageGridView1)
        Me.Panel1.Location = New System.Drawing.Point(13, 152)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 518)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bewerber/innen mit Homepageeintrag"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.rbtnalle)
        Me.GroupBox1.Controls.Add(Me.rbtngeloescht)
        Me.GroupBox1.Controls.Add(Me.rbtnnichtgelöscht)
        Me.GroupBox1.Location = New System.Drawing.Point(282, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 62)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'rbtnalle
        '
        Me.rbtnalle.AutoSize = True
        Me.rbtnalle.Checked = True
        Me.rbtnalle.Location = New System.Drawing.Point(12, 21)
        Me.rbtnalle.Name = "rbtnalle"
        Me.rbtnalle.Size = New System.Drawing.Size(52, 20)
        Me.rbtnalle.TabIndex = 1
        Me.rbtnalle.TabStop = True
        Me.rbtnalle.Text = "alle"
        Me.rbtnalle.UseVisualStyleBackColor = True
        '
        'rbtngeloescht
        '
        Me.rbtngeloescht.AutoSize = True
        Me.rbtngeloescht.Location = New System.Drawing.Point(271, 16)
        Me.rbtngeloescht.Name = "rbtngeloescht"
        Me.rbtngeloescht.Size = New System.Drawing.Size(168, 36)
        Me.rbtngeloescht.TabIndex = 1
        Me.rbtngeloescht.Text = "nicht auf Homepage " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "angezeigt"
        Me.rbtngeloescht.UseVisualStyleBackColor = True
        '
        'rbtnnichtgelöscht
        '
        Me.rbtnnichtgelöscht.AutoSize = True
        Me.rbtnnichtgelöscht.Location = New System.Drawing.Point(76, 22)
        Me.rbtnnichtgelöscht.Name = "rbtnnichtgelöscht"
        Me.rbtnnichtgelöscht.Size = New System.Drawing.Size(182, 20)
        Me.rbtnnichtgelöscht.TabIndex = 0
        Me.rbtnnichtgelöscht.Text = "auf Homepage anzeigt"
        Me.rbtnnichtgelöscht.UseVisualStyleBackColor = True
        '
        'btnDeaktivieren
        '
        Me.btnDeaktivieren.ForeColor = System.Drawing.Color.Red
        Me.btnDeaktivieren.Image = CType(resources.GetObject("btnDeaktivieren.Image"), System.Drawing.Image)
        Me.btnDeaktivieren.Location = New System.Drawing.Point(22, 99)
        Me.btnDeaktivieren.Name = "btnDeaktivieren"
        Me.btnDeaktivieren.Size = New System.Drawing.Size(163, 37)
        Me.btnDeaktivieren.TabIndex = 10
        Me.btnDeaktivieren.Text = "<html><strong>Auf Homepage <br />deaktivieren</strong></html>"
        '
        'btnAktivieren
        '
        Me.btnAktivieren.ForeColor = System.Drawing.Color.Red
        Me.btnAktivieren.Image = CType(resources.GetObject("btnAktivieren.Image"), System.Drawing.Image)
        Me.btnAktivieren.Location = New System.Drawing.Point(209, 99)
        Me.btnAktivieren.Name = "btnAktivieren"
        Me.btnAktivieren.Size = New System.Drawing.Size(163, 37)
        Me.btnAktivieren.TabIndex = 11
        Me.btnAktivieren.Text = "<html><strong>Auf Homepage <br />aktivieren</strong></html>"
        '
        'btnNeuladen
        '
        Me.btnNeuladen.ForeColor = System.Drawing.Color.Red
        Me.btnNeuladen.Image = CType(resources.GetObject("btnNeuladen.Image"), System.Drawing.Image)
        Me.btnNeuladen.Location = New System.Drawing.Point(394, 99)
        Me.btnNeuladen.Name = "btnNeuladen"
        Me.btnNeuladen.Size = New System.Drawing.Size(163, 37)
        Me.btnNeuladen.TabIndex = 12
        Me.btnNeuladen.Text = "<html><strong>Homepagedaten <br />neu laden</strong></html>"
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(589, 99)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(163, 37)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "<html><strong>   Fenster schließen>/strong></html>"
        '
        'frmHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(761, 681)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNeuladen)
        Me.Controls.Add(Me.btnAktivieren)
        Me.Controls.Add(Me.btnDeaktivieren)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bewerber und Bewerberinnen auf der Homepage"
        CType(Me.HeyduckDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tt_newsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomepageGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomepageGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnDeaktivieren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAktivieren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNeuladen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeyduckDataSet As bewerberpool.heyduckDataSet
    Friend WithEvents Tt_newsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tt_newsTableAdapter As bewerberpool.heyduckDataSetTableAdapters.tt_newsTableAdapter
    Friend WithEvents HomepageGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtngeloescht As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnnichtgelöscht As System.Windows.Forms.RadioButton
    Friend WithEvents btnDeaktivieren As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAktivieren As Telerik.WinControls.UI.RadButton
    Friend WithEvents rbtnalle As System.Windows.Forms.RadioButton
    Friend WithEvents btnNeuladen As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
End Class
