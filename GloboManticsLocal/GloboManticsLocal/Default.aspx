<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GloboManticsLocal._Default" %>
<!DOCTYPE html>
<html>
<head>
<title>Globomantics</title>
 <meta charset="utf-8">
 <meta http-equiv="X-UA-Compatible" content="IE=edge">
 <meta name="viewport" content="width=device-width, initial-scale=1">
 <link href="content/css/bootstrap.min.css" rel="stylesheet">
 
 <link href="content/css/style-home.css" rel="stylesheet">
<link rel="shortcut icon" type="image/x-icon" href="images/G.png"/>
</head>

<body>
<div id="wrapper">

	<header>
	    <div class="container">
		    <div class="logo col-md-5 col-sm-5 col-xs-8">
                <a href="index.html"><img src="content/images/Globo-Logo-white.svg" alt="logo"/></a><br /><span class="text">MANIACALLY TAKING TECH TO THE GLOBE</span>
			</div>
			<div class="mobile-togle col-md-12 col-sm-12 col-xs-12">
            <nav class="navbar navbar-default" role="navigation"></nav>
  		    </div>
  			<div class="right_section col-md-5 col-xs-12">
  		        <nav class="navbar navbar-expand-lg navbar-light bg-light">
                </nav>
            </div>

            <div class="sign-in col-md-2">

            </div>

  		</div>
  	</header>
</div>

    <div class="container">
        <div class="logo col-md-8">

            <asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
                <div class="row">
                    <h3><a href="?targetFile=1.txt">To show user data, click here</a></h3>

                    <form id="form1" runat="server">
                        <asp:Panel id="fileContents" runat="server" />

                        <h3>To trigger the process, click below:</h3>
                        <asp:TextBox ID="TextBox1" EnableViewState="True"></asp:TextBox>
                        <input type="submit" ID="Submit">
                    </form>
                </div>
            </asp:Content>

        </div>
    </div>

</body>
</html>
