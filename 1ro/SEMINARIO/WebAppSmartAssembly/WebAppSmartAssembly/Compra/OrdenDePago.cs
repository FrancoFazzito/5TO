using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAppSmartAssembly
{
    internal class OrdenDePago
    {
        public OrdenDePago()
        {
        }

        public OrdenDePago(Compra compra, Proveedor proveedor, List<Componente> componentesRecibidos)
        {
            Compra = compra;
            Proveedor = proveedor;
            ComponentesRecibidos = componentesRecibidos;
        }

        public List<OrdenDePago> ObtenerOrdenesDePagoInpagas()
        {
            return DAL.ObtenerOrdenesDePagoInpagas();
        }

        public void EmitirOrdenDePago()
        {
            DAL.CrearOrdenDePago(this);
        }

        public void MarcarComoPagada()
        {
            DAL.MarcarComoPagada(this);
        }

        public List<Componente> ComponentesRecibidos { get; }

        public decimal TotalAPagar { 
            get
                { 
                return ComponentesRecibidos.Sum(x => x.Precio);
                } 
            }

        public bool EstaPagada
        {
            get; set;
        }

        public Proveedor Proveedor { get; set; }
        public Compra Compra { get; }
    }
}