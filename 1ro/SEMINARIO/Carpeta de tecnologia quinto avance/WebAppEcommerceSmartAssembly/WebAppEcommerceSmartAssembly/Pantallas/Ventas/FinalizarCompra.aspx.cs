using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEcommerceSmartAssembly.Pantallas.Ventas
{
    public partial class FinalizarCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList3.DataSource = new Localidad().GetLocalidades();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            if (DropDownList2.SelectedValue == "correo")
            {
                Envio envio = new Envio
                {
                    Calle = "",
                    Cliente = ClienteLogueado.Cliente,
                    CodigoPostal = new CodigoPostal(),
                    CostoEnvio = 100,
                    EntreCalleCalle = ""
                };
                foreach (var detalle in pedido.DetallesPedido)
                {
                    var detalleEnvio = new DetalleEnvio()
                    {
                        NumeroDetalle = 1,
                        Cantidad = detalle.Cantidad,
                        Computadora = detalle.Computadora
                    };
                    envio.AgregarDetalleEnvio(detalleEnvio);
                }
            }
            pedido.AltaPedido();
        }
    }
}