namespace WebAppSmartAssembly
{
    public class Presupuesto
    {
        public Presupuesto(string tipoUso, string importancia, int presupuestoEnPesos)
        {
            TipoUso = tipoUso;
            Importancia = importancia;
            PresupuestoEnPesos = presupuestoEnPesos;
        }

        public string TipoUso { get; set; }
        public string Importancia { get; set; }
        public int PresupuestoEnPesos { get; set; }
    }
}