using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEcommerceSmartAssembly
{
    public class Bitacora
    {
        public void RegistrarLog(string mensaje, TipoMensaje tipo)
        {
            DAL.RegistrarLog(mensaje, tipo);
        }

        public List<string> GetLogs()
        {
            return DAL.GetLogs();
        }
    }
}