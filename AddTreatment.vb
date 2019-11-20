Imports MySql.Data.MySqlClient
Public Class AddTreatment
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim conn As New MySqlConnection("host=" + My.Settings.sett_dbSource + "; username = " + My.Settings.sett_dbUsername + "; password=" + My.Settings.sett_dbPass + "; database=" + My.Settings.sett_dbName + ";character set=utf8")
        Dim command As MySqlCommand
        Try
            conn.Open()

            command = New MySqlCommand("Insert into heat_trmnt (eng_char,jp_char,Category) values('" + GunaTextBox1.Text + "','" + GunaTextBox2.Text + "','" + GunaComboBox1.Text + "')", conn) With {
            .CommandTimeout = 0
            }
            command.ExecuteNonQuery()
            conn.Close()
            GunaTextBox1.Text = ""
            GunaTextBox2.Text = ""
            MessageBox.Show("Character Successfully Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class