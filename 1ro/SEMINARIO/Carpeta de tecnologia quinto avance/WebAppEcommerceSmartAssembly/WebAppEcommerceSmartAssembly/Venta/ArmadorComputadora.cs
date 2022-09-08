using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAppEcommerceSmartAssembly
{
    public class ArmadorComputadora
    {
        private readonly List<Componente> componentes;

        public ArmadorComputadora(Presupuesto presupuesto)
        {
            Presupuesto = presupuesto;
            componentes = new Componente().GetComponentesOrdenadosPorImportancia(presupuesto.Importancia);
        }

        public List<Computadora> ObtenerComputadoras()
        {
            List<Computadora> computadoras = new List<Computadora>();
            Especificacion especificaciones = new Especificacion().GetEspecificacionesPorTipoUso(Presupuesto.TipoUso);

            IEnumerable<Componente> cpus = GetComponentesPorTipo("Cpu").FindAll(cpu => cpu.Calidad >= especificaciones.CalidadCpu);
            foreach (Componente cpu in cpus)
            {
                Computadora computadora = new Computadora
                {
                    Especificacion = especificaciones
                };

                computadora.AgregarComponente(cpu);

                Componente mother = BuscarMother(cpu, especificaciones);
                computadora.AgregarComponente(mother);

                List<Componente> rams = BuscarRam(cpu, mother, especificaciones);
                computadora.AgregarComponentes(rams);

                Componente gpu = BuscarGpu(cpu, mother, especificaciones);
                if (gpu != null)
                {
                    computadora.AgregarComponente(gpu);
                }

                Componente ssd = BuscarSSD(especificaciones);
                computadora.AgregarComponente(ssd);

                Componente hdd = BuscarHDD(especificaciones);
                computadora.AgregarComponente(hdd);

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
            return computadoras.Take(5).ToList(); //mock
        }

        private Componente BuscarHDD(Especificacion especificaciones)
        {
            string tipo = "hdd";
            List<Componente> hdds = GetComponentesPorTipo(tipo);
            return hdds.First(hdd => hdd.Capacidad >= especificaciones.CapacidadHDD);
        }

        private Componente BuscarSSD(Especificacion especificaciones)
        {
            string tipo = "ssd";
            List<Componente> ssds = GetComponentesPorTipo(tipo);
            return ssds.First(ssd => ssd.Capacidad >= especificaciones.CapacidadSSD);
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

        private Componente BuscarTower(Componente mother, Componente fan, Especificacion especificaciones)
        {
            string tipo = "tower";
            List<Componente> towers = GetComponentesPorTipo(tipo);
            return towers.First(tower => tower.TamanoFormato >= mother.TamanoFormato && tower.Calidad >= especificaciones.CalidadTower && tower.FanSize >= fan.Capacidad);
        }

        private Componente BuscarFan(Componente cpu, Especificacion especificaciones)
        {
            string tipo = "fan";
            return cpu.CalidadFan >= especificaciones.CalidadFan
                ? null
                : GetComponentesPorTipo(tipo).First(fan => fan.CalidadFan >= especificaciones.CalidadFan && fan.Socket == cpu.Socket);
        }

        private Componente BuscarGpu(Componente cpu, Componente mother, Especificacion especificaciones)
        {
            string tipo = "gpu";
            return mother.TieneVideoIntegrado && cpu.CalidadVideo >= especificaciones.CalidadVideo
                ? null
                : GetComponentesPorTipo(tipo).First(gpu => gpu.Calidad >= especificaciones.CalidadVideo);
        }

        private List<Componente> BuscarRam(Componente cpu, Componente mother, Especificacion especificaciones)
        {
            string tipo = "ram";
            List<Componente> mejoresRams = new List<Componente>();
            List<Componente> rams = GetComponentesPorTipo(tipo);
            Componente mejorRam = rams.First(ram => ram.TipoMemoria == cpu.TipoMemoria && ram.Capacidad >= (especificaciones.CapacidadRam / cpu.CantidadCanales) && ram.FrecuenciaMaxima <= cpu.FrecuenciaMaxima && ram.FrecuenciaMaxima <= mother.FrecuenciaMaxima);
            for (int i = 0; i < cpu.CantidadCanales; i++)
            {
                mejoresRams.Add(mejorRam);
            }
            return mejoresRams;
        }

        private Componente BuscarMother(Componente cpu, Especificacion especificaciones)
        {
            string tipo = "mother";
            List<Componente> mothers = GetComponentesPorTipo(tipo);
            return mothers.First(mother => mother.Socket == cpu.Socket && mother.Calidad >= especificaciones.CalidadMother);
        }

        private List<Componente> GetComponentesPorTipo(string tipo)
        {
            return componentes.FindAll(x => x.TipoComponente == tipo);
        }

        public Presupuesto Presupuesto { get; }
    }
}