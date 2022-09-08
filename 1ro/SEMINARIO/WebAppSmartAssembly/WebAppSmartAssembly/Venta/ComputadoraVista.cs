namespace WebAppSmartAssembly.Vista
{
    public class ComputadoraVista
    {
        private readonly Computadora computadora;

        public ComputadoraVista(Computadora computadora)
        {
            this.computadora = computadora;
        }

        public string Cpu { get; internal set; }
        public string Ram { get; internal set; }
        public string Almacenamiento { get; internal set; }
        public string Gpu { get; internal set; }
        public string Precio { get; internal set; }

        public override string ToString()
        {
            return $"{Cpu} {Ram} {Almacenamiento} {Gpu} ${Precio}";
        }
    }
}