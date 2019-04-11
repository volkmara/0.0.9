<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomepageindividuell
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
        Dim Tx_ttnewserweiterung_referenznummerLabel As System.Windows.Forms.Label
        Dim Tx_ttnewserweiterung_bewerbernameLabel As System.Windows.Forms.Label
        Dim UidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomepageindividuell))
        Dim DatetimeLabel1 As System.Windows.Forms.Label
        Me.HeyduckDataSet = New bewerberpool.heyduckDataSet()
        Me.Tt_newsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tt_newsTableAdapter = New bewerberpool.heyduckDataSetTableAdapters.tt_newsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbStopzeit = New System.Windows.Forms.CheckBox()
        Me.cbHomepage = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tx_ttnewserweiterung_referenznummerTextBox = New System.Windows.Forms.TextBox()
        Me.lblRefNrRundschreiben = New System.Windows.Forms.Label()
        Me.Tx_ttnewserweiterung_bewerbernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tx_ttnewserweiterung_bewerbernameLabel2 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New bewerberpool.heyduckDataSetTableAdapters.TableAdapterManager()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.lblEintragsdatum = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEndtime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Tx_ttnewserweiterung_referenznummerLabel = New System.Windows.Forms.Label()
        Tx_ttnewserweiterung_bewerbernameLabel = New System.Windows.Forms.Label()
        UidLabel = New System.Windows.Forms.Label()
        DatetimeLabel1 = New System.Windows.Forms.Label()
        CType(Me.HeyduckDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tt_newsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tx_ttnewserweiterung_referenznummerLabel
        '
        Tx_ttnewserweiterung_referenznummerLabel.AutoSize = True
        Tx_ttnewserweiterung_referenznummerLabel.Location = New System.Drawing.Point(12, 69)
        Tx_ttnewserweiterung_referenznummerLabel.Name = "Tx_ttnewserweiterung_referenznummerLabel"
        Tx_ttnewserweiterung_referenznummerLabel.Size = New System.Drawing.Size(154, 16)
        Tx_ttnewserweiterung_referenznummerLabel.TabIndex = 1
        Tx_ttnewserweiterung_referenznummerLabel.Text = "Refnr Bewerberpool: "
        '
        'Tx_ttnewserweiterung_bewerbernameLabel
        '
        Tx_ttnewserweiterung_bewerbernameLabel.AutoSize = True
        Tx_ttnewserweiterung_bewerbernameLabel.Location = New System.Drawing.Point(12, 26)
        Tx_ttnewserweiterung_bewerbernameLabel.Name = "Tx_ttnewserweiterung_bewerbernameLabel"
        Tx_ttnewserweiterung_bewerbernameLabel.Size = New System.Drawing.Size(99, 16)
        Tx_ttnewserweiterung_bewerbernameLabel.TabIndex = 2
        Tx_ttnewserweiterung_bewerbernameLabel.Text = "Bewerber/in: "
        '
        'UidLabel
        '
        UidLabel.AutoSize = True
        UidLabel.Location = New System.Drawing.Point(12, 107)
        UidLabel.Name = "UidLabel"
        UidLabel.Size = New System.Drawing.Size(161, 16)
        UidLabel.TabIndex = 4
        UidLabel.Text = "Refnr. Rundschreiben:"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Tx_ttnewserweiterung_referenznummerTextBox)
        Me.Panel1.Controls.Add(Me.lblRefNrRundschreiben)
        Me.Panel1.Controls.Add(UidLabel)
        Me.Panel1.Controls.Add(Me.Tx_ttnewserweiterung_bewerbernameTextBox)
        Me.Panel1.Controls.Add(Tx_ttnewserweiterung_bewerbernameLabel)
        Me.Panel1.Controls.Add(Tx_ttnewserweiterung_referenznummerLabel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 489)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblEintragsdatum)
        Me.GroupBox1.Controls.Add(DatetimeLabel1)
        Me.GroupBox1.Controls.Add(Me.cbHomepage)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 165)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'cbStopzeit
        '
        Me.cbStopzeit.AutoSize = True
        Me.cbStopzeit.Location = New System.Drawing.Point(310, 129)
        Me.cbStopzeit.Name = "cbStopzeit"
        Me.cbStopzeit.Size = New System.Drawing.Size(44, 20)
        Me.cbStopzeit.TabIndex = 10
        Me.cbStopzeit.Text = "Ja"
        Me.cbStopzeit.UseVisualStyleBackColor = True
        '
        'cbHomepage
        '
        Me.cbHomepage.AutoSize = True
        Me.cbHomepage.Location = New System.Drawing.Point(310, 112)
        Me.cbHomepage.Name = "cbHomepage"
        Me.cbHomepage.Size = New System.Drawing.Size(44, 20)
        Me.cbHomepage.TabIndex = 3
        Me.cbHomepage.Text = "Ja"
        Me.cbHomepage.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(397, 129)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 22)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Visible = False
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(9, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bewerber/in auf Startseite der Homepage plazieren:"
        '
        'Tx_ttnewserweiterung_referenznummerTextBox
        '
        Me.Tx_ttnewserweiterung_referenznummerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tt_newsBindingSource, "tx_ttnewserweiterung_referenznummer", True))
        Me.Tx_ttnewserweiterung_referenznummerTextBox.Location = New System.Drawing.Point(214, 65)
        Me.Tx_ttnewserweiterung_referenznummerTextBox.Name = "Tx_ttnewserweiterung_referenznummerTextBox"
        Me.Tx_ttnewserweiterung_referenznummerTextBox.Size = New System.Drawing.Size(57, 22)
        Me.Tx_ttnewserweiterung_referenznummerTextBox.TabIndex = 14
        '
        'lblRefNrRundschreiben
        '
        Me.lblRefNrRundschreiben.AutoSize = True
        Me.lblRefNrRundschreiben.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRefNrRundschreiben.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tt_newsBindingSource, "uid", True))
        Me.lblRefNrRundschreiben.Location = New System.Drawing.Point(214, 107)
        Me.lblRefNrRundschreiben.Name = "lblRefNrRundschreiben"
        Me.lblRefNrRundschreiben.Size = New System.Drawing.Size(57, 18)
        Me.lblRefNrRundschreiben.TabIndex = 6
        Me.lblRefNrRundschreiben.Text = "Label2"
        '
        'Tx_ttnewserweiterung_bewerbernameTextBox
        '
        Me.Tx_ttnewserweiterung_bewerbernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tt_newsBindingSource, "tx_ttnewserweiterung_bewerbername", True))
        Me.Tx_ttnewserweiterung_bewerbernameTextBox.Location = New System.Drawing.Point(214, 23)
        Me.Tx_ttnewserweiterung_bewerbernameTextBox.Name = "Tx_ttnewserweiterung_bewerbernameTextBox"
        Me.Tx_ttnewserweiterung_bewerbernameTextBox.ReadOnly = True
        Me.Tx_ttnewserweiterung_bewerbernameTextBox.Size = New System.Drawing.Size(443, 22)
        Me.Tx_ttnewserweiterung_bewerbernameTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Detailansicht Homepageeintrag von: "
        '
        'Tx_ttnewserweiterung_bewerbernameLabel2
        '
        Me.Tx_ttnewserweiterung_bewerbernameLabel2.BackColor = System.Drawing.Color.White
        Me.Tx_ttnewserweiterung_bewerbernameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tt_newsBindingSource, "tx_ttnewserweiterung_bewerbername", True))
        Me.Tx_ttnewserweiterung_bewerbernameLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx_ttnewserweiterung_bewerbernameLabel2.ForeColor = System.Drawing.Color.Crimson
        Me.Tx_ttnewserweiterung_bewerbernameLabel2.Location = New System.Drawing.Point(303, 13)
        Me.Tx_ttnewserweiterung_bewerbernameLabel2.Name = "Tx_ttnewserweiterung_bewerbernameLabel2"
        Me.Tx_ttnewserweiterung_bewerbernameLabel2.Size = New System.Drawing.Size(239, 23)
        Me.Tx_ttnewserweiterung_bewerbernameLabel2.TabIndex = 3
        Me.Tx_ttnewserweiterung_bewerbernameLabel2.Text = "Label2"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tt_newsTableAdapter = Me.Tt_newsTableAdapter
        Me.TableAdapterManager.UpdateOrder = bewerberpool.heyduckDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnSave
        '
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(12, 51)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(163, 37)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "<html><strong>Speichern>/strong></html>"
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(516, 51)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(163, 37)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "<html><strong>   Fenster schließen>/strong></html>"
        '
        'DatetimeLabel1
        '
        DatetimeLabel1.AutoSize = True
        DatetimeLabel1.ForeColor = System.Drawing.Color.Crimson
        DatetimeLabel1.Location = New System.Drawing.Point(6, 18)
        DatetimeLabel1.Name = "DatetimeLabel1"
        DatetimeLabel1.Size = New System.Drawing.Size(121, 16)
        DatetimeLabel1.TabIndex = 10
        DatetimeLabel1.Text = "Eingetragen am:"
        '
        'lblEintragsdatum
        '
        Me.lblEintragsdatum.AutoSize = True
        Me.lblEintragsdatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEintragsdatum.Location = New System.Drawing.Point(144, 18)
        Me.lblEintragsdatum.Name = "lblEintragsdatum"
        Me.lblEintragsdatum.Size = New System.Drawing.Size(57, 18)
        Me.lblEintragsdatum.TabIndex = 12
        Me.lblEintragsdatum.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(9, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(623, 48)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblEndtime)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbStopzeit)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 170)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(7, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bewerber/in wird nach diesem Datum" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nicht mehr auf der Homepage angezeigt:"
        '
        'lblEndtime
        '
        Me.lblEndtime.AutoSize = True
        Me.lblEndtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndtime.Location = New System.Drawing.Point(311, 22)
        Me.lblEndtime.Name = "lblEndtime"
        Me.lblEndtime.Size = New System.Drawing.Size(57, 18)
        Me.lblEndtime.TabIndex = 1
        Me.lblEndtime.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(9, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(623, 54)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Soll der Bewerber/die Bewerberin auch nach diesem Zeitpunt auf der Homepage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ange" &
    "zeigt werden, muss ein Datum ausgewählt und  eingetragen werden, das " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zeitlich " &
    "nach dem ursprünglichen Datum liegt."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(12, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Späteres Enddatum eintragen: "
        '
        'frmHomepageindividuell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(691, 600)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Tx_ttnewserweiterung_bewerbernameLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmHomepageindividuell"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bewerber/in auf Homepage - Detaildaten"
        CType(Me.HeyduckDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tt_newsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeyduckDataSet As bewerberpool.heyduckDataSet
    Friend WithEvents Tt_newsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tt_newsTableAdapter As bewerberpool.heyduckDataSetTableAdapters.tt_newsTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tx_ttnewserweiterung_bewerbernameLabel2 As System.Windows.Forms.Label
    Friend WithEvents Tx_ttnewserweiterung_bewerbernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As bewerberpool.heyduckDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblRefNrRundschreiben As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tx_ttnewserweiterung_referenznummerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbHomepage As System.Windows.Forms.CheckBox
    Friend WithEvents cbStopzeit As System.Windows.Forms.CheckBox
    Friend WithEvents lblEintragsdatum As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblEndtime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
