﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim AnmerkungenLabel As System.Windows.Forms.Label
        Dim RundschreibenreihenfolgeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim RundschreibenLabel As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim AktuellLabel As System.Windows.Forms.Label
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewComboBoxColumn1 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn6 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewComboBoxColumn2 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn3 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn4 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn5 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn6 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn7 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn8 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn9 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRundschreibenuebersicht))
        Dim GridViewDecimalColumn7 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn8 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewDecimalColumn9 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn10 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewComboBoxColumn10 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewDecimalColumn11 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn12 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn13 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewComboBoxColumn11 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn12 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn13 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn14 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn15 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn16 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn17 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn18 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewDecimalColumn14 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn15 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewDecimalColumn16 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn17 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewDecimalColumn18 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn19 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewComboBoxColumn19 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn20 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn21 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn22 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn23 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn24 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn25 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewComboBoxColumn26 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewDecimalColumn20 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn21 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn22 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn23 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn24 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.BewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberDataSet = New bewerberpool.BewerberDataSet()
        Me.BewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RundschreibenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RundschreibenmonatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RundschreibenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RGVRundschreibenMonat = New Telerik.WinControls.UI.RadGridView()
        Me.RGVBewerber = New Telerik.WinControls.UI.RadGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnEintraegeloeschen = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AktuellTextBox = New System.Windows.Forms.TextBox()
        Me.chgNurhomepage = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.chkAufHomepage = New System.Windows.Forms.CheckBox()
        Me.rbtnNein = New System.Windows.Forms.RadioButton()
        Me.rbtnJa = New System.Windows.Forms.RadioButton()
        Me.RundschreibenreihenfolgeTextBox = New System.Windows.Forms.TextBox()
        Me.AnmerkungenTextBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.RGVRundschreibenmonataktuell = New Telerik.WinControls.UI.RadGridView()
        Me.RGVRundschreibenaktuell = New Telerik.WinControls.UI.RadGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tabellebtn = New Telerik.WinControls.UI.RadDropDownButton()
        Me.AufklappenRadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.EinklappenRadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.btnRundschreibenaktuell_Close = New Telerik.WinControls.UI.RadButton()
        Me.btnEintraegeloeschenunduebertragen = New Telerik.WinControls.UI.RadButton()
        Me.btnSave_Rundschreiben = New Telerik.WinControls.UI.RadButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkAufHomepagePremium = New System.Windows.Forms.CheckBox()
        Me.rbtnJaPremium = New System.Windows.Forms.RadioButton()
        Me.rbtnNeinPremium = New System.Windows.Forms.RadioButton()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.RGVRundschreibenPremiumMonat = New Telerik.WinControls.UI.RadGridView()
        Me.RundschreibenpremiummonatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RGVRundschreibenPremium = New Telerik.WinControls.UI.RadGridView()
        Me.RundschreibenpremiumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnPremiumEintraegeloeschen = New Telerik.WinControls.UI.RadButton()
        Me.rbtnTabellePremium = New Telerik.WinControls.UI.RadDropDownButton()
        Me.AufklappenPremium = New Telerik.WinControls.UI.RadMenuItem()
        Me.EinklappenPremium = New Telerik.WinControls.UI.RadMenuItem()
        Me.btnPremiumClose = New Telerik.WinControls.UI.RadButton()
        Me.btnMonatPremiumloeschen = New Telerik.WinControls.UI.RadButton()
        Me.btnRSPremiumspeichern = New Telerik.WinControls.UI.RadButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnKWspeichern = New Telerik.WinControls.UI.RadButton()
        Me.lblKW = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAktuellesDatum = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BewTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.bewTableAdapter()
        Me.TableAdapterManager = New bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager()
        Me.RundschreibenmonatTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.rundschreibenmonatTableAdapter()
        Me.RundschreibenTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.rundschreibenTableAdapter()
        Me.RundschreibenpremiummonatTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.rundschreibenpremiummonatTableAdapter()
        Me.RundschreibenpremiumTableAdapter = New bewerberpool.BewerberDataSetTableAdapters.rundschreibenpremiumTableAdapter()
        Me.RundschreibenpremiumbewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RundschreibenpremiumbewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        AnmerkungenLabel = New System.Windows.Forms.Label()
        RundschreibenreihenfolgeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        RundschreibenLabel = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        AktuellLabel = New System.Windows.Forms.Label()
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenmonatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.RGVRundschreibenMonat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVRundschreibenMonat.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVBewerber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVBewerber.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.btnEintraegeloeschen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.RGVRundschreibenmonataktuell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVRundschreibenmonataktuell.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVRundschreibenaktuell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVRundschreibenaktuell.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabellebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRundschreibenaktuell_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEintraegeloeschenunduebertragen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave_Rundschreiben, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.RGVRundschreibenPremiumMonat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVRundschreibenPremiumMonat.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenpremiummonatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVRundschreibenPremium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVRundschreibenPremium.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenpremiumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPremiumEintraegeloeschen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtnTabellePremium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPremiumClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMonatPremiumloeschen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRSPremiumspeichern, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnKWspeichern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenpremiumbewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RundschreibenpremiumbewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnmerkungenLabel
        '
        AnmerkungenLabel.AutoSize = True
        AnmerkungenLabel.ForeColor = System.Drawing.Color.Crimson
        AnmerkungenLabel.Location = New System.Drawing.Point(715, 62)
        AnmerkungenLabel.Name = "AnmerkungenLabel"
        AnmerkungenLabel.Size = New System.Drawing.Size(106, 16)
        AnmerkungenLabel.TabIndex = 92
        AnmerkungenLabel.Text = "Anmerkungen:"
        '
        'RundschreibenreihenfolgeLabel
        '
        RundschreibenreihenfolgeLabel.AutoSize = True
        RundschreibenreihenfolgeLabel.ForeColor = System.Drawing.Color.Crimson
        RundschreibenreihenfolgeLabel.Location = New System.Drawing.Point(1104, 62)
        RundschreibenreihenfolgeLabel.Name = "RundschreibenreihenfolgeLabel"
        RundschreibenreihenfolgeLabel.Size = New System.Drawing.Size(194, 16)
        RundschreibenreihenfolgeLabel.TabIndex = 93
        RundschreibenreihenfolgeLabel.Text = "Rundschreibenreihenfolge:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.Crimson
        Label1.Location = New System.Drawing.Point(3, 17)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 32)
        Label1.TabIndex = 95
        Label1.Text = "Auf Home-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "page:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.ForeColor = System.Drawing.Color.Crimson
        Label5.Location = New System.Drawing.Point(713, 17)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(117, 16)
        Label5.TabIndex = 98
        Label5.Text = "Nur Homepage:"
        '
        'RundschreibenLabel
        '
        RundschreibenLabel.AutoSize = True
        RundschreibenLabel.ForeColor = System.Drawing.Color.Crimson
        RundschreibenLabel.Location = New System.Drawing.Point(322, 17)
        RundschreibenLabel.Name = "RundschreibenLabel"
        RundschreibenLabel.Size = New System.Drawing.Size(138, 32)
        RundschreibenLabel.TabIndex = 95
        RundschreibenLabel.Text = "Für Rundschreiben" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ausgewählt:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.ForeColor = System.Drawing.Color.Crimson
        Label12.Location = New System.Drawing.Point(338, 13)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(138, 32)
        Label12.TabIndex = 106
        Label12.Text = "Für Rundschreiben" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ausgewählt:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.ForeColor = System.Drawing.Color.Crimson
        Label13.Location = New System.Drawing.Point(15, 15)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(80, 32)
        Label13.TabIndex = 109
        Label13.Text = "Auf Home-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "page:"
        '
        'AktuellLabel
        '
        AktuellLabel.AutoSize = True
        AktuellLabel.Location = New System.Drawing.Point(1135, 136)
        AktuellLabel.Name = "AktuellLabel"
        AktuellLabel.Size = New System.Drawing.Size(58, 16)
        AktuellLabel.TabIndex = 99
        AktuellLabel.Text = "aktuell:"
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
        'BewBindingSource1
        '
        Me.BewBindingSource1.DataMember = "rundschreiben_bew"
        Me.BewBindingSource1.DataSource = Me.RundschreibenBindingSource1
        '
        'RundschreibenBindingSource1
        '
        Me.RundschreibenBindingSource1.DataMember = "rundschreibenmonat_rundschreiben"
        Me.RundschreibenBindingSource1.DataSource = Me.RundschreibenmonatBindingSource
        '
        'RundschreibenmonatBindingSource
        '
        Me.RundschreibenmonatBindingSource.DataMember = "rundschreibenmonat"
        Me.RundschreibenmonatBindingSource.DataSource = Me.BewerberDataSet
        '
        'RundschreibenBindingSource
        '
        Me.RundschreibenBindingSource.DataMember = "bew_rundschreiben"
        Me.RundschreibenBindingSource.DataSource = Me.BewBindingSource
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 154)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RGVRundschreibenMonat)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RGVBewerber)
        Me.SplitContainer1.Size = New System.Drawing.Size(1503, 684)
        Me.SplitContainer1.SplitterDistance = 322
        Me.SplitContainer1.TabIndex = 3
        '
        'RGVRundschreibenMonat
        '
        Me.RGVRundschreibenMonat.AutoSizeRows = True
        Me.RGVRundschreibenMonat.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RGVRundschreibenMonat.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVRundschreibenMonat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RGVRundschreibenMonat.Font = New System.Drawing.Font("Arial", 9.75!)
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
        GridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
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
        GridViewDecimalColumn2.DataType = GetType(Integer)
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "erledigt"
        GridViewDecimalColumn2.HeaderText = "erledigt"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.IsVisible = False
        GridViewDecimalColumn2.Name = "erledigt"
        Me.RGVRundschreibenMonat.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewDecimalColumn2})
        Me.RGVRundschreibenMonat.MasterTemplate.DataSource = Me.RundschreibenmonatBindingSource
        Me.RGVRundschreibenMonat.MasterTemplate.EnableGrouping = False
        SortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor1.PropertyName = "idrundschreibenmonat"
        Me.RGVRundschreibenMonat.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.RGVRundschreibenMonat.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGVRundschreibenMonat.Name = "RGVRundschreibenMonat"
        Me.RGVRundschreibenMonat.ReadOnly = True
        Me.RGVRundschreibenMonat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVRundschreibenMonat.Size = New System.Drawing.Size(322, 684)
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
        Me.RGVBewerber.MasterTemplate.AllowColumnChooser = False
        Me.RGVBewerber.MasterTemplate.AllowColumnReorder = False
        Me.RGVBewerber.MasterTemplate.AllowDragToGroup = False
        GridViewDecimalColumn3.AllowGroup = False
        GridViewDecimalColumn3.AllowSort = False
        GridViewDecimalColumn3.DataType = GetType(Integer)
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "id_rundschreiben"
        GridViewDecimalColumn3.HeaderText = "id_rundschreiben"
        GridViewDecimalColumn3.IsAutoGenerated = True
        GridViewDecimalColumn3.IsVisible = False
        GridViewDecimalColumn3.Name = "id_rundschreiben"
        GridViewDecimalColumn3.VisibleInColumnChooser = False
        GridViewDecimalColumn4.AllowGroup = False
        GridViewDecimalColumn4.AllowSort = False
        GridViewDecimalColumn4.DataType = GetType(Integer)
        GridViewDecimalColumn4.EnableExpressionEditor = False
        GridViewDecimalColumn4.FieldName = "bewid"
        GridViewDecimalColumn4.HeaderText = "bewid"
        GridViewDecimalColumn4.IsAutoGenerated = True
        GridViewDecimalColumn4.IsVisible = False
        GridViewDecimalColumn4.Name = "bewid"
        GridViewDecimalColumn4.VisibleInColumnChooser = False
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
        GridViewDecimalColumn5.AllowGroup = False
        GridViewDecimalColumn5.AllowSort = False
        GridViewDecimalColumn5.DataType = GetType(Integer)
        GridViewDecimalColumn5.EnableExpressionEditor = False
        GridViewDecimalColumn5.FieldName = "aktuell"
        GridViewDecimalColumn5.HeaderText = "aktuell"
        GridViewDecimalColumn5.IsAutoGenerated = True
        GridViewDecimalColumn5.IsVisible = False
        GridViewDecimalColumn5.Name = "aktuell"
        GridViewDecimalColumn5.VisibleInColumnChooser = False
        GridViewDecimalColumn6.AllowGroup = False
        GridViewDecimalColumn6.AllowSort = False
        GridViewDecimalColumn6.DataType = GetType(Integer)
        GridViewDecimalColumn6.EnableExpressionEditor = False
        GridViewDecimalColumn6.FieldName = "idrundschreibenmonat"
        GridViewDecimalColumn6.HeaderText = "idrundschreibenmonat"
        GridViewDecimalColumn6.IsAutoGenerated = True
        GridViewDecimalColumn6.IsVisible = False
        GridViewDecimalColumn6.Name = "idrundschreibenmonat"
        GridViewDecimalColumn6.VisibleInColumnChooser = False
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
        GridViewTextBoxColumn4.AllowGroup = False
        GridViewTextBoxColumn4.AllowSort = False
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "anmerkungen"
        GridViewTextBoxColumn4.HeaderText = "Anmerkungen"
        GridViewTextBoxColumn4.Name = "column10"
        GridViewTextBoxColumn4.VisibleInColumnChooser = False
        GridViewTextBoxColumn4.Width = 200
        Me.RGVBewerber.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn3, GridViewDecimalColumn4, GridViewTextBoxColumn3, GridViewComboBoxColumn1, GridViewDecimalColumn5, GridViewDecimalColumn6, GridViewComboBoxColumn2, GridViewComboBoxColumn3, GridViewComboBoxColumn4, GridViewComboBoxColumn5, GridViewComboBoxColumn6, GridViewComboBoxColumn7, GridViewComboBoxColumn8, GridViewComboBoxColumn9, GridViewTextBoxColumn4})
        Me.RGVBewerber.MasterTemplate.DataSource = Me.RundschreibenBindingSource1
        Me.RGVBewerber.MasterTemplate.EnableGrouping = False
        Me.RGVBewerber.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RGVBewerber.Name = "RGVBewerber"
        Me.RGVBewerber.ReadOnly = True
        Me.RGVBewerber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVBewerber.Size = New System.Drawing.Size(1177, 684)
        Me.RGVBewerber.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1535, 873)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.btnEintraegeloeschen)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Tabellebtn)
        Me.TabPage1.Controls.Add(Me.btnRundschreibenaktuell_Close)
        Me.TabPage1.Controls.Add(Me.btnEintraegeloeschenunduebertragen)
        Me.TabPage1.Controls.Add(Me.btnSave_Rundschreiben)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1527, 844)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rundschreiben in Vorbereitung"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnEintraegeloeschen
        '
        Me.btnEintraegeloeschen.ForeColor = System.Drawing.Color.Red
        Me.btnEintraegeloeschen.Image = CType(resources.GetObject("btnEintraegeloeschen.Image"), System.Drawing.Image)
        Me.btnEintraegeloeschen.Location = New System.Drawing.Point(657, 10)
        Me.btnEintraegeloeschen.Name = "btnEintraegeloeschen"
        Me.btnEintraegeloeschen.Size = New System.Drawing.Size(201, 47)
        Me.btnEintraegeloeschen.TabIndex = 95
        Me.btnEintraegeloeschen.Text = "<html><strong> <br/>   Eintrag löschen></strong><br/></html>"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(AktuellLabel)
        Me.Panel1.Controls.Add(Me.AktuellTextBox)
        Me.Panel1.Controls.Add(Me.chgNurhomepage)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.chkAufHomepage)
        Me.Panel1.Controls.Add(RundschreibenLabel)
        Me.Panel1.Controls.Add(Me.rbtnNein)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.rbtnJa)
        Me.Panel1.Controls.Add(RundschreibenreihenfolgeLabel)
        Me.Panel1.Controls.Add(Me.RundschreibenreihenfolgeTextBox)
        Me.Panel1.Controls.Add(AnmerkungenLabel)
        Me.Panel1.Controls.Add(Me.AnmerkungenTextBox)
        Me.Panel1.Location = New System.Drawing.Point(6, 630)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1500, 215)
        Me.Panel1.TabIndex = 94
        '
        'AktuellTextBox
        '
        Me.AktuellTextBox.Location = New System.Drawing.Point(1199, 133)
        Me.AktuellTextBox.Name = "AktuellTextBox"
        Me.AktuellTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AktuellTextBox.TabIndex = 100
        '
        'chgNurhomepage
        '
        Me.chgNurhomepage.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RundschreibenBindingSource1, "nurhomepage", True))
        Me.chgNurhomepage.Location = New System.Drawing.Point(836, 15)
        Me.chgNurhomepage.Name = "chgNurhomepage"
        Me.chgNurhomepage.Size = New System.Drawing.Size(104, 24)
        Me.chgNurhomepage.TabIndex = 99
        Me.chgNurhomepage.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(322, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Bereits in Rundschreiben vorgeschlagen:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(325, 85)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(261, 100)
        Me.ListBox1.TabIndex = 97
        '
        'chkAufHomepage
        '
        Me.chkAufHomepage.AutoSize = True
        Me.chkAufHomepage.Location = New System.Drawing.Point(99, 17)
        Me.chkAufHomepage.Name = "chkAufHomepage"
        Me.chkAufHomepage.Size = New System.Drawing.Size(44, 20)
        Me.chkAufHomepage.TabIndex = 96
        Me.chkAufHomepage.Text = "Ja"
        Me.chkAufHomepage.UseVisualStyleBackColor = True
        '
        'rbtnNein
        '
        Me.rbtnNein.AutoSize = True
        Me.rbtnNein.ForeColor = System.Drawing.Color.Crimson
        Me.rbtnNein.Location = New System.Drawing.Point(603, 15)
        Me.rbtnNein.Name = "rbtnNein"
        Me.rbtnNein.Size = New System.Drawing.Size(58, 20)
        Me.rbtnNein.TabIndex = 97
        Me.rbtnNein.TabStop = True
        Me.rbtnNein.Text = "Nein"
        Me.rbtnNein.UseVisualStyleBackColor = True
        '
        'rbtnJa
        '
        Me.rbtnJa.AutoSize = True
        Me.rbtnJa.ForeColor = System.Drawing.Color.Crimson
        Me.rbtnJa.Location = New System.Drawing.Point(545, 15)
        Me.rbtnJa.Name = "rbtnJa"
        Me.rbtnJa.Size = New System.Drawing.Size(43, 20)
        Me.rbtnJa.TabIndex = 96
        Me.rbtnJa.TabStop = True
        Me.rbtnJa.Text = "Ja"
        Me.rbtnJa.UseVisualStyleBackColor = True
        '
        'RundschreibenreihenfolgeTextBox
        '
        Me.RundschreibenreihenfolgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RundschreibenBindingSource1, "rundschreibenreihenfolge", True))
        Me.RundschreibenreihenfolgeTextBox.Location = New System.Drawing.Point(1107, 85)
        Me.RundschreibenreihenfolgeTextBox.Name = "RundschreibenreihenfolgeTextBox"
        Me.RundschreibenreihenfolgeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RundschreibenreihenfolgeTextBox.TabIndex = 94
        '
        'AnmerkungenTextBox
        '
        Me.AnmerkungenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RundschreibenBindingSource1, "anmerkungen", True))
        Me.AnmerkungenTextBox.Location = New System.Drawing.Point(718, 85)
        Me.AnmerkungenTextBox.Multiline = True
        Me.AnmerkungenTextBox.Name = "AnmerkungenTextBox"
        Me.AnmerkungenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AnmerkungenTextBox.Size = New System.Drawing.Size(352, 108)
        Me.AnmerkungenTextBox.TabIndex = 93
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SplitContainer2.Location = New System.Drawing.Point(6, 124)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.RGVRundschreibenmonataktuell)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.RGVRundschreibenaktuell)
        Me.SplitContainer2.Size = New System.Drawing.Size(1500, 500)
        Me.SplitContainer2.SplitterDistance = 322
        Me.SplitContainer2.TabIndex = 92
        '
        'RGVRundschreibenmonataktuell
        '
        Me.RGVRundschreibenmonataktuell.AutoSizeRows = True
        Me.RGVRundschreibenmonataktuell.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RGVRundschreibenmonataktuell.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVRundschreibenmonataktuell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RGVRundschreibenmonataktuell.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.RGVRundschreibenmonataktuell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVRundschreibenmonataktuell.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVRundschreibenmonataktuell.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RGVRundschreibenmonataktuell.MasterTemplate.AllowAddNewRow = False
        Me.RGVRundschreibenmonataktuell.MasterTemplate.AllowColumnReorder = False
        Me.RGVRundschreibenmonataktuell.MasterTemplate.AllowDragToGroup = False
        Me.RGVRundschreibenmonataktuell.MasterTemplate.AllowEditRow = False
        GridViewDecimalColumn7.DataType = GetType(Integer)
        GridViewDecimalColumn7.EnableExpressionEditor = False
        GridViewDecimalColumn7.FieldName = "idrundschreibenmonat"
        GridViewDecimalColumn7.HeaderText = "idrundschreibenmonat"
        GridViewDecimalColumn7.IsAutoGenerated = True
        GridViewDecimalColumn7.IsVisible = False
        GridViewDecimalColumn7.Name = "idrundschreibenmonat"
        GridViewTextBoxColumn5.AllowGroup = False
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "monat"
        GridViewTextBoxColumn5.HeaderText = "Rundschreiben"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.Name = "monat"
        GridViewTextBoxColumn5.VisibleInColumnChooser = False
        GridViewTextBoxColumn5.Width = 180
        GridViewTextBoxColumn6.AllowGroup = False
        GridViewTextBoxColumn6.DataType = GetType(Integer)
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "kw"
        GridViewTextBoxColumn6.HeaderText = "KW"
        GridViewTextBoxColumn6.IsAutoGenerated = True
        GridViewTextBoxColumn6.Name = "kw"
        GridViewTextBoxColumn6.VisibleInColumnChooser = False
        GridViewDecimalColumn8.DataType = GetType(Integer)
        GridViewDecimalColumn8.EnableExpressionEditor = False
        GridViewDecimalColumn8.FieldName = "erledigt"
        GridViewDecimalColumn8.HeaderText = "erledigt"
        GridViewDecimalColumn8.IsAutoGenerated = True
        GridViewDecimalColumn8.IsVisible = False
        GridViewDecimalColumn8.Name = "erledigt"
        Me.RGVRundschreibenmonataktuell.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn7, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewDecimalColumn8})
        Me.RGVRundschreibenmonataktuell.MasterTemplate.DataSource = Me.RundschreibenmonatBindingSource
        Me.RGVRundschreibenmonataktuell.MasterTemplate.EnableGrouping = False
        Me.RGVRundschreibenmonataktuell.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.RGVRundschreibenmonataktuell.Name = "RGVRundschreibenmonataktuell"
        Me.RGVRundschreibenmonataktuell.ReadOnly = True
        Me.RGVRundschreibenmonataktuell.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVRundschreibenmonataktuell.Size = New System.Drawing.Size(322, 500)
        Me.RGVRundschreibenmonataktuell.TabIndex = 0
        '
        'RGVRundschreibenaktuell
        '
        Me.RGVRundschreibenaktuell.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RGVRundschreibenaktuell.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVRundschreibenaktuell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RGVRundschreibenaktuell.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.RGVRundschreibenaktuell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVRundschreibenaktuell.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVRundschreibenaktuell.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RGVRundschreibenaktuell.MasterTemplate.AllowAddNewRow = False
        Me.RGVRundschreibenaktuell.MasterTemplate.AllowColumnReorder = False
        Me.RGVRundschreibenaktuell.MasterTemplate.AllowDragToGroup = False
        GridViewDecimalColumn9.AllowGroup = False
        GridViewDecimalColumn9.AllowSort = False
        GridViewDecimalColumn9.DataType = GetType(Integer)
        GridViewDecimalColumn9.EnableExpressionEditor = False
        GridViewDecimalColumn9.FieldName = "id_rundschreiben"
        GridViewDecimalColumn9.HeaderText = "id_rundschreiben"
        GridViewDecimalColumn9.IsAutoGenerated = True
        GridViewDecimalColumn9.IsVisible = False
        GridViewDecimalColumn9.Name = "id_rundschreiben"
        GridViewDecimalColumn9.VisibleInColumnChooser = False
        GridViewDecimalColumn10.AllowGroup = False
        GridViewDecimalColumn10.AllowSort = False
        GridViewDecimalColumn10.DataType = GetType(Integer)
        GridViewDecimalColumn10.EnableExpressionEditor = False
        GridViewDecimalColumn10.FieldName = "bewid"
        GridViewDecimalColumn10.HeaderText = "bewid"
        GridViewDecimalColumn10.IsAutoGenerated = True
        GridViewDecimalColumn10.IsVisible = False
        GridViewDecimalColumn10.Name = "bewid"
        GridViewDecimalColumn10.VisibleInColumnChooser = False
        GridViewTextBoxColumn7.AllowGroup = False
        GridViewTextBoxColumn7.AllowSort = False
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "bezeichnung"
        GridViewTextBoxColumn7.HeaderText = "bezeichnung"
        GridViewTextBoxColumn7.IsAutoGenerated = True
        GridViewTextBoxColumn7.IsVisible = False
        GridViewTextBoxColumn7.Name = "bezeichnung"
        GridViewTextBoxColumn7.VisibleInColumnChooser = False
        GridViewComboBoxColumn10.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn10.DataType = GetType(Integer)
        GridViewComboBoxColumn10.DisplayMember = "refnr"
        GridViewComboBoxColumn10.EnableExpressionEditor = False
        GridViewComboBoxColumn10.FieldName = "bewid"
        GridViewComboBoxColumn10.HeaderText = "RefNr"
        GridViewComboBoxColumn10.IsVisible = False
        GridViewComboBoxColumn10.Name = "column9"
        GridViewDecimalColumn11.AllowGroup = False
        GridViewDecimalColumn11.AllowSort = False
        GridViewDecimalColumn11.DataType = GetType(Integer)
        GridViewDecimalColumn11.EnableExpressionEditor = False
        GridViewDecimalColumn11.FieldName = "aktuell"
        GridViewDecimalColumn11.HeaderText = "aktuell"
        GridViewDecimalColumn11.IsAutoGenerated = True
        GridViewDecimalColumn11.IsVisible = False
        GridViewDecimalColumn11.Name = "aktuell"
        GridViewDecimalColumn11.VisibleInColumnChooser = False
        GridViewDecimalColumn12.AllowGroup = False
        GridViewDecimalColumn12.AllowSort = False
        GridViewDecimalColumn12.DataType = GetType(Integer)
        GridViewDecimalColumn12.EnableExpressionEditor = False
        GridViewDecimalColumn12.FieldName = "idrundschreibenmonat"
        GridViewDecimalColumn12.HeaderText = "idrundschreibenmonat"
        GridViewDecimalColumn12.IsAutoGenerated = True
        GridViewDecimalColumn12.IsVisible = False
        GridViewDecimalColumn12.Name = "idrundschreibenmonat"
        GridViewDecimalColumn12.VisibleInColumnChooser = False
        GridViewDecimalColumn13.DataType = GetType(Integer)
        GridViewDecimalColumn13.EnableExpressionEditor = False
        GridViewDecimalColumn13.FieldName = "refnr"
        GridViewDecimalColumn13.HeaderText = "Refnr"
        GridViewDecimalColumn13.IsAutoGenerated = True
        GridViewDecimalColumn13.Name = "refnr"
        GridViewComboBoxColumn11.AllowGroup = False
        GridViewComboBoxColumn11.AllowSort = False
        GridViewComboBoxColumn11.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn11.DataType = GetType(Integer)
        GridViewComboBoxColumn11.DisplayMember = "anrede"
        GridViewComboBoxColumn11.EnableExpressionEditor = False
        GridViewComboBoxColumn11.FieldName = "bewid"
        GridViewComboBoxColumn11.HeaderText = "Anrede"
        GridViewComboBoxColumn11.Name = "column2"
        GridViewComboBoxColumn11.ValueMember = "id_bew"
        GridViewComboBoxColumn11.VisibleInColumnChooser = False
        GridViewComboBoxColumn11.Width = 80
        GridViewComboBoxColumn12.AllowGroup = False
        GridViewComboBoxColumn12.AllowSort = False
        GridViewComboBoxColumn12.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn12.DataType = GetType(Integer)
        GridViewComboBoxColumn12.DisplayMember = "vorname"
        GridViewComboBoxColumn12.EnableExpressionEditor = False
        GridViewComboBoxColumn12.FieldName = "bewid"
        GridViewComboBoxColumn12.HeaderText = "Vorname"
        GridViewComboBoxColumn12.Name = "column3"
        GridViewComboBoxColumn12.ValueMember = "id_bew"
        GridViewComboBoxColumn12.VisibleInColumnChooser = False
        GridViewComboBoxColumn12.Width = 150
        GridViewComboBoxColumn13.AllowGroup = False
        GridViewComboBoxColumn13.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn13.DataType = GetType(Integer)
        GridViewComboBoxColumn13.DisplayMember = "name"
        GridViewComboBoxColumn13.EnableExpressionEditor = False
        GridViewComboBoxColumn13.FieldName = "bewid"
        GridViewComboBoxColumn13.HeaderText = "Nachname"
        GridViewComboBoxColumn13.Name = "column1"
        GridViewComboBoxColumn13.ValueMember = "id_bew"
        GridViewComboBoxColumn13.VisibleInColumnChooser = False
        GridViewComboBoxColumn13.Width = 200
        GridViewComboBoxColumn14.AllowGroup = False
        GridViewComboBoxColumn14.AllowSort = False
        GridViewComboBoxColumn14.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn14.DataType = GetType(Integer)
        GridViewComboBoxColumn14.DisplayMember = "stand"
        GridViewComboBoxColumn14.EnableExpressionEditor = False
        GridViewComboBoxColumn14.FieldName = "bewid"
        GridViewComboBoxColumn14.HeaderText = "Stand"
        GridViewComboBoxColumn14.Name = "column4"
        GridViewComboBoxColumn14.ValueMember = "id_bew"
        GridViewComboBoxColumn14.VisibleInColumnChooser = False
        GridViewComboBoxColumn14.Width = 100
        GridViewComboBoxColumn15.AllowGroup = False
        GridViewComboBoxColumn15.AllowSort = False
        GridViewComboBoxColumn15.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn15.DataType = GetType(Integer)
        GridViewComboBoxColumn15.DisplayMember = "ulas"
        GridViewComboBoxColumn15.EnableExpressionEditor = False
        GridViewComboBoxColumn15.FieldName = "bewid"
        GridViewComboBoxColumn15.HeaderText = "Ulas"
        GridViewComboBoxColumn15.Name = "column5"
        GridViewComboBoxColumn15.ValueMember = "id_bew"
        GridViewComboBoxColumn15.VisibleInColumnChooser = False
        GridViewComboBoxColumn16.AllowGroup = False
        GridViewComboBoxColumn16.AllowSort = False
        GridViewComboBoxColumn16.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn16.DataType = GetType(Integer)
        GridViewComboBoxColumn16.DisplayMember = "alter"
        GridViewComboBoxColumn16.EnableExpressionEditor = False
        GridViewComboBoxColumn16.FieldName = "bewid"
        GridViewComboBoxColumn16.HeaderText = "Alter"
        GridViewComboBoxColumn16.Name = "column6"
        GridViewComboBoxColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewComboBoxColumn16.ValueMember = "id_bew"
        GridViewComboBoxColumn16.VisibleInColumnChooser = False
        GridViewComboBoxColumn17.AllowGroup = False
        GridViewComboBoxColumn17.AllowSort = False
        GridViewComboBoxColumn17.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn17.DataType = GetType(Integer)
        GridViewComboBoxColumn17.DisplayMember = "ort"
        GridViewComboBoxColumn17.EnableExpressionEditor = False
        GridViewComboBoxColumn17.FieldName = "bewid"
        GridViewComboBoxColumn17.HeaderText = "Wohnort"
        GridViewComboBoxColumn17.Name = "column7"
        GridViewComboBoxColumn17.ValueMember = "id_bew"
        GridViewComboBoxColumn17.VisibleInColumnChooser = False
        GridViewComboBoxColumn17.Width = 150
        GridViewComboBoxColumn18.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn18.DataType = GetType(Integer)
        GridViewComboBoxColumn18.DisplayMember = "arbeitsort"
        GridViewComboBoxColumn18.EnableExpressionEditor = False
        GridViewComboBoxColumn18.FieldName = "bewid"
        GridViewComboBoxColumn18.HeaderText = "Arbeitsort"
        GridViewComboBoxColumn18.Name = "column8"
        GridViewComboBoxColumn18.ValueMember = "id_bew"
        GridViewComboBoxColumn18.Width = 150
        GridViewDecimalColumn14.DataType = GetType(Integer)
        GridViewDecimalColumn14.EnableExpressionEditor = False
        GridViewDecimalColumn14.FieldName = "homepage"
        GridViewDecimalColumn14.HeaderText = "homepage"
        GridViewDecimalColumn14.IsAutoGenerated = True
        GridViewDecimalColumn14.IsVisible = False
        GridViewDecimalColumn14.Name = "homepage"
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "anmerkungen"
        GridViewTextBoxColumn8.HeaderText = "anmerkungen"
        GridViewTextBoxColumn8.IsAutoGenerated = True
        GridViewTextBoxColumn8.IsVisible = False
        GridViewTextBoxColumn8.Name = "anmerkungen"
        GridViewDecimalColumn15.AllowGroup = False
        GridViewDecimalColumn15.AllowResize = False
        GridViewDecimalColumn15.AllowSort = False
        GridViewDecimalColumn15.DataType = GetType(Integer)
        GridViewDecimalColumn15.EnableExpressionEditor = False
        GridViewDecimalColumn15.FieldName = "rundschreibenreihenfolge"
        GridViewDecimalColumn15.HeaderText = "Reihenfolge"
        GridViewDecimalColumn15.IsAutoGenerated = True
        GridViewDecimalColumn15.Name = "rundschreibenreihenfolge"
        GridViewDecimalColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewDecimalColumn15.VisibleInColumnChooser = False
        GridViewDecimalColumn15.Width = 80
        Me.RGVRundschreibenaktuell.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn9, GridViewDecimalColumn10, GridViewTextBoxColumn7, GridViewComboBoxColumn10, GridViewDecimalColumn11, GridViewDecimalColumn12, GridViewDecimalColumn13, GridViewComboBoxColumn11, GridViewComboBoxColumn12, GridViewComboBoxColumn13, GridViewComboBoxColumn14, GridViewComboBoxColumn15, GridViewComboBoxColumn16, GridViewComboBoxColumn17, GridViewComboBoxColumn18, GridViewDecimalColumn14, GridViewTextBoxColumn8, GridViewDecimalColumn15})
        Me.RGVRundschreibenaktuell.MasterTemplate.DataSource = Me.RundschreibenBindingSource1
        Me.RGVRundschreibenaktuell.MasterTemplate.EnableGrouping = False
        Me.RGVRundschreibenaktuell.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.RGVRundschreibenaktuell.Name = "RGVRundschreibenaktuell"
        Me.RGVRundschreibenaktuell.ReadOnly = True
        Me.RGVRundschreibenaktuell.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVRundschreibenaktuell.Size = New System.Drawing.Size(1174, 500)
        Me.RGVRundschreibenaktuell.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(759, 54)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Die Bewerber bzw. Bewerberinnen müssen in der Tabelle mit der Maus angeklickt w" &
    "erden!"
        '
        'Tabellebtn
        '
        Me.Tabellebtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tabellebtn.ForeColor = System.Drawing.Color.Red
        Me.Tabellebtn.Image = CType(resources.GetObject("Tabellebtn.Image"), System.Drawing.Image)
        Me.Tabellebtn.Items.AddRange(New Telerik.WinControls.RadItem() {Me.AufklappenRadMenuItem1, Me.EinklappenRadMenuItem1})
        Me.Tabellebtn.Location = New System.Drawing.Point(974, 12)
        Me.Tabellebtn.Name = "Tabellebtn"
        Me.Tabellebtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Tabellebtn.Size = New System.Drawing.Size(163, 37)
        Me.Tabellebtn.TabIndex = 89
        Me.Tabellebtn.Text = "<html><span style=""font-size: 9pt"">Tabelle...</span></html>"
        CType(Me.Tabellebtn.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
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
        'btnRundschreibenaktuell_Close
        '
        Me.btnRundschreibenaktuell_Close.ForeColor = System.Drawing.Color.Red
        Me.btnRundschreibenaktuell_Close.Image = CType(resources.GetObject("btnRundschreibenaktuell_Close.Image"), System.Drawing.Image)
        Me.btnRundschreibenaktuell_Close.Location = New System.Drawing.Point(1156, 12)
        Me.btnRundschreibenaktuell_Close.Name = "btnRundschreibenaktuell_Close"
        Me.btnRundschreibenaktuell_Close.Size = New System.Drawing.Size(163, 37)
        Me.btnRundschreibenaktuell_Close.TabIndex = 88
        Me.btnRundschreibenaktuell_Close.Text = "<html><strong>   Fenster schließen>/strong></html>"
        '
        'btnEintraegeloeschenunduebertragen
        '
        Me.btnEintraegeloeschenunduebertragen.ForeColor = System.Drawing.Color.Red
        Me.btnEintraegeloeschenunduebertragen.Image = CType(resources.GetObject("btnEintraegeloeschenunduebertragen.Image"), System.Drawing.Image)
        Me.btnEintraegeloeschenunduebertragen.Location = New System.Drawing.Point(430, 12)
        Me.btnEintraegeloeschenunduebertragen.Name = "btnEintraegeloeschenunduebertragen"
        Me.btnEintraegeloeschenunduebertragen.Size = New System.Drawing.Size(201, 47)
        Me.btnEintraegeloeschenunduebertragen.TabIndex = 87
        Me.btnEintraegeloeschenunduebertragen.Text = "<html><strong> <br/>   Monatsauswahl löschen><br/>und übertragen</strong><br/></h" &
    "tml>"
        '
        'btnSave_Rundschreiben
        '
        Me.btnSave_Rundschreiben.ForeColor = System.Drawing.Color.Red
        Me.btnSave_Rundschreiben.Image = CType(resources.GetObject("btnSave_Rundschreiben.Image"), System.Drawing.Image)
        Me.btnSave_Rundschreiben.Location = New System.Drawing.Point(249, 10)
        Me.btnSave_Rundschreiben.Name = "btnSave_Rundschreiben"
        Me.btnSave_Rundschreiben.Size = New System.Drawing.Size(163, 49)
        Me.btnSave_Rundschreiben.TabIndex = 86
        Me.btnSave_Rundschreiben.Text = "<html><strong>         Rundschreibennormal <br />speichern</strong></html>"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 36)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Ausgewählte Bewerber/innen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "für das Kundenrundschreiben"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.SplitContainer3)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.btnPremiumEintraegeloeschen)
        Me.TabPage3.Controls.Add(Me.rbtnTabellePremium)
        Me.TabPage3.Controls.Add(Me.btnPremiumClose)
        Me.TabPage3.Controls.Add(Me.btnMonatPremiumloeschen)
        Me.TabPage3.Controls.Add(Me.btnRSPremiumspeichern)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1527, 844)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Rundschreiben Premium"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.chkAufHomepagePremium)
        Me.Panel3.Controls.Add(Label12)
        Me.Panel3.Controls.Add(Me.rbtnJaPremium)
        Me.Panel3.Controls.Add(Label13)
        Me.Panel3.Controls.Add(Me.rbtnNeinPremium)
        Me.Panel3.Controls.Add(Me.ListBox2)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(6, 630)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1500, 208)
        Me.Panel3.TabIndex = 103
        '
        'chkAufHomepagePremium
        '
        Me.chkAufHomepagePremium.AutoSize = True
        Me.chkAufHomepagePremium.Location = New System.Drawing.Point(131, 15)
        Me.chkAufHomepagePremium.Name = "chkAufHomepagePremium"
        Me.chkAufHomepagePremium.Size = New System.Drawing.Size(44, 20)
        Me.chkAufHomepagePremium.TabIndex = 110
        Me.chkAufHomepagePremium.Text = "Ja"
        Me.chkAufHomepagePremium.UseVisualStyleBackColor = True
        '
        'rbtnJaPremium
        '
        Me.rbtnJaPremium.AutoSize = True
        Me.rbtnJaPremium.ForeColor = System.Drawing.Color.Crimson
        Me.rbtnJaPremium.Location = New System.Drawing.Point(568, 13)
        Me.rbtnJaPremium.Name = "rbtnJaPremium"
        Me.rbtnJaPremium.Size = New System.Drawing.Size(43, 20)
        Me.rbtnJaPremium.TabIndex = 107
        Me.rbtnJaPremium.TabStop = True
        Me.rbtnJaPremium.Text = "Ja"
        Me.rbtnJaPremium.UseVisualStyleBackColor = True
        '
        'rbtnNeinPremium
        '
        Me.rbtnNeinPremium.AutoSize = True
        Me.rbtnNeinPremium.ForeColor = System.Drawing.Color.Crimson
        Me.rbtnNeinPremium.Location = New System.Drawing.Point(626, 13)
        Me.rbtnNeinPremium.Name = "rbtnNeinPremium"
        Me.rbtnNeinPremium.Size = New System.Drawing.Size(58, 20)
        Me.rbtnNeinPremium.TabIndex = 108
        Me.rbtnNeinPremium.TabStop = True
        Me.rbtnNeinPremium.Text = "Nein"
        Me.rbtnNeinPremium.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(341, 108)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(343, 84)
        Me.ListBox2.TabIndex = 105
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Crimson
        Me.Label11.Location = New System.Drawing.Point(338, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(346, 16)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Bereits in Premiumrundschreiben vorgeschlagen:"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Location = New System.Drawing.Point(6, 124)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.RGVRundschreibenPremiumMonat)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.RGVRundschreibenPremium)
        Me.SplitContainer3.Size = New System.Drawing.Size(1500, 500)
        Me.SplitContainer3.SplitterDistance = 322
        Me.SplitContainer3.TabIndex = 102
        '
        'RGVRundschreibenPremiumMonat
        '
        Me.RGVRundschreibenPremiumMonat.BackColor = System.Drawing.Color.Transparent
        Me.RGVRundschreibenPremiumMonat.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVRundschreibenPremiumMonat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RGVRundschreibenPremiumMonat.EnableAnalytics = False
        Me.RGVRundschreibenPremiumMonat.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGVRundschreibenPremiumMonat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVRundschreibenPremiumMonat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVRundschreibenPremiumMonat.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.AllowAddNewRow = False
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.AllowColumnChooser = False
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.AllowColumnReorder = False
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.AllowDeleteRow = False
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.AllowDragToGroup = False
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.AllowEditRow = False
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.AutoGenerateColumns = False
        GridViewDecimalColumn16.DataType = GetType(Integer)
        GridViewDecimalColumn16.EnableExpressionEditor = False
        GridViewDecimalColumn16.FieldName = "idrundschreibenpremiummonat"
        GridViewDecimalColumn16.HeaderText = "idrundschreibenpremiummonat"
        GridViewDecimalColumn16.IsAutoGenerated = True
        GridViewDecimalColumn16.IsVisible = False
        GridViewDecimalColumn16.Name = "idrundschreibenpremiummonat"
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.FieldName = "monat"
        GridViewTextBoxColumn9.HeaderText = "Rundschreiben"
        GridViewTextBoxColumn9.IsAutoGenerated = True
        GridViewTextBoxColumn9.Name = "monat"
        GridViewTextBoxColumn9.ReadOnly = True
        GridViewTextBoxColumn9.Width = 250
        GridViewDecimalColumn17.DataType = GetType(Integer)
        GridViewDecimalColumn17.EnableExpressionEditor = False
        GridViewDecimalColumn17.FieldName = "erledigt"
        GridViewDecimalColumn17.HeaderText = "erledigt"
        GridViewDecimalColumn17.IsAutoGenerated = True
        GridViewDecimalColumn17.IsVisible = False
        GridViewDecimalColumn17.Name = "erledigt"
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn16, GridViewTextBoxColumn9, GridViewDecimalColumn17})
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.DataSource = Me.RundschreibenpremiummonatBindingSource
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.EnableGrouping = False
        Me.RGVRundschreibenPremiumMonat.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.RGVRundschreibenPremiumMonat.Name = "RGVRundschreibenPremiumMonat"
        Me.RGVRundschreibenPremiumMonat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVRundschreibenPremiumMonat.Size = New System.Drawing.Size(322, 500)
        Me.RGVRundschreibenPremiumMonat.TabIndex = 0
        '
        'RundschreibenpremiummonatBindingSource
        '
        Me.RundschreibenpremiummonatBindingSource.DataMember = "rundschreibenpremiummonat"
        Me.RundschreibenpremiummonatBindingSource.DataSource = Me.BewerberDataSet
        '
        'RGVRundschreibenPremium
        '
        Me.RGVRundschreibenPremium.BackColor = System.Drawing.Color.Transparent
        Me.RGVRundschreibenPremium.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVRundschreibenPremium.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RGVRundschreibenPremium.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.RGVRundschreibenPremium.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVRundschreibenPremium.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVRundschreibenPremium.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RGVRundschreibenPremium.MasterTemplate.AllowAddNewRow = False
        Me.RGVRundschreibenPremium.MasterTemplate.AllowColumnReorder = False
        Me.RGVRundschreibenPremium.MasterTemplate.AllowDeleteRow = False
        Me.RGVRundschreibenPremium.MasterTemplate.AllowDragToGroup = False
        GridViewDecimalColumn18.DataType = GetType(Integer)
        GridViewDecimalColumn18.EnableExpressionEditor = False
        GridViewDecimalColumn18.FieldName = "bewid"
        GridViewDecimalColumn18.HeaderText = "bewid"
        GridViewDecimalColumn18.IsAutoGenerated = True
        GridViewDecimalColumn18.IsVisible = False
        GridViewDecimalColumn18.Name = "bewid"
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.FieldName = "bezeichnung"
        GridViewTextBoxColumn10.HeaderText = "bezeichnung"
        GridViewTextBoxColumn10.IsAutoGenerated = True
        GridViewTextBoxColumn10.IsVisible = False
        GridViewTextBoxColumn10.Name = "bezeichnung"
        GridViewDecimalColumn19.DataType = GetType(Integer)
        GridViewDecimalColumn19.EnableExpressionEditor = False
        GridViewDecimalColumn19.FieldName = "refnr"
        GridViewDecimalColumn19.HeaderText = "RefNr"
        GridViewDecimalColumn19.IsAutoGenerated = True
        GridViewDecimalColumn19.Name = "refnr"
        GridViewDecimalColumn19.ReadOnly = True
        GridViewDecimalColumn19.Width = 80
        GridViewComboBoxColumn19.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn19.DataType = GetType(Integer)
        GridViewComboBoxColumn19.DisplayMember = "anrede"
        GridViewComboBoxColumn19.EnableExpressionEditor = False
        GridViewComboBoxColumn19.FieldName = "idrundschreibenpremium"
        GridViewComboBoxColumn19.HeaderText = "Anrede"
        GridViewComboBoxColumn19.Name = "anrede"
        GridViewComboBoxColumn19.ReadOnly = True
        GridViewComboBoxColumn19.ValueMember = "id_bew"
        GridViewComboBoxColumn19.Width = 80
        GridViewComboBoxColumn20.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn20.DataType = GetType(Integer)
        GridViewComboBoxColumn20.DisplayMember = "vorname"
        GridViewComboBoxColumn20.EnableExpressionEditor = False
        GridViewComboBoxColumn20.FieldName = "idrundschreibenpremium"
        GridViewComboBoxColumn20.HeaderText = "Vorname"
        GridViewComboBoxColumn20.Name = "vorname"
        GridViewComboBoxColumn20.ReadOnly = True
        GridViewComboBoxColumn20.ValueMember = "id_bew"
        GridViewComboBoxColumn20.Width = 150
        GridViewComboBoxColumn21.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn21.DataType = GetType(Integer)
        GridViewComboBoxColumn21.DisplayMember = "name"
        GridViewComboBoxColumn21.EnableExpressionEditor = False
        GridViewComboBoxColumn21.FieldName = "idrundschreibenpremium"
        GridViewComboBoxColumn21.HeaderText = "Nachname"
        GridViewComboBoxColumn21.Name = "column1"
        GridViewComboBoxColumn21.ReadOnly = True
        GridViewComboBoxColumn21.ValueMember = "id_bew"
        GridViewComboBoxColumn21.Width = 200
        GridViewComboBoxColumn22.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn22.DataType = GetType(Integer)
        GridViewComboBoxColumn22.DisplayMember = "stand"
        GridViewComboBoxColumn22.EnableExpressionEditor = False
        GridViewComboBoxColumn22.FieldName = "idrundschreibenpremium"
        GridViewComboBoxColumn22.HeaderText = "Stand"
        GridViewComboBoxColumn22.Name = "stand"
        GridViewComboBoxColumn22.ReadOnly = True
        GridViewComboBoxColumn22.ValueMember = "id_bew"
        GridViewComboBoxColumn23.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn23.DataType = GetType(Integer)
        GridViewComboBoxColumn23.DisplayMember = "ulas"
        GridViewComboBoxColumn23.EnableExpressionEditor = False
        GridViewComboBoxColumn23.FieldName = "idrundschreibenpremium"
        GridViewComboBoxColumn23.HeaderText = "Ulas"
        GridViewComboBoxColumn23.Name = "ulas"
        GridViewComboBoxColumn23.ReadOnly = True
        GridViewComboBoxColumn23.ValueMember = "id_bew"
        GridViewComboBoxColumn24.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn24.DataType = GetType(Integer)
        GridViewComboBoxColumn24.DisplayMember = "ort"
        GridViewComboBoxColumn24.EnableExpressionEditor = False
        GridViewComboBoxColumn24.FieldName = "idrundschreibenpremium"
        GridViewComboBoxColumn24.HeaderText = "Wohnort"
        GridViewComboBoxColumn24.Name = "wohnort"
        GridViewComboBoxColumn24.ReadOnly = True
        GridViewComboBoxColumn24.ValueMember = "id_bew"
        GridViewComboBoxColumn24.Width = 150
        GridViewComboBoxColumn25.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn25.DataType = GetType(Integer)
        GridViewComboBoxColumn25.DisplayMember = "alter"
        GridViewComboBoxColumn25.EnableExpressionEditor = False
        GridViewComboBoxColumn25.FieldName = "idrundschreibenpremium"
        GridViewComboBoxColumn25.HeaderText = "Alter"
        GridViewComboBoxColumn25.Name = "alter"
        GridViewComboBoxColumn25.ReadOnly = True
        GridViewComboBoxColumn25.ValueMember = "id_bew"
        GridViewComboBoxColumn26.DataSource = Me.BewBindingSource
        GridViewComboBoxColumn26.DataType = GetType(Integer)
        GridViewComboBoxColumn26.DisplayMember = "arbeitsort"
        GridViewComboBoxColumn26.EnableExpressionEditor = False
        GridViewComboBoxColumn26.FieldName = "idrundschreibenpremium"
        GridViewComboBoxColumn26.HeaderText = "Arbeitsort"
        GridViewComboBoxColumn26.Name = "arbeitsort"
        GridViewComboBoxColumn26.ReadOnly = True
        GridViewComboBoxColumn26.ValueMember = "id_bew"
        GridViewComboBoxColumn26.Width = 150
        GridViewDecimalColumn20.DataType = GetType(Integer)
        GridViewDecimalColumn20.EnableExpressionEditor = False
        GridViewDecimalColumn20.FieldName = "aktuell"
        GridViewDecimalColumn20.HeaderText = "aktuell"
        GridViewDecimalColumn20.IsAutoGenerated = True
        GridViewDecimalColumn20.IsVisible = False
        GridViewDecimalColumn20.Name = "aktuell"
        GridViewDecimalColumn21.DataType = GetType(Integer)
        GridViewDecimalColumn21.EnableExpressionEditor = False
        GridViewDecimalColumn21.FieldName = "idrundschreibenmonatpremium"
        GridViewDecimalColumn21.HeaderText = "idrundschreibenmonatpremium"
        GridViewDecimalColumn21.IsAutoGenerated = True
        GridViewDecimalColumn21.IsVisible = False
        GridViewDecimalColumn21.Name = "idrundschreibenmonatpremium"
        GridViewDecimalColumn22.DataType = GetType(Integer)
        GridViewDecimalColumn22.EnableExpressionEditor = False
        GridViewDecimalColumn22.FieldName = "homepage"
        GridViewDecimalColumn22.HeaderText = "homepage"
        GridViewDecimalColumn22.IsAutoGenerated = True
        GridViewDecimalColumn22.IsVisible = False
        GridViewDecimalColumn22.Name = "homepage"
        GridViewTextBoxColumn11.EnableExpressionEditor = False
        GridViewTextBoxColumn11.FieldName = "anmerkungen"
        GridViewTextBoxColumn11.HeaderText = "anmerkungen"
        GridViewTextBoxColumn11.IsAutoGenerated = True
        GridViewTextBoxColumn11.IsVisible = False
        GridViewTextBoxColumn11.Name = "anmerkungen"
        GridViewDecimalColumn23.DataType = GetType(Integer)
        GridViewDecimalColumn23.EnableExpressionEditor = False
        GridViewDecimalColumn23.FieldName = "rundschreibenreihenfolge"
        GridViewDecimalColumn23.HeaderText = "Reihenfolge"
        GridViewDecimalColumn23.IsAutoGenerated = True
        GridViewDecimalColumn23.Name = "rundschreibenreihenfolge"
        GridViewDecimalColumn23.Width = 80
        GridViewDecimalColumn24.DataType = GetType(Integer)
        GridViewDecimalColumn24.EnableExpressionEditor = False
        GridViewDecimalColumn24.FieldName = "gelöscht"
        GridViewDecimalColumn24.HeaderText = "gelöscht"
        GridViewDecimalColumn24.IsAutoGenerated = True
        GridViewDecimalColumn24.IsVisible = False
        GridViewDecimalColumn24.Name = "gelöscht"
        GridViewCheckBoxColumn1.EnableExpressionEditor = False
        GridViewCheckBoxColumn1.FieldName = "premiumrundschreibenjanein"
        GridViewCheckBoxColumn1.HeaderText = "premiumrundschreibenjanein"
        GridViewCheckBoxColumn1.IsAutoGenerated = True
        GridViewCheckBoxColumn1.IsVisible = False
        GridViewCheckBoxColumn1.MinWidth = 20
        GridViewCheckBoxColumn1.Name = "premiumrundschreibenjanein"
        Me.RGVRundschreibenPremium.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn18, GridViewTextBoxColumn10, GridViewDecimalColumn19, GridViewComboBoxColumn19, GridViewComboBoxColumn20, GridViewComboBoxColumn21, GridViewComboBoxColumn22, GridViewComboBoxColumn23, GridViewComboBoxColumn24, GridViewComboBoxColumn25, GridViewComboBoxColumn26, GridViewDecimalColumn20, GridViewDecimalColumn21, GridViewDecimalColumn22, GridViewTextBoxColumn11, GridViewDecimalColumn23, GridViewDecimalColumn24, GridViewCheckBoxColumn1})
        Me.RGVRundschreibenPremium.MasterTemplate.DataSource = Me.RundschreibenpremiumBindingSource
        Me.RGVRundschreibenPremium.MasterTemplate.EnableGrouping = False
        Me.RGVRundschreibenPremium.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.RGVRundschreibenPremium.Name = "RGVRundschreibenPremium"
        Me.RGVRundschreibenPremium.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVRundschreibenPremium.Size = New System.Drawing.Size(1174, 500)
        Me.RGVRundschreibenPremium.TabIndex = 0
        '
        'RundschreibenpremiumBindingSource
        '
        Me.RundschreibenpremiumBindingSource.DataMember = "rundschreibenpremiummonat_rundschreibenpremium"
        Me.RundschreibenpremiumBindingSource.DataSource = Me.RundschreibenpremiummonatBindingSource
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Yellow
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Crimson
        Me.Label10.Location = New System.Drawing.Point(5, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(759, 25)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Die Bewerber bzw. Bewerberinnen müssen in der Tabelle mit der Maus angeklickt wer" &
    "den!"
        '
        'btnPremiumEintraegeloeschen
        '
        Me.btnPremiumEintraegeloeschen.ForeColor = System.Drawing.Color.Red
        Me.btnPremiumEintraegeloeschen.Image = CType(resources.GetObject("btnPremiumEintraegeloeschen.Image"), System.Drawing.Image)
        Me.btnPremiumEintraegeloeschen.Location = New System.Drawing.Point(682, 12)
        Me.btnPremiumEintraegeloeschen.Name = "btnPremiumEintraegeloeschen"
        Me.btnPremiumEintraegeloeschen.Size = New System.Drawing.Size(201, 47)
        Me.btnPremiumEintraegeloeschen.TabIndex = 100
        Me.btnPremiumEintraegeloeschen.Text = "<html><strong> <br/>   Eintrag löschen></strong><br/></html>"
        '
        'rbtnTabellePremium
        '
        Me.rbtnTabellePremium.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rbtnTabellePremium.ForeColor = System.Drawing.Color.Red
        Me.rbtnTabellePremium.Image = CType(resources.GetObject("rbtnTabellePremium.Image"), System.Drawing.Image)
        Me.rbtnTabellePremium.Items.AddRange(New Telerik.WinControls.RadItem() {Me.AufklappenPremium, Me.EinklappenPremium})
        Me.rbtnTabellePremium.Location = New System.Drawing.Point(999, 14)
        Me.rbtnTabellePremium.Name = "rbtnTabellePremium"
        Me.rbtnTabellePremium.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rbtnTabellePremium.Size = New System.Drawing.Size(163, 37)
        Me.rbtnTabellePremium.TabIndex = 99
        Me.rbtnTabellePremium.Text = "<html><span style=""font-size: 9pt"">Tabelle...</span></html>"
        CType(Me.rbtnTabellePremium.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.rbtnTabellePremium.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Text = "<html><span style=""font-size: 9pt"">Tabelle...</span></html>"
        CType(Me.rbtnTabellePremium.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        CType(Me.rbtnTabellePremium.GetChildAt(0), Telerik.WinControls.UI.RadDropDownButtonElement).CanFocus = True
        CType(Me.rbtnTabellePremium.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
        CType(Me.rbtnTabellePremium.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.Red
        CType(Me.rbtnTabellePremium.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        CType(Me.rbtnTabellePremium.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AufklappenPremium
        '
        Me.AufklappenPremium.Alignment = System.Drawing.ContentAlignment.MiddleRight
        Me.AufklappenPremium.DescriptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AufklappenPremium.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AufklappenPremium.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AufklappenPremium.Image = Nothing
        Me.AufklappenPremium.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.AufklappenPremium.Name = "AufklappenPremium"
        Me.AufklappenPremium.Padding = New System.Windows.Forms.Padding(10, 3, 5, 3)
        Me.AufklappenPremium.Text = "    Aufklappen"
        Me.AufklappenPremium.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.AufklappenPremium.UseCompatibleTextRendering = False
        '
        'EinklappenPremium
        '
        Me.EinklappenPremium.DescriptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EinklappenPremium.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EinklappenPremium.Image = Nothing
        Me.EinklappenPremium.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.EinklappenPremium.Name = "EinklappenPremium"
        Me.EinklappenPremium.Text = "      Einklappen"
        Me.EinklappenPremium.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.EinklappenPremium.UseCompatibleTextRendering = False
        '
        'btnPremiumClose
        '
        Me.btnPremiumClose.ForeColor = System.Drawing.Color.Red
        Me.btnPremiumClose.Image = CType(resources.GetObject("btnPremiumClose.Image"), System.Drawing.Image)
        Me.btnPremiumClose.Location = New System.Drawing.Point(1181, 14)
        Me.btnPremiumClose.Name = "btnPremiumClose"
        Me.btnPremiumClose.Size = New System.Drawing.Size(163, 37)
        Me.btnPremiumClose.TabIndex = 98
        Me.btnPremiumClose.Text = "<html><strong>   Fenster schließen>/strong></html>"
        '
        'btnMonatPremiumloeschen
        '
        Me.btnMonatPremiumloeschen.ForeColor = System.Drawing.Color.Red
        Me.btnMonatPremiumloeschen.Image = CType(resources.GetObject("btnMonatPremiumloeschen.Image"), System.Drawing.Image)
        Me.btnMonatPremiumloeschen.Location = New System.Drawing.Point(455, 14)
        Me.btnMonatPremiumloeschen.Name = "btnMonatPremiumloeschen"
        Me.btnMonatPremiumloeschen.Size = New System.Drawing.Size(201, 47)
        Me.btnMonatPremiumloeschen.TabIndex = 97
        Me.btnMonatPremiumloeschen.Text = "<html><strong><br /><br /><br />Monatsauswahl löschen<br /></strong><br /></html>" &
    ""
        '
        'btnRSPremiumspeichern
        '
        Me.btnRSPremiumspeichern.ForeColor = System.Drawing.Color.Red
        Me.btnRSPremiumspeichern.Image = CType(resources.GetObject("btnRSPremiumspeichern.Image"), System.Drawing.Image)
        Me.btnRSPremiumspeichern.Location = New System.Drawing.Point(274, 12)
        Me.btnRSPremiumspeichern.Name = "btnRSPremiumspeichern"
        Me.btnRSPremiumspeichern.Size = New System.Drawing.Size(163, 49)
        Me.btnRSPremiumspeichern.TabIndex = 96
        Me.btnRSPremiumspeichern.Text = "<html><strong>    Premiumeinträge<br />    speichern</strong></html>"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(238, 36)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Ausgewählte Bewerber/innen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "für das Premiumrundschreiben"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1527, 844)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rundschreibenübersicht"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnKWspeichern)
        Me.Panel2.Controls.Add(Me.lblKW)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblAktuellesDatum)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(7, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(562, 117)
        Me.Panel2.TabIndex = 5
        '
        'btnKWspeichern
        '
        Me.btnKWspeichern.ForeColor = System.Drawing.Color.Red
        Me.btnKWspeichern.Image = CType(resources.GetObject("btnKWspeichern.Image"), System.Drawing.Image)
        Me.btnKWspeichern.Location = New System.Drawing.Point(382, 44)
        Me.btnKWspeichern.Name = "btnKWspeichern"
        Me.btnKWspeichern.Size = New System.Drawing.Size(163, 37)
        Me.btnKWspeichern.TabIndex = 5
        Me.btnKWspeichern.Text = "<html><strong>Kalenderwoche<br/>eintragen</strong></html>"
        Me.btnKWspeichern.Visible = False
        '
        'lblKW
        '
        Me.lblKW.AutoSize = True
        Me.lblKW.BackColor = System.Drawing.Color.Yellow
        Me.lblKW.Location = New System.Drawing.Point(223, 79)
        Me.lblKW.Name = "lblKW"
        Me.lblKW.Size = New System.Drawing.Size(31, 16)
        Me.lblKW.TabIndex = 4
        Me.lblKW.Text = "KW"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Aktuelle Kalenderwoche:"
        '
        'lblAktuellesDatum
        '
        Me.lblAktuellesDatum.AutoSize = True
        Me.lblAktuellesDatum.BackColor = System.Drawing.Color.Yellow
        Me.lblAktuellesDatum.Location = New System.Drawing.Point(220, 44)
        Me.lblAktuellesDatum.Name = "lblAktuellesDatum"
        Me.lblAktuellesDatum.Size = New System.Drawing.Size(120, 16)
        Me.lblAktuellesDatum.TabIndex = 2
        Me.lblAktuellesDatum.Text = "Aktuelles Datum"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Aktuelles Datum: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(4, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kalenderwoche eintragen:"
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
        Me.TableAdapterManager.rundschreibenpremiummonatTableAdapter = Nothing
        Me.TableAdapterManager.rundschreibenpremiumTableAdapter = Nothing
        Me.TableAdapterManager.rundschreibenTableAdapter = Nothing
        Me.TableAdapterManager.ulasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = bewerberpool.BewerberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RundschreibenmonatTableAdapter
        '
        Me.RundschreibenmonatTableAdapter.ClearBeforeFill = True
        '
        'RundschreibenTableAdapter
        '
        Me.RundschreibenTableAdapter.ClearBeforeFill = True
        '
        'RundschreibenpremiummonatTableAdapter
        '
        Me.RundschreibenpremiummonatTableAdapter.ClearBeforeFill = True
        '
        'RundschreibenpremiumTableAdapter
        '
        Me.RundschreibenpremiumTableAdapter.ClearBeforeFill = True
        '
        'RundschreibenpremiumbewBindingSource
        '
        Me.RundschreibenpremiumbewBindingSource.DataMember = "rundschreibenpremium_bew"
        Me.RundschreibenpremiumbewBindingSource.DataSource = Me.RundschreibenpremiumBindingSource
        '
        'RundschreibenpremiumbewBindingSource1
        '
        Me.RundschreibenpremiumbewBindingSource1.DataMember = "rundschreibenpremium_bew"
        Me.RundschreibenpremiumbewBindingSource1.DataSource = Me.RundschreibenpremiumBindingSource
        '
        'frmRundschreibenuebersicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1548, 898)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRundschreibenuebersicht"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rundschreibenübersicht"
        CType(Me.BewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenmonatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.RGVRundschreibenMonat.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVRundschreibenMonat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVBewerber.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVBewerber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.btnEintraegeloeschen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.RGVRundschreibenmonataktuell.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVRundschreibenmonataktuell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVRundschreibenaktuell.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVRundschreibenaktuell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabellebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRundschreibenaktuell_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEintraegeloeschenunduebertragen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave_Rundschreiben, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.RGVRundschreibenPremiumMonat.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVRundschreibenPremiumMonat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenpremiummonatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVRundschreibenPremium.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVRundschreibenPremium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenpremiumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPremiumEintraegeloeschen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtnTabellePremium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPremiumClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMonatPremiumloeschen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRSPremiumspeichern, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnKWspeichern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenpremiumbewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RundschreibenpremiumbewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BewerberDataSet As BewerberDataSet
    Friend WithEvents BewBindingSource As BindingSource
    Friend WithEvents BewTableAdapter As BewerberDataSetTableAdapters.bewTableAdapter
    Friend WithEvents TableAdapterManager As BewerberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RundschreibenBindingSource As BindingSource
    Friend WithEvents RundschreibenmonatBindingSource As BindingSource
    Friend WithEvents RundschreibenmonatTableAdapter As BewerberDataSetTableAdapters.rundschreibenmonatTableAdapter
    Friend WithEvents RundschreibenTableAdapter As BewerberDataSetTableAdapters.rundschreibenTableAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents RGVRundschreibenMonat As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RGVBewerber As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Tabellebtn As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents AufklappenRadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents EinklappenRadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents btnRundschreibenaktuell_Close As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEintraegeloeschenunduebertragen As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave_Rundschreiben As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label4 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents RGVRundschreibenmonataktuell As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RGVRundschreibenaktuell As Telerik.WinControls.UI.RadGridView
    Friend WithEvents BewBindingSource1 As BindingSource
    Friend WithEvents RundschreibenBindingSource1 As BindingSource
    Friend WithEvents AnmerkungenTextBox As TextBox
    Friend WithEvents RundschreibenreihenfolgeTextBox As TextBox
    Friend WithEvents chkAufHomepage As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbtnNein As RadioButton
    Friend WithEvents rbtnJa As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAktuellesDatum As Label
    Friend WithEvents lblKW As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnKWspeichern As Telerik.WinControls.UI.RadButton
    Friend WithEvents chgNurhomepage As CheckBox
    Friend WithEvents btnEintraegeloeschen As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Label10 As Label
    Friend WithEvents btnPremiumEintraegeloeschen As Telerik.WinControls.UI.RadButton
    Friend WithEvents rbtnTabellePremium As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents AufklappenPremium As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents EinklappenPremium As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents btnPremiumClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnMonatPremiumloeschen As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnRSPremiumspeichern As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RGVRundschreibenPremiumMonat As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents rbtnNeinPremium As RadioButton
    Friend WithEvents rbtnJaPremium As RadioButton
    Friend WithEvents chkAufHomepagePremium As CheckBox
    Friend WithEvents RGVRundschreibenPremium As Telerik.WinControls.UI.RadGridView
    Friend WithEvents AktuellTextBox As TextBox
    Friend WithEvents RundschreibenpremiummonatBindingSource As BindingSource
    Friend WithEvents RundschreibenpremiummonatTableAdapter As BewerberDataSetTableAdapters.rundschreibenpremiummonatTableAdapter
    Friend WithEvents RundschreibenpremiumBindingSource As BindingSource
    Friend WithEvents RundschreibenpremiumTableAdapter As BewerberDataSetTableAdapters.rundschreibenpremiumTableAdapter
    Friend WithEvents RundschreibenpremiumbewBindingSource As BindingSource
    Friend WithEvents RundschreibenpremiumbewBindingSource1 As BindingSource
    Friend WithEvents Panel3 As Panel
End Class
