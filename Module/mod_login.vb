Imports MySql.Data.MySqlClient
Module mod_login

    ReadOnly conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8;")
    Public Function TestConnect()
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

        End Try
        Return 0
    End Function

    Public Function GetDbConnect()
        Try
            conn.OpenAsync()
            My.Settings.dbConnected = True
            conn.Close()
        Catch ex As Exception

            My.Settings.dbConnected = False

        End Try
        conn.CloseAsync()
        Return 0
    End Function

    Dim bSource As New BindingSource


    Public Function GetDbChar(material)
        Dim sda As New MySqlDataAdapter
        Dim dbDtaSet As New DataTable
        Try
            conn.OpenAsync()
            Dim query As String
            Dim com As MySqlCommand
            If material = "" Then
                query = "select eng_char as English_Character,jp_char as Japanese_Character from char_search"
            Else

                query = "select eng_char as English_Character,jp_char as Japanese_Character from heat_trmnt where category='" + material + "'"

            End If
            com = New MySqlCommand(query, conn)
            sda.SelectCommand = com
            sda.Fill(dbDtaSet)
            bSource.DataSource = dbDtaSet
            Frm_Char.GunaDataGridView1.DataSource = bSource
            sda.Update(dbDtaSet)
            conn.CloseAsync()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function



    Public Function GetCharFilter()
        bSource.Filter = "English_Character like '%" & Frm_Char.GunaTextBox1.Text & "%' or Japanese_Character like '%" & Frm_Char.GunaTextBox1.Text & "%'"
        Return 0
    End Function



End Module
