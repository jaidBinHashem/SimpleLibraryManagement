<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="LibraryManagement.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <h2><b>Profile</b></h2><hr />
        Id:<asp:Label ID="lab_user_id" runat="server" Text="ID" Font-Bold="True"></asp:Label><br /><hr />
        Name:<asp:Label ID="lab_name" runat="server" Text="Name" Font-Bold="True"></asp:Label><br /><hr />
        Email:<asp:Label ID="lab_email" runat="server" Text="Email" Font-Bold="True"></asp:Label><br /><hr />
        Gender:<asp:Label ID="lab_gender" runat="server" Text="Gender" Font-Bold="True"></asp:Label><br /><hr />
        Address:<asp:Label ID="lab_address" runat="server" Text="Address" Font-Bold="True"></asp:Label><br /><hr />
       
            </center>
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>