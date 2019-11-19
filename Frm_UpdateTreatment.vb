Imports MySql.Data.MySqlClient
Public Class Frm_UpdateTreatment
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Me.Close()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim editChar As New Character
        If Label1.Text = "EDIT CHARACTER" Then
            editChar.update("materialCategory", " ", "char_search")
        Else
            editChar.update("Category", Frm_Char.materialCat, "heat_trmnt")
        End If
    End Sub

    Private Sub Frm_UpdateTreatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim cat() = Label1.Text.Split(" ")
        ' Label2.Text = cat(1)
    End Sub
End Class