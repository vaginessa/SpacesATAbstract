Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class UserSettings

    Public Shared Function GetUserSettings(ByVal userid As String, ByVal setting As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        'CreateSQL Command
        Dim MySQL2 As SqlCommand
        'Choose SP
        MySQL2 = New SqlCommand("GetUserSettings", con)
        MySQL2.CommandType = CommandType.StoredProcedure
        HomeDatabase.spParamAdd(MySQL2, "@SETTING", SqlDbType.VarChar, setting)
        HomeDatabase.spParamAdd(MySQL2, "@USERID", SqlDbType.Int, userid)
        'Fill Datatable using a DataAdapter
        Dim dt As New DataTable()
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter
        DataAdapter.SelectCommand = MySQL2
        DataAdapter.Fill(dt)

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Sub EditSettings(ByVal userID As Integer, ByVal title As String, ByVal colour As String, ByVal contrast As Integer)
        Dim con As New SqlConnection(HomeDatabase.connection())
        Dim cmd As New SqlCommand()
        HomeDatabase.spSelect(cmd, "SetUserSettings")
        HomeDatabase.spParamAdd(cmd, "@USERID", SqlDbType.Int, userID)
        HomeDatabase.spParamAdd(cmd, "@TITLE", SqlDbType.VarChar, title)
        HomeDatabase.spParamAdd(cmd, "@COLOUR", SqlDbType.VarChar, colour)
        HomeDatabase.spParamAdd(cmd, "@CONTRAST", SqlDbType.Int, contrast)
        HomeDatabase.spExecuteInsert(con, cmd)
    End Sub

    Public Shared Sub EditTabs(ByVal tabid As Integer, ByVal tabname As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        Dim cmd As New SqlCommand()
        HomeDatabase.spSelect(cmd, "SetTabs")
        HomeDatabase.spParamAdd(cmd, "@TABID", SqlDbType.Int, tabid)
        HomeDatabase.spParamAdd(cmd, "@TABNAME", SqlDbType.VarChar, tabname)
        HomeDatabase.spExecuteInsert(con, cmd)
    End Sub

End Class
