Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Links
    Public Shared Sub getLinks(ByRef rpt As Repeater, ByVal tabID As Integer, ByVal userID As Integer)
        Dim con As New SqlConnection(HomeDatabase.connection())
        Dim cmd As New SqlCommand()
        HomeDatabase.spSelect(cmd, "GetUserLinks")
        HomeDatabase.spParamAdd(cmd, "@TABID", SqlDbType.Int, tabID)
        HomeDatabase.spParamAdd(cmd, "@USERID", SqlDbType.Int, userID)
        HomeDatabase.spExecuteToRepeater(con, cmd, rpt)
    End Sub

    Public Shared Sub populateTabDropDown(ByRef dd As DropDownList)
        Dim con As New SqlConnection(HomeDatabase.connection())
        Dim cmd As New SqlCommand()
        HomeDatabase.spSelect(cmd, "GetTabs")
        HomeDatabase.spExecuteToDropDownList(con, cmd, dd, "TABNAME", "TABID")
    End Sub

    Public Shared Sub addLink(ByVal title As String, ByVal link As String, ByVal userID As Integer, ByVal tabid As Integer)
        Dim con As New SqlConnection(HomeDatabase.connection())
        Dim cmd As New SqlCommand()
        HomeDatabase.spSelect(cmd, "SetLink")
        HomeDatabase.spParamAdd(cmd, "@TITLE", SqlDbType.VarChar, title)
        HomeDatabase.spParamAdd(cmd, "@LINK", SqlDbType.VarChar, link)
        HomeDatabase.spParamAdd(cmd, "@USERID", SqlDbType.Int, userID)
        HomeDatabase.spParamAdd(cmd, "@TABID", SqlDbType.Int, tabid)
        HomeDatabase.spExecuteInsert(con, cmd)
    End Sub

End Class
