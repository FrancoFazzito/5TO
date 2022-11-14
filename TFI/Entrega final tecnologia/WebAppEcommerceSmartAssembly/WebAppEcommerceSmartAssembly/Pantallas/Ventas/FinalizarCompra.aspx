<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinalizarCompra.aspx.cs" Inherits="WebAppEcommerceSmartAssembly.Pantallas.Ventas.FinalizarCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Indique su metodo de pago y como quiere retirarlo y la computadora ya va a ser tuya!</h1>
    <p>Seleccionar envio:</p>
    <p>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Envio por correo</asp:ListItem>
            <asp:ListItem>Retiro en tienda</asp:ListItem>
        </asp:DropDownList>
    </p>
<p>
        Localidad:
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>Buenos aires</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>Codigo postal:
        <asp:TextBox ID="TextBox1" runat="server" Width="198px">1653</asp:TextBox>
    </p>
    <p>Calle:
        <asp:TextBox ID="TextBox2" runat="server" Width="117px">Republica</asp:TextBox>
    </p>
    <p>Altura:
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Number" Width="117px">4877</asp:TextBox>
    </p>
<p>Entre calle y calle:
        <asp:TextBox ID="TextBox4" runat="server" Width="311px">Alvear y Lacroze</asp:TextBox>
    </p>
    <div class="col text-center">
            <p>
        <asp:Button ID="Button1" runat="server" Height="39px" OnClick="Button1_Click" Text="Comprar" Width="153px" CssClass="active" />
    </p>
    <p>
            <asp:Label ID="Label1" runat="server" Text="Se ha generado con exito el pedido con numero: 1234."></asp:Label>
    </p>
    </div>
    
</asp:Content>
