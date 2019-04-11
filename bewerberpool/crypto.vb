Imports System.Security
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class crypto

    Public Shared Property Encryptionkey As String

    Public Shared Function Encrypt(clearText As String) As String
        '  Dim EncryptionKey As String = "$kldfKFSAK37236780!!*+++hHUDO723BNU!$hask+*jhds7!2929j$+jP*!hWrT$kldfKFSAK37236780!!*+++hHUDO723BNU!$hask+*jhds7!2929j$+jP*!hWrT"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)

            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Public Shared Function Decrypt(cipherText As String) As String
        ' Dim EncryptionKey As String = "$kldfKFSAK37236780!!*+++hHUDO723BNU!$hask+*jhds7!2929j$+jP*!hWrT$kldfKFSAK37236780!!*+++hHUDO723BNU!$hask+*jhds7!2929j$+jP*!hWrT"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)

            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
End Class
