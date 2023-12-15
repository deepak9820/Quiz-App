<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExamResult.aspx.cs" Inherits="Assignment_Part_2.ExamResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><b>User: </b></h1><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <h3><b>Result</b></h3>
            <!--Grid view to Display Result-->
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
