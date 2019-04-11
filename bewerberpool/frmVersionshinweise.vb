Public Class frmVersionshinweise

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmVersionshinweise_Load(sender As Object, e As EventArgs) Handles Me.Load
        If connectionString.Contains("127.0.0.1") Then
            RichTextBox1.LoadFile("E:\heyduck\bewerberpool-neu\0.0.2\Bewerberpool.rtf")
        Else
            RichTextBox1.LoadFile("x:\bewerberpool\Bewerberpool.rtf")
        End If
    End Sub
End Class