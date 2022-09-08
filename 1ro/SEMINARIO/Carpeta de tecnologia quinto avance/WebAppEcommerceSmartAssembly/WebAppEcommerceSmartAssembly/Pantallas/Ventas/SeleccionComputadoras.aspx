<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SeleccionComputadoras.aspx.cs" Inherits="WebAppEcommerceSmartAssembly.Pantallas.Ventas.SeleccionComputadoras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <br />
        <h1>Armamos estas computadoras para ti!</h1>
    <p>
        <asp:Button ID="Button3" runat="server" Text="&lt;- volver a estimar" Width="197px" />
        </p>
        <p>
            &nbsp;</p>
    <p>
        <asp:GridView ID="GridComputadoras" runat="server" Height="312px" Width="859px" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridComputadoras_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandName="" Text="Seleccionar Computadora" OnClick="GridComputadoras_SelectedIndexChanged"/>
                    </ItemTemplate>
                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:TemplateField>
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
            Computadora seleccionada:
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Cantidad:
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="34px" OnClick="Button2_Click" Text="Agregar computadora" Width="212px" />
        </p>
        <p>
            Computadoras agregadas:</p>
    
        <asp:BulletedList ID="BulletedListComputadoras" runat="server">
        </asp:BulletedList>
    
        <div class="col text-center">
            <asp:Button ID="Button1" class="btn btn-default" runat="server" Height="47px" Text="Finalizar Compra" Width="171px" OnClick="Button1_Click" />
            <br />
        </div>
</asp:Content>
