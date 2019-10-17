Public Class frm_desk
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        CheckForIllegalCrossThreadCalls = False

        GunaWinCircleProgressIndicator1.Visible = True
        BackgroundWorker2.RunWorkerAsync()

        If Txt_User.Text = "User" And Txt_Pass.Text = "1234" Then
            MessageBox.Show("Login Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frm_char.MdiParent = Frm_Main
            frm_char.Show()

        Else
            Txt_Pass.Text = ""
            Txt_User.Text = ""

            MessageBox.Show("Invalid User Account", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Frm_desk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Frm_Main.Mts_Logout.Visible = False
        Frm_Main.Mts_Login.Visible = False
        BackgroundWorker1.RunWorkerAsync()


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        getDbConnect()
    End Sub

    Private Sub Tmr_connStatus_Tick(sender As Object, e As EventArgs) Handles tmr_connStatus.Tick


        If My.Settings.dbConnected = True Then
            GunaCirclePictureBox1.BaseColor = Color.Green
            lbl_dbNotif.Text = "DATABASE CONNECTED"
        Else
            GunaCirclePictureBox1.BaseColor = Color.Red
            lbl_dbNotif.Text = "DATABASE NOT CONNECTED"
        End If
    End Sub



    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        System.Threading.Thread.Sleep(100)

    End Sub


End Class