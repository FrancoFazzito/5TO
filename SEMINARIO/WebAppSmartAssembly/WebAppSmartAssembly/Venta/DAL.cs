using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WebAppSmartAssembly.RealizarCompra;

namespace WebAppSmartAssembly
{
    public class DAL
    {
        private readonly SqlConnection conexion;

        public DAL()
        {
            conexion = new SqlConnection();
        }

        internal static List<Componente> GetComponentesEnVenta(Proveedor proveedor)
        {
            return new List<Componente>();
        }

        internal static void GuardarRecibo()
        {
            return;
        }

        internal static List<OrdenDePago> ObtenerOrdenesDePagoInpagas()
        {
            return new List<OrdenDePago>();
        }

        internal static List<Compra> ObtenerComprasEnRevision()
        {
            return new List<Compra>();
        }

        internal static List<Compra> ObtenerComprasAprobadas()
        {
            return new List<Compra>();
        }

        internal static void CrearOrdenDePago(OrdenDePago ordenDePago)
        {
            return;
        }

        internal static void MarcarComoPagada(OrdenDePago ordenDePago)
        {
            return;
        }

        internal static List<Componente> GetComponentesAlaVenta(object id)
        {
            return new List<Componente>();
        }

        internal static List<Componente> GetComponentesConBajoStock()
        {
            return new List<Componente>();
        }

        internal static List<Proveedor> GetProveedores()
        {
            return new List<Proveedor>();
        }

        internal static string GetEstadoCompraPorNombre(string nombre)
        {
            return "test";
        }

        public static List<string> GetImportancias()
        {
            return new List<string>()
            {
                "Precio",
                "Calidad"
            };
        }

        internal static void AltaCompra(Compra compra)
        {
            throw new NotImplementedException();
        }

        public static void GuardarFactura(Pedido pedido)
        {
            return;
        }

        public static Empleado BuscarEmpleadoMenosActive()
        {
            return new Empleado();
        }

        public static Especificaciones GetEspecificacionesPorTipoUso(string tipoUso)
        {
            return new Especificaciones()
            {
                TipoUso = tipoUso,
                CalidadCpu = 5,
                CalidadFan = 5,
                CapacidadRam = 8,
                CapacidadHDD = 1000,
                CapacidadSSD = 256,
                CalidadVideo = 5,
                CalidadTower = 5
            };
        }

        internal static void ActualizarStock(List<Componente> componentesAcomprar)
        {
            return;
        }

        internal static Proveedor GetProveedorPorId(int id)
        {
            return new Proveedor();
        }

        internal static void ConfirmarOrdenDeCompra(Compra compra)
        {
            return;
        }

        public static void AltaPedido(Pedido pedido)
        {
            var cliente = pedido.Cliente;
            return;
        }

        public static void ActualizarStock(Pedido pedido)
        {
            return;
        }

        public static bool ValidarStock(Computadora computadora)
        {
            return true;
        }

        public static List<Componente> GetComponentesOrdenadosPorImportancia(string importancia)
        {
            return importancia == "calidad"
                ? new List<Componente>().OrderBy(x => x.Calidad).ToList()
                : new List<Componente>().OrderBy(x => x.Precio).ToList();
        }

        internal static void ActualizarPrecio(Componente componente)
        {
            return;
        }

        public static List<string> GetTiposDeUso()
        {
            return new List<string>()
            {
                "Gaming",
                "Oficina",
                "Diseño gráfico"
            };
        }
    }
}