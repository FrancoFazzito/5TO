<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearPresupuesto.aspx.cs" Inherits="WebAppEcommerceSmartAssembly.Pantallas.Ventas.CrearPresupuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <br />
        <h1>Hola! indicanos tu presupuesto y para que vas a utilizar la computadora!</h1>
    <p>
    </p>
    <p>
        Presupuesto:
        $ <asp:TextBox ID="TxtPresupuesto" runat="server" TextMode="Number" CssClass="active"></asp:TextBox>
    </p>
    <p>
        Tipo de uso:
        <asp:DropDownList ID="DropDownTipoUso" runat="server" CssClass="active">
            <asp:ListItem>Gaming</asp:ListItem>
            <asp:ListItem>Arquitectura</asp:ListItem>
            <asp:ListItem>Programacion</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Importancia:
        <asp:DropDownList ID="DropDownImportancia" runat="server" CssClass="active">
            <asp:ListItem>Precio</asp:ListItem>
            <asp:ListItem>Calidad</asp:ListItem>
        </asp:DropDownList>
    </p>
        <div class="col text-center">
            <asp:Button ID="Button1" class="btn btn-default" runat="server" Height="47px" Text="Buscar computadoras" Width="171px" OnClick="Button1_Click" CssClass="active" />
        </div>
    <p>
    </p>
</asp:Content>
