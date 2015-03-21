
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class _Default
    Inherits Page

    Public deviantart As String
    Public facebook As String
    Public flickr As String
    Public google As String
    Public linkedin As String
    Public tumblr As String
    Public twitter As String
    Public youtube As String
    Public usertitle As String
    Public contrast As Integer
    Public colour As String
    Public contrasttext As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'Load User Settings
        usertitle = UserSettings.GetUserSettings(1, "TITLE")
        contrast = UserSettings.GetUserSettings(1, "CONTRAST")
        colour = UserSettings.GetUserSettings(1, "COLOUR")

        'Set Dark/Light Theme
        If contrast = 1 Then
            contrasttext = "Light"
        ElseIf contrast = 0 Then
            contrasttext = "Dark"
        Else
            contrasttext = "Dark"
        End If

        'Add Placeholder
        txtTitle.Attributes.Add("onFocus()", "")
        txtLink.Attributes.Add("onFocus()", "")
        txtTitle.Attributes.Add("onBlur()", "")
        txtLink.Attributes.Add("onBlur()", "")
        txtPageTitle.Attributes.Add("onFocus()", "")
        txtcolour.Attributes.Add("onFocus()", "")
        txtPageTitle.Attributes.Add("onBlur()", "")
        txtcolour.Attributes.Add("onBlur()", "")

        'Load Links
        Links.getLinks(rptLinksByUser1, 1, 1)
        Links.getLinks(rptLinksByUser2, 2, 1)
        Links.getLinks(rptLinksByUser3, 3, 1)

        'Load Social
        deviantart = Social.DeviantArt(1)
        facebook = Social.Facebook(1)
        flickr = Social.Flickr(1)
        google = Social.Google(1)
        linkedin = Social.LinkedIn(1)
        tumblr = Social.Tumblr(1)
        twitter = Social.Twitter(1)
        youtube = Social.YouTube(1)

        'Populate Tab Dropdown List
        Links.populateTabDropDown(selectTab)

        'Load User Settings into Edit
        If Not IsPostBack Then
            'Load Settings
            If usertitle IsNot String.Empty Then
                txtPageTitle.Text = usertitle
            End If
            If colour IsNot String.Empty Then
                txtcolour.Text = colour
            End If
            If contrasttext IsNot String.Empty Then
                ddContrast.SelectedValue = contrast
            End If
            'Load Social
            If deviantart IsNot String.Empty Then
                txtDeviantArt.Text = deviantart
            End If
            If facebook IsNot String.Empty Then
                txtFacebook.Text = facebook
            End If
            If flickr IsNot String.Empty Then
                txtFlickr.Text = flickr
            End If
            If google IsNot String.Empty Then
                txtGoogle.Text = google
            End If
            If linkedin IsNot String.Empty Then
                txtLinkedIn.Text = linkedin
            End If
            If tumblr IsNot String.Empty Then
                txtTumblr.Text = tumblr
            End If
            If twitter IsNot String.Empty Then
                txtTwitter.Text = twitter
            End If
            If youtube IsNot String.Empty Then
                txtYouTube.Text = youtube
            End If
        End If
        

    End Sub

    Protected Sub btnAddLink_Click(sender As Object, e As EventArgs) Handles btnAddLink.Click
        Links.addLink(txtTitle.Text, txtLink.Text, 1, selectTab.SelectedValue)
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UserSettings.EditSettings(1, txtPageTitle.Text, txtcolour.Text, ddContrast.SelectedValue)
    End Sub

    Protected Sub btnSaveSocial_Click(sender As Object, e As EventArgs) Handles btnSaveSocial.Click
        If txtDeviantArt.Text = "DeviantArt" Then
            txtDeviantArt.Text = ""
        End If
        If txtFacebook.Text = "Facebook" Then
            txtFacebook.Text = ""
        End If
        If txtFlickr.Text = "Flickr" Then
            txtFlickr.Text = ""
        End If
        If txtGoogle.Text = "Google" Then
            txtGoogle.Text = ""
        End If
        If txtLinkedIn.Text = "Linkedin" Then
            txtLinkedIn.Text = ""
        End If
        If txtTumblr.Text = "Tumblr" Then
            txtTumblr.Text = ""
        End If
        If txtTwitter.Text = "Twitter" Then
            txtTwitter.Text = ""
        End If
        If txtYouTube.Text = "YouTube" Then
            txtYouTube.Text = ""
        End If
        Social.UpdateSocial(1, txtDeviantArt.Text, txtFacebook.Text, txtFlickr.Text, txtGoogle.Text, txtLinkedIn.Text, txtTumblr.Text, txtTwitter.Text, txtYouTube.Text)
    End Sub
End Class