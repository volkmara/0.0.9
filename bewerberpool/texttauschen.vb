Public Class texttauschen
    Public Shared Sub Textboxtauschen()

        Dim cmbwert As String() = New String() {"0", "1", "2", "3", "4"}

        ' Tabpage 5 - Sprachen/EDV

        If frmMain.TabControl1.SelectedTab Is frmMain.TabPage5 Then
            For Each tb In frmMain.GroupBox27.Controls.OfType(Of TextBox)()
                If tb.Text.Contains("0:") Then
                    tb.Text = CStr("0")
                ElseIf tb.Text.Contains("1:") Then
                    tb.Text = CStr("1")
                ElseIf tb.Text.Contains("2:") Then
                    tb.Text = CStr("2")
                ElseIf tb.Text.Contains("3:") Then
                    tb.Text = CStr("3")
                ElseIf tb.Text.Contains("4:") Then
                    tb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox30.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0:") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1:") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2:") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3:") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox29.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0:") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1:") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2:") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3:") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4:") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Tabpage 6 - Büro/Assistenz/RA-Angestellte

        ElseIf frmMain.TabControl1.SelectedTab Is frmMain.TabPage6 Then

            'Büro

            For Each cmb In frmMain.GroupBox32.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox33.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox34.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Assistenz

            For Each cmb In frmMain.GroupBox35.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            'RAE

            For Each cmb In frmMain.GroupBox36.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox37.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Tabpage 7 - Vertrieb/Einkauf/Versand/Logistik/Marketing

        ElseIf frmMain.TabControl1.SelectedTab Is frmMain.TabPage7 Then

            ' Vertrieb

            For Each cmb In frmMain.GroupBox39.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox40.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Einkauf

            For Each cmb In frmMain.GroupBox41.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox42.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Versand/Logistik

            For Each cmb In frmMain.GroupBox44.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox45.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Marketing/Design

            For Each cmb In frmMain.GroupBox43.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox46.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox45.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox47.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Tabpage 8 - Finanzbuchhaltung

        ElseIf frmMain.TabControl1.SelectedTab Is frmMain.TabPage8 Then

            ' Finanzbuchhaltung

            For Each cmb In frmMain.GroupBox49.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox50.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox51.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Bilanzbuchhaltung

            For Each cmb In frmMain.GroupBox59.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox60.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox61.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Controlling

            For Each cmb In frmMain.GroupBox52.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox53.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            'Steuerfachangestellte

            For Each cmb In frmMain.GroupBox54.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Tabpage 9 - Personalverwaltung/Lohn und Gehalt

        ElseIf frmMain.TabControl1.SelectedTab Is frmMain.TabPage9 Then

            ' Personalverwaltung

            For Each cmb In frmMain.GroupBox56.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox57.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Lohn- und Gehaltsabrechnung

            For Each cmb In frmMain.GroupBox63.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Lohn- und Gehaltsbuchhaltung

            For Each cmb In frmMain.GroupBox64.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' Tabpage 10 - Technik/EDV/Gewerblich

        ElseIf frmMain.TabControl1.SelectedTab Is frmMain.TabPage10 Then

            ' Technik

            For Each cmb In frmMain.GroupBox66.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox67.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' IT

            For Each cmb In frmMain.GroupBox73.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox72.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox71.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox70.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox69.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox68.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            ' gewerblich

            For Each cmb In frmMain.GroupBox83.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox86.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox87.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next

            For Each cmb In frmMain.GroupBox88.Controls.OfType(Of ComboBox)()
                cmb.Items.Clear()
                'cmb.FlatStyle = FlatStyle.Popup
                cmb.Items.AddRange(cmbwert)
                If cmb.Text.Contains("0") Then
                    cmb.Text = CStr("0")
                ElseIf cmb.Text.Contains("1") Then
                    cmb.Text = CStr("1")
                ElseIf cmb.Text.Contains("2") Then
                    cmb.Text = CStr("2")
                ElseIf cmb.Text.Contains("3") Then
                    cmb.Text = CStr("3")
                ElseIf cmb.Text.Contains("4") Then
                    cmb.Text = CStr("4")
                End If
            Next
        End If
    End Sub
End Class
