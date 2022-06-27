<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearPresupuesto.aspx.cs" Inherits="WebAppSmartAssembly.RealizarVenta.CrearPresupuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <br />
        <h1>Hola! indicanos tu presupuesto y para que vas a utilizar la computadora!</h1>
    <p>
    </p>
    <p>
        Presupuesto:
        $ <asp:TextBox ID="TxtPresupuesto" runat="server" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        Tipo de uso:
        <asp:DropDownList ID="DropDownTipoUso" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Importancia:
        <asp:DropDownList ID="DropDownImportancia" runat="server">
        </asp:DropDownList>
    </p>
        <div class="col text-center">
            <asp:Button ID="Button1" class="btn btn-default" runat="server" Height="47px" Text="Buscar computadoras" Width="171px" OnClick="Button1_Click" />
        </div>
    <p>
    </p>
</asp:Content>
