<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitWorkstationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsl_hover = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ts_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmr_time = New System.Windows.Forms.Timer(Me.components)
        Me.tsb_char = New System.Windows.Forms.ToolStripButton()
        Me.tsb_purchase = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Menu
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.SettingsToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginAccountToolStripMenuItem, Me.ExitWorkstationToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoginAccountToolStripMenuItem
        '
        Me.LoginAccountToolStripMenuItem.Name = "LoginAccountToolStripMenuItem"
        Me.LoginAccountToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoginAccountToolStripMenuItem.Text = "Login Account"
        '
        'ExitWorkstationToolStripMenuItem
        '
        Me.ExitWorkstationToolStripMenuItem.Name = "ExitWorkstationToolStripMenuItem"
        Me.ExitWorkstationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitWorkstationToolStripMenuItem.Text = "Exit Workstation"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_hover, Me.ts_time})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 585)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(965, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsl_hover
        '
        Me.tsl_hover.Name = "tsl_hover"
        Me.tsl_hover.Size = New System.Drawing.Size(62, 17)
        Me.tsl_hover.Text = "hover Text"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_char, Me.tsb_purchase})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(965, 97)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ts_time
        '
        Me.ts_time.Name = "ts_time"
        Me.ts_time.Size = New System.Drawing.Size(888, 17)
        Me.ts_time.Spring = True
        Me.ts_time.Text = "ts_time"
        Me.ts_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmr_time
        '
        Me.tmr_time.Enabled = True
        Me.tmr_time.Interval = 1000
        '
        'tsb_char
        '
        Me.tsb_char.AutoSize = False
        Me.tsb_char.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsb_char.Image = CType(resources.GetObject("tsb_char.Image"), System.Drawing.Image)
        Me.tsb_char.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_char.Margin = New System.Windows.Forms.Padding(0)
        Me.tsb_char.Name = "tsb_char"
        Me.tsb_char.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.tsb_char.Size = New System.Drawing.Size(95, 95)
        Me.tsb_char.Text = "WORKSTATION"
        Me.tsb_char.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsb_char.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsb_purchase
        '
        Me.tsb_purchase.AutoSize = False
        Me.tsb_purchase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsb_purchase.Image = CType(resources.GetObject("tsb_purchase.Image"), System.Drawing.Image)
        Me.tsb_purchase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_purchase.Name = "tsb_purchase"
        Me.tsb_purchase.Size = New System.Drawing.Size(95, 95)
        Me.tsb_purchase.Text = "PURCHASED PARTS"
        Me.tsb_purchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsb_purchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 607)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.Text = "KMTI WORKSTATION DESKTOP APPLICATION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitWorkstationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsl_hover As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsb_char As ToolStripButton
    Friend WithEvents tsb_purchase As ToolStripButton
    Friend WithEvents ts_time As ToolStripStatusLabel
    Friend WithEvents tmr_time As Timer
End Class
