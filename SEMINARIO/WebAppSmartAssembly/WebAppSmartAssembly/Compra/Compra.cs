using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace WebAppSmartAssembly
{
    public class Compra
    {
        private SmtpClient clienteSmtp;

        public Compra()
        {
            clienteSmtp = new SmtpClient();
            ComponentesAcomprar = new List<Componente>();
        }

        public List<Compra> ObtenerComprasAprobadas()
        {
            return DAL.ObtenerComprasAprobadas();
        }

        public List<Compra> ObtenerComprasEnRevision()
        {
            return DAL.ObtenerComprasEnRevision();
        }

        public void RealizarCompra(List<ItemCompra> itemsCompra)
        {
            foreach (var itemCompras in itemsCompra.GroupBy(x => x.ProveedorPrecioMasBajo.Id).ToList())
            {
                foreach (var item in itemCompras)
                {
                    AgregarComponentes(item.Componente, item.Cantidad);
                }
                AltaOrdenDeCompra(itemCompras.Key);
            }
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

        public void EntregarOrdenDeCompra()
        {
            Estado = new EstadoCompra().GetEstadoCompraPorNombre("Entregada");
            DAL.ActualizarStock(ComponentesAcomprar);
        }

        public void EntregarParcialmenteOrdenDeCompra()
        {
            Estado = new EstadoCompra().GetEstadoCompraPorNombre("Entregada parcialmente");
            DAL.ActualizarStock(ComponentesAcomprar);
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

        public Proveedor Proveedor { get; set; }
    }
}