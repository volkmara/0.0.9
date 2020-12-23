Imports System.ComponentModel
Imports bewerberpool.oaDataSet
Imports bewerberpool.BewerberDataSet
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.Html
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinControls.RichTextEditor


Public Class frmOA

    Public liste As New BindingList(Of String)() ' enthält die ausgewählten Einträge, Listbox wird daran gebunden
    Public interviewerstellenliste As String = String.Empty ' Stellenvorschläge des Interviewers für Bewerber

    Public Shared vorschlagenfuerstelle_bool As Boolean = False
    Public Shared vorschlagenfuerstelle_interviewer_bool As Boolean = False

    Private _frmMain As frmMain
    Private _frmInterviewer As frmInterviewer

    Sub New(frmInterviewer As frmInterviewer)
        ' TODO: Complete member initialization 
        _frmInterviewer = frmInterviewer
        InitializeComponent()
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(frmMain As frmMain)
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmOA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        Me.Oa_stelleTableAdapter.Fill(Me.OaDataSet.oa_stelle)
        Me.BewBindingSource.DataSource = frmMain.BewBindingSource
        Me.BewBindingSource.Filter = "id_bew = '" & letzteid & "'"
    End Sub

    Private Sub frmOA_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each column As GridViewColumn In OAGridView.Columns
            If TypeOf column Is GridViewTextBoxColumn Then
                Dim col As GridViewTextBoxColumn = TryCast(column, GridViewTextBoxColumn)
                col.HeaderTextAlignment = ContentAlignment.MiddleLeft
            End If
            Me.OAGridView.Rows(0).IsCurrent = True
            Me.OAGridView.Columns(4).WrapText = True
        Next

        Me.OAGridView.MasterTemplate.ShowFilterCellOperatorText = False

        '  Call auswaehlen()
        Call voreintraege()
        ' Call columnsausblenden()
    End Sub

#Region "Grid formatieren"

    Private Sub OAGridView_ViewCellFormatting(ByVal sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles OAGridView.ViewCellFormatting
        Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

        If TypeOf e.CellElement Is GridHeaderCellElement Then
            e.CellElement.Font = newFont10
        Else
            e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

        If e.CellElement.ColumnInfo.Name = "oa_kunde" Then
            e.CellElement.Font = newFont10
            e.CellElement.DrawFill = True
            e.CellElement.NumberOfColors = 1
            e.CellElement.BackColor = Color.Yellow
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        End If
    End Sub
#End Region

#Region "Einträge auswählen, Einträge abwählen, voreingetragene Werte einlesen"

    ' Es werden die Werte ausgelesen, die bereits früher eingetragen wurden und in die Bindinglist eingetragen, die mit Listbox1 verbunden ist
    Private Sub voreintraege()

        Dim stellewerte = DirectCast(DirectCast(frmMain.BewBindingSource.Current, DataRowView).Row, bewRow)
        Dim lines() As String
        Dim eintraege As String = String.Empty

        Select Case True
            'frmMain
            Case vorschlagenfuerstelle_bool
                If stellewerte.IsfuerstelleNull OrElse stellewerte.fuerstelle = String.Empty Then
                    Return
                Else
                    eintraege = CStr(stellewerte.fuerstelle)
                End If

                'frmInterviewer
            Case vorschlagenfuerstelle_interviewer_bool
                If stellewerte.IsfuerstelleNull OrElse stellewerte.fuerstelle = String.Empty Then
                    Return
                Else
                    eintraege = CStr(stellewerte.fuerstelle)
                End If
        End Select

        'Wenn keine früheren Einträge vorhanden sind, wird nichts eingetragen und die Bindinglist nicht mit der Listbox1 verbunden

        lines = eintraege.Split(vbNewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)

        If lines.Count > 0 Then
            For Each item In lines
                liste.Add(item)
            Next
            ListBox1.DataSource = liste
        Else
            Exit Sub
        End If
    End Sub

    Private Sub auswaehlen()
        Dim oawerte = DirectCast(DirectCast(Oa_stelleBindingSource.Current, DataRowView).Row, oa_stelleRow)
        Dim werte As String = String.Empty
        Dim länge As Integer = 0

        Select Case True
            ' Die Auftragsbezeichnungen aus OA werden übernommen und ggf. auf 50 Zeichen gekürzt

            ' Felder in frmMain
            Case vorschlagenfuerstelle_bool

                länge = oawerte.oa_ueberschrift.Length
                If länge > 50 Then
                    werte = String.Concat("Refnr: ", oawerte.oa_referenznummer, ", Kunde: ", oawerte.oa_kunde, " , Stelle: ", oawerte.oa_ueberschrift.Substring(0, 50), vbNewLine, vbNewLine)
                ElseIf länge <= 50 Then
                    werte = String.Concat("Refnr: ", oawerte.oa_referenznummer, ", Kunde: ", oawerte.oa_kunde, " , Stelle: ", oawerte.oa_ueberschrift, vbNewLine, vbNewLine)
                End If

                liste.Add(werte)
                interviewerstellenliste = String.Join(vbNewLine, liste)
                ListBox1.DataSource = liste

                ' Felder im Interviewerfragebogen

            Case vorschlagenfuerstelle_interviewer_bool
                länge = oawerte.oa_ueberschrift.Length
                If länge > 50 Then
                    werte = String.Concat("Refnr: ", oawerte.oa_referenznummer, ", Kunde: ", oawerte.oa_kunde, " , Stelle: ", oawerte.oa_ueberschrift.Substring(0, 50), vbNewLine)
                ElseIf länge <= 50 Then
                    werte = String.Concat("Refnr: ", oawerte.oa_referenznummer, ", Kunde: ", oawerte.oa_kunde, " , Stelle: ", oawerte.oa_ueberschrift, vbNewLine)
                End If

                liste.Add(werte)
                interviewerstellenliste = String.Join(vbNewLine, liste)
                ListBox1.DataSource = liste
        End Select
    End Sub

    Private Sub OAGridView_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs) Handles OAGridView.CurrentRowChanged
        Call ImportHtml()
    End Sub

    Private Sub OAGridView_DoubleClick(sender As Object, e As EventArgs) Handles OAGridView.DoubleClick
        Call auswaehlen()

        If liste.Count > 0 Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If
    End Sub

