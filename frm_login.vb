Public Class frm_login
    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.Gainsboro
        Panel2.BackColor = Color.Gainsboro
        With txt_user
            .Text = "ENTER USERNAME"
            .ForeColor = SystemColors.InactiveCaption

        End With
        With txt_pass
            .Text = "ENTER PASSWORD"
            .ForeColor = SystemColors.InactiveCaption

        End With
    End Sub

    Private Sub Txt_user_Enter(sender As Object, e As EventArgs) Handles txt_user.Enter
        Panel1.Visible = True
        Panel1.BackColor = Color.Maroon
        txt_user.Text = ""
        txt_user.ForeColor = Color.Black

    End Sub

    Private Sub Txt_pass_Enter(sender As Object, e As EventArgs) Handles txt_pass.Enter
        Panel1.BackColor = Color.Gainsboro
        Panel2.BackColor = Color.Maroon
        txt_pass.Text = ""
        txt_pass.ForeColor = Color.Black
    End Sub

    Private Sub Txt_pass_Leave(sender As Object, e As EventArgs) Handles txt_pass.Leave
        Panel1.BackColor = Color.Gainsboro
        Panel2.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        frm_main.tsl_hover.Text = "Login Your Account"
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        frm_main.tsl_hover.Text = ""
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        frm_main.tsl_hover.Text = "Exit Login Window"
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        frm_main.tsl_hover.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnl_load.Visible = True

    End Sub
End Class