<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_dashboard.aspx.cs" Inherits="LibraryManagement.user_dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
        
<style type="text/css">
body{
	background-color: #eee;
	
}

.profile_option_div{
    background: #004ea8;
    height:40px;
    text-align: right;
    padding: 10px;
    font-family: Helvetica,Arial,sans-serif;
    font-size: 13px;
	position:fixed;
	left:0;
	top:0;
	width:100%;
	z-index: 999;	
}
div a.menu{
	color:#fff;
}
div a.menu:hover{
	color:#000;
}
a{
	text-decoration: none;
	color: blue;
	align: center;
}
a:hover{
	color: #000;	
}

div.leftmenu{
	background-color: #eee;
	color : #0572B4;
	float: left;
	width: 15%;
	padding: 5px;
	text-align: center;
	table-layout: inherit;
	text-decoration: none;
	position:fixed;
    border-right: 1px solid #333;
    border-radius: 5px;
	left:0;
	top:80;
}
.tablediv a:hover{
    background-color: #22587D;
    color: #ff9900;
    padding: 5px;
    border-radius: 5px;
}


</style>
	

		<div class="profile_option_div">
		<br/>
			<a href="admin_dashboard.aspx" style="font-size:22;color:white;position:fixed;left:10%; font-family:none; text-decoration:none; top: 1px; height: 57px;">
			<h1><b>Library Management System</b></h1></a>
			<a class="menu" href="user_dashboard.aspx">Home</a>&nbsp;
			<a class="menu" href="profile.aspx">Profile</a>&nbsp;
			<a class="menu" href="admin-change-password.php">Change Password</a>&nbsp;
			<a class="menu" href="logout.aspx">Logout</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;	
		
		</div>

	</div>
	<br/>
	
	

	<div class="optionmenudiv">
		<div class="leftmenu">
			<label style="color:green;font-size:18px;">
			DASHBOARD
			<hr/>
			</label>
		<br/><br/><br/>
			<table class="tablediv">
				<tr>
					<td>
						&nbsp;&nbsp;<img src="Image/newBook-icon.png" alt="logo" style="height: 22px; width: 20px">
					</td>
					<td>
						<a href="user_book_search.aspx"> Search Book</a>
						<hr/>
					</td>
				</tr>

				<tr>
					<td>
						&nbsp;&nbsp;<img src="Image/search.png" alt="logo" style="height: 21px; width: 20px">
					</td>
					<td>
						<a href="all_issued_book.aspx"> My Issued Book</a>
						<hr/>
					</td>
				</tr>
				<tr>
					<td>
						&nbsp;&nbsp;<img src="Image/Book-List.png" alt="logo" style="height: 21px; width: 20px">
					</td>
					<td>
						<a href="user_book_list_view.aspx"> View All Book</a>
						<hr/>
					</td>
				</tr>
				
				<tr>
					<td>
						&nbsp;&nbsp;<img src="Image/logout.png" alt="logo" style="height: 21px; width: 20px">
					</td>
					<td>
						<a href="logout.aspx"> Logout</a>
						<hr/>
					</td>
				</tr>
			</table>
			<br/><br/>
			
		</div>

	</div>
	
	<div style="background-color: #eee;position :absolute;left :262px; top :80px; width :777px";/>

    <div>
        <h2>Welcome <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h2>

        
        <center>
        <asp:ImageButton ID="ImageButtonProfile" runat="server" BorderStyle="Solid" Height="154px" ImageUrl="~/Image/profile.png" Width="166px" OnClick="ImageButtonProfile_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButtonSearch" runat="server" BorderStyle="Solid" Height="154px" ImageUrl="~/Image/search.png" style="margin-right: 0px" Width="161px" OnClick="ImageButtonSearch_Click" />
        &nbsp;<br />
        <asp:Label ID="Label2" runat="server" Text="Profile"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Search"></asp:Label>
            <br />
        <br />
        <asp:ImageButton ID="ImageButtonMyIssuedBook" runat="server" BorderStyle="Solid" Height="155px" ImageUrl="~/Image/Book-Issued.png" Width="166px" OnClick="ImageButtonMyIssuedBook_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButtonAllBook" runat="server" BorderStyle="Solid" Height="155px" ImageUrl="~/Image/Book-List.png" Width="166px" OnClick="ImageButtonAllBook_Click"  />
        <br />
        <asp:Label ID="Label4" runat="server" Text="My Issued List"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="All Books"></asp:Label>
        <br /><br />
            </center>
    </div>
    </form>
</body>
</html>
