Public Class frm_settings
    Private Sub Lbl_dtbase_MouseHover(sender As Object, e As EventArgs) Handles lbl_dtbase.MouseHover
        lbl_dtbase.ForeColor = Color.Gold
        lbl_dtbase.Font = New Font("Century Gothic", 20, FontStyle.Bold)
    End Sub

    Private Sub Lbl_dtbase_MouseLeave(sender As Object, e As EventArgs) Handles lbl_dtbase.MouseLeave
        lbl_dtbase.ForeColor = Color.White
        lbl_dtbase.Font = New Font("Century Gothic", 18, FontStyle.Regular)
    End Sub

    Private Sub Frm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.sett_dbSource = txt_dbSource.Text
        My.Settings.sett_dbName = txt_dbName.Text
        My.Settings.sett_dbUsername = txt_dbUsername.Text
        My.Settings.sett_dbPass = txt_dbPassword.Text
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        testConnect()
    End Sub
End Class