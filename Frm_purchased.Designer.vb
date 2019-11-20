<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_purchased
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_purchased))
        Me.pnl_purch = New Guna.UI.WinForms.GunaPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_DownloadAll = New System.Windows.Forms.Button()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDataGridView3 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Btn_QuickDownload = New System.Windows.Forms.Button()
        Me.Btn_PrevFile = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGrid_Parts = New Guna.UI.WinForms.GunaDataGridView()
        Me.DataGrid_Files = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_TextSearch = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Tmr_QuickDownload = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Wrkr_PreviewFile = New System.ComponentModel.BackgroundWorker()
        Me.Tmr_PreviewFile = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_DeletePart = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Worker_Delete = New System.ComponentModel.BackgroundWorker()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.pnl_purch.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GunaDataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid_Parts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid_Files, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_purch
        '
        Me.pnl_purch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnl_purch.Controls.Add(Me.GroupBox1)
        Me.pnl_purch.Controls.Add(Me.GunaPanel3)
        Me.pnl_purch.Controls.Add(Me.GroupBox2)
        Me.pnl_purch.Location = New System.Drawing.Point(212, 78)
        Me.pnl_purch.Name = "pnl_purch"
        Me.pnl_purch.Size = New System.Drawing.Size(1516, 758)
        Me.pnl_purch.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_DownloadAll)
        Me.GroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GroupBox1.Controls.Add(Me.GunaDataGridView3)
        Me.GroupBox1.Location = New System.Drawing.Point(926, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 720)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Btn_DownloadAll
        '
        Me.Btn_DownloadAll.Enabled = False
        Me.Btn_DownloadAll.Location = New System.Drawing.Point(393, 663)
        Me.Btn_DownloadAll.Name = "Btn_DownloadAll"
        Me.Btn_DownloadAll.Size = New System.Drawing.Size(156, 40)
        Me.Btn_DownloadAll.TabIndex = 14
        Me.Btn_DownloadAll.Text = "DOWNLOAD FILES"
        Me.Btn_DownloadAll.UseVisualStyleBackColor = True
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Maroon
        Me.GunaLabel3.Location = New System.Drawing.Point(7, 15)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(163, 37)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "Download List"
        '
        'GunaDataGridView3
        '
        Me.GunaDataGridView3.AllowUserToAddRows = False
        Me.GunaDataGridView3.AllowUserToDeleteRows = False
        Me.GunaDataGridView3.AllowUserToResizeColumns = False
        Me.GunaDataGridView3.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaDataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GunaDataGridView3.BackgroundColor = System.Drawing.Color.SlateGray
        Me.GunaDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.GunaDataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView3.ColumnHeadersHeight = 40
        Me.GunaDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GunaDataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView3.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView3.EnableHeadersVisualStyles = False
        Me.GunaDataGridView3.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GunaDataGridView3.Location = New System.Drawing.Point(14, 93)
        Me.GunaDataGridView3.MultiSelect = False
        Me.GunaDataGridView3.Name = "GunaDataGridView3"
        Me.GunaDataGridView3.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(8)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GunaDataGridView3.RowHeadersVisible = False
        Me.GunaDataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.GunaDataGridView3.RowTemplate.Height = 21
        Me.GunaDataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GunaDataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GunaDataGridView3.Size = New System.Drawing.Size(535, 557)
        Me.GunaDataGridView3.TabIndex = 12
        Me.GunaDataGridView3.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal
        Me.GunaDataGridView3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GunaDataGridView3.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView3.ThemeStyle.BackColor = System.Drawing.Color.SlateGray
        Me.GunaDataGridView3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GunaDataGridView3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.GunaDataGridView3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView3.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GunaDataGridView3.ThemeStyle.HeaderStyle.Height = 40
        Me.GunaDataGridView3.ThemeStyle.ReadOnly = True
        Me.GunaDataGridView3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GunaDataGridView3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView3.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.GunaDataGridView3.ThemeStyle.RowsStyle.Height = 21
        Me.GunaDataGridView3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GunaDataGridView3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.HeaderText = "DOWNLOAD_LIST"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.DarkRed
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1516, 10)
        Me.GunaPanel3.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Btn_QuickDownload)
        Me.GroupBox2.Controls.Add(Me.Btn_PrevFile)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.DataGrid_Parts)
        Me.GroupBox2.Controls.Add(Me.DataGrid_Files)
        Me.GroupBox2.Controls.Add(Me.GunaLabel1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Txt_TextSearch)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(897, 720)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(661, 111)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(131, 16)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "Search All Parts File"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(279, 78)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(195, 19)
        Me.RadioButton2.TabIndex = 21
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Outfitting Purchased Parts"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(44, 78)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(188, 19)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.Text = "Machine Purchased Parts"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Btn_QuickDownload
        '
        Me.Btn_QuickDownload.BackgroundImage = Global.kmtiworkstationvb.My.Resources.Resources.Save_Button_PNG_Transparent_Background
        Me.Btn_QuickDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_QuickDownload.Location = New System.Drawing.Point(825, 285)
        Me.Btn_QuickDownload.Name = "Btn_QuickDownload"
        Me.Btn_QuickDownload.Size = New System.Drawing.Size(51, 49)
        Me.Btn_QuickDownload.TabIndex = 19
        Me.Btn_QuickDownload.UseVisualStyleBackColor = True
        '
        'Btn_PrevFile
        '
        Me.Btn_PrevFile.BackgroundImage = Global.kmtiworkstationvb.My.Resources.Resources.preview
        Me.Btn_PrevFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_PrevFile.Location = New System.Drawing.Point(825, 230)
        Me.Btn_PrevFile.Name = "Btn_PrevFile"
        Me.Btn_PrevFile.Size = New System.Drawing.Size(51, 49)
        Me.Btn_PrevFile.TabIndex = 18
        Me.Btn_PrevFile.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.kmtiworkstationvb.My.Resources.Resources._51iJjNPb07L
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(825, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 49)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGrid_Parts
        '
        Me.DataGrid_Parts.AllowUserToAddRows = False
        Me.DataGrid_Parts.AllowUserToDeleteRows = False
        Me.DataGrid_Parts.AllowUserToResizeColumns = False
        Me.DataGrid_Parts.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.DataGrid_Parts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrid_Parts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_Parts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGrid_Parts.BackgroundColor = System.Drawing.Color.SlateGray
        Me.DataGrid_Parts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid_Parts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGrid_Parts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGrid_Parts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_Parts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrid_Parts.ColumnHeadersHeight = 40
        Me.DataGrid_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_Parts.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGrid_Parts.EnableHeadersVisualStyles = False
        Me.DataGrid_Parts.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGrid_Parts.Location = New System.Drawing.Point(14, 175)
        Me.DataGrid_Parts.MultiSelect = False
        Me.DataGrid_Parts.Name = "DataGrid_Parts"
        Me.DataGrid_Parts.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(8)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_Parts.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGrid_Parts.RowHeadersVisible = False
        Me.DataGrid_Parts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGrid_Parts.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGrid_Parts.RowTemplate.Height = 21
        Me.DataGrid_Parts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGrid_Parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrid_Parts.Size = New System.Drawing.Size(321, 539)
        Me.DataGrid_Parts.TabIndex = 8
        Me.DataGrid_Parts.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal
        Me.DataGrid_Parts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.DataGrid_Parts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGrid_Parts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGrid_Parts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGrid_Parts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGrid_Parts.ThemeStyle.BackColor = System.Drawing.Color.SlateGray
        Me.DataGrid_Parts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGrid_Parts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DataGrid_Parts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGrid_Parts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGrid_Parts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGrid_Parts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrid_Parts.ThemeStyle.HeaderStyle.Height = 40
        Me.DataGrid_Parts.ThemeStyle.ReadOnly = True
        Me.DataGrid_Parts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DataGrid_Parts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGrid_Parts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGrid_Parts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGrid_Parts.ThemeStyle.RowsStyle.Height = 21
        Me.DataGrid_Parts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.DataGrid_Parts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGrid_Files
        '
        Me.DataGrid_Files.AllowUserToAddRows = False
        Me.DataGrid_Files.AllowUserToDeleteRows = False
        Me.DataGrid_Files.AllowUserToResizeColumns = False
        Me.DataGrid_Files.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.DataGrid_Files.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGrid_Files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_Files.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGrid_Files.BackgroundColor = System.Drawing.Color.SlateGray
        Me.DataGrid_Files.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid_Files.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGrid_Files.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGrid_Files.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_Files.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGrid_Files.ColumnHeadersHeight = 40
        Me.DataGrid_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_Files.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGrid_Files.EnableHeadersVisualStyles = False
        Me.DataGrid_Files.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGrid_Files.Location = New System.Drawing.Point(341, 175)
        Me.DataGrid_Files.MultiSelect = False
        Me.DataGrid_Files.Name = "DataGrid_Files"
        Me.DataGrid_Files.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(8)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_Files.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGrid_Files.RowHeadersVisible = False
        Me.DataGrid_Files.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGrid_Files.RowTemplate.Height = 21
        Me.DataGrid_Files.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGrid_Files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrid_Files.Size = New System.Drawing.Size(458, 539)
        Me.DataGrid_Files.TabIndex = 7
        Me.DataGrid_Files.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal
        Me.DataGrid_Files.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.DataGrid_Files.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGrid_Files.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGrid_Files.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGrid_Files.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGrid_Files.ThemeStyle.BackColor = System.Drawing.Color.SlateGray
        Me.DataGrid_Files.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGrid_Files.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.DataGrid_Files.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGrid_Files.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGrid_Files.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGrid_Files.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrid_Files.ThemeStyle.HeaderStyle.Height = 40
        Me.DataGrid_Files.ThemeStyle.ReadOnly = True
        Me.DataGrid_Files.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DataGrid_Files.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGrid_Files.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGrid_Files.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGrid_Files.ThemeStyle.RowsStyle.Height = 21
        Me.DataGrid_Files.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.DataGrid_Files.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.GunaLabel1.Location = New System.Drawing.Point(7, 12)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(225, 37)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "PURCHASED PARTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "SEARCH ITEM:"
        '
        'Txt_TextSearch
        '
        Me.Txt_TextSearch.BaseColor = System.Drawing.Color.White
        Me.Txt_TextSearch.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Txt_TextSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_TextSearch.FocusedBaseColor = System.Drawing.Color.White
        Me.Txt_TextSearch.FocusedBorderColor = System.Drawing.Color.Salmon
        Me.Txt_TextSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Txt_TextSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Txt_TextSearch.Location = New System.Drawing.Point(14, 131)
        Me.Txt_TextSearch.Name = "Txt_TextSearch"
        Me.Txt_TextSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_TextSearch.Size = New System.Drawing.Size(778, 26)
        Me.Txt_TextSearch.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CATEGORY:"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.DarkRed
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1897, 53)
        Me.GunaPanel1.TabIndex = 7
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me.pnl_purch
        '
        'BackgroundWorker1
        '
        '
        'Tmr_QuickDownload
        '
        Me.Tmr_QuickDownload.Interval = 70
        '
        'BackgroundWorker2
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GunaLabel4)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.GunaProgressBar1)
        Me.Panel1.Location = New System.Drawing.Point(771, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 108)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel4.Location = New System.Drawing.Point(156, 64)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(352, 21)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "Downloading File"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GunaLabel4.Visible = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel2.Location = New System.Drawing.Point(39, 64)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(111, 21)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Downloading File"
        '
        'GunaProgressBar1
        '
        Me.GunaProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.GunaProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaProgressBar1.Location = New System.Drawing.Point(43, 29)
        Me.GunaProgressBar1.Name = "GunaProgressBar1"
        Me.GunaProgressBar1.ProgressMaxColor = System.Drawing.Color.LightCoral
        Me.GunaProgressBar1.ProgressMinColor = System.Drawing.Color.Maroon
        Me.GunaProgressBar1.Radius = 5
        Me.GunaProgressBar1.Size = New System.Drawing.Size(465, 22)
        Me.GunaProgressBar1.TabIndex = 0
        '
        'Timer2
        '
        Me.Timer2.Interval = 70
        '
        'Wrkr_PreviewFile
        '
        '
        'Tmr_PreviewFile
        '
        Me.Tmr_PreviewFile.Interval = 60
        '
        'Btn_DeletePart
        '
        Me.Btn_DeletePart.Animated = True
        Me.Btn_DeletePart.AnimationHoverSpeed = 0.07!
        Me.Btn_DeletePart.AnimationSpeed = 0.03!
        Me.Btn_DeletePart.BaseColor = System.Drawing.Color.Maroon
        Me.Btn_DeletePart.BorderColor = System.Drawing.Color.Black
        Me.Btn_DeletePart.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Btn_DeletePart.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btn_DeletePart.CheckedForeColor = System.Drawing.Color.White
        Me.Btn_DeletePart.CheckedImage = CType(resources.GetObject("Btn_DeletePart.CheckedImage"), System.Drawing.Image)
        Me.Btn_DeletePart.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btn_DeletePart.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_DeletePart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_DeletePart.ForeColor = System.Drawing.Color.White
        Me.Btn_DeletePart.Image = Nothing
        Me.Btn_DeletePart.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_DeletePart.LineColor = System.Drawing.Color.Maroon
        Me.Btn_DeletePart.Location = New System.Drawing.Point(30, 275)
        Me.Btn_DeletePart.Name = "Btn_DeletePart"
        Me.Btn_DeletePart.OnHoverBaseColor = System.Drawing.Color.Firebrick
        Me.Btn_DeletePart.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_DeletePart.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_DeletePart.OnHoverImage = Nothing
        Me.Btn_DeletePart.OnHoverLineColor = System.Drawing.Color.Firebrick
        Me.Btn_DeletePart.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_DeletePart.Size = New System.Drawing.Size(167, 90)
        Me.Btn_DeletePart.TabIndex = 13
        Me.Btn_DeletePart.Text = "DELETE PARTS"
        Me.Btn_DeletePart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Btn_DeletePart.Visible = False
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Maroon
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.Maroon
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(30, 167)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Firebrick
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Firebrick
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(167, 90)
        Me.GunaAdvenceButton1.TabIndex = 11
        Me.GunaAdvenceButton1.Text = "ADD PARTS"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RadioButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(520, 78)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(118, 19)
        Me.RadioButton3.TabIndex = 23
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Standard Parts"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Frm_purchased
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1897, 918)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_DeletePart)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.pnl_purch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_purchased"
        Me.Text = "Purchased Parts"
        Me.pnl_purch.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GunaDataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGrid_Parts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid_Files, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_purch As Guna.UI.WinForms.GunaPanel
    Friend WithEvents DataGrid_Files As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents DataGrid_Parts As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaDataGridView3 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_TextSearch As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_QuickDownload As Button
    Friend WithEvents Btn_PrevFile As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Tmr_QuickDownload As Timer
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Btn_DownloadAll As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Wrkr_PreviewFile As System.ComponentModel.BackgroundWorker
    Friend WithEvents Tmr_PreviewFile As Timer
    Friend WithEvents Btn_DeletePart As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Worker_Delete As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadioButton3 As RadioButton
End Class
