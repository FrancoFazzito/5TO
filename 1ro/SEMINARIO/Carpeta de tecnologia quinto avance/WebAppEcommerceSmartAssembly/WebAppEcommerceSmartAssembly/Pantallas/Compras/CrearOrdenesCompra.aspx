<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearOrdenesCompra.aspx.cs" Inherits="WebAppEcommerceSmartAssembly.Pantallas.Compras.CrearOrdenesCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Tenemos estos componentes con bajo stock</h1>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="243px" Width="838px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField ButtonType="Button" Text="Agregar a compras" />
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
    <p>Cantidad:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>Listado de componentes a comprar:</p>
    <asp:BulletedList ID="BulletedList1" runat="server">
    </asp:BulletedList>
    <p>
        <asp:Button ID="Button1" runat="server" Height="55px" OnClick="Button1_Click" Text="Crear ordenes de compra" Width="222px" />
    </p>
    <p>
        Compra creada con ID 3!</p>
</asp:Content>
