Imports System.IO

Public Class IcadFileAccess

    Dim LineOfText As String

    Public Sub ICADWrite(NameOfFile As String, BinaryDataFile() As Byte)
        Try
            Dim filename() As String
            Dim K As Long



            K = UBound(BinaryDataFile)
            filename = NameOfFile.ToString.Split("/")
            LineOfText = String.Join("／", filename)
            Dim fs As New FileStream(My.Application.Info.DirectoryPath + "/temp/" + LineOfText, FileMode.OpenOrCreate, FileAccess.Write)

            fs.Write(BinaryDataFile, 0, K)
            fs.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub OpenICAD()
        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath + "/temp/" + LineOfText)
    End Sub
    Public Sub ICADDownload(NameOfFile As String, BinaryDataFile() As Byte)
        Try
            Dim filename() As String
            Dim K As Long



            K = UBound(BinaryDataFile)
            filename = NameOfFile.ToString.Split("/")
            LineOfText = String.Join("／", filename)
            Dim fs As New FileStream(My.Settings.sett_locpath + "/DownloadedParts/" + LineOfText, FileMode.OpenOrCreate, FileAccess.Write)

            fs.Write(BinaryDataFile, 0, K)
            fs.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
