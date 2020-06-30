Imports Microsoft.Reporting.WinForms
Imports bewerberpool.BewerberDataSet
Public Class kopfbogendrucken
    Public Shared Property reportdatei As String = String.Empty
    '  Public Shared Property kopfbogen_wo As String = String.Empty

    Public Shared Property nachricht As String = String.Concat("Eine zum Ausdruck geeignete Bewerberbeschreibung existiert nicht.", vbNewLine, vbNewLine, "Bitte bei ""Persönlichkeit"" etwas eintragen, sonst ist nix mit Kopfbogen, entweder mit dem Interviewerfragebogen oder später.")

    Public Shared Sub daten()

        Dim daten = DirectCast(DirectCast(frmMain.BewBindingSource.Current, DataRowView).Row, bewRow)
        refnr = CInt(daten.refnr)

        If connectionString.Contains("127.0.0.1") Then
            '  kopfbogen_wo = String.Concat("e:\heyduck\ulas\", refnr, "\", "Kopfbogen\")
            reportdatei = CStr("E:\heyduck\bewerberpool-neu\0.0.2\bewerberpool\Report1.rdlc")
        Else
            '  kopfbogen_wo = String.Concat("x:\ulas\", refnr, "\", "Kopfbogen\")
            reportdatei = CStr("X:\bewerberpool\Report1.rdlc")
        End If

        frmMain.BewTableAdapter.FillByParam1(frmMain.BewerberDataSet.bew, CInt(letzteid))
        frmMain.Bew_bewerberdatenTableAdapter.FillByParam1(frmMain.BewerberDataSet.bew_bewerberdaten, CInt(letzteid))
        frmMain.Bewerber_berufserfahrungTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_berufserfahrung, CInt(letzteid))
        frmMain.Bewerber_edvTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_edv, CInt(letzteid))
        frmMain.Bewerber_sprachenTableAdapter.FillByParam1(frmMain.BewerberDataSet.bewerber_sprachen, CInt(letzteid))
        frmMain.UlasTableAdapter.FillByParam1(frmMain.BewerberDataSet.ulas, CInt(letzteid))
    End Sub

    Public Shared Sub kopfbogen()

        Dim daten = DirectCast(DirectCast(frmMain.BewBindingSource.Current, DataRowView).Row, bewRow)

        If daten.Isbewerberbeschreibung_textNull Then
            MessageBox.Show(nachricht, "Bitte ausfüllen und abspeichern", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If daten.bewerberbeschreibung_text = String.Empty Then
            MessageBox.Show(nachricht, "Bitte ausfüllen und abspeichern", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        ElseIf daten.bewerberbeschreibung_text <> String.Empty Then
            Call kopfbogendrucken.daten()

            Dim rep As New LocalReport
            With rep
                .ReportPath = reportdatei
                .DataSources.Add(New ReportDataSource("DataSet1", frmMain.BewBindingSource))
                .DataSources.Add(New ReportDataSource("bewerberdaten", frmMain.Bew_bewerberdatenBindingSource))
                .DataSources.Add(New ReportDataSource("berufserfahrung", frmMain.Bewerber_berufserfahrungBindingSource))
                .DataSources.Add(New ReportDataSource("edv", frmMain.Bewerber_edvBindingSource))
                .DataSources.Add(New ReportDataSource("sprachen", frmMain.Bewerber_sprachenBindingSource))
                .DataSources.Add(New ReportDataSource("ulas", frmMain.UlasBindingSource))
            End With

            ' If Not IO.Directory.Exists(kopfbogen_wo) Then
            'IO.Directory.CreateDirectory(kopfbogen_wo)
            'End If

            ' Dim pdfspeichern As String = String.Concat(kopfbogen_wo, "Kopfbogen.pdf")
            Dim pdfspeichern As String = "Kopfbogen.pdf"

            Try
                Dim pdfContent As Byte() = rep.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Dim pdfFile As New System.IO.FileStream(pdfspeichern, System.IO.FileMode.Create)
                pdfFile.Write(pdfContent, 0, pdfContent.Length)
                pdfFile.Close()
                'MessageBox.Show("Datei erfolgreich gespeichert")
                frmMain.BewGridView1.FilterDescriptors.Clear()
                ' frmMain.DBLoad()
                System.Diagnostics.Process.Start(pdfspeichern) ' Kopfbogen anzeigen
            Catch ex As Exception
                MessageBox.Show("Fehler beim Speichern: " & ex.Message)
            End Try

        End If
    End Sub

    Public Shared Sub druckenkopfbogen()

        Dim daten = DirectCast(DirectCast(frmMain.BewBindingSource.Current, DataRowView).Row, bewRow)

        If daten.Isbewerberbeschreibung_textNull Then
            MessageBox.Show(nachricht, "Bitte ausfüllen und abspeichern", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If daten.bewerberbeschreibung_text = String.Empty Then
            MessageBox.Show(nachricht, "Bitte ausfüllen und abspeichern", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        ElseIf daten.bewerberbeschreibung_text <> String.Empty Then
            Call kopfbogendrucken.daten()

            Dim rep As New LocalReport
            With rep
                .ReportPath = reportdatei
                .DataSources.Add(New ReportDataSource("DataSet1", frmMain.BewBindingSource))
                .DataSources.Add(New ReportDataSource("bewerberdaten", frmMain.Bew_bewerberdatenBindingSource))
                .DataSources.Add(New ReportDataSource("berufserfahrung", frmMain.Bewerber_berufserfahrungBindingSource))
                .DataSources.Add(New ReportDataSource("edv", frmMain.Bewerber_edvBindingSource))
                .DataSources.Add(New ReportDataSource("sprachen", frmMain.Bewerber_sprachenBindingSource))
                .DataSources.Add(New ReportDataSource("ulas", frmMain.UlasBindingSource))
            End With

            ' Ausdrucken
            Try
                Dim prt = DirectPrinting.getInstance
                prt.DirectPrint(rep)
                frmMain.BewGridView1.FilterDescriptors.Clear()
                '  frmMain.DBLoad()
            Catch ex As Exception
                'MessageBox.Show("Fehler beim Drucken: " & ex.Message)
            End Try
        End If
    End Sub
End Class
