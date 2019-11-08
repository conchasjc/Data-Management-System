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
            System.Threading.Thread.Sleep(100)
        ElseIf ProgressBar1.Value < 60 Then
            ProgressBar1.Increment(1)
            Lbl_SplashNotifier.Text = "Importing ICD Files"
            System.Threading.Thread.Sleep(200)
        ElseIf ProgressBar1.Value < 80 Then
            ProgressBar1.Increment(2)
            Lbl_SplashNotifier.Text = "Importing DLL Files"
            System.Threading.Thread.Sleep(50)
        ElseIf ProgressBar1.Value < 100 Then
            ProgressBar1.Increment(2)
            Lbl_SplashNotifier.Text = "Application Getting Ready"

        End If

    End Sub

    Private Sub Frm_Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.settings_notSet = True Then
            Me.Hide()
            Dim res = MessageBox.Show("Database Not Connected,Connect Now?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If res = vbYes Then
                frm_settings.Show()
            Else
                Me.Close()
            End If
        Else
                Timer1.Start()
            Lbl_SplashNotifier.Text = "Starting Application"
        End If
        Timer2.Enabled = True
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

    Private Sub MaximizedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSMenu_Logout.Click
        Frm_Main.Mts_Logout.PerformClick()
        TSMenu_Logout.Visible = False
        TSMenu_Login.Visible = True
    End Sub

    Private Sub TSMenu_Login_Click(sender As Object, e As EventArgs) Handles TSMenu_Login.Click
        Frm_Main.Show()

    End Sub

    Private Sub frm_splash_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myProcesses As Process() = Process.GetProcessesByName("ApplicationName")
                Dim myProcess As Process
                For Each myProcess In myProcesses
                    SetProcessWorkingSetSize(myProcess.Handle, -1, -1)
                Next myProcess
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_splash_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Login_Status = "offline"
        Dim pListofProcessess() As Process
        Dim pExcelProcess As System.Diagnostics.Process
        pListofProcessess = pExcelProcess.GetProcesses
        For Each pExcelProcess In pListofProcessess
            If pExcelProcess.ProcessName.ToUpper = "EXCEL" Then
                pExcelProcess.Kill()
            End If
        Next

    End Sub
End Class