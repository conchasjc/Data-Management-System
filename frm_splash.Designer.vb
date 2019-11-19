<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Splash))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Lbl_SplashNotifier = New System.Windows.Forms.Label()
        Me.Lbl_SplashPercentage = New System.Windows.Forms.Label()
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.NotifyIcon3 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Cms_Notify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMenu_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SplashScreenTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cms_Notify.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(49, 455)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(777, 24)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Lbl_SplashNotifier
        '
        Me.Lbl_SplashNotifier.AutoSize = True
        Me.Lbl_SplashNotifier.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SplashNotifier.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Lbl_SplashNotifier.ForeColor = System.Drawing.Color.White
        Me.Lbl_SplashNotifier.Location = New System.Drawing.Point(55, 267)
        Me.Lbl_SplashNotifier.Name = "Lbl_SplashNotifier"
        Me.Lbl_SplashNotifier.Size = New System.Drawing.Size(138, 16)
        Me.Lbl_SplashNotifier.TabIndex = 2
        Me.Lbl_SplashNotifier.Text = "LOADINGCAPTION"
        '
        'Lbl_SplashPercentage
        '
        Me.Lbl_SplashPercentage.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SplashPercentage.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Lbl_SplashPercentage.ForeColor = System.Drawing.Color.White
        Me.Lbl_SplashPercentage.Location = New System.Drawing.Point(363, 265)
        Me.Lbl_SplashPercentage.Name = "Lbl_SplashPercentage"
        Me.Lbl_SplashPercentage.Size = New System.Drawing.Size(51, 21)
        Me.Lbl_SplashPercentage.TabIndex = 3
        Me.Lbl_SplashPercentage.Text = "0%"
        Me.Lbl_SplashPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.BackColor = System.Drawing.Color.Transparent
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(27, 261)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.Yellow
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(26, 26)
        Me.GunaWinCircleProgressIndicator1.TabIndex = 4
        '
        'BackgroundWorker3
        '
        '
        'NotifyIcon3
        '
        Me.NotifyIcon3.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon3.BalloonTipTitle = "KMTI DATA  MANAGEMENT SYSTEM"
        Me.NotifyIcon3.ContextMenuStrip = Me.Cms_Notify
        Me.NotifyIcon3.Icon = CType(resources.GetObject("NotifyIcon3.Icon"), System.Drawing.Icon)
        Me.NotifyIcon3.Text = "KMTI DATA MANAGEMENT SYSTEM"
        '
        'Cms_Notify
        '
        Me.Cms_Notify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMenu_Logout, Me.TSMenu_Login, Me.ExitToolStripMenuItem1})
        Me.Cms_Notify.Name = "cms_notify"
        Me.Cms_Notify.Size = New System.Drawing.Size(161, 70)
        '
        'TSMenu_Logout
        '
        Me.TSMenu_Logout.Name = "TSMenu_Logout"
        Me.TSMenu_Logout.Size = New System.Drawing.Size(160, 22)
        Me.TSMenu_Logout.Text = "Logout Account"
        Me.TSMenu_Logout.Visible = False
        '
        'TSMenu_Login
        '
        Me.TSMenu_Login.Name = "TSMenu_Login"
        Me.TSMenu_Login.Size = New System.Drawing.Size(160, 22)
        Me.TSMenu_Login.Text = "Login Account"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'SplashScreenTimer
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.kmtiworkstationvb.My.Resources.Resources.othersplash1
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(840, 372)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Frm_Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 372)
        Me.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.Controls.Add(Me.Lbl_SplashNotifier)
        Me.Controls.Add(Me.Lbl_SplashPercentage)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_splash"
        Me.Cms_Notify.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Lbl_SplashNotifier As Label
    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents NotifyIcon3 As NotifyIcon
    Friend WithEvents Cms_Notify As ContextMenuStrip
    Friend WithEvents TSMenu_Logout As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TSMenu_Login As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_SplashPercentage As Label
    Friend WithEvents SplashScreenTimer As Timer
End Class
