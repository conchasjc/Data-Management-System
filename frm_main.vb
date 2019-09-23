Public Class frm_main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_login.MdiParent = Me
        frm_login.Show()
        tsl_hover.Text = ""
        tsb_char.Text = "Work" + vbNewLine + "Station"
        tsb_purchase.Text = "Purchased" + vbNewLine + "Parts"
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frm_settings.Show()
    End Sub

    Private Sub Tmr_time_Tick(sender As Object, e As EventArgs) Handles tmr_time.Tick
        ts_time.Text = Now.ToLongTimeString + " " + Now.ToLongDateString

    End Sub

    Private Sub Tsb_char_Click(sender As Object, e As EventArgs) Handles tsb_char.Click
        frm_char.MdiParent = Me
        frm_char.Show()
    End Sub
End Class
