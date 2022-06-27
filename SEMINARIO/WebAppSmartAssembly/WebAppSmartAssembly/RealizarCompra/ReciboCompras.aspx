<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReciboCompras.aspx.cs" Inherits="WebAppSmartAssembly.RealizarCompra.ReciboCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <h1>
        Recibo Compras</h1>
    <p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="282px" Width="843px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Cancel" HeaderText="Seleccionar" ShowHeader="True" Text="Seleccionar" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Id compra:
        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        Componente:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Ryzen 5 3400 G</asp:ListItem>
            <asp:ListItem>Ryzen 7 5600x</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Cantidad recibida:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="Recibo completo" />
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Agregar a componentes recibidos" />
    </p>
    <p>
        Componentes recibidos:</p>
    <asp:BulletedList ID="BulletedList1" runat="server">
        <asp:ListItem>Cantidad: 3 - Ryzen 5 3600G</asp:ListItem>
    </asp:BulletedList>
    <p>
        <asp:Button ID="Button1" runat="server" Height="61px" OnClick="Button1_Click" Text="Generar recibo y orden de pago" Width="299px" />
    </p>
</asp:Content>
