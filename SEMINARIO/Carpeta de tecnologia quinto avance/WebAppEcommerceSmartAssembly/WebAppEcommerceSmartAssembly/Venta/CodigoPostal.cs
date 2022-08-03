using System.Collections.Generic;

namespace WebAppEcommerceSmartAssembly
{
    public class CodigoPostal
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        public List<string> GetCodigosPostales()
        {
            return DAL.GetCodigosPostales();
        }
    }
}