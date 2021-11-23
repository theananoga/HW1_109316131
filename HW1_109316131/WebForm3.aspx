<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="HW1_109316131.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Body Assessment</h2>
            ID Number :
            <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
            <br />
            NHI Number :
            <asp:TextBox ID="tbNhi" runat="server"></asp:TextBox>
            <br />
            <br />
            Height :
            <asp:TextBox ID="tbHeight" runat="server"></asp:TextBox>cm
            </asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Height must be filled!" ControlToValidate="tbHeight" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Height must above 0" ValidationExpression="([1-9]\d*)(\.\d+)" ControlToValidate="tbHeight" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>

            <br />
            Weight :
            <asp:TextBox ID="tbWeight" runat="server"></asp:TextBox>kg
            </asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Weight must be filled!" ControlToValidate="tbWeight" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Weight must above 0!" ValidationExpression="([1-9]\d*)(\.\d+)" ControlToValidate="tbWeight" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>

            <br />

            Systolic Blood Pressure :
            <asp:TextBox ID="tbSystolic" runat="server"></asp:TextBox>mmHg
            </asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Systolic must be filled!" ControlToValidate="tbSystolic" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Systolic must above 0!" ValidationExpression="([1-9]\d*)" ControlToValidate="tbSystolic" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>

            <br />
            Diastolic Blood Pressure :
            <asp:TextBox ID="tbDiastolic" runat="server"></asp:TextBox>mmHg
            </asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Diastolic must be filled!" ControlToValidate="tbDiastolic" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Diastolic must above 0!" ValidationExpression="([1-9]\d*)" ControlToValidate="tbDiastolic" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Systolic cannot smaller than Diastolic" ControlToValidate="tbSystolic" ControlToCompare="tbDiastolic" Type="Integer" Operator="GreaterThan"></asp:CompareValidator>
            <br />
            <br />
            Number of exercises per week :
            <asp:RadioButtonList ID="rblFrequency" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" AutoPostBack="True" OnSelectedIndexChanged="rblFrequency_SelectedIndexChanged">
                <asp:ListItem Value="0">0</asp:ListItem>
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">>3</asp:ListItem>
            </asp:RadioButtonList>


            <br />
            Duration of exercise :
            <asp:TextBox ID="tbDuration" runat="server"></asp:TextBox>minutes<br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Duration must above 0!" ValidationExpression="([1-9]\d*)" ControlToValidate="tbDuration" ForeColor="Red" Display="Dynamic" Enabled="true"></asp:RegularExpressionValidator>

            <br />
            <br />

            <h2>Vaccine Injection Appointment</h2>
            Choose Kind of Vaccines : 
            <asp:DropDownList ID="ddlVaccine" runat="server">
                <asp:ListItem Value="0">==Choose Vaccines==</asp:ListItem>
                <asp:ListItem Value="1">AZ</asp:ListItem>
                <asp:ListItem Value="2">P-fizer</asp:ListItem>
                <asp:ListItem Value="3">BNT</asp:ListItem>
            </asp:DropDownList><br />
            Choose Hospital :
            <asp:DropDownList ID="ddlHospital" runat="server" OnSelectedIndexChanged="ddlHospital_SelectedIndexChanged">
                <asp:ListItem Value="0">==Choose Hospital==</asp:ListItem>
                <asp:ListItem Value="1">HL Hospital</asp:ListItem>
                <asp:ListItem Value="2">DJ Hospital</asp:ListItem>
                <asp:ListItem Value="3">JH Hospital</asp:ListItem>
                <asp:ListItem Value="4">YS Hospital</asp:ListItem>
                <asp:ListItem Value="5">GK Hospital</asp:ListItem>
                <asp:ListItem Value="6">DW Hospital</asp:ListItem>
                <asp:ListItem Value="7">YK Hospital</asp:ListItem>
                <asp:ListItem Value="8">WP Hospital</asp:ListItem>
            </asp:DropDownList><br />
            Date & Time :<asp:DropDownList ID="ddlTime" runat="server" Visible="false"></asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="save" runat="server" Text="Save" OnClick="save_Click" />
            <asp:Button ID="confirm" runat="server" Text="Confirm" OnClick="confirm_Click" />



        </div>
    </form>
</body>
</html>
