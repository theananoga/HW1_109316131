<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HW1_109316131.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Vaccine Injection Appointment and Body Assessment System</h2>
            ID Number : <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="ID Number must be filled!" ControlToValidate="tbId" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="ID Number format wrong!" ControlToValidate="tbId" ForeColor="Red" Display="Dynamic" ValidationExpression="[a-zA-Z]{1}[1-2]{1}[0-9]{8}"></asp:RegularExpressionValidator><br />
            NHI Number : <asp:TextBox ID="tbNhi" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="NHI Number must be filled!" ControlToValidate="tbNhi" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="NHI Number format wrong!" ControlToValidate="tbNhi" ForeColor="Red" ValidationExpression="[0-9]{12}"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="confirm" runat="server" Text="Confirm" OnClick="confirm_Click"/>&nbsp;&nbsp;
            <asp:Button ID="clear" runat="server" Text="Clear" OnClick="clear_Click" />

        </div>
    </form>
</body>
</html>
