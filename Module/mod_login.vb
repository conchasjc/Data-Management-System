Imports MySql.Data.MySqlClient
Module mod_login

    Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";")
    Public Function testConnect()
        Dim con As New MySqlConnection("host=" + frm_settings.txt_dbSource.Text + "; username = " + frm_settings.txt_dbUsername.Text + "; password=" + frm_settings.txt_dbPassword.Text + "; database=" + frm_settings.txt_dbName.Text + ";")
        Try
            con.Open()
            MessageBox.Show("Database Connected Succesfully")

            con.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
        Return 0
    End Function
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

    Dim bSource As New BindingSource

    Public Function getDbChar(material)
        Dim sda As New MySqlDataAdapter
        Dim dbDtaSet As New DataTable
        Try
            conn.OpenAsync()
            Dim query As String
            Dim com As MySqlCommand
            query = "select engWord as English_Character,japWord as Japanese_Character from tbl_wordchar where materialCategory='" + material + "'"
            com = New MySqlCommand(query, conn)
            sda.SelectCommand = com
            sda.Fill(dbDtaSet)
            bSource.DataSource = dbDtaSet
            frm_char.GunaDataGridView1.DataSource = bSource
            sda.Update(dbDtaSet)
            conn.CloseAsync()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function

    Public Function getFilter()
        bSource.Filter = "English_Character like '%" & frm_char.GunaTextBox1.Text & "%' or Japanese_Character like '%" & frm_char.GunaTextBox1.Text & "%'"
        Return 0
    End Function



End Module
