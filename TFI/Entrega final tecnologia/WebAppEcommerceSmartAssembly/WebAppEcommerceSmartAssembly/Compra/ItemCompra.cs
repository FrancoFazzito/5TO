

namespace WebAppEcommerceSmartAssembly
{
    public class ItemCompra
    {
        public ItemCompra(Componente componente, Proveedor proveedor)
        {
            Componente = componente;
            Proveedor = proveedor;
        }

        public Componente Componente { get; }
        public Proveedor Proveedor { get; }
        public int Cantidad { get; set; }
    }
}