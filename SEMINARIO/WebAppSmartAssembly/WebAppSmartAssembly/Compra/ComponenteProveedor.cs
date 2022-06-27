namespace WebAppSmartAssembly.RealizarCompra
{
    public class ComponenteProveedor
    {
        public ComponenteProveedor(Componente componente, Proveedor proveedorPrecioMasBajo)
        {
            Componente = componente;
            ProveedorPrecioMasBajo = proveedorPrecioMasBajo;
        }

        public Componente Componente { get; }
        public Proveedor ProveedorPrecioMasBajo { get; }
        public int Cantidad { get; set; }
    }
}