Imports Telerik.WinControls.UI.Localization
Imports Telerik.WinControls.RichTextEditor
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.Rtf
Imports Telerik.WinForms.Documents.FormatProviders.Txt
Imports Telerik.WinForms.RichTextEditor
Imports Telerik.WinForms.Documents.RichTextBoxCommands
Imports bewerberpool.BewerberDataSet
Public Class frmPersönlichkeitbearbeiten

    Public Shared Property bewerberbeschreibungtext As String = String.Empty
    Public Shared Property bewerberbeschreibung As String = String.Empty

    Public exportfilertf As String = String.Empty
    Public exportfiletxt As String = String.Empty
    Public importfilertf As String = String.Empty
    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmPersönlichkeitbearbeiten_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        If connectionString.Contains("127.0.0.1") Then
            RichTextBoxLocalizationProvider.CurrentProvider = RichTextBoxLocalizationProvider.FromFile("RichTextBoxStrings.xml")
        Else
            RichTextBoxLocalizationProvider.CurrentProvider = RichTextBoxLocalizationProvider.FromFile("x:\bewerberpool\RichTextBoxStrings.xml")
        End If
        Me.BewBindingSource.DataSource = frmMain.BewBindingSource
    End Sub

    Private Sub frmPersönlichkeitbearbeiten_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call bewerberbeschreibungladen()
    End Sub

    Private Sub export()
        Dim providerrtf As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        Dim providertxt As New Telerik.WinForms.Documents.FormatProviders.Txt.TxtFormatProvider()

        '  Dim exportfilertf As String = String.Empty
        exportfilertf = allgemein.ExporttoRtf(Me.RTEPersoenlichkeit.Document)
        exportfiletxt = allgemein.ExporttoTxt(Me.RTEPersoenlichkeit.Document)

    End Sub

    Private Sub bewerberbeschreibungladen() ' Lädt Bewerberbeschreibung und prüft, ob RTF oder nicht

        Dim bewgrid = DirectCast(DirectCast(frmMain.BewBindingSource.Current, DataRowView).Row, bewRow)

        ' Dim bewerberbeschreibung As String = String.Empty
        'Dim bewerberbeschreibungtext As String = String.Empty
        Dim bewerberbeschreibung_bool As Boolean = True
        Dim bewerberbeschreibungtxt_bool As Boolean = True
        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        Dim provider1 As New Telerik.WinForms.Documents.FormatProviders.Txt.TxtFormatProvider()
        Dim content As String = CStr("{\rtf\ansi\ansicpg1252\uc1\deff0\deflang1033{\fonttbl{\f0 Verdana;}}{\colortbl\red0\green0\blue0 ;}{\*\defchp\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone}{\*\defpap\sl276\slmult1\ql\sa180\ltrpar}{\stylesheet{\s0\sqformat\spriority0\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Normal;}{\*\ts2\tsrowd\spriority59\trbrdrt\brdrnone\trbrdrb\brdrnone\trbrdrl\brdrnone\trbrdrr\brdrnone\trbrdrh\brdrnone\trbrdrv\brdrnone\trgaph0\trpaddl75\trpaddr75\trpaddt0\trpaddb0\clpadft3\clpadt0\clpadfr3\clpadr0\clpadfl3\clpadl0\clpadfb3\clpadb0\tsvertalt\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Table Normal;}}\nouicompat\viewkind4\paperw12240\paperh15840\margl1425\margr1425\margt1425\margb1425\deftab720\sectd\pgwsxn12240\pghsxn15840\marglsxn1425\margrsxn1425\margtsxn1425\margbsxn1425\headery720\footery720\pard\s0\sl276\slmult1\ql\sa180\ltrpar{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone  }{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\par}}")

        ' Wenn eintrag in DB DBNull ist, einen nach RTF leeren String importieren und Sub beenden
        If bewgrid.IsbewerberbeschreibungNull Then
            '  RTEBewerberbeschreibung.Document = provider.Import(content)
            bewerberbeschreibung_bool = False
            '   Exit Sub
        End If

        If bewgrid.Isbewerberbeschreibung_textNull Then
            bewerberbeschreibungtxt_bool = False
        End If

        ' Wenn eintrag in DB nicht DBNull ist, geht es hier weiter
        If bewerberbeschreibung_bool Then
            bewerberbeschreibung = CStr(bewgrid.bewerberbeschreibung)
        End If

        If bewerberbeschreibungtxt_bool Then
            bewerberbeschreibungtext = CStr(bewgrid.bewerberbeschreibung_text)
        End If

        If bewerberbeschreibung_bool AndAlso bewerberbeschreibung.Contains("{\rtf") Then
            RTEPersoenlichkeit.Document = provider.Import(bewerberbeschreibung)
            RTEPersoenlichkeit.Document.Selection.SelectAll()
            RTEPersoenlichkeit.DocumentEditor.ChangeFontSize(15)
            RTEPersoenlichkeit.DocumentEditor.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Microsoft Sans Serif"))
            RTEPersoenlichkeit.Document.Selection.Clear()
        ElseIf Not bewerberbeschreibung.Contains("{\rtf") Then
            RTEPersoenlichkeit.Document = provider1.Import(bewerberbeschreibungtext)
            RTEPersoenlichkeit.Document.Selection.SelectAll()
            RTEPersoenlichkeit.DocumentEditor.ChangeFontSize(15)
            RTEPersoenlichkeit.DocumentEditor.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Microsoft Sans Serif"))
            RTEPersoenlichkeit.Document.Selection.Clear()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' Es werden nur die Daten nach frmMain übertragen und dort erst gespeichert.
        Call export()
        bewerberbeschreibungtext = exportfiletxt
        bewerberbeschreibung = exportfilertf

        ' Änderungen werden direkt im Hauptfenster angezeigt
        If bewerberbeschreibung.Contains("{\rtf") Then
            Dim provider_uebergabefrmMain As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
            frmMain.RTEBewerberbeschreibung.Document = provider_uebergabefrmMain.Import(bewerberbeschreibung)
        ElseIf Not bewerberbeschreibung.Contains("{\rtf") Then
            Dim provider1_uebergabefrmMain As New Telerik.WinForms.Documents.FormatProviders.Txt.TxtFormatProvider()
            frmMain.RTEBewerberbeschreibung.Document = provider1_uebergabefrmMain.Import(bewerberbeschreibung)
        End If

        MessageBox.Show("Um Ihre Änderungen zu speichern, klicken Sie bitte auf ""Speichern"", nachdem sich dieses Fenster geschlossen hat", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class