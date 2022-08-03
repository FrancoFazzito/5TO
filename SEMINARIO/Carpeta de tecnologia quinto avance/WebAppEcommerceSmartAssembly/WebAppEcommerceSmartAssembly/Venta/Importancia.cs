using System.Collections.Generic;

namespace WebAppEcommerceSmartAssembly
{
    public class Importancia
    {
        public Importancia()
        {
        }

        public List<Importancia> GetImportancias()
        {
            return DAL.GetImportancias();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
