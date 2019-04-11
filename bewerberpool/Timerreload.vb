Public Class Timerreload
    Private Shared WithEvents myTimer As New System.Windows.Forms.Timer()


    ' This is the method to run when the timer is raised.
    Private Shared Sub TimerEventProcessor(myObject As Object, _
                                          ByVal myEventArgs As EventArgs) _
                                         Handles myTimer.Tick
        myTimer.Stop()
        Call abfragespeichern()
        ' frmMain.DBLoad()
        myTimer.Enabled = True
    End Sub

    Public Shared Sub Reload()
        ' Adds the event and the event handler for the method that will
        ' process the timer event to the timer.
        ' Sets the timer interval to 5 minuten.
        myTimer.Interval = 1200000
        ' myTimer.Interval = 10000
        myTimer.Start()
    End Sub
    Public Shared Sub Timerstop()
        myTimer.Stop()
    End Sub
End Class
