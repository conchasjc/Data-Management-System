Public Class frm_main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_login.MdiParent = Me
        frm_login.Show()
        tsl_hover.Text = ""

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frm_settings.Show()
    End Sub
End Class
