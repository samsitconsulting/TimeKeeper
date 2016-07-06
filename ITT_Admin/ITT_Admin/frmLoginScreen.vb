Imports System.Data.Sql
Imports System.Data.SqlClient
Imports ITT_Admin.Variables
Imports ITT_Admin.DBFunction

Public Class frmLoginScreen


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        db_close()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        'changed this to one big if statement because timesheet would be called and you could update even
        'though you needed to change your password.  Admin and Timesheet are now called in ChangePwd after
        'the users password is changed.

        If isValidUser(txtUserID.Text, txtPassword.Text) Then


            If chngpasswd_flag.Equals("Y") Then
                ChangePwd.Show()

            ElseIf isAdmin Then
                Admin.Show()

            Else
                Timesheet.Show()
            End If

            Me.Visible = False
        Else
            MsgBox("Please Contact your System Administrator.")

        End If


    End Sub

    Private Sub frmLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db_connect()

    End Sub


End Class
