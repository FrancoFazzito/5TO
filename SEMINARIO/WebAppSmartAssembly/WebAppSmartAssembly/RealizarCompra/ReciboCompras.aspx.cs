using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSmartAssembly.RealizarCompra
{
    public partial class ReciboCompras : System.Web.UI.Page
    {
        public Proveedor Proveedor { get; }
        public List<Componente> ComponentesRecibidos { get; }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Compra> compra = new Compra().ObtenerComprasAprobadas();

            //crear objetos vista con esa coleccion
            List<CompraVista> compraVistas = new List<CompraVista>
            {
                new CompraVista()
                {
                    Id = 1,
                    Estado = "Aprobada",
                    EstaPagada = false,
                    PrecioAPagar = 1000000,
                    Proveedor = "Jose SRL"
                },
                new CompraVista()
                {
                    Id = 2,
                    Estado = "Aprobada",
                    EstaPagada = false,
                    PrecioAPagar = 1000000,
                    Proveedor = "Import trucho SA"
                },
                new CompraVista()
                {
                    Id = 3,
                    Estado = "Aprobada",
                    EstaPagada = false,
                    PrecioAPagar = 1000000,
                    Proveedor = "Pepe gpus SRL"
                }
            };
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            List<Componente> componentesRecibidos = new List<Componente>();

            OrdenDePago ordenPago = new OrdenDePago(compra.Proveedor, componentesRecibidos);

            if (CheckBox1.Checked || compra.CantidadAComprar == int.Parse(TextBox1.Text))
            {
                compra.EntregarOrdenDeCompra();
            }
            else
            {
                compra.EntregarParcialmenteOrdenDeCompra();
            }

            ordenPago.EmitirOrdenDePago();
            Recibo recibo = new Recibo(compra.Proveedor, componentesRecibidos);
            recibo.EmitirRecibo();
        }
    }
}