Public Class frm_char
    Private Sub Frm_char_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_main.mts_logout.Visible = True
        frm_main.mts_login.Visible = False
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Clipboard.SetText(GunaCircleButton1.Text)
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        Clipboard.SetText(GunaCircleButton2.Text)
    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click
        Clipboard.SetText(GunaCircleButton3.Text)
    End Sub

    Private Sub GunaCircleButton4_Click(sender As Object, e As EventArgs) Handles GunaCircleButton4.Click
        Clipboard.SetText(GunaCircleButton4.Text)
    End Sub

    Private Sub GunaCircleButton5_Click(sender As Object, e As EventArgs) Handles GunaCircleButton5.Click
        Clipboard.SetText(GunaCircleButton5.Text)
    End Sub

    Private Sub GunaCircleButton6_Click(sender As Object, e As EventArgs) Handles GunaCircleButton6.Click
        Clipboard.SetText(GunaCircleButton6.Text)
    End Sub
End Class