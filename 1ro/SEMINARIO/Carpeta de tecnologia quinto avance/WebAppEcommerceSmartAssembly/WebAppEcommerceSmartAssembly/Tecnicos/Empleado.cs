namespace WebAppEcommerceSmartAssembly
{
    public class Empleado
    {
        public Empleado()
        {
        }

        public Empleado BuscarEmpleadoMenosActivo()
        {
            return DAL.BuscarEmpleadoMenosActivo();
        }

        public void Registrar(Empleado empleado, string pass)
        {
            Hasher hasher = new Hasher();
            string passHashed = hasher.HashPassword(pass);
            DAL.AltaEmpleado(empleado, pass);
        }

        public void Baja(int idEmpleado)
        {
            DAL.BajaEmpleado(idEmpleado);
        }

        public void Modificacion(Empleado empleado)
        {
            DAL.ModificarEmpleado(empleado);
        }

        public void Login(string email, string pass)
        {
            Login login = new Login();
            if (login.LoguearEmpleado(email, pass))
            {
                Rol = login.GetRol(email);
                EmpleadoLogueado.Empleado = this;
            }
        }

        public Rol Rol { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
    }
}
