Imports Telerik.WinControls.UI.Localization
Imports Telerik.WinForms.RichTextEditor

Public Class MyRichTextBoxLocalizationProvider
    Inherits RichTextBoxLocalizationProvider
    Public Overrides Function GetLocalizedString(ByVal id As String) As String
        Select Case id
            Case "Documents_ContextMenu_Clipboard_Copy"
                Return "Kopieren"
        End Select
        Return MyBase.GetLocalizedString(id)
    End Function
End Class





