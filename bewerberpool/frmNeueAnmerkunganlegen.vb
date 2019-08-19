Imports Telerik.WinControls.RichTextEditor
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.Rtf
Imports Telerik.WinForms.Documents.FormatProviders.Txt
Imports Telerik.WinForms.RichTextEditor
Imports Telerik.WinForms.Documents.RichTextBoxCommands
Imports bewerberpool.BewerberDataSet
Public Class frmNeueAnmerkunganlegen

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Public Shared Property anmerkungneu_bool As Boolean = False
    Public Shared Property alt_bool As Boolean = False
    Public Shared Property eingestellt_bool As Boolean = False
    Public Shared Property vermittelt_bool As Boolean = False
    Public Shared Property eingestellt_vermittelt_bool As Boolean = False

    Public Shared Property anmerkungdragdrop_bool As Boolean = False
    Public Shared Property droptext As String = String.Empty
    Public exportfilertf As String = String.Empty
    Public exportfiletxt As String = String.Empty

    Private Sub frmNeueAnmerkunganlegen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.NotizenTableAdapter.FillBy(Me.BewerberDataSet.notizen, CInt(letzteid))
        ' frmMain.NotizenTableAdapter.FillBy(frmMain.BewerberDataSet.notizen, CInt(letzteid))
        ' Me.NotizenBindingSource.DataSource = frmMain.NotizenBindingSource.Current
        ' Me.NotizenBindingSource.AddNew()
        Call neueanmerkunganlegen()
        ' Fenster in den Vordergrund und wieder freigeben
        TopMost = True
        TopMost = False
    End Sub

    Private Sub frmNeueAnmerkunganlegen_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' Prüfung, ob ein ein Bewerber ausgewählt wurde
        If CInt(letzteid) = 0 Then
            MessageBox.Show("Bitte wählen Sie eine/n Bewerber/in in der Tabelle aus und klicken Sie dann erneut auf den Button ""Neue Anmerkung anlegen""", "Bitte zuerst Bewerber/in auswählen", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If
    End Sub

    Private Sub neueanmerkunganlegen()

        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        Dim contentleer As String = CStr("{\rtf\ansi\ansicpg1252\uc1\deff0\deflang1033{\fonttbl{\f0 Verdana;}}{\colortbl\red0\green0\blue0 ;}{\*\defchp\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone}{\*\defpap\sl276\slmult1\ql\sa180\ltrpar}{\stylesheet{\s0\sqformat\spriority0\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Normal;}{\*\ts2\tsrowd\spriority59\trbrdrt\brdrnone\trbrdrb\brdrnone\trbrdrl\brdrnone\trbrdrr\brdrnone\trbrdrh\brdrnone\trbrdrv\brdrnone\trgaph0\trpaddl75\trpaddr75\trpaddt0\trpaddb0\clpadft3\clpadt0\clpadfr3\clpadr0\clpadfl3\clpadl0\clpadfb3\clpadb0\tsvertalt\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\sl276\slmult1\ql\sa180\ltrpar Table Normal;}}\nouicompat\viewkind4\paperw12240\paperh15840\margl1425\margr1425\margt1425\margb1425\deftab720\sectd\pgwsxn12240\pghsxn15840\marglsxn1425\margrsxn1425\margtsxn1425\margbsxn1425\headery720\footery720\pard\s0\sl276\slmult1\ql\sa180\ltrpar{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone  }{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\par}}")
        Me.AnmerkungRTE.Document = provider.Import(contentleer)
        Dim rtfeintragen = DirectCast(DirectCast(Me.NotizenBindingSource.AddNew, DataRowView).Row, notizenRow)

        Select Case True
            Case anmerkungneu_bool
                Me.BetreffListBox.Items.AddRange(New Object() {"Angebot", vbNewLine, "Anmerkungen zum Bewerbungsgespräch", vbNewLine, "Telefonkontakt", "Emailkontakt", "Email mit Nachfrage nach aktuellem Stand versandt", vbNewLine, "Vorsicht", vbNewLine, "von uns eingestellt", "von uns vermittelt", "hat neue Stelle", "hat neue Stelle, sucht weiter", vbNewLine, "sucht noch", "sucht wieder", vbNewLine, "Rundschreiben", vbNewLine, "Persönlichkeit/Äußeres etc.", vbNewLine, "Kununu"})
            Case alt_bool
                Me.BetreffListBox.Items.AddRange(New Object() {"hat neue Stelle", "hat neue Stelle, sucht weiter", "Bewerber/in ist nicht zu erreichen"})
            Case eingestellt_bool
                Me.BetreffListBox.Items.Add("von uns eingestellt")
                Me.BetreffListBox.SelectedIndex = 0
            Case vermittelt_bool
                Me.BetreffListBox.Items.Add("von uns vermittelt")
                Me.BetreffListBox.SelectedIndex = 0
            Case eingestellt_vermittelt_bool
                Me.BetreffListBox.Items.Add("von uns eingestellt und vermittelt")
                Me.BetreffListBox.SelectedIndex = 0
            Case anmerkungdragdrop_bool
                Me.BetreffListBox.Items.AddRange(New Object() {"Angebot", vbNewLine, "Anmerkungen zum Bewerbungsgespräch", vbNewLine, "Telefonkontakt", "Emailkontakt", "Vorsicht", vbNewLine, "von uns eingestellt", "von uns vermittelt", "hat neue Stelle", "hat neue Stelle, sucht weiter", vbNewLine, "sucht noch", "sucht wieder", vbNewLine, "Rundschreiben", vbNewLine, "Persönlichkeit/Äußeres etc.", vbNewLine, "Kununu"})
                Dim provider1 As New Telerik.WinForms.Documents.FormatProviders.Txt.TxtFormatProvider
                Me.AnmerkungRTE.Document = provider1.Import(droptext)
        End Select

        AnmerkungRTE.Focus()
    End Sub

    Private Sub btnNeueAnmerkungSpeichern_Click(sender As Object, e As EventArgs) Handles btnNeueAnmerkungSpeichern.Click
        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()

        Dim rtfeintragen = DirectCast(DirectCast(Me.NotizenBindingSource.Current, DataRowView).Row, notizenRow)

        ' RTF und txt auslesen
        '  Dim exportfilertf As String = String.Empty
        ' Dim exportfiletxt As String = String.Empty

        Call doppelteleerzeilen() ' entfernt doppelte Leerzeilen in Richtext und Text

        exportfilertf = allgemein.ExporttoRtf(Me.AnmerkungRTE.Document)
        exportfiletxt = allgemein.ExporttoTxt(Me.AnmerkungRTE.Document)

        If exportfiletxt <> String.Empty Then
            Dim result As DialogResult = MessageBox.Show("Möchten Sie Ihre neue Anmerkung abspeichern, dann drücken Sie auf den Button ""Ja"", wenn Sie nicht speichern wollen, auf den Button ""Nein""", "Neue Anmerkung speichern", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.Yes Then
                If CStr(BetreffListBox.SelectedItem.ToString) = String.Empty OrElse CStr(exportfilertf) = String.Empty OrElse CStr(exportfiletxt) = String.Empty Then
                    MessageBox.Show("Bitte einen Betreff und/oder einen Anmerkungstext eintragen", "Fehlender Eintrag", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    rtfeintragen.betreff = CStr(BetreffListBox.SelectedItem.ToString)
                    rtfeintragen.anmerkungen_rtf = CStr(exportfilertf)
                    rtfeintragen.anmerkungen_text = CStr(exportfiletxt)
                    rtfeintragen.eingetragen_von = CStr(usernameklar)
                    '   rtfeintragen.geaendert_von = String.Empty ' darf nicht dbnull sein
                    rtfeintragen.eingetragen_am = Date.Now
                    rtfeintragen.geaendert_am = CDate("1970-01-01 00:00:00")
                    rtfeintragen.bewid = CInt(letzteid)

                    Me.Validate()
                    Me.NotizenBindingSource.EndEdit()
                    Me.NotizenTableAdapter.Update(Me.BewerberDataSet.notizen)
                    Call gespeichert()
                    frmMain.NotizenTableAdapter.FillBy(frmMain.BewerberDataSet.notizen, CInt(letzteid))
                    'frmMain.NotizenTableAdapter.Fill(frmMain.BewerberDataSet.notizen)
                    'frmMain.NotizenRadGridView.Refresh()
                    ' frmMain.DBLoad() ' Datenbank wird neu geladen
                    frmMain.letzteanmerkunganzeigen() ' Letzte Anmerkung wird in frmMain in das Feld im Reiter Bewerber/in geladen
                    droptext = String.Empty
                    Me.Close()
                End If
            ElseIf result = Windows.Forms.DialogResult.No Then
                    Exit Sub
            End If
        Else
            MessageBox.Show("Keine Anmerkung eingetragen", "Keine Anmerkung eingetragen", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Entfernt doppelte Leerzeilen aus RTE-Editor-Richtext
    Private Sub doppelteleerzeilen()
        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        Dim text As String = provider.Export(AnmerkungRTE.Document)
        Dim textneu As String = String.Empty
        Dim rausrein As String = "{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\par}"
        Dim raus As String = "{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\par}\pard\s0\sl276\slmult1\ql\sa180\ltrpar{\ltrch\f0\fs24\i0\b0\strike0\cf0\ulc0\ulnone\par}\pard\s0\sl276\slmult1\ql\sa180\ltrpar"

        textneu = text.Replace(raus, rausrein)
        Me.AnmerkungRTE.Document = provider.Import(textneu)
    End Sub
End Class