Public Class frm_settings




    Private Sub Frm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pnl_database.Visible = True Then
            lbl_dtbase.ForeColor = Color.Gold
            lbl_dtbase.Font = New Font("Century Gothic", 22, FontStyle.Bold)
        End If
        pnl_purchSett.Visible = False
        pnl_database.Visible = True
        pnl_database.Dock = DockStyle.Fill
        btn_save.Enabled = False
        Txt_ActionPath.Text = My.Settings.sett_actpath
        Txt_DownPath.Text = My.Settings.sett_locpath
        If My.Settings.sett_autoDel = True Then
            GunaCheckBox2.Checked = True
        Else
            GunaCheckBox2.Checked = False
        End If
        Me.TopMost = True
        Frm_Main.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        My.Settings.sett_dbSource = txt_dbSource.Text
        My.Settings.sett_dbName = txt_dbName.Text
        My.Settings.sett_dbUsername = txt_dbUsername.Text
        My.Settings.sett_dbPass = txt_dbPassword.Text
        My.Settings.settings_notSet = False
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        Dim test As New Database
        test.TestConnect()
    End Sub




    Private Sub Lbl_dtbase_Click(sender As Object, e As EventArgs) Handles lbl_dtbase.Click
        lbl_dtbase.ForeColor = Color.Gold
        lbl_dtbase.Font = New Font("Century Gothic", 22, FontStyle.Bold)
        lbl_purch.ForeColor = Color.White
        lbl_purch.Font = New Font("Century Gothic", 18, FontStyle.Regular)
        pnl_purchSett.Visible = False
        pnl_database.Visible = True
        pnl_database.Dock = DockStyle.Fill
    End Sub

    Private Sub Lbl_purch_Click(sender As Object, e As EventArgs) Handles lbl_purch.Click
        lbl_purch.ForeColor = Color.Gold
        lbl_purch.Font = New Font("Century Gothic", 22, FontStyle.Bold)
        lbl_dtbase.ForeColor = Color.White
        lbl_dtbase.Font = New Font("Century Gothic", 18, FontStyle.Regular)
        pnl_purchSett.Visible = True
        pnl_database.Visible = False
        pnl_purchSett.Dock = DockStyle.Fill
    End Sub



    Private Sub Pb_showeye_Click(sender As Object, e As EventArgs) Handles pb_showeye.Click
        PictureBox2.Visible = True
        txt_dbPassword.PasswordChar = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
        txt_dbPassword.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            Txt_DownPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        OpenFileDialog1.Filter = "ICAD FIND ACTION | *.exe"
        OpenFileDialog1.FileName = "FindAction"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Txt_ActionPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dialogResult = MessageBox.Show("Apply Changes?", "Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            My.Settings.sett_actpath = Txt_ActionPath.Text
            My.Settings.sett_locpath = Txt_DownPath.Text
            If GunaCheckBox2.Checked Then
                My.Settings.sett_autoDel = True
            Else
                My.Settings.sett_autoDel = False
            End If
            My.Settings.settings_notSet = False
            My.Settings.Save()
            MessageBox.Show("Settings Applied Successfully.", "Settings Applied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Application.Restart()
        End If

    End Sub

    Private Sub Frm_settings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_Main.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Reset()

    End Sub
End Class