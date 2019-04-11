'Imports MySql.Data.MySqlClient
Imports bewerberpool.BewerberDataSet
Public Class ulasspeichern
    ' Pfade für Ulas
    Public Shared Property zieldatei As String ' die Datei mit dem Pfad, in den die Datei kopiert wird
    Public Shared Property ausgangsdatei As String ' die Originaldatei - die, die kopiert werden soll mit Pfad und allem Drum und Dran
    Public Shared Property zielverzeichnis As String ' das Verzeichnis für Originalunterlagen, in das die zieldatei kopiert werden soll
    Public Shared Property zielverzeichnisbearbeitet As String ' das Verzeichnis für anonmyisierte Dateien, in die anonymisierte Dateien kopiert werden sollen
    Public Shared Property ausgangsverzeichnis As String ' das Verzeichnis der Originaldateien
    Public Shared Property ausgangsdateiohnepfad As String ' der Dateiname der Originaldatei ohne Pfad
    Public Shared Property origdropdatei As String ' die Datei mit dem Pfad, in den eine Originaldatei per Drag and Drop kopiert wird
    Public Shared Property anonymisiertdropdatei As String ' die Datei mit dem Pfad, in den eine anonymisierte Datei per Drag and Drop kopiert wird

    ' Originalulas speichern

    Public Shared Sub originalulasspeichern()

        If connectionString.Contains("127.0.0.1") Then
            verzeichnis = CStr("e:\heyduck\ulas\")
        Else
            verzeichnis = CStr("x:\ulas\")
        End If

        zielverzeichnis = String.Concat(verzeichnis, letzteid, "\", "Originale", "\")

        Using OpenFd As New OpenFileDialog
            With OpenFd
                .Filter = "Pdf Dateien(*.pdf)|*.pdf|Word 2007 etc.-Dateien(*.docx)|*.docx|Word 2003-Dateien(*.doc)|*.doc|Text-Dateien(*.txt)|*.txt|Alle Dateien(*.*)|*.*"
                .RestoreDirectory = True
                .Multiselect = True
            End With
            OpenFd.ShowDialog()

            '  Es wurde versucht, das Fenster zu schließen, ohne dass eine Datei ausgewählt wurde. 
            If OpenFd.FileName = String.Empty Then
                Dim Message1 As String = "Haben Sie vergessen, eine Datei auszuwählen?" & vbNewLine & """Ja"" zum Auswählen einer Datei, ""Nein"", um abzubrechen"
                Dim Result1 As DialogResult = MessageBox.Show(Message1, "Ulas speichern", MessageBoxButtons.YesNo)

                If Result1 = Windows.Forms.DialogResult.No Then
                    Exit Sub
                ElseIf Result1 = Windows.Forms.DialogResult.Yes Then
                    OpenFd.ShowDialog()
                End If
            End If

            ' Normaler Ablauf, wenn eine Datei ausgewählt wurde, das Zielverzeichnis noch nicht angelegt wurde und der neue Dateiname nicht leer ist

            If OpenFd.FileName <> "" Then
                For Each origdatei As String In OpenFd.FileNames

                    ausgangsdatei = CStr(IO.Path.GetFullPath(origdatei))
                    ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(origdatei))
                    zieldatei = CStr(zielverzeichnis + ausgangsdateiohnepfad)
                    If Not IO.Directory.Exists(zielverzeichnis) AndAlso CStr(ausgangsdatei) <> String.Empty Then
                        System.IO.Directory.CreateDirectory(zielverzeichnis)
                        System.IO.File.Copy(ausgangsdatei, zieldatei)
                        System.IO.File.Delete(ausgangsdatei)

                    ElseIf IO.Directory.Exists(zielverzeichnis) AndAlso CStr(ausgangsdatei) <> String.Empty Then
                        System.IO.File.Copy(ausgangsdatei, zieldatei, overwrite:=True)
                        System.IO.File.Delete(ausgangsdatei)
                        MsgBox("Ulas erfolgreich gespeichert")
                        zieldatei = String.Empty
                    End If
                Next
            End If
        End Using

    End Sub

    ' Bearbeitete Ulas speichern
    Public Shared Sub bearbeiteteulasspeichern()
        If connectionString.Contains("127.0.0.1") Then
            verzeichnis = CStr("e:\heyduck\ulas\")
        Else
            verzeichnis = CStr("x:\ulas\")
        End If

        zielverzeichnisbearbeitet = String.Concat(verzeichnis, letzteid, "\", "bearbeitet", "\")

        Using OpenFd As New OpenFileDialog
            With OpenFd
                .Filter = "Pdf Dateien(*.pdf)|*.pdf|Word 2007 etc.-Dateien(*.docx)|*.docx|Word 2003-Dateien(*.doc)|*.doc|Text-Dateien(*.txt)|*.txt|Alle Dateien(*.*)|*.*"
                .RestoreDirectory = True
                .Multiselect = True
            End With
            OpenFd.ShowDialog()

            ' Es wurde versucht, das Fenster zu schließen, ohne dass eine Datei ausgewählt wurde. 
           If OpenFd.FileName = String.Empty Then
                Dim Message1 As String = "Haben Sie vergessen, eine Datei auszuwählen?" & vbNewLine & """Ja"" zum Auswählen einer Datei, ""Nein"", um abzubrechen"
                Dim Caption1 As String = "Ulas speichern"
                Dim Buttons1 As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result1 As DialogResult = MessageBox.Show(Message1, Caption1, Buttons1)

                If Result1 = Windows.Forms.DialogResult.No Then
                    Exit Sub
                ElseIf Result1 = Windows.Forms.DialogResult.Yes Then
                    OpenFd.ShowDialog()
                End If
            End If

            ' Normaler Ablauf, wenn eine Datei ausgewählt wurde, das Zielverzeichnis noch nicht angelegt wurde und der neue Dateiname nicht leer ist

            If OpenFd.FileName <> "" Then
                For Each bearbeitetdatei As String In OpenFd.FileNames
                    ausgangsdatei = CStr(IO.Path.GetFullPath(bearbeitetdatei))
                    ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(bearbeitetdatei))
                    zieldatei = CStr(zielverzeichnisbearbeitet + ausgangsdateiohnepfad)

                    If Not IO.Directory.Exists(zielverzeichnisbearbeitet) AndAlso CStr(ausgangsdatei) <> String.Empty Then
                        System.IO.Directory.CreateDirectory(zielverzeichnisbearbeitet)
                        System.IO.File.Copy(ausgangsdatei, zieldatei)
                        System.IO.File.Delete(ausgangsdatei)
                    ElseIf IO.Directory.Exists(zielverzeichnisbearbeitet) AndAlso CStr(ausgangsdatei) <> String.Empty Then
                        System.IO.File.Copy(ausgangsdatei, zieldatei, overwrite:=True)
                        System.IO.File.Delete(ausgangsdatei)
                        MsgBox("Ulas erfolgreich gespeichert")
                        zieldatei = String.Empty
                    End If
                Next
            End If
        End Using
    End Sub

    ' Dateien per Drag and Drop verschieben 

    Public Shared Sub originalulasdraganddrop() ' Orginale verschieben

        If connectionString.Contains("127.0.0.1") Then
            verzeichnis = CStr("e:\heyduck\ulas\")
        Else
            verzeichnis = CStr("x:\ulas\")
        End If

        zielverzeichnis = String.Concat(verzeichnis, letzteid, "\", "Originale", "\")
        ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(origdropdatei))
        zieldatei = CStr(zielverzeichnis + ausgangsdateiohnepfad)

        If Not IO.Directory.Exists(zielverzeichnis) AndAlso CStr(origdropdatei) <> String.Empty Then
            System.IO.Directory.CreateDirectory(zielverzeichnis)
            System.IO.File.Copy(origdropdatei, zieldatei)
            System.IO.File.Delete(origdropdatei)
        ElseIf IO.Directory.Exists(zielverzeichnis) AndAlso CStr(origdropdatei) <> String.Empty Then
            System.IO.File.Copy(origdropdatei, zieldatei, overwrite:=True)
            System.IO.File.Delete(origdropdatei)
            MsgBox("Ulas erfolgreich gespeichert")
            zieldatei = String.Empty
        End If
    End Sub

    Public Shared Sub anonymisiertulasdraganddrop() ' anonymisierte Dateien verschieben
        If connectionString.Contains("127.0.0.1") Then
            verzeichnis = CStr("e:\heyduck\ulas\")
        Else
            verzeichnis = CStr("x:\ulas\")
        End If

        zielverzeichnisbearbeitet = String.Concat(verzeichnis, letzteid, "\", "bearbeitet", "\")
        ausgangsdateiohnepfad = CStr(IO.Path.GetFileName(anonymisiertdropdatei))
        zieldatei = CStr(zielverzeichnisbearbeitet + ausgangsdateiohnepfad)

        If Not IO.Directory.Exists(zielverzeichnisbearbeitet) AndAlso CStr(anonymisiertdropdatei) <> String.Empty Then
            System.IO.Directory.CreateDirectory(zielverzeichnisbearbeitet)
            System.IO.File.Copy(anonymisiertdropdatei, zieldatei)
            System.IO.File.Delete(anonymisiertdropdatei)
        ElseIf IO.Directory.Exists(zielverzeichnisbearbeitet) AndAlso CStr(anonymisiertdropdatei) <> String.Empty Then
            System.IO.File.Copy(anonymisiertdropdatei, zieldatei, overwrite:=True)
            System.IO.File.Delete(anonymisiertdropdatei)
            MsgBox("Ulas erfolgreich gespeichert")
            zieldatei = String.Empty
        End If
    End Sub
End Class
