namespace WebAppEcommerceSmartAssembly
{
    public class Seguridad
    {
        public bool EmpleadoEstaAutorizado(Empleado empleado, Rol rolEsperado)
        {
            return empleado.Rol.Jerarquia >= rolEsperado.Jerarquia;
        }
    }
}
