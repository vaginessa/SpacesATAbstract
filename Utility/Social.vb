Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Social
    Public Shared Function DeviantArt(ByVal userid As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        'CreateSQL Command
        Dim MySQL2 As SqlCommand
        'Choose SP
        MySQL2 = New SqlCommand("GetSocial", con)
        MySQL2.CommandType = CommandType.StoredProcedure
        HomeDatabase.spParamAdd(MySQL2, "@SOCIAL", SqlDbType.VarChar, "DEVIANTART")
        HomeDatabase.spParamAdd(MySQL2, "@USERID", SqlDbType.Int, userid)
        'Fill Datatable using a DataAdapter
        Dim dt As New DataTable()
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter
        DataAdapter.SelectCommand = MySQL2
        DataAdapter.Fill(dt)

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Function Facebook(ByVal userid As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        'CreateSQL Command
        Dim MySQL2 As SqlCommand
        'Choose SP
        MySQL2 = New SqlCommand("GetSocial", con)
        MySQL2.CommandType = CommandType.StoredProcedure
        HomeDatabase.spParamAdd(MySQL2, "@SOCIAL", SqlDbType.VarChar, "FACEBOOK")
        HomeDatabase.spParamAdd(MySQL2, "@USERID", SqlDbType.Int, userid)
        'Fill Datatable using a DataAdapter
        Dim dt As New DataTable()
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter
        DataAdapter.SelectCommand = MySQL2
        DataAdapter.Fill(dt)

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Function Flickr(ByVal userid As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        'CreateSQL Command
        Dim MySQL2 As SqlCommand
        'Choose SP
        MySQL2 = New SqlCommand("GetSocial", con)
        MySQL2.CommandType = CommandType.StoredProcedure
        HomeDatabase.spParamAdd(MySQL2, "@SOCIAL", SqlDbType.VarChar, "FLICKR")
        HomeDatabase.spParamAdd(MySQL2, "@USERID", SqlDbType.Int, userid)
        'Fill Datatable using a DataAdapter
        Dim dt As New DataTable()
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter
        DataAdapter.SelectCommand = MySQL2
        DataAdapter.Fill(dt)

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Function Google(ByVal userid As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        'CreateSQL Command
        Dim MySQL2 As SqlCommand
        'Choose SP
        MySQL2 = New SqlCommand("GetSocial", con)
        MySQL2.CommandType = CommandType.StoredProcedure
        HomeDatabase.spParamAdd(MySQL2, "@SOCIAL", SqlDbType.VarChar, "GOOGLE")
        HomeDatabase.spParamAdd(MySQL2, "@USERID", SqlDbType.Int, userid)
        'Fill Datatable using a DataAdapter
        Dim dt As New DataTable()
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter
        DataAdapter.SelectCommand = MySQL2
        DataAdapter.Fill(dt)

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Function LinkedIn(ByVal userid As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        'CreateSQL Command
        Dim MySQL2 As SqlCommand
        'Choose SP
        MySQL2 = New SqlCommand("GetSocial", con)
        MySQL2.CommandType = CommandType.StoredProcedure
        HomeDatabase.spParamAdd(MySQL2, "@SOCIAL", SqlDbType.VarChar, "LINKEDIN")
        HomeDatabase.spParamAdd(MySQL2, "@USERID", SqlDbType.Int, userid)
        'Fill Datatable using a DataAdapter
        Dim dt As New DataTable()
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter
        DataAdapter.SelectCommand = MySQL2
        DataAdapter.Fill(dt)

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Function Tumblr(ByVal userid As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        'CreateSQL Command
        Dim MySQL2 As SqlCommand
        'Choose SP
        MySQL2 = New SqlCommand("GetSocial", con)
        MySQL2.CommandType = CommandType.StoredProcedure
        HomeDatabase.spParamAdd(MySQL2, "@SOCIAL", SqlDbType.VarChar, "TUMBLR")
        HomeDatabase.spParamAdd(MySQL2, "@USERID", SqlDbType.Int, userid)
        'Fill Datatable using a DataAdapter
        Dim dt As New DataTable()
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter
        DataAdapter.SelectCommand = MySQL2
        DataAdapter.Fill(dt)

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Function Twitter(ByVal userid As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        'CreateSQL Command
        Dim MySQL2 As SqlCommand
        'Choose SP
        MySQL2 = New SqlCommand("GetSocial", con)
        MySQL2.CommandType = CommandType.StoredProcedure
        HomeDatabase.spParamAdd(MySQL2, "@SOCIAL", SqlDbType.VarChar, "TWITTER")
        HomeDatabase.spParamAdd(MySQL2, "@USERID", SqlDbType.Int, userid)
        'Fill Datatable using a DataAdapter
        Dim dt As New DataTable()
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter
        DataAdapter.SelectCommand = MySQL2
        DataAdapter.Fill(dt)

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Function YouTube(ByVal userid As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        'CreateSQL Command
        Dim MySQL2 As SqlCommand
        'Choose SP
        MySQL2 = New SqlCommand("GetSocial", con)
        MySQL2.CommandType = CommandType.StoredProcedure
        HomeDatabase.spParamAdd(MySQL2, "@SOCIAL", SqlDbType.VarChar, "YOUTUBE")
        HomeDatabase.spParamAdd(MySQL2, "@USERID", SqlDbType.Int, userid)
        'Fill Datatable using a DataAdapter
        Dim dt As New DataTable()
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter
        DataAdapter.SelectCommand = MySQL2
        DataAdapter.Fill(dt)

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Sub UpdateSocial(ByVal userID As Integer, ByVal deviantart As String, ByVal facebook As String, ByVal flickr As String, ByVal google As String, ByVal linkedin As String, ByVal tumblr As String, ByVal twitter As String, ByVal youtube As String)
        Dim con As New SqlConnection(HomeDatabase.connection())
        Dim cmd As New SqlCommand()
        HomeDatabase.spSelect(cmd, "SetSocialSettings")
        HomeDatabase.spParamAdd(cmd, "@USERID", SqlDbType.Int, userID)
        HomeDatabase.spParamAdd(cmd, "@DEVIANTART", SqlDbType.VarChar, deviantart)
        HomeDatabase.spParamAdd(cmd, "@FACEBOOK", SqlDbType.VarChar, facebook)
        HomeDatabase.spParamAdd(cmd, "@FLICKR", SqlDbType.VarChar, flickr)
        HomeDatabase.spParamAdd(cmd, "@GOOGLE", SqlDbType.VarChar, google)
        HomeDatabase.spParamAdd(cmd, "@LINKEDIN", SqlDbType.VarChar, linkedin)
        HomeDatabase.spParamAdd(cmd, "@TUMBLR", SqlDbType.VarChar, tumblr)
        HomeDatabase.spParamAdd(cmd, "@TWITTER", SqlDbType.VarChar, twitter)
        HomeDatabase.spParamAdd(cmd, "@YOUTUBE", SqlDbType.VarChar, youtube)
        HomeDatabase.spExecuteInsert(con, cmd)
    End Sub
End Class
