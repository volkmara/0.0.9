Imports System.Net.Mail
Public NotInheritable Class Mail
    Public Property subject As String
    Public Property body As String
    Public Property receiver As String
    Public Property sender As String
    Public Property attachmentfile As String = String.Empty
    Public Property emailusername As String
    Public Property emailpassword As String


    Public Sub send()
        Try
            Dim smtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            smtpServer.UseDefaultCredentials = False
            'smtpServer.Credentials = New Net.NetworkCredential("wp11114271-heyduck", "TYGMn6D7!")
            smtpServer.Credentials = New Net.NetworkCredential("service2@startzeit.de", "bowiguso")
            'smtpServer.Port = 587
            smtpServer.Port = 25
            'smtpServer.EnableSsl = True
            smtpServer.EnableSsl = False
            'smtpServer.Host = "	wp11114271.mailout.server-he.de"
            smtpServer.Host = "192.168.190.100"

            mail = New MailMessage()
            mail.From = New MailAddress("kontakt@heyduck-personalservice.de")
            mail.To.Add(receiver)
            ' mail.To.Add("volkmar.adler@heyduck-zeitarbeit.de")
            mail.Subject = subject
            mail.Body = body
            smtpServer.Send(mail)
            smtpServer.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try
    End Sub

End Class