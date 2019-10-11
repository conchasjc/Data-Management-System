Public Class Frm_PurchAdd
    Private Sub Frm_PurchAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
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
    Public Function getdropfilename(path As String)
        Return IO.Path.GetFullPath(path)
    End Function

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        getAddPurchased(ComboBox1.Text, ComboBox2.Text)

    End Sub


End Class