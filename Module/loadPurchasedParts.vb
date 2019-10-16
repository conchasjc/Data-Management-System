﻿Imports System.IO
Imports MySql.Data.MySqlClient

Module loadPurchasedParts
    Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
    Dim command As MySqlCommand
    Dim sql_adapter As MySqlDataAdapter
    Dim table As New DataTable
    Dim DataFileBinary() As Byte
    Dim machinesource As New BindingSource

    Public Function loadDatabasePurchasedParts()
        Try
            conn.Open()

            command = New MySqlCommand("select * from tblfile ", conn)
            command.CommandTimeout = 0
            sql_adapter = New MySqlDataAdapter(command)
            sql_adapter.Fill(table)
            machinesource.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return 0
    End Function


    Public Function previewFile(downloadFile)

        Try
            machinesource.Filter = "file like '" + downloadFile + "'"
            Dim LineOfText As String
            Dim filename() As String
            Dim K As Long

            DataFileBinary = machinesource(0)(3)
            K = UBound(DataFileBinary)
            filename = downloadFile.ToString.Split("/")
            LineOfText = String.Join("-", filename)

            Dim fs As New FileStream(My.Application.Info.DirectoryPath + "/temp/" + LineOfText, FileMode.OpenOrCreate, FileAccess.Write)

            fs.Write(DataFileBinary, 0, K)
            fs.Close()

            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath + "/temp/" + LineOfText)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function
End Module
