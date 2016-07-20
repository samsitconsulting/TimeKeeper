Imports ITT_Admin.Variables
Imports ITT_Admin.DBFunction

Public Class Timesheet

    Private Sub Timesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.timesheet' table. You can move, or remove it, as needed.
        lblUsername.Text = "Welcome " & username
        DateTimePicker1.Enabled = False

        If getTime(userid, DateTime.Now.Date) Then
            Dim idxtimeIn As Integer = timeIn.IndexOf(" ") + 1

            lblTimeInData.Text = timeIn.Substring(idxtimeIn)

            If timeOut <> vbNullString Then
                Dim idxtimeOut As Integer = timeOut.IndexOf(" ") + 1
                lblTimeOutData.Text = timeOut.Substring(idxtimeOut)
                btnSignIn_Out.Enabled = False
            End If
        End If





    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Me.Close()
        'ITT_Admin.frmLoginScreen.Close()
        Application.Exit()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnSignIn_Out_Click(sender As Object, e As EventArgs) Handles btnSignIn_Out.Click

        If String.IsNullOrEmpty(lblTimeInData.Text) Then

            lblTimeInData.Text = DateAndTime.TimeString
            insertTime(userid, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"))

        Else

            lblTimeOutData.Text = DateAndTime.TimeString
            getTime(userid, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"))
            updateTime(userid, timeIn, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), workDate)

            btnSignIn_Out.Enabled = False

        End If
    End Sub

End Class