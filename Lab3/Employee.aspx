<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Lab3Question1.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <div>
            Employee ID
            <br />
            <asp:DropDownList ID="EmployeeIDList" runat="server" AutoPostBack="True" Height="23px" OnSelectedIndexChanged="EmployeeSelectedIndexChanged" Width="160px"></asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="EmployeeImage" runat="server" Height="160px" Width="160px" />
            <br />
            <br />
            Name of the Employee<br />
            <asp:TextBox ID="EmployeeNameTextBox" runat="server" Width="150px"></asp:TextBox>
            <br />
            Date of Joining<br />
            (dd-mm-yyyy)<br />
            <asp:TextBox ID="DOJTextBox" runat="server" Width="150px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="EligibleButton" runat="server" OnClick="EligibleButtonClick" Text="Am I Eligible" Width="154px" />
            <br />
            <br />
            <asp:Label ID="ResponseLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
