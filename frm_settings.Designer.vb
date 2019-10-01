<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_settings
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_purch = New System.Windows.Forms.Label()
        Me.lbl_dtbase = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_database = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pb_showeye = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_dbPassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_dbUsername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_dbName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dbSource = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnl_database.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_showeye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.DarkRed
        Me.GunaPanel1.Controls.Add(Me.lbl_purch)
        Me.GunaPanel1.Controls.Add(Me.lbl_dtbase)
        Me.GunaPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(310, 632)
        Me.GunaPanel1.TabIndex = 0
        '
        'lbl_purch
        '
        Me.lbl_purch.AutoSize = True
        Me.lbl_purch.BackColor = System.Drawing.Color.Transparent
        Me.lbl_purch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_purch.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_purch.ForeColor = System.Drawing.Color.White
        Me.lbl_purch.Location = New System.Drawing.Point(56, 234)
        Me.lbl_purch.Name = "lbl_purch"
        Me.lbl_purch.Size = New System.Drawing.Size(200, 30)
        Me.lbl_purch.TabIndex = 4
        Me.lbl_purch.Text = "Purchased Parts"
        '
        'lbl_dtbase
        '
        Me.lbl_dtbase.AutoSize = True
        Me.lbl_dtbase.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dtbase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_dtbase.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dtbase.ForeColor = System.Drawing.Color.White
        Me.lbl_dtbase.Location = New System.Drawing.Point(56, 164)
        Me.lbl_dtbase.Name = "lbl_dtbase"
        Me.lbl_dtbase.Size = New System.Drawing.Size(129, 30)
        Me.lbl_dtbase.TabIndex = 3
        Me.lbl_dtbase.Text = "Database"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.kmtiworkstationvb.My.Resources.Resources.setting
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 78)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Salmon
        Me.Label2.Location = New System.Drawing.Point(91, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SETTINGS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Salmon
        Me.Label1.Location = New System.Drawing.Point(91, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WORKSTATION"
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1039, 6)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.DarkRed
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(30, 30)
        Me.GunaControlBox1.TabIndex = 1
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnl_database)
        Me.Panel1.Location = New System.Drawing.Point(310, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 632)
        Me.Panel1.TabIndex = 2
        '
        'pnl_database
        '
        Me.pnl_database.Controls.Add(Me.PictureBox2)
        Me.pnl_database.Controls.Add(Me.pb_showeye)
        Me.pnl_database.Controls.Add(Me.Button2)
        Me.pnl_database.Controls.Add(Me.txt_dbPassword)
        Me.pnl_database.Controls.Add(Me.Label9)
        Me.pnl_database.Controls.Add(Me.txt_dbUsername)
        Me.pnl_database.Controls.Add(Me.Label8)
        Me.pnl_database.Controls.Add(Me.txt_dbName)
        Me.pnl_database.Controls.Add(Me.Label7)
        Me.pnl_database.Controls.Add(Me.Label6)
        Me.pnl_database.Controls.Add(Me.txt_dbSource)
        Me.pnl_database.Controls.Add(Me.Label5)
        Me.pnl_database.Controls.Add(Me.Label4)
        Me.pnl_database.Controls.Add(Me.GunaLinePanel1)
        Me.pnl_database.Controls.Add(Me.Button1)
        Me.pnl_database.Controls.Add(Me.Label3)
        Me.pnl_database.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnl_database.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_database.Location = New System.Drawing.Point(0, 0)
        Me.pnl_database.Name = "pnl_database"
        Me.pnl_database.Size = New System.Drawing.Size(764, 632)
        Me.pnl_database.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.kmtiworkstationvb.My.Resources.Resources.view
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(497, 460)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'pb_showeye
        '
        Me.pb_showeye.BackgroundImage = Global.kmtiworkstationvb.My.Resources.Resources.view_png_image_6
        Me.pb_showeye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_showeye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_showeye.Location = New System.Drawing.Point(497, 460)
        Me.pb_showeye.Name = "pb_showeye"
        Me.pb_showeye.Size = New System.Drawing.Size(33, 32)
        Me.pb_showeye.TabIndex = 14
        Me.pb_showeye.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 566)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 41)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Test Connection"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_dbPassword
        '
        Me.txt_dbPassword.BackColor = System.Drawing.Color.White
        Me.txt_dbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_dbPassword.FocusedLineColor = System.Drawing.Color.LightCoral
        Me.txt_dbPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_dbPassword.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_dbPassword.Location = New System.Drawing.Point(49, 460)
        Me.txt_dbPassword.Name = "txt_dbPassword"
        Me.txt_dbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_dbPassword.Size = New System.Drawing.Size(442, 32)
        Me.txt_dbPassword.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 438)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Password"
        '
        'txt_dbUsername
        '
        Me.txt_dbUsername.BackColor = System.Drawing.Color.White
        Me.txt_dbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_dbUsername.FocusedLineColor = System.Drawing.Color.LightCoral
        Me.txt_dbUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_dbUsername.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_dbUsername.Location = New System.Drawing.Point(49, 366)
        Me.txt_dbUsername.Name = "txt_dbUsername"
        Me.txt_dbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_dbUsername.Size = New System.Drawing.Size(442, 32)
        Me.txt_dbUsername.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Username"
        '
        'txt_dbName
        '
        Me.txt_dbName.BackColor = System.Drawing.Color.White
        Me.txt_dbName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_dbName.FocusedLineColor = System.Drawing.Color.LightCoral
        Me.txt_dbName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_dbName.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_dbName.Location = New System.Drawing.Point(49, 278)
        Me.txt_dbName.Name = "txt_dbName"
        Me.txt_dbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_dbName.Size = New System.Drawing.Size(442, 32)
        Me.txt_dbName.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Database Name"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "(Eg. Localhost / Server Ip Address)"
        '
        'txt_dbSource
        '
        Me.txt_dbSource.BackColor = System.Drawing.Color.White
        Me.txt_dbSource.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_dbSource.FocusedLineColor = System.Drawing.Color.LightCoral
        Me.txt_dbSource.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_dbSource.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_dbSource.Location = New System.Drawing.Point(49, 197)
        Me.txt_dbSource.Name = "txt_dbSource"
        Me.txt_dbSource.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_dbSource.Size = New System.Drawing.Size(442, 32)
        Me.txt_dbSource.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DataSource"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(605, 43)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "These is the database connection settings. Please enter the following information" &
    " needed below for the connection request in the server."
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.SeaGreen
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(36, 47)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(5, 37)
        Me.GunaLinePanel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(580, 566)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SAVE SETTINGS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(455, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "DATABASE CONNECTION"
        '
        'frm_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 632)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_settings"
        Me.TopMost = True
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnl_database.ResumeLayout(False)
        Me.pnl_database.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_showeye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_dtbase As Label
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_database As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_dbSource As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents txt_dbPassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_dbUsername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_dbName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_purch As Label
    Friend WithEvents pb_showeye As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
