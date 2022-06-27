namespace WebAppSmartAssembly.RealizarCompra
{
    internal class OrdenDePagoVista
    {
        public string Proveedor { get; internal set; }
        public int TotalAPagar { get; internal set; }
        public bool EstaPagada { get; internal set; }
    }
}