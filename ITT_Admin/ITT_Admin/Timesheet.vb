Imports ITT_Admin.Variables

Public Class Timesheet

    Private Sub Timesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.timesheet' table. You can move, or remove it, as needed.
        lblUsername.Text = "Welcome " & username
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
        Else
            lblTimeOutData.Text = DateAndTime.TimeString
            btnSignIn_Out.Enabled = False
        End If
    End Sub

End Class