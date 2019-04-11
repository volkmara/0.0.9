Public Class einloggen
    Public Shared Sub logincheck()
        Select Case loginflag
            Case 2
                '    frmMain.Interviewerbogen.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Case 4 ' Akquise
                ' frmMain.Panel23.Enabled = False
                ' frmMain.GroupBox1.Enabled = False
                'frmMain.NameTextBox.ReadOnly = True
            Case 6 ' Fürst, Mersch
                '   frmMain.Interviewerbogen.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Case 8 ' Adler
                'frmMain.AdminfunktionenRadMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
                '  frmMain.Interviewerbogen.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Case 9 'Heyduck
                'frmMain.AdminfunktionenRadMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
                ' frmMain.Interviewerbogen.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Case -1
                MsgBox("Login fehlgeschlagen")
        End Select
    End Sub

    Public Shared Sub tbcheck()

        For Each cmb As ComboBox In frmMain.GroupBox17.Controls.OfType(Of ComboBox)()
            If cmb.SelectedIndex = CInt(0) AndAlso loginflag = CInt(2) Then
                cmb.BackColor = Color.Yellow
            ElseIf cmb.SelectedIndex > CInt(0) AndAlso loginflag = CInt(2) Then
                cmb.BackColor = Color.White
            End If
        Next

        For Each tb As TextBox In frmMain.GroupBox17.Controls.OfType(Of TextBox)()
            If tb.Text = String.Empty AndAlso loginflag = CInt(2) Then
                tb.BackColor = Color.Yellow
            ElseIf tb.Text <> String.Empty AndAlso loginflag = CInt(2) Then
                tb.BackColor = Color.White
            End If
        Next

        For Each tb As TextBox In frmMain.GroupBox18.Controls.OfType(Of TextBox)()
            If tb.Text = String.Empty AndAlso loginflag = CInt(2) Then
                tb.BackColor = Color.Yellow
            ElseIf tb.Text <> String.Empty AndAlso loginflag = CInt(2) Then
                tb.BackColor = Color.White
            End If
        Next

        For Each cmb As ComboBox In frmMain.GroupBox18.Controls.OfType(Of ComboBox)()
            If cmb.SelectedIndex = CInt(0) AndAlso loginflag = CInt(2) Then
                cmb.BackColor = Color.Yellow
            ElseIf cmb.SelectedIndex > CInt(0) AndAlso loginflag = CInt(2) Then
                cmb.BackColor = Color.White
            End If
        Next

        For Each cmb As ComboBox In frmMain.GroupBox27.Controls.OfType(Of ComboBox)()
            If cmb.SelectedIndex = CInt(0) AndAlso loginflag = CInt(2) Then
                cmb.BackColor = Color.Yellow
            ElseIf cmb.SelectedIndex > CInt(0) AndAlso loginflag = CInt(2) Then
                cmb.BackColor = Color.White
            End If
        Next

        For Each tb As TextBox In frmMain.GroupBox27.Controls.OfType(Of TextBox)()
            If tb.Text = String.Empty AndAlso loginflag = CInt(2) Then
                tb.BackColor = Color.Yellow
            ElseIf tb.Text <> String.Empty AndAlso loginflag = CInt(2) Then
                tb.BackColor = Color.White
            End If
        Next

    End Sub
End Class
