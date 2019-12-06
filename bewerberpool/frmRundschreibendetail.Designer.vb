<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRundschreibendetail
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
        Dim RefnrLabel As System.Windows.Forms.Label
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AlterLabel As System.Windows.Forms.Label
        Dim UlasLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim ArbeitsortLabel As System.Windows.Forms.Label
        Dim StandLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRundschreibendetail))
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.btnNewandSave = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMonat = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRundschreibenanmerkungen = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkHomepage = New System.Windows.Forms.CheckBox()
        Me.StandTextBox = New System.Windows.Forms.TextBox()
        Me.ArbeitsortTextBox = New System.Windows.Forms.TextBox()
        Me.OrtTextBox = New System.Windows.Forms.TextBox()
        Me.RefnrTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.UlasTextBox = New System.Windows.Forms.TextBox()
        Me.AlterTextBox = New System.Windows.Forms.TextBox()
        Me.AnredeTextBox = New System.Windows.Forms.TextBox()
        Me.RundschreibenmonatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RundschreibenmonatTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.rundschreibenmonatTableAdapter()
        Me.RundschreibenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RundschreibenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.rundschreibenTableAdapter()
        Me.TableAdapterManager = New bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager()
        RefnrLabel = New System.Windows.Forms.Label()
        AnredeLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AlterLabel = New System.Windows.Forms.Label()
        UlasLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        ArbeitsortLabel = New System.Windows.Forms.Label()
        StandLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewandSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RundschreibenmonatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RefnrLabel
        '
        RefnrLabel.AutoSize = True
        RefnrLabel.ForeColor = System.Drawing.Color.Crimson
        RefnrLabel.Location = New System.Drawing.Point(16, 200)
        RefnrLabel.Name = "RefnrLabel"
        RefnrLabel.Size = New System.Drawing.Size(49, 16)
        RefnrLabel.TabIndex = 15
        RefnrLabel.Text = "Refnr:"
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
        'AlterLabel
        '
        AlterLabel.AutoSize = True
        AlterLabel.ForeColor = System.Drawing.Color.Crimson
        AlterLabel.Location = New System.Drawing.Point(15, 315)
        AlterLabel.Name = "AlterLabel"
        AlterLabel.Size = New System.Drawing.Size(44, 16)
        AlterLabel.TabIndex = 8
        AlterLabel.Text = "Alter:"
        '
        'UlasLabel
        '
        UlasLabel.AutoSize = True
        UlasLabel.ForeColor = System.Drawing.Color.Crimson
        UlasLabel.Location = New System.Drawing.Point(15, 241)
        UlasLabel.Name = "UlasLabel"
        UlasLabel.Size = New System.Drawing.Size(44, 16)
        UlasLabel.TabIndex = 6
        UlasLabel.Text = "Ulas:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(16, 358)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(69, 16)
        OrtLabel.TabIndex = 16
        OrtLabel.Text = "Wohnort:"
        '
        'ArbeitsortLabel
        '
        ArbeitsortLabel.AutoSize = True
        ArbeitsortLabel.Location = New System.Drawing.Point(16, 404)
        ArbeitsortLabel.Name = "ArbeitsortLabel"
        ArbeitsortLabel.Size = New System.Drawing.Size(79, 16)
        ArbeitsortLabel.TabIndex = 17
        ArbeitsortLabel.Text = "Arbeitsort:"
        '
        'StandLabel
        '
        StandLabel.AutoSize = True
        StandLabel.Location = New System.Drawing.Point(16, 153)
        StandLabel.Name = "StandLabel"
        StandLabel.Size = New System.Drawing.Size(52, 16)
        StandLabel.TabIndex = 18
        StandLabel.Text = "Stand:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 447)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(116, 32)
        Label1.TabIndex = 21
        Label1.Text = "Bereits auf " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "der Homepage:"
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
        'btnNewandSave
        '
        Me.btnNewandSave.ForeColor = System.Drawing.Color.Red
        Me.btnNewandSave.Image = CType(resources.GetObject("btnNewandSave.Image"), System.Drawing.Image)
        Me.btnNewandSave.Location = New System.Drawing.Point(520, 12)
        Me.btnNewandSave.Name = "btnNewandSave"
        Me.btnNewandSave.Size = New System.Drawing.Size(163, 37)
        Me.btnNewandSave.TabIndex = 15
        Me.btnNewandSave.Text = "<html><strong>Neu und " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "speichern>/strong></html>"
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(693, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(163, 37)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "<html><strong>      Fenster schließen</html>"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(11, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(845, 563)
        Me.Panel1.TabIndex = 18
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox4)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(324, 22)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(511, 530)
        Me.FlowLayoutPanel1.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbMonat)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 90)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Für welches Rundschreiben vorgesehen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Monat:"
        '
        'cmbMonat
        '
        Me.cmbMonat.FormattingEnabled = True
        Me.cmbMonat.Location = New System.Drawing.Point(83, 26)
        Me.cmbMonat.Name = "cmbMonat"
        Me.cmbMonat.Size = New System.Drawing.Size(397, 24)
        Me.cmbMonat.TabIndex = 21
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListBox1)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox4.Location = New System.Drawing.Point(3, 99)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(486, 208)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bereits im Rundschreiben gewesen:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(474, 180)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRundschreibenanmerkungen)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Location = New System.Drawing.Point(3, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 205)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Anmerkungen:"
        '
        'txtRundschreibenanmerkungen
        '
        Me.txtRundschreibenanmerkungen.Location = New System.Drawing.Point(6, 31)
        Me.txtRundschreibenanmerkungen.Multiline = True
        Me.txtRundschreibenanmerkungen.Name = "txtRundschreibenanmerkungen"
        Me.txtRundschreibenanmerkungen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRundschreibenanmerkungen.Size = New System.Drawing.Size(474, 155)
        Me.txtRundschreibenanmerkungen.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.chkHomepage)
        Me.GroupBox1.Controls.Add(StandLabel)
        Me.GroupBox1.Controls.Add(Me.StandTextBox)
        Me.GroupBox1.Controls.Add(ArbeitsortLabel)
        Me.GroupBox1.Controls.Add(Me.ArbeitsortTextBox)
        Me.GroupBox1.Controls.Add(OrtLabel)
        Me.GroupBox1.Controls.Add(Me.OrtTextBox)
        Me.GroupBox1.Controls.Add(Me.RefnrTextBox)
        Me.GroupBox1.Controls.Add(RefnrLabel)
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
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 537)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bewerber/innen-Daten"
        '
        'chkHomepage
        '
        Me.chkHomepage.AutoSize = True
        Me.chkHomepage.Location = New System.Drawing.Point(162, 449)
        Me.chkHomepage.Name = "chkHomepage"
        Me.chkHomepage.Size = New System.Drawing.Size(15, 14)
        Me.chkHomepage.TabIndex = 20
        Me.chkHomepage.UseVisualStyleBackColor = True
        '
        'StandTextBox
        '
        Me.StandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "stand", True))
        Me.StandTextBox.Location = New System.Drawing.Point(111, 150)
        Me.StandTextBox.Name = "StandTextBox"
        Me.StandTextBox.ReadOnly = True
        Me.StandTextBox.Size = New System.Drawing.Size(186, 22)
        Me.StandTextBox.TabIndex = 19
        '
        'ArbeitsortTextBox
        '
        Me.ArbeitsortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "arbeitsort", True))
        Me.ArbeitsortTextBox.Location = New System.Drawing.Point(111, 398)
        Me.ArbeitsortTextBox.Name = "ArbeitsortTextBox"
        Me.ArbeitsortTextBox.ReadOnly = True
        Me.ArbeitsortTextBox.Size = New System.Drawing.Size(186, 22)
        Me.ArbeitsortTextBox.TabIndex = 18
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(111, 355)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.ReadOnly = True
        Me.OrtTextBox.Size = New System.Drawing.Size(186, 22)
        Me.OrtTextBox.TabIndex = 17
        '
        'RefnrTextBox
        '
        Me.RefnrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "refnr", True))
        Me.RefnrTextBox.Location = New System.Drawing.Point(111, 197)
        Me.RefnrTextBox.Name = "RefnrTextBox"
        Me.RefnrTextBox.ReadOnly = True
        Me.RefnrTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RefnrTextBox.TabIndex = 16
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(111, 104)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(186, 22)
        Me.NameTextBox.TabIndex = 5
        '
        'VornameTextBox
        '
        Me.VornameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "vorname", True))
        Me.VornameTextBox.Location = New System.Drawing.Point(111, 62)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.ReadOnly = True
        Me.VornameTextBox.Size = New System.Drawing.Size(186, 22)
        Me.VornameTextBox.TabIndex = 3
        '
        'UlasTextBox
        '
        Me.UlasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "ulas", True))
        Me.UlasTextBox.Location = New System.Drawing.Point(111, 238)
        Me.UlasTextBox.Multiline = True
        Me.UlasTextBox.Name = "UlasTextBox"
        Me.UlasTextBox.ReadOnly = True
        Me.UlasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UlasTextBox.Size = New System.Drawing.Size(100, 48)
        Me.UlasTextBox.TabIndex = 7
        '
        'AlterTextBox
        '
        Me.AlterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "alter", True))
        Me.AlterTextBox.Location = New System.Drawing.Point(111, 312)
        Me.AlterTextBox.Name = "AlterTextBox"
        Me.AlterTextBox.ReadOnly = True
        Me.AlterTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AlterTextBox.TabIndex = 9
        '
        'AnredeTextBox
        '
        Me.AnredeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BewBindingSource, "anrede", True))
        Me.AnredeTextBox.Location = New System.Drawing.Point(111, 27)
        Me.AnredeTextBox.Name = "AnredeTextBox"
        Me.AnredeTextBox.ReadOnly = True
        Me.AnredeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AnredeTextBox.TabIndex = 1
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
        'RundschreibenBindingSource
        '
        Me.RundschreibenBindingSource.DataMember = "rundschreiben"
        Me.RundschreibenBindingSource.DataSource = Me.BewerberDataSet
        '
        'RundschreibenTableAdapter
        '
        Me.RundschreibenTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.rundschreibenmonatTableAdapter = Me.RundschreibenmonatTableAdapter
        Me.TableAdapterManager.rundschreibenTableAdapter = Me.RundschreibenTableAdapter
        Me.TableAdapterManager.ulasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmRundschreibendetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(863, 628)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNewandSave)
        Me.Name = "frmRundschreibendetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bewerber/in für Rundschreiben"
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewandSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RundschreibenmonatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BewerberDataSet As bewerberpool.BewerberDataSet
    Friend WithEvents BewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BewTableAdapter As bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter
    Friend WithEvents btnNewandSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ArbeitsortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RefnrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VornameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnredeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents RundschreibenmonatBindingSource As BindingSource
    Friend WithEvents RundschreibenmonatTableAdapter As BewerberDataSetTableAdapters.rundschreibenmonatTableAdapter
    Friend WithEvents cmbMonat As ComboBox
    Friend WithEvents RundschreibenBindingSource As BindingSource
    Friend WithEvents RundschreibenTableAdapter As BewerberDataSetTableAdapters.rundschreibenTableAdapter
    Friend WithEvents StandTextBox As TextBox
    Friend WithEvents TableAdapterManager As BewerberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRundschreibenanmerkungen As TextBox
    Friend WithEvents chkHomepage As CheckBox
End Class
