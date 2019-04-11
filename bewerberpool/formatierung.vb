Imports Telerik.WinControls.UI
Public Class formatierung
    ' Formatiert Labels in einer Groupbox in schwarz, wenn der Überschrift der Groupbox eine andere Farbe zugewiesen wurde
    Public Shared Sub Labelfarbe()
        For Each lbl In frmMain.GroupBox1.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox2.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox3.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox4.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox5.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox6.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox76.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        frmMain.lblgooglemaps.ForeColor = Color.Crimson
        'frmMain.GroupBox13.BackColor = Color.FromArgb(255, 225, 247)
        ' frmMain.GroupBox13.BackColor = Color.DarkOrange

        ' Reiter Daten

        For Each lbl In frmMain.GroupBox7.Controls.OfType(Of Label)() ' Labels in der obersten Groupbox Reiter Daten
            lbl.ForeColor = Color.Crimson
        Next

        For Each lbl In frmMain.GroupBox8.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox9.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox11.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox12.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox13.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox15.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox14.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        ' Ulas

        For Each lbl In frmMain.GroupBox17.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox21.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox16.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        ' Ende Ulas

        ' Ende Reiter Daten

        ' Reiter Berufliches/Fremdsprachen/EDV
        For Each lbl In frmMain.GroupBox22.Controls.OfType(Of Label)() ' Labels in der obersten Groupbox Reiter Berufliches/Fremdsprachen/EDV
            lbl.ForeColor = Color.Crimson
        Next

        For Each lbl In frmMain.GroupBox23.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox24.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox25.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox26.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox27.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox28.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox29.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        For Each lbl In frmMain.GroupBox30.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next

        ' Ende Reiter Berufliches/Fremdsprachen/EDV

        For Each lbl In frmMain.GroupBox18.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.Black
        Next
    End Sub
End Class
