<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register src="CartView.ascx" tagname="CartView" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h1>Produker der skal lægges i kurven</h1>

        <table>
            <tr>
                <td>Id</td>
                <td><asp:TextBox ID="TextBox_id" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>Navn</td>
                <td><asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>Pris</td>
                <td><asp:TextBox ID="TextBox_price" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>Antal</td>
                <td><asp:TextBox ID="TextBox_amount" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td colspan="2"><asp:Button ID="Button_submit" runat="server" Text="Put i kurv" OnClick="Button_submit_Click" /></td>
            </tr>
        </table>

    </div>

        <h2>Indkøbsliste</h2>

        <uc1:CartView ID="CartView1" runat="server" />

        <br />

    </form>
</body>
</html>
