Imports MySql.Data.MySqlClient
Imports System.Net

Module Module1

    'Public connectionString As String = "Server=127.0.0.1; uid=root; pwd=heyduck1!; Convert Zero Datetime=True; persistsecurityinfo=True; database=bewerberneu;"
    'Public oaconnectionString As String = "Server=127.0.0.1; uid=root; pwd=heyduck1!; database=oa;"
    'Public benutzerverwaltungConnectionString As String = "Server=127.0.0.1;user id=root;password=heyduck1!;persistsecurityinfo=True;database=benutzerverwaltung;"
    'Public heyduckConnectionString As String = "server=heyduck-personalservice.de;user id=heyduck;password=heyduck1!;persistsecurityinfo=True;database=heyduck;"
    Public newsletterConnectionString As String = "server=heyduck-personalservice.de;user id=newsletter;password=EeVBHjtF;persistsecurityinfo=True;database=newsletter;fConvert Zero Datetime=True;"
    Public connectionString As String = "Server=SERVER2012; user id=Adler; password=zgA7K$z!; Convert Zero Datetime=True;database=bewerberneu;"
    Public oaconnectionString As String = "Server=SERVER2012; user id=Adler; password=zgA7K$z!; database=oa;"
    Public benutzerverwaltungConnectionString As String = "Server=SERVER2012; user id=Adler; password=zgA7K$z!; Convert Zero Datetime=True;persistsecurityinfo=True;database=benutzerverwaltung;"

    ' Public username As String = String.Empty
    Public usernameklar As String = String.Empty
    Public loginflag As Integer = CInt(-1)
    Public bewid As Integer = CInt(0) ' Id aus Datenbank
    Public letzteid As Integer = CInt(0) ' Id aus Haupttabelle
    Public autoincrementwert As Integer = CInt(0) ' Autoincrement-Wert aus DB
    Public refnr As Integer = CInt(0)
    Public rf As String = String.Empty
    ' Ulasverzeichnis definieren
    Public verzeichnis As String = String.Empty
    Public Inet As Boolean = Inetverbindung(Inet)
    Public computername As String = System.Environment.MachineName
    Public benutzer As String = System.Environment.UserName

    Public Sub Getbewid()
        Dim query As String = ("SELECT MAX(id_bew) From bewerberneu.bew")
        Dim cnn As New MySqlConnection(connectionString)

        Using connection As New MySqlConnection(connectionString)
            Try
                cnn.Open()
                Dim command As New MySqlCommand(query, cnn)
                bewid = CInt(command.ExecuteScalar())
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Public Sub GetAutoincrement()
        Dim query As String = "SELECT auto_increment FROM information_schema.TABLES where TABLE_SCHEMA = 'bewerberneu' and TABLE_NAME = 'bew';"

        Dim cnn As New MySqlConnection(connectionString)

        Using connection As New MySqlConnection(connectionString)
            Try
                cnn.Open()
                Dim command As New MySqlCommand(query, cnn)
                Dim reader As MySqlDataReader = command.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    autoincrementwert = CInt(reader("auto_increment"))
                End If
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Public Sub gespeichert()
        MessageBox.Show("Daten erfolgreich gespeichert", "Daten erfolgreich gespeichert", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub abfragespeichern()
        Dim result As DialogResult = MessageBox.Show("Möchten Sie Ihre Eingaben vorher speichern?", "Speichern", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            frmMain.DBLoad()
            If result = DialogResult.No Then
                Exit Sub
            End If
        End If
    End Sub

    ' Abfrage, ob Internetzugang besteht und heyduck-personalservice.de pingbar ist. Da Interviewer keinen Inetzugang haben, darf alles, was einen Inetzugang erfordert, nicht geladen werden
    Public Function Inetverbindung(ByVal url As Boolean) As Boolean
        Try
            My.Computer.Network.Ping("www.heyduck-personalservice.de")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function IsUrlValid(ByVal url As String, ByVal timeout As Integer) As Boolean
        Try
            Dim request As HttpWebRequest = TryCast(HttpWebRequest.Create(url), HttpWebRequest)
            request.Timeout = timeout
            request.Method = "Head"

            Using response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
                Dim statusCode As Integer = CInt(response.StatusCode)
                If statusCode >= 100 AndAlso statusCode < 400 Then Return True
            End Using

        Catch ex As WebException

            If ex.Status <> WebExceptionStatus.ProtocolError Then
                '  Console.ForegroundColor = ConsoleColor.Red
                ' Console.WriteLine(ex.Message)
                ' Console.ResetColor()
            End If
        End Try
        Return False
    End Function

    Public Sub Internetverbindung()
        If Not Inet OrElse Not IsUrlValid("http://www.heyduck-personalservice.de", 2000) Then ' Die Function IsUrlValid steht in Module1
            MessageBox.Show("Es besteht keine Internetverbindung oder der Webserver ist nicht erreichbar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Auf Speichern hinweisen, wenn aus anderer Form Änderungen übernommen wurden.
    Public Sub Speichernhinweis()
        MessageBox.Show("Speichern nicht vergessen, Einträge wurden geändert", "Speichern nicht vergessen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
