using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSmartAssembly.RealizarCompra
{
    public partial class AprobacionCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Compra> compra = new Compra().ObtenerComprasEnRevision();

            //crear objetos vista con esa coleccion
            List<CompraVista> compraVistas = new List<CompraVista>
            {
                new CompraVista()
                {
                    Id = 1,
                    Estado = "En revision",
                    EstaPagada = false,
                    PrecioAPagar = 1000000,
                    Proveedor = "Jose SRL"
                },
                new CompraVista()
                {
                    Id = 2,
                    Estado = "En revision",
                    EstaPagada = false,
                    PrecioAPagar = 1000000,
                    Proveedor = "Import trucho SA"
                },
                new CompraVista()
                {
                    Id = 3,
                    Estado = "En revision",
                    EstaPagada = false,
                    PrecioAPagar = 1000000,
                    Proveedor = "Pepe gpus SRL"
                }
            };
            GridView1.DataSource = compraVistas;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var compraSeleccionada = new Compra();
            compraSeleccionada.ConfirmarOrdenDeCompra(compraSeleccionada);
        }
    }
}