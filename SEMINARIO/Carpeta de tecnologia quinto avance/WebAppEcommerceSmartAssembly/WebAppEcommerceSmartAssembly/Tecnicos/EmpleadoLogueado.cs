namespace WebAppEcommerceSmartAssembly
{
    public sealed class EmpleadoLogueado
    {
        private static readonly Empleado empleadoLogueado = new Empleado();

        private EmpleadoLogueado()
        {

        }

        public static Empleado Empleado { get; set; }
    }
}
