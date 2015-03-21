Imports System.Data.SqlClient

Public Class HomeDatabase
    Public Shared Function connection()
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("ATCorpConnectionString").ConnectionString
        Return strConnString
    End Function

    Public Shared Sub spParamAdd(ByRef cmd As SqlCommand, ByVal paramName As String, ByVal dataType As SqlDbType, ByVal value As Object)
        'This Case statement selects the data type that the stored procedure could be and converts accordingly
        'Need to make sure we have the correct datatype, add more as needed!
        Select Case dataType
            Case SqlDbType.VarChar
                cmd.Parameters.AddWithValue(paramName, CStr(value)).DbType = dataType
            Case SqlDbType.Int
                cmd.Parameters.AddWithValue(paramName, CInt(value)).DbType = dataType
            Case SqlDbType.SmallInt
                cmd.Parameters.AddWithValue(paramName, CSng(value)).DbType = dataType
        End Select

    End Sub

    Public Shared Sub spSelect(ByRef cmd As SqlCommand, ByVal spName As String)
        'Selects the command type and the stored procedure from the connected database
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = spName
    End Sub

    Public Shared Sub spExecuteToRepeater(ByRef con As SqlConnection, ByRef cmd As SqlCommand, ByRef rpt As Repeater)
        Try
            'Connect to the Database
            cmd.Connection = con
            con.Open()
            'Select the Datasource for the repeater
            rpt.DataSource = cmd.ExecuteReader()
            'Bind the data to the repeater
            rpt.DataBind()
        Catch ex As Exception
            'If not then throw an error
            Throw ex
        Finally
            'And Finally close the database connection
            con.Close()
            con.Dispose()
        End Try
    End Sub

    Public Shared Function spExecuteToDt(ByRef cmd As SqlCommand, spName As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        Try
            'CreateSQL Command
            Dim MySQL2 As SqlCommand
            'Choose SP
            MySQL2 = New SqlCommand(spName, con)
            MySQL2.CommandType = CommandType.StoredProcedure
            'Fill Datatable using a DataAdapter
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = MySQL2
            DataAdapter.Fill(dt)
            'Send the table back to the user
            Return dt
        Catch ex As Exception
            'If not then throw an error
            Throw ex
        Finally
            'And Finally close the database connection
            con.Close()
            con.Dispose()
        End Try
    End Function

    Public Shared Sub spExecuteInsert(ByRef con As SqlConnection, ByRef cmd As SqlCommand)
        Try
            'Connect to the Database
            cmd.Connection = con
            con.Open()
            'Execute Stored Procedure
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'If not then throw an error
            Throw ex
        Finally
            'And Finally close the database connection
            con.Close()
            con.Dispose()
        End Try
    End Sub

    Public Shared Sub spExecuteToDropDownList(ByRef con As SqlConnection, ByRef cmd As SqlCommand, ByRef dd As DropDownList, textField As String, valuefield As String)
        Try
            'Connect to the Database
            cmd.Connection = con
            con.Open()
            'Select the Datasource for the dropdown
            dd.DataSource = cmd.ExecuteReader()
            dd.DataTextField = textField
            dd.DataValueField = valuefield
            dd.DataBind()
        Catch ex As Exception
            'If not then throw an error
            Throw ex
        Finally
            'And Finally close the database connection
            con.Close()
            con.Dispose()
        End Try
    End Sub
End Class
