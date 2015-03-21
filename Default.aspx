<%@ Page Title="Home Page" Language="VB" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="HomepageV2._Default" %>

<!doctype html>
<html>
<head runat="server">
	<title><%: Page.Title %></title>

	<link href="Content/themes/base/jquery-ui-1.10.4.custom.css" rel="stylesheet" />
	<link href="Content/Site.css" rel="stylesheet" />
	
	<script src="http://code.jquery.com/jquery-1.9.1.js"></script>
	<script src="http://code.jquery.com/ui/1.10.2/jquery-ui.js"></script>

	<link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
		.ui-state-active a, 
		.ui-state-active a:link, 
		.ui-state-active a:visited, 
		.ui-state-default a:hover, 
		.ui-tabs .ui-tabs-panel a,
		h2,
		#username {
			color: <%=colour%>;
		}

		h3 {
			background-image: linear-gradient(<%=colour%>, #000);
		}

		h3:after {
			border-color: #333 #333 transparent transparent;
		}
	</style>
</head>

<body>

<form runat="server">

<header class="<%=contrasttext%>" style="border-bottom:4px solid <%=colour%>;">
	<span class="image-wrap" style="background:url(images/av.jpg) no-repeat center center;">
		<img src="images/av.jpg" style="opacity: 0;">
	</span> 
	<%=usertitle%>
</header>

<div id="leftContent">
	<div class="arrow-down" style="border-top: 20px solid <%=colour%>;"></div>
	<div class="arrow-down" style="border-top: 20px solid <%=colour%>;"></div>
	<div class="clearfix"></div>
	<div id="tabs">
		<ul>
		<li><a href="#tabs-1">personal</a></li>
		<li><a href="#tabs-2">thankQ</a></li>
		<li><a href="#tabs-3">abstract</a></li>
		<li><a href="#tabs-4">+</a></li>
		<li><a href="#tabs-5"><img src="images/settings.png" alt="Settings" /></a></li>
		</ul>
		<div id="tabs-1">
			<asp:Repeater runat="server" ID="rptLinksByUser1">
				<ItemTemplate>
					<a href='<%#Container.DataItem("LINKURL")%>'><%#Container.DataItem("LINKNAME")%></a>
				</ItemTemplate>
			</asp:Repeater>	
		</div>
		<div id="tabs-2">
			<asp:Repeater runat="server" ID="rptLinksByUser2">
				<ItemTemplate>
					<a href='<%#Container.DataItem("LINKURL")%>'><%#Container.DataItem("LINKNAME")%></a>
				</ItemTemplate>
			</asp:Repeater>	
		</div>
		<div id="tabs-3">
			<asp:Repeater runat="server" ID="rptLinksByUser3">
				<ItemTemplate>
					<a href='<%#Container.DataItem("LINKURL")%>'><%#Container.DataItem("LINKNAME")%></a>
				</ItemTemplate>
			</asp:Repeater>	
		</div>
		<div id="tabs-4">
			<h2>add A link</h2>
			<asp:TextBox ID="txtTitle" runat="server" CssClass="textbox" onFocus="if(this.value=='Title') this.value='';" onBlur="if(this.value=='') this.value='Title';" Text="Title"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtLink" runat="server" CssClass="textbox" onFocus="if(this.value=='Link') this.value='';" onBlur="if(this.value=='') this.value='Link';" Text="Link"></asp:TextBox>
			<br /><br /> 
			<asp:DropDownList runat="server" ID="selectTab"></asp:DropDownList>
			<asp:Button ID="btnAddLink" CssClass="myButton" runat="server" Text="Add Link" />
		</div>
		<div id="tabs-5">
			<h2>settings</h2>
			<asp:TextBox ID="txtPageTitle" runat="server" CssClass="textbox" onFocus="if(this.value=='Title') this.value='';" onBlur="if(this.value=='') this.value='Title';" Text="Title"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtcolour" runat="server" CssClass="textbox" onFocus="if(this.value=='Colour') this.value='';" onBlur="if(this.value=='') this.value='Colour';" Text="Colour"></asp:TextBox>
			<br /><br />
			<div class="styled-select">
				<asp:DropDownList ID="ddContrast" runat="server" CssClass="select">
					<asp:ListItem Text="Theme" Value="1" Selected="True"></asp:ListItem>
					<asp:ListItem Text="------------" Value="1"></asp:ListItem>
					<asp:ListItem Text="Dark" Value="0"></asp:ListItem>
					<asp:ListItem Text="Light" Value="1"></asp:ListItem>
				</asp:DropDownList>
			</div>
			<br /><br /> 
			<asp:Button ID="btnSave" CssClass="myButton" runat="server" Text="Save" />

			<br /><br /><br />

			<h2>social links</h2>
			<asp:TextBox ID="txtDeviantArt" runat="server" CssClass="textbox" onFocus="if(this.value=='DeviantArt') this.value='';" onBlur="if(this.value=='') this.value='DeviantArt';" Text="DeviantArt"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtFacebook" runat="server" CssClass="textbox" onFocus="if(this.value=='Facebook') this.value='';" onBlur="if(this.value=='') this.value='Facebook';" Text="Facebook"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtFlickr" runat="server" CssClass="textbox" onFocus="if(this.value=='Flickr') this.value='';" onBlur="if(this.value=='') this.value='Flickr';" Text="Flickr"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtGoogle" runat="server" CssClass="textbox" onFocus="if(this.value=='Google') this.value='';" onBlur="if(this.value=='') this.value='Google';" Text="Google"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtLinkedIn" runat="server" CssClass="textbox" onFocus="if(this.value=='Linkedin') this.value='';" onBlur="if(this.value=='') this.value='Linkedin';" Text="Linkedin"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtTumblr" runat="server" CssClass="textbox" onFocus="if(this.value=='Tumblr') this.value='';" onBlur="if(this.value=='') this.value='Tumblr';" Text="Tumblr"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtTwitter" runat="server" CssClass="textbox" onFocus="if(this.value=='Twitter') this.value='';" onBlur="if(this.value=='') this.value='Twitter';" Text="Twitter"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtYouTube" runat="server" CssClass="textbox" onFocus="if(this.value=='YouTube') this.value='';" onBlur="if(this.value=='') this.value='YouTube';" Text="YouTube"></asp:TextBox>
			<br /><br />
			<asp:Button ID="btnSaveSocial" CssClass="myButton" runat="server" Text="Save Social" />

			<br /><br /><br />

			<h2>tabs</h2>
			<asp:TextBox ID="txtTab1" runat="server" CssClass="textbox" onFocus="if(this.value=='Tab 1') this.value='';" onBlur="if(this.value=='') this.value='Tab 1';" Text="Tab 1"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtTab2" runat="server" CssClass="textbox" onFocus="if(this.value=='Tab 2') this.value='';" onBlur="if(this.value=='') this.value='Tab 2';" Text="Tab 2"></asp:TextBox>
			<br /><br />
			<asp:TextBox ID="txtTab3" runat="server" CssClass="textbox" onFocus="if(this.value=='Tab 3') this.value='';" onBlur="if(this.value=='') this.value='Tab 3';" Text="Tab 3"></asp:TextBox>
			<br /><br />
			<asp:Button ID="btnSaveTabs" CssClass="myButton" runat="server" Text="Save Tabs" />
		</div>
	</div>
</div>

<aside>
	
	<h3>Spaces <span>(By Abstract Thinking)</span></h3>
   
	<br /><br />

	<div id="social">
		<a href="http://www.<%=deviantart%>.deviantart.com/"><img src="images/social/deviantart.png" alt="DeviantArt"/></a>
		<a href="https://www.facebook.com/<%=facebook%>"><img src="images/social/facebook.png" alt="Facebook"/></a>
		<a href="http://www.flickr.com/photos/<%=flickr%>/"><img src="images/social/flickr.png" alt="Flickr"/></a>
		<a href="https://plus.google.com/u/0/<%=google%>/posts"><img src="images/social/google.png" alt="Google+"/></a>
		<a href="<%=linkedin%>"><img src="images/social/linkedin.png" alt="LinkedIn"/></a>
		<a href="http://www.tumblr.com/blog/<%=tumblr%>"><img src="images/social/tumblr.png" alt="Tumblr"/></a>
		<a href="https://twitter.com/<%=twitter%>"><img src="images/social/twitter.png" alt="Twitter"/></a>
		<a href="http://www.youtube.com/user/<%=youtube%>"><img src="images/social/youtube.png" alt="You Tube"/></a>
	</div>

	 <div id="asideContain">
		<h2>Welcome back</h2>

		<span class="image-wrap" style="background:url(images/logged-in-pic.jpg) no-repeat center center;">
			<img src="images/logged-in-pic.jpg" style="opacity: 0;">
		</span> 

		<div id="username">W3R3W0LF666</div>
	</div>
	
	
</aside>

<script type="text/javascript">
		$(function () {
		$("#tabs").tabs({
			show: function (event, ui) {
				var lastOpenedPanel = $(this).data("lastOpenedPanel");
				if (!$(this).data("topPositionTab")) {
					$(this).data("topPositionTab", $(ui.panel).position().top)
				}

				// do crossfade of tabs
				$(ui.panel).hide().css('z-index', 2).fadeIn(200, function () {
					$(this).css('z-index', '');
					if (lastOpenedPanel) {
						lastOpenedPanel
						  .toggleClass("ui-tabs-hide")
						  .hide();
					}
				});

				$(this).data("lastOpenedPanel", $(ui.panel));
			}
		})
	});
</script>

<script type="text/javascript">
	$("#tabs-1>a[href^='http']").each(function () {
		$(this).css({
			background: "url(http://g.etfv.co/" + this.href + ") left center no-repeat",
			"padding": "0px",
			"padding-bottom": "4px",
			"padding-left": "30px",
			"background-size": "16px"
		});
	});
	$("#tabs-2>a[href^='http']").each(function () {
		$(this).css({
			background: "url(http://g.etfv.co/" + this.href + ") left center no-repeat",
			"padding": "0px",
			"padding-bottom": "4px",
			"padding-left": "30px",
			"background-size": "16px"
		});
	});
	$("#tabs-3>a[href^='http']").each(function () {
		$(this).css({
			background: "url(http://g.etfv.co/" + this.href + ") left center no-repeat",
			"padding": "0px",
			"padding-bottom": "4px",
			"padding-left": "30px",
			"background-size": "16px"
		});
	});
</script>
</form>
</body>
</html>

