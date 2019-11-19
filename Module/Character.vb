Imports MySql.Data.MySqlClient
Public Class Character
    Public Property TextBind As New BindingSource

    Public Sub GetCharacterDatabase(material)
        Dim charDb As New Database
        If material = "" Then
            charDb.Connect("select eng_char as ENGLISH,jp_char as JAPANESE from char_search order by eng_char asc")
            Frm_Char.GunaPanel7.Enabled = True
            Frm_Char.GunaPanel9.Enabled = False
        Else
            charDb.Connect("select eng_char as ENGLISH,jp_char as JAPANESE from heat_trmnt where category='" + material + "' order by eng_char asc")
            Frm_Char.GunaPanel7.Enabled = False
            Frm_Char.GunaPanel9.Enabled = True
        End If
        TextBind.DataSource = charDb.QueryTable

    End Sub
    Public Sub FindCharacter()
        TextBind.Filter = "ENGLISH like '%" & Frm_Char.GunaTextBox1.Text & "%' or JAPANESE like '%" & Frm_Char.GunaTextBox1.Text & "%'"

    End Sub

    Public Sub Delete(character As String, jpcharacter As String, material As String, columnName As String, tableName As String)
        Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8")
        Dim command As MySqlCommand
        Try
            conn.Open()

            Command = New MySqlCommand("Delete from " + tableName + " where " + columnName + "='" + material + "' and (eng_char='" + character + "' or jp_char='" + jpcharacter + "')", conn) With {
            .CommandTimeout = 0
            }
            Command.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Character Deleted")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub Update(columnName As String, material As String, tableName As String)
        Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8")
        Dim command As MySqlCommand
        Try
            conn.Open()

            command = New MySqlCommand("Update " + tableName + " set eng_char='" + Frm_UpdateTreatment.GunaTextBox1.Text + "' ,jp_char='" + Frm_UpdateTreatment.GunaTextBox2.Text + "' where " + columnName + "='" + material + "'  and eng_char='" + Frm_Char.GunaDataGridView1.CurrentRow.Cells(0).Value + "'", conn) With {
            .CommandTimeout = 0
            }
            command.ExecuteNonQuery()
            conn.Close()
            Frm_UpdateTreatment.GunaTextBox1.Text = ""
            Frm_UpdateTreatment.GunaTextBox2.Text = ""
            MessageBox.Show("Character Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Frm_UpdateTreatment.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub



End Class
