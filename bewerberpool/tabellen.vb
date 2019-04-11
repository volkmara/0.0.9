Imports Telerik.WinControls.UI

Public Class tabellen

    Public Shared Sub tabellenheader()

        frmMain.BewGridView1.MasterTemplate.ShowFilterCellOperatorText = False
        frmMain.NotizenRadGridView.MasterTemplate.ShowFilterCellOperatorText = False

        ' Tabpage 1
        For Each column As GridViewColumn In frmMain.BewGridView1.Columns
            If TypeOf column Is GridViewTextBoxColumn Then
                Dim col As GridViewTextBoxColumn = TryCast(column, GridViewTextBoxColumn)
                col.HeaderTextAlignment = ContentAlignment.MiddleLeft
            End If
        Next
    End Sub

    '        TabPage 9

    '  For Each column As GridViewColumn In frmMain.NotizenRadGridView.Columns
    'If TypeOf column Is GridViewTextBoxColumn Then
    ' Dim col As GridViewTextBoxColumn = TryCast(column, GridViewTextBoxColumn)
    ' col.HeaderTextAlignment = ContentAlignment.MiddleLeft
    ' End If
    ' Next
End Class
