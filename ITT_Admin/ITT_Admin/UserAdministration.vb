Public Class UserAdministration

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub UserAdministration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.Database1DataSet1.login)

    End Sub
End Class