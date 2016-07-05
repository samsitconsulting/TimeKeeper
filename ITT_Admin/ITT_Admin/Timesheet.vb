Imports ITT_Admin.Variables

Public Class Timesheet

    Private Sub Timesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.timesheet' table. You can move, or remove it, as needed.
        Me.TimesheetTableAdapter.Fill(Me.Database1DataSet1.timesheet)
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

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.TimesheetTableAdapter.FillBy(Me.Database1DataSet1.timesheet)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FillByToolStrip.ItemClicked

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class