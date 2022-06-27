using System;
using System.Collections.Generic;

namespace WebAppSmartAssembly
{
    public class Pedido
    {
        public List<Computadora> Computadoras { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }

        public Pedido()
        {
            Computadoras = new List<Computadora>();
        }

        public void AgregarComputadora(Computadora computadora)
        {
            if (ValidarStock(computadora))
            {
                Computadoras.Add(computadora);
            }
        }

        public void ActualizarStock()
        {
            DAL.ActualizarStock(this);
        }

        public void AltaPedido()
        {
            ActualizarStock();
            AsignarEmpleadoMenosActivo();
            Cliente = ClienteLogueado.Cliente;
            DAL.AltaPedido(this);
            new Factura(this).GuardarFactura();
        }

        public void AsignarEmpleadoMenosActivo()
        {
            Empleado = new Empleado().BuscarEmpleadoMenosActive();
        }

        private bool ValidarStock(Computadora computadora)
        {
            return DAL.ValidarStock(computadora);
        }
    }
}