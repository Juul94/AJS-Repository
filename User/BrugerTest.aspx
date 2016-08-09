<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrugerTest.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="lbl_user" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="Btn_opret" runat="server" Text="Opret" OnClick="Btn_opret_Click" />
        <asp:Button ID="Btn_slet" runat="server" Text="Slet" OnClick="Btn_slet_Click" />
        <!-- <asp:Button ID="Btn_reload" runat="server" Text="Reload" /> -->

        <br />

        <div id="div_navn" runat="server"></div>

    </div>
    </form>
</body>
</html>
