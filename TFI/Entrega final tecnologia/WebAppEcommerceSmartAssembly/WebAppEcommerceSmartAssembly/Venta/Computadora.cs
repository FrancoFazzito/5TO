using System.Collections.Generic;
using System.Linq;

namespace WebAppEcommerceSmartAssembly
{
    public class Computadora
    {
        public Computadora()
        {
            Componentes = new List<Componente>();
        }

        public void AgregarComponente(Componente componente)
        {
            Componentes.Add(componente);
        }

        public void AgregarComponentes(List<Componente> rams)
        {
            foreach (var ram in rams)
            {
                AgregarComponente(ram);
            }
        }
        public int Id { get; set; }
        public decimal Precio
        {
            get
            {
                return Componentes.Sum(x => x.Precio);
            }
        }
        public int Consumo
        {
            get
            {
                return Componentes.Sum(x => x.Consumo);
            }
        }
        public Importancia Importancia { get; set; }
        public Especificacion Especificacion { get; set; }
        public List<Componente> Componentes { get; set; }
    }
}