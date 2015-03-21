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
  
</head>

<body>

<form runat="server">

<header class="light">
	<span class="image-wrap" style="background:url(images/av.jpg) no-repeat center center;">
		<img src="images/av.jpg" style="opacity: 0;">
	</span> 
	W3R3W0LF's Den
</header>

<div id="leftContent">
	<div class="arrow-down"></div>
    <div class="arrow-down"></div>
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
        	
        </div>
        <div id="tabs-5">
        	
        </div>
    </div>
</div>

<aside>
	<div id="toDoFlag">To-Do</div>
    
    <div id="social">
    	<a href="http://www.w3r3w0lf666.deviantart.com/"><img src="images/social/deviantart.png" alt="DeviantArt"/></a>
        <a href="https://www.facebook.com/Spikey6666"><img src="images/social/facebook.png" alt="Facebook"/></a>
        <a href="http://www.flickr.com/photos/drlupus/"><img src="images/social/flickr.png" alt="Flickr"/></a>
        <a href="https://plus.google.com/u/0/101459213175623200603/posts"><img src="images/social/google.png" alt="Google+"/></a>
        <a href="http://www.linkedin.com/pub/liane-stevenson/2b/5/35b"><img src="images/social/linkedin.png" alt="LinkedIn"/></a>
        <a href="http://www.tumblr.com/blog/w3r3w0lf666"><img src="images/social/tumblr.png" alt="Tumblr"/></a>
        <a href="https://twitter.com/W3R3W0LF666"><img src="images/social/twitter.png" alt="Twitter"/></a>
        <a href="http://www.youtube.com/user/DrLupusMI"><img src="images/social/youtube.png" alt="You Tube"/></a>
    </div>
    
    <div id="tasks">
        <div class="checkboxOuter">
            <input type="checkbox" value="1" id="checkboxInput1" class="checkboxInput" name="" />
            <label for="checkboxInput"></label>
            Write Novel
        </div>
        <div class="checkboxOuter">
            <input type="checkbox" value="1" id="checkboxInput2" class="checkboxInput" name="" />
            <label for="checkboxInput"></label>
            Finish Website Mock-up
        </div>
        <div class="checkboxOuter">
            <input type="checkbox" value="1" id="checkboxInput3" class="checkboxInput" name="" />
            <label for="checkboxInput"></label>
            Edit Photos
        </div>
        <div class="checkboxOuter">
            <input type="checkbox" value="1" id="checkboxInput4" class="checkboxInput" name="" />
            <label for="checkboxInput"></label>
            Code Marauders
        </div>
        <div class="checkboxOuter">
            <input type="checkbox" value="1" id="checkboxInput5" class="checkboxInput" name="" />
            <label for="checkboxInput"></label>
            Pick up Ray
        </div>
        
        <input type="text" id="toDoInput" /> <input type="submit" id="addToDo" value="" />
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

