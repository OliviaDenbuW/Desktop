<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Label ID="lblNamn" runat="server" Text="Ange namn"></asp:Label>
        <asp:TextBox ID="txtNamn" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <br />
        <asp:ListBox ID="lstValues" runat="server"></asp:ListBox>
        <br />
        <asp:Label ID="lblSida" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
