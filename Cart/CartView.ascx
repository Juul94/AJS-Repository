<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CartView.ascx.cs" Inherits="CartView" %>

<asp:Repeater ID="Repeater_CartView" runat="server" OnItemCommand="Repeater_CartView_ItemCommand">

    <HeaderTemplate>
        <table>
            <thead>
                <th>Navn</th>
                <th>Pris</th>
                <th>Antal</th>
                <th>Eks. Moms</th>
                <th>Moms</th>
                <th>Inkl. Moms</th>
            </thead>
        <tbody>
    </HeaderTemplate>

    <ItemTemplate>    
        <tr>
            <th><%#Eval("Name")%></th>
            <th><%#Eval("Price")%></th>
            <th>
                <asp:Button ID="Button_Minus" runat="server" Text="-" CommandArgument='<%#Eval("Id") %>' CommandName='minus'/>
                    <%#Eval("Amount")%>
                <asp:Button ID="Button_Plus" runat="server" Text="+" CommandArgument='<%#Eval("Id") %>' CommandName='plus'/>
            </th>
            <th><%#Eval("TotalPrice")%></th>
            <th><%#Eval("Vat")%></th>
            <th><%#Eval("InklMoms")%></th>
            <th>
                <asp:Button ID="Button_removeProduct" runat="server" Text="Slet" CommandName="delete" CommandArgument='<%#Eval("id")%>'/>
            </th>
        </tr>
    </ItemTemplate>

    <FooterTemplate>
        <tr>
            <td colspan="5">
            </td>
        </tr>
            </tbody>
        </table>
    </FooterTemplate>
</asp:Repeater>

    <asp:Button ID="Button_EmptyCart" runat="server" Text="Tøm Indkøbskurv" OnClick="Button_EmptyCart_Click" />
