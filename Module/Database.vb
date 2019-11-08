
Imports MySql.Data.MySqlClient
Public Class Database
    Public Property Command As MySqlCommand
    Public Property QueryTable As New DataTable
    Public Sub Connect(query As String)
        Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
        Try
            conn.Open()
            My.Settings.dbConnected = True
            command = New MySqlCommand(query, conn) With {
            .CommandTimeout = 0
            }
            Dim sql_adapter As MySqlDataAdapter
            sql_adapter = New MySqlDataAdapter(command)
            sql_adapter.Fill(QueryTable)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATABASE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Settings.dbConnected = False
        End Try

    End Sub
    Public Sub TestConnect()
        Dim con As New MySqlConnection("host=" + frm_settings.txt_dbSource.Text + "; username = " + frm_settings.txt_dbUsername.Text + "; password=" + frm_settings.txt_dbPassword.Text + "; database=" + frm_settings.txt_dbName.Text + ";character set=utf8;")
        Try
            con.Open()
            MessageBox.Show("Database Connected Succesfully")
            frm_settings.btn_save.Enabled = True
            con.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
            frm_settings.btn_save.Enabled = False
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub Notification()
        Dim con As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
        Try
            con.Open()
            My.Settings.dbConnected = True
            con.Close()
        Catch ex As Exception

            My.Settings.dbConnected = False
        Finally

        End Try
    End Sub

End Class
