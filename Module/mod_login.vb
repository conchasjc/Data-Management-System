Imports MySql.Data.MySqlClient
Module mod_login

    Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; user = " + My.Settings.sett_dbUsername + "; pass=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";")

    Public Function getDbConnect()
        Try
            conn.Open()

            My.Settings.dbConnected = True
            conn.Close()
        Catch ex As Exception

            My.Settings.dbConnected = False

        End Try
        Return 0
    End Function




End Module
