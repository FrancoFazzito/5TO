using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEcommerceSmartAssembly.Pantallas.Ventas
{
    public partial class SeleccionComputadoras : System.Web.UI.Page
    {
        private Pedido pedido;

        protected void Page_Load(object sender, EventArgs e)
        {
            pedido = new Pedido();

            Presupuesto presupuesto = new Presupuesto(new TipoUso(), new Importancia(), 100000);
            ArmadorComputadora armadorComputadora = new ArmadorComputadora(presupuesto);
            List<Computadora> compus = armadorComputadora.ObtenerComputadoras();

            //crear objetos vista con esa coleccion
            var computadoras = new List<ComputadoraVista>
            {
                new ComputadoraVista(new Computadora())
                {
                    Cpu = "Ryzen 5 3400G",
                    Ram = "12GB",
                    Almacenamiento = "1TB HDD 256 SSD",
                    Gpu = "Integrada",
                    Precio = "80000",
                    Descripcion = "Esta es la mejor computadora para vos!"
                },
                new ComputadoraVista(new Computadora())
                {
                    Cpu = "Ryzen 7 5600X",
                    Ram = "16GB",
                    Almacenamiento = "1TB HDD 256 SSD",
                    Gpu = "GTX 1650TI",
                    Precio = "100000",
                    Descripcion = "---"
                },
                new ComputadoraVista(new Computadora())
                {
                    Cpu = "Intel i7",
                    Ram = "16GB",
                    Almacenamiento = "1TB HDD 256 SSD",
                    Gpu = "GTX 1650TI",
                    Precio = "110000",
                    Descripcion = "---"
                },
                new ComputadoraVista(new Computadora())
                {
                    Cpu = "Intel i9",
                    Ram = "16GB",
                    Almacenamiento = "1TB HDD 256 SSD",
                    Gpu = "GTX 1650TI",
                    Precio = "120000",
                    Descripcion = "---"
                },
                new ComputadoraVista(new Computadora())
                {
                    Cpu = "Ryzen 9",
                    Ram = "16GB",
                    Almacenamiento = "1TB HDD 256 SSD",
                    Gpu = "GTX 1650TI",
                    Precio = "125000",
                    Descripcion = "---"
                }
            };
            GridComputadoras.DataSource = computadoras;
            GridComputadoras.DataBind();

            BulletedListComputadoras.Items.Add($"cantidad = 1 - {computadoras[0]}");
            BulletedListComputadoras.Items.Add($"cantidad = 1 - {computadoras[1]}");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("FinalizarCompra.aspx", true);
        }

        protected void GridComputadoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Computadora computadora = new Computadora();
            DetallePedido detallePedido = new DetallePedido()
            {
                Cantidad = 1,//TextBox1.Text
                Computadora = computadora,
                NumeroDetalle = 1
            };
            pedido.AddDetallePedido(detallePedido);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("FinalizarCompra.aspx", true);
        }
    }
}