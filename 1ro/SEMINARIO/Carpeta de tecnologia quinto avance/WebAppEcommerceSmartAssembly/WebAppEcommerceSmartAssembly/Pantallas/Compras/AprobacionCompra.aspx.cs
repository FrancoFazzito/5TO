using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEcommerceSmartAssembly.Pantallas.Compras
{
    public partial class AprobacionCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<OrdenCompra> compra = new OrdenCompra().ObtenerComprasNoAprobadas();

            //crear objetos vista con esa coleccion
            List<OrdenCompraVista> compraVistas = new List<OrdenCompraVista>
            {
                new OrdenCompraVista(new OrdenCompra())
                {
                    Id = 1,
                    PrecioAPagar = 1000000,
                    Proveedor = "Jose SRL"
                },
                new OrdenCompraVista(new OrdenCompra())
                {
                    Id = 2,
                    PrecioAPagar = 1000000,
                    Proveedor = "Import test SA"
                },
                new OrdenCompraVista(new OrdenCompra())
                {
                    Id = 3,
                    PrecioAPagar = 1000000,
                    Proveedor = "Pepe gpus SRL"
                }
            };
            GridView1.DataSource = compraVistas;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var compraSeleccionada = new OrdenCompra();
            compraSeleccionada.AprobarOrdenCompra(compraSeleccionada);
        }
    }
}