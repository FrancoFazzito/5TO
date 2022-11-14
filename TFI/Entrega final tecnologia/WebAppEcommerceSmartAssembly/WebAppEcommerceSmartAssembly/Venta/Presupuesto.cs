namespace WebAppEcommerceSmartAssembly
{
    public class Presupuesto
    {

        public Presupuesto(TipoUso tipoUso, Importancia importancia, int presupuestoEnPesos)
        {
            TipoUso = tipoUso;
            Importancia = importancia;
            PresupuestoEnPesos = presupuestoEnPesos;
        }

        public TipoUso TipoUso { get; set; }
        public Importancia Importancia { get; set; }
        public int PresupuestoEnPesos { get; set; }
    }
}
