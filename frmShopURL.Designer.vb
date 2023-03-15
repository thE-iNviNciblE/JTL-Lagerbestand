<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShopURL
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
        Me.txtShopURL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSyncLager = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtShopURL
        '
        Me.txtShopURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShopURL.Location = New System.Drawing.Point(12, 33)
        Me.txtShopURL.Name = "txtShopURL"
        Me.txtShopURL.Size = New System.Drawing.Size(411, 22)
        Me.txtShopURL.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shop URL für Emailreport eintragen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSyncLager
        '
        Me.btnSyncLager.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSyncLager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSyncLager.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncLager.Location = New System.Drawing.Point(297, 74)
        Me.btnSyncLager.Name = "btnSyncLager"
        Me.btnSyncLager.Size = New System.Drawing.Size(126, 29)
        Me.btnSyncLager.TabIndex = 2
        Me.btnSyncLager.Text = "Speichern"
        Me.btnSyncLager.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Beispiel: http://www.meinshop.de/connector/jtl-shop-connector.php"
        '
        'frmShopURL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 114)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSyncLager)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShopURL)
        Me.Name = "frmShopURL"
        Me.Text = "Shop URL eintragen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtShopURL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSyncLager As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
