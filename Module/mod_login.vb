Imports MySql.Data.MySqlClient
Module mod_login

    Dim conn As New MySqlConnection("host=localhost; user = root; pass=; database=kmtiworkstation;")

    Public Function getConnect()
        Try
            conn.Open()
            MessageBox.Show("Database connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function

End Module
