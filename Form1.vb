Public Class frmMain
    Public clsDB As New clsDatenbank

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtTageAnzahl.Text = My.Settings.Verkäufe_Tage_zurück(My.Settings.mandant_position)
        txtLagerbestand_Menge.Text = My.Settings.Lagerhinweis_Menge(My.Settings.mandant_position)
        Me.Text = "JTL Lagerbestand Report v." & strVersionsNummer
        Try
            lvwArtikel.SmallImageList = img
            lvwArtikel.LargeImageList = img

        Catch ex As Exception
            ' Bilder könnnen nicht angezeigt werden 
        End Try

        gbl_KeyCode = getWMI_KeyCode()
        Dim strServerInfo() As String = getHTTPResponseMessage("https://api.bludau-media.de/SafeSandy/IsRegistered.php?key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&versionsnummer=" & strVersionsNummer, mgetUpdaterMessage.getIstBuyed, True)
        If Not strServerInfo(0) = "GEKAUFT" Then
            Dim frmRegisterJTLBridge As New frmDemoVersion
            frmRegisterJTLBridge.ShowDialog()
        End If

        '# Keine Datenbankverbindungsmöglichkeiten vorhanden erster Start 
        If My.Settings.mandant_position = -1 Then
            Dim frmDBSetting As New frmDatenbankEinstellungen
            frmDBSetting.ShowDialog()
        End If

        Dim strServerInfo1() As String = getHTTPResponseMessage("https://api.bludau-media.de/SafeSandy/Update.php?key=" & System.Uri.EscapeDataString(gbl_KeyCode) & "&programID=12&versionsnummer=" & strVersionsNummer & "&KeinUpdate=1", mgetUpdaterMessage.getProgramUpdateCheck, True)

        If Not strServerInfo1(0) = "VERSION_AKTUELL" Then
            Dim frmUpdater As New frmUpdater
            frmUpdater.ShowDialog()
        End If

        ''# Prüfung ob my.settings.mandant_position außerhalb des Index
        Try
            If My.Settings.db_server(My.Settings.mandant_position) = "" Then

            End If
        Catch ex As Exception
            '# Außerhalb des Index default Datenbank laden, falls vorhanden 
            MainMenuStrip.Text = "Fehler: aktuelle Position innerhalb der Einstellungen '" & My.Settings.mandant_position & "' - lade Standard Werte"
            Dim frmDBSetting As New frmDatenbankEinstellungen
            frmDBSetting.ShowDialog()
            'My.Settings.mandant_position = getMySettingsPositionByDatabase("eazybusiness")
        End Try


        '##################################################
        '# >> Standarddatenbank easzybusiness Connection 
        '##################################################
        If clsDB.strConnectionString_eazybusiness = "" Then
            Dim iDefaultDB As Integer = getMySettingsPositionByDatabase("eazybusiness")

            '# Es konnte keine Standarddatenbank gefunden werden 
            If iDefaultDB = -1 Then
                iDefaultDB = 0
            End If

            Dim strCon2 As String = "server=" & My.Settings.db_server.Item(iDefaultDB) & ";uid=" & My.Settings.db_username.Item(iDefaultDB) & ";pwd=" & My.Settings.db_passwort.Item(iDefaultDB) & ";database=" & My.Settings.db_datenbankname.Item(iDefaultDB) & ";"
            If clsDB.getDBConnect(strCon2, True) = False Then
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
            End If
        End If

        '######################################################
        '# >> Mandantendatenbank auswählen 
        '######################################################
        If My.Settings.db_server(My.Settings.mandant_position) = "" Or My.Settings.db_datenbankname(My.Settings.mandant_position) = "" Or My.Settings.db_passwort(My.Settings.mandant_position) = "" Or My.Settings.db_username(My.Settings.mandant_position) = "" Then
            Dim frmDBSetting As New frmDatenbankEinstellungen
            frmDBSetting.ShowDialog()
        End If
        Dim strCon As String = "server=" & My.Settings.db_server.Item(My.Settings.mandant_position) & ";uid=" & My.Settings.db_username.Item(My.Settings.mandant_position) & ";pwd=" & My.Settings.db_passwort.Item(My.Settings.mandant_position) & ";database=" & My.Settings.db_datenbankname.Item(My.Settings.mandant_position) & ";"
        If clsDB.getDBConnect(strCon) = False Then
            Dim frmDBSetting As New frmDatenbankEinstellungen
            frmDBSetting.ShowDialog()
        End If

        '# Datenbank Verbindung initialisieren
        'Call setDBSettings(True)

        '#################################################################
        '# >> Standardmandanten laden - eazybusiness Standarddatenbank
        '######################################################
        Call clsDB.setMandantbyCombobox(cmbMandant, False)


        If My.Settings.shop_url(My.Settings.mandant_position) = "http://www.shop.de/bilder/produkte/klein/" Then
            Dim frmShop As New frmShopURL
            frmShop.Show()
        End If

        '# Kategorien abrufen in Listview         
        lvwKategorie.Items.Clear() ' Listview löschen
        Dim lvwitem As New ListViewItem
        lvwitem.Text = "-1"
        lvwitem.SubItems.Add("Alle Kategorien")
        lvwKategorie.Items.Add(lvwitem)

        Call clsDB.getKategorie(0, lvwKategorie, 0)

        lvwKategorie.Items(1).Selected = True
    End Sub

    Private Sub txtTageAnzahl_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTageAnzahl.TextChanged
        If IsNumeric(txtTageAnzahl.Text) = True Then
            My.Settings.Verkäufe_Tage_zurück(My.Settings.mandant_position) = txtTageAnzahl.Text            
            My.Settings.Save()
        End If
    End Sub
    '##################################################################################
    '# >> geteazybusinessSettings()
    '# Findet die Position an der Sich die Hauptdatenbank befindet 
    '##################################################################################
    Public Function getMySettingsPositionByDatabase(strDatabaseName As String) As Integer
        Try
            Dim i As Byte
            Dim iGefunden As Integer = -1
            Dim bGefunden As Boolean = False

            '# Keine Einstellung gefunden 
            If My.Settings.db_datenbankname.Count = 0 Then
                Return -1
                Exit Function
            End If

            For i = 0 To My.Settings.db_datenbankname.Count - 1
                If My.Settings.db_datenbankname(i) = strDatabaseName Then
                    bGefunden = True
                    iGefunden = i
                    Exit For
                End If
            Next
            '# Nicht gefunden Position 0 
            If bGefunden = False Then
                iGefunden = -1
            End If

            My.Settings.Save()
            Return iGefunden
        Catch ex As Exception
            MessageBox.Show("Fehler: " & ex.Message, "geteMySettingsbyDatabase()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    '#################################################
    '# >> setSettingsDelete
    '# My.Settings.xxx String Collection alle löschen
    '#################################################
    Public Function setSettingsDelete() As Boolean
        Dim i As Integer
        For i = 0 To My.Settings.db_server.Count - 1
            Try
                My.Settings.db_server.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.db_datenbankname.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.db_username.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.db_passwort.RemoveAt(0)
            Catch ex As Exception

            End Try
             
            Try
                My.Settings.email_absende_name.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_pop_port.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_pop3_before_smtp.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_pwd.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_smtp.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_smtp_port.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_username.RemoveAt(0)
            Catch ex As Exception

            End Try

        Next
        Return True
    End Function
    '#################################################
    '# >> setSettingsInit
    '# My.Settings.xxx String Collection initalisieren
    '#################################################
    Public Function setSettingsInit(ByVal iSize As Integer) As Integer
        Try
            Dim txtShopURL_test As String = ""
            Dim iCount_insert As Integer = 0

            If My.Settings.db_server.Count - 1 < iSize Then
                For iCount As Integer = My.Settings.db_server.Count To iSize
                    Try

                    Catch ex As Exception
                        My.Settings.db_server.Insert(iCount, "")
                        My.Settings.db_datenbankname.Insert(iCount, "")
                        My.Settings.db_username.Insert(iCount, "")
                        My.Settings.db_passwort.Insert(iCount, "")
                        'My.Settings.email_empfang.Insert(iCount, "")
                        My.Settings.email_absende_name.Insert(iCount, "")
                        My.Settings.email_pop_port.Insert(iCount, "")
                        My.Settings.email_pop3_before_smtp.Insert(iCount, "false")
                        My.Settings.email_pwd.Insert(iCount, "")
                        My.Settings.email_smtp.Insert(iCount, "")
                        My.Settings.email_smtp_port.Insert(iCount, "")
                        My.Settings.email_username.Insert(iCount, "")
                        My.Settings.email_enable_ssl.Insert(iCount, "true")
                        My.Settings.email_username_user.Insert(iCount, "")
                        iCount_insert += 1
                    End Try
                Next

            End If
            Return iCount_insert
        Catch ex As Exception
            MessageBox.Show("Fehler bei setInitSettings: " & ex.Message, "setInitSettings()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Private Sub txtLagerbestand_Menge_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLagerbestand_Menge.TextChanged

        If IsNumeric(txtLagerbestand_Menge.Text) = True Then
            My.Settings.Lagerhinweis_Menge(My.Settings.mandant_position) = txtLagerbestand_Menge.Text
            My.Settings.Save()
        End If


    End Sub

    Private Sub DatenbankeinstellungenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DatenbankeinstellungenToolStripMenuItem.Click
        Dim frmDB As New frmDatenbankEinstellungen
        frmDB.Show()
    End Sub

    Private Sub EmailserverEinstellungenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmailserverEinstellungenToolStripMenuItem.Click
        Dim frmEmail As New frmMailServer
        frmEmail.Show()
    End Sub

    Private Sub btnSyncLager_Click(sender As System.Object, e As System.EventArgs) Handles btnSyncLager.Click
        If txtLagerbestand_Menge.Text = "" Or IsNumeric(txtLagerbestand_Menge.Text) = False Then
            MessageBox.Show("Bitte eine Zahl für Lagerbestand Menge eintragen", "Fehler: Kein Wert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If txtTageAnzahl.Text = "" Or IsNumeric(txtTageAnzahl.Text) = False Then
            MessageBox.Show("Bitte eine Zahl für Verkauf Anzahl Tage zurück eintragen", "Fehler: Kein Wert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        ProgressBar1.Visible = True

        lvwArtikel.Items.Clear()
        If chkEmailReport.Checked = True Then
            Dim iCount As Integer = 0

            '# Alle Kategorien durchgehen
            For iCount = 1 To lvwKategorie.Items.Count - 1
                lvwKategorie.Items(iCount).Selected = True
                lvwKategorie.EnsureVisible(iCount)
                Application.DoEvents()

                Dim lvwItemCat As New ListViewItem
                lvwItemCat.SubItems.Add(lvwKategorie.SelectedItems(0).SubItems(1).Text)
                lvwArtikel.Items.Add(lvwItemCat)

                'lvwArtikel.EnsureVisible(iCount)
                lvwArtikel.BeginUpdate()
                Call clsDB.JTLGetLagerbestand(lvwKategorie.SelectedItems(0).Text, img)
                lvwArtikel.EndUpdate()
                Application.DoEvents()
            Next

            '# Report aufbereiten
            Dim icount2 As Integer = 0
            Dim strHTML As String = getEmailHTML(lvwArtikel)

            Dim clsEmail As New clsEmail
            clsEmail.setSendMail(My.Settings.email_username(My.Settings.mandant_position), strHTML, "JTL Lagerbestand Report")
        Else
            Call clsDB.JTLGetLagerbestand(lvwKategorie.SelectedItems(0).Text, img)
        End If
        ProgressBar1.Visible = False
        MessageBox.Show("Es wurden alle Daten verarbeitet", "Verarbeitung abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    '################################################################
    '# >> getEmailHTML
    '################################################################
    Private Function getEmailHTML(lvwProdukte As ListView) As String
        Try
            Dim strHTML As String = ""
            Dim strBildPfad As String = ""
            strHTML = "Anzahl der Produkte mit niedrigem Lagerbestand: " & lvwArtikel.Items.Count - 1 & "<br/><br/><table><tr><td>Bild</td><td>Artikelnummer</td><td>Typ</td><td>Wert</td><td>Lagerbestand Var</td><td>Name</td><td>Lagerbestand</td><td>Verkäufe</td></tr>"
            For icount2 = 0 To lvwArtikel.Items.Count - 1

                If lvwArtikel.Items(icount2).SubItems.Count = 2 Then
                    strHTML &= "<tr><td colspan=8><h1>" & lvwArtikel.Items(icount2).SubItems(1).Text & "</h1></td></tr>"
                Else
                    Try
                        strBildPfad = lvwArtikel.Items(icount2).SubItems(5).Text
                    Catch ex As Exception

                    End Try

                    strHTML &= "<tr>"
                    strHTML &= "<td><a href=""" & strBildPfad.Replace("/klein/", "/gross/") & """><img width=""50"" height=""50"" src=""" & strBildPfad & """></a></td><td>" & lvwArtikel.Items(icount2).SubItems(1).Text & "</td><td>" & lvwArtikel.Items(icount2).SubItems(6).Text & "</td><td>" & lvwArtikel.Items(icount2).SubItems(7).Text & "</td><td>" & lvwArtikel.Items(icount2).SubItems(8).Text & "</td><td>" & lvwArtikel.Items(icount2).SubItems(2).Text & "</td><td>" & lvwArtikel.Items(icount2).SubItems(3).Text & "</td><td>" & lvwArtikel.Items(icount2).SubItems(4).Text & "</td>"
                    strHTML &= "</tr>"
                End If
            Next
            strHTML &= "</table>"

            Return strHTML
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub lvwKategorie_Click(sender As Object, e As System.EventArgs) Handles lvwKategorie.Click
        Application.DoEvents()

        lvwArtikel.Items.Clear()
        ProgressBar1.Visible = True
        Dim lvwItemCat As New ListViewItem
        lvwItemCat.SubItems.Add(lvwKategorie.SelectedItems(0).SubItems(1).Text)
        lvwArtikel.Items.Add(lvwItemCat)
        lvwArtikel.BeginUpdate()
        Call clsDB.JTLGetLagerbestand(lvwKategorie.SelectedItems(0).Text, img)
        lvwArtikel.EndUpdate()

        '# Report aufbereiten
        If lvwArtikel.Items.Count > 1 Then

            If MessageBox.Show("Möchten Sie eine Email für diese Kategorie '" & lvwKategorie.SelectedItems(0).SubItems(1).Text.Trim & "' verschicken?", "Email verschicken?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim icount2 As Integer = 0
                Dim strHTML As String = getEmailHTML(lvwArtikel)

                Dim clsEmail As New clsEmail
                clsEmail.setSendMail(My.Settings.email_username(My.Settings.mandant_position), strHTML, "JTL Lagerbestand Report")

            End If
        End If
        ProgressBar1.Visible = False
    End Sub
 
 
    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEmailReport.CheckedChanged
        If My.Settings.email_username(My.Settings.mandant_position).ToString.Length = 0 Then
            Dim frmEmailSetup As New frmMailServer
            frmEmailSetup.Show()
        End If
    End Sub

    Private Sub ShopURLFestlegenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShopURLFestlegenToolStripMenuItem.Click
        Dim frmShopURL As New frmShopURL
        frmShopURL.Show()
    End Sub

    Private Sub lvwKategorie_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvwKategorie.SelectedIndexChanged

    End Sub

    Private Sub NachUpdatesSuchenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NachUpdatesSuchenToolStripMenuItem.Click
        Dim frmUpdater As New frmUpdater
        frmUpdater.Show()
    End Sub

    Private Sub lvwArtikel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwArtikel.SelectedIndexChanged

    End Sub
End Class
