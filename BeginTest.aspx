<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BeginTest.aspx.cs" Inherits="Assignment_Part_2.BeginTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height:450px;" align="center">
            <table style="width:565px;height:421px;margin:5px 5px 5px 5px;" align="center">
                <tr>
                    <td align="center">
                        <b>Enter Your Email</b><br/>
                        <br />
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="email" Width="330px" Height="20px"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="email is required" ControlToValidate="TextBox1"></asp:RequiredFieldValidator><br />

                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="enter valid email Address" ControlToValidate="TextBox1" ValidationExpression="^\S+@\S+$"></asp:RegularExpressionValidator><br />
                        <asp:Button ID="Button1" runat="server" Text="BEGIN EXAM" Height="20px" Width="330px" OnClick="Button1_Click" />

                    </td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
