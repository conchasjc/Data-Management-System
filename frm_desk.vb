Public Class frm_desk
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        CheckForIllegalCrossThreadCalls = False

        GunaWinCircleProgressIndicator1.Visible = True


        If Txt_User.Text = "User" And Txt_Pass.Text = "1234" Then
            MessageBox.Show("Login Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frm_char.MdiParent = Frm_Main
            frm_char.Show()
            My.Settings.Login_Status = "online"
            frm_splash.TSMenu_Login.Visible = False
            frm_splash.TSMenu_Logout.Visible = True
        ElseIf Txt_User.Text = "Admin" And Txt_Pass.Text = "12345" Then
            MessageBox.Show("Login Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Frm_Char.MdiParent = Frm_Main
            Frm_Char.Show()
            My.Settings.Login_Status = "online"
            frm_splash.TSMenu_Login.Visible = False
            frm_splash.TSMenu_Logout.Visible = True
        Else
            Txt_Pass.Text = ""
            Txt_User.Text = ""
            Txt_User.Focus()
            System.Threading.Thread.Sleep(1000)
            MessageBox.Show("Invalid User Account", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            GunaWinCircleProgressIndicator1.Visible = False
        End If
    End Sub

    Private Sub Frm_desk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Frm_Main.Mts_Logout.Visible = False
        Frm_Main.Mts_Login.Visible = False
        BackgroundWorker1.RunWorkerAsync()

        Frm_Main.ToolStripMenuItem1.Visible = False
        Frm_Main.Tsb_Char.Enabled = False
        Frm_Main.Tsb_Purchase.Enabled = False
        Me.KeyPreview = True
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

    Private Sub frm_desk_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            GunaAdvenceButton1.PerformClick()
        End If
    End Sub

    Private Sub GunaWinCircleProgressIndicator1_Load(sender As Object, e As EventArgs) Handles GunaWinCircleProgressIndicator1.Load

    End Sub
End Class