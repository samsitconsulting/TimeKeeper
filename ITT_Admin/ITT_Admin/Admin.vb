Public Class Admin

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timesheet.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserAdministration.Show()
        Me.Visible = False
    End Sub
End Class