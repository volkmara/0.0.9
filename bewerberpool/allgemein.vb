Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.WinControls
Imports Telerik.WinControls.RichTextEditor
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.Rtf
Imports Telerik.WinForms.Documents.FormatProviders.Txt
Imports bewerberpool.BewerberDataSet
Imports bewerberpool.heyduckDataSet

Public Class allgemein

    Public Shared Function Anmerkungvorhanden(ByVal test As Integer) As Boolean
        Return frmMain.BewerberDataSet.notizen.Any(Function(rw) rw.bewid = test)
    End Function

    Public Shared Function ExporttoRtf(ByVal document As RadDocument) As String
        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
        Return provider.Export(document)
    End Function

    Public Shared Function ExporttoTxt(ByVal document As RadDocument) As String
        Dim provider As New Telerik.WinForms.Documents.FormatProviders.Txt.TxtFormatProvider()
        Return provider.Export(document)
    End Function

    '  Public Shared Function ImporttoRtf(ByVal document As RadDocument) As String
    'Dim provider As New Telerik.WinForms.Documents.FormatProviders.Rtf.RtfFormatProvider()
    '   Return provider.Import(document)
    'End Function

    Public Shared Function refnrhomepage(ByVal test As Integer) As Boolean
        Return frmMain.HeyduckDataSet.tt_news.Any(Function(x) CInt(x.tx_ttnewserweiterung_referenznummer) = test)
    End Function

    ' Public Shared Function Inetverbindung(ByVal url As Boolean) As Boolean
    '    Try
    '       My.Computer.Network.Ping("www.heyduck-personalservice.de")
    '      Return True
    ' Catch ex As Exception
    '    Return False
    'End Try
    'End Function

End Class
