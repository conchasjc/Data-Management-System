
Imports MySql.Data.MySqlClient
Public Class Database
    Public Property command As MySqlCommand
    Public Property QueryTable As New DataTable
    Public Sub Connect(query As String)
        Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
        Try
            conn.Open()

            command = New MySqlCommand(query, conn) With {
            .CommandTimeout = 0
            }
            Dim sql_adapter As MySqlDataAdapter
            sql_adapter = New MySqlDataAdapter(command)
            sql_adapter.Fill(QueryTable)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

End Class
