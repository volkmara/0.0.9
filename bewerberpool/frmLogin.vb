Imports System.Security
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports bewerberpool.benutzerverwaltungDataSet
Public Class frmLogin

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BenutzerTableAdapter.Fill(Me.BenutzerverwaltungDataSet.benutzer)
        Me.KeyTableAdapter.Fill(Me.BenutzerverwaltungDataSet.key)
        Dim encryptionrow = DirectCast(DirectCast(KeyBindingSource.Current, DataRowView).Row, keyRow)
        crypto.Encryptionkey = CStr(encryptionrow.keycol)
    End Sub

    Public Function GetBenutzernameExists(ByVal benutzername As String) As Boolean
        Dim test1 As String = CStr(crypto.Encrypt(txtUsername.Text))
        Return Me.BenutzerverwaltungDataSet.benutzer.Any(Function(rw) rw.benutzername = test1)
    End Function

    Public Function GetPasswordExists(ByVal benutzername As String) As Boolean
        Dim test2 As String = CStr(crypto.Encrypt(txtPassword.Text))
        Return Me.BenutzerverwaltungDataSet.benutzer.Any(Function(rw) rw.kennwort = test2)
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        usernameklar = CStr(txtUsername.Text)
        Dim username As String = CStr(crypto.Encrypt(txtUsername.Text))
        Dim password As String = CStr(crypto.Encrypt(txtPassword.Text))
        Dim vorhanden1 As Boolean = GetBenutzernameExists(username)
        Dim vorhanden2 As Boolean = GetPasswordExists(password)

        If String.IsNullOrEmpty(username) Then Exit Sub ' Ausführung anhalten, wenn nichts eingetragen wurde
        If String.IsNullOrEmpty(password) Then Exit Sub ' Ausführung anhalten, wenn nichts eingetragen wurde

        If vorhanden1 AndAlso vorhanden2 Then
            Me.BenutzerTableAdapter.ScalarQuery(Me.BenutzerverwaltungDataSet.benutzer, username, password)
            Dim loginflagausdataset = DirectCast(DirectCast(Me.BenutzerBindingSource.Current, DataRowView).Row, benutzerRow)
            loginflag = CInt(loginflagausdataset.zugang_bewpool)
            Me.Close()
        Else
            MsgBox("Username und/oder Passwort ist falsch.")
            loginflag = 0
            frmMain.Close()
            Me.Close()
        End If
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        frmMain.Close()
        Me.Close()
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AcceptButton = btnOK
    End Sub
End Class