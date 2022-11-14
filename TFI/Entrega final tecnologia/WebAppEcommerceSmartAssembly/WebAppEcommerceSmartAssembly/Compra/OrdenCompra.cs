using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEcommerceSmartAssembly
{
    public class OrdenCompra
    {
        private void Alta(OrdenCompra ordenCompra)
        {
            DAL.AltaOrdenCompraSinAprobar(ordenCompra);
        }

        public void AgregarDetalleCompra(DetalleOrdenCompra detalleOrden)
        {
            DetallesOrdenCompra.Add(detalleOrden);
        }

        internal List<OrdenCompra> ObtenerComprasNoAprobadas()
        {
            return DAL.ObtenerComprasNoAprobadas();
        }

        public int AltaOrdenCompraSinAprobar(List<ItemCompra> itemsCompra)
        {
            var itemCompras = itemsCompra.GroupBy(x => x.Proveedor);
            var id = 0;
            foreach (var itemCompra in itemCompras)
            {
                OrdenCompra ordenCompra = new OrdenCompra();
                for (int i = 0; i < itemCompra.Count(); i++)
                {
                    var detalleOrdenCompra = new DetalleOrdenCompra(i, itemCompra.ElementAt(i).Componente, itemCompra.ElementAt(i).Cantidad);
                    ordenCompra.DetallesOrdenCompra.Add(detalleOrdenCompra);
                }
                ordenCompra.Proveedor = itemCompra.Key;
                id = DAL.AltaOrdenCompraSinAprobar(ordenCompra);
            }
            return id;
        }

        public void AprobarOrdenCompra(OrdenCompra ordenCompra)
        {
            ordenCompra.Aprobada = true;
            DAL.ActualizarOrdenCompra();
            EnviarMailProveedor(ordenCompra.Proveedor, ordenCompra.DetallesOrdenCompra);
            foreach (var detalle in ordenCompra.DetallesOrdenCompra)
            {
                ActualizarStockPrecio(detalle);
            }
        }

        private static void ActualizarStockPrecio(DetalleOrdenCompra detalle)
        {
            detalle.Componente.Modificacion(detalle.Componente);
        }

        private void EnviarMailProveedor(Proveedor proveedor, List<DetalleOrdenCompra> detallesOrdenCompra)
        {
            throw new NotImplementedException();
        }

        public int Id { get; set; }
        public Proveedor Proveedor { get; set; }
        public decimal PrecioTotal
        {
            get
            {
                return DetallesOrdenCompra.Sum(c => c.Precio);
            }
        }
        public List<DetalleOrdenCompra> DetallesOrdenCompra { get; set; }
        public bool Aprobada { get; set; }
    }
}