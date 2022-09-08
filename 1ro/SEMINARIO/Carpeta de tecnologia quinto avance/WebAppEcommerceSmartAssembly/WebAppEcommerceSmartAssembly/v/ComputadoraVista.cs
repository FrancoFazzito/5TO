namespace WebAppEcommerceSmartAssembly.Pantallas.Ventas
{
    internal class ComputadoraVista
    {
        private readonly Computadora computadora;

        public ComputadoraVista(Computadora computadora)
        {
            this.computadora = computadora;
        }

        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Almacenamiento { get; set; }
        public string Gpu { get; set; }
        public string Precio { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return $"{Cpu} {Ram} {Almacenamiento}";
        }
    }
}