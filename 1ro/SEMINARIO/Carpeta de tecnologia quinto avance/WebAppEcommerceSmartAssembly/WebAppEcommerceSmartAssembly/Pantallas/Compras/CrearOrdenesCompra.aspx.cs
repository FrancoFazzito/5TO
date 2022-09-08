using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEcommerceSmartAssembly.Pantallas.Compras
{
    public partial class CrearOrdenesCompra : System.Web.UI.Page
    {
        private List<ItemCompra> componentesProveedoresObtenidos;
        private List<ItemCompra> itemsCompra;
        private List<ComponenteVista> componentesVista;
        private OrdenCompra compra;

        protected void Page_Load(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            componentesProveedoresObtenidos = proveedor.GetComponentesEnVentaBajosEnStock();
            itemsCompra = new List<ItemCompra>();

            //crear objetos vista con esa coleccion
            componentesVista = new List<ComponenteVista>
            {
                new ComponenteVista(new Componente())
                {
                    Nombre = "Ryzen 5 3400G",
                    Precio = "10000",
                    Tipo = "cpu",
                    Socket = "AM4",
                    StockBajo = 2,
                    Proveedor = "Juan SRL"
                },
                new ComponenteVista(new Componente())
                {
                    Nombre = "Ryzen 7",
                    Precio = "10000",
                    Tipo = "cpu",
                    Socket = "AM4",
                    StockBajo = 2,
                    Proveedor = "Import test SA"
                },
                new ComponenteVista(new Componente())
                {
                    Nombre = "Intel i7 11th",
                    Precio = "10000",
                    Tipo = "cpu",
                    Socket = "AM4",
                    StockBajo = 2,
                    Proveedor = "Import test SA"
                }
            };

            GridView1.DataSource = componentesVista;
            GridView1.DataBind();

            BulletedList1.Items.Add($"Cantidad 2 - {componentesVista[0]}");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            itemsCompra.Add(new ItemCompra
            (
                new Componente(),//componente index
                new Proveedor()//proveedor index
            )
            {
                Cantidad = int.Parse(TextBox1.Text)
            });
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            compra = new OrdenCompra();
            compra.AltaOrdenCompraSinAprobar(itemsCompra);
        }
    }
}