using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEcommerceSmartAssembly
{
    public class Pedido
    {
        public Pedido()
        {
            DetallesPedido = new List<DetallePedido>();
        }

        public void ActualizarStock()
        {
            var componenteCantidad = new Dictionary<Componente, int>();
            foreach (var componente in DetallesPedido.Select(c => c.Computadora).SelectMany(computadora => computadora.Componentes))
                componenteCantidad[componente] = componenteCantidad.ContainsKey(componente) ? +1 : 1;

            DAL.ActualizarStockArmadoPedido(componenteCantidad);
        }

        public int AltaPedido()
        {
            ActualizarStock();
            AsignarEmpleadoMenosActivo();
            AsignarCliente();
            Estado = new EstadoPedido().GetEstadoPorNombre("Pendiente");
            int numero = DAL.AltaPedido(this);
            return numero;
        }

        private void AsignarCliente()
        {
            Cliente = ClienteLogueado.Cliente;
        }

        public void AsignarEmpleadoMenosActivo()
        {
            var empleadoPedido = new Dictionary<Empleado, int>();
            foreach (var pedido in GetPedidos())
            {
                if (empleadoPedido.ContainsKey(pedido.Empleado))
                {
                    empleadoPedido[pedido.Empleado] += pedido.DetallesPedido.Sum(detalle => detalle.Cantidad);
                }
                else
                {
                    empleadoPedido[pedido.Empleado] = pedido.DetallesPedido.Sum(detalle => detalle.Cantidad);
                }
            }
            Empleado = BuscarEmpleadoMenosActivo(empleadoPedido);
        }

        private Empleado BuscarEmpleadoMenosActivo(Dictionary<Empleado, int> empleadoPedido)
        {
            return empleadoPedido.First(empleado => empleado.Value == empleadoPedido.Values.Min()).Key;
        }

        private List<Pedido> GetPedidos()
        {
            return DAL.GetPedidos();
        }

        //en pantalla agregar la cantidad y un boton de seleccion
        public void AddDetallePedido(DetallePedido detalle)
        {
            if (ValidarStock(detalle))
            {
                DetallesPedido.Add(detalle);
            }
        }

        private bool ValidarStock(DetallePedido detalle)
        {
            return DAL.ValidarStock(detalle);
        }


        public int Id { get; set; }
        public decimal PrecioTotal
        {
            get
            {
                return DetallesPedido.Sum(detalle => detalle.Precio);
            }
        }
        public Empleado Empleado { get; set; }
        public List<DetallePedido> DetallesPedido { get; set; }
        public Cliente Cliente { get; set; }
        public EstadoPedido Estado { get; set; }
        public bool Pagado { get; set; }
        
    }
}