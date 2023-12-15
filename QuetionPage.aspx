<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuetionPage.aspx.cs" Inherits="Assignment_Part_2.QuetionPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><b>Quetion</b></h1><br />
            <br />
            &nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
            <br />
            <h1><b>Answers</b></h1><br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="ans" /><br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="ans" /><br />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="ans"/><br />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="ans"/><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />


            

        </div>
    </form>
</body>
</html>
