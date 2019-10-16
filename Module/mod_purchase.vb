
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
            Dim query = "select file as DRAWING_FILE from tblfile where Parts_type='" + category.ToString + "'"

            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim ds As New DataTable
            adapter.Fill(ds)
            bSources.DataSource = ds
            Frm_purchased.DataGrid_Files.DataSource = bSources
            conn.Close()
        Catch ex As Exception


        End Try
        Return 0
    End Function

    Public Function getloadCategory()
        Dim query = "select distinct Category from tblfile"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet
        adapter.Fill(ds)
        Frm_purchased.Cmb_Category.DataSource = ds.Tables(0)
        Frm_purchased.Cmb_Category.DisplayMember = "Category"
        Frm_PurchAdd.ComboBox1.DataSource = ds.Tables(0)
        Frm_PurchAdd.ComboBox1.DisplayMember = "Category"
        conn.Close()
        Return 0
    End Function

    Public Function LoadPartTypes()
        Dim query As String
        query = "select distinct Parts_type as PARTS_TYPE from tblfile where category='" + Frm_purchased.Cmb_Category.Text + "' order by Parts_type"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet
        adapter.Fill(ds)

        Frm_purchased.DataGrid_Parts.DataSource = ds.Tables(0)
        Frm_PurchAdd.ComboBox2.DataSource = ds.Tables(0)
        Frm_PurchAdd.ComboBox2.DisplayMember = "Parts_type"
        Frm_PurchAdd.ComboBox1.DataSource = ds.Tables(0)
        conn.Close()
        Return 0
    End Function



    Public Function GetAllParts()
        Dim querys As String
        querys = "select distinct Parts_type as PARTS_TYPE from tblfile "
        Dim adapters As New MySqlDataAdapter(querys, conn)
        Dim dss As New DataTable
        adapters.Fill(dss)

        bSource.DataSource = dss

        Frm_purchased.DataGrid_Parts.DataSource = bSource

        conn.Close()
        Return 0
    End Function

    Public Function GetAllfiles()
        Dim querys As String
        querys = "select file as DRAWING_FILE from tblfile "
        Dim adapters As New MySqlDataAdapter(querys, conn)
        Dim dss As New DataTable
        adapters.Fill(dss)
        bSources.DataSource = dss
        Frm_purchased.DataGrid_Files.DataSource = bSources
        conn.Close()
        Return 0
    End Function

    Public Function FilterParts()
        If Frm_purchased.ComboBox1.SelectedIndex = 0 Then
            bSource.Filter = "PARTS_TYPE like '%" & Frm_purchased.Txt_TextSearch.Text & "%'"
        ElseIf Frm_purchased.ComboBox1.SelectedIndex = 1 Then
            bSources.Filter = "DRAWING_FILE like '%" & Frm_purchased.Txt_TextSearch.Text & "%'"
        Else
            bSources.Filter = "DRAWING_FILE like '%" & Frm_purchased.Txt_TextSearch.Text & "%'"
        End If
        Return 0
    End Function





    Public Function QuickDownload(downloadFile)
        Try
            Dim cmd As New MySqlCommand("select * from tblfile where file='" + downloadFile + "';", conn)
            Dim sqL_adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            Dim LineOfText As String
            Dim filename() As String
            Dim MyData() As Byte
            Dim K As Long
            sqL_adapter.Fill(table)
            MyData = table.Rows(0)(3)
            K = UBound(MyData)

            filename = downloadFile.ToString.Split("/")
            LineOfText = String.Join("-", filename)
            Dim fs As New FileStream(My.Settings.sett_locpath + "/DownloadedParts/" + LineOfText, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(MyData, 0, K)

            fs.Close()

            LoadPartTypes()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return 0
    End Function


    Public Function previewFile3(downloadFile)
        Try
            Dim cmd As New MySqlCommand("select * from tblfile where file='" + downloadFile + "';", conn)
            Dim table As New DataTable

            Dim sqL_adapters As New MySqlDataAdapter(cmd)
            Dim LineOfText As String
            Dim filename() As String
            Dim MyData() As Byte
            Dim K As Long


            sqL_adapters.Fill(table)
            MyData = table.Rows(0)(3)
            K = UBound(MyData)

            filename = downloadFile.ToString.Split("/")
            LineOfText = String.Join("-", filename)
            Dim fs As New FileStream(My.Application.Info.DirectoryPath + "/temp/" + LineOfText, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(MyData, 0, K)

            fs.Close()
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath + "/temp/" + LineOfText)
            LoadPartTypes()
            Frm_purchased.Timer3.Stop()
            Frm_purchased.Panel1.Visible = False
            Frm_purchased.GunaProgressBar1.Style = Guna.UI.WinForms.ProgressBarStyle.Blocks
            Frm_purchased.GunaLabel2.Text = "Downloading Files"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Frm_purchased.Panel1.Visible = False
        End Try
        Return 0
    End Function


    Public Function allFile(downloadFile)
        Try
            Dim cmd As New MySqlCommand("select * from tblfile where file='" + downloadFile + "';", conn)
            Dim sqL_adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            Dim LineOfText As String
            Dim filename() As String
            Dim MyData() As Byte
            Dim K As Long
            sqL_adapter.Fill(table)
            MyData = table.Rows(0)(3)
            K = UBound(MyData)
            filename = downloadFile.ToString.Split("/")
            LineOfText = String.Join("-", filename)
            Dim fs As New FileStream(My.Settings.sett_locpath + "/DownloadedParts/" + LineOfText, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(MyData, 0, K)

            fs.Close()

            LoadPartTypes()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function





    ''Codes Under This Line Is for Speed Optimization







    Dim command As MySqlCommand
    Dim adapt As MySqlDataAdapter
    Dim table As New DataTable
    Public Function loadFile(dfile, dparts)
        conn.Close()
        conn.OpenAsync()
        command = New MySqlCommand("select * from tblfile where Parts_Type='" + dparts + "';", conn)
        adapt = New MySqlDataAdapter(command)
        adapt.Fill(table)
        conn.Close()
        Return 0

    End Function




End Module
