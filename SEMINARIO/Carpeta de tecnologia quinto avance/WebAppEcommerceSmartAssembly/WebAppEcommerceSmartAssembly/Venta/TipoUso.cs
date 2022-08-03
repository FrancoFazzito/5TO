using System.Collections.Generic;

namespace WebAppEcommerceSmartAssembly
{
    public class TipoUso
    {
        public TipoUso()
        {
        }

        public List<TipoUso> GetTiposDeUso()
        {
            return DAL.GetTiposDeUso();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
