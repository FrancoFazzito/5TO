namespace WebAppSmartAssembly.RealizarCompra
{
    public class CompraVista 
    {
        public string Proveedor { get; set; }

        public decimal PrecioAPagar
        {
            get;
            set;
        }

        public string Estado { get; set; }

        public bool EstaPagada { get; set; }
        
        public int Id { get; set; }

        public int CantidadArecibir { get; set; }
    }
}