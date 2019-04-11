Public Class frmListboxen

    Private _frmMain As frmMain
    Private _frmInterviewer As frmInterviewer
    Private _frmKurzfragebogen As frmKurzfragebogen
    Private _frmTelefoninterview As frmTelefoninterview

    Sub New(frmMain As frmMain)
        ' TODO: Complete member initialization 
        _frmMain = frmMain
        InitializeComponent()
    End Sub

    Sub New(frmInterviewer As frmInterviewer)
        ' TODO: Complete member initialization 
        _frmInterviewer = frmInterviewer
        InitializeComponent()
    End Sub

    Sub New(frmKurzfragebogen As frmKurzfragebogen)
        ' TODO: Complete member initialization 
        _frmKurzfragebogen = frmKurzfragebogen
        InitializeComponent()
    End Sub

    Sub New(frmTelefoninterview As frmTelefoninterview)
        ' TODO: Complete member initialization 
        _frmTelefoninterview = frmTelefoninterview
        InitializeComponent()
    End Sub

    ' Bool-Variablen für frmMain
    Public Shared Property zavm_bool As Boolean = False
    Public Shared Property arbeitsort_bool As Boolean = False
    Public Shared Property fuehrerschein_bool As Boolean = False
    Public Shared Property oepnv_bool As Boolean = False
    Public Shared Property pdl_welche_bool As Boolean = False
    'Public Shared Property suchmaschine_bool As Boolean = False
    'Public Shared Property jobboerse_bool As Boolean = False
    'Public Shared Property zeitung_bool As Boolean = False
    'Public Shared Property anderemedien_bool As Boolean = False
    Public Shared Property studiumsabschluss_bool As Boolean = False
    Public Shared Property sapmodule_bool As Boolean = False
    Public Shared Property fibuerfahrung_bool As Boolean = False
    Public Shared Property fibusoftwareerfahrung_bool As Boolean = False
    Public Shared Property controllingerfahrung_bool As Boolean = False
    Public Shared Property controllingsystemeerfahrung_bool As Boolean = False
    Public Shared Property steuerfachangestellte_erfahrung_bool As Boolean = False
    Public Shared Property steuerfachangestellte_software_bool As Boolean = False
    Public Shared Property bibuha_erfahrung_bool As Boolean = False
    Public Shared Property bibuha_software_bool As Boolean = False
    Public Shared Property lug_abrechnung_bool As Boolean = False
    Public Shared Property lugabrechnung_software_bool As Boolean = False
    Public Shared Property lug_buchhaltung_bool As Boolean = False
    Public Shared Property lugbuchhaltung_software_bool As Boolean = False
    Public Shared Property fibu_kontenrahmen_bool As Boolean = False
    Public Shared Property vztz_bool As Boolean = False

    ' String-Variablen für frmMain

    Public Shared Property zavm As String = String.Empty
    Public Shared Property arbeitsort As String = String.Empty
    Public Shared Property fueherschein As String = String.Empty
    Public Shared Property oepnv As String = String.Empty
    Public Shared Property pdl_welche As String = String.Empty
    Public Shared Property suchmaschine As String = String.Empty
    Public Shared Property zeitung As String = String.Empty
    Public Shared Property jobboerse As String = String.Empty
    Public Shared Property anderemedien As String = String.Empty
    Public Shared Property studiumabschluss As String = String.Empty
    Public Shared Property sapmodule As String = String.Empty
    Public Shared Property fibuerfahrung As String = String.Empty
    Public Shared Property fibusoftwareerfahrung As String = String.Empty
    Public Shared Property controllingerfahrung As String = String.Empty
    Public Shared Property controllingsystemeerfahrung As String = String.Empty
    Public Shared Property steuerfachangestellte_erfahrung As String = String.Empty
    Public Shared Property steuerfachangestellte_software As String = String.Empty
    Public Shared Property bibuha_erfahrung As String = String.Empty
    Public Shared Property bibuha_software As String = String.Empty
    Public Shared Property lug_erfahrung As String = String.Empty
    Public Shared Property lug_abrechnung_software As String = String.Empty
    Public Shared Property lug_buchhaltung As String = String.Empty
    Public Shared Property lug_buchhaltung_software As String = String.Empty
    Public Shared Property fibu_kontenrahmen As String = String.Empty
    Public Shared Property vztz As String = String.Empty


    Private Sub frmListboxen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Select True
            Case zavm_bool
                Me.ListBox1.Items.AddRange(New Object() {"Vermittlung", "Zeitarbeit", "Zeitarbeit mit Übernahmeoption", "egal"})
            Case arbeitsort_bool
                Me.ListBox1.Items.AddRange(New Object() {"Bundesweit", "RSK", "BN", "BN LR", "BN RR", "K", "K LR", "K RR", "Berg L", "LEV", "D", "Ruhr", "RLP", "GM", "Nümbrecht", "AK", "Norddeutschland"})
            Case fuehrerschein_bool
                Me.ListBox1.Items.AddRange(New Object() {"Pkw", "Lkw", "Motorrad", "kein Führerschein"})
            Case oepnv_bool
                Me.ListBox1.Items.AddRange(New Object() {"Pkw", "ÖPNV (Bus, Bahn, etc.)", "Fahrrad", "andere Verkehrsmittel"})
                '  Case pdl_welche_bool
                '     Me.ListBox1.Items.AddRange(New Object() {"Dienstleistungsunternehmen", "Industrie", "Handwerk ", "Freie Berufe", "Verbände", "soziale Organisationen", "öffentlicher Dienst", "kirchliche Organisationen"})
                ' Case suchmaschine_bool
                '    Me.ListBox1.Items.AddRange(New Object() {"Google", "Bing", "Yahoo", "Web.de", "andere"})
                'Case jobboerse_bool
                '   Me.ListBox1.Items.AddRange(New Object() {"Agentur für Arbeit", "Monster", "Stepstone", "Indeed", "Kalaydo", "stellenmarkt", "Rekruter", "Gigajob", "meinestadt", "Jobmonitor", "Jobomat", "backinjob", "Placement24", "andere"})
                'Case zeitung_bool
                '   Me.ListBox1.Items.AddRange(New Object() {"Bonner Generalanzeiger", "Kölner Stadtanzeiger", "Rhein-Sieg-Anzeiger", "Regionale Anzeigenblätter", "andere"})
                'Case anderemedien_bool
             '   Me.ListBox1.Items.AddRange(New Object() {"Facebook", "Twitter", "Bewertungsportal", "andere"})
            Case studiumsabschluss_bool
                Me.ListBox1.Items.AddRange(New Object() {"Bachelor", "Master", "Diplom", "Staatsexamen"})
            Case sapmodule_bool
                Me.ListBox1.Items.AddRange(New Object() {"FI ", "CO ", "TR ", "EC ", "IM ", "PSM ", "RE", "PS", "SEM", "MM", "PP", "SD", "PM", "LE", "EHS", "QM", "CS", "LO", "PLM", "WM", "HCM", "PY", "PA", "PT", "PE", "PD", "CP", "WF", "IS"})
            Case fibuerfahrung_bool
                Me.ListBox1.Items.AddRange(New Object() {"Steuerberater", "Wirtschaftsprüfer", "vereidigter Buchprüfer", "Buchhaltungsabteilung", "selbständiger Buchhalter", "Wohnungsbaugesellschaft"})
            Case fibusoftwareerfahrung_bool
                Me.ListBox1.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "AS 400", "andere"})
            Case controllingerfahrung_bool
                Me.ListBox1.Items.AddRange(New Object() {"Finanzcontrolling", "Vertriebscontrolling", "Personalcontrolling", "Projektcontrolling", "Einkaufscontrolling", "Produktionscontrolling"})
            Case controllingsystemeerfahrung_bool
                Me.ListBox1.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "AS 400", "Oracle", "andere"})
            Case steuerfachangestellte_erfahrung_bool
                Me.ListBox1.Items.AddRange(New Object() {"Steuerberater", "Wirtschaftsprüfer", "vereidigter Buchprüfer", "Buchhaltungsabteilung", "selbständiger Buchhalter"})
            Case steuerfachangestellte_software_bool
                Me.ListBox1.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Addison Wesley", "Lexware", "KHK Sage", "AS 400", "Oracle", "andere"})
            Case bibuha_erfahrung_bool
                Me.ListBox1.Items.AddRange(New Object() {"Einzelunternehmen", "OHG, KG", "GmbH", "GmbH & Co. KG", "AG, KGaA", "Stiftung", "Öffentlicher Dienst"})
            Case bibuha_software_bool
                Me.ListBox1.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "AS 400", "Oracle", "andere"})
            Case lug_abrechnung_bool
                Me.ListBox1.Items.AddRange(New Object() {"Dienstleistung", "Handwerk", "Industrie", "Öffentlicher Dienst", "Freiberufler"})
            Case lugabrechnung_software_bool
                Me.ListBox1.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "Oracle", "andere"})
            Case lug_buchhaltung_bool
                Me.ListBox1.Items.AddRange(New Object() {"Dienstleistung", "Handwerk", "Industrie", "Öffentlicher Dienst", "Freiberufler"})
            Case lugbuchhaltung_software_bool
                Me.ListBox1.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "Oracle", "andere"})
            Case fibu_kontenrahmen_bool
                Me.ListBox1.Items.AddRange(New Object() {"SKR 03", "SKR 03 nach IFRS/IAS", "SKR 03 Ärzte", "SKR 03 Bau und Handwerk", "SKR 03 Hotel und Gaststätten", "SKR 03 Zahnärzte", "SKR 03 E-Bilanz Einzelunternehmen", "SKR 03 E-Bilanz Personengesellschaft", "SKR 04 ", "SKR 04 nach IFRS/IAS", "SKR 04 Ärzte", "SKR 04 Bau und Handwerk", "SKR 04 Hotel und Gaststätten", "SKR 04 Kommunale Unternehmen", "SKR 04 Zahnärzte", "SKR 04 E-Bilanz Einzelunternehmen", "SKR 04 E-Bilanz Kapitalgesellschaft", "SKR 45 E-Bilanz Kapitalgesellschaft", "SKR 45 E-Bilanz Einzelunternehmen", "SKR 45 soziale Einrichtungen nach PBV", "SKR 49 Vereine/Stiftungen/gGmbH", "SKR 51 Kfz-Branche", "SKR 93 Kfz-Betriebe"})
            Case vztz_bool
                Me.ListBox1.Items.AddRange(New Object() {"Vollzeit", "Teilzeit", "Teilzeit flexibel", "Vollzeit/Teilzeit"})
        End Select
        '  Me.ListBox1.SelectedIndex = 0

    End Sub


    Private Sub listboxendeaktivieren()
        zavm_bool = False
        arbeitsort_bool = False
        fuehrerschein_bool = False
        oepnv_bool = False
        pdl_welche_bool = False
        ' suchmaschine_bool = False
        'jobboerse_bool = False
        'zeitung_bool = False
        'anderemedien_bool = False
        studiumsabschluss_bool = False
        sapmodule_bool = False
        fibuerfahrung_bool = False
        fibusoftwareerfahrung_bool = False
        controllingerfahrung_bool = False
        controllingsystemeerfahrung_bool = False
        steuerfachangestellte_erfahrung_bool = False
        steuerfachangestellte_software_bool = False
        bibuha_erfahrung_bool = False
        bibuha_software_bool = False
        lug_abrechnung_bool = False
        lug_buchhaltung_bool = False
        lugbuchhaltung_software_bool = False
        fibu_kontenrahmen_bool = False
        vztz_bool = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case True
            Case zavm_bool
                zavm = String.Empty
                For h As Integer = 0 To Me.ListBox1.SelectedItems.Count - 1
                    zavm &= Me.ListBox1.SelectedItems.Item(h).ToString & vbCrLf
                Next
            Case arbeitsort_bool
                arbeitsort = String.Empty
                For j As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    arbeitsort &= ListBox1.SelectedItems.Item(j).ToString & vbCrLf
                Next
            Case fuehrerschein_bool
                fueherschein = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    fueherschein &= ListBox1.SelectedItems.Item(k).ToString & ", "
                Next
            Case oepnv_bool
                oepnv = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    oepnv &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case pdl_welche_bool
                pdl_welche = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    pdl_welche &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
                '  Case suchmaschine_bool
                '     suchmaschine = String.Empty
                '    For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                '   suchmaschine &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                '  Next
                'Case jobboerse_bool
                '   jobboerse = String.Empty
                '  For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                ' jobboerse &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                'Next
                'Case zeitung_bool
                '   zeitung = String.Empty
                '  For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                ' zeitung &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                'Next
                'Case anderemedien_bool
                '   anderemedien = String.Empty
                '  For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                ' anderemedien &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                'Next
            Case studiumsabschluss_bool
                studiumabschluss = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    studiumabschluss &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case sapmodule_bool
                sapmodule = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    sapmodule &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case fibuerfahrung_bool
                fibuerfahrung = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    fibuerfahrung &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case fibusoftwareerfahrung_bool
                fibusoftwareerfahrung = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    fibusoftwareerfahrung &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case controllingerfahrung_bool
                controllingerfahrung = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    controllingerfahrung &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case controllingsystemeerfahrung_bool
                controllingsystemeerfahrung = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    controllingsystemeerfahrung &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case steuerfachangestellte_erfahrung_bool
                steuerfachangestellte_erfahrung = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    steuerfachangestellte_erfahrung &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case steuerfachangestellte_software_bool
                steuerfachangestellte_software = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    steuerfachangestellte_software &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case bibuha_erfahrung_bool
                bibuha_erfahrung = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    bibuha_erfahrung &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case bibuha_software_bool
                bibuha_software = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    bibuha_software &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case lug_abrechnung_bool
                lug_erfahrung = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    lug_erfahrung &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case lugabrechnung_software_bool
                lug_abrechnung_software = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    lug_abrechnung_software &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case lug_buchhaltung_bool
                lug_buchhaltung = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    lug_buchhaltung &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case lugbuchhaltung_software_bool
                lug_buchhaltung_software = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    lug_buchhaltung_software &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case fibu_kontenrahmen_bool
                fibu_kontenrahmen = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    fibu_kontenrahmen &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
            Case vztz_bool
                vztz = String.Empty
                For k As Integer = 0 To ListBox1.SelectedItems.Count - 1
                    vztz &= Me.ListBox1.SelectedItems.Item(k).ToString & vbCrLf
                Next
        End Select
    End Sub

    Private Sub btnAuswahluebernehmen_Click(sender As Object, e As EventArgs) Handles btnAuswahluebernehmen.Click
        Call listboxendeaktivieren()
        Me.Close()
    End Sub
End Class