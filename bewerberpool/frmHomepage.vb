Imports bewerberpool.heyduckDataSet
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class frmHomepage

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Internetverbindung()
        If Inet Then
            Me.Tt_newsTableAdapter.Fill(Me.HeyduckDataSet.tt_news)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmHomepage_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.HomepageGridView1.MasterTemplate.ShowFilterCellOperatorText = False
    End Sub

    Private Sub HomepageGridView1_ViewCellFormatting(ByVal sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles HomepageGridView1.ViewCellFormatting
        Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

        If TypeOf e.CellElement Is GridHeaderCellElement Then
            e.CellElement.Font = newFont10
        Else
            e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnnichtgelöscht.CheckedChanged, rbtngeloescht.CheckedChanged, rbtnalle.CheckedChanged
        Select Case True
            Case sender Is rbtnnichtgelöscht
                Tt_newsBindingSource.Filter = "deleted = 0"
            Case sender Is rbtngeloescht
                Tt_newsBindingSource.Filter = "deleted = 1"
            Case sender Is rbtnalle
                Tt_newsBindingSource.RemoveFilter()
        End Select
    End Sub

    Private Sub btnDeaktivieren_Click(sender As Object, e As EventArgs) Handles btnDeaktivieren.Click, btnAktivieren.Click, btnNeuladen.Click, btnClose.Click
        Select Case True
            Case sender Is btnDeaktivieren
                Dim homepage = DirectCast(DirectCast(Tt_newsBindingSource.Current, DataRowView).Row, tt_newsRow)
                homepage.deleted = CInt(1)
                Me.Validate()
                Me.Tt_newsBindingSource.EndEdit()
                Me.Tt_newsTableAdapter.Update(Me.HeyduckDataSet.tt_news)
                Me.Tt_newsTableAdapter.Fill(Me.HeyduckDataSet.tt_news)
            Case sender Is btnAktivieren
                Dim homepage = DirectCast(DirectCast(Tt_newsBindingSource.Current, DataRowView).Row, tt_newsRow)
                homepage.deleted = CInt(0)
                Me.Validate()
                Me.Tt_newsBindingSource.EndEdit()
                Me.Tt_newsTableAdapter.Update(Me.HeyduckDataSet.tt_news)
                Me.Tt_newsTableAdapter.Fill(Me.HeyduckDataSet.tt_news)
            Case sender Is btnNeuladen
                Me.Tt_newsTableAdapter.Fill(Me.HeyduckDataSet.tt_news)
            Case sender Is btnClose
                Me.Close()
        End Select
    End Sub
End Class