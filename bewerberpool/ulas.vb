Imports MySql.Data.MySqlClient

Public Class ulas

    ' Pfade für Ulas
    Public Shared Property zieldatei As String
    Public Shared Property ausgangsdatei As String
    Public Shared Property zielverzeichnis As String
    Public Shared Property ausgangsverzeichnis As String
    Public Shared Property verzeichnis As String
    Public Shared Property ausgangsdateiohnepfad As String

    ' Boolean Original oder Bearbeitet
    Public Shared Property lebenslauf As Boolean
    Public Shared Property zeugnisse As Boolean
    Public Shared Property foto As Boolean
    Public Shared Property ulasbewid As Boolean
    Public Shared Property ulas As Boolean

    Public Shared Sub connect()
        If connectionString.Contains("127.0.0.1") Then
            verzeichnis = CStr("e:\heyduck\ulas\")
        Else
            verzeichnis = CStr("x:\ulas\")
        End If
    End Sub

    ' Ulas original

    Public Shared Sub ulasspeichern()
        zielverzeichnis = String.Concat(verzeichnis, bewid, "\")

        Using OpenFd As New OpenFileDialog
            OpenFd.Filter = "Pdf Dateien(*.pdf)|*.pdf|Word 2007 etc.-Dateien(*.docx)|*.docx|Word 2003-Dateien(*.doc)|*.doc|Text-Dateien(*.txt)|*.txt|Alle Dateien(*.*)|*.*"
            OpenFd.RestoreDirectory = True
            OpenFd.ShowDialog()

            ' Es wurde versucht, das Fenster zu schließen, ohne dass eine Datei ausgewählt wurde. 
            If OpenFd.FileName = String.Empty Then
                Dim Message1 As String = "Haben Sie vergessen, eine Datei auszuwählen?" & vbNewLine & """Ja"" zum Auswählen einer Datei, ""Nein"", um abzubrechen"
                Dim Caption1 As String = "Lebenslauf speichern"
                Dim Buttons1 As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result1 As DialogResult = MessageBox.Show(Message1, Caption1, Buttons1)

                If Result1 = Windows.Forms.DialogResult.Yes Then
                    OpenFd.ShowDialog()
                    ausgangsdatei = CStr(IO.Path.GetFullPath(OpenFd.FileName))
                    ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(OpenFd.FileName))
                    zieldatei = CStr(zielverzeichnis + ausgangsdateiohnepfad)
                    If lebenslauf = True Then
                        frmMain.LebenslaufTextBox.Text = CStr(zieldatei)
                    ElseIf lebenslauf = False Then
                        frmMain.Lebenslauf_bearbeitetTextBox.Text = CStr(zieldatei)
                    End If
                    MsgBox("Lebenslauf erfolgreich gespeichert")
                ElseIf Result1 = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
        End Using
    End Sub


    ' Lebenslauf original und bearbeitet
    Public Shared Sub Lebenslaufspeichern()
        Call connect()
        If lebenslauf = True Then
            'zielverzeichnis = CStr(verzeichnis & CStr(frmMain.NameTextBox.Text) & ", " & CStr(frmMain.VornameTextBox.Text) & "\Original\Lebenslauf\")
            zielverzeichnis = String.Concat(verzeichnis, bewid, "\Original\Lebenslauf\")
        ElseIf lebenslauf = False Then
            ' zielverzeichnis = CStr(verzeichnis & CStr(frmMain.NameTextBox.Text) & ", " & CStr(frmMain.VornameTextBox.Text) & "\Bearbeitet\Lebenslauf\")
            zielverzeichnis = String.Concat(verzeichnis, bewid, "\Bearbeitet\Lebenslauf\")
        End If

        Using OpenFd As New OpenFileDialog
            OpenFd.Filter = "Pdf Dateien(*.pdf)|*.pdf|Word 2007 etc.-Dateien(*.docx)|*.docx|Word 2003-Dateien(*.doc)|*.doc|Text-Dateien(*.txt)|*.txt|Alle Dateien(*.*)|*.*"
            OpenFd.RestoreDirectory = True
            OpenFd.ShowDialog()

            ' Es wurde versucht, das Fenster zu schließen, ohne dass eine Datei ausgewählt wurde. 
            If OpenFd.FileName = String.Empty Then
                Dim Message1 As String = "Haben Sie vergessen, eine Datei auszuwählen?" & vbNewLine & """Ja"" zum Auswählen einer Datei, ""Nein"", um abzubrechen"
                Dim Caption1 As String = "Lebenslauf speichern"
                Dim Buttons1 As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result1 As DialogResult = MessageBox.Show(Message1, Caption1, Buttons1)

                If Result1 = Windows.Forms.DialogResult.Yes Then
                    OpenFd.ShowDialog()
                    ausgangsdatei = CStr(IO.Path.GetFullPath(OpenFd.FileName))
                    ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(OpenFd.FileName))
                    zieldatei = CStr(zielverzeichnis + ausgangsdateiohnepfad)
                    If lebenslauf = True Then
                        frmMain.LebenslaufTextBox.Text = CStr(zieldatei)
                    ElseIf lebenslauf = False Then
                        frmMain.Lebenslauf_bearbeitetTextBox.Text = CStr(zieldatei)
                    End If
                    MsgBox("Lebenslauf erfolgreich gespeichert")
                ElseIf Result1 = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            ' Normaler Ablauf, wenn eine Datei ausgewählt wurde, das Zielverzeichnis noch nicht angelegt wurde und der neue Dateiname nicht leer ist

            If OpenFd.FileName <> "" Then
                ausgangsdatei = CStr(IO.Path.GetFullPath(OpenFd.FileName))
                ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(OpenFd.FileName))
                zieldatei = CStr(zielverzeichnis + ausgangsdateiohnepfad)
            End If
            If IO.Directory.Exists(zielverzeichnis) = False AndAlso CStr(ausgangsdatei) <> String.Empty Then
                System.IO.Directory.CreateDirectory(zielverzeichnis)
                System.IO.File.Copy(ausgangsdatei, zieldatei)
                If lebenslauf = True Then
                    frmMain.LebenslaufTextBox.Text = CStr(zieldatei)
                ElseIf lebenslauf = False Then
                    frmMain.Lebenslauf_bearbeitetTextBox.Text = CStr(zieldatei)
                End If
                MsgBox("Lebenslauf erfolgreich gespeichert")
                zieldatei = String.Empty

                ' Bestehenden Lebenslauf überschreiben
            ElseIf IO.Directory.Exists(zielverzeichnis) AndAlso IO.File.Exists(ausgangsdateiohnepfad) = False Then
                Dim Message2 As String = "Es wurde bereits ein Lebenslauf abgespeichert. Soll diese Datei geändert werden?" & vbNewLine & """Ja"" zum Überschreiben, "" Nein"", um die alte Datei zu behalten."
                Dim Caption2 As String = "Lebenslauf ändern?"
                Dim Buttons2 As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result2 As DialogResult = MessageBox.Show(Message2, Caption2, Buttons2)
                If Result2 = Windows.Forms.DialogResult.Yes Then
                    System.IO.Directory.Delete(zielverzeichnis, True) ' Vorhandenes Verzeichnis rekursiv löschen, dann Verzeichnis (REfnR) neu anlegen
                    System.IO.Directory.CreateDirectory(zielverzeichnis)
                    System.IO.File.Copy(ausgangsdatei, zieldatei)
                    If lebenslauf = True Then
                        frmMain.LebenslaufTextBox.Text = CStr(zieldatei)
                    ElseIf lebenslauf = False Then
                        frmMain.Lebenslauf_bearbeitetTextBox.Text = CStr(zieldatei)
                    End If
                    MsgBox("Neuer Lebenslauf gespeichert")
                End If
            End If
        End Using
    End Sub

    ' Zeugnisse original und bearbeitet speichern
    Public Shared Sub Zeugnissespeichern()
        Call connect()
        If zeugnisse = True Then
            'zielverzeichnis = CStr(verzeichnis & CStr(frmMain.NameTextBox.Text) & ", " & CStr(frmMain.VornameTextBox.Text) & "\Original\Zeugnisse\")
            zielverzeichnis = String.Concat(verzeichnis, bewid, "\Original\Zeugnisse\")
        ElseIf zeugnisse = False Then
            ' zielverzeichnis = CStr(verzeichnis & CStr(frmMain.NameTextBox.Text) & ", " & CStr(frmMain.VornameTextBox.Text) & "\Bearbeitet\Zeugnisse\")
            zielverzeichnis = String.Concat(verzeichnis, bewid, "\Bearbeitet\Zeugnisse\")
        End If

        Using OpenFd As New OpenFileDialog
            OpenFd.Filter = "Pdf Dateien(*.pdf)|*.pdf|Word 2007 etc.-Dateien(*.docx)|*.docx|Word 2003-Dateien(*.doc)|*.doc|Text-Dateien(*.txt)|*.txt|Alle Dateien(*.*)|*.*"
            OpenFd.RestoreDirectory = True
            OpenFd.ShowDialog()

            ' Es wurde versucht, das Fenster zu schließen, ohne dass eine Datei ausgewählt wurde. 
            If OpenFd.FileName = String.Empty Then
                Dim Message1 As String = "Haben Sie vergessen, eine Datei auszuwählen?" & vbNewLine & """Ja"" zum Auswählen einer Datei, ""Nein"", um abzubrechen"
                Dim Caption1 As String = "Zeugnisse speichern"
                Dim Buttons1 As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result1 As DialogResult = MessageBox.Show(Message1, Caption1, Buttons1)

                If Result1 = Windows.Forms.DialogResult.Yes Then
                    OpenFd.ShowDialog()
                    ausgangsdatei = CStr(IO.Path.GetFullPath(OpenFd.FileName))
                    ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(OpenFd.FileName))
                    zieldatei = CStr(zielverzeichnis + ausgangsdateiohnepfad)
                    If zeugnisse = True Then
                        frmMain.ZeugnisseTextBox.Text = CStr(zieldatei)
                    ElseIf zeugnisse = False Then
                        frmMain.Zeugnisse_bearbeitetTextBox.Text = CStr(zieldatei)
                    End If
                    MsgBox("Zeugnisse erfolgreich gespeichert")
                ElseIf Result1 = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            ' Normaler Ablauf, wenn eine Datei ausgewählt wurde, das Zielverzeichnis noch nicht angelegt wurde und der neue Dateiname nicht leer ist

            If OpenFd.FileName <> "" Then
                ausgangsdatei = CStr(IO.Path.GetFullPath(OpenFd.FileName))
                ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(OpenFd.FileName))
                zieldatei = CStr(zielverzeichnis + ausgangsdateiohnepfad)
            End If
            If IO.Directory.Exists(zielverzeichnis) = False AndAlso CStr(ausgangsdatei) <> String.Empty Then
                System.IO.Directory.CreateDirectory(zielverzeichnis)
                System.IO.File.Copy(ausgangsdatei, zieldatei)
                If zeugnisse = True Then
                    frmMain.ZeugnisseTextBox.Text = CStr(zieldatei)
                ElseIf zeugnisse = False Then
                    frmMain.Zeugnisse_bearbeitetTextBox.Text = CStr(zieldatei)
                End If
                MsgBox("Zeugnisse erfolgreich gespeichert")
                zieldatei = String.Empty

                ' Bestehende Zeugnisse überschreiben
            ElseIf IO.Directory.Exists(zielverzeichnis) AndAlso IO.File.Exists(ausgangsdateiohnepfad) = False Then
                Dim Message2 As String = "Es wurden bereits Zeugnisse abgespeichert. Soll diese Datei geändert werden?" & vbNewLine & """Ja"" zum Überschreiben, "" Nein"", um die alte Datei zu behalten."
                Dim Caption2 As String = "Zeugnisse ändern?"
                Dim Buttons2 As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result2 As DialogResult = MessageBox.Show(Message2, Caption2, Buttons2)
                If Result2 = Windows.Forms.DialogResult.Yes Then
                    System.IO.Directory.Delete(zielverzeichnis, True) ' Vorhandenes Verzeichnis rekursiv löschen, dann Verzeichnis (REfnR) neu anlegen
                    System.IO.Directory.CreateDirectory(zielverzeichnis)
                    System.IO.File.Copy(ausgangsdatei, zieldatei)
                    If zeugnisse = True Then
                        frmMain.ZeugnisseTextBox.Text = CStr(zieldatei)
                    ElseIf zeugnisse = False Then
                        frmMain.Zeugnisse_bearbeitetTextBox.Text = CStr(zieldatei)
                    End If
                    MsgBox("Neue Zeugnisse erfolgreich gespeichert")
                End If
            End If
        End Using
    End Sub

    ' Fotos original und bearbeitet abspeichern
    Public Shared Sub Fotosspeichern()
        Call connect()
        If foto = True Then
            'zielverzeichnis = CStr(verzeichnis & CStr(frmMain.NameTextBox.Text) & ", " & CStr(frmMain.VornameTextBox.Text) & "\Original\Fotos\")
            zielverzeichnis = String.Concat(verzeichnis, bewid, "\Original\Fotos\")
        ElseIf foto = False Then
            'zielverzeichnis = CStr(verzeichnis & CStr(frmMain.NameTextBox.Text) & ", " & CStr(frmMain.VornameTextBox.Text) & "\Bearbeitet\Fotos\")
            zielverzeichnis = String.Concat(verzeichnis, bewid, "\Bearbeitet\Fotos\")
        End If

        Using OpenFd As New OpenFileDialog
            OpenFd.Filter = "Jpg-Dateien(*.jpg)|*.jpg|Png-Dateien(*.png)|*.png|Gif-Dateien(*.gif)|*.gif|bmp-Dateien(*.bmp)|*.bmp|Pdf Dateien(*.pdf)|*.pdf|Alle Dateien(*.*)|*.*"
            OpenFd.RestoreDirectory = True
            OpenFd.ShowDialog()

            ' Es wurde versucht, das Fenster zu schließen, ohne dass eine Datei ausgewählt wurde. 
            If OpenFd.FileName = String.Empty Then
                Dim Message1 As String = "Haben Sie vergessen, eine Datei auszuwählen?" & vbNewLine & """Ja"" zum Auswählen einer Datei, ""Nein"", um abzubrechen"
                Dim Caption1 As String = "Fotos speichern"
                Dim Buttons1 As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result1 As DialogResult = MessageBox.Show(Message1, Caption1, Buttons1)

                If Result1 = Windows.Forms.DialogResult.Yes Then
                    OpenFd.ShowDialog()
                    ausgangsdatei = CStr(IO.Path.GetFullPath(OpenFd.FileName))
                    ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(OpenFd.FileName))
                    zieldatei = CStr(zielverzeichnis + ausgangsdateiohnepfad)
                    If foto = True Then
                        frmMain.Foto_woTextBox.Text = CStr(zieldatei)
                    ElseIf foto = False Then
                        frmMain.Foto_bearbeitetTextBox.Text = CStr(zieldatei)
                    End If
                    MsgBox("Foto erfolgreich gespeichert")
                ElseIf Result1 = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            ' Normaler Ablauf, wenn eine Datei ausgewählt wurde, das Zielverzeichnis noch nicht angelegt wurde und der neue Dateiname nicht leer ist

            If OpenFd.FileName <> "" Then
                ausgangsdatei = CStr(IO.Path.GetFullPath(OpenFd.FileName))
                ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(OpenFd.FileName))
                zieldatei = CStr(zielverzeichnis + ausgangsdateiohnepfad)
            End If
            If IO.Directory.Exists(zielverzeichnis) = False AndAlso CStr(ausgangsdatei) <> String.Empty Then
                System.IO.Directory.CreateDirectory(zielverzeichnis)
                System.IO.File.Copy(ausgangsdatei, zieldatei)
                MsgBox("Foto erfolgreich gespeichert")
                If foto = True Then
                    frmMain.Foto_woTextBox.Text = CStr(zieldatei)
                ElseIf foto = False Then
                    frmMain.Foto_bearbeitetTextBox.Text = CStr(zieldatei)
                End If
                zieldatei = String.Empty

                ' Bestehendes Foto überschreiben
            ElseIf IO.Directory.Exists(zielverzeichnis) AndAlso IO.File.Exists(ausgangsdateiohnepfad) = False Then
                Dim Message2 As String = "Es wurden bereits Fotos abgespeichert. Soll diese Datei geändert werden?" & vbNewLine & """Ja"" zum Überschreiben, "" Nein"", um die alte Datei zu behalten."
                Dim Caption2 As String = "Fotos ändern?"
                Dim Buttons2 As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result2 As DialogResult = MessageBox.Show(Message2, Caption2, Buttons2)
                If Result2 = Windows.Forms.DialogResult.Yes Then
                    System.IO.Directory.Delete(zielverzeichnis, True) ' Vorhandenes Verzeichnis rekursiv löschen, dann Verzeichnis (REfnR) neu anlegen
                    System.IO.Directory.CreateDirectory(zielverzeichnis)
                    System.IO.File.Copy(ausgangsdatei, zieldatei)
                    If foto = True Then
                        frmMain.Foto_woTextBox.Text = CStr(zieldatei)
                    ElseIf foto = False Then
                        frmMain.Foto_bearbeitetTextBox.Text = CStr(zieldatei)
                    End If
                    MsgBox("Neues Foto erfolgreich gespeichert")
                End If
            End If
        End Using
    End Sub

    Public Shared Sub LLinDB()
        ulasbewid = Allgmein.ulasExists(bewid)

        Dim sql_neu As String = "INSERT INTO bewerberneu.ulas (id_bew, lebenslauf) VALUES (@idbew, @lebenslauf);"
        Dim llsql As String = "UPDATE bewerberneu.ulas SET lebenslauf = @lebenslauf WHERE id_bew = @idbew;"

        If ulasbewid = False Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(sql_neu, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@lebenslauf", CStr(frmMain.LebenslaufTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        ElseIf ulasbewid = True Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(llsql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@lebenslauf", CStr(frmMain.LebenslaufTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End If
    End Sub

    Public Shared Sub ZeugnisseinDB()
        ulasbewid = Allgmein.ulasExists(bewid)
        Dim zeugnisse_neusql As String = "INSERT INTO bewerberneu.ulas (id_bew, zeugnisse) VALUES (@idbew, @zeugnisse);"
        Dim zeugnissesql As String = "UPDATE bewerberneu.ulas SET zeugnisse = @zeugnisse WHERE id_bew = @idbew;"

        If ulasbewid = False Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(zeugnisse_neusql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@zeugnisse", CStr(frmMain.ZeugnisseTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        ElseIf ulasbewid = True Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(zeugnissesql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@zeugnisse", CStr(frmMain.ZeugnisseTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End If
    End Sub

    Public Shared Sub FotoinDB()
        ulasbewid = Allgmein.ulasExists(bewid)
        Dim fotoneu_sql As String = "INSERT INTO bewerberneu.ulas (id_bew, foto_wo) VALUES (@idbew, @foto);"
        Dim fotosql As String = "UPDATE bewerberneu.ulas SET foto_wo = @foto_wo WHERE id_bew = @idbew;"

        If ulasbewid = False Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(fotoneu_sql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@foto_wo", CStr(frmMain.Foto_woTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        ElseIf ulasbewid = True Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(fotosql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@foto_wo", CStr(frmMain.Foto_woTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End If
    End Sub

    Public Shared Sub LLbearbeitetinDB()
        ulasbewid = Allgmein.ulasExists(bewid)
        Dim ll_bearbeitetsql As String = "INSERT INTO bewerberneu.ulas (id_bew, lebenslauf_bearbeitet) VALUES (@idbew, @lebenslaufbearbeitet);"
        Dim llsql As String = "UPDATE bewerberneu.ulas SET lebenslauf_bearbeitet = @lebenslaufbearbeitet WHERE id_bew = @idbew;"

        If ulasbewid = False Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(ll_bearbeitetsql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@lebenslaufbearbeitet", CStr(frmMain.Lebenslauf_bearbeitetTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        ElseIf ulasbewid = True Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(llsql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@lebenslaufbearbeitet", CStr(frmMain.Lebenslauf_bearbeitetTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End If
    End Sub

    Public Shared Sub ZeugnissebearbeitetinDB()
        ulasbewid = Allgmein.ulasExists(bewid)
        Dim zeugnisse_bearbeitetsql As String = "INSERT INTO bewerberneu.ulas (id_bew, zeugnisse_bearbeitet) VALUES (@idbew, @zeugnissebearbeitet);"
        Dim zeugnissesql As String = "UPDATE bewerberneu.ulas SET zeugnisse_bearbeitet = @zeugnissebearbeitet WHERE id_bew = @idbew;"

        If ulasbewid = False Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(zeugnisse_bearbeitetsql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@zeugnissebearbeitet", CStr(frmMain.Zeugnisse_bearbeitetTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        ElseIf ulasbewid = True Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(zeugnissesql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@zeugnissebearbeitet", CStr(frmMain.Zeugnisse_bearbeitetTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End If
    End Sub

    Public Shared Sub FotobearbeitetinDB()
        ulasbewid = Allgmein.ulasExists(bewid)
        Dim foto_bearbeitetsql As String = "INSERT INTO bewerberneu.ulas (id_bew, foto_bearbeitet) VALUES (@idbew, @fotobearbeitet);"
        Dim fotosql As String = "UPDATE bewerberneu.ulas SET foto_bearbeitet = @fotobearbeitet WHERE id_bew = @idbew;"


        If ulasbewid = False Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(foto_bearbeitetsql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@fotobearbeitet", CStr(frmMain.Foto_bearbeitetTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        ElseIf ulasbewid = True Then
            Using conn As New MySqlConnection(connectionString)
                Dim comm As New MySqlCommand(fotosql, conn)
                comm.Parameters.AddWithValue("@idbew", bewid)
                comm.Parameters.AddWithValue("@fotobearbeitet", CStr(frmMain.Foto_bearbeitetTextBox.Text))
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End If
    End Sub
End Class
