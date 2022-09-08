namespace WebAppEcommerceSmartAssembly
{
    public class Especificacion
    {
        public Especificacion()
        {

        }

        public void AltaEspecificacion(Especificacion especificacion)
        {
            DAL.AltaEspecificacion(especificacion);
        }

        public void ModificarEspecificacion(Especificacion especificacion)
        {
            DAL.ModificarEspecificacion(especificacion);
        }

        public void BajaEspecificacion(Especificacion especificacion)
        {
            DAL.BajaEspecificacion(especificacion);
        }

        public Especificacion GetEspecificacionesPorTipoUso(TipoUso tipoUso)
        {
            return DAL.GetEspecificacionesPorTipoUso(tipoUso);
        }

        public int CalidadCpu { get; set; }
        public int CalidadMother
        {
            get
            {
                return CalidadCpu + 1;
            }
        }
        public int CalidadFan { get; set; }
        public int CapacidadRam { get; set; }
        public int CapacidadHDD { get; set; }
        public int CapacidadSSD { get; set; }
        public int CalidadVideo { get; set; }
        public int CalidadTower { get; set; }
        public TipoUso TipoUso { get; set; }
        public int Id { get; set; }
    }
}
