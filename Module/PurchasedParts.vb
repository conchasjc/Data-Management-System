Imports MySql.Data.MySqlClient

Imports System.IO
Public Class PurchasedParts
    Inherits Database

    ReadOnly BindingAll As New BindingSource
    ReadOnly BindingFiles As New BindingSource
    Public Sub AddNewParts(Category As String, PartTypes As String)
        Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
        Dim cmd As MySqlCommand
        conn.OpenAsync()
        Try
            For Each item In Frm_PurchAdd.ListBox1.Items
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into tblfile (Category,Parts_Type,file,dataFile)values(@category,@parts,@file,@datafile);"
                Dim fullfilename() As String = item.ToString.Split("\")
                Dim fname As String = fullfilename.Last.ToString
                cmd.Parameters.AddWithValue("@category", Category)
                cmd.Parameters.AddWithValue("@parts", PartTypes)
                cmd.Parameters.AddWithValue("@file", fname)
                cmd.Parameters.AddWithValue("@datafile", File.ReadAllBytes(item))
                cmd.ExecuteNonQuery()
            Next
            Frm_PurchAdd.ListBox1.Items.Clear()
            MessageBox.Show("Purchased Parts Added Successfully.", "Adding Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        conn.CloseAsync()
    End Sub

    Public Sub DeleteParts(FileName As String)
        Dim res = MessageBox.Show("Delete " + FileName + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If res = vbYes Then
            Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
            Dim cmd As MySqlCommand
            conn.OpenAsync()
            cmd = conn.CreateCommand
            cmd.CommandText = "Delete from tblfile where file='" + FileName + "'"
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            conn.CloseAsync()
            MessageBox.Show("File Deleted")
            Frm_purchased.DataGrid_Files.Rows.RemoveAt(Frm_purchased.DataGrid_Files.CurrentRow.Index)
        End If
    End Sub

    Public Sub LoadParts(category)

        Connect("select distinct Parts_type as PARTS_TYPE from tblfile where category='" + category + "' order by Parts_type")
        Frm_purchased.DataGrid_Parts.DataSource = QueryTable
    End Sub

    Public Sub LoadFiles(partName)
        Connect("select file as DRAWINGFILE from tblfile where Parts_type='" + partName.ToString + "'")
        BindingFiles.DataSource = QueryTable
        Frm_purchased.DataGrid_Files.DataSource = BindingFiles
    End Sub

    Public Sub LoadAll()
        Connect("select file as DRAWINGFILE from tblfile")
        BindingAll.DataSource = QueryTable
        Frm_purchased.DataGrid_Files.DataSource = BindingAll
    End Sub

    Public Sub FilterFile(fileName)
        If Frm_purchased.CheckBox1.Checked = True Then
            BindingAll.RemoveFilter()
            BindingAll.Filter = "DRAWINGFILE like '%" & Frm_purchased.Txt_TextSearch.Text & "%'"
        Else
            If fileName = True Then
                BindingFiles.RemoveFilter()
                BindingFiles.Filter = "DRAWINGFILE like '%" & Frm_purchased.Txt_TextSearch.Text & "%'"
            Else
                BindingFiles.RemoveFilter()
                BindingFiles.Filter = "DRAWINGFILE like '%" & Frm_purchased.Txt_TextSearch.Text & "%'"

            End If
        End If

    End Sub
End Class
