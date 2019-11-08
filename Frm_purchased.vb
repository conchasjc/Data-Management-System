
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Frm_purchased

    Private Sub Frm_purchased_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Me.KeyPreview = True
    End Sub




    Private Sub GunaDataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Parts.CellClick
        Dim purchasedFiles As New PurchasedParts
        purchasedFiles.LoadFiles(DataGrid_Parts.CurrentCell.Value)


    End Sub


    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Frm_PurchAdd.TopMost = True
        Frm_PurchAdd.Show()
    End Sub



    Private Sub GunaDataGridView2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Parts.CellEnter
        Dim purchasedFiles As New PurchasedParts
        purchasedFiles.LoadFiles(DataGrid_Parts.CurrentCell.Value)


    End Sub

    Private Sub Txt_TextSearch_TextChanged(sender As Object, e As EventArgs) Handles Txt_TextSearch.TextChanged
        Dim searchFile As New PurchasedParts
        If CheckBox1.Checked = True Then
            searchFile.LoadAll()
        Else
            searchFile.LoadFiles(DataGrid_Parts.CurrentCell.Value)
        End If
        searchFile.FilterFile(RadioButton1.Checked)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GunaDataGridView3.Rows.Add(DataGrid_Files.CurrentCell.Value)
        DataGrid_Files.Select()

    End Sub






    Private Sub Frm_purchased_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.D) Then
            Btn_QuickDownload.PerformClick()
        End If
    End Sub












    '#################  DOWNLOAD ALL BUTTON FUNCTION ################
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Timer2.Start()
        BackgroundWorker2.RunWorkerAsync()


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel1.Visible = True
        GroupBox2.Enabled = False
        GroupBox1.Enabled = False
        GunaProgressBar1.Maximum = 100

        GunaLabel4.Visible = True
        Control.CheckForIllegalCrossThreadCalls = False

        GunaProgressBar1.Value += 10

        Timer2.Interval = max * 40


        If GunaProgressBar1.Value = 100 Then
            Timer2.Stop()
            MessageBox.Show("File Downloaded Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GunaProgressBar1.Value = 0
            Panel1.Visible = False
            GroupBox2.Enabled = True
            GroupBox1.Enabled = True
            GunaLabel4.Visible = False
        End If
    End Sub
    Dim min As Integer
    Dim max As Integer

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

        min = 0
        max = GunaDataGridView3.Rows.Count
        GunaProgressBar1.Maximum = max
        Do
            GunaLabel4.Text = GunaDataGridView3.Item(0, 0).Value
            AllFile(GunaDataGridView3.Item(0, 0).Value)
            GunaDataGridView3.Rows.RemoveAt(0)
            min += 1
            System.Threading.Thread.Sleep(400)
        Loop Until min = max
        GunaLabel4.Text = ""
    End Sub








    '##################################################################


    '#################  QUICK DOWNLOAD BUTTON FUNCTION ################

    Private Sub Btn_QuickDownload_Click(sender As Object, e As EventArgs) Handles Btn_QuickDownload.Click
        Tmr_QuickDownload.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Tmr_QuickDownload.Tick
        Btn_QuickDownload.Enabled = False
        Panel1.Visible = True
        GroupBox2.Enabled = False
        GunaProgressBar1.Maximum = 100
        Control.CheckForIllegalCrossThreadCalls = False

        Frm_Main.ToolStripProgressBar1.Increment(10)
        GunaProgressBar1.Value = Frm_Main.ToolStripProgressBar1.Value
        If Frm_Main.ToolStripProgressBar1.Value >= 90 Then
            Frm_Main.Tsl_Hover.Text = "Writing File"
        Else
            Frm_Main.Tsl_Hover.Text = "Downloading File"
        End If
        If Frm_Main.ToolStripProgressBar1.Value = 10 Then
            Try
                BackgroundWorker1.RunWorkerAsync()
            Catch


            End Try

        End If

        If Frm_Main.ToolStripProgressBar1.Value = 100 Then
            Tmr_QuickDownload.Stop()
            MessageBox.Show("File Downloaded Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Frm_Main.ToolStripProgressBar1.Visible = False
            Frm_Main.ToolStripProgressBar1.Value = 0
            Frm_Main.Tsl_Hover.Visible = False
            Btn_QuickDownload.Enabled = True
            Panel1.Visible = False
            GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            QuickDownload(DataGrid_Files.CurrentCell.Value, RadioButton1.Checked, CheckBox1.Checked)
        Catch
        End Try
    End Sub

    '###############################################################



    '#################  PREVIEW FILE BUTTON FUNCTION ################

    'Button Preview
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_PrevFile.Click


        If (Not System.IO.Directory.Exists(My.Application.Info.DirectoryPath + "/Temp")) Then
            System.IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath + "/Temp")
        End If

        Tmr_PreviewFile.Start()
    End Sub

    'Preview Background Process
    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Wrkr_PreviewFile.DoWork
        Try
            PreviewFile(DataGrid_Files.CurrentCell.Value, RadioButton1.Checked, CheckBox1.Checked)
        Catch
        End Try
    End Sub

    'Preview Loader
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Tmr_PreviewFile.Tick

        GunaLabel2.Text = "Opening File"
        Panel1.Visible = True
        GroupBox2.Enabled = False
        GunaProgressBar1.Maximum = 100
        Control.CheckForIllegalCrossThreadCalls = False

        Frm_Main.ToolStripProgressBar1.Increment(10)
        GunaProgressBar1.Value = Frm_Main.ToolStripProgressBar1.Value

        If Frm_Main.ToolStripProgressBar1.Value = 10 Then
            Wrkr_PreviewFile.RunWorkerAsync()
        End If

        If Frm_Main.ToolStripProgressBar1.Value = 100 Then
            Tmr_PreviewFile.Stop()
            GunaLabel2.Text = "Downloading File"
            Frm_Main.ToolStripProgressBar1.Visible = False
            Frm_Main.ToolStripProgressBar1.Value = 0
            DataGrid_Files.Select()
            Panel1.Visible = False
            GroupBox2.Enabled = True
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim machineParts As New PurchasedParts
        machineParts.LoadParts(RadioButton1.Text)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim outfittingParts As New PurchasedParts
        outfittingParts.LoadParts(RadioButton2.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim purchasedFiles As New PurchasedParts
        If CheckBox1.Checked = True Then
            DataGrid_Parts.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            Txt_TextSearch.Text = ""
          purchasedFiles.LoadAll
        Else

            purchasedFiles.LoadFiles(DataGrid_Parts.CurrentCell.Value)


            DataGrid_Parts.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            Txt_TextSearch.Text = ""
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip1.Show("ADD TO DOWNLOAD LIST", Button1)
    End Sub

    Private Sub Btn_PrevFile_MouseHover(sender As Object, e As EventArgs) Handles Btn_PrevFile.MouseHover
        ToolTip1.Show("PREVIEW ICAD FILE", Btn_PrevFile)
    End Sub

    Private Sub Btn_QuickDownload_MouseHover(sender As Object, e As EventArgs) Handles Btn_QuickDownload.MouseHover
        ToolTip1.Show("DOWNLOAD FILE NOW", Btn_QuickDownload)
    End Sub

    Private Sub Btn_DeletePart_Click(sender As Object, e As EventArgs) Handles Btn_DeletePart.Click
        Dim delFile As New PurchasedParts
        delFile.DeleteParts(DataGrid_Files.CurrentCell.Value)

    End Sub

    Private Sub Worker_Delete_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_Delete.DoWork

    End Sub




    '##################################################################


End Class