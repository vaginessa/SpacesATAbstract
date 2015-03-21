Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ToDo
    Public Shared Sub getToDoList(ByRef rpt As Repeater, ByVal userID As Integer)
        Dim con As New SqlConnection(HomeDatabase.connection())
        Dim cmd As New SqlCommand()
        HomeDatabase.spSelect(cmd, "GetToDo")
        HomeDatabase.spParamAdd(cmd, "@USERID", SqlDbType.Int, userID)
        HomeDatabase.spExecuteToRepeater(con, cmd, rpt)
    End Sub
End Class
