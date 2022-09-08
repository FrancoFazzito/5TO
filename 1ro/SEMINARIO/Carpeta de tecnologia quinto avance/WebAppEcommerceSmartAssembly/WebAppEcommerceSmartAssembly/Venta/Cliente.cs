using System;

namespace WebAppEcommerceSmartAssembly
{
    public class Cliente
    {
        public Cliente(string dni, string email)
        {
            Dni = dni;
            Email = email;
        }

        public void RegistrarCliente(Cliente cliente, string pass)
        {
            Hasher hasher = new Hasher();
            string passHashed = hasher.HashPassword(pass);
            DAL.AltaCliente(cliente, pass);
        }

        public void Login(string email, string pass)
        {
            if (new Login().LoguearCliente(email, pass))
            {
                ClienteLogueado.Cliente = this;
            }
        }

        public void Logout()
        {
            ClienteLogueado.Cliente = null;
        }

        public int Id { get; set; }
        public string Dni { get; }
        public string Email { get; }

    }
}