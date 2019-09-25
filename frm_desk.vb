Public Class frm_desk
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        CheckForIllegalCrossThreadCalls = False

        GunaWinCircleProgressIndicator1.Visible = True
        Me.Close()
        frm_char.MdiParent = frm_main
        frm_char.Show()


    End Sub

    Private Sub Frm_desk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frm_main.mts_logout.Visible = False
        frm_main.mts_login.Visible = False
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
End Class