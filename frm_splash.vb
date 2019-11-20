Imports System.Deployment.Application
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Diagnostics
Public Class Frm_Splash


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If ProgressBar1.Value = 5 Then
            BackgroundWorker1.RunWorkerAsync()
            BackgroundWorker2.RunWorkerAsync()
            BackgroundWorker3.RunWorkerAsync()
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            SplashScreenTimer.Enabled = True
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
    Overrides Sub Refresh()
        Try
            Lbl_SplashPercentage.Parent = PictureBox1
            Lbl_SplashNotifier.Parent = PictureBox1
            GunaWinCircleProgressIndicator1.Parent = PictureBox1

            MyBase.Hide()
            Dim bitmap As New Bitmap(MyBase.Width, MyBase.Height, PixelFormat.Format32bppArgb)
            Dim graphics As Graphics = Graphics.FromImage(bitmap)
            graphics.CopyFromScreen(MyBase.Location.X, MyBase.Location.Y, 0, 0, MyBase.Size, CopyPixelOperation.SourceCopy)
            bitmap.Save("spls.bin", ImageFormat.Png)
            Me.BackgroundImage = bitmap
            MyBase.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Frm_Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Opacity = 0.0
        SplashScreenTimer.Start()
        Refresh()

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
        LoadMachinePurchasedParts()

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        LoadOutfittingPurchasedParts()
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        LoadStandardParts()
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

    Private Sub Frm_Splash_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Login_Status = "offline"
        Dim pListofProcessess() As Process
        Dim pExcelProcess As Diagnostics.Process
        pListofProcessess = pExcelProcess.GetProcesses
        For Each pExcelProcess In pListofProcessess
            If pExcelProcess.ProcessName.ToUpper = "EXCEL" Then
                pExcelProcess.Kill()
            End If
        Next

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Refresh()
    End Sub

    Dim appeared As Boolean = False
    Private Sub SplashScreenTimer_Tick(sender As Object, e As EventArgs) Handles SplashScreenTimer.Tick
        If Not appeared Then
            Opacity += 0.05
            If Opacity >= 1.0 Then

                SplashScreenTimer.Interval = 100
                appeared = True
                SplashScreenTimer.Enabled = False
            End If
        End If
        If ProgressBar1.Value >= 90 Then

            Opacity -= 0.05
            If Opacity = 0.0 Then
                Me.Hide()
                Frm_Main.Show()
                SplashScreenTimer.Enabled = False
            End If
        End If
    End Sub
End Class