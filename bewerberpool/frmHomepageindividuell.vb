Imports bewerberpool.heyduckDataSet
Public Class frmHomepageindividuell

    Private _frmMain As frmMain

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmHomepageindividuell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Internetverbindung()
        If Inet Then
            Me.Tt_newsTableAdapter.Fill(Me.HeyduckDataSet.tt_news)
            Tt_newsBindingSource.Filter = "Tx_ttnewserweiterung_referenznummer = '" & rf & "'"
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmHomepageindividuell_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim homepage = DirectCast(DirectCast(Tt_newsBindingSource.Current, DataRowView).Row, tt_newsRow)
        lblEintragsdatum.Text = TimestampzuDate(homepage.datetime).ToString
        lblEndtime.Text = TimestampzuDate(homepage.endtime).ToString
    End Sub


    Function TimestampzuDate(ByVal timestamp As Double) As DateTime
        Return New DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(timestamp).ToLocalTime()
    End Function


    Private Function DatezuTimestamp(ByVal currDate As DateTime) As Double
        'create Timespan by subtracting the value provided from the Unix Epoch
        Dim span As TimeSpan = (currDate - New DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime())
        'return the total seconds (which is a UNIX timestamp)
        Return span.TotalSeconds
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim homepage = DirectCast(DirectCast(Tt_newsBindingSource.Current, DataRowView).Row, tt_newsRow)
        Dim homepagetime As Integer = CInt(homepage.datetime)
        MsgBox(homepagetime)
        MsgBox(TimestampzuDate(homepagetime))
        '  DateTimePicker1.Text = CStr(ConvertTimestamp(homepagetime))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MsgBox(DateTimePicker1.Value.ToString)
        'TextBox1.Text = DateTimePicker1.Value.ToString

        '        Dim utime As Date = DateTimePicker1.Value
        '       Dim utimeneu As Integer = CInt(0)

        'Dim uTime As DateTime = DateTimePicker1.Value
        'utimeneu = CInt((utime.Utc - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds)
        ' utimeneu = CInt(utime.ToUniversalTime - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds))
        'utimeneu = CInt(DateTimePicker1.Value - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds))
        'uTime = Date.FromOADate((DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds)

        '   MsgBox(ConvertTimestamp(DateTimePicker1.Value.ToOADate()))
        MsgBox(DatezuTimestamp(DateTimePicker1.Value))


        'MsgBox(utimeneu)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click, btnClose.Click
        Select Case True
            Case sender Is btnClose
                Me.Close()
            Case sender Is btnSave
                Dim homepage = DirectCast(DirectCast(Tt_newsBindingSource.Current, DataRowView).Row, tt_newsRow)
                If cbHomepage.Checked Then
                    homepage.datetime = CUInt(DatezuTimestamp(Date.Now))
                End If
                If cbStopzeit.Checked Then
                    homepage.endtime = CUInt(DatezuTimestamp(DateTimePicker1.Value))
                End If

                ' If homepage.endtime < CUInt(DatezuTimestamp(Date.Now)) Then
                '  If homepage.endtime < CUInt(DatezuTimestamp(DateTimePicker1.Value)) Then
                ' homepage.endtime = CUInt(DatezuTimestamp(DateTimePicker1.Value))
                'MsgBox(CUInt(DatezuTimestamp(DateTimePicker1.Value)))
                'End If
                Me.Validate()
                Me.Tt_newsBindingSource.EndEdit()
                Me.Tt_newsTableAdapter.Update(HeyduckDataSet.tt_news)
        End Select

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim homepage = DirectCast(DirectCast(Tt_newsBindingSource.Current, DataRowView).Row, tt_newsRow)
        '    Dim datumneu As Integer = CInt((DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds)
        'Dim datumneu1 As Integer = CInt((DateTime.Now - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds)
        '   MsgBox(datumneu)
        MsgBox(homepage.endtime)
        MsgBox((CUInt(DatezuTimestamp(DateTimePicker1.Value))))
    End Sub

    Private Sub cbStopzeit_CheckedChanged(sender As Object, e As EventArgs) Handles cbStopzeit.CheckedChanged
        Dim homepage = DirectCast(DirectCast(Tt_newsBindingSource.Current, DataRowView).Row, tt_newsRow)
        If cbStopzeit.Checked Then
            DateTimePicker1.Visible = True
            MsgBox(homepage.endtime)
            MsgBox(CUInt(DatezuTimestamp(DateTimePicker1.Value)))
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim homepage = DirectCast(DirectCast(Tt_newsBindingSource.Current, DataRowView).Row, tt_newsRow)

        MsgBox(TimestampzuDate(homepage.datetime).ToString)

        MsgBox(Date.Now)
        MsgBox(CUInt(DatezuTimestamp(Date.Now)).ToString)

    End Sub
End Class