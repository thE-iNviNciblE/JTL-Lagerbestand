Public Class frmShopURL

    Private Sub txtShopURL_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtShopURL.TextChanged
        My.Settings.shop_url(My.Settings.mandant_position) = txtShopURL.Text
        My.Settings.Save()
    End Sub

    Private Sub frmShopURL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtShopURL.Text = My.Settings.shop_url(My.Settings.mandant_position)
    End Sub

    Private Sub btnSyncLager_Click(sender As System.Object, e As System.EventArgs) Handles btnSyncLager.Click
        My.Settings.Save()
        Me.Close()
    End Sub
End Class