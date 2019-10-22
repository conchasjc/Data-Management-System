Imports System.IO
Imports MySql.Data.MySqlClient
'#################################################### MODULE FOR PURCHASED PARTS FUNCTION #################################################################
Module loadPurchasedParts


    Dim DataFileBinary() As Byte
    Dim MachineSource As New BindingSource
    Dim OutfittingSource As New BindingSource
    Dim machinefilter As New BindingSource
    Public Function LoadMachinePurchasedParts()
        Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
        Try
            conn.Open()
            Dim command As MySqlCommand
            Dim sql_adapter As MySqlDataAdapter
            Dim table As New DataTable
            command = New MySqlCommand("select * from tblfile where category='Machine Purchased Parts' ", conn) With {
            .CommandTimeout = 0
            }
            sql_adapter = New MySqlDataAdapter(command)
            sql_adapter.Fill(table)
            MachineSource.DataSource = table

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return 0
    End Function

    Public Function LoadOutfittingPurchasedParts()
        Try
            Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
            conn.Open()
            Dim command As MySqlCommand
            Dim sql_adapter As MySqlDataAdapter
            Dim table As New DataTable
            command = New MySqlCommand("select * from tblfile where category='Outfitting Purchased Parts'", conn)
            command.CommandTimeout = 0
            sql_adapter = New MySqlDataAdapter(command)
            sql_adapter.Fill(table)
            OutfittingSource.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return 0
    End Function
    Public Function PreviewFile(downloadFile, choice, allfiles)

        Try

            Dim LineOfText As String
            Dim filename() As String
            Dim K As Long


            If choice = True And allfiles = False Then
                MachineSource.Filter = "file Like '" + downloadFile + "'"
                DataFileBinary = MachineSource(0)(3)
            ElseIf choice = False And allfiles = False Then
                OutfittingSource.Filter = "file Like '" + downloadFile + "'"
                DataFileBinary = OutfittingSource(0)(3)
            ElseIf allfiles = True Then
                MachineSource.RemoveFilter()
                MachineSource.Filter = "file Like '" + downloadFile + "'"
                If MachineSource.Count = 1 Then

                    DataFileBinary = MachineSource(0)(3)
                Else
                    OutfittingSource.RemoveFilter()
                    OutfittingSource.Filter = "file Like '" + downloadFile + "'"
                    DataFileBinary = OutfittingSource(0)(3)
                End If
            End If

            K = UBound(DataFileBinary)
            filename = downloadFile.ToString.Split("/")
            LineOfText = String.Join("／", filename)

            Dim fs As New FileStream(My.Application.Info.DirectoryPath + "/temp/" + LineOfText, FileMode.OpenOrCreate, FileAccess.Write)

            fs.Write(DataFileBinary, 0, K)
            fs.Close()
            MachineSource.RemoveFilter()
            OutfittingSource.RemoveFilter()
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath + "/temp/" + LineOfText)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function

    Public Function QuickDownload(downloadFile, choice)

        Try

            Dim LineOfText As String
            Dim filename() As String
            Dim K As Long


            If choice = True Then
                MachineSource.Filter = "file Like '" + downloadFile + "'"
                DataFileBinary = MachineSource(0)(3)
            ElseIf choice = False Then
                OutfittingSource.Filter = "file Like '" + downloadFile + "'"
                DataFileBinary = OutfittingSource(0)(3)
            Else
                MachineSource.Filter = "file Like '" + downloadFile + "'"
                If MachineSource.Count = 1 Then

                    DataFileBinary = MachineSource(0)(3)
                Else
                    OutfittingSource.Filter = "file Like '" + downloadFile + "'"
                    DataFileBinary = OutfittingSource(0)(3)
                End If
            End If

            K = UBound(DataFileBinary)
            filename = downloadFile.ToString.Split("/")
            LineOfText = String.Join("／", filename)

            Dim fs As New FileStream(My.Settings.sett_locpath + "/DownloadedParts/" + LineOfText, FileMode.OpenOrCreate, FileAccess.Write)

            fs.Write(DataFileBinary, 0, K)
            fs.Close()




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function


    Public Function AllFile(downloadFile)
        Try

            Dim LineOfText As String
            Dim filename() As String
            Dim K As Long
            MachineSource.Filter = "file Like '" + downloadFile + "'"
            If MachineSource.Count = 1 Then

                DataFileBinary = MachineSource(0)(3)
            Else
                OutfittingSource.Filter = "file Like '" + downloadFile + "'"
                DataFileBinary = OutfittingSource(0)(3)
            End If
            K = UBound(DataFileBinary)
                filename = downloadFile.ToString.Split("/")
            LineOfText = String.Join("／", filename)

            Dim fs As New FileStream(My.Settings.sett_locpath + "/DownloadedParts/" + LineOfText, FileMode.OpenOrCreate, FileAccess.Write)

            fs.Write(DataFileBinary, 0, K)
            fs.Close()




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function



End Module

'###################################################################################################################################################