

namespace WebAppEcommerceSmartAssembly
{
    public class DetalleOrdenCompra
    {
        public DetalleOrdenCompra(int numeroDetalle, Componente componente, int cantidad)
        {
            NumeroDetalle = numeroDetalle;
            Componente = componente;
            Cantidad = cantidad;
        }

        public int NumeroDetalle { get; set; }
        public Componente Componente { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio 
        { 
            get
            { 
                return Cantidad * Componente.Precio;
            }
        }
    }
}