Imports Microsoft.Reporting.WinForms
Imports bewerberpool.BewerberDataSet

Public Class bewerberbogen_ausdrucken
    Public Shared Property reportdatei As String = String.Empty

    Public Shared Sub Datenquellenladen()

        ' refnr (in Module1 definiert) aus BewBindingsource holen
        Dim daten = DirectCast(DirectCast(frmMain.BewBindingSource.Current, DataRowView).Row, bewRow)
        refnr = CInt(daten.refnr)

        If connectionString.Contains("127.0.0.1") Then
            verzeichnis = CStr("e:\heyduck\ulas\")
            ' reportdatei = CStr("E:\heyduck\bewerberpool-neu\0.0.2\bewerberpool\Bewerberbogen_Druck.rdlc")
            reportdatei = CStr("E:\heyduck\bewerberpool-neu\0.0.6\bewerberpool\Report2.rdlc")
            ' reportdatei = CStr("E:\heyduck\bewerberpool-neu\0.0.6\bewerberpool\Report4.rdlc")
        Else
            verzeichnis = CStr("x:\ulas\")
            'reportdatei = CStr("X:\bewerberpool\Bewerberbogen_Druck.rdlc")
            reportdatei = CStr("X:\bewerberpool\Report2.rdlc")
            ' reportdatei = CStr("X:\bewerberpool\Report4.rdlc")
        End If

        frmMain.BewTableAdapter.FillByParam1(frmMain.BewerberDataSet.bew, CInt(letzteid))
        frmMain.Bew_bewerberdatenTableAdapter.FillByParam1(frmMain.BewerberDataSet.bew_bewerberdaten, CInt(letzteid))
        frmMain.Bewerber_ausbildungTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_ausbildung, CInt(letzteid))
        frmMain.Bewerber_berufserfahrungTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_berufserfahrung, CInt(letzteid))
        frmMain.Bewerber_edvTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_edv, CInt(letzteid))
        frmMain.Bewerber_sprachenTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_sprachen, CInt(letzteid))
        frmMain.Bew_assistenzTableAdapter.FillByParam1(frmMain.BewerberDataSet.bew_assistenz, CInt(letzteid))
        frmMain.Bewerber_bueroTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_buero, CInt(letzteid))
        frmMain.Bewerber_raeTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_rae, CInt(letzteid))
        frmMain.Bewerber_fibuTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_fibu, CInt(letzteid))
        frmMain.Bew_bibuhaTableAdapter.FillByParam1(frmMain.BewerberDataSet.bew_bibuha, CInt(letzteid))
        frmMain.Bewerber_controllingTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_controlling, CInt(letzteid))
        frmMain.Bew_lugTableAdapter.FillByParam1(frmMain.BewerberDataSet.bew_lug, CInt(letzteid))
        frmMain.Bew_steuerfachangestellteTableAdapter.FillByParam1(frmMain.BewerberDataSet.bew_steuerfachangestellte, CInt(letzteid))
        frmMain.Bewerber_vertriebTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_vertrieb, CInt(letzteid))
        frmMain.Bewerber_einkaufTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_einkauf, CInt(letzteid))
        frmMain.Bewerber_versandTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_versand, CInt(letzteid))
        frmMain.Bewerber_logistikTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_logistik, CInt(letzteid))
        frmMain.Bewerber_marketing_designTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_marketing_design, CInt(letzteid))
        frmMain.Bewerber_personalTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_personal, CInt(letzteid))
        frmMain.Bewerber_technikTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_technik, CInt(letzteid))
        frmMain.Bewerber_itTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_it, CInt(letzteid))
        frmMain.GewerblichTableAdapter.FillByParam1(frmMain.BewerberDataSet.gewerblich, CInt(letzteid))
    End Sub

    ' Bewerberbogen speichern
    Public Shared Sub speichern_bewerberbogen()

        Call Datenquellenladen()

        Dim rep As New LocalReport
        With rep
            .ReportPath = reportdatei
            .DataSources.Add(New ReportDataSource("bew", frmMain.BewBindingSource))
            .DataSources.Add(New ReportDataSource("bewerberdaten", frmMain.Bew_bewerberdatenBindingSource))
            .DataSources.Add(New ReportDataSource("ausbildung", frmMain.Bewerber_ausbildungBindingSource))
            .DataSources.Add(New ReportDataSource("berufserfahrung", frmMain.Bewerber_berufserfahrungBindingSource))
            .DataSources.Add(New ReportDataSource("sprachen", frmMain.Bewerber_sprachenBindingSource))
            .DataSources.Add(New ReportDataSource("edv", frmMain.Bewerber_edvBindingSource))
            .DataSources.Add(New ReportDataSource("büro", frmMain.Bewerber_bueroBindingSource))
            .DataSources.Add(New ReportDataSource("assistenz", frmMain.Bew_assistenzBindingSource))
            .DataSources.Add(New ReportDataSource("rae", frmMain.Bewerber_raeBindingSource))
            .DataSources.Add(New ReportDataSource("FiBu", frmMain.Bewerber_fibuBindingSource))
            .DataSources.Add(New ReportDataSource("bibuha", frmMain.Bew_bibuhaBindingSource))
            .DataSources.Add(New ReportDataSource("controlling", frmMain.Bewerber_controllingBindingSource))
            .DataSources.Add(New ReportDataSource("lug", frmMain.Bew_lugBindingSource))
            .DataSources.Add(New ReportDataSource("steuerfachangestellte", frmMain.Bew_steuerfachangestellteBindingSource))
            .DataSources.Add(New ReportDataSource("vertrieb", frmMain.Bewerber_vertriebBindingSource))
            .DataSources.Add(New ReportDataSource("einkauf", frmMain.Bewerber_einkaufBindingSource))
            .DataSources.Add(New ReportDataSource("versand", frmMain.Bewerber_versandBindingSource))
            .DataSources.Add(New ReportDataSource("logistik", frmMain.Bewerber_logistikBindingSource))
            .DataSources.Add(New ReportDataSource("marketing", frmMain.Bewerber_marketing_designBindingSource))
            .DataSources.Add(New ReportDataSource("personal", frmMain.Bewerber_personalBindingSource))
            .DataSources.Add(New ReportDataSource("technik", frmMain.Bewerber_technikBindingSource))
            .DataSources.Add(New ReportDataSource("it", frmMain.Bewerber_itBindingSource))
            '.DataSources.Add(New ReportDataSource("gewerblich", frmMain.GewerblichBindingSource))
            ' .DataSources.Add(New ReportDataSource("dsgv", frmMain.dsgvBindingSource))
        End With

        ' Speichern für Anzeige

        Dim pdfspeichern As String = "Bewerberbogen.pdf"

        Try
            Dim pdfContent As Byte() = rep.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim pdfFile As New System.IO.FileStream(pdfspeichern, System.IO.FileMode.Create)
            pdfFile.Write(pdfContent, 0, pdfContent.Length)
            pdfFile.Close()
            ' MessageBox.Show("Datei erfolgreich gespeichert")
            System.Diagnostics.Process.Start(pdfspeichern)
        Catch ex As Exception
            MessageBox.Show("Fehler beim Speichern: " & ex.Message)
        End Try
    End Sub

    ' Bewerberbogen drucken
    Public Shared Sub druckenbewerberbogen()

        Call Datenquellenladen()

        Dim rep As New LocalReport
        With rep
            .ReportPath = reportdatei
            .DataSources.Add(New ReportDataSource("bew", frmMain.BewBindingSource))
            .DataSources.Add(New ReportDataSource("bewerberdaten", frmMain.Bew_bewerberdatenBindingSource))
            .DataSources.Add(New ReportDataSource("ausbildung", frmMain.Bewerber_ausbildungBindingSource))
            .DataSources.Add(New ReportDataSource("berufserfahrung", frmMain.Bewerber_berufserfahrungBindingSource))
            .DataSources.Add(New ReportDataSource("sprachen", frmMain.Bewerber_sprachenBindingSource))
            .DataSources.Add(New ReportDataSource("edv", frmMain.Bewerber_edvBindingSource))
            .DataSources.Add(New ReportDataSource("büro", frmMain.Bewerber_bueroBindingSource))
            .DataSources.Add(New ReportDataSource("assistenz", frmMain.Bew_assistenzBindingSource))
            .DataSources.Add(New ReportDataSource("rae", frmMain.Bewerber_raeBindingSource))
            .DataSources.Add(New ReportDataSource("FiBu", frmMain.Bewerber_fibuBindingSource))
            .DataSources.Add(New ReportDataSource("bibuha", frmMain.Bew_bibuhaBindingSource))
            .DataSources.Add(New ReportDataSource("controlling", frmMain.Bewerber_controllingBindingSource))
            .DataSources.Add(New ReportDataSource("lug", frmMain.Bew_lugBindingSource))
            .DataSources.Add(New ReportDataSource("steuerfachangestellte", frmMain.Bew_steuerfachangestellteBindingSource))
            .DataSources.Add(New ReportDataSource("vertrieb", frmMain.Bewerber_vertriebBindingSource))
            .DataSources.Add(New ReportDataSource("einkauf", frmMain.Bewerber_einkaufBindingSource))
            .DataSources.Add(New ReportDataSource("versand", frmMain.Bewerber_versandBindingSource))
            .DataSources.Add(New ReportDataSource("logistik", frmMain.Bewerber_logistikBindingSource))
            .DataSources.Add(New ReportDataSource("marketing", frmMain.Bewerber_marketing_designBindingSource))
            .DataSources.Add(New ReportDataSource("personal", frmMain.Bewerber_personalBindingSource))
            .DataSources.Add(New ReportDataSource("technik", frmMain.Bewerber_technikBindingSource))
            .DataSources.Add(New ReportDataSource("it", frmMain.Bewerber_itBindingSource))
            .DataSources.Add(New ReportDataSource("gewerblich", frmMain.GewerblichBindingSource))
            ' .DataSources.Add(New ReportDataSource("dsgv", frmMain.dsgvBindingSource))
        End With

        ' Ausdrucken
        Try
            Dim prt = DirectPrinting.getInstance
            prt.DirectPrint(rep)
            '  frmMain.DBLoad()
        Catch ex As Exception
            'MessageBox.Show("Fehler beim Drucken: " & ex.Message)
        End Try
    End Sub

End Class
