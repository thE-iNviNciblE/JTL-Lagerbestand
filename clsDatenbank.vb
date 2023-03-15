Imports System.Data
Imports System.Data.SqlClient

Public Class clsDatenbank
    Public strConnectionString As String
    Public strConnectionString_eazybusiness As String = ""

    '##########################################################
    '# >> Existiert der Mandant welcher eingelesen wird
    '##########################################################
    Public Function chkMandantExists(strMandant_db As String) As Boolean
        Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
        Try
            sqlConn.Open()
            Dim sqlComm As New SqlCommand("USE " & strMandant_db, sqlConn)
            sqlComm.ExecuteNonQuery()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    '##########################################################
    '# >> chkMandantPosition
    '# Mandanten Position innerhalb der tMandant bestimmen
    '##########################################################
    Public Function chkMandantPosition(strMandantDBName As String) As Integer
        Try
            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Dim iCount As Byte = 0
            sqlConn.Open()

            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant WHERE cDB='" & strMandantDBName & "' ORDER BY cNAME ASC", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                If chkMandantExists(r("cdb").ToString) = True Then
                    If strMandantDBName = r("cDB").ToString Then
                        My.Settings.mandant_position = r("kMandant").ToString
                        My.Settings.Save()
                        Exit While
                    End If
                End If
                iCount += 1
            End While

            Return My.Settings.mandant_position
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler bei chkMandantPosition abrufen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    '##########################################################
    '# >> Verbindung aufbauen + Connection String 
    '##########################################################
    Public Function getDBConnect(ByVal strConnection As String, Optional bEazybusiness As Boolean = False) As Boolean
        Dim sqlConn As New SqlConnection(strConnection)

        Try

            If strConnection.IndexOf("eazybusiness") > 0 Then
                bEazybusiness = True
                strConnectionString = strConnection
            End If


            sqlConn.Open()
            'If bEazybusiness = False And strConnection.IndexOf("eazybusiness") < 0 Then
            If bEazybusiness = False Then
                strConnectionString = strConnection
            Else
                strConnectionString_eazybusiness = strConnection
                'strConnectionString = strConnection
            End If

            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler bei Verbindung getDBConnect()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '##########################################################
    '# >> setMandantbyCombobox
    '# Mandanten in Combobox einlesen
    '##########################################################
    Public Function setMandantbyCombobox(ByVal cmbMandant As ComboBox, ByVal bAllDBs As Boolean) As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            sqlConn.Open()

            '# Combobox löschen 
            cmbMandant.Items.Clear()
            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant ORDER BY cNAME ASC", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                '# Prüfen ob Datenbank überhaupt angelegt ist 
                If chkMandantExists(r("cDB").ToString) = True Then
                    Dim lvwItem As New ListViewItem

                    '# Nur Verfügbare Datenbanken eintragen, wenn Setting gefunden wurde und bAllDbs nicht True ist 
                    If bAllDBs = True Then
                        cmbMandant.Items.Add(r("cName").ToString)
                    Else
                        If frmMain.getMySettingsPositionByDatabase(r("cDB").ToString) >= 0 Then
                            cmbMandant.Items.Add(r("cName").ToString)
                        End If
                    End If

                End If
            End While

            If cmbMandant.Items.Count > 0 Then
                If cmbMandant.Items.Count - 1 > 0 Then
                    For i As Byte = 0 To cmbMandant.Items.Count - 1
                        If My.Settings.mandant_letzter_name = cmbMandant.Items(i) Then
                            cmbMandant.SelectedIndex = i
                            My.Settings.mandant_letzter_name = cmbMandant.Text
                            Exit For
                        End If
                    Next
                Else
                    cmbMandant.SelectedIndex = 0
                    My.Settings.mandant_letzter_name = cmbMandant.Text
                End If

            End If
            My.Settings.Save()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim JTL Mandant abrufen getMandant()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '##########################################################
    '# >> getMandantbyName
    '# Mandant DB Name einlesen
    '# Returns DB-Name
    '##########################################################
    Public Function getMandantDatabaseByMandantName(strMandantName As String) As String
        Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
        Try

            Dim strDBName As String = ""

            sqlConn.Open()
            '# Datenbank einlesen 
            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant WHERE cName='" & strMandantName & "'", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                Dim lvwItem As New ListViewItem
                strDBName = r("cDB").ToString
            End While

            sqlConn.Close()
            Return strDBName
        Catch ex As Exception
            MessageBox.Show(ex.Message, "getMandantbyName()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '##########################################################
    '# >> getMandantbyDBName
    '# Mandant DB Name einlesen
    '# Returns Profil-Name
    '##########################################################
    Public Function getMandantbyDBName(strMandantDB As String) As String
        Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
        Try

            Dim strMandantName As String = ""

            sqlConn.Open()
            '# Datenbank einlesen 
            Dim sqlComm As New SqlCommand("SELECT * FROM  tMandant WHERE cDB='" & strMandantDB & "'", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                Dim lvwItem As New ListViewItem
                strMandantName = r("cName").ToString
            End While

            sqlConn.Close()
            Return strMandantName
        Catch ex As Exception
            MessageBox.Show(ex.Message, "getMandantbyDBName()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '##########################################################
    '# >> Kategorie abrufen
    '##########################################################
    Public Function getKategorie(ByVal iCatID As Integer, ByVal lvwKategorie As ListView, Optional ByVal iSubLevel As Integer = -1) As Boolean
        Try
            Dim strAbstand As String = ""
            Dim sqlConn As New SqlConnection(strConnectionString)
            sqlConn.Open()

            Dim sqlComm As New SqlCommand("SELECT * FROM tkategorie LEFT JOIN tKategorieSprache ON tKategorieSprache.kKategorie = tkategorie.kKategorie WHERE kOberKategorie='" & iCatID & "' AND kSprache='1'", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            '# Abstand berechnen 
            If iSubLevel > 0 Then
                For iCount As Integer = 0 To iSubLevel
                    strAbstand &= "    "
                Next
            End If

            While r.Read()

                Dim lvwItem As New ListViewItem
                lvwItem.Text = r("kKategorie").ToString
                lvwItem.SubItems.Add(strAbstand & r("cName").ToString)
                lvwItem.SubItems.Add("")
                lvwItem.SubItems.Add(strAbstand & r("cBeschreibung").ToString)
                lvwKategorie.Items.Add(lvwItem)

                '# Alle Unterkategorien anzeigen 
                If iSubLevel >= 0 Then
                    Call getKategorie(r("kKategorie").ToString, lvwKategorie, iSubLevel + 1) ' Rekursion starten 
                End If

            End While
            sqlConn.Close()


            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim Abrufen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function JTLGetLagerbestand(iCatId As Integer, img As ImageList) As Boolean
        Try

            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Dim sqlConn2 As New SqlConnection(strConnectionString_eazybusiness)
            Dim iCount As Byte = 0
            Dim strQuery As String = ""
            sqlConn.Open()

            '##################################################################
            '# >> Kombinationsartikel laden 
            '##################################################################

            If Not iCatId = -1 Then
                '########################
                '# Menge bestimmmen
                '########################
                strQuery = "SELECT count(*) as anzahl FROM tartikel JOIN tkategorieartikel ON tkategorieartikel.kArtikel = tartikel.kArtikel  JOIN tlagerbestand ON tlagerbestand.kArtikel = tartikel.kArtikel RIGHT JOIN teigenschaft ON teigenschaft.kArtikel = tartikel.kArtikel JOIN tEigenschaftwert ON teigenschaftwert.kEigenschaft = teigenschaft.kEigenschaft WHERE tkategorieartikel.kKategorie=" & iCatId
                Dim sqlCommAnzahl As New SqlCommand(strQuery, sqlConn)
                Dim rAnzahl As SqlDataReader = sqlCommAnzahl.ExecuteReader()
                frmMain.ProgressBar1.Value = 0
                While rAnzahl.Read()

                    frmMain.ProgressBar1.Maximum = Convert.ToInt16(rAnzahl("anzahl").ToString)

                End While
                rAnzahl.Close()

                'strQuery = "SELECT * FROM tartikel JOIN tkategorieartikel ON tkategorieartikel.kArtikel = tartikel.kArtikel  JOIN tlagerbestand ON tlagerbestand.kArtikel = tartikel.kArtikel WHERE tkategorieartikel.kKategorie='" & iCatId & "' AND tlagerbestand.fVerfuegbar <= " & frmMain.txtLagerbestand_Menge.Text

                '#

                'strQuery = "SELECT tartikel.*,tlagerbestand.fVerfuegbar,teigenschaft.cName as cTypName, teigenschaftwert.cName as cTypValue,teigenschaftwert.cArtNr as Artikelnummer, teigenschaftwert.fLagerbestand as nLageranzahl,tArtikelBeschreibung.*   FROM tartikel JOIN tArtikelBeschreibung ON tArtikelBeschreibung.kArtikel = tartikel.kArtikel JOIN tkategorieartikel ON tkategorieartikel.kArtikel = tartikel.kArtikel  JOIN tlagerbestand ON tlagerbestand.kArtikel = tartikel.kArtikel JOIN teigenschaft ON teigenschaft.kArtikel = tartikel.kArtikel JOIN tEigenschaftwert ON teigenschaftwert.kEigenschaft = teigenschaft.kEigenschaft WHERE tkategorieartikel.kKategorie=" & iCatId & " AND tArtikelBeschreibung.kSprache= 1"
                strQuery = "SELECT tartikel.*,tlagerbestand.fVerfuegbar, teigenschaftwert.fLagerbestand as nLageranzahl,tEigenschaftSprache.cName as cTypName, tEigenschaftWertSprache.cName as cTypValue,teigenschaftwert.cArtNr as Artikelnummer,tArtikelBeschreibung.* FROM tartikel LEFT JOIN tArtikelBeschreibung ON tArtikelBeschreibung.kArtikel = tartikel.kArtikel JOIN  tkategorieartikel ON tkategorieartikel.kArtikel = tartikel.kArtikel  JOIN tlagerbestand ON tlagerbestand.kArtikel = tartikel.kArtikel JOIN teigenschaft ON teigenschaft.kArtikel = tartikel.kArtikel JOIN tEigenschaftwert ON teigenschaftwert.kEigenschaft = teigenschaft.kEigenschaft JOIN tEigenschaftSprache ON teigenschaft.kEigenschaft = tEigenschaftSprache.kEigenschaft JOIN tEigenschaftWertSprache ON  tEigenschaftWertSprache.kEigenschaftWert = teigenschaftwert.kEigenschaftWert  WHERE tkategorieartikel.kKategorie=" & iCatId & " AND tArtikelBeschreibung.kSprache= 1 AND tEigenschaftWertSprache.kSprache= 1 AND tEigenschaftSprache.kSprache= 1 AND kPlattform=1 AND tlagerbestand.fVerfuegbar <= " & frmMain.txtLagerbestand_Menge.Text
            Else
                strQuery = "SELECT * FROM tartikel JOIN tlagerbestand ON tlagerbestand.kArtikel = tartikel.kArtikel WHERE tlagerbestand.fVerfuegbar <= " & frmMain.txtLagerbestand_Menge.Text
            End If


            frmMain.img.Images.Clear()

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()
            Dim iMenge As Integer = 0
            Dim strMengeKombi As String = ""
            While r.Read()

                iMenge += 1
                frmMain.ProgressBar1.Value = iMenge

                Dim strQueryKombi As String = ""
                Dim sqlConnKombi As New SqlConnection(strConnectionString)
                sqlConnKombi.Open()
                strQueryKombi = "SELECT * FROM tartikel JOIN tArtikelBeschreibung ON tArtikelBeschreibung.kArtikel = tartikel.kArtikel JOIN tlagerbestand ON tlagerbestand.kArtikel = tartikel.kArtikel WHERE tartikel.cArtNr='" & r("Artikelnummer") & "' AND tArtikelBeschreibung.kSprache= 1"
                strMengeKombi = ""
                Dim sqlCommKombi As New SqlCommand(strQueryKombi, sqlConnKombi)
                Dim rKombi As SqlDataReader = sqlCommKombi.ExecuteReader()
                While rKombi.Read()
                    strMengeKombi = rKombi("fVerfuegbar").ToString
                End While
                ' rKombi.Close()
                sqlConnKombi.Close()

                'Or CInt(Val(r("fVerfuegbar"))) <= frmMain.txtLagerbestand_Menge.Text
                If strMengeKombi.Length > 0 Then


                    If CInt(Val(strMengeKombi)) <= frmMain.txtLagerbestand_Menge.Text Then


                        iCount = +1
                        Dim sqlConn3 As New SqlConnection(strConnectionString)
                        sqlConn3.Open()
                        'Dim sqlComm2 As New SqlCommand("SELECT * FROM tArtikelBild WHERE kArtikel=" & r("kArtikel") & " AND nNr=1", sqlConn2)

                        If IO.File.Exists(Application.StartupPath & "\bilderexport\" & r("cArtNr") & ".jpg") = False Then
                            Dim sqlComm3 As New SqlCommand("SELECT * FROM tArtikelbildPlattform JOIN tBild ON tArtikelbildPlattform.kBild = tBild.kBild WHERE kArtikel=" & r("kArtikel") & " AND nNr='1' AND kPlattform = 1", sqlConn3)
                            Dim r3 As SqlDataReader = sqlComm3.ExecuteReader()
                            While r3.Read()
                                Try

                                    Dim strData() As Byte = r3("bBild")

                                    My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\bilderexport\" & r("cArtNr") & ".jpg", strData, False)
                                Catch ex As Exception
                                    If Not ex.Message = " Das Objekt des Typs ""System.DBNull"" kann nicht in Typ ""System.Byte[]"" umgewandelt werden." Then
                                        MessageBox.Show(r("cArtNr").ToString & " " & ex.Message)
                                    End If
                                End Try

                            End While
                        End If

                        If IO.File.Exists(Application.StartupPath & "\bilderexport\" & r("cArtNr").ToString & ".jpg") = True Then
                            img.Images.Add(r("cArtNr").ToString, Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & r("cArtNr").ToString & ".jpg"))
                        End If

                        Call getHTTPResponseMessage(My.Settings.shop_url(My.Settings.mandant_position) & "?modus=artikeldetails&iArtikelID=" & r("kArtikel").ToString, mgetUpdaterMessage.getItemDetails, True)

                        Dim lvwItem As New ListViewItem
                        Dim strBildPfad As String = ""

                        lvwItem.ImageKey = r("cArtNr").ToString
                        'lvwItem.ImageIndex = iCount
                        sqlConn3.Close()

                        'lvwItem.Text = ""
                        If r("Artikelnummer").ToString.Length > 0 Then
                            lvwItem.SubItems.Add(r("Artikelnummer").ToString)
                        Else
                            lvwItem.SubItems.Add(r("cArtNr").ToString)
                        End If

                        lvwItem.SubItems.Add(r("cName").ToString)
                        lvwItem.SubItems.Add(r("fVerfuegbar").ToString)

                        ''# Bildnamen einfügen 
                        'Dim sqlConn4 As New SqlConnection(strConnectionString)
                        'sqlConn4.Open()
                        'Dim sqlComm4 As New SqlCommand("SELECT * FROM tArtikelBild WHERE kArtikel =" & r("kArtikel").ToString & " ORDER BY nNr ASC", sqlConn4)
                        'Dim r4 As SqlDataReader = sqlComm4.ExecuteReader()
                        'While r4.Read()
                        '    Try
                        '        strBildPfad = r4("cPath").ToString
                        '    Catch ex As Exception
                        '        MessageBox.Show(ex.Message)
                        '    End Try
                        'End While
                        'sqlConn4.Close()
                        'r4.Close()

                        'If r("cArtNr").ToString.IndexOf("MPT-02") >= 0 Then
                        'Stop
                        'End If

                        strQuery = "SELECT count(*) as anzahl FROM tbestellpos WHERE cArtNr = '" & r("Artikelnummer").ToString & "'"

                        sqlConn2.Open()
                        Dim sqlComm2 As New SqlCommand(strQuery, sqlConn2)
                        Dim r2 As SqlDataReader = sqlComm2.ExecuteReader()
                        Dim strAnzahl As String = "0"
                        While r2.Read()
                            strAnzahl = r2("anzahl").ToString
                        End While
                        sqlConn2.Close()
                        r2.Close()
                        If strAnzahl = "" Then
                            strAnzahl = 0
                        End If

                        lvwItem.SubItems.Add(strAnzahl)
                        lvwItem.SubItems.Add(strItemCurrent_bild)

                        lvwItem.SubItems.Add(r("cTypName").ToString)
                        lvwItem.SubItems.Add(r("cTypValue").ToString)
                        'lvwItem.SubItems.Add(r("nLageranzahl").ToString)
                        lvwItem.SubItems.Add(strMengeKombi)

                        frmMain.lvwArtikel.Items.Add(lvwItem)
                        frmMain.lvwArtikel.EnsureVisible(frmMain.lvwArtikel.Items.Count - 1)
                    End If
                End If
                rKombi.Close()
            End While


            r.Close()

            '##################################################################
            '# >> Normale Artikel laden 
            '##################################################################

            '########################
            '# Menge bestimmmen
            '########################
            strQuery = "SELECT count(*) as anzahl FROM tartikel JOIN tArtikelBeschreibung ON tArtikelBeschreibung.kArtikel = tartikel.kArtikel JOIN tkategorieartikel ON tkategorieartikel.kArtikel = tartikel.kArtikel  JOIN tlagerbestand ON tlagerbestand.kArtikel = tartikel.kArtikel WHERE tkategorieartikel.kKategorie='" & iCatId & "' AND tlagerbestand.fVerfuegbar <= " & frmMain.txtLagerbestand_Menge.Text & " AND tArtikelBeschreibung.kSprache= 1"
            Dim sqlCommAnzahl2 As New SqlCommand(strQuery, sqlConn)
            Dim rAnzahl2 As SqlDataReader = sqlCommAnzahl2.ExecuteReader()
            frmMain.ProgressBar1.Value = 0
            While rAnzahl2.Read()

                frmMain.ProgressBar1.Maximum = Convert.ToInt16(rAnzahl2("anzahl").ToString)

            End While
            rAnzahl2.Close()

            strQuery = "SELECT * FROM tartikel JOIN tArtikelBeschreibung ON tArtikelBeschreibung.kArtikel = tartikel.kArtikel JOIN tkategorieartikel ON tkategorieartikel.kArtikel = tartikel.kArtikel  JOIN tlagerbestand ON tlagerbestand.kArtikel = tartikel.kArtikel WHERE tkategorieartikel.kKategorie='" & iCatId & "' AND tlagerbestand.fVerfuegbar <= " & frmMain.txtLagerbestand_Menge.Text & " AND tArtikelBeschreibung.kSprache= 1"

            Dim sqlCommNormal As New SqlCommand(strQuery, sqlConn)
            Dim rNormal As SqlDataReader = sqlCommNormal.ExecuteReader()
            Dim iMenge2 As Integer = 0
            While rNormal.Read()

                iMenge2 += 1
                Try
                    frmMain.ProgressBar1.Value = iMenge2
                Catch ex As Exception

                End Try




                iCount = +1
                Dim sqlConn3 As New SqlConnection(strConnectionString)
                sqlConn3.Open()
                'Dim sqlComm2 As New SqlCommand("SELECT * FROM tArtikelBild WHERE kArtikel=" & r("kArtikel") & " AND nNr=1", sqlConn2)

                If IO.File.Exists(Application.StartupPath & "\bilderexport\" & rNormal("cArtNr") & ".jpg") = False Then
                    Dim sqlComm3 As New SqlCommand("SELECT * FROM tArtikelbildPlattform JOIN tBild ON tArtikelbildPlattform.kBild = tBild.kBild WHERE kArtikel=" & rNormal("kArtikel") & " AND nNr='1' AND kPlattform = 1", sqlConn3)
                    Dim r3 As SqlDataReader = sqlComm3.ExecuteReader()
                    While r3.Read()
                        Try

                            Dim strData() As Byte = r3("bBild")

                            My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\bilderexport\" & rNormal("cArtNr") & ".jpg", strData, False)
                        Catch ex As Exception
                            If Not ex.Message = " Das Objekt des Typs ""System.DBNull"" kann nicht in Typ ""System.Byte[]"" umgewandelt werden." Then
                                MessageBox.Show(rNormal("cArtNr").ToString & " " & ex.Message)
                            End If
                        End Try

                    End While
                End If

                If IO.File.Exists(Application.StartupPath & "\bilderexport\" & rNormal("cArtNr").ToString & ".jpg") = True Then
                    img.Images.Add(rNormal("cArtNr").ToString, Bitmap.FromFile(Application.StartupPath & "\bilderexport\" & rNormal("cArtNr").ToString & ".jpg"))
                End If

                Call getHTTPResponseMessage(My.Settings.shop_url(My.Settings.mandant_position) & "?modus=artikeldetails&iArtikelID=" & rNormal("kArtikel").ToString, mgetUpdaterMessage.getItemDetails, True)

                Dim lvwItem As New ListViewItem
                Dim strBildPfad As String = ""

                lvwItem.ImageKey = rNormal("cArtNr").ToString
                'lvwItem.ImageIndex = iCount
                sqlConn3.Close()

                'lvwItem.Text = ""
                lvwItem.SubItems.Add(rNormal("cArtNr").ToString)
                lvwItem.SubItems.Add(rNormal("cName").ToString)
                lvwItem.SubItems.Add(rNormal("fVerfuegbar").ToString)

                strQuery = "SELECT count(*) as anzahl FROM tbestellpos WHERE cArtNr = '" & rNormal("cArtNr").ToString & "'"

                sqlConn2.Open()
                Dim sqlComm2 As New SqlCommand(strQuery, sqlConn2)
                Dim r2 As SqlDataReader = sqlComm2.ExecuteReader()
                Dim strAnzahl As String = "0"
                While r2.Read()
                    strAnzahl = r2("anzahl").ToString
                End While
                sqlConn2.Close()
                r2.Close()
                If strAnzahl = "" Then
                    strAnzahl = 0
                End If

                lvwItem.SubItems.Add(strAnzahl)
                lvwItem.SubItems.Add(strItemCurrent_bild)

                lvwItem.SubItems.Add("---")
                lvwItem.SubItems.Add("---")
                lvwItem.SubItems.Add("---")

                frmMain.lvwArtikel.Items.Add(lvwItem)
                frmMain.lvwArtikel.EnsureVisible(frmMain.lvwArtikel.Items.Count - 1)


            End While
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

End Class
