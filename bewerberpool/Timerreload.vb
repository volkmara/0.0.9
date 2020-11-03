Public Class Timerreload
    Private Shared WithEvents myTimer As New System.Windows.Forms.Timer()


    ' This is the method to run when the timer is raised.
    Private Shared Sub TimerEventProcessor(myObject As Object, _
                                          ByVal myEventArgs As EventArgs) _
                                         Handles myTimer.Tick
        myTimer.Stop()

        frmMain.BewGridView1.SaveLayout("filter.xml")

        frmMain.Validate()
        frmMain.BewBindingSource.EndEdit()
        frmMain.Bew_bewerberdatenBindingSource.EndEdit()
        frmMain.UlasBindingSource.EndEdit()
        frmMain.Bewerber_berufserfahrungBindingSource.EndEdit()
        frmMain.Bewerber_ausbildungBindingSource.EndEdit()
        frmMain.Bewerber_sprachenBindingSource.EndEdit()
        frmMain.Bewerber_edvBindingSource.EndEdit()
        frmMain.Bewerber_bueroBindingSource.EndEdit()
        frmMain.Bew_assistenzBindingSource.EndEdit()
        frmMain.Bewerber_raeBindingSource.EndEdit()
        frmMain.Bewerber_vertriebBindingSource.EndEdit()
        frmMain.Bewerber_einkaufBindingSource.EndEdit()
        frmMain.Bewerber_versandBindingSource.EndEdit()
        frmMain.Bewerber_logistikBindingSource.EndEdit()
        frmMain.Bewerber_marketing_designBindingSource.EndEdit()
        frmMain.Bewerber_fibuBindingSource.EndEdit()
        frmMain.Bew_bibuhaBindingSource.EndEdit()
        frmMain.Bewerber_controllingBindingSource.EndEdit()
        frmMain.Bew_steuerfachangestellteBindingSource.EndEdit()
        frmMain.Bewerber_personalBindingSource.EndEdit()
        frmMain.Bew_lugBindingSource.EndEdit()
        frmMain.Bewerber_technikBindingSource.EndEdit()
        frmMain.Bewerber_itBindingSource.EndEdit()
        frmMain.GewerblichBindingSource.EndEdit()
        'frmMain.NotizenBindingSource.EndEdit()

        frmMain.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)
        frmMain.Bew_bewerberdatenTableAdapter.Update(frmMain.BewerberDataSet.bew_bewerberdaten)
        frmMain.UlasTableAdapter.Update(frmMain.BewerberDataSet.ulas)
        frmMain.Bewerber_ausbildungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_ausbildung)
        frmMain.Bewerber_berufserfahrungTableAdapter.Update(frmMain.BewerberDataSet.bewerber_berufserfahrung)
        frmMain.Bewerber_sprachenTableAdapter.Update(frmMain.BewerberDataSet.bewerber_sprachen)
        frmMain.Bewerber_edvTableAdapter.Update(frmMain.BewerberDataSet.bewerber_edv)
        frmMain.Bewerber_bueroTableAdapter.Update(frmMain.BewerberDataSet.bewerber_buero)
        frmMain.Bew_assistenzTableAdapter.Update(frmMain.BewerberDataSet.bew_assistenz)
        frmMain.Bewerber_raeTableAdapter.Update(frmMain.BewerberDataSet.bewerber_rae)
        frmMain.Bewerber_vertriebTableAdapter.Update(frmMain.BewerberDataSet.bewerber_vertrieb)
        frmMain.Bewerber_einkaufTableAdapter.Update(frmMain.BewerberDataSet.bewerber_einkauf)
        frmMain.Bewerber_versandTableAdapter.Update(frmMain.BewerberDataSet.bewerber_versand)
        frmMain.Bewerber_logistikTableAdapter.Update(frmMain.BewerberDataSet.bewerber_logistik)
        frmMain.Bewerber_marketing_designTableAdapter.Update(frmMain.BewerberDataSet.bewerber_marketing_design)
        frmMain.Bewerber_fibuTableAdapter.Update(frmMain.BewerberDataSet.bewerber_fibu)
        frmMain.Bew_bibuhaTableAdapter.Update(frmMain.BewerberDataSet.bew_bibuha)
        frmMain.Bewerber_controllingTableAdapter.Update(frmMain.BewerberDataSet.bewerber_controlling)
        frmMain.Bew_steuerfachangestellteTableAdapter.Update(frmMain.BewerberDataSet.bew_steuerfachangestellte)
        frmMain.Bewerber_personalTableAdapter.Update(frmMain.BewerberDataSet.bewerber_personal)
        frmMain.Bew_lugTableAdapter.Update(frmMain.BewerberDataSet.bew_lug)
        frmMain.Bewerber_technikTableAdapter.Update(frmMain.BewerberDataSet.bewerber_technik)
        frmMain.Bewerber_itTableAdapter.Update(frmMain.BewerberDataSet.bewerber_it)
        frmMain.GewerblichTableAdapter.Update(frmMain.BewerberDataSet.gewerblich)
        'frmMain.NotizenTableAdapter.Update(frmMain.BewerberDataSet.notizen)

        'frmMain.DBLoad()
        frmMain.BewGridView1.LoadLayout("filter.xml")
        myTimer.Enabled = True
    End Sub

    Public Shared Sub Reload()
        ' Adds the event and the event handler for the method that will
        ' process the timer event to the timer.
        ' Sets the timer interval to 5 minuten.
        myTimer.Interval = 900000 ' Speicherintervall 15 Minuten
        'myTimer.Interval = 20000
        'myTimer.Interval = 120000
        myTimer.Start()
    End Sub
    Public Shared Sub Timerstop()
        myTimer.Stop()
    End Sub
End Class
