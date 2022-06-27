using System.Collections.Generic;

namespace WebAppSmartAssembly
{
    public class Componente
    {
        public Componente()
        {
            LimiteStock = 1;
        }

        public List<Componente> GetComponentesOrdenadosPorImportancia(string importancia)
        {
            return DAL.GetComponentesOrdenadosPorImportancia(importancia);
        }

        public List<Componente> GetComponentesConBajoStock()
        {
            return DAL.GetComponentesConBajoStock();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Calidad { get; set; }
        public string TipoComponente { get; set; }
        public int Consumo { get; set; } = 20;
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
    }
}