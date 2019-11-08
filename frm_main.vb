Imports System.ComponentModel
Imports System.Threading
Public Class Frm_Main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        If My.Settings.Login_Status = "offline" Then
            Frm_Desk.MdiParent = Me
            Frm_Desk.Show()
            Frm_Char.Close()
        Else
            If My.Settings.accPriv = "userAccount" Then
                UserPriv()
                Frm_Char.MdiParent = Me
                Frm_Char.Show()
            ElseIf My.Settings.accPriv = "adminAccount" Then
                AdminPriv()
                Frm_Char.MdiParent = Me
                Frm_Char.Show()
            End If

        End If
        Tsl_Hover.Text = ""
        Tsb_Char.Text = "Work" + vbNewLine + "Station"
        Tsb_Purchase.Text = "Purchased" + vbNewLine + "Parts"
        If (Not System.IO.Directory.Exists(My.Application.Info.DirectoryPath + "/Temp")) Then
            System.IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath + "/Temp")

        End If
        If (My.Settings.sett_autoDel = True And System.IO.Directory.Exists(My.Settings.sett_locpath + "/DownloadedParts")) Then
            Try
                System.IO.Directory.Delete(My.Settings.sett_locpath + "/DownloadedParts", True)
            Catch ex As Exception
            End Try
        End If
        If (Not System.IO.Directory.Exists(My.Settings.sett_locpath + "/DownloadedParts")) Then
            System.IO.Directory.CreateDirectory(My.Settings.sett_locpath + "/DownloadedParts")
        End If
        frm_splash.NotifyIcon3.Visible = False
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frm_settings.Show()
    End Sub

    Private Sub Tmr_time_Tick(sender As Object, e As EventArgs) Handles Tmr_Time.Tick

        Ts_Time.Text = Now.ToLongTimeString + " " + Now.ToLongDateString

    End Sub

    Private Sub Tsb_char_Click(sender As Object, e As EventArgs) Handles Tsb_Char.Click

        Frm_Char.MdiParent = Me
        Frm_Char.Show()

        Tsb_Char.CheckState = CheckState.Checked
        Tsb_Purchase.CheckState = CheckState.Unchecked
    End Sub

    Private Sub LoginAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mts_Logout.Click
        Frm_Char.Close()
        Frm_Desk.MdiParent = Me
        Frm_Desk.Show()
        My.Settings.Login_Status = "offline"
        frm_splash.TSMenu_Login.Visible = True
        frm_splash.TSMenu_Logout.Visible = False
    End Sub


    Private Sub Tsb_purchase_Click(sender As Object, e As EventArgs) Handles Tsb_Purchase.Click
        Frm_Char.Close()
        Frm_purchased.MdiParent = Me
        Frm_purchased.Show()
        Frm_purchased.WindowState = FormWindowState.Maximized
        Tsb_Purchase.CheckState = CheckState.Checked
        Tsb_Char.CheckState = CheckState.Unchecked
    End Sub




    Private Sub Frm_Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If (System.IO.Directory.Exists(My.Application.Info.DirectoryPath + "/Temp")) Then
            System.IO.Directory.Delete(My.Application.Info.DirectoryPath + "/Temp", True)
        End If
        frm_splash.NotifyIcon3.Visible = True


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        System.Diagnostics.Process.Start(My.Settings.sett_actpath)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Dim rm As Resources.ResourceManager
        rm = New Resources.ResourceManager("kmtiworkstationvb.Resources", System.Reflection.Assembly.GetExecutingAssembly)
        Dim b As Byte()
        b = rm.GetObject("User_s_Manual")
        System.IO.File.WriteAllBytes(My.Application.Info.DirectoryPath + "/User-s-Manual.chm", b)
        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath + "/User-s-Manual.chm")
    End Sub


End Class
