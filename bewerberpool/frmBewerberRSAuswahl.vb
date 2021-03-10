Imports bewerberpool.BewerberDataSet
Imports bewerberpool.oaDataSet
Imports Telerik.WinControls.UI

Public Class frmBewerberRSAuswahl
    Private frmMain As frmMain

    Public Sub New(frmMain As frmMain)
        Me.frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmBewerberRSAuswahl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "OaDataSet.oa_stelle". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Oa_stelleTableAdapter.Fill(Me.OaDataSet.oa_stelle)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberDataSet.bew". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)

    End Sub

    Private Sub frmBewerberRSAuswahl_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.BewBindingSource.Filter = "stand = 'aktuell'"
        Me.Oa_stelleBindingSource.Filter = "oa_status = 'aktiv'"
        Me.RGVStelle.AutoSizeRows = True
        Me.RGVBewerber.AutoSizeRows = True
        Me.RGVStelle.Columns(3).WrapText = True
        Me.RGVStelle.Columns(6).WrapText = True
        Me.RGVStelle.Columns(7).WrapText = True
        Me.RGVBewerber.MasterTemplate.ShowFilterCellOperatorText = False
        Me.RGVStelle.MasterTemplate.ShowFilterCellOperatorText = False
    End Sub

    Private Sub RGVStelle_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs)
        Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

        If TypeOf e.CellElement Is GridHeaderCellElement Then
            e.CellElement.Font = newFont10
        Else
            e.CellElement.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub Bewerberbeschreibungladen()

        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        Dim provider1 As New Telerik.WinForms.Documents.FormatProviders.Txt.TxtFormatProvider()

        Dim bewgrid = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        Dim bewerberbeschreibung As String = bewgrid.bewerberbeschreibung
        RTEBewerber.Document = provider.Import(bewerberbeschreibung)
        RTEBewerber.Document.Selection.SelectAll()
        RTEBewerber.DocumentEditor.ChangeFontSize(15)
        RTEBewerber.DocumentEditor.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Microsoft Sans Serif"))
        RTEBewerber.Document.Selection.Clear()

    End Sub

    Private Sub RGVBewerber_Click(sender As Object, e As EventArgs) Handles RGVBewerber.Click
        Call Bewerberbeschreibungladen()
    End Sub
End Class