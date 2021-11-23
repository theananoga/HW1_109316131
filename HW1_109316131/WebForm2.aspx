<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="HW1_109316131.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Personal Information</h2>
            ID Number :
            <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
            <br />
            NHI Number :
            <asp:TextBox ID="tbNhi" runat="server"></asp:TextBox>
            <br />
            Name :
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name must be filled!" ControlToValidate="tbName" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            Sex :
            <asp:RadioButtonList ID="rblSex" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Sex must be filled!" ControlToValidate="rblSex" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            Birthdate : 
            <asp:TextBox ID="tbBirthdate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Birthdate must be filled!" ControlToValidate="tbBirthdate" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Cannot todays date!" ForeColor="Red" Display="Dynamic" Operator="LessThan" Font-Italic="True" ControlToValidate="tbBirthdate" ></asp:CompareValidator>
            <br />
            Phone Number :
            <asp:TextBox ID="tbPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Phone Number must be filled!" ControlToValidate="tbPhone" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Phone Number format wrong!" ControlToValidate="tbPhone" ForeColor="Red" ValidationExpression="[09]{2}[0-9]{8}" Display="Dynamic"></asp:RegularExpressionValidator>
            <br />
            Address :
            <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Address must be filled!" ControlToValidate="tbAddress" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            Email :
            <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Email must be filled!" ControlToValidate="tbEmail" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />

            <asp:Button ID="save" runat="server" Text="Save Info" OnClick="save_Click"/>&nbsp;&nbsp;
            <asp:Button ID="next" runat="server" Text="Next" OnClick="next_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text="Must input the personal info and click save" Visible="false"></asp:Label>

        </div>
    </form>
</body>
</html>
