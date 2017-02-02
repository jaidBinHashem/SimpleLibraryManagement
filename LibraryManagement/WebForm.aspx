<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <h2>&nbsp;</h2>
            <h2><b>Login</b></h2>
            <hr />
        Username<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        Password<br />
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <br />
            <asp:HyperLink ID="HyperLinkReg" runat="server" NavigateUrl="~/user_registration.aspx">I have no account yet?</asp:HyperLink>
            </center>
    </div>
    </form>
</body>
</html>
