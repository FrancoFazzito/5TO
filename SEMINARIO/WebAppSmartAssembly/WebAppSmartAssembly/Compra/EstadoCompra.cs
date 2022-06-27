using System;

namespace WebAppSmartAssembly.RealizarCompra
{
    public class EstadoCompra
    {
        public string GetEstadoCompraPorNombre(string nombre)
        {
            return DAL.GetEstadoCompraPorNombre(nombre);
        }
    }
}