using System;

namespace WebAppEcommerceSmartAssembly
{
    public class EstadoPedido
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        internal EstadoPedido GetEstadoPorNombre(string nombre)
        {
            return DAL.GetEstadoPorNombre(nombre);
        }
    }
}