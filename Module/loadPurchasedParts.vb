Imports System.IO

'#################################################### MODULE FOR PURCHASED PARTS FUNCTION #################################################################
Module loadPurchasedParts


    Dim DataFileBinary() As Byte
    Dim MachineSource As New BindingSource
    Dim OutfittingSource As New BindingSource

    Public Function LoadMachinePurchasedParts()
        Dim DbConnect As New Database
        DbConnect.Connect("select * from tblfile where category='Machine Purchased Parts'")
        MachineSource.DataSource = DbConnect.QueryTable
        Return 0
    End Function

    Public Function LoadOutfittingPurchasedParts()
        Dim DbConnect As New Database
        DbConnect.Connect("select * from tblfile where category='Outfitting Purchased Parts'")
        OutfittingSource.DataSource = DbConnect.QueryTable
        Return 0
    End Function
    Public Function PreviewFile(DownloadFile, Choice, AllFiles)
        If Choice = True And AllFiles = False Then
            MachineSource.Filter = "file Like '" + DownloadFile + "'"
            DataFileBinary = MachineSource(0)(3)
        ElseIf Choice = False And AllFiles = False Then
            OutfittingSource.Filter = "file Like '" + DownloadFile + "'"
            DataFileBinary = OutfittingSource(0)(3)
        ElseIf AllFiles = True Then
            MachineSource.RemoveFilter()
            MachineSource.Filter = "file Like '" + DownloadFile + "'"
            If MachineSource.Count = 1 Then
                DataFileBinary = MachineSource(0)(3)
            Else
                OutfittingSource.RemoveFilter()
                OutfittingSource.Filter = "file Like '" + DownloadFile + "'"
                DataFileBinary = OutfittingSource(0)(3)
            End If
        End If
        Dim File As New IcadFileAccess
        File.ICADWrite(DownloadFile, DataFileBinary)
        File.OpenICAD()
        MachineSource.RemoveFilter()
        OutfittingSource.RemoveFilter()

        Return 0
    End Function

    Public Function QuickDownload(DownloadFile, Choice, AllFiles)

        If Choice = True And AllFiles = False Then
            MachineSource.Filter = "file Like '" + DownloadFile + "'"
            DataFileBinary = MachineSource(0)(3)
        ElseIf Choice = False And AllFiles = False Then
            OutfittingSource.Filter = "file Like '" + DownloadFile + "'"
            DataFileBinary = OutfittingSource(0)(3)
        ElseIf AllFiles = True Then
            MachineSource.RemoveFilter()
            MachineSource.Filter = "file Like '" + DownloadFile + "'"
            If MachineSource.Count = 1 Then

                DataFileBinary = MachineSource(0)(3)
            Else
                OutfittingSource.RemoveFilter()
                OutfittingSource.Filter = "file Like '" + DownloadFile + "'"
                DataFileBinary = OutfittingSource(0)(3)
            End If
        End If
        Dim File As New IcadFileAccess
        File.ICADDownload(DownloadFile, DataFileBinary)

        MachineSource.RemoveFilter()
        OutfittingSource.RemoveFilter()

        Return 0
    End Function


    Public Function AllFile(downloadFile)

        MachineSource.Filter = "file Like '" + downloadFile + "'"
            If MachineSource.Count = 1 Then

                DataFileBinary = MachineSource(0)(3)
            Else
                OutfittingSource.Filter = "file Like '" + downloadFile + "'"
                DataFileBinary = OutfittingSource(0)(3)
            End If
        Dim File As New IcadFileAccess
        File.ICADDownload(downloadFile, DataFileBinary)
        MachineSource.RemoveFilter()
        OutfittingSource.RemoveFilter()



        Return 0
    End Function



End Module

'###################################################################################################################################################