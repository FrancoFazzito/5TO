using System;
using System.Collections.Generic;
using WebAppSmartAssembly.Vista;

namespace WebAppSmartAssembly.RealizarVenta
{
    public partial class MostrarComputadoras : System.Web.UI.Page
    {
        private Pedido pedido;

        protected void Page_Load(object sender, EventArgs e)
        {
            pedido = new Pedido();

            //crear objetos vista con esa coleccion
            var computadoras = new List<ComputadoraVista>
            {
                new ComputadoraVista(new Computadora())
                {
                    Cpu = "Ryzen 5 3400G",
                    Ram = "8GB",
                    Almacenamiento = "1TB HDD 256 SSD",
                    Gpu = "Integrada",
                    Precio = "80000"
                },
                new ComputadoraVista(new Computadora())
                {
                    Cpu = "Ryzen 7 5600X",
                    Ram = "16GB",
                    Almacenamiento = "1TB HDD 256 SSD",
                    Gpu = "GTX 1650TI",
                    Precio = "100000"
                },
                new ComputadoraVista(new Computadora())
                {
                    Cpu = "Intel i7",
                    Ram = "8GB",
                    Almacenamiento = "1TB HDD 256 SSD",
                    Gpu = "GTX 1650TI",
                    Precio = "110000"
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
            pedido.AgregarComputadora(computadora);
        }
    }
}