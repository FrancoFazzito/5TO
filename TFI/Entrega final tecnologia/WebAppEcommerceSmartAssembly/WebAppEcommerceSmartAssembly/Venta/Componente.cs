using System.Collections.Generic;

namespace WebAppEcommerceSmartAssembly
{
    public class Componente
    {
        public Componente()
        {
            LimiteStock = 1;
            Consumo = 20;
        }

        public List<Componente> GetComponentesOrdenadosPorImportancia(Importancia importancia)
        {
            return DAL.GetComponentesOrdenadosPorImportancia(importancia);
        }

        public List<Componente> GetComponentesConBajoStock()
        {
            return DAL.GetComponentesConBajoStock();
        }

        public void Alta(Componente componente)
        {
            DAL.AltaComponente(componente);
        }

        public void Baja(int idComponente)
        {
            DAL.BajaComponente(idComponente);
        }

        public void Modificacion(Componente componente)
        {
            DAL.ModificarComponente(componente);
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Calidad { get; set; }
        public string TipoComponente { get; set; }
        public int Consumo { get; set; }
        public string Socket { get; set; }
        public bool TieneVideoIntegrado { get; set; }
        public int CantidadCanales { get; set; }
        public int CalidadVideo { get; set; }
        public int CalidadFan { get; set; }
        public bool NecesitaFrecuenciaAlta { get; set; }
        public int Capacidad { get; set; }
        public int FanSize { get; set; }
        public string TipoFormato { get; set; }
        public string TipoMemoria { get; set; }
        public int FrecuenciaMaxima { get; set; }
        public int Stock { get; set; }
        public int LimiteStock { get; set; }

        public int TamanoFormato
        {
            get
            {
                switch (TipoFormato)
                {
                    case "ATX":
                        return 3;
                    case "ITX":
                        return 2;
                    case "Micro-ITX":
                        return 1;
                    default:
                        return 0;
                }
            }
        }
    }
}
