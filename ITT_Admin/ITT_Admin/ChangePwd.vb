Imports ITT_Admin.Variables
Imports ITT_Admin.DBFunction

Public Class ChangePwd

    Private Sub ChangePwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'remove login screen before displaying message to user.  
        frmLoginScreen.Visible = False
        'message instructing the user to change their password
        MsgBox(username + ", Please Change Your Password")
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtCurrentPwd.Text = userPassword Then
            If txtNewPwd.Text = txtNewPwdChk.Text And Not txtNewPwd.Text = "" Then
                MsgBox(userid)
                updatePassword(userid, txtNewPwdChk.Text)
                Me.Visible = False

                If isAdmin Then
                    Admin.Show()
                Else
                    Timesheet.Show()
                End If
            Else
                MsgBox("New Passwords do not match")
            End If
        Else
            MsgBox("Current Password incorrect")
        End If


    End Sub

  
End Class