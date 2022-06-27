<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinalizarCompra.aspx.cs" Inherits="WebAppSmartAssembly.RealizarVenta.FinalizarCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Indique su metodo de pago y como quiere retirarlo!</h1>
    <p>&nbsp;</p>
    <p>Metodo de pago:</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Transferencia</asp:ListItem>
            <asp:ListItem>Mercado Pago</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>Seleccionar envio:</p>
    <p>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Envio por correo</asp:ListItem>
            <asp:ListItem>Retiro en tienda</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>Codigo postal:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>Direccion:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="39px" OnClick="Button1_Click" Text="Comprar" Width="153px" />
    </p>
</asp:Content>
