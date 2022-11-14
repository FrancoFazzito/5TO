

namespace WebAppEcommerceSmartAssembly.Pantallas.Compras
{
    internal class OrdenCompraVista
    {
        private readonly OrdenCompra ordenCompra;

        public OrdenCompraVista(OrdenCompra ordenCompra)
        {
            this.ordenCompra = ordenCompra;
        }

        public int Id { get; set; }
        public int PrecioAPagar { get; set; }
        public string Proveedor { get; set; }
    }
}