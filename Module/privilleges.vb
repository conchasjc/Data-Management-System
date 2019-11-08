Module privilleges
    Public Sub UserPriv()
        Frm_Char.GunaPanel7.Visible = False

        Frm_purchased.GunaAdvenceButton1.Visible = False
        Frm_purchased.Btn_DeletePart.Visible = False
        My.Settings.Login_Status = "online"
        frm_splash.TSMenu_Login.Visible = False
        frm_splash.TSMenu_Logout.Visible = True
    End Sub
    Public Sub AdminPriv()

        Frm_purchased.GunaAdvenceButton1.Visible = True
        Frm_purchased.Btn_DeletePart.Visible = True
        Frm_Char.GunaPanel7.Visible = True

        My.Settings.Login_Status = "online"
        frm_splash.TSMenu_Login.Visible = False
        frm_splash.TSMenu_Logout.Visible = True
    End Sub
End Module
