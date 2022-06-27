using System.Collections.Generic;

namespace WebAppSmartAssembly
{
    public class TipoUso
    {
        public TipoUso()
        {
        }

        public List<string> GetTiposDeUso()
        {
            return DAL.GetTiposDeUso();
        }
    }
}