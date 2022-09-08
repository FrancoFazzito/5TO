using System.Collections.Generic;
using System.Linq;

namespace WebAppSmartAssembly
{
    public class Computadora
    {
        public int Id { get; set; }
        public Especificaciones Especificaciones { get; internal set; }
        public List<Componente> Componentes { get; internal set; }

        public Computadora()
        {
            Componentes = new List<Componente>();
        }

        public string Cpu
        {
            get
            {
                var cpu = Componentes.First(x => x.TipoComponente == "cpu");
                return cpu.Nombre;
            }
        }

        public string Ram
        {
            get
            {
                var rams = Componentes.FindAll(x => x.TipoComponente == "ram");
                return $"${ rams.Sum(x => x.Capacidad)}";
            }
        }

        public string Almacenamiento
        {
            get
            {
                var hdd = Componentes.FindAll(x => x.TipoComponente == "ssd");
                var ssd = Componentes.FindAll(x => x.TipoComponente == "hdd");
                int hddStorage = hdd.Sum(x => x.Capacidad);
                int ssdStorage = hdd.Sum(x => x.Capacidad);
                return $"HDD: {hddStorage} SSD: {ssdStorage}";
            }
        }

        public string GPU
        {
            get
            {
                var gpu = Componentes.First(x => x.TipoComponente == "gpu");
                return gpu != null ? gpu.Nombre : "Video integrado";
            }
        }

        public decimal Precio
        {
            get
            {
                return Componentes.Sum(x => x.Precio);
            }
        }

        public int Consumo { 
            get
            { 
                return Componentes.Sum(x => x.Consumo);
            } 
        }

        public void AgregarComponente(Componente componente)
        {
            Componentes.Add(componente);
        }
    }
}