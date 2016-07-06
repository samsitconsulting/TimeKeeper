Imports System.Data.SqlServerCe
Imports ITT_Admin.Variables
Public Class DBFunction
    Public Shared conn As New SqlCeConnection

    Public Shared strDataSource As String = "" & _
            "Data Source = C:\Users\" & _
            "Sam McClain\" & _
            "Documents\" & _
            "Visual Studio 2012\" & _
            "Projects\ITT_Admin\ITT_Admin\Database1.sdf"

    Public Shared adp As New SqlCeDataAdapter()
    Public Shared ds As New DataSet


    Public Shared Sub db_connect()

        conn.ConnectionString = strDataSource
        conn.Open()

    End Sub

    Public Shared Sub db_close()
        conn.Close()

    End Sub

    Public Shared Sub createUser(user_id As String,
                          password As String,
                          name As String,
                          chngpass_flag As String,
                          isAdmin As String)


        Dim insertCmd As SqlCeCommand = conn.CreateCommand

        ' Create the InsertCommand.
        insertCmd = New SqlCeCommand( _
            "insert into login(user_id,password,name,chngpass_flag,isAdmin) " & _
            "values ('" & user_id & "','" & password & "','" & name & "','" & chngpass_flag & "','" & isAdmin & "')", conn)


        adp.InsertCommand = insertCmd
        adp.InsertCommand.ExecuteNonQuery()


    End Sub

    Public Shared Sub updatePassword(user_id As String, password As String)
        Try
            Dim updateCmd As SqlCeCommand = conn.CreateCommand()
            updateCmd.CommandText = "UPDATE login SET password = '" & password & "', chngpass_flag ='N'" + _
                " WHERE user_id = '" & user_id & "'"

            MsgBox(updateCmd.CommandText)
           
            adp.UpdateCommand = updateCmd

            adp.UpdateCommand.ExecuteNonQuery()

            ds.Clear()
            adp.Fill(ds)

            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
          
        End Try

    End Sub

    Public Shared Sub deleteCmd()

    End Sub

    Public Shared Sub selectAllCmd(table As String)

        Dim selectCmd As SqlCeCommand = conn.CreateCommand
        selectCmd.CommandText = "SELECT * FROM " & table
        adp.SelectCommand = selectCmd
        adp.Fill(ds)
    End Sub

    Public Shared Sub selectAllCmd(table As String, where As String)

        Dim selectCmd As SqlCeCommand = conn.CreateCommand
        selectCmd.CommandText = "SELECT * FROM " & table
        adp.SelectCommand = selectCmd
        adp.Fill(ds)
    End Sub



    Public Shared Function isValidUser(user_id As String, password As String)
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
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function


    Public Shared Function changePassword(user_id As String, password As String)
        Try
            Dim selectCmd As SqlCeCommand = conn.CreateCommand
            selectCmd.CommandText = "SELECT chngpass_flag FROM login where user_id = '" & user_id & "' and password = '" & password & "'"
            adp.SelectCommand = selectCmd
            adp.Fill(ds)


            For Each row As DataRow In ds.Tables.Item(0).Rows
                chngpasswd_flag = row.Item("chngpass_flag").ToString()

            Next
            If chngpasswd_flag.Equals("N") Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function


    Public Shared Function changePassword(ds As DataSet)
        Try

            For Each row As DataRow In ds.Tables.Item(0).Rows
                chngpasswd_flag = row.Item("chngpass_flag").ToString()

            Next
            If chngpasswd_flag.Equals("N") Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

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
