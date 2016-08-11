Public Class Admin

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLogTime.Click
        Timesheet.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        UserAdministration.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdjustTime.Click
        AdminTimesheet.Show()
        Me.Close()
    End Sub

    Private Sub btnGenerateRpt_Click(sender As Object, e As EventArgs) Handles btnGenerateRpt.Click
        Reports.Show()
        Me.Close()
    End Sub
End Class