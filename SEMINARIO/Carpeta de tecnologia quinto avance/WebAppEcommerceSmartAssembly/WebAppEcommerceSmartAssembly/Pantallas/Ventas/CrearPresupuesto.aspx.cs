using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEcommerceSmartAssembly.Pantallas.Ventas
{
    public partial class CrearPresupuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownImportancia.DataSource = new Importancia().GetImportancias();
            //DropDownImportancia.DataBind();

            DropDownTipoUso.DataSource = new TipoUso().GetTiposDeUso();
            //DropDownTipoUso.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TipoUso tipoUso = new TipoUso() { Nombre = DropDownTipoUso.SelectedValue };
            Importancia importancia = new Importancia() { Nombre = DropDownImportancia.SelectedValue };

            Context.Items["tipoUso"] = tipoUso;
            Context.Items["importancia"] = importancia;
            Server.Transfer("MostrarComputadoras.aspx", true);
        }
    }
}