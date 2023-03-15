<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdater))
        Me.pgrUpdate = New System.Windows.Forms.ProgressBar()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblUpdater = New System.Windows.Forms.Label()
        Me.lblUpdateHinweise = New System.Windows.Forms.Label()
        Me.lblUpdateMessage = New System.Windows.Forms.Label()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pgrUpdate
        '
        Me.pgrUpdate.Location = New System.Drawing.Point(16, 226)
        Me.pgrUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pgrUpdate.Name = "pgrUpdate"
        Me.pgrUpdate.Size = New System.Drawing.Size(716, 28)
        Me.pgrUpdate.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Bisque
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.ImageKey = "cancel.png"
        Me.btnOK.ImageList = Me.ImageList1
        Me.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOK.Location = New System.Drawing.Point(557, 263)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(175, 44)
        Me.btnOK.TabIndex = 83
        Me.btnOK.Text = "&Abbrechen"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cancel.png")
        Me.ImageList1.Images.SetKeyName(1, "database_connect.png")
        '
        'lblUpdater
        '
        Me.lblUpdater.AutoSize = True
        Me.lblUpdater.Location = New System.Drawing.Point(324, 207)
        Me.lblUpdater.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdater.Name = "lblUpdater"
        Me.lblUpdater.Size = New System.Drawing.Size(0, 17)
        Me.lblUpdater.TabIndex = 84
        '
        'lblUpdateHinweise
        '
        Me.lblUpdateHinweise.AutoSize = True
        Me.lblUpdateHinweise.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateHinweise.Location = New System.Drawing.Point(16, 11)
        Me.lblUpdateHinweise.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdateHinweise.Name = "lblUpdateHinweise"
        Me.lblUpdateHinweise.Size = New System.Drawing.Size(245, 24)
        Me.lblUpdateHinweise.TabIndex = 85
        Me.lblUpdateHinweise.Text = "JTL Lagerbestand Report"
        '
        'lblUpdateMessage
        '
        Me.lblUpdateMessage.AutoSize = True
        Me.lblUpdateMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateMessage.Location = New System.Drawing.Point(4, 12)
        Me.lblUpdateMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdateMessage.Name = "lblUpdateMessage"
        Me.lblUpdateMessage.Size = New System.Drawing.Size(156, 17)
        Me.lblUpdateMessage.TabIndex = 86
        Me.lblUpdateMessage.Text = "Suche nach Updates...."
        '
        'btnDownload
        '
        Me.btnDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDownload.BackColor = System.Drawing.Color.Bisque
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDownload.ImageKey = "database_connect.png"
        Me.btnDownload.ImageList = Me.ImageList1
        Me.btnDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDownload.Location = New System.Drawing.Point(328, 263)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(221, 44)
        Me.btnDownload.TabIndex = 87
        Me.btnDownload.Text = "&Update"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(716, 171)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Hinweise"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lblUpdateMessage)
        Me.Panel1.Location = New System.Drawing.Point(8, 23)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 140)
        Me.Panel1.TabIndex = 87
        '
        'frmUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 322)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.lblUpdateHinweise)
        Me.Controls.Add(Me.lblUpdater)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.pgrUpdate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpdater"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgrUpdate As System.Windows.Forms.ProgressBar
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblUpdater As System.Windows.Forms.Label
    Friend WithEvents lblUpdateHinweise As System.Windows.Forms.Label
    Friend WithEvents lblUpdateMessage As System.Windows.Forms.Label
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
