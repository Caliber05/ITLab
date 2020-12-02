<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Captcha.aspx.cs" Inherits="Lab3Question1.Captcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
        <div>
            Captcha
            <br />
            <asp:Image ID="CaptchaImage" runat="server" Width="260px" />
            <br />
            <br />
            Enter the above captcha here:<br />
            <asp:TextBox ID="CaptchaResponseTextBox" runat="server" Width="260px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="SubmitButton" runat="server" OnClick="CaptchaSubmitClicked" Text="Submit" Width="260px" />
            <br />
            <br />
            <asp:Label ID="ResponseLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
