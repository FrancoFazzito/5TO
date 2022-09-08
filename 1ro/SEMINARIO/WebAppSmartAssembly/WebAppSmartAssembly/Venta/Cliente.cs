namespace WebAppSmartAssembly
{
    public class Cliente
    {
        public Cliente(string dni, string email)
        {
            Dni = dni;
            Email = email;
        }

        public int Id { get; set; }
        public string Dni { get; }
        public string Email { get; }
    }
}