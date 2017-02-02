<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_registration.aspx.cs" Inherits="LibraryManagement.user_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
    <div>
        
                <h2><b>Registration Form</b></h2><hr />
        
                <asp:Label ID="lab_id" runat="server" Text="User ID"></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_id" runat="server" BorderStyle="Groove"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorId" runat="server" ErrorMessage="Id is required" ControlToValidate="txt_id">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorId" runat="server" ErrorMessage="Invalid ID" ValidationExpression="[0-1][0-9]-[0-9]{5}-[1-3]" ControlToValidate="txt_id">XX-XXXXX-X</asp:RegularExpressionValidator>
                <br />
                <asp:Label ID="lab_first_name" runat="server" Text="First Name"></asp:Label><br />
                <asp:TextBox ID="txt_first_name" runat="server" BorderStyle="Groove"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator_firstname" runat="server" ErrorMessage="RequiredFieldValidator_firstname" ControlToValidate="txt_first_name" >*</asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="lab_last_name" runat="server" Text="Last Name"></asp:Label><br />
                <asp:TextBox ID="txt_last_name" runat="server" BorderStyle="Groove"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator_lastname" runat="server" ErrorMessage="RequiredFieldValidator_lastname" ControlToValidate="txt_last_name">*</asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="lab_email" runat="server" Text="Email Address"></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_email" runat="server" BorderStyle="Groove"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator_email" runat="server" ErrorMessage="RequiredFieldValidator_email" ControlToValidate="txt_email">*</asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txt_email">*Invalid</asp:RegularExpressionValidator>
                <br />
                <asp:Label ID="lab_gender" runat="server" Text="Gender"></asp:Label>
                <asp:RadioButtonList ID="radiobtn_gender" runat="server">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Label ID="lab_address" runat="server" Text="Address"></asp:Label>
                <br />
                <asp:TextBox ID="txt_address" runat="server" BorderStyle="Groove"></asp:TextBox>
                <br />
                <asp:Label ID="lab_pass" runat="server" Text="Password"></asp:Label>
                <br />
                &nbsp;
                <asp:TextBox ID="txt_password" runat="server" BorderStyle="Groove" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_password" ErrorMessage="*Can't Be Empty">*</asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="lab_repass" runat="server" Text="Re-Password"></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_re_password" runat="server" BorderStyle="Groove" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidatorRepass" runat="server" ErrorMessage="*MissMatched" ControlToCompare="txt_password" ControlToValidate="txt_re_password">*</asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorRepass" runat="server" ControlToValidate="txt_re_password" ErrorMessage="*Can't be Empty">*</asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="lab_password" runat="server" EnableViewState="False" Text="pass_container" ViewStateMode="Disabled" Visible="False"></asp:Label>
                &nbsp;
                <asp:Label ID="lab_designation" runat="server" EnableViewState="False" Text="Student" ViewStateMode="Disabled" Visible="False"></asp:Label>
                &nbsp;
                <br />
                <br />
                &nbsp;
                <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click" />
        
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLinkBack" runat="server" NavigateUrl="~/WebForm.aspx">Back to Login Page</asp:HyperLink>
        
    </div>
    </form>
        </center>
</body>
</html>
