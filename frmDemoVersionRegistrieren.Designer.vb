<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemoVersionRegistrieren
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDemoVersionRegistrieren))
        Me.txtLand = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStadt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPLZ = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStraße = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNachname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirma = New System.Windows.Forms.TextBox()
        Me.lblFirma = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHandy = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRegisterJTLBridge = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLand
        '
        Me.txtLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLand.Location = New System.Drawing.Point(13, 219)
        Me.txtLand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLand.Name = "txtLand"
        Me.txtLand.Size = New System.Drawing.Size(230, 23)
        Me.txtLand.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 199)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Land*"
        '
        'txtStadt
        '
        Me.txtStadt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStadt.Location = New System.Drawing.Point(525, 116)
        Me.txtStadt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStadt.Name = "txtStadt"
        Me.txtStadt.Size = New System.Drawing.Size(230, 23)
        Me.txtStadt.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(521, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Stadt*"
        '
        'txtPLZ
        '
        Me.txtPLZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPLZ.Location = New System.Drawing.Point(287, 116)
        Me.txtPLZ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPLZ.Name = "txtPLZ"
        Me.txtPLZ.Size = New System.Drawing.Size(114, 23)
        Me.txtPLZ.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(283, 96)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Postleitzahl*"
        '
        'txtStraße
        '
        Me.txtStraße.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStraße.Location = New System.Drawing.Point(13, 116)
        Me.txtStraße.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStraße.Name = "txtStraße"
        Me.txtStraße.Size = New System.Drawing.Size(230, 23)
        Me.txtStraße.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Straße*"
        '
        'txtNachname
        '
        Me.txtNachname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNachname.Location = New System.Drawing.Point(524, 57)
        Me.txtNachname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNachname.Name = "txtNachname"
        Me.txtNachname.Size = New System.Drawing.Size(167, 23)
        Me.txtNachname.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(520, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nachname*"
        '
        'txtVorname
        '
        Me.txtVorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVorname.Location = New System.Drawing.Point(285, 57)
        Me.txtVorname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(167, 23)
        Me.txtVorname.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Vorname*"
        '
        'txtFirma
        '
        Me.txtFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirma.Location = New System.Drawing.Point(12, 57)
        Me.txtFirma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirma.Name = "txtFirma"
        Me.txtFirma.Size = New System.Drawing.Size(230, 23)
        Me.txtFirma.TabIndex = 18
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirma.Location = New System.Drawing.Point(8, 37)
        Me.lblFirma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(54, 17)
        Me.lblFirma.TabIndex = 17
        Me.lblFirma.Text = "Firma*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "JTL Lagerbestand Report "
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(12, 171)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 23)
        Me.txtEmail.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Email*"
        '
        'txtTelefon
        '
        Me.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefon.Location = New System.Drawing.Point(285, 171)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(167, 23)
        Me.txtTelefon.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(281, 151)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Telefon*"
        '
        'txtHandy
        '
        Me.txtHandy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHandy.Location = New System.Drawing.Point(524, 171)
        Me.txtHandy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHandy.Name = "txtHandy"
        Me.txtHandy.Size = New System.Drawing.Size(167, 23)
        Me.txtHandy.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(520, 151)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Handy*"
        '
        'btnRegisterJTLBridge
        '
        Me.btnRegisterJTLBridge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRegisterJTLBridge.BackColor = System.Drawing.Color.Bisque
        Me.btnRegisterJTLBridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterJTLBridge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRegisterJTLBridge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegisterJTLBridge.ImageKey = "database_add.png"
        Me.btnRegisterJTLBridge.ImageList = Me.ImageList1
        Me.btnRegisterJTLBridge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegisterJTLBridge.Location = New System.Drawing.Point(341, 519)
        Me.btnRegisterJTLBridge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegisterJTLBridge.Name = "btnRegisterJTLBridge"
        Me.btnRegisterJTLBridge.Size = New System.Drawing.Size(285, 44)
        Me.btnRegisterJTLBridge.TabIndex = 38
        Me.btnRegisterJTLBridge.Text = "&JTL Lager Report registrieren"
        Me.btnRegisterJTLBridge.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cancel.png")
        Me.ImageList1.Images.SetKeyName(1, "database_add.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(784, 169)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hinweise"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 31)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(647, 119)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = resources.GetString("Label11.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFirma)
        Me.GroupBox2.Controls.Add(Me.txtFirma)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtHandy)
        Me.GroupBox2.Controls.Add(Me.txtLand)
        Me.GroupBox2.Controls.Add(Me.txtVorname)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtTelefon)
        Me.GroupBox2.Controls.Add(Me.txtNachname)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.txtStraße)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtPLZ)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtStadt)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 241)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(783, 262)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registrieren für JTL Lagerbestand Report"
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbbrechen.BackColor = System.Drawing.Color.Bisque
        Me.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbbrechen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAbbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbbrechen.ImageKey = "cancel.png"
        Me.btnAbbrechen.ImageList = Me.ImageList1
        Me.btnAbbrechen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAbbrechen.Location = New System.Drawing.Point(635, 519)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(168, 44)
        Me.btnAbbrechen.TabIndex = 41
        Me.btnAbbrechen.Text = "&Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = False
        '
        'frmDemoVersionRegistrieren
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 578)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRegisterJTLBridge)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDemoVersionRegistrieren"
        Me.Text = "Demoversion Registieren"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLand As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStadt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPLZ As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStraße As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNachname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVorname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirma As System.Windows.Forms.TextBox
    Friend WithEvents lblFirma As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtHandy As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRegisterJTLBridge As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
