<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNeueAnmerkunganlegen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNeueAnmerkunganlegen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNeueAnmerkungSpeichern = New System.Windows.Forms.Button()
        Me.AnmerkungRTE = New Telerik.WinControls.UI.RadRichTextEditor()
        Me.BetreffListBox = New System.Windows.Forms.ListBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.NotizenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotizenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.notizenTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.AnmerkungRTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotizenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnNeueAnmerkungSpeichern)
        Me.Panel1.Controls.Add(Me.AnmerkungRTE)
        Me.Panel1.Controls.Add(Me.BetreffListBox)
        Me.Panel1.Controls.Add(Me.Label71)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 534)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(501, 462)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(169, 57)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "       Fenster" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       schließen"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnNeueAnmerkungSpeichern
        '
        Me.btnNeueAnmerkungSpeichern.Image = CType(resources.GetObject("btnNeueAnmerkungSpeichern.Image"), System.Drawing.Image)
        Me.btnNeueAnmerkungSpeichern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNeueAnmerkungSpeichern.Location = New System.Drawing.Point(260, 459)
        Me.btnNeueAnmerkungSpeichern.Name = "btnNeueAnmerkungSpeichern"
        Me.btnNeueAnmerkungSpeichern.Size = New System.Drawing.Size(203, 60)
        Me.btnNeueAnmerkungSpeichern.TabIndex = 43
        Me.btnNeueAnmerkungSpeichern.Text = "          Neue Anmerkung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        speichern"
        Me.btnNeueAnmerkungSpeichern.UseVisualStyleBackColor = True
        '
        'AnmerkungRTE
        '
        Me.AnmerkungRTE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.AnmerkungRTE.Location = New System.Drawing.Point(12, 181)
        Me.AnmerkungRTE.Name = "AnmerkungRTE"
        Me.AnmerkungRTE.SelectionFill = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AnmerkungRTE.Size = New System.Drawing.Size(902, 259)
        Me.AnmerkungRTE.TabIndex = 42
        '
        'BetreffListBox
        '
        Me.BetreffListBox.ColumnWidth = 380
        Me.BetreffListBox.FormattingEnabled = True
        Me.BetreffListBox.ItemHeight = 16
        Me.BetreffListBox.Location = New System.Drawing.Point(119, 11)
        Me.BetreffListBox.MultiColumn = True
        Me.BetreffListBox.Name = "BetreffListBox"
        Me.BetreffListBox.Size = New System.Drawing.Size(795, 164)
        Me.BetreffListBox.TabIndex = 41
        '
        'Label71
        '
        Me.Label71.ForeColor = System.Drawing.Color.Crimson
        Me.Label71.Location = New System.Drawing.Point(9, 11)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(104, 79)
        Me.Label71.TabIndex = 40
        Me.Label71.Text = "Betreff" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(bitte einen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Betreff " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "auswählen):"
        '
        'BewerberDataSet
        '
        Me.BewerberDataSet.DataSetName = "BewerberDataSet"
        Me.BewerberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotizenBindingSource
        '
        Me.NotizenBindingSource.DataMember = "notizen"
        Me.NotizenBindingSource.DataSource = Me.BewerberDataSet
        '
        'NotizenTableAdapter
        '
        Me.NotizenTableAdapter.ClearBeforeFill = True
        '
        'frmNeueAnmerkunganlegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(941, 551)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmNeueAnmerkunganlegen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Neue Anmerkung anlegen"
        Me.Panel1.ResumeLayout(False)
        CType(Me.AnmerkungRTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotizenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents BetreffListBox As System.Windows.Forms.ListBox
    Friend WithEvents AnmerkungRTE As Telerik.WinControls.UI.RadRichTextEditor
    Friend WithEvents btnNeueAnmerkungSpeichern As System.Windows.Forms.Button
    Friend WithEvents BewerberDataSet As bewerberpool.BewerberDataSet
    Friend WithEvents NotizenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotizenTableAdapter As bewerberpool.BewerberDataSetTableAdapters.notizenTableAdapter
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
