using System.Collections.Generic;

namespace WebAppEcommerceSmartAssembly
{
    public class Proveedor
    {
        public Proveedor()
        {
        }

        public List<Proveedor> GetProveedores()
        {
            return DAL.GetProveedores();
        }

        public Componente GetComponenteEnVentaPorId(int id)
        {
            return DAL.GetComponentesEnVentaPorId(id);
        }

        public List<ItemCompra> GetComponentesEnVentaBajosEnStock()
        {
            var proveedores = GetProveedores();
            var componentesBajoStock = new Componente().GetComponentesConBajoStock();
            var itemsCompra = new List<ItemCompra>();
            foreach (var componente in componentesBajoStock)
            {
                decimal precioMinimo = 0;
                Proveedor proveedorMinimo = new Proveedor();
                foreach (var proveedor in proveedores)
                {
                    var componenteEncontrado = proveedor.GetComponenteEnVentaPorId(componente.Id);
                    if (ValidarPrecioMasBajo(precioMinimo, componenteEncontrado))
                    {
                        precioMinimo = componenteEncontrado.Precio;
                        proveedorMinimo = proveedor;
                    }
                }
                componente.Precio = precioMinimo;
                ItemCompra itemCompra = new ItemCompra(componente, proveedorMinimo);
                itemsCompra.Add(itemCompra);
            }
            return itemsCompra;
        }

        private static bool ValidarPrecioMasBajo(decimal precioMinimo, Componente componenteEncontrado)
        {
            return componenteEncontrado.Precio <= precioMinimo;
        }

        public Proveedor GetProveedorPorId(int id)
        {
            return DAL.GetProveedorPorId(id);
        }

        public void AgregarComponenteProveedor(Componente componente)
        {
            ComponentesEnVenta.Add(componente);
            ModificarProveedor(this);
        }

        public void AltaProveedor(Proveedor proveedor)
        {
            DAL.AltaProveedor(proveedor);
        }

        public void BajaProveedor(int idProveedor)
        {
            DAL.BajaProveedor(idProveedor);
        }

        public void ModificarProveedor(Proveedor proveedor)
        {
            DAL.ModificarProveedor(proveedor);
        }

        public int Id { get; set; }

        public int Nombre { get; set; }

        public int Email { get; set; }

        public int CBU { get; set; }

        public List<Componente> ComponentesEnVenta { get; set; }
    }
}