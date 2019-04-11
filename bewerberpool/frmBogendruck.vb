Public Class frmBogendruck

    ' Bogenauswahl

    Public Shared Property auswahlkopfbogen_bool As Boolean = False
    Public Shared Property auswahlbewerberbogen_bool As Boolean = False
    Public Shared Property auswahlbewerberbogenergänzt_bool As Boolean = False

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmBogendruck_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RadioButton1.Checked = False
        Call Bogenauswahl()
    End Sub

    Private Sub Bogenauswahl()
        Select Case True
            Case auswahlkopfbogen_bool
                RadioButton1.Text = "Kopfbogen anzeigen"
                RadioButton2.Text = "Kopfbogen drucken"
                RadioButton3.Text = "Kopfbogen drucken und anzeigen"
                GroupBox1.Text = "Kopfbogen"
            Case auswahlbewerberbogen_bool
                RadioButton1.Text = "Bewerberbogen anzeigen"
                RadioButton2.Text = "Bewerberbogen drucken"
                RadioButton3.Text = "Bewerberbogen drucken und anzeigen"
                GroupBox1.Text = "Bewerberbogen"
            Case auswahlbewerberbogenergänzt_bool
                RadioButton1.Text = "Ergänzten Bewerberbogen anzeigen "
                RadioButton2.Text = "Ergänzten Bewerberbogen drucken "
                RadioButton3.Text = "Ergänzten Bewerberbogen drucken und anzeigen"
                GroupBox1.Text = "Ergänzter Bewerberbogen"
        End Select
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then ' Bogen speichern
            If frmBogendruck.auswahlkopfbogen_bool Then
                Call kopfbogendrucken.kopfbogen()
            ElseIf frmBogendruck.auswahlbewerberbogen_bool Then
                ' Call frmMain.bewerberbogendrucken()
                Call bewerberbogen_ausdrucken.speichern_bewerberbogen()
            ElseIf frmBogendruck.auswahlbewerberbogenergänzt_bool Then
                Call bewerberbogen_ergänzt_ausdruck.ausdruckergänztspeichern()
            End If
            Me.Close()
        ElseIf RadioButton2.Checked Then ' Bogen drucken
            If frmBogendruck.auswahlkopfbogen_bool Then
                Call kopfbogendrucken.druckenkopfbogen()
            ElseIf frmBogendruck.auswahlbewerberbogen_bool Then
                Call bewerberbogen_ausdrucken.druckenbewerberbogen()
            ElseIf frmBogendruck.auswahlbewerberbogenergänzt_bool Then
                Call bewerberbogen_ergänzt_ausdruck.bewerberbogenergänztdrucken()
            End If
            Me.Close()
        ElseIf RadioButton3.Checked Then ' Bogen drucken und speichern
            If frmBogendruck.auswahlkopfbogen_bool Then
                Call kopfbogendrucken.druckenkopfbogen()
                Call kopfbogendrucken.kopfbogen()
                Me.Close()
            ElseIf frmBogendruck.auswahlbewerberbogen_bool Then
                Call bewerberbogen_ausdrucken.druckenbewerberbogen()
                Call bewerberbogen_ausdrucken.speichern_bewerberbogen()
                ' Call frmMain.bewerberbogendrucken()
                Me.Close()
            ElseIf frmBogendruck.auswahlbewerberbogenergänzt_bool Then
                Call bewerberbogen_ergänzt_ausdruck.bewerberbogenergänztdrucken()
                Call bewerberbogen_ergänzt_ausdruck.ausdruckergänztspeichern()
                Me.Close()
            End If
        End If
    End Sub
End Class