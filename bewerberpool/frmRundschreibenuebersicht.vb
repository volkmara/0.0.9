Imports System.ComponentModel
Imports bewerberpool
Imports bewerberpool.BewerberDataSet
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class frmRundschreibenuebersicht
    Private frmMain As frmMain

    Public Sub New(frmMain As frmMain)
        Me.frmMain = frmMain
        InitializeComponent()
    End Sub


    Private Sub frmRundschreibenuebersicht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RundschreibenTableAdapter.Fill(Me.BewerberDataSet.rundschreiben)
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        Me.RundschreibenmonatTableAdapter.Fill(Me.BewerberDataSet.rundschreibenmonat)
        ' Me.BewBindingSource.Filter = "rundschreibenuebersichtjanein = 0"
        ' Me.RundschreibenBindingSource.Filter = "column9 <> 0"

    End Sub

    Private Sub RGVRundschreibenMonat_ViewCellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RGVRundschreibenMonat.ViewCellFormatting, RGVBewerber.ViewCellFormatting
        Dim newFont10 = New Font("Microsoft Sans Serif", 10.0, FontStyle.Bold)

        If TypeOf e.CellElement Is GridHeaderCellElement Then
            e.CellElement.Font = newFont10
        Else
            e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

        If e.CellElement.ColumnInfo.Name = "column1" Then
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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage2 Then
            'Me.BewBindingSource.Filter = "rundschreibenuebersichtjanein = 0"
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim rundschreibenmonat = DirectCast(DirectCast(Me.RundschreibenmonatBindingSource.Current, DataRowView).Row, rundschreibenmonatRow)
        rundschreibenmonat.kw = CInt(cmbKW.SelectedItem)
        Me.Validate()
        Me.RundschreibenmonatBindingSource.EndEdit()
        Me.RundschreibenmonatTableAdapter.Update(Me.BewerberDataSet.rundschreibenmonat)
    End Sub

    Private Sub frmRundschreibenuebersicht_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Call Bewerbersortieren()
        For i = 1 To 52
            cmbKW.Items.Add(i)
        Next
    End Sub
    Private Sub Bewerbersortieren()
        ' Me.RGVBewerber.MasterTemplate.EnableSorting = True
        Dim descriptor As New SortDescriptor()
        descriptor.PropertyName = "column1"
        descriptor.Direction = ListSortDirection.Ascending
        Me.RGVBewerber.MasterTemplate.SortDescriptors.Add(descriptor)
    End Sub


End Class