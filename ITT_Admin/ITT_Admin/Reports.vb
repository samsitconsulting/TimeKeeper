Imports ITT_Admin.DBFunction
Imports System.Net.Mime.MediaTypeNames
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Reports

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        diaFolder.Filter = "Excel files (*.xlsx)|*.xls|All files (*.*)|*.*"

        If diaFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFolder.Text = diaFolder.FileName.ToString

        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim currDate As String = dtpReport.Value


        Dim APP As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook
        workbook = APP.Workbooks.Add()


        workbook.SaveAs(txtFolder.Text)

        ' Open the workbook.
        '    workbook = _
        'APP.Workbooks.Open(Filename:=txtFolder.Text)

        ' See if the worksheet already exists.

        ' If (workbook Is Nothing) Then
        ' Add the worksheet at the end.
        worksheet = workbook.Sheets.Add( _
            After:=workbook.Sheets(workbook.Sheets.Count), _
            Count:=1, _
            Type:=Excel.XlSheetType.xlWorksheet)
        'worksheet.Name = worksheet
        ' End Ifo

        Dim reportData As DataSet = getReportTimes(currDate)
        Dim count As Integer = 2
        ' cbxUsers.Items.Add("--- New User ---")
        worksheet.Cells(1, 1) = "Name"
        worksheet.Cells(1, 2) = "UserId"
        worksheet.Cells(1, 3) = "Time In"
        worksheet.Cells(1, 4) = "Time Out"

        For Each row As DataRow In reportData.Tables.Item(0).Rows
            'Dim userData As String = getUserName(row.Item("user_Id").ToString)
            'MsgBox(" (" & row.Item("user_Id").ToString & ") = " & row.Item("time_in").ToString & " to " & row.Item("time_out").ToString)
            worksheet.Cells(count, 1) = row.Item("name").ToString
            worksheet.Cells(count, 2) = row.Item("user_Id").ToString
            worksheet.Cells(count, 3) = row.Item("time_in").ToString
            worksheet.Cells(count, 4) = row.Item("time_out").ToString

            count = count + 1

        Next
        ' Add some data to individual cells.

        ' Save the changes and close the workbook.
        workbook.Close(SaveChanges:=True)

        ' Close the Excel server.
        APP.Quit()

        MsgBox("Done")


        '  MsgBox(txtFolder.Text)
        'Me.Close()
    End Sub

    Private Sub txtFolder_TextChanged(sender As Object, e As EventArgs) Handles txtFolder.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Admin.Show()
        Me.Close()
    End Sub
End Class