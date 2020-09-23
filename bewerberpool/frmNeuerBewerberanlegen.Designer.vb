<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNeuerBewerberanlegen
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNeuerBewerberanlegen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNeuerBewerber = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.AnredeComboBox = New System.Windows.Forms.ComboBox()
        NameLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        AnredeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(19, 138)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(89, 17)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Nachname:"
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(19, 74)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(77, 17)
        VornameLabel.TabIndex = 4
        VornameLabel.Text = "Vorname:"
        '
        'AnredeLabel
        '
        AnredeLabel.AutoSize = True
        AnredeLabel.Location = New System.Drawing.Point(19, 23)
        AnredeLabel.Name = "AnredeLabel"
        AnredeLabel.Size = New System.Drawing.Size(65, 17)
        AnredeLabel.TabIndex = 1
        AnredeLabel.Text = "Anrede:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(502, 65)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bitte geben Sie Anrede, Vorname und Name eines/r " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "neuen Bewerber/in ein:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnNeuerBewerber)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(VornameLabel)
        Me.Panel1.Controls.Add(Me.VornameTextBox)
        Me.Panel1.Controls.Add(Me.AnredeComboBox)
        Me.Panel1.Controls.Add(AnredeLabel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 351)
        Me.Panel1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(32, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(321, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Fenster schließen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNeuerBewerber
        '
        Me.btnNeuerBewerber.BackColor = System.Drawing.Color.Gainsboro
        Me.btnNeuerBewerber.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNeuerBewerber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnNeuerBewerber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNeuerBewerber.Image = CType(resources.GetObject("btnNeuerBewerber.Image"), System.Drawing.Image)
        Me.btnNeuerBewerber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNeuerBewerber.Location = New System.Drawing.Point(158, 190)
        Me.btnNeuerBewerber.Name = "btnNeuerBewerber"
        Me.btnNeuerBewerber.Size = New System.Drawing.Size(321, 60)
        Me.btnNeuerBewerber.TabIndex = 7
        Me.btnNeuerBewerber.Text = "Neue/n Bewerber/in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "anlegen"
        Me.btnNeuerBewerber.UseVisualStyleBackColor = False
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(158, 135)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(321, 23)
        Me.NameTextBox.TabIndex = 6
        '
        'VornameTextBox
        '
        Me.VornameTextBox.Location = New System.Drawing.Point(158, 74)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.Size = New System.Drawing.Size(321, 23)
        Me.VornameTextBox.TabIndex = 5
        '
        'AnredeComboBox
        '
        Me.AnredeComboBox.FormattingEnabled = True
        Me.AnredeComboBox.Items.AddRange(New Object() {"", "Herr", "Frau"})
        Me.AnredeComboBox.Location = New System.Drawing.Point(158, 23)
        Me.AnredeComboBox.Name = "AnredeComboBox"
        Me.AnredeComboBox.Size = New System.Drawing.Size(121, 24)
        Me.AnredeComboBox.TabIndex = 4
        '
        'frmNeuerBewerberanlegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(527, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNeuerBewerberanlegen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Neue/n Bewerber/in anlegen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNeuerBewerber As System.Windows.Forms.Button
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VornameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnredeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
