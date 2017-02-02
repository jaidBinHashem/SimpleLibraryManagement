<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_dashboard.aspx.cs" Inherits="LibraryManagement.admin_deshboard" %>

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
			<a class="menu" href="admin_dashboard.aspx">Home</a>&nbsp;
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
						<a href="book_entry.aspx"> Add New Book</a>
						<hr/>
					</td>
				</tr>

				<tr>
					<td>
						&nbsp;&nbsp;<img src="Image/search.png" alt="logo" style="height: 21px; width: 20px">
					</td>
					<td>
						<a href="book_search.aspx"> Search Book</a>
						<hr/>
					</td>
				</tr>
				<tr>
					<td>
						&nbsp;&nbsp;<img src="Image/Book-List.png" alt="logo" style="height: 21px; width: 20px">
					</td>
					<td>
						<a href="BookListView.aspx"> View All Book</a>
						<hr/>
					</td>
				</tr>
				<tr>
					<td>
						&nbsp;&nbsp;<img src="Image/Finder.png" alt="logo" style="height: 30px; width: 26px">
					</td>
					<td>
						<a href="UserList.aspx"> View All User</a>
						<hr/>
					</td>
				</tr>
				<tr>
					<td>
						&nbsp;&nbsp;<img src="Image/Book-Issued.png" alt="logo" style="height: 29px; width: 26px">
					</td>
					<td>
						<a href="all_issued_book.aspx">All Issued Book</a>
						<hr/>
					</td>
				</tr>
				
			
				
				<tr>
					<td>
						&nbsp;&nbsp;<img src="Image/logout.png" alt="logo" style="height: 21px; width: 22px">
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
        <asp:ImageButton ID="ImageButtonProfile" runat="server" BorderStyle="Solid" Height="154px" ImageUrl="~/Image/profile.png" Width="165px" OnClick="ImageButtonProfile_Click" />
           &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:ImageButton ID="ImageButtonSearch" runat="server" BorderStyle="Solid" Height="154px" ImageUrl="~/Image/search.png" style="margin-right: 0px" Width="167px" OnClick="ImageButtonSearch_Click" />
        &nbsp;&nbsp;&nbsp;
        &nbsp;<asp:ImageButton ID="ImageButtonUserList" runat="server" BorderStyle="Solid" Height="154px" ImageUrl="~/Image/Finder.png" OnClick="ImageButtonUserList_Click" Width="163px" />
           <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Profile"></asp:Label>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Search"></asp:Label>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="Label7" runat="server" Text="User List"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <br />
        <br />
        <asp:ImageButton ID="ImageButtonBookEntry" runat="server" BorderStyle="Solid" Height="155px" ImageUrl="~/Image/newBook-icon.png" Width="167px" OnClick="ImageButtonBookEntry_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButtonAllBooks" runat="server" BorderStyle="Solid" Height="155px" ImageUrl="~/Image/Book-List.png" Width="164px" OnClick="ImageButtonAllBooks_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButtonIssuedView" runat="server" BorderStyle="Solid" Height="155px" ImageUrl="~/Image/Book-Issued.png" Width="164px" OnClick="ImageButtonIssuedView_Click"  />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<asp:Label ID="Label4" runat="server" Text="Entry New Book"></asp:Label>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="All Books"></asp:Label>
        
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="Label6" runat="server" Text="Issued Books"></asp:Label>
        
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
            </center>
    
    </div>
        
    </form>
</body>
</html>
