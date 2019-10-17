<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splash))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Lbl_SplashNotifier = New System.Windows.Forms.Label()
        Me.Lbl_SplashPercentage = New System.Windows.Forms.Label()
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.NotifyIcon3 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Cms_Notify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MaximizedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cms_Notify.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 351)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(777, 24)
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
        Me.Lbl_SplashNotifier.Location = New System.Drawing.Point(43, 387)
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
        Me.Lbl_SplashPercentage.Location = New System.Drawing.Point(364, 387)
        Me.Lbl_SplashPercentage.Name = "Lbl_SplashPercentage"
        Me.Lbl_SplashPercentage.Size = New System.Drawing.Size(401, 19)
        Me.Lbl_SplashPercentage.TabIndex = 3
        Me.Lbl_SplashPercentage.Text = "0%"
        Me.Lbl_SplashPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.BackColor = System.Drawing.Color.Transparent
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(9, 378)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.Yellow
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(28, 34)
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
        Me.Cms_Notify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaximizedToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.Cms_Notify.Name = "cms_notify"
        Me.Cms_Notify.Size = New System.Drawing.Size(181, 70)
        '
        'MaximizedToolStripMenuItem
        '
        Me.MaximizedToolStripMenuItem.Name = "MaximizedToolStripMenuItem"
        Me.MaximizedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MaximizedToolStripMenuItem.Text = "Maximized"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'frm_splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.kmtiworkstationvb.My.Resources.Resources.Untitled_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(777, 416)
        Me.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.Controls.Add(Me.Lbl_SplashPercentage)
        Me.Controls.Add(Me.Lbl_SplashNotifier)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_splash"
        Me.Cms_Notify.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Lbl_SplashNotifier As Label
    Friend WithEvents Lbl_SplashPercentage As Label
    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents NotifyIcon3 As NotifyIcon
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Cms_Notify As ContextMenuStrip
    Friend WithEvents MaximizedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
