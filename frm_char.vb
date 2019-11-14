Imports Microsoft.Office.Interop

Public Class Frm_Char
    ReadOnly dataText As New Character
    Private Sub Frm_char_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.accPriv = "userAccount" Then
            UserPriv()
            Me.MdiParent = Frm_Main
            Me.Show()
        Else
            AdminPriv()
            Me.MdiParent = Frm_Main
            Me.Show()
        End If
        Frm_Main.Mts_Logout.Visible = True
        Frm_Main.Mts_Login.Visible = False
        Frm_Desk.Close()
        dataText.GetCharacterDatabase("")
        GunaDataGridView1.DataSource = dataText.TextBind
        Frm_Main.ToolStripMenuItem1.Visible = True
        Frm_Main.Tsb_Char.Enabled = True
        Frm_Main.Tsb_Purchase.Enabled = True
    End Sub





    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        Try
            Clipboard.SetText(GunaDataGridView1.CurrentCell.Value)
        Catch
        End Try
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged

        dataText.FindCharacter()

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim dataTexts As New Character
        If GunaAdvenceButton1.Checked = True Then
            GunaAdvenceButton1.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = True
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            dataText.GetCharacterDatabase("S35C&S45C")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        If GunaAdvenceButton2.Checked = True Then
            GunaAdvenceButton2.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = True
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False
            dataText.GetCharacterDatabase("S50C")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        If GunaAdvenceButton3.Checked = True Then
            GunaAdvenceButton3.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = True
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("S55C")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        If GunaAdvenceButton4.Checked = True Then
            GunaAdvenceButton4.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = True
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("SCM435")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        If GunaAdvenceButton5.Checked = True Then
            GunaAdvenceButton5.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = True
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("SCM440")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton10.Click
        If GunaAdvenceButton10.Checked = True Then
            GunaAdvenceButton10.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = True
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("SKD11")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton9.Click
        If GunaAdvenceButton9.Checked = True Then
            GunaAdvenceButton9.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = True
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("SNC631")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        If GunaAdvenceButton8.Checked = True Then
            GunaAdvenceButton8.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = True
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("SNCM439")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        If GunaAdvenceButton7.Checked = True Then
            GunaAdvenceButton7.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = True
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("SNCM447")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        If GunaAdvenceButton6.Checked = True Then
            GunaAdvenceButton6.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = True
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("SS400")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton15_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton15.Click
        If GunaAdvenceButton15.Checked = True Then
            GunaAdvenceButton15.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = True

            dataText.GetCharacterDatabase("SUJ2")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton14_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton14.Click
        If GunaAdvenceButton14.Checked = True Then
            GunaAdvenceButton14.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = True
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("SUS304")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton13_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton13.Click
        If GunaAdvenceButton13.Checked = True Then
            GunaAdvenceButton13.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = True
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("FCD500")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton12_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton12.Click
        If GunaAdvenceButton12.Checked = True Then
            GunaAdvenceButton12.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = False
            GunaAdvenceButton12.Checked = True
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("MFGC")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton11_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton11.Click
        If GunaAdvenceButton11.Checked = True Then
            GunaAdvenceButton11.Checked = False
            dataText.GetCharacterDatabase("")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        Else
            GunaAdvenceButton1.Checked = False
            GunaAdvenceButton2.Checked = False
            GunaAdvenceButton3.Checked = False
            GunaAdvenceButton4.Checked = False
            GunaAdvenceButton5.Checked = False
            GunaAdvenceButton6.Checked = False
            GunaAdvenceButton7.Checked = False
            GunaAdvenceButton8.Checked = False
            GunaAdvenceButton9.Checked = False
            GunaAdvenceButton10.Checked = False
            GunaAdvenceButton11.Checked = True
            GunaAdvenceButton12.Checked = False
            GunaAdvenceButton13.Checked = False
            GunaAdvenceButton14.Checked = False
            GunaAdvenceButton15.Checked = False

            dataText.GetCharacterDatabase("OTHER")
            GunaDataGridView1.DataSource = dataText.TextBind
            GunaTextBox1.Text = ""
        End If
    End Sub


    Dim xlBook
    Dim xlsheet As Excel.Worksheet
    Dim material() As String

    Public Function GetResults(text)
        Try
            If text.ToString.Contains(vbTab) = True Then
                material = text.ToString.Split(vbTab)
            Else

                material = text.ToString.Split(" ")
            End If
            Dim materialResult As Double
                xlsheet = xlBook.Sheets("RM Calculator")
            With xlsheet
                .Range("A15").Value = material(0)
                .Range("B15").Value = material(1)
                .Range("C15").Value = material(2)
            End With
            materialResult = xlsheet.Range("D15").Value
            TextBox2.AppendText(Math.Round(materialResult, 2, MidpointRounding.AwayFromZero).ToString + vbNewLine)

        Catch ex As Exception
            TextBox2.AppendText("" + vbNewLine)
            'MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
        Return 0
    End Function

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            If Not My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\calc.xlsx") Then

                Dim rm As Resources.ResourceManager
                rm = New Resources.ResourceManager("kmtiworkstationvb.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                Dim b As Byte()
                b = rm.GetObject("calc")
                System.IO.File.WriteAllBytes(My.Application.Info.DirectoryPath + "/calc.xlsx", b)
            End If
            Dim ExcelApp As New Microsoft.Office.Interop.Excel.Application
            TextBox2.Text = ""
            ExcelApp.Visible = False
            xlBook = ExcelApp.Workbooks.Open(My.Application.Info.DirectoryPath + "\calc.xlsx") 'My.Application.Info.DirectoryPath + "\calc.xlsx" C:\Users\KMTI-Admin\Desktop\calc.xlsx

            For Each txtLine As String In TextBox1.Lines
                GetResults(txtLine)
            Next
            xlBook.close(SaveChanges:=False)
            ExcelApp.Quit()

            Clipboard.SetText(TextBox2.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub GunaAdvenceButton16_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton16.Click
        Clipboard.SetText(GunaAdvenceButton16.Text)
    End Sub

    Private Sub GunaAdvenceButton17_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton17.Click
        Clipboard.SetText(GunaAdvenceButton17.Text)
    End Sub

    Private Sub GunaAdvenceButton18_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton18.Click
        Clipboard.SetText(GunaAdvenceButton18.Text)
    End Sub


    Private Sub GunaAdvenceButton19_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton19.Click
        Clipboard.SetText(GunaAdvenceButton19.Text)
    End Sub

    Private Sub GunaAdvenceButton20_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton20.Click
        Clipboard.SetText(GunaAdvenceButton20.Text)
    End Sub

    Private Sub GunaAdvenceButton21_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton21.Click
        Clipboard.SetText(GunaAdvenceButton21.Text)
    End Sub
    Dim ext = True

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If ext = True Then
            Dim i = 256

            GunaAdvenceButton22.Visible = False
            GunaAdvenceButton23.Visible = False
            GunaAdvenceButton24.Visible = False

            Do Until i = 45
                GunaPanel7.Size = New Size(221, i)

                i -= 1

            Loop
            GunaPanel9.Location = New Point(49, 146)

            ext = False
        Else
            Dim i = 46
            Do Until i = 256
                GunaPanel7.Size = New Size(221, i)
                i += 1
            Loop
            GunaPanel9.Location = New Point(49, 356)
            GunaAdvenceButton22.Visible = True
            GunaAdvenceButton23.Visible = True
            GunaAdvenceButton24.Visible = True
            ext = True
        End If
    End Sub
    Dim exts = True
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If exts = True Then
            Dim i = 256
            GunaAdvenceButton28.Visible = False
            GunaAdvenceButton29.Visible = False
            GunaAdvenceButton30.Visible = False

            Do Until i = 45
                GunaPanel9.Size = New Size(221, i)

                i -= 1

            Loop
            exts = False
        Else
            Dim i = 46
            Do Until i = 256
                GunaPanel9.Size = New Size(221, i)
                i += 1
            Loop
            GunaAdvenceButton28.Visible = True
            GunaAdvenceButton29.Visible = True
            GunaAdvenceButton30.Visible = True
            exts = True
        End If

    End Sub

    Private Sub GunaAdvenceButton22_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton22.Click

    End Sub
End Class