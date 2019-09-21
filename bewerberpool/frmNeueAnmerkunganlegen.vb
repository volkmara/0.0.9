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

        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        Me.NotizenTableAdapter.Fill(Me.BewerberDataSet.notizen)
        Me.BewBindingSource.DataSource = frmMain.BewBindingSource

        Call neueanmerkunganlegen() ' Den Text der Anmerkung vorgenerieren
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

        Dim notizeneintragen = DirectCast(DirectCast(Me.NotizenBindingSource.AddNew, DataRowView).Row, notizenRow)
        Dim bew = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow) ' um das Datum der letzten Anmerkung bei einem Bewerber in bew einzutragen, damit das gefiltert werden kann

        ' den eingegebenen Anmerkungstext auslesen, um ihn in DB zu speichern
        exportfilertf = allgemein.ExporttoRtf(Me.AnmerkungRTE.Document)
        exportfiletxt = allgemein.ExporttoTxt(Me.AnmerkungRTE.Document)

        If exportfiletxt <> String.Empty Then
            Dim result As DialogResult = MessageBox.Show("Möchten Sie Ihre neue Anmerkung abspeichern, dann drücken Sie auf den Button ""Ja"", wenn Sie nicht speichern wollen, auf den Button ""Nein""", "Neue Anmerkung speichern", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.Yes Then
                If CStr(BetreffListBox.SelectedItem.ToString) = String.Empty OrElse CStr(exportfilertf) = String.Empty OrElse CStr(exportfiletxt) = String.Empty Then
                    MessageBox.Show("Bitte einen Betreff und/oder einen Anmerkungstext eintragen", "Fehlender Eintrag", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    notizeneintragen.betreff = CStr(BetreffListBox.SelectedItem.ToString)
                    notizeneintragen.anmerkungen_rtf = CStr(exportfilertf)
                    notizeneintragen.anmerkungen_text = CStr(exportfiletxt)
                    notizeneintragen.eingetragen_von = CStr(usernameklar)
                    '   rtfeintragen.geaendert_von = String.Empty ' darf nicht dbnull sein
                    notizeneintragen.eingetragen_am = Date.Now
                    notizeneintragen.geaendert_am = CDate("1970-01-01 00:00:00")
                    notizeneintragen.bewid = CInt(letzteid)

                    bew.letztes_datum_anmerkung = Date.Now ' um das Datum der letzten Anmerkung bei einem Bewerber in bew einzutragen, damit das gefiltert werden kann

                    Me.Validate()
                    Me.NotizenBindingSource.EndEdit()
                    Me.NotizenTableAdapter.Update(Me.BewerberDataSet.notizen)

                    Me.BewBindingSource.EndEdit()
                    frmMain.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)

                    Call gespeichert()

                    'frmMain.NotizenTableAdapter.FillBy(frmMain.BewerberDataSet.notizen, CInt(letzteid))
                    frmMain.NotizenTableAdapter.Fill(frmMain.BewerberDataSet.notizen)
                    frmMain.BewTableAdapter.Fill(frmMain.BewerberDataSet.bew)
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
    Private Sub AnmerkungRTE_Enter(sender As Object, e As EventArgs) Handles AnmerkungRTE.Enter
        Dim text1 As String = Clipboard.GetText
        If text1 Is Nothing OrElse text1 = String.Empty Then
            Exit Sub
        Else
            Dim text2 As String = text1.Replace(vbCrLf & vbCrLf & vbCrLf, vbCrLf)
            AnmerkungRTE.Text = text2.Replace(vbCrLf & vbCrLf, vbCrLf)
            Clipboard.Clear()
        End If
    End Sub
End Class