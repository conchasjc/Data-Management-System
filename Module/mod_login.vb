Imports MySql.Data.MySqlClient
Module mod_login

    Dim conn As New MySqlConnection("host=localhost; user = root; pass=; database=kmtiworkstation;")
    Dim stat As Boolean
    Public Function getConnect()
        Try
            conn.Open()
            stat = True


        Catch ex As Exception
            frm_desk.GunaCirclePictureBox1.BaseColor = Color.Red

            stat = False
        End Try
        Return 0
    End Function
    Public Function conStatus()
        Return stat
    End Function

End Module
