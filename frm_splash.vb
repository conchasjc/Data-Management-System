Public Class frm_splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 5 Then
            BackgroundWorker1.RunWorkerAsync()
            BackgroundWorker2.RunWorkerAsync()
        End If
        If ProgressBar1.Value = 100 Then

            Timer1.Stop()
            Me.Hide()

            Frm_Main.Show()

        End If
        Lbl_SplashPercentage.Text = ProgressBar1.Value.ToString + "%"
        If ProgressBar1.Value < 20 Then
            ProgressBar1.Increment(5)
            Lbl_SplashNotifier.Text = "Starting Application"
        ElseIf ProgressBar1.Value < 30 Then
            ProgressBar1.Increment(1)
            Lbl_SplashNotifier.Text = "Connecting Database"
            System.Threading.Thread.Sleep(1000)
        ElseIf ProgressBar1.Value < 60 Then
            ProgressBar1.Increment(1)
            Lbl_SplashNotifier.Text = "Importing ICD Files"
            System.Threading.Thread.Sleep(200)
        ElseIf ProgressBar1.Value < 80 Then
            ProgressBar1.Increment(2)
            Lbl_SplashNotifier.Text = "Importing DLL Files"
            System.Threading.Thread.Sleep(2000)
        ElseIf ProgressBar1.Value < 100 Then
            ProgressBar1.Increment(2)
            Lbl_SplashNotifier.Text = "Application Getting Ready"

        End If

    End Sub

    Private Sub Frm_Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Lbl_SplashNotifier.Text = "Starting Application"
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        loadMachinePurchasedParts()

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        loadOutfittingPurchasedParts()
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork

    End Sub

    Private Sub NotifyIcon3_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon3.DoubleClick
        Frm_Main.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim res = MessageBox.Show("Exit Program?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbYes Then
            Me.Close()
            My.Settings.Login_Status = "offline"
        End If
    End Sub


End Class