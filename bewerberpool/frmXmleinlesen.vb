Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.IO
Imports bewerberpool.BewerberDataSet

Public Class frmXmleinlesen
    Private frmMain As frmMain
    Public xmlverzeichnis As String = String.Empty ' Verzeichnis, in dem vom BT die xml-Datei gespeichert wird
    Public xmlneuverzeichnis As String = String.Empty ' Verzeichnis, in dem die bearbeiteten Dateien gespeichert werden
    Public xmlaltverzeichnis As String = String.Empty ' unbearbeitete Originaldateien werden in dieses Verzeichnis verschoben
    Public xmlzumeinlesen As String = String.Empty ' Verzeichnisstring zum Einlesen in DB
    Public xmltextneu As String = String.Empty
    Public xmlneu As String = String.Empty
    Public xmlalt As String = String.Empty
    Public filename As String = String.Empty
    Public bewidneu As Integer = 1
    '  Public filename As String = String.Empty
    Public eintraegekorrekt_bool As Boolean = True
    Public Shared Property sqlfile As String = String.Empty
    Public Shared Property xmleinlesen_bool As Boolean = False

    Public Sub New(frmMain As frmMain)
        Me.frmMain = frmMain
        InitializeComponent()
    End Sub

    Private Sub frmXmleinlesen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BewTableAdapter.Fill(Me.BewerberDataSet.bew)
        Me.BewBindingSource.DataSource = frmMain.BewBindingSource
        Call xmldateieneinlesen()
    End Sub


    Private Sub xmldateieneinlesen()
        If connectionString.Contains("127.0.0.1") Then
            xmlverzeichnis = CStr("e:\heyduck\xml\")
            xmlneuverzeichnis = CStr("e:\heyduck\xml\neu")
            xmlaltverzeichnis = CStr("e:\heyduck\xml\alt")
        Else
            xmlverzeichnis = CStr("x:\xml\")
            xmlneuverzeichnis = CStr("x:\xml\neu")
            xmlaltverzeichnis = CStr("x:\xml\alt")
        End If

        lstXml.Items.Clear()

        If IO.Directory.Exists(xmlverzeichnis) Then

            Dim xmlliste = New List(Of IO.FileInfo)
            xmlliste.AddRange(New IO.DirectoryInfo(xmlverzeichnis).GetFiles("*.xml", SearchOption.TopDirectoryOnly))

            ' Prüfen, ob mindestens eine xml-Datei im Verzeichnis vorhanden ist, sonst Abbruch
            If xmlliste.Count > 0 Then

                'lstXml.DataSource = xmlliste

                For Each Item As FileInfo In xmlliste
                    Dim listitem As String = String.Concat(xmlverzeichnis, Item.ToString)
                    lstXml.Items.Add(listitem)
                Next
            Else
                MessageBox.Show("Keine xml-Datei zum Einlesen vorhanden.", "Keine xml-Datei vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            lstXml.Items.Clear()
            Exit Sub
            Me.Close()
        End If

    End Sub

    Private Sub lstXml_DoubleClick(sender As Object, e As EventArgs) Handles lstXml.DoubleClick
        Call Xmlersetzungen()
    End Sub

    Private Sub Xmlersetzungen()
        Call GetAutoincrement()

        Call frmMain.DBLoad()

        Me.Label2.Visible = True
        Me.Panel1.Visible = True

        Me.Label4.Text = CStr(bewidneu)
        Me.Label6.Text = CStr(bewidneu)
        Dim text As String = File.ReadAllText(lstXml.SelectedItem.ToString)

        xmltextneu = text.Replace("<id_bewerberdaten>1", String.Concat("<id_bewerberdaten>", autoincrementwert)).Replace("<id_bew>1", String.Concat("<id_bew>", autoincrementwert)).Replace("<id_ausbildung>1", String.Concat("<id_ausbildung>", autoincrementwert)).Replace("<id_berufserfahrung>1", String.Concat("<id_berufserfahrung>", autoincrementwert)).Replace("<id_sprachen>1", String.Concat("<id_sprachen>", autoincrementwert)).Replace("<id_edv>1", String.Concat("<id_edv>", autoincrementwert)).Replace("<id_assistenz>1", String.Concat("<id_assistenz>", autoincrementwert)).Replace("<id_buero>1", String.Concat("<id_buero>", autoincrementwert)).Replace("<id_rae>1", String.Concat("<id_rae>", autoincrementwert)).Replace("<id_fibu>1", String.Concat("<id_fibu>", autoincrementwert)).Replace("<id_bibuha>1", String.Concat("<id_bibuha>", autoincrementwert)).Replace("<id_controlling>1", String.Concat("<id_controlling>", autoincrementwert)).Replace("<id_steuerfachang>1", String.Concat("<id_steuerfachang>", autoincrementwert)).Replace("<id_lug>1", String.Concat("<id_lug>", autoincrementwert)).Replace("<id_vertrieb>1", String.Concat("<id_vertrieb>", autoincrementwert)).Replace("<id_einkauf>1", String.Concat("<id_einkauf>", autoincrementwert)).Replace("<id_logistik>1", String.Concat("<id_logistik>", autoincrementwert)).Replace("<id_versand>1", String.Concat("<id_versand>", autoincrementwert)).Replace("<id_m_d>1", String.Concat("<id_m_d>", autoincrementwert)).Replace("<id_personal>1", String.Concat("<id_personal>", autoincrementwert)).Replace("<id_technik>1", String.Concat("<id_technik>", autoincrementwert)).Replace("<id_it>1", String.Concat("<id_it>", autoincrementwert)).Replace("<id_gewerblich>1", String.Concat("<id_gewerblich>", autoincrementwert)).Replace("<refnr>1", String.Concat("<refnr>", autoincrementwert)).Replace("<id_ulas>1", String.Concat("<id_ulas>", autoincrementwert))


        rtb.Text = xmltextneu
        Dim found As Boolean = True
        Dim found1 As Boolean = True
        Dim found2 As Boolean = True
        Dim index As Integer = 0
        Dim index1 As Integer = 0
        Dim index2 As Integer = 0

        Do
            index = rtb.Text.IndexOf("<id_", index)
            If (index >= 0) Then
                rtb.SelectionStart = index
                rtb.SelectionLength = 3
                rtb.SelectionColor = Color.Blue
                index += 3
            Else
                found = False
            End If
        Loop While found = True

        Do
            index1 = rtb.Text.IndexOf(CStr(autoincrementwert), index1)
            If (index1 >= 0) Then
                rtb.SelectionStart = index1
                rtb.SelectionLength = 4
                rtb.SelectionColor = Color.Green
                index1 += 4
            Else
                found1 = False
            End If
        Loop While found1 = True

        Do
            index2 = rtb.Text.IndexOf("<refnr>", index2)
            If (index2 >= 0) Then
                rtb.SelectionStart = index2
                rtb.SelectionLength = 6
                rtb.SelectionColor = Color.Red
                index2 += 6
            Else
                found2 = False
            End If
        Loop While found2 = True
    End Sub

    Private Sub btneintragen_Click(sender As Object, e As EventArgs) Handles btneintragen.Click
        ' bearbeitete xml-datei speichern
        ' filename = CStr(lstXml.SelectedItem.ToString)
        Dim dateiname As String = CStr(My.Computer.FileSystem.GetName(lstXml.SelectedItem.ToString))
        xmlneu = String.Concat(xmlneuverzeichnis, "\", dateiname)
        ' xmlzumeinlesen = xmlneu.Replace("\", "/") ' \ ersetzen durch /, um in Sql einzulesen

        xmlalt = String.Concat(xmlaltverzeichnis, "\", dateiname)

        IO.File.WriteAllText(xmlneu, xmltextneu)
        xmlzumeinlesen = xmlneu.Replace("\", "/") ' \ ersetzen durch /, um in Sql einzulesen

        ' Prüfen, ob neue id eingetragen wurde, sonst Abbruch
        If xmlneu.Contains("<id_bew>1</id_bew>") Then
            MessageBox.Show("Die neue Referenznummer wurde nicht korrekt eingetragen! Die xml-Datei wird nicht eingelesen." & vbNewLine & vbNewLine & "Bitte den Pleitegeier verständigen.", "Fehler bei der Konvertierung der xml-Datei", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            Dim result As DialogResult = MessageBox.Show("Alles in Ordnung. Die xml-Datei kann jetzt eingelesen werden.", "Alles in Ordnung", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                Call XmlinDb()
                Me.Close()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Die xml-Datei wurde nicht eingelesen.", "xml-Datei wurde nicht eingelesen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub XmlinDb()

        xmleinlesen_bool = True

        ' Backup der DB vor dem Einspielen der xml-Datei erstellen

        Call Backuperstellen()

        'Dim querybew As String = ("Load xml local Infile 'e:/heyduck/xml/neu/Franz_Maier.xml' into table bew rows identified by '<bew>';")
        'Dim query_bew As String = ("Lock tables bew write; Load xml local Infile '" & xmlzumeinlesen & "' into table bew rows identified by '<bew>'; Unlock tables;")

        Dim query As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bew rows identified by '<bew>';Load xml local Infile '" & xmlzumeinlesen & "' into table bew_bewerberdaten rows identified by '<bew_bewerberdaten>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_ausbildung rows identified by '<bewerber_ausbildung>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_berufserfahrung rows identified by '<bewerber_berufserfahrung>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_sprachen rows identified by '<bewerber_sprachen>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_edv rows identified by '<bewerber_edv>';Load xml local Infile '" & xmlzumeinlesen & "' into table bew_assistenz rows identified by '<bew_assistenz>';Load xml local Infile '" & xmlzumeinlesen & "' into table bew_assistenz rows identified by '<bew_assistenz>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_buero rows identified by '<bewerber_buero>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_rae rows identified by '<bewerber_rae>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_fibu rows identified by '<bewerber_fibu>';Load xml local Infile '" & xmlzumeinlesen & "' into table bew_bibuha rows identified by '<bew_bibuha>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_controlling rows identified by '<bewerber_controlling>';Load xml local Infile '" & xmlzumeinlesen & "' into table bew_steuerfachangestellte rows identified by '<bew_steuerfachangestellte>';Load xml local Infile '" & xmlzumeinlesen & "' into table bew_steuerfachangestellte rows identified by '<bew_steuerfachangestellte>';Load xml local Infile '" & xmlzumeinlesen & "' into table bew_lug rows identified by '<bew_lug>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_vertrieb rows identified by '<bewerber_vertrieb>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_einkauf rows identified by '<bewerber_einkauf>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_logistik rows identified by '<bewerber_logistik>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_versand rows identified by '<bewerber_versand>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_marketing_design rows identified by '<bewerber_marketing_design>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_personal rows identified by '<bewerber_personal>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_technik rows identified by '<bewerber_technik>';Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_it rows identified by '<bewerber_it>';Load xml local Infile '" & xmlzumeinlesen & "' into table gewerblich rows identified by '<gewerblich>';Load xml local Infile '" & xmlzumeinlesen & "' into table ulas rows identified by '<ulas>';")

        ' Dim query_bew As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bew rows identified by '<bew>';")
        'Dim query_bewerberdaten As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bew_bewerberdaten rows identified by '<bew_bewerberdaten>';")
        'Dim query_ausbildung As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_ausbildung rows identified by '<bewerber_ausbildung>';")
        'Dim query_berufserfahrung As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_berufserfahrung rows identified by '<bewerber_berufserfahrung>';")
        'Dim query_sprachen As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_sprachen rows identified by '<bewerber_sprachen>';")
        'Dim query_edv As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_edv rows identified by '<bewerber_edv>';")
        'Dim query_assistenz As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bew_assistenz rows identified by '<bew_assistenz>';")
        'Dim query_buero As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_buero rows identified by '<bewerber_buero>';")
        'Dim query_rae As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_rae rows identified by '<bewerber_rae>';")
        'Dim query_fibu As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_fibu rows identified by '<bewerber_fibu>';")
        'Dim query_bibuha As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bew_bibuha rows identified by '<bew_bibuha>';")
        'Dim query_controlling As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_controlling rows identified by '<bewerber_controlling>';")
        'Dim query_steuerfachangestellte As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bew_steuerfachangestellte rows identified by '<bew_steuerfachangestellte>';")
        'Dim query_lug As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bew_lug rows identified by '<bew_lug>';")
        'Dim query_vertrieb As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_vertrieb rows identified by '<bewerber_vertrieb>';")
        'Dim query_einkauf As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_einkauf rows identified by '<bewerber_einkauf>';")
        'Dim query_logistik As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_logistik rows identified by '<bewerber_logistik>';")
        'Dim query_versand As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_versand rows identified by '<bewerber_versand>';")
        'Dim query_mud As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_marketing_design rows identified by '<bewerber_marketing_design>';")
        'Dim query_personal As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_personal rows identified by '<bewerber_personal>';")
        'Dim query_technik As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_technik rows identified by '<bewerber_technik>';")
        'Dim query_it As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table bewerber_it rows identified by '<bewerber_it>';")
        'Dim query_gewerblich As String = ("Load xml local Infile '" & xmlzumeinlesen & "' into table gewerblich rows identified by '<gewerblich>';")

        Dim cnn As New MySqlConnection(connectionString)

        Using connection As New MySqlConnection(connectionString)
            Try
                cnn.Open()
                Dim command As New MySqlCommand(query, cnn)
                command.ExecuteNonQuery()
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using

        Call gespeichert()
        frmMain.DBLoad()

        Me.BewBindingSource.Filter = "id_bew = '" & autoincrementwert & "'"
        Dim bew = DirectCast(DirectCast(Me.BewBindingSource.Current, DataRowView).Row, bewRow)
        bew.erstkontakt = Date.Now
        'bew.rundschreibenjanein = 0
        bew.topbewerberchecked = False
        Me.BewBindingSource.EndEdit()
        frmMain.BewTableAdapter.Update(frmMain.BewerberDataSet.bew)
        Me.BewBindingSource.RemoveFilter()
        frmMain.DBLoad()

        ' xml-Einträge in DB prüfen
        Call Eintraegepruefen()

        ' Wenn die Einträge korrekt sind, wird die xml-Originaldatei verschoben und archiviert, wenn die Einträge nicht korrekt waren, bleibt die xml-Datei, wo sie war für den nächsten Einleseversuch

        If eintraegekorrekt_bool Then
            ' unbearbeitete xml-Datei verschieben
            Dim dateiname As String = CStr(lstXml.SelectedItem.ToString)
            System.IO.File.Copy(dateiname, xmlalt, True)
            System.IO.File.Delete(dateiname)
        End If
    End Sub

    Private Sub Backuperstellen()
        Dim sqlstring As String = String.Empty
        '  Dim sqlfile As String = String.Empty
        Dim workdir As String = String.Empty
        If Not connectionString.Contains("127.0.0.1") Then
            workdir = "x:\mysqldump\"
            sqlfile = String.Concat(workdir, "dump.sql")
            sqlstring = ("mysqldump.exe -u Adler -pzgA7K$z! -h server2012 bewerberneu > x:\mysqldump\dump.sql")
        Else
            workdir = "e:\heyduck\mysqldump\"
            sqlfile = String.Concat(workdir, "dump.sql")
            sqlstring = ("mysqldump.exe -u root -pheyduck1! bewerberneu > e:\heyduck\mysqldump\dump.sql")
        End If

        Dim myProcess As New Process()
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.WorkingDirectory = CStr(workdir)
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.Start()
        Dim myStreamerWriter As StreamWriter = myProcess.StandardInput
        Dim myStreamerReader As StreamReader = myProcess.StandardOutput
        'myStreamerWriter.WriteLine("mysqldump.exe -u root -pheyduck1! bewerberneu > e:\heyduck\mysqldump\dump.sql")
        ' myStreamerWriter.WriteLine("mysqldump.exe -u root -pheyduck1! bewerberneu > '" & sqlfile & "'")
        myStreamerWriter.WriteLine(sqlstring)
        myStreamerWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
        MessageBox.Show("Backup wurde erstellt", "Backup wurde erstellt", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub Backupeinspielen()
        '  Dim sqlfile As String = String.Empty
        Dim sqlstring As String = String.Empty
        Dim workdir As String = String.Empty
        If Not connectionString.Contains("127.0.0.1") Then
            workdir = "x:\mysqldump\"
            sqlfile = String.Concat(workdir, "dump.sql")
            sqlstring = ("mysql.exe -u Adler -pzgA7K$z! -h server2012 bewerberneu < x:\mysqldump\dump.sql")
        Else
            workdir = "e:\heyduck\mysqldump\"
            sqlfile = String.Concat(workdir, "dump.sql")
            sqlstring = ("mysql.exe -u root -pheyduck1! bewerberneu < e:\heyduck\mysqldump\dump.sql")
        End If

        Dim myProcess As New Process()
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.WorkingDirectory = workdir
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.Start()
        Dim myStreamerWriter As StreamWriter = myProcess.StandardInput
        Dim myStreamerReader As StreamReader = myProcess.StandardOutput
        myStreamerWriter.WriteLine(sqlstring)
        ' myStreamerWriter.WriteLine("mysql.exe -u root -pheyduck1! bewerberneu < e:\heyduck\mysqldump\dump.sql")
        myStreamerWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()

        Dim result As DialogResult = MessageBox.Show("Backup jetzt löschen?", "Backup löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
        If result = DialogResult.Yes Then
            IO.File.Delete(sqlfile)
            MessageBox.Show("Backup wurde gelöscht", "Backup gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmMain.DBLoad()
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Keine Änderungen", "Keine Änderungen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    ' eingespielte xml-Einträge prüfen
    Private Sub Eintraegepruefen()
        If Not frmMain.BewerberDataSet.bew_assistenz.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bew_bewerberdaten.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bew_bibuha.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bew_lug.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bew_steuerfachangestellte.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_ausbildung.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_berufserfahrung.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_buero.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_controlling.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_edv.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_einkauf.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_fibu.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_it.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_logistik.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_marketing_design.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_personal.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_rae.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_sprachen.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_technik.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_versand.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.bewerber_vertrieb.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
        ElseIf Not frmMain.BewerberDataSet.gewerblich.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        ElseIf Not frmMain.BewerberDataSet.ulas.Any(Function(x) x.id_bew = CInt(autoincrementwert)) Then
            Call Message()
            Exit Sub
        End If
    End Sub

    Private Sub Message()
        MessageBox.Show("Die xml-Datei wurde nicht korrekt in die Datenbank eingespielt." & vbNewLine & vbNewLine & "Das Backup wird zur Fehlerbereinigung eingespielt." & vbNewLine & vbNewLine & "Bitte lesen Sie die xml-Datei erneut ein.", "Xml-Datei wurde nicht korrekt eingespielt", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        eintraegekorrekt_bool = False
        Call Backupeinspielen()
    End Sub
End Class