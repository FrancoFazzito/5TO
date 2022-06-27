namespace WebAppSmartAssembly
{
    public class Especificaciones
    {
        public Especificaciones()
        {

        }

        public int CalidadCpu { get; internal set; }
        public int CalidadMother 
        { 
            get
            { 
                return CalidadCpu + 1;
            } 
        }
        public int CalidadFan { get; internal set; }
        public int CapacidadRam { get; internal set; }
        public int CapacidadHDD { get; internal set; }
        public int CapacidadSSD { get; internal set; }
        public int CalidadVideo { get; internal set; }
        public int CalidadTower { get; internal set; }
        public string TipoUso { get; internal set; }

        public int Id { get; set; }

        public Especificaciones GetEspecificacionesPorTipoUso(string tipoUso)
        {
            return DAL.GetEspecificacionesPorTipoUso(tipoUso);
        }
    }
}