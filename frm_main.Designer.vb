<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.Mst_Main = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mts_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mts_Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MdilistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Tsl_Hover = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Ts_Time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Ts_Menubar = New System.Windows.Forms.ToolStrip()
        Me.Tsb_Char = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tsb_Purchase = New System.Windows.Forms.ToolStripButton()
        Me.Tmr_Time = New System.Windows.Forms.Timer(Me.components)
        Me.TimeWorker = New System.ComponentModel.BackgroundWorker()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Cms_Notify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MaximizedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mst_Main.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Ts_Menubar.SuspendLayout()
        Me.Cms_Notify.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mst_Main
        '
        Me.Mst_Main.BackColor = System.Drawing.SystemColors.Menu
        Me.Mst_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.MdilistToolStripMenuItem})
        Me.Mst_Main.Location = New System.Drawing.Point(0, 0)
        Me.Mst_Main.MdiWindowListItem = Me.MdilistToolStripMenuItem
        Me.Mst_Main.Name = "Mst_Main"
        Me.Mst_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Mst_Main.Size = New System.Drawing.Size(965, 24)
        Me.Mst_Main.TabIndex = 1
        Me.Mst_Main.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mts_Logout, Me.Mts_Login, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'Mts_Logout
        '
        Me.Mts_Logout.Name = "Mts_Logout"
        Me.Mts_Logout.Size = New System.Drawing.Size(180, 22)
        Me.Mts_Logout.Text = "Logout Account"
        '
        'Mts_Login
        '
        Me.Mts_Login.Name = "Mts_Login"
        Me.Mts_Login.Size = New System.Drawing.Size(180, 22)
        Me.Mts_Login.Text = "Login Account"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'MdilistToolStripMenuItem
        '
        Me.MdilistToolStripMenuItem.Name = "MdilistToolStripMenuItem"
        Me.MdilistToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MdilistToolStripMenuItem.Text = "mdilist"
        Me.MdilistToolStripMenuItem.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsl_Hover, Me.Ts_Time})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 585)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(965, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Tsl_Hover
        '
        Me.Tsl_Hover.Name = "Tsl_Hover"
        Me.Tsl_Hover.Size = New System.Drawing.Size(62, 17)
        Me.Tsl_Hover.Text = "hover Text"
        '
        'Ts_Time
        '
        Me.Ts_Time.Name = "Ts_Time"
        Me.Ts_Time.Size = New System.Drawing.Size(888, 17)
        Me.Ts_Time.Spring = True
        Me.Ts_Time.Text = "ts_time"
        Me.Ts_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ts_Menubar
        '
        Me.Ts_Menubar.AutoSize = False
        Me.Ts_Menubar.BackColor = System.Drawing.SystemColors.Control
        Me.Ts_Menubar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ts_Menubar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Ts_Menubar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsb_Char, Me.ToolStripSeparator1, Me.Tsb_Purchase})
        Me.Ts_Menubar.Location = New System.Drawing.Point(0, 24)
        Me.Ts_Menubar.Name = "Ts_Menubar"
        Me.Ts_Menubar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Ts_Menubar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Ts_Menubar.Size = New System.Drawing.Size(965, 97)
        Me.Ts_Menubar.TabIndex = 3
        Me.Ts_Menubar.Text = "ToolStrip1"
        '
        'Tsb_Char
        '
        Me.Tsb_Char.AutoSize = False
        Me.Tsb_Char.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tsb_Char.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tsb_Char.Image = Global.kmtiworkstationvb.My.Resources.Resources.iconws2
        Me.Tsb_Char.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tsb_Char.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tsb_Char.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Tsb_Char.Name = "Tsb_Char"
        Me.Tsb_Char.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.Tsb_Char.Size = New System.Drawing.Size(95, 95)
        Me.Tsb_Char.Text = "WORKSTATION"
        Me.Tsb_Char.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tsb_Char.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 97)
        '
        'Tsb_Purchase
        '
        Me.Tsb_Purchase.AutoSize = False
        Me.Tsb_Purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Tsb_Purchase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tsb_Purchase.Image = Global.kmtiworkstationvb.My.Resources.Resources.purchparticon2
        Me.Tsb_Purchase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tsb_Purchase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tsb_Purchase.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.Tsb_Purchase.Name = "Tsb_Purchase"
        Me.Tsb_Purchase.Size = New System.Drawing.Size(95, 95)
        Me.Tsb_Purchase.Text = "PURCHASED PARTS"
        Me.Tsb_Purchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tsb_Purchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tmr_Time
        '
        Me.Tmr_Time.Enabled = True
        Me.Tmr_Time.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "I am running minimized"
        Me.NotifyIcon1.BalloonTipTitle = "KMTI DATA  MANAGEMENT SYSTEM"
        Me.NotifyIcon1.ContextMenuStrip = Me.Cms_Notify
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "KMTI DATA MANAGEMENT SYSTEM"
        '
        'Cms_Notify
        '
        Me.Cms_Notify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaximizedToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.Cms_Notify.Name = "cms_notify"
        Me.Cms_Notify.Size = New System.Drawing.Size(132, 48)
        '
        'MaximizedToolStripMenuItem
        '
        Me.MaximizedToolStripMenuItem.Name = "MaximizedToolStripMenuItem"
        Me.MaximizedToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.MaximizedToolStripMenuItem.Text = "Maximized"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 607)
        Me.Controls.Add(Me.Ts_Menubar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Mst_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Mst_Main
        Me.Name = "Frm_Main"
        Me.Text = "KMTI DATA MANAGEMENT SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Mst_Main.ResumeLayout(False)
        Me.Mst_Main.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Ts_Menubar.ResumeLayout(False)
        Me.Ts_Menubar.PerformLayout()
        Me.Cms_Notify.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mst_Main As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Mts_Logout As ToolStripMenuItem
    Friend WithEvents Mts_Login As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Tsl_Hover As ToolStripStatusLabel
    Friend WithEvents Ts_Menubar As ToolStrip
    Friend WithEvents Tsb_Char As ToolStripButton
    Friend WithEvents Ts_Time As ToolStripStatusLabel
    Friend WithEvents Tmr_Time As Timer
    Friend WithEvents MdilistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tsb_Purchase As ToolStripButton
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Cms_Notify As ContextMenuStrip
    Friend WithEvents MaximizedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
