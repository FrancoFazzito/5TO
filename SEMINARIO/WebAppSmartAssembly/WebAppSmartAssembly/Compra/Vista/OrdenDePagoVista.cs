namespace WebAppSmartAssembly.RealizarCompra
{
    internal class OrdenDePagoVista
    {
        private readonly OrdenDePago ordenDePago;

        public OrdenDePagoVista(OrdenDePago ordenDePago)
        {
            this.ordenDePago = ordenDePago;
        }

        public string Proveedor { get; internal set; }
        public int TotalAPagar { get; internal set; }
        public bool EstaPagada { get; internal set; }
    }
}