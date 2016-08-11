Imports System.Data.SqlServerCe
Imports ITT_Admin.Variables
Public Class DBFunction
    Public Shared conn As New SqlCeConnection("" & _
            "Data Source = C:\Users\" & _
            "Sam McClain\" & _
            "Documents\" & _
            "Visual Studio 2012\" & _
            "Projects\ITT_Admin\ITT_Admin\Database1.sdf")

    ' Public Shared strDataSource As String = 

    Public Shared adp As New SqlCeDataAdapter()
    Public Shared ds As New DataSet


    Public Shared Sub db_open()

        '     conn.ConnectionString = strDataSource
        If conn.State.ToString() = "Open" Then
            conn.Close()
            conn.Open()
        Else

            conn.Open()

        End If
        ds.Clear()

    End Sub

    Public Shared Sub db_close()
        If conn.State.ToString() = "Open" Then
            conn.Close()
        End If


    End Sub

    Public Shared Sub createUser(user_id As String,
                          password As String,
                          name As String,
                          chngpass_flag As String,
                          isAdmin As String)

        db_open()

        Dim insertCmd As SqlCeCommand = conn.CreateCommand

        ' Create the InsertCommand.
        insertCmd = New SqlCeCommand( _
            "insert into login(user_id,password,name,chngpass_flag,isAdmin) " & _
            "values ('" & user_id & "','" & password & "','" & name & "','" & chngpass_flag & "','" & isAdmin & "')", conn)


        adp.InsertCommand = insertCmd
        adp.InsertCommand.ExecuteNonQuery()

        db_close()

    End Sub

    Public Shared Sub updateUser(user_id As String,
                          name As String,
                          chngpass_flag As String,
                          is_admin As String)


        db_open()
        Try
            Dim updateCmd As SqlCeCommand = conn.CreateCommand()
            updateCmd.CommandText = "UPDATE login SET isAdmin = '" & is_admin & "'," & _
                                                    " name = '" & name & "'," & _
                                                    " chngpass_flag = '" & chngpass_flag & "'" & _
                " WHERE user_id = '" & user_id & "'"

            'MsgBox(updateCmd.CommandText)

            adp.UpdateCommand = updateCmd

            adp.UpdateCommand.ExecuteNonQuery()

            ds.Clear()
            adp.Fill(ds)

            db_close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        db_close()

    End Sub
    Public Shared Sub updatePassword(user_id As String, password As String)

        db_open()
        Try
            Dim updateCmd As SqlCeCommand = conn.CreateCommand()
            updateCmd.CommandText = "UPDATE login SET password = '" & password & "', chngpass_flag ='N'" + _
                " WHERE user_id = '" & user_id & "'"

            'MsgBox(updateCmd.CommandText)

            adp.UpdateCommand = updateCmd

            adp.UpdateCommand.ExecuteNonQuery()

            ds.Clear()
            adp.Fill(ds)

            db_close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Shared Sub deleteCmd()

    End Sub

    Public Shared Sub selectAllCmd(table As String)
        db_open()

        Dim selectCmd As SqlCeCommand = conn.CreateCommand
        selectCmd.CommandText = "SELECT * FROM " & table
        adp.SelectCommand = selectCmd
        adp.Fill(ds)
        db_close()

    End Sub

    Public Shared Function getUsers()
        db_open()

        Dim selectCmd As SqlCeCommand = conn.CreateCommand
        selectCmd.CommandText = "SELECT * FROM login"
        adp.SelectCommand = selectCmd
        adp.Fill(ds)
        db_close()


        Return ds


    End Function

    Public Shared Sub selectAllCmd(table As String, where As String)
        db_open()

        Dim selectCmd As SqlCeCommand = conn.CreateCommand
        selectCmd.CommandText = "SELECT * FROM " & table
        adp.SelectCommand = selectCmd
        adp.Fill(ds)
        db_close()

    End Sub



    Public Shared Function isValidUser(user_id As String, password As String)
        db_open()
        Try
            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT * FROM login where user_id = '" & user_id & "' and password = '" & password & "'"
            adp.SelectCommand = selectCmd
            adp.Fill(ds)

            If ds.Tables.Item(0).Rows.Count < 1 Then
                Return False
            Else

                For Each row As DataRow In ds.Tables.Item(0).Rows
                    chngpasswd_flag = row.Item("chngpass_flag").ToString()
                    username = row.Item("name").ToString()
                    userPassword = row.Item("password").ToString()
                    userid = row.Item("user_id").ToString()
                    rowindex = ds.Tables.Item(0).Rows.IndexOf(row)
                    If row.Item("isAdmin").Equals("Y") Then
                        isAdmin = True
                    Else
                        isAdmin = False
                    End If
                Next
                Return True
            End If

            db_close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function



    Public Shared Function isValidUser(user_id As String)
        db_open()
        ds.Clear()

        Try
            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT * FROM login where user_id = '" & user_id & "'"
            adp.SelectCommand = selectCmd
            adp.Fill(ds)

            If ds.Tables.Item(0).Rows.Count < 1 Then
                Return False
            Else
                Return True
            End If

            db_close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Public Shared Function isUserAdmin(vuserid As String)

        'MsgBox(vuserid)
        db_open()
        ds.Clear()
        Try
            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT isAdmin FROM login where user_id = '" & vuserid & "'"
            adp.SelectCommand = selectCmd
            ' MsgBox(selectCmd.CommandText)

            adp.Fill(ds)
            'MsgBox(ds.Tables.Item(0).Rows.Count)
            If ds.Tables.Item(0).Rows.Count < 1 Then
                Return "N"
            Else

                For Each row As DataRow In ds.Tables.Item(0).Rows


                    Return row.Item("isAdmin").ToString


                Next

            End If

            db_close()
            Return "N"
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "N"

        End Try

    End Function



    Public Shared Function getUserId(vusername As String)
        db_open()
        Try
            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT * FROM login where name = '" & vusername & "'"
            adp.SelectCommand = selectCmd
            adp.Fill(ds)

            If ds.Tables.Item(0).Rows.Count < 1 Then
                Return ""
            Else

                For Each row As DataRow In ds.Tables.Item(0).Rows

                    Return row.Item("user_id").ToString

                Next

            End If

            db_close()
            Return ""
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""
        End Try

    End Function

    Public Shared Function getUserName(vuserid As String)
        db_open()
        Try
            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT * FROM login where user_id = '" & vuserid & "'"
            adp.SelectCommand = selectCmd

            ds.Clear()

            adp.Fill(ds)

            If ds.Tables.Item(0).Rows.Count < 1 Then
                Return ""
            Else

                For Each row As DataRow In ds.Tables.Item(0).Rows

                    Return row.Item("name").ToString

                Next

            End If

            db_close()
            Return ""
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""
        End Try

    End Function
    Public Shared Function getChangePassword(vuserid As String)
        db_open()
        ds.Clear()
        Try
            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT * FROM login where user_id = '" & vuserid & "'"
            adp.SelectCommand = selectCmd
            ' MsgBox(selectCmd.CommandText)
            adp.Fill(ds)

            If ds.Tables.Item(0).Rows.Count < 1 Then
                Return "N"
            Else

                For Each row As DataRow In ds.Tables.Item(0).Rows
                    Return row.Item("chngpass_flag").ToString()
                Next

            End If

            db_close()
            Return "N"
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "N"

        End Try

    End Function

    Public Shared Function changePassword(user_id As String, password As String)
        db_open()
        Try
            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT chngpass_flag FROM login where user_id = '" & user_id & "' and password = '" & password & "'"
            adp.SelectCommand = selectCmd
            adp.Fill(ds)


            For Each row As DataRow In ds.Tables.Item(0).Rows
                chngpasswd_flag = row.Item("chngpass_flag").ToString()

            Next
            If chngpasswd_flag.Equals("N") Then
                db_close()
                Return False
            Else
                db_close()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            db_close()
            Return False

        End Try

    End Function


    Public Shared Function changePassword(ds As DataSet)
        db_open()
        Try

            For Each row As DataRow In ds.Tables.Item(0).Rows
                chngpasswd_flag = row.Item("chngpass_flag").ToString()

            Next
            If chngpasswd_flag.Equals("N") Then
                db_close()
                Return False
            Else
                db_close()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            db_close()
            Return False

        End Try

    End Function


    Public Shared Sub insertTime(user_id As String,
                          time_in As Date,
                          work_date As Date,
                          created_date As Date
                          )

        db_open()

        Dim insertCmd As SqlCeCommand = conn.CreateCommand
        insertCmd = New SqlCeCommand( _
           "insert into timesheet(user_id,time_in,time_out,work_date,created_date) " & _
          "values ('" & user_id & "','" & time_in & "',NULL,'" & work_date & "','" & created_date & "')", conn)


        adp.InsertCommand = insertCmd
        adp.InsertCommand.ExecuteNonQuery()

        db_close()
        ' insertTime(user_id, time_in, New Nullable(Of Date), work_date, created_date)

    End Sub

    Public Shared Sub insertTime(user_id As String,
                         time_in As Date,
                         time_out As Date,
                         work_date As Date,
                         created_date As Date
                         )

        db_open()

        Dim insertCmd As SqlCeCommand = conn.CreateCommand
        ' Create the InsertCommand.
        insertCmd = New SqlCeCommand( _
           "insert into timesheet(user_id,time_in,time_out,work_date,created_date) " & _
           "values ('" & user_id & "','" & time_in & "','" & time_out & "','" & work_date & "','" & Date.Now.ToString("MM/dd/yyyy HH:mm:ss") & "')", conn)


        adp.InsertCommand = insertCmd
        adp.InsertCommand.ExecuteNonQuery()

        db_close()

    End Sub

    Public Shared Sub updateTime(user_id As String,
                                 time_in As Date,
                                 time_out As Date,
                                 work_date As Date)


        db_open()
        Try
            Dim updateCmd As SqlCeCommand = conn.CreateCommand()
            updateCmd.CommandText = "UPDATE timesheet SET time_out = '" & time_out & "'" & _
                " WHERE user_id = '" & user_id & "'" & _
                " and time_in = '" & time_in & "'" & _
                " and work_date = '" & work_date & "'"

            MsgBox(updateCmd.CommandText)

            adp.UpdateCommand = updateCmd

            adp.UpdateCommand.ExecuteNonQuery()

            ds.Clear()
            adp.Fill(ds)

            db_close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        db_close()

    End Sub


    Public Shared Sub adjustTime(user_id As String,
                                 time_in As Date,
                                 time_out As Date,
                                 work_date As Date)


        db_open()
        Try
            Dim updateCmd As SqlCeCommand = conn.CreateCommand()
            updateCmd.CommandText = "UPDATE timesheet SET time_out = '" & time_out & "', time_in = '" & time_in & "'" & _
                " WHERE user_id = '" & user_id & "'" & _
                " and work_date = '" & work_date & "'"

            MsgBox(updateCmd.CommandText)

            adp.UpdateCommand = updateCmd

            adp.UpdateCommand.ExecuteNonQuery()

            ds.Clear()
            adp.Fill(ds)

            db_close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        db_close()

    End Sub



    Public Shared Function getTime(user_id As String, work_date As Date)
        db_open()
        Try

            Dim sYear As String = work_date.Year.ToString()
            Dim sMonth As String = work_date.Month.ToString().PadLeft(2, "0")
            Dim sDay As String = work_date.Day.ToString().PadLeft(2, "0")

            Dim caseTime As String = sMonth & "/" & sDay & "/" & sYear

            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT * FROM timesheet where user_id = '" & user_id & "' and CONVERT(nvarchar(10),work_date,101)  = CONVERT(nvarchar(10),'" & caseTime & "',101)"

            adp.SelectCommand = selectCmd
            ds.Clear()
            adp.Fill(ds)

            If ds.Tables.Item(0).Rows.Count < 1 Then
                timeIn = ""
                timeOut = ""
                workDate = ""
                Return False
            Else

                For Each row As DataRow In ds.Tables.Item(0).Rows
                    timeIn = row.Item("time_in").ToString
                    timeOut = row.Item("time_out").ToString
                    workDate = row.Item("work_date").ToString

                Next
                Return True
            End If

            db_close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function



    Public Shared Function getReportTimes(work_date As Date)
        db_open()
        Try

            Dim sYear As String = work_date.Year.ToString()
            Dim sMonth As String = work_date.Month.ToString().PadLeft(2, "0")
            Dim sDay As String = work_date.Day.ToString().PadLeft(2, "0")

            Dim caseTime As String = sMonth & "/" & sDay & "/" & sYear

            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT l.user_id, l.name, t.time_in, t.time_out FROM login AS l INNER JOIN timesheet AS t ON l.user_id = t.user_id where CONVERT(nvarchar(10),work_date,101)  = CONVERT(nvarchar(10),'" & caseTime & "',101)"
            adp.SelectCommand = selectCmd

            ds.Clear()
            adp.Fill(ds)

            If ds.Tables.Item(0).Rows.Count < 1 Then

                Return ""
            Else

                
                Return ds
            End If

            db_close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""

        End Try

    End Function

    '        Try
    '    Dim strDataSource As String
    '            strDataSource = "" & _
    '                "Data Source = C:\Users\" & _
    '                "Sam McClain\" & _
    '                "Documents\" & _
    '                "Visual Studio 2012\" & _
    '"Projects\WindowsApplication1\WindowsApplication1\Database1.sdf"

    '    Dim conn As New SqlCeConnection
    '            conn.ConnectionString = strDataSource

    '    Dim selectCmd As SqlCeCommand = conn.CreateCommand
    '            selectCmd.CommandText = "SELECT * FROM login"

    '    Dim adp As New SqlCeDataAdapter()

    '    Dim ds As New DataSet

    '            adp.SelectCommand = selectCmd

    '    ' Note: Fill will leave the connection in its original state;
    '    ' In this case, the connection was closed so it will be left closed
    '            adp.Fill(ds)

    '            For Each dr As DataRow In ds.Tables(0).Rows
    '                MsgBox(dr.Item("user_id").ToString)
    '            Next

    '            MsgBox(("The SqlCeDataAdapter succesfully filled " & _
    '                               ds.Tables.Item(0).Rows.Count & " rows in the DataSet!"))


    '    Dim insertCmd As SqlCeCommand = conn.CreateCommand

    '    ' Create the InsertCommand.
    '            insertCmd = New SqlCeCommand( _
    '                "insert into login(user_id,password,name,chngpass_flag,isAdmin) " & _
    '                "values ('15987041','password','Sam','Y','Y')", conn)


    '            adp.InsertCommand = insertCmd
    '            conn.Open()
    '            adp.InsertCommand.ExecuteNonQuery()


    '    Dim updateCmd As SqlCeCommand = conn.CreateCommand()
    '            updateCmd.CommandText = "UPDATE login SET name = 'Sam Haney'" + _
    '                " WHERE user_id = 15987041"


    '            adp.UpdateCommand = updateCmd
    '            adp.UpdateCommand.ExecuteNonQuery()




    '            adp.SelectCommand = selectCmd
    '            ds.Clear()

    '            adp.Fill(ds)

    '            For Each dr As DataRow In ds.Tables(0).Rows
    '                MsgBox(dr.Item("user_id").ToString)
    '            Next
    '        Catch ds As Exception
    '            MsgBox(ds.Message)
    '        Finally
    '            MsgBox(vbNewLine & vbNewLine & vbNewLine & _
    '                              "Press any key to continue...")
    '        End Try


End Class