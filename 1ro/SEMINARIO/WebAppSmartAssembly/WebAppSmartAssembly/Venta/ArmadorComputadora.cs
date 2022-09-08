using System.Collections.Generic;
using System.Linq;

namespace WebAppSmartAssembly
{
    public class ArmadorComputadora
    {
        private readonly List<Componente> componentes;

        public ArmadorComputadora(Presupuesto presupuesto)
        {
            Presupuesto = presupuesto;
            componentes = new Componente().GetComponentesOrdenadosPorImportancia(presupuesto.Importancia);
        }

        public Presupuesto Presupuesto { get; }

        public List<Computadora> ObtenerComputadoras()
        {
            List<Computadora> computadoras = new List<Computadora>();
            Especificaciones especificaciones = new Especificaciones().GetEspecificacionesPorTipoUso(Presupuesto.TipoUso);

            IEnumerable<Componente> cpus = GetCpus();
            foreach (Componente cpu in cpus)
            {
                Computadora computadora = new Computadora
                {
                    Especificaciones = especificaciones
                };

                Componente mother = BuscarMother(cpu, especificaciones);
                computadora.AgregarComponente(mother);

                Componente ram = BuscarRam(cpu, especificaciones);
                computadora.AgregarComponente(ram);

                Componente gpu = BuscarGpu(cpu, mother, especificaciones);
                if (gpu != null)
                {
                    computadora.AgregarComponente(gpu);
                }

                Componente fan = BuscarFan(cpu, especificaciones);
                computadora.AgregarComponente(fan);

                Componente tower = BuscarTower(mother, fan, especificaciones);
                computadora.AgregarComponente(tower);

                Componente psu = BuscarPsu(computadora);
                computadora.AgregarComponente(psu);

                bool validacionPrecio = ValidarPrecio(computadora, Presupuesto.PresupuestoEnPesos);
                if (validacionPrecio)
                {
                    AgregarComputadora(computadoras, computadora);
                }
            }
            return computadoras; //mock
        }

        private static void AgregarComputadora(List<Computadora> computadoras, Computadora computadora)
        {
            computadoras.Add(computadora);
        }

        private bool ValidarPrecio(Computadora computadora, int presupuestoEnPesos)
        {
            return computadora.Precio <= presupuestoEnPesos;
        }

        private Componente BuscarPsu(Computadora computadora)
        {
            string tipo = "psu";
            List<Componente> psus = GetComponentesPorTipo(tipo);
            return psus.First(psu => psu.Capacidad >= (computadora.Consumo * 1.30));
        }

        private Componente BuscarTower(Componente mother, Componente fan, Especificaciones especificaciones)
        {
            string tipo = "tower";
            List<Componente> towers = GetComponentesPorTipo(tipo);
            return towers.First(tower => ConvertirFormatoAtamano(tower.TipoFormato) >= ConvertirFormatoAtamano(mother.TipoFormato) && tower.Calidad >= especificaciones.CalidadTower && tower.FanSize >= fan.Capacidad);
        }

        private static int ConvertirFormatoAtamano(string tipoFormato)
        {
            switch (tipoFormato)
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

        private Componente BuscarFan(Componente cpu, Especificaciones especificaciones)
        {
            string tipo = "fan";
            List<Componente> fans = GetComponentesPorTipo(tipo);
            return fans.First(fan => fan.CalidadFan >= especificaciones.CalidadFan && fan.Socket == cpu.Socket);
        }

        private Componente BuscarGpu(Componente cpu, Componente mother, Especificaciones especificaciones)
        {
            string tipo = "gpu";
            List<Componente> gpus = GetComponentesPorTipo(tipo);
            return mother.TieneVideoIntegrado && cpu.CalidadVideo >= especificaciones.CalidadVideo
                ? null
                : gpus.First(gpu => gpu.Calidad >= especificaciones.CalidadVideo);
        }

        private Componente BuscarRam(Componente cpu, Especificaciones especificaciones)
        {
            string tipo = "ram";
            List<Componente> rams = GetComponentesPorTipo(tipo);
            List<Componente> ramsCompatiblesCpu = rams.FindAll(x => x.TipoMemoria == cpu.TipoMemoria);
            return ramsCompatiblesCpu.First(ram => ram.Capacidad >= (especificaciones.CapacidadRam / cpu.CantidadCanales));
        }

        private Componente BuscarMother(Componente cpu, Especificaciones especificaciones)
        {
            string tipo = "mother";
            List<Componente> mothers = GetComponentesPorTipo(tipo);
            return mothers.First(mother => mother.Socket == cpu.Socket && mother.Calidad >= especificaciones.CalidadMother);
        }

        private List<Componente> GetComponentesPorTipo(string tipo)
        {
            return componentes.FindAll(x => x.TipoComponente == tipo);
        }

        private IEnumerable<Componente> GetCpus()
        {
            return componentes.FindAll(x => x.TipoComponente == "cpu");
        }
    }
}