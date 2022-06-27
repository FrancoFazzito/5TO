using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSmartAssembly.RealizarCompra
{
    public partial class PagarOrdenDePago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<OrdenDePago> ordenDePago = new OrdenDePago().ObtenerOrdenesDePagoInpagas();
            List<OrdenDePagoVista> ordenesDePago = new List<OrdenDePagoVista>
            {
                new OrdenDePagoVista()
                {
                    Proveedor = "jose SRL",
                    TotalAPagar = 10000,
                    EstaPagada = false
                },
                new OrdenDePagoVista()
                {
                    Proveedor = "marquitos SRL",
                    TotalAPagar = 10000,
                    EstaPagada = false
                },
                new OrdenDePagoVista()
                {
                    Proveedor = "susana SRL",
                    TotalAPagar = 10000,
                    EstaPagada = false
                }
            };
            GridView1.DataSource = ordenesDePago;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ordenPagoSeleccionada = new OrdenDePago();
            ordenPagoSeleccionada.MarcarComoPagada();
        }
    }
}