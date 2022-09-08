using System;

namespace WebAppSmartAssembly
{
    public class Empleado
    {
        public Empleado()
        {
        }

        public Empleado BuscarEmpleadoMenosActive()
        {
            return DAL.BuscarEmpleadoMenosActive();
        }

        public string NombreUsuario { get; set; }

        public string Email { get; set; }

        public int Id { get; set; }
    }
}