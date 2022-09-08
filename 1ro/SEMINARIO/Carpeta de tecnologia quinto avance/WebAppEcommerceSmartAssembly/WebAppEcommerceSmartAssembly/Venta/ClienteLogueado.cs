namespace WebAppEcommerceSmartAssembly
{
    public class ClienteLogueado
    {
        private static readonly Cliente clienteLogueado = new Cliente("test", "test");

        private ClienteLogueado()
        {

        }

        public static Cliente Cliente { get; set; }
    }
}