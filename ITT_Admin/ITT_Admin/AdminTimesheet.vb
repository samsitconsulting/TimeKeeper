Imports ITT_Admin.Variables
Imports ITT_Admin.DBFunction

Public Class AdminTimesheet

    Private Sub AdminTimesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.timesheet' table. You can move, or remove it, as needed.
        '  lblUsername.Text = "Welcome " & username
        'DateTimePicker1.Enabled = False

        Dim users As DataSet = getUsers()

        ' cbxUsers.Items.Add("--- New User ---")

        For Each row As DataRow In users.Tables.Item(0).Rows
            cbxUsers.Items.Add(row.Item("name").ToString & " (" & row.Item("user_Id").ToString & ")")

        Next

        'If getTime(userid, DateTime.Now.Date) Then
        'Dim idxtimeIn As Integer = timeIn.IndexOf(" ") + 1

        'lblTimeInData.Text = timeIn.Substring(idxtimeIn)

        ' If timeOut <> vbNullString Then
        ' Dim idxtimeOut As Integer = timeOut.IndexOf(" ") + 1
        ' lblTimeOutData.Text = timeOut.Substring(idxtimeOut)
        '   btnSignIn_Out.Enabled = False
        'End If
        'End If





    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Admin.Show()
        Me.Close()
        'ITT_Admin.frmLoginScreen.Close()
        'Application.Exit()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnSignIn_Out_Click(sender As Object, e As EventArgs) Handles btnSignIn_Out.Click

        'If String.IsNullOrEmpty(lblTimeInData.Text) Then

        'lblTimeInData.Text = DateAndTime.TimeString
        ' insertTime(userid, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"))

        '  Else

        ' lblTimeOutData.Text = DateAndTime.TimeString
        ' getTime(userid, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"))
        '  updateTime(userid, timeIn, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), workDate)

        btnSignIn_Out.Enabled = False

        '  End If
        Dim userData As String = cbxUsers.SelectedItem.ToString.Substring(cbxUsers.SelectedItem.ToString.IndexOf("(") + 1)
        'getUserId(txtFullname.Text) 
        userData = userData.Substring(0, userData.ToString.IndexOf(")"))
        Dim user As String = userData
        'MsgBox(userData)
        'MsgBox(dtpTimesheet.Value.Date)
        Dim signInData As Date
        Dim signOutData As Date

        Try
            signInData = dtpTimesheet.Value.Date & " " & txtSignIn.Text
            signOutData = dtpTimesheet.Value.Date & " " & txtSignOut.Text
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


        'MsgBox(signInData)
        'MsgBox(txtSignOut.Text)
        If getTime(user, dtpTimesheet.Value.Date) Then
            adjustTime(user, signInData, signOutData, workDate)
        Else
            insertTime(user, signInData, signOutData, dtpTimesheet.Value.ToString("MM/dd/yyyy HH:mm:ss"))
        End If

    End Sub

    Private Sub cbxUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUsers.SelectedIndexChanged
        Dim user As String = cbxUsers.SelectedItem.ToString.Substring(0, cbxUsers.SelectedItem.ToString.IndexOf("(") - 1)
        'MsgBox(txtFullname.Text)
        Dim userData As String = cbxUsers.SelectedItem.ToString.Substring(cbxUsers.SelectedItem.ToString.IndexOf("(") + 1)
        'getUserId(txtFullname.Text) 
        userData = userData.Substring(0, userData.ToString.IndexOf(")"))
        user = userData
        'MsgBox(txtUserId.Text)


        getTime(getUserId(user), dtpTimesheet.Value.ToShortDateString) '.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
    End Sub
End Class