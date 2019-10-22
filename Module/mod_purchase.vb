
Imports System.IO
Imports MySql.Data.MySqlClient
Module mod_purchase
    'CONNECTION OF DATABASE THROUGH SERVER
    Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
    Dim bSource As New BindingSource
    Dim bSources As New BindingSource

    Public Function getAddPurchased(category, partsType)
        Dim sda As New MySqlDataAdapter
        Dim dbDtaSet As New DataTable
        Dim cmd As MySqlCommand
        conn.OpenAsync()
        Try
            For Each item In Frm_PurchAdd.ListBox1.Items
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into tblfile (Category,Parts_Type,file,dataFile)values(@category,@parts,@file,@datafile);"
                Dim fullfilename() As String = item.ToString.Split("\")
                Dim fname As String = fullfilename.Last.ToString
                cmd.Parameters.AddWithValue("@category", category)
                cmd.Parameters.AddWithValue("@parts", partsType)
                cmd.Parameters.AddWithValue("@file", fname)
                cmd.Parameters.AddWithValue("@datafile", File.ReadAllBytes(item))
                cmd.ExecuteNonQuery()
            Next
            Frm_PurchAdd.ListBox1.Items.Clear()
            MessageBox.Show("DATA ADDED")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.CloseAsync()
        Return 0
    End Function

    Public Function getLoad(category)
        Try
            Dim query = "select file as DRAWINGFILE from tblfile where Parts_type='" + category.ToString + "'"

            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim ds As New DataTable
            adapter.Fill(ds)
            ds.Columns(0).Caption = "PURCHASED PARTS FILE"
            bSources.DataSource = ds
            Frm_purchased.DataGrid_Files.DataSource = bSources
            conn.Close()
        Catch ex As Exception


        End Try
        Return 0
    End Function



    Public Function LoadPartTypes(category)
        Dim query As String
        query = "select distinct Parts_type as PARTS_TYPE from tblfile where category='" + category + "' order by Parts_type"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet
        adapter.Fill(ds)

        Frm_purchased.DataGrid_Parts.DataSource = ds.Tables(0)

        conn.Close()
        Return 0
    End Function
    Dim AllFile As New BindingSource
    Public Function LoadAll()
        Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
        Dim querys As String
        querys = "select file as DRAWINGFILE from tblfile "
        Dim adapters As New MySqlDataAdapter(querys, conn)
        Dim dss As New DataTable



        adapters.Fill(dss)

        AllFile.DataSource = dss
        Frm_purchased.DataGrid_Files.DataSource = AllFile
        conn.Close()
        adapters.Dispose()
        Return 0
    End Function
    Public Function FileFilter(cat)
        If Frm_purchased.CheckBox1.Checked = True Then
            AllFile.RemoveFilter()
            AllFile.Filter = "DRAWINGFILE like '%" & Frm_purchased.Txt_TextSearch.Text & "%'"
        Else
            If cat = True Then
                bSources.RemoveFilter()
                bSources.Filter = "DRAWINGFILE like '%" & Frm_purchased.Txt_TextSearch.Text & "%'"
            Else
                bSources.RemoveFilter()
                bSources.Filter = "DRAWINGFILE like '%" & Frm_purchased.Txt_TextSearch.Text & "%'"

            End If
        End If
        Return 0
    End Function






End Module
