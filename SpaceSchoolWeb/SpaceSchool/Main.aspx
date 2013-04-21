<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="SpaceSchool.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Create Your Mission<br />
        <asp:Button ID="Button1" runat="server" Text="Build Vehicle" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Choose Crew" />
&nbsp;<asp:Button ID="Button3" runat="server" Text="Choose Payloads" />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="Parabolic Flight">Parabolic Flight</asp:ListItem>
            <asp:ListItem>Single Orbit</asp:ListItem>
            <asp:ListItem>Multiple Orbits</asp:ListItem>
            <asp:ListItem>Space Docking</asp:ListItem>
            <asp:ListItem>Space Station</asp:ListItem>
            <asp:ListItem>Moon Flight</asp:ListItem>
            <asp:ListItem>Mission to Mars</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
