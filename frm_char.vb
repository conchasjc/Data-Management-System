Public Class frm_char
    Private Sub Frm_char_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_main.mts_logout.Visible = True
        frm_main.mts_login.Visible = False

        getDbChar("")
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


    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        Clipboard.SetText(GunaDataGridView1.CurrentCell.Value)
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged
        getFilter()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        If GunaAdvenceButton1.Checked = True Then
            GunaAdvenceButton1.Checked = False

            getDbChar("")
        Else
            GunaAdvenceButton1.Checked = True
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("S35C&S45C")
        End If

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        If GunaAdvenceButton2.Checked = True Then
            GunaAdvenceButton2.Checked = False
            getDbChar("")
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = True
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("S50C")
        End If
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        If GunaAdvenceButton3.Checked = True Then
            GunaAdvenceButton3.Checked = False
            getDbChar("")
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = True
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("S55C")
        End If
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        If GunaAdvenceButton4.Checked = True Then
            GunaAdvenceButton4.Checked = False
            getDbChar("")
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = True
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("SCM435")
        End If
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        If GunaAdvenceButton5.Checked = True Then
            GunaAdvenceButton5.Checked = False
            getDbChar("")
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = True
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("SCM440")
        End If
    End Sub
End Class