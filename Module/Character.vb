Public Class Character
    Public Property TextBind As New BindingSource

    Public Sub GetCharacterDatabase(material)
        Dim charDb As New Database
        If material = "" Then
            charDb.Connect("select eng_char as ENGLISH,jp_char as JAPANESE from char_search")
        Else
            charDb.Connect("select eng_char as ENGLISH,jp_char as JAPANESE from heat_trmnt where category='" + material + "'")
        End If
        TextBind.DataSource = charDb.QueryTable

    End Sub
    Public Sub FindCharacter()
        TextBind.Filter = "ENGLISH like '%" & Frm_Char.GunaTextBox1.Text & "%' or JAPANESE like '%" & Frm_Char.GunaTextBox1.Text & "%'"

    End Sub

End Class
