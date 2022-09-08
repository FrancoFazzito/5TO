using System;

namespace WebAppEcommerceSmartAssembly
{
    public class Login
    {
        public Login()
        {
        }

        public bool LoguearCliente(string email, string pass)
        {
            Cliente cliente = DAL.GetCliente(email);
            return true;
        }

        internal bool LoguearEmpleado(string email, string pass)
        {
            Cliente cliente = DAL.GetEmpleado(email);
            return true;
        }

        internal Rol GetRol(string email)
        {
            return DAL.GetRol(email);
        }
    }
}