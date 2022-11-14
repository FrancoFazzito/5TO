using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEcommerceSmartAssembly
{
    public class Envio
    {
        public void AgregarDetalleEnvio(DetalleEnvio detalleEnvio)
        {
            DetalleEnvios.Add(detalleEnvio);
        }

        public void RemoverDetalleEnvio(DetalleEnvio detalleEnvio)
        {
            DetalleEnvios.Remove(detalleEnvio);
        }

        public void AltaEnvio()
        {
            DAL.AltaEnvio(this);
        }

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Localidad Localidad { get; set; }
        public CodigoPostal CodigoPostal { get; set; }
        public List<DetalleEnvio> DetalleEnvios { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string EntreCalleCalle { get; set; }
        public decimal CostoEnvio { get; set; }
    }
}