#End Region

#Region "Auftragsbeschreibung"
    Public Sub SetDefaultFontPropertiesToEditor(ByVal editor As RadRichTextEditor)
        editor.RichTextBoxElement.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial"))
        editor.DocumentInheritsDefaultStyleSettings = True
    End Sub

    Private Sub ImportHtml()
        Dim oawerte = DirectCast(DirectCast(Oa_stelleBindingSource.Current, DataRowView).Row, oa_stelleRow)
        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Html.HtmlFormatProvider()
        provider.ImportSettings.UseDefaultStylesheetForFontProperties = True
        Me.RadRTEhtml.Document = provider.Import(oawerte.oa_texthtml)
        Me.RadRTEhtml.Document.Selection.SelectAll()
        Me.RadRTEhtml.DocumentEditor.ChangeFontSize(Unit.PointToDip(10))
        Me.RadRTEhtml.Document.Selection.Clear()
    End Sub
#End Region

    Private Sub datenuebertragen()
        Select Case True

            ' frmMain
            Case vorschlagenfuerstelle_bool
                ' If CStr(interviewerstellenliste) <> String.Empty Then
                Dim bewerber = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
                    bewerber.fuerstelle = CStr(interviewerstellenliste)
                    'Me.Validate()
                    'Me.BewBindingSource.EndEdit()

                'End If

            ' frmInterviewer
            Case vorschlagenfuerstelle_interviewer_bool
                If CStr(interviewerstellenliste) <> String.Empty Then
                    Dim bewerber = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
                    bewerber.fuerstelle = CStr(interviewerstellenliste)
                    _frmInterviewer.txtFuerstelle.Text = CStr(interviewerstellenliste)
                End If
        End Select
    End Sub

    ' Buttons
    Private Sub btneintragloeschen_Click(sender As Object, e As EventArgs) Handles btneintragloeschen.Click, btnCloseandDelete.Click, btnWerteeintragenFensterschliessen.Click
        Select Case True
            Case sender Is btneintragloeschen
                Dim idx As Integer = CInt(ListBox1.SelectedIndex)
                liste.RemoveAt(idx)
                interviewerstellenliste = String.Join(vbNewLine, liste)

            Case sender Is btnCloseandDelete
                vorschlagenfuerstelle_bool = False
                vorschlagenfuerstelle_interviewer_bool = False

                liste.Clear()
                interviewerstellenliste = String.Empty
                Me.Close()

            Case sender Is btnWerteeintragenFensterschliessen

                If vorschlagenfuerstelle_bool Then
                    ' If liste.Count > 0 Then
                    Call datenuebertragen()
                    MessageBox.Show("Bitte abspeichern, um die ausgewählten Stellen in die Datenbank zu übernehmen.", "Abspeichern", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'End If
                    frmMain.oa_ausgewaehlt = True
                End If

                If vorschlagenfuerstelle_interviewer_bool Then
                    'If liste.Count > 0 Then
                    Call datenuebertragen()
                    'End If
                    frmMain.oa_ausgewaehlt = True
                End If

                vorschlagenfuerstelle_bool = False
                vorschlagenfuerstelle_interviewer_bool = False

                liste.Clear()
                interviewerstellenliste = String.Empty
                Me.Close()
        End Select
    End Sub

    Private Sub frmOA_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If liste.Count = 0 Then
            Me.BewBindingSource.RemoveFilter()
        End If
    End Sub
End Class