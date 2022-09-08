namespace WebAppSmartAssembly
{
    public class ItemCompra
    {
        public ItemCompra(Componente componente, Proveedor proveedorPrecioMasBajo)
        {
            Componente = componente;
            ProveedorPrecioMasBajo = proveedorPrecioMasBajo;
        }

        public Componente Componente { get; }
        public Proveedor ProveedorPrecioMasBajo { get; }
        public int Cantidad { get; set; }
    }
}