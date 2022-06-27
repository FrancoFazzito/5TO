using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace WebAppSmartAssembly.RealizarCompra
{
    public class Compra
    {
        private SmtpClient clienteSmtp;

        public Compra()
        {
            clienteSmtp = new SmtpClient();
            ComponentesAcomprar = new List<Componente>();
        }

        public Proveedor Proveedor { get; set; }

        internal List<Compra> ObtenerComprasAprobadas()
        {
            return DAL.ObtenerComprasAprobadas();
        }

        public List<Compra> ObtenerComprasEnRevision()
        {
            return DAL.ObtenerComprasEnRevision();
        }

        public decimal PrecioAPagar 
        { 
            get
            { 
                return ComponentesAcomprar.Sum(componente => componente.Precio);
            } 
        }

        public decimal CantidadAComprar
        {
            get
            {
                return ComponentesAcomprar.Count;
            }
        }

        public string Estado { get; set; }

        public bool EstaPagada { get; set; }
        public List<Componente> ComponentesAcomprar { get; set; }

        public void RealizarCompra(List<ComponenteProveedor> componentesProveedoresCargados)
        {
            foreach (var componentesProveedores in componentesProveedoresCargados.GroupBy(x => x.ProveedorPrecioMasBajo.Id).ToList())
            {
                foreach (var componenteProveedor in componentesProveedores)
                {
                    AgregarComponentes(componenteProveedor.Componente, componenteProveedor.Cantidad);
                }
                AltaOrdenDeCompra(componentesProveedores.Key);
            }
        }

        internal void EntregarOrdenDeCompra()
        {
            Estado = new EstadoCompra().GetEstadoCompraPorNombre("Entregada");
            DAL.ActualizarStock(ComponentesAcomprar);
        }

        internal void EntregarParcialmenteOrdenDeCompra()
        {
            Estado = new EstadoCompra().GetEstadoCompraPorNombre("Entregada parcialmente");
            DAL.ActualizarStock(ComponentesAcomprar);
        }

        private void AgregarComponentes(Componente componente, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                ComponentesAcomprar.Add(componente);
            }
        }

        private void AltaOrdenDeCompra(int idProveedor)
        {
            Proveedor proveedor = new Proveedor().GetProveedorPorId(idProveedor);
            Compra compra = new Compra()
            {
                Proveedor = proveedor,
                Estado = new EstadoCompra().GetEstadoCompraPorNombre("En revision"),
                EstaPagada = false
            };
            foreach (var componente in ComponentesAcomprar)
            {
                compra.AgregarComponentes(componente, 1);
            } //mock para mandar this
            DAL.AltaCompra(compra);
        }

        public void ConfirmarOrdenDeCompra(Compra compra)
        {
            DAL.ConfirmarOrdenDeCompra(compra);
            EnviarOrdenDeCompra(compra.Proveedor);
            foreach (var componente in compra.ComponentesAcomprar)
            {
                DAL.ActualizarPrecio(componente);
            }
        }

        private void EnviarOrdenDeCompra(Proveedor proveedor)
        {
            clienteSmtp = new SmtpClient();
        }
    }
}