<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_char
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.pnl_char = New Guna.UI.WinForms.GunaPanel()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.elps_pnlchar = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.clm_japanese = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_eng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton3 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton4 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton5 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton6 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.pnl_char.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.DarkRed
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(2080, 82)
        Me.GunaPanel1.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.GunaLabel1.Location = New System.Drawing.Point(16, 22)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(238, 37)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "CHARACTER SEARCH"
        '
        'pnl_char
        '
        Me.pnl_char.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnl_char.Controls.Add(Me.GunaDataGridView1)
        Me.pnl_char.Controls.Add(Me.GunaTextBox1)
        Me.pnl_char.Controls.Add(Me.GunaPanel3)
        Me.pnl_char.Controls.Add(Me.GunaLabel1)
        Me.pnl_char.Location = New System.Drawing.Point(12, 101)
        Me.pnl_char.Name = "pnl_char"
        Me.pnl_char.Size = New System.Drawing.Size(811, 425)
        Me.pnl_char.TabIndex = 5
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GunaDataGridView1.ColumnHeadersHeight = 21
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_eng, Me.clm_japanese})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(48, 127)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowTemplate.Height = 21
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(722, 266)
        Me.GunaDataGridView1.TabIndex = 6
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 21
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.GunaTextBox1.BorderSize = 2
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.Salmon
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.Location = New System.Drawing.Point(48, 62)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Radius = 10
        Me.GunaTextBox1.Size = New System.Drawing.Size(722, 41)
        Me.GunaTextBox1.TabIndex = 5
        Me.GunaTextBox1.Text = "GunaTextBox1"
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.DarkRed
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(811, 10)
        Me.GunaPanel3.TabIndex = 4
        '
        'elps_pnlchar
        '
        Me.elps_pnlchar.Radius = 5
        Me.elps_pnlchar.TargetControl = Me.pnl_char
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GunaPanel2.Controls.Add(Me.GunaLabel5)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel4)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel2.Controls.Add(Me.GunaCircleButton6)
        Me.GunaPanel2.Controls.Add(Me.GunaCircleButton5)
        Me.GunaPanel2.Controls.Add(Me.GunaCircleButton4)
        Me.GunaPanel2.Controls.Add(Me.GunaCircleButton3)
        Me.GunaPanel2.Controls.Add(Me.GunaCircleButton2)
        Me.GunaPanel2.Controls.Add(Me.GunaCircleButton1)
        Me.GunaPanel2.Controls.Add(Me.GunaPanel4)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel2.Location = New System.Drawing.Point(849, 101)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(448, 283)
        Me.GunaPanel2.TabIndex = 6
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.DarkRed
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(448, 10)
        Me.GunaPanel4.TabIndex = 4
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Maroon
        Me.GunaLabel2.Location = New System.Drawing.Point(16, 22)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(141, 37)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "TEMPLATES"
        '
        'clm_japanese
        '
        Me.clm_japanese.HeaderText = "JAPANESE"
        Me.clm_japanese.Name = "clm_japanese"
        '
        'clm_eng
        '
        Me.clm_eng.HeaderText = "ENGLISH"
        Me.clm_eng.Name = "clm_eng"
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.Animated = True
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(42, 93)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(89, 84)
        Me.GunaCircleButton1.TabIndex = 5
        Me.GunaCircleButton1.Text = "φ×-"
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.Animated = True
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = Nothing
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(182, 93)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.Size = New System.Drawing.Size(89, 84)
        Me.GunaCircleButton2.TabIndex = 6
        Me.GunaCircleButton2.Text = "□×"
        '
        'GunaCircleButton3
        '
        Me.GunaCircleButton3.Animated = True
        Me.GunaCircleButton3.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton3.AnimationSpeed = 0.03!
        Me.GunaCircleButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton3.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton3.Image = Nothing
        Me.GunaCircleButton3.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton3.Location = New System.Drawing.Point(321, 93)
        Me.GunaCircleButton3.Name = "GunaCircleButton3"
        Me.GunaCircleButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton3.OnHoverImage = Nothing
        Me.GunaCircleButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.Size = New System.Drawing.Size(89, 84)
        Me.GunaCircleButton3.TabIndex = 7
        Me.GunaCircleButton3.Text = "××"
        '
        'GunaCircleButton4
        '
        Me.GunaCircleButton4.Animated = True
        Me.GunaCircleButton4.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton4.AnimationSpeed = 0.03!
        Me.GunaCircleButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton4.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton4.Image = Nothing
        Me.GunaCircleButton4.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton4.Location = New System.Drawing.Point(42, 183)
        Me.GunaCircleButton4.Name = "GunaCircleButton4"
        Me.GunaCircleButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton4.OnHoverImage = Nothing
        Me.GunaCircleButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton4.Size = New System.Drawing.Size(89, 84)
        Me.GunaCircleButton4.TabIndex = 8
        Me.GunaCircleButton4.Text = "××-"
        '
        'GunaCircleButton5
        '
        Me.GunaCircleButton5.Animated = True
        Me.GunaCircleButton5.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton5.AnimationSpeed = 0.03!
        Me.GunaCircleButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton5.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton5.Image = Nothing
        Me.GunaCircleButton5.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton5.Location = New System.Drawing.Point(182, 183)
        Me.GunaCircleButton5.Name = "GunaCircleButton5"
        Me.GunaCircleButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton5.OnHoverImage = Nothing
        Me.GunaCircleButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton5.Size = New System.Drawing.Size(89, 84)
        Me.GunaCircleButton5.TabIndex = 9
        Me.GunaCircleButton5.Text = "φ×"
        '
        'GunaCircleButton6
        '
        Me.GunaCircleButton6.Animated = True
        Me.GunaCircleButton6.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton6.AnimationSpeed = 0.03!
        Me.GunaCircleButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton6.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton6.Image = Nothing
        Me.GunaCircleButton6.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton6.Location = New System.Drawing.Point(321, 183)
        Me.GunaCircleButton6.Name = "GunaCircleButton6"
        Me.GunaCircleButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton6.OnHoverImage = Nothing
        Me.GunaCircleButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton6.Size = New System.Drawing.Size(89, 84)
        Me.GunaCircleButton6.TabIndex = 10
        Me.GunaCircleButton6.Text = "×φ"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(42, 62)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(89, 20)
        Me.GunaLabel3.TabIndex = 11
        Me.GunaLabel3.Text = "PIPE"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(182, 62)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(89, 14)
        Me.GunaLabel4.TabIndex = 12
        Me.GunaLabel4.Text = "BAR"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel5
        '
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(321, 62)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(89, 14)
        Me.GunaLabel5.TabIndex = 13
        Me.GunaLabel5.Text = "PLATE"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_char
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(2080, 921)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.pnl_char)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_char"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Station"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_char.ResumeLayout(False)
        Me.pnl_char.PerformLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pnl_char As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents elps_pnlchar As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents clm_eng As DataGridViewTextBoxColumn
    Friend WithEvents clm_japanese As DataGridViewTextBoxColumn
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton6 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton5 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton4 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton3 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
