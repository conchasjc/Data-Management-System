Public Class frm_settings




    Private Sub Frm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pnl_database.Visible = True Then
            lbl_dtbase.ForeColor = Color.Gold
            lbl_dtbase.Font = New Font("Century Gothic", 22, FontStyle.Bold)
        End If
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




    Private Sub Lbl_dtbase_Click(sender As Object, e As EventArgs) Handles lbl_dtbase.Click
        lbl_dtbase.ForeColor = Color.Gold
        lbl_dtbase.Font = New Font("Century Gothic", 22, FontStyle.Bold)
        lbl_purch.ForeColor = Color.White
        lbl_purch.Font = New Font("Century Gothic", 18, FontStyle.Regular)
    End Sub

    Private Sub Lbl_purch_Click(sender As Object, e As EventArgs) Handles lbl_purch.Click
        lbl_purch.ForeColor = Color.Gold
        lbl_purch.Font = New Font("Century Gothic", 22, FontStyle.Bold)
        lbl_dtbase.ForeColor = Color.White
        lbl_dtbase.Font = New Font("Century Gothic", 18, FontStyle.Regular)
    End Sub



    Private Sub Pb_showeye_Click(sender As Object, e As EventArgs) Handles pb_showeye.Click
        PictureBox2.Visible = True
        txt_dbPassword.PasswordChar = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
        txt_dbPassword.PasswordChar = "*"
    End Sub
End Class