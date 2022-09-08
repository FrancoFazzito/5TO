using System.Collections.Generic;

namespace WebAppSmartAssembly
{
    public class Importancia
    {
        public Importancia()
        {
        }

        public List<string> GetImportancias()
        {
            return DAL.GetImportancias();
        }
    }
}