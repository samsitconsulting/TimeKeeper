Imports ITT_Admin.Variables

Public Class ChangePwd

    Private Sub ChangePwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'remove login screen before displaying message to user.  
        frmLoginScreen.Visible = False
        'message instructing the user to change their password
        MsgBox(username + ", Please Change Your Password")
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'create a new DataRow to hold temp data.  base this off the login table
        Dim row As DataRow = Database1DataSet1.Tables("login").NewRow()

        'set the row equal to the credentials supplied at the login screen
        'dont forget the changpasswd_flg
        With row
            .Item("user_id") = userid
            .Item("password") = userPassword
            .Item("name") = username
            .Item("chngpass_flag") = chngpasswd_flag

        End With

        'LEAVE FOR TESTING.  Used to make sure we're looking at the correct record
        ' MsgBox("Record: " + " Userid: " + userid + " user pass: " + userPassword + " user name: " + username + " change flag: " + chngpasswd_flag)
        'REMOVE AFTER TESTING ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


        'check to make sure both passwords match and the current password matches the current password
        'in the database
        If txtNewPwd.Text = txtNewPwdChk.Text And Not txtNewPwd.Text = "" And txtCurrentPwd.Text = userPassword Then
            'prevent user from clicking 'OK' more than once
            btnOK.Visible = False

            'set ChangePwd visible to false 
            Me.Visible = False

            'check to see if user is admin or not.  correct screen is called depending on admin status
            'ChangePwd screen is disposed of.
            If isAdmin Then
                Admin.Show()

            Else
                Timesheet.Show()
            End If

            '--write changes to the database while the user is on the next screen.  the DB writes took a couple of seconds
            'so i wanted to have that done in the background.

            'remove the current record based on the userid.  we need to look into
            'making this an update.  
            LoginTableAdapter.Delete(Original_user_id:=userid)

            'set the new row record values.  after testing set chngpass_flag to 'N'
            row.Item("password") = txtNewPwd.Text
            row.Item("chngpass_flag") = "N"

            'write the new rows to the "temp" table (table you see when we drag it to the screen)
            Database1DataSet1.Tables("login").Rows.Add(row)

            'update the main table 
            LoginTableAdapter.Update(Me.Database1DataSet1.login)


            Me.Close()
        Else
            'if the current password does not equal to the current pass in the DB then display error
            If Not txtCurrentPwd.Text = userPassword Then
                MsgBox("Current Password Incorrect")
            Else
                'display error if new passwords do not match
                MsgBox("New Passwords do not match!")
            End If
        End If
    End Sub

  
End Class