Imports System.ComponentModel

Public Class Frm_PurchAdd
    Private Sub Frm_PurchAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        GroupBox1.Visible = False
        ListBox1.Location = New Point(28, 189)
        ListBox1.Height = 364
        GunaElipsePanel1.Location = New Point(28, 189)
        GunaElipsePanel1.Height = 364
        Frm_Main.Enabled = False
    End Sub

    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All

        End If
    End Sub

    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop
        Dim droppedItems As String() = e.Data.GetData(DataFormats.FileDrop)
        Dim x As Integer = 2
        For Each file In droppedItems
            Dim extn As New IO.FileInfo(file)
            Dim filename = getdropfilename(file)
            If extn.Extension = ".icd" Then

                ListBox1.Items.Add(filename)
            Else
                x = 1

            End If
        Next
        If x = 1 Then
            MessageBox.Show("FILE NOT SUPPORTED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
        End If
    End Sub
    Public Function GetDropfilename(path As String)
        Return IO.Path.GetFullPath(path)
    End Function

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim parts As New PurchasedParts
        If Radio_Machine.Checked = True Then
            parts.AddNewParts("Machine Purchased Parts", GunaTextBox2.Text)
        Else
            parts.AddNewParts("Outfitting Purchased Parts", GunaTextBox2.Text)
        End If
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub Radio_Machine_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Machine.CheckedChanged
        Cmb_PartsType.Items.Clear()
        GroupBox1.Visible = False
        GunaTextBox2.Text = ""
        ListBox1.Location = New Point(28, 189)
        ListBox1.Height = 364
        Dim db As New Database
        db.Connect("select distinct Parts_type from tblfile where category='Machine Purchased Parts'")
        Cmb_PartsType.Items.Add("NEW PART TYPE")
        For i = 0 To db.QueryTable.Rows.Count - 1
            Cmb_PartsType.Items.Add(db.QueryTable.Rows(i).Item(0).ToString)
        Next

    End Sub

    Private Sub Radio_Outfit_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Outfit.CheckedChanged
        Cmb_PartsType.Items.Clear()
        GroupBox1.Visible = False
        GunaTextBox2.Text = ""

        ListBox1.Location = New Point(28, 189)
        ListBox1.Height = 364
        GunaElipsePanel1.Location = New Point(28, 189)
        GunaElipsePanel1.Height = 364
        Dim db As New Database
        db.Connect("select distinct Parts_type from tblfile where category='Outfitting Purchased Parts'")
        Cmb_PartsType.Items.Add("NEW PART TYPE")
        For i = 0 To db.QueryTable.Rows.Count - 1
            Cmb_PartsType.Items.Add(db.QueryTable.Rows(i).Item(0).ToString)
        Next


    End Sub

    Private Sub Cmb_PartsType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_PartsType.SelectedIndexChanged
        If Cmb_PartsType.Text = "NEW PART TYPE" Then
            GunaTextBox2.Text = ""
            GroupBox1.Visible = True
            ListBox1.Location = New Point(28, 249)

            ListBox1.Height = 304
            GunaElipsePanel1.Location = New Point(28, 249)
            GunaElipsePanel1.Height = 304
        Else
            GunaTextBox2.Text = ""
            GroupBox1.Visible = False
            ListBox1.Location = New Point(28, 189)
            ListBox1.Height = 364
            GunaElipsePanel1.Location = New Point(28, 189)
            GunaElipsePanel1.Height = 364
        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Me.Close()
    End Sub

    Private Sub Frm_PurchAdd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Frm_Main.Enabled = True
    End Sub
End Class