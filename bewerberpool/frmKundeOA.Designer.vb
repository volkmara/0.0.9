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
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor2 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKundeOA))
        Me.lstOa_kunde_name = New System.Windows.Forms.ListBox()
        Me.Oa_kundeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OaDataSet = New bewerberpool.oaDataSet()
        Me.RGVOAkunde = New Telerik.WinControls.UI.RadGridView()
        Me.Oa_kundeTableAdapter = New bewerberpool.oaDataSetTableAdapters.oa_kundeTableAdapter()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEintragloeschen = New Telerik.WinControls.UI.RadButton()
        Me.btnCloseandDelete = New Telerik.WinControls.UI.RadButton()
        Me.btnWerteeintragenFensterschliessen = New Telerik.WinControls.UI.RadButton()
        CType(Me.Oa_kundeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVOAkunde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVOAkunde.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnEintragloeschen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseandDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnWerteeintragenFensterschliessen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstOa_kunde_name
        '
        Me.lstOa_kunde_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstOa_kunde_name.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Oa_kundeBindingSource, "oa_kunde_name", True))
        Me.lstOa_kunde_name.FormattingEnabled = True
        Me.lstOa_kunde_name.ItemHeight = 16
        Me.lstOa_kunde_name.Location = New System.Drawing.Point(3, 5)
        Me.lstOa_kunde_name.Name = "lstOa_kunde_name"
        Me.lstOa_kunde_name.Size = New System.Drawing.Size(317, 178)
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
        Me.RGVOAkunde.Location = New System.Drawing.Point(12, 108)
        '
        '
        '
        Me.RGVOAkunde.MasterTemplate.AllowAddNewRow = False
        Me.RGVOAkunde.MasterTemplate.AllowColumnChooser = False
        Me.RGVOAkunde.MasterTemplate.AllowColumnReorder = False
        Me.RGVOAkunde.MasterTemplate.AllowDragToGroup = False
        Me.RGVOAkunde.MasterTemplate.AllowEditRow = False
        GridViewDecimalColumn2.AllowGroup = False
        GridViewDecimalColumn2.DataType = GetType(Integer)
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "oakundeID"
        GridViewDecimalColumn2.HeaderText = "oakundeID"
        GridViewDecimalColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.IsVisible = False
        GridViewDecimalColumn2.Name = "oakundeID"
        GridViewDecimalColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
        GridViewDecimalColumn2.VisibleInColumnChooser = False
        GridViewDecimalColumn2.Width = 500
        GridViewTextBoxColumn2.AllowGroup = False
        GridViewTextBoxColumn2.AllowResize = False
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "oa_kunde_name"
        GridViewTextBoxColumn2.HeaderText = "Kunde"
        GridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "oa_kunde_name"
        GridViewTextBoxColumn2.VisibleInColumnChooser = False
        GridViewTextBoxColumn2.Width = 500
        Me.RGVOAkunde.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn2, GridViewTextBoxColumn2})
        Me.RGVOAkunde.MasterTemplate.DataSource = Me.Oa_kundeBindingSource
        Me.RGVOAkunde.MasterTemplate.EnableFiltering = True
        SortDescriptor2.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor2.PropertyName = "oakundeID"
        Me.RGVOAkunde.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor2})
        Me.RGVOAkunde.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RGVOAkunde.Name = "RGVOAkunde"
        Me.RGVOAkunde.ReadOnly = True
        Me.RGVOAkunde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVOAkunde.Size = New System.Drawing.Size(539, 192)
        Me.RGVOAkunde.TabIndex = 2
        '
        'Oa_kundeTableAdapter
        '
        Me.Oa_kundeTableAdapter.ClearBeforeFill = True
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(971, 74)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(17, 20)
        Me.PictureBox13.TabIndex = 48
        Me.PictureBox13.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox13, "Doppelklick auf einen Eintrag, um diesen zu entfernen")
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1159, 46)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Um einen Kunden auszuwählen, für die der Bewerber/die Bewerberin generell in Frag" &
    "e kommt: Doppelklick auf einen Tabelleneintrag" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(12, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 22)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "1. Kunden auswählen"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(569, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(671, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(281, 22)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "2. Ausgewählte Kunden eintragen"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnEintragloeschen)
        Me.Panel1.Controls.Add(Me.btnCloseandDelete)
        Me.Panel1.Controls.Add(Me.btnWerteeintragenFensterschliessen)
        Me.Panel1.Controls.Add(Me.lstOa_kunde_name)
        Me.Panel1.Location = New System.Drawing.Point(671, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 192)
        Me.Panel1.TabIndex = 54
        '
        'btnEintragloeschen
        '
        Me.btnEintragloeschen.ForeColor = System.Drawing.Color.Red
        Me.btnEintragloeschen.Image = CType(resources.GetObject("btnEintragloeschen.Image"), System.Drawing.Image)
        Me.btnEintragloeschen.Location = New System.Drawing.Point(344, 10)
        Me.btnEintragloeschen.Name = "btnEintragloeschen"
        Me.btnEintragloeschen.Size = New System.Drawing.Size(131, 37)
        Me.btnEintragloeschen.TabIndex = 9
        Me.btnEintragloeschen.Text = "<html><strong>      Kunde nicht<br /></strong><strong>      mehr auswählen</stron" &
    "g></html>"
        '
        'btnCloseandDelete
        '
        Me.btnCloseandDelete.ForeColor = System.Drawing.Color.Red
        Me.btnCloseandDelete.Image = CType(resources.GetObject("btnCloseandDelete.Image"), System.Drawing.Image)
        Me.btnCloseandDelete.Location = New System.Drawing.Point(344, 136)
        Me.btnCloseandDelete.Name = "btnCloseandDelete"
        Me.btnCloseandDelete.Size = New System.Drawing.Size(131, 37)
        Me.btnCloseandDelete.TabIndex = 10
        Me.btnCloseandDelete.Text = "<html><strong>      Fenster schließen<br />       nichts eintragen</strong> </htm" &
    "l>"
        '
        'btnWerteeintragenFensterschliessen
        '
        Me.btnWerteeintragenFensterschliessen.ForeColor = System.Drawing.Color.Red
        Me.btnWerteeintragenFensterschliessen.Image = CType(resources.GetObject("btnWerteeintragenFensterschliessen.Image"), System.Drawing.Image)
        Me.btnWerteeintragenFensterschliessen.Location = New System.Drawing.Point(344, 74)
        Me.btnWerteeintragenFensterschliessen.Name = "btnWerteeintragenFensterschliessen"
        Me.btnWerteeintragenFensterschliessen.Size = New System.Drawing.Size(131, 37)
        Me.btnWerteeintragenFensterschliessen.TabIndex = 11
        Me.btnWerteeintragenFensterschliessen.Text = "<html><strong>      Fenster schließen, <br /></strong><strong>   Kunden eintragen" &
    "</strong></html>"
        '
        'frmKundeOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1176, 311)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.RGVOAkunde)
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
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnEintragloeschen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseandDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnWerteeintragenFensterschliessen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OaDataSet As oaDataSet
    Friend WithEvents Oa_kundeBindingSource As BindingSource
    Friend WithEvents Oa_kundeTableAdapter As oaDataSetTableAdapters.oa_kundeTableAdapter
    Friend WithEvents lstOa_kunde_name As ListBox
    Friend WithEvents RGVOAkunde As Telerik.WinControls.UI.RadGridView
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BewerberDataSet As BewerberDataSet
    Friend WithEvents BewBindingSource As BindingSource
    Friend WithEvents BewTableAdapter As BewerberDataSetTableAdapters.bewTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEintragloeschen As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCloseandDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnWerteeintragenFensterschliessen As Telerik.WinControls.UI.RadButton
End Class
