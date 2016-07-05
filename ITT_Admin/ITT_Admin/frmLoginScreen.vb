Imports System.Data.Sql
Imports System.Data.SqlClient
Imports ITT_Admin.Variables

Public Class frmLoginScreen


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Dim myConn As SqlConnection
        'myConn = New SqlConnection("Data Source=" & """C:\Users\Sam McClain\Documents\Visual Studio 2012\Projects\ITT_Admin\ITT_Admin\Database1.sdf""")
        'MessageBox.Show("Data Source=" & """C:\Users\Sam McClain\Documents\Visual Studio 2012\Projects\ITT_Admin\ITT_Admin\Database1.sdf""", "test")
        'myConn.Open()
        Dim rowindex As Integer
        Dim found As Boolean = False

        For Each row As DataGridViewRow In dgLogin.Rows


            If row.Cells.Item("user_id").Value = txtUserID.Text Then
                rowindex = row.Index.ToString()
                lblUser.Text = rowindex.ToString
                If txtPassword.Text = dgLogin.Rows(rowindex).Cells(1).Value Then
                    lblPass.Text = dgLogin.Rows(rowindex).Cells(2).Value
                    found = True
                    '   Dim actie As String = row.Cells("PRICE").Value.ToString()
                    ' MsgBox(dgLogin.Rows(rowindex).Cells(3).Value.ToString)
                    ' MsgBox(dgLogin.Rows(rowindex).Cells(3).Value.ToString)
                    userPassword = dgLogin.Rows(rowindex).Cells(1).Value
                    username = dgLogin.Rows(rowindex).Cells(2).Value
                    userid = txtUserID.Text
                    '  row.Cells.Item("chngpass_flag").Value = "Y"
                    ' MsgBox(row.Cells.Item("chngpass_flag").Value.ToString)
                    If row.Cells.Item("chngpass_flag").Value.Equals("Y") Then
                        'ChangePwd.Show()
                        chngpasswd_flag = row.Cells.Item("chngpass_flag").Value
                    Else
                        'set if chngpaswd not equal to Y
                        chngpasswd_flag = "N"

                    End If

                    'MsgBox(dgLogin.ColumnCount.ToString)
                   

                    ' Else
                    'MsgBox("you got a prob yo")
                    '  Exit For
                End If
            End If
        Next

        If found Then

            'changed this to one big if statement because timesheet would be called and you could update even
            'though you needed to change your password.  Admin and Timesheet are now called in ChangePwd after
            'the users password is changed.
            'MsgBox(chngpasswd_flag)

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

            ' txtPassword.Text = dgLogin.Rows(rowindex).Cells(1).Value

    End Sub

    Private Sub frmLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgLogin.Visible = False
        LoginTableAdapter.Update(Me.Database1DataSet1.login)
        Me.LoginTableAdapter.Fill(Me.Database1DataSet1.login)
        'TODO: This line of code loads data into the 'Database1DataSet11.login' table. You can move, or remove it, as needed.
        ' Me.LoginTableAdapter.Fill(Me.Database1DataSet11.login)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' dgLogin.Rows.Insert(4,new object[]{"3","sam","sam haney"})
        ' BindingSource["LoginBindingSource"].AddNew()
        ' Me.LoginBindingSource.New()
        'Database1DataSet1.login.AddloginRow("3", "sam", "sam haney")
        'Database1DataSet1.Tables.Add("login").Rows.Add(Database1DataSet1.login.AddloginRow("3", "sam", "sam haney"))
        Dim row As DataRow = Database1DataSet1.Tables("login").NewRow()

        With row
            .Item("user_id") = txtUserID.Text
            .Item("password") = txtPassword.Text
            .Item("name") = "sam haney"
        End With

        Database1DataSet1.Tables("login").Rows.Add(row)
        LoginTableAdapter.Update(Me.Database1DataSet1.login)
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.LoginTableAdapter.FillBy(Me.Database1DataSet1.login)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub chkAdmin()
        Dim row As DataRow = Database1DataSet1.Tables("login").NewRow()



       
    End Sub
End Class
