Imports System.Threading
Public Class frm_main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        frm_desk.MdiParent = Me
        frm_desk.Show()
        tsl_hover.Text = ""
        tsb_char.Text = "Work" + vbNewLine + "Station"
        tsb_purchase.Text = "Purchased" + vbNewLine + "Parts"
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frm_settings.Show()
    End Sub

    Private Sub Tmr_time_Tick(sender As Object, e As EventArgs) Handles tmr_time.Tick
        timeworker.RunWorkerAsync()

    End Sub

    Private Sub Tsb_char_Click(sender As Object, e As EventArgs) Handles tsb_char.Click
        frm_char.MdiParent = Me
        frm_char.Show()
    End Sub

    Private Sub LoginAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginAccountToolStripMenuItem.Click
        frm_desk.Close()
        frm_desk.MdiParent = Me
        frm_desk.Show()


    End Sub

    Private Sub Timeworker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles timeworker.DoWork
        ts_time.Text = Now.ToLongTimeString + " " + Now.ToLongDateString

    End Sub

    Private Sub Tsb_purchase_Click(sender As Object, e As EventArgs) Handles tsb_purchase.Click
        frm_char.Hide()
        frm_purchase.MdiParent = Me
        frm_purchase.Show()
    End Sub
End Class
