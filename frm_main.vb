Imports System.ComponentModel
Imports System.Threading
Public Class Frm_Main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        frm_desk.MdiParent = Me
        frm_desk.Show()
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


    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frm_settings.Show()
    End Sub

    Private Sub Tmr_time_Tick(sender As Object, e As EventArgs) Handles Tmr_Time.Tick

        Ts_Time.Text = Now.ToLongTimeString + " " + Now.ToLongDateString

    End Sub

    Private Sub Tsb_char_Click(sender As Object, e As EventArgs) Handles Tsb_Char.Click
        frm_char.MdiParent = Me
        frm_char.Show()

        Tsb_Char.CheckState = CheckState.Checked
        Tsb_Purchase.CheckState = CheckState.Unchecked
    End Sub

    Private Sub LoginAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mts_Logout.Click
        frm_char.Close()
        frm_desk.MdiParent = Me
        frm_desk.Show()


    End Sub


    Private Sub Tsb_purchase_Click(sender As Object, e As EventArgs) Handles Tsb_Purchase.Click
        frm_char.Close()
        Frm_purchased.MdiParent = Me
        Frm_purchased.Show()
        Frm_purchased.WindowState = FormWindowState.Maximized
        Tsb_Purchase.CheckState = CheckState.Checked
        Tsb_Char.CheckState = CheckState.Unchecked
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Frm_main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(1, "KMTI DATA MANAGEMENT SYSTEM", "I am running minimized", ToolTipIcon.Info)
        Else
            NotifyIcon1.Visible = False
        End If

    End Sub

    Private Sub Frm_Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If (System.IO.Directory.Exists(My.Application.Info.DirectoryPath + "/Temp")) Then
            System.IO.Directory.Delete(My.Application.Info.DirectoryPath + "/Temp", True)
        End If

    End Sub
End Class
