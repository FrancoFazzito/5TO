using System;

namespace WebAppSmartAssembly
{
    public class EstadoCompra
    {
        public string GetEstadoCompraPorNombre(string nombre)
        {
            return DAL.GetEstadoCompraPorNombre(nombre);
        }
    }
}