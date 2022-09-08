namespace WebAppEcommerceSmartAssembly.Pantallas.Compras
{
    internal class ComponenteVista
    {
        private readonly Componente componente;

        public ComponenteVista(Componente componente)
        {
            this.componente = componente;
        }

        public string Nombre { get; internal set; }
        public string Precio { get; internal set; }
        public string Tipo { get; internal set; }
        public string Socket { get; internal set; }
        public int StockBajo { get; internal set; }
        public string Proveedor { get; internal set; }
    }
}