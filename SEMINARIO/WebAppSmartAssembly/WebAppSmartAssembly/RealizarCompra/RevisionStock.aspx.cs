using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAppSmartAssembly.RealizarCompra
{
    public partial class RevisionStock : System.Web.UI.Page
    {
        private List<ItemCompra> componentesProveedoresObtenidos;
        private List<ItemCompra> componentesProveedoresCargados;
        private List<ComponenteVista> componentesVista;
        private Compra compra;

        protected void Page_Load(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            componentesProveedoresObtenidos = proveedor.GetComponentesMasBaratosPorProveedor();
            componentesProveedoresCargados = new List<ItemCompra>();

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
        }

        protected void DataGridButton1_Click(object sender, EventArgs e)
        {
            componentesProveedoresCargados.Add(new ItemCompra
            (
                new Componente(),//componente index
                new Proveedor()//proveedor index
            )
            { 
                Cantidad = int.Parse(TextBox1.Text)
            });
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            compra = new Compra();
            compra.RealizarCompra(componentesProveedoresCargados);
        }
    }
}