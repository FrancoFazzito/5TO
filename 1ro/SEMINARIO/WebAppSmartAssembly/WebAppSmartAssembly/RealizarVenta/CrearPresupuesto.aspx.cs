using System;
using System.Collections.Generic;

namespace WebAppSmartAssembly.RealizarVenta
{
    public partial class CrearPresupuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownImportancia.DataSource = new Importancia().GetImportancias();
            DropDownImportancia.DataBind();

            DropDownTipoUso.DataSource = new TipoUso().GetTiposDeUso();
            DropDownTipoUso.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string tipoUso = DropDownTipoUso.SelectedValue;
            string importancia = DropDownImportancia.SelectedValue;
            Presupuesto presupuesto = new Presupuesto(tipoUso, importancia, int.Parse(TxtPresupuesto.Text));
            ArmadorComputadora armadorComputadora = new ArmadorComputadora(presupuesto);
            List<Computadora> computadoras = armadorComputadora.ObtenerComputadoras();

            Context.Items["Computadoras"] = computadoras;
            Server.Transfer("MostrarComputadoras.aspx", true);
        }
    }
}