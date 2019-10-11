
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Frm_purchased

    Private Sub Frm_purchased_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mod_purchase.getloadCategory()

        mod_purchase.getLoad(DataGrid_Parts.CurrentCell.Value)


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


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub


End Class