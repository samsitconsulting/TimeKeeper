Imports System.Net.Mime.MediaTypeNames
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Reports

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If diaFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFolder.Text = diaFolder.FileName.ToString

        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

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
       ' End If

        ' Add some data to individual cells.
        worksheet.Cells(1, 1) = "A"
        worksheet.Cells(1, 2) = "B"
        worksheet.Cells(1, 3) = "C"

        ' Save the changes and close the workbook.
        workbook.Close(SaveChanges:=True)

        ' Close the Excel server.
        APP.Quit()

        MsgBox("Done")


        '  MsgBox(txtFolder.Text)
        Me.Close()
    End Sub

    Private Sub txtFolder_TextChanged(sender As Object, e As EventArgs) Handles txtFolder.TextChanged

    End Sub
End Class