Public Class frmUlaseintragen

    Private _frmMain As frmMain
    Private _frmKurzfragebogen As frmKurzfragebogen
    Private _frmInterviewer As frmInterviewer

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Sub New(frmKurzfragebogen As frmKurzfragebogen)
        ' TODO: Complete member initialization 
        _frmKurzfragebogen = frmKurzfragebogen
        InitializeComponent()
    End Sub

    Sub New(frmInterviewer As frmInterviewer)
        ' TODO: Complete member initialization 
        _frmInterviewer = frmInterviewer
        InitializeComponent()
    End Sub

    Public Shared Property ulas_bool As Boolean = False
    Public Shared Property ulas_wert As String = String.Empty

    Private Sub listboxendeaktivieren()
        ulas_bool = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ulas_wert = String.Empty
        For k As Integer = 0 To Me.ListBox1.SelectedItems.Count - 1
            ulas_wert &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
        Next
    End Sub

    Private Sub btnAuswahluebernehmen_Click(sender As Object, e As EventArgs) Handles btnAuswahluebernehmen.Click
        Call listboxendeaktivieren()
        Me.Close()
    End Sub
End Class