namespace WebAppEcommerceSmartAssembly
{
    public class DetallePedido
    {
        public int NumeroDetalle { get; set; }
        public Computadora Computadora { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio 
        { 
            get 
            { 
                return Computadora.Precio * Cantidad;
            }
        }
    }
}