using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAppSmartAssembly.RealizarCompra
{
    internal class OrdenDePago
    {
        public OrdenDePago()
        {
        }

        public OrdenDePago(Proveedor proveedor, List<Componente> componentesRecibidos)
        {
            this.Proveedor = proveedor;
            ComponentesRecibidos = componentesRecibidos;
        }

        internal List<OrdenDePago> ObtenerOrdenesDePagoInpagas()
        {
            return DAL.ObtenerOrdenesDePagoInpagas();
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

        internal void EmitirOrdenDePago()
        {
            DAL.CrearOrdenDePago(this);
        }

        internal void MarcarComoPagada()
        {
            DAL.MarcarComoPagada(this);
        }
    }
}