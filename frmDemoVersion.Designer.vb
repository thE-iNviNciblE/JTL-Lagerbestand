﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemoVersion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDemoVersion))
        Me.pgrTage = New System.Windows.Forms.ProgressBar()
        Me.btnProgrammStart = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMainMessage = New System.Windows.Forms.Label()
        Me.btnProgrammRegister = New System.Windows.Forms.Button()
        Me.lblInstallDatum = New System.Windows.Forms.Label()
        Me.lblDemoEnde = New System.Windows.Forms.Label()
        Me.btnProgrammEnde = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pgrTage
        '
        Me.pgrTage.Location = New System.Drawing.Point(16, 258)
        Me.pgrTage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pgrTage.Name = "pgrTage"
        Me.pgrTage.Size = New System.Drawing.Size(740, 28)
        Me.pgrTage.TabIndex = 0
        '
        'btnProgrammStart
        '
        Me.btnProgrammStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProgrammStart.BackColor = System.Drawing.Color.Moccasin
        Me.btnProgrammStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgrammStart.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnProgrammStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgrammStart.ImageKey = "illixi_icon.ico"
        Me.btnProgrammStart.ImageList = Me.ImageList1
        Me.btnProgrammStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProgrammStart.Location = New System.Drawing.Point(489, 27)
        Me.btnProgrammStart.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnProgrammStart.Name = "btnProgrammStart"
        Me.btnProgrammStart.Size = New System.Drawing.Size(267, 38)
        Me.btnProgrammStart.TabIndex = 73
        Me.btnProgrammStart.Text = "&Weiter zu JTL Lagerbestand"
        Me.btnProgrammStart.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "illixi_icon.ico")
        Me.ImageList1.Images.SetKeyName(1, "database_go.png")
        Me.ImageList1.Images.SetKeyName(2, "cross.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMainMessage)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(464, 210)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Demoversion"
        '
        'lblMainMessage
        '
        Me.lblMainMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMessage.Location = New System.Drawing.Point(8, 30)
        Me.lblMainMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMainMessage.Name = "lblMainMessage"
        Me.lblMainMessage.Size = New System.Drawing.Size(441, 156)
        Me.lblMainMessage.TabIndex = 0
        Me.lblMainMessage.Text = resources.GetString("lblMainMessage.Text")
        '
        'btnProgrammRegister
        '
        Me.btnProgrammRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProgrammRegister.BackColor = System.Drawing.Color.Moccasin
        Me.btnProgrammRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgrammRegister.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnProgrammRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgrammRegister.ImageKey = "database_go.png"
        Me.btnProgrammRegister.ImageList = Me.ImageList1
        Me.btnProgrammRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProgrammRegister.Location = New System.Drawing.Point(489, 100)
        Me.btnProgrammRegister.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnProgrammRegister.Name = "btnProgrammRegister"
        Me.btnProgrammRegister.Size = New System.Drawing.Size(267, 38)
        Me.btnProgrammRegister.TabIndex = 75
        Me.btnProgrammRegister.Text = "JTL Lagerbestand &registieren"
        Me.btnProgrammRegister.UseVisualStyleBackColor = False
        '
        'lblInstallDatum
        '
        Me.lblInstallDatum.AutoSize = True
        Me.lblInstallDatum.Location = New System.Drawing.Point(15, 241)
        Me.lblInstallDatum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstallDatum.Name = "lblInstallDatum"
        Me.lblInstallDatum.Size = New System.Drawing.Size(0, 17)
        Me.lblInstallDatum.TabIndex = 76
        '
        'lblDemoEnde
        '
        Me.lblDemoEnde.AutoSize = True
        Me.lblDemoEnde.Location = New System.Drawing.Point(525, 239)
        Me.lblDemoEnde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDemoEnde.Name = "lblDemoEnde"
        Me.lblDemoEnde.Size = New System.Drawing.Size(0, 17)
        Me.lblDemoEnde.TabIndex = 77
        '
        'btnProgrammEnde
        '
        Me.btnProgrammEnde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProgrammEnde.BackColor = System.Drawing.Color.Moccasin
        Me.btnProgrammEnde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgrammEnde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnProgrammEnde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgrammEnde.ImageKey = "cross.png"
        Me.btnProgrammEnde.ImageList = Me.ImageList1
        Me.btnProgrammEnde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProgrammEnde.Location = New System.Drawing.Point(489, 162)
        Me.btnProgrammEnde.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnProgrammEnde.Name = "btnProgrammEnde"
        Me.btnProgrammEnde.Size = New System.Drawing.Size(265, 38)
        Me.btnProgrammEnde.TabIndex = 78
        Me.btnProgrammEnde.Text = "JTL Lagerbestand &beenden"
        Me.btnProgrammEnde.UseVisualStyleBackColor = False
        '
        'frmDemoVersion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 302)
        Me.Controls.Add(Me.btnProgrammEnde)
        Me.Controls.Add(Me.lblDemoEnde)
        Me.Controls.Add(Me.lblInstallDatum)
        Me.Controls.Add(Me.btnProgrammRegister)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProgrammStart)
        Me.Controls.Add(Me.pgrTage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDemoVersion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demoversion"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgrTage As System.Windows.Forms.ProgressBar
    Friend WithEvents btnProgrammStart As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMainMessage As System.Windows.Forms.Label
    Friend WithEvents btnProgrammRegister As System.Windows.Forms.Button
    Friend WithEvents lblInstallDatum As System.Windows.Forms.Label
    Friend WithEvents lblDemoEnde As System.Windows.Forms.Label
    Friend WithEvents btnProgrammEnde As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
