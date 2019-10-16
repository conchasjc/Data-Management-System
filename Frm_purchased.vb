
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Frm_purchased

    Private Sub Frm_purchased_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mod_purchase.getloadCategory()

        mod_purchase.getLoad(DataGrid_Parts.CurrentCell.Value)

        Me.KeyPreview = True
    End Sub




    Private Sub GunaDataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Parts.CellClick


        getLoad(DataGrid_Parts.CurrentCell.Value)
    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Frm_PurchAdd.TopMost = True
        Frm_PurchAdd.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Category.SelectedIndexChanged
        loadPartTypes()
    End Sub

    Private Sub GunaDataGridView2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Parts.CellEnter
        getLoad(DataGrid_Parts.CurrentCell.Value)
    End Sub

    Private Sub Txt_TextSearch_TextChanged(sender As Object, e As EventArgs) Handles Txt_TextSearch.TextChanged
        filterParts()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            getAllParts()
        Else
            getAllfiles()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GunaDataGridView3.Rows.Add(DataGrid_Files.CurrentCell.Value)
        DataGrid_Files.Select()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button3.Enabled = False
        Panel1.Visible = True
        GroupBox2.Enabled = False
        GunaProgressBar1.Maximum = 100
        Control.CheckForIllegalCrossThreadCalls = False

        Frm_Main.ToolStripProgressBar1.Increment(2)
        GunaProgressBar1.Value = Frm_Main.ToolStripProgressBar1.Value
        If Frm_Main.ToolStripProgressBar1.Value >= 90 Then
            Frm_Main.Tsl_Hover.Text = "Writing File"
        Else
            Frm_Main.Tsl_Hover.Text = "Downloading File"
        End If
        If Frm_Main.ToolStripProgressBar1.Value = 20 Then
            Try
                BackgroundWorker1.RunWorkerAsync()
            Catch


            End Try

        End If

        If Frm_Main.ToolStripProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("File Downloaded Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Frm_Main.ToolStripProgressBar1.Visible = False
            Frm_Main.ToolStripProgressBar1.Value = 0
            Frm_Main.Tsl_Hover.Visible = False
            Button3.Enabled = True
            Panel1.Visible = False
            GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            QuickDownload(DataGrid_Files.CurrentCell.Value)

        Catch

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If (Not System.IO.Directory.Exists(My.Application.Info.DirectoryPath + "/Temp")) Then
            System.IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath + "/Temp")
        End If

        Timer3.Start()
    End Sub

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

        GunaProgressBar1.Value += 1

        Timer2.Interval = max * 70


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
            allFile(GunaDataGridView3.Item(0, 0).Value)
            GunaDataGridView3.Rows.RemoveAt(0)
            min += 1

        Loop Until min = max
        GunaLabel4.Text = ""
    End Sub


    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork

        Try
            previewFile(DataGrid_Files.CurrentCell.Value)


        Catch

        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        GunaLabel2.Text = "Opening File"
        Panel1.Visible = True
        GroupBox2.Enabled = False
        GunaProgressBar1.Maximum = 100
        Control.CheckForIllegalCrossThreadCalls = False

        Frm_Main.ToolStripProgressBar1.Increment(1)
        GunaProgressBar1.Value = Frm_Main.ToolStripProgressBar1.Value

        If Frm_Main.ToolStripProgressBar1.Value = 10 Then
            BackgroundWorker3.RunWorkerAsync()
        End If

        If Frm_Main.ToolStripProgressBar1.Value = 100 Then
            Timer3.Stop()
            GunaLabel2.Text = "Downloading File"
            Frm_Main.ToolStripProgressBar1.Visible = False
            Frm_Main.ToolStripProgressBar1.Value = 0

            Panel1.Visible = False
            GroupBox2.Enabled = True
        End If

    End Sub

    Private Sub Button3_KeyDown(sender As Object, e As KeyEventArgs) Handles Button3.KeyDown

    End Sub

    Private Sub Button3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button3.KeyPress

    End Sub

    Private Sub Frm_purchased_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.D) Then
            Button3.PerformClick()
        End If
    End Sub
End Class