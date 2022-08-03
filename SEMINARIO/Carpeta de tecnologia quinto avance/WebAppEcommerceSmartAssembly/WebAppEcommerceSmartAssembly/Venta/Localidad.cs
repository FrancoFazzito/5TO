using System.Collections.Generic;

namespace WebAppEcommerceSmartAssembly
{
    public class Localidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<string> GetLocalidades()
        {
            return DAL.GetLocalidades();
        }
    }
}