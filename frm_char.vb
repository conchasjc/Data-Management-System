Public Class frm_char
    Private Sub Frm_char_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_Main.Mts_Logout.Visible = True
        Frm_Main.Mts_Login.Visible = False
        frm_desk.Close()
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
        Try
            Clipboard.SetText(GunaDataGridView1.CurrentCell.Value)
        Catch
        End Try
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged
        getCharFilter()

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        If GunaAdvenceButton1.Checked = True Then
            GunaAdvenceButton1.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
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
            GunaTextBox1.Text = ""
        End If

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        If GunaAdvenceButton2.Checked = True Then
            GunaAdvenceButton2.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
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
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        If GunaAdvenceButton3.Checked = True Then
            GunaAdvenceButton3.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
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
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        If GunaAdvenceButton4.Checked = True Then
            GunaAdvenceButton4.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
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
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        If GunaAdvenceButton5.Checked = True Then
            GunaAdvenceButton5.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
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
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton10.Click
        If GunaAdvenceButton10.Checked = True Then
            GunaAdvenceButton10.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = True
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("SKD11")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton9.Click
        If GunaAdvenceButton9.Checked = True Then
            GunaAdvenceButton9.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = True
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("SNC631")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        If GunaAdvenceButton8.Checked = True Then
            GunaAdvenceButton8.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = True
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("SNCM439")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        If GunaAdvenceButton7.Checked = True Then
            GunaAdvenceButton7.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = True
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("SNCM447")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        If GunaAdvenceButton6.Checked = True Then
            GunaAdvenceButton6.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = True
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("SS400")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton15_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton15.Click
        If GunaAdvenceButton15.Checked = True Then
            GunaAdvenceButton15.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
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
            GunaAdvenceButton15.Checked = True
            getDbChar("SUJ2")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton14_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton14.Click
        If GunaAdvenceButton14.Checked = True Then
            GunaAdvenceButton14.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
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
            GunaAdvenceButton14.Checked = True
            GunaAdvenceButton15.Checked = False
            getDbChar("SUS304")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton13_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton13.Click
        If GunaAdvenceButton13.Checked = True Then
            GunaAdvenceButton13.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
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
            GunaAdvenceButton13.Checked = True
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("FCD500")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton12_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton12.Click
        If GunaAdvenceButton12.Checked = True Then
            GunaAdvenceButton12.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
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
            GunaAdvenceButton12.Checked = True
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("MFGC")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton11_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton11.Click
        If GunaAdvenceButton11.Checked = True Then
            GunaAdvenceButton11.Checked = False
            getDbChar("")
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = True
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            getDbChar("OTHER")
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            Clipboard.SetText(TextBox2.Text)
        Catch ex As Exception
            MessageBox.Show("Result is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Clipboard.Clear()
    End Sub




End Class