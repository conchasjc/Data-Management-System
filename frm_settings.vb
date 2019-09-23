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
End Class