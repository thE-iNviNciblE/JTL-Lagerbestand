<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnSyncLager = New System.Windows.Forms.Button()
        Me.lvwArtikel = New System.Windows.Forms.ListView()
        Me.colBild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colArtikelnummer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLagerbestand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVerkäufe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBildname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVarTyp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVarValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVarLagerbestand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTageAnzahl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLagerbestand_Menge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankeinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailserverEinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopURLFestlegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NachUpdatesSuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbMandant = New System.Windows.Forms.ComboBox()
        Me.lvwKategorie = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKatName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkEmailReport = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSyncLager
        '
        Me.btnSyncLager.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSyncLager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSyncLager.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncLager.Location = New System.Drawing.Point(9, 28)
        Me.btnSyncLager.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSyncLager.Name = "btnSyncLager"
        Me.btnSyncLager.Size = New System.Drawing.Size(162, 43)
        Me.btnSyncLager.TabIndex = 0
        Me.btnSyncLager.Text = "Report erstellen"
        Me.btnSyncLager.UseVisualStyleBackColor = False
        '
        'lvwArtikel
        '
        Me.lvwArtikel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwArtikel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwArtikel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBild, Me.colArtikelnummer, Me.colName, Me.colLagerbestand, Me.colVerkäufe, Me.colBildname, Me.colVarTyp, Me.colVarValue, Me.colVarLagerbestand})
        Me.lvwArtikel.FullRowSelect = True
        Me.lvwArtikel.GridLines = True
        Me.lvwArtikel.HideSelection = False
        Me.lvwArtikel.LargeImageList = Me.img
        Me.lvwArtikel.Location = New System.Drawing.Point(207, 94)
        Me.lvwArtikel.Margin = New System.Windows.Forms.Padding(2)
        Me.lvwArtikel.MultiSelect = False
        Me.lvwArtikel.Name = "lvwArtikel"
        Me.lvwArtikel.Size = New System.Drawing.Size(538, 360)
        Me.lvwArtikel.SmallImageList = Me.img
        Me.lvwArtikel.TabIndex = 1
        Me.lvwArtikel.UseCompatibleStateImageBehavior = False
        Me.lvwArtikel.View = System.Windows.Forms.View.Details
        '
        'colBild
        '
        Me.colBild.Text = "Bild"
        '
        'colArtikelnummer
        '
        Me.colArtikelnummer.DisplayIndex = 4
        Me.colArtikelnummer.Text = "Art-Nr."
        '
        'colName
        '
        Me.colName.DisplayIndex = 5
        Me.colName.Text = "Name"
        Me.colName.Width = 673
        '
        'colLagerbestand
        '
        Me.colLagerbestand.DisplayIndex = 6
        Me.colLagerbestand.Text = "Lagerbestand"
        Me.colLagerbestand.Width = 105
        '
        'colVerkäufe
        '
        Me.colVerkäufe.DisplayIndex = 7
        Me.colVerkäufe.Text = "Verkäufe"
        Me.colVerkäufe.Width = 78
        '
        'colBildname
        '
        Me.colBildname.DisplayIndex = 8
        Me.colBildname.Text = "Bildname"
        '
        'colVarTyp
        '
        Me.colVarTyp.DisplayIndex = 1
        Me.colVarTyp.Text = "Typ"
        Me.colVarTyp.Width = 87
        '
        'colVarValue
        '
        Me.colVarValue.DisplayIndex = 2
        Me.colVarValue.Text = "Value"
        Me.colVarValue.Width = 78
        '
        'colVarLagerbestand
        '
        Me.colVarLagerbestand.DisplayIndex = 3
        Me.colVarLagerbestand.Text = "Lagerbestand"
        Me.colVarLagerbestand.Width = 66
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "ok")
        Me.img.Images.SetKeyName(1, "gen-himmel021.jpg")
        Me.img.Images.SetKeyName(2, "spa.jpg")
        Me.img.Images.SetKeyName(3, "calendar_delete.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tage Rückwärts für Verkäufe"
        Me.Label1.Visible = False
        '
        'txtTageAnzahl
        '
        Me.txtTageAnzahl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTageAnzahl.Location = New System.Drawing.Point(374, 45)
        Me.txtTageAnzahl.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTageAnzahl.Name = "txtTageAnzahl"
        Me.txtTageAnzahl.Size = New System.Drawing.Size(53, 20)
        Me.txtTageAnzahl.TabIndex = 3
        Me.txtTageAnzahl.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(431, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tage"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(565, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lagerbestand für Hinweis"
        '
        'txtLagerbestand_Menge
        '
        Me.txtLagerbestand_Menge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLagerbestand_Menge.Location = New System.Drawing.Point(567, 43)
        Me.txtLagerbestand_Menge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLagerbestand_Menge.Name = "txtLagerbestand_Menge"
        Me.txtLagerbestand_Menge.Size = New System.Drawing.Size(53, 20)
        Me.txtLagerbestand_Menge.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(624, 45)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Menge"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankeinstellungenToolStripMenuItem, Me.EmailserverEinstellungenToolStripMenuItem, Me.ShopURLFestlegenToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'DatenbankeinstellungenToolStripMenuItem
        '
        Me.DatenbankeinstellungenToolStripMenuItem.Name = "DatenbankeinstellungenToolStripMenuItem"
        Me.DatenbankeinstellungenToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DatenbankeinstellungenToolStripMenuItem.Text = "Datenbankeinstellungen..."
        '
        'EmailserverEinstellungenToolStripMenuItem
        '
        Me.EmailserverEinstellungenToolStripMenuItem.Name = "EmailserverEinstellungenToolStripMenuItem"
        Me.EmailserverEinstellungenToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.EmailserverEinstellungenToolStripMenuItem.Text = "Emailserver Einstellungen..."
        '
        'ShopURLFestlegenToolStripMenuItem
        '
        Me.ShopURLFestlegenToolStripMenuItem.Name = "ShopURLFestlegenToolStripMenuItem"
        Me.ShopURLFestlegenToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ShopURLFestlegenToolStripMenuItem.Text = "Shop URL festlegen..."
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NachUpdatesSuchenToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'NachUpdatesSuchenToolStripMenuItem
        '
        Me.NachUpdatesSuchenToolStripMenuItem.Name = "NachUpdatesSuchenToolStripMenuItem"
        Me.NachUpdatesSuchenToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.NachUpdatesSuchenToolStripMenuItem.Text = "&Nach Updates suchen..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(205, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Mandant"
        '
        'cmbMandant
        '
        Me.cmbMandant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMandant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMandant.FormattingEnabled = True
        Me.cmbMandant.Location = New System.Drawing.Point(207, 45)
        Me.cmbMandant.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMandant.Name = "cmbMandant"
        Me.cmbMandant.Size = New System.Drawing.Size(134, 21)
        Me.cmbMandant.TabIndex = 10
        '
        'lvwKategorie
        '
        Me.lvwKategorie.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvwKategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwKategorie.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colKatName})
        Me.lvwKategorie.FullRowSelect = True
        Me.lvwKategorie.GridLines = True
        Me.lvwKategorie.HideSelection = False
        Me.lvwKategorie.Location = New System.Drawing.Point(9, 94)
        Me.lvwKategorie.Margin = New System.Windows.Forms.Padding(2)
        Me.lvwKategorie.MultiSelect = False
        Me.lvwKategorie.Name = "lvwKategorie"
        Me.lvwKategorie.Size = New System.Drawing.Size(194, 360)
        Me.lvwKategorie.TabIndex = 11
        Me.lvwKategorie.UseCompatibleStateImageBehavior = False
        Me.lvwKategorie.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 0
        '
        'colKatName
        '
        Me.colKatName.Text = "Name"
        Me.colKatName.Width = 300
        '
        'chkEmailReport
        '
        Me.chkEmailReport.AutoSize = True
        Me.chkEmailReport.Checked = True
        Me.chkEmailReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEmailReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEmailReport.Location = New System.Drawing.Point(9, 72)
        Me.chkEmailReport.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEmailReport.Name = "chkEmailReport"
        Me.chkEmailReport.Size = New System.Drawing.Size(168, 17)
        Me.chkEmailReport.TabIndex = 12
        Me.chkEmailReport.Text = "Email Report (Kategoriesortiert)"
        Me.chkEmailReport.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(207, 69)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(538, 19)
        Me.ProgressBar1.TabIndex = 13
        Me.ProgressBar1.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 463)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.chkEmailReport)
        Me.Controls.Add(Me.lvwKategorie)
        Me.Controls.Add(Me.cmbMandant)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLagerbestand_Menge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTageAnzahl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwArtikel)
        Me.Controls.Add(Me.btnSyncLager)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "JTL Lager Sync Report 2.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSyncLager As System.Windows.Forms.Button
    Friend WithEvents lvwArtikel As System.Windows.Forms.ListView
    Friend WithEvents colBild As System.Windows.Forms.ColumnHeader
    Friend WithEvents colArtikelnummer As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLagerbestand As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVerkäufe As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTageAnzahl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLagerbestand_Menge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankeinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailserverEinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NachUpdatesSuchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbMandant As System.Windows.Forms.ComboBox
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents lvwKategorie As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colKatName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkEmailReport As System.Windows.Forms.CheckBox
    Friend WithEvents ShopURLFestlegenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colBildname As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVarTyp As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVarValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVarLagerbestand As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
