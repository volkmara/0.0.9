<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKundeOA
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
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKundeOA))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstOa_kunde_name = New System.Windows.Forms.ListBox()
        Me.Oa_kundeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OaDataSet = New bewerberpool.oaDataSet()
        Me.RGVOAkunde = New Telerik.WinControls.UI.RadGridView()
        Me.Oa_kundeTableAdapter = New bewerberpool.oaDataSetTableAdapters.oa_kundeTableAdapter()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnWerteeintragenFensterschliessen = New Telerik.WinControls.UI.RadButton()
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        CType(Me.Oa_kundeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVOAkunde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVOAkunde.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnWerteeintragenFensterschliessen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bitte einen oder mehrere Kunden aus OA mit Doppelklick auswählen:"
        '
        'lstOa_kunde_name
        '
        Me.lstOa_kunde_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstOa_kunde_name.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Oa_kundeBindingSource, "oa_kunde_name", True))
        Me.lstOa_kunde_name.FormattingEnabled = True
        Me.lstOa_kunde_name.ItemHeight = 16
        Me.lstOa_kunde_name.Location = New System.Drawing.Point(13, 443)
        Me.lstOa_kunde_name.Name = "lstOa_kunde_name"
        Me.lstOa_kunde_name.Size = New System.Drawing.Size(538, 114)
        Me.lstOa_kunde_name.TabIndex = 1
        '
        'Oa_kundeBindingSource
        '
        Me.Oa_kundeBindingSource.DataMember = "oa_kunde"
        Me.Oa_kundeBindingSource.DataSource = Me.OaDataSet
        '
        'OaDataSet
        '
        Me.OaDataSet.DataSetName = "oaDataSet"
        Me.OaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RGVOAkunde
        '
        Me.RGVOAkunde.AutoSizeRows = True
        Me.RGVOAkunde.BackColor = System.Drawing.Color.DarkOrange
        Me.RGVOAkunde.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVOAkunde.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.RGVOAkunde.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVOAkunde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVOAkunde.Location = New System.Drawing.Point(13, 57)
        '
        '
        '
        Me.RGVOAkunde.MasterTemplate.AllowAddNewRow = False
        Me.RGVOAkunde.MasterTemplate.AllowColumnChooser = False
        Me.RGVOAkunde.MasterTemplate.AllowColumnReorder = False
        Me.RGVOAkunde.MasterTemplate.AllowDragToGroup = False
        Me.RGVOAkunde.MasterTemplate.AllowEditRow = False
        GridViewDecimalColumn1.AllowGroup = False
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "oakundeID"
        GridViewDecimalColumn1.HeaderText = "oakundeID"
        GridViewDecimalColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.IsVisible = False
        GridViewDecimalColumn1.Name = "oakundeID"
        GridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
        GridViewDecimalColumn1.VisibleInColumnChooser = False
        GridViewDecimalColumn1.Width = 500
        GridViewTextBoxColumn1.AllowGroup = False
        GridViewTextBoxColumn1.AllowResize = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "oa_kunde_name"
        GridViewTextBoxColumn1.HeaderText = "Kunde"
        GridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "oa_kunde_name"
        GridViewTextBoxColumn1.VisibleInColumnChooser = False
        GridViewTextBoxColumn1.Width = 500
        Me.RGVOAkunde.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1})
        Me.RGVOAkunde.MasterTemplate.DataSource = Me.Oa_kundeBindingSource
        Me.RGVOAkunde.MasterTemplate.EnableFiltering = True
        SortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor1.PropertyName = "oakundeID"
        Me.RGVOAkunde.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.RGVOAkunde.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGVOAkunde.Name = "RGVOAkunde"
        Me.RGVOAkunde.ReadOnly = True
        Me.RGVOAkunde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVOAkunde.Size = New System.Drawing.Size(561, 365)
        Me.RGVOAkunde.TabIndex = 2
        '
        'Oa_kundeTableAdapter
        '
        Me.Oa_kundeTableAdapter.ClearBeforeFill = True
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(557, 443)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(17, 20)
        Me.PictureBox13.TabIndex = 48
        Me.PictureBox13.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox13, "Doppelklick auf einen Eintrag, um diesen zu entfernen")
        '
        'btnWerteeintragenFensterschliessen
        '
        Me.btnWerteeintragenFensterschliessen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWerteeintragenFensterschliessen.ForeColor = System.Drawing.Color.Red
        Me.btnWerteeintragenFensterschliessen.Image = CType(resources.GetObject("btnWerteeintragenFensterschliessen.Image"), System.Drawing.Image)
        Me.btnWerteeintragenFensterschliessen.Location = New System.Drawing.Point(184, 577)
        Me.btnWerteeintragenFensterschliessen.Name = "btnWerteeintragenFensterschliessen"
        Me.btnWerteeintragenFensterschliessen.Size = New System.Drawing.Size(213, 74)
        Me.btnWerteeintragenFensterschliessen.TabIndex = 49
        Me.btnWerteeintragenFensterschliessen.Text = "<html><span style=""font-size: 10pt""><strong>Fenster schließen, <br /></strong><st" &
    "rong>Stellen eintragen</strong></span></html>"
        '
        'BewerberDataSet
        '
        Me.BewerberDataSet.DataSetName = "BewerberDataSet"
        Me.BewerberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'frmKundeOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(586, 661)
        Me.Controls.Add(Me.btnWerteeintragenFensterschliessen)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.RGVOAkunde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstOa_kunde_name)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmKundeOA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kunden aus Offene Aufträge"
        CType(Me.Oa_kundeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVOAkunde.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVOAkunde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnWerteeintragenFensterschliessen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents OaDataSet As oaDataSet
    Friend WithEvents Oa_kundeBindingSource As BindingSource
    Friend WithEvents Oa_kundeTableAdapter As oaDataSetTableAdapters.oa_kundeTableAdapter
    Friend WithEvents lstOa_kunde_name As ListBox
    Friend WithEvents RGVOAkunde As Telerik.WinControls.UI.RadGridView
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnWerteeintragenFensterschliessen As Telerik.WinControls.UI.RadButton
    Friend WithEvents BewerberDataSet As BewerberDataSet
    Friend WithEvents BewBindingSource As BindingSource
    Friend WithEvents BewTableAdapter As BewerberDataSetTableAdapters.bewTableAdapter
End Class
