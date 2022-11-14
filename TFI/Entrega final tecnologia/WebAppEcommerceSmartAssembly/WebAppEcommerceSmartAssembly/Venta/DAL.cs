using System;
using System.Collections.Generic;

namespace WebAppEcommerceSmartAssembly
{
    internal class DAL
    {
        internal static List<Componente> GetComponentesOrdenadosPorImportancia(Importancia importancia)
        {
            return new List<Componente>();
        }

        internal static List<ItemMultiIdioma> GetEntradaControles()
        {
            throw new NotImplementedException();
        }

        internal static void RegistrarLog(string mensaje, TipoMensaje tipo)
        {
            throw new NotImplementedException();
        }

        internal static Rol GetRol(string email)
        {
            throw new NotImplementedException();
        }

        internal static List<string> GetLogs()
        {
            throw new NotImplementedException();
        }

        internal static List<OrdenCompra> ObtenerComprasNoAprobadas()
        {
            return new List<OrdenCompra>();
        }

        internal static void AltaEnvio(Envio envio)
        {
            throw new NotImplementedException();
        }

        internal static void AltaComponente(Componente componente)
        {
            throw new NotImplementedException();
        }

        internal static void BajaComponente(int idComponente)
        {
            throw new NotImplementedException();
        }

        internal static void ModificarComponente(Componente componente)
        {
            throw new NotImplementedException();
        }

        internal static EstadoPedido GetEstadoPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        internal static List<Proveedor> GetProveedores()
        {
            return new List<Proveedor>();
        }

        internal static int AltaOrdenCompraSinAprobar(OrdenCompra ordenCompra)
        {
            throw new NotImplementedException();
        }

        internal static void ActualizarOrdenCompra()
        {
            throw new NotImplementedException();
        }

        internal static List<string> GetLocalidades()
        {
            return new List<string>();
        }

        internal static Componente GetComponentesEnVentaPorId(int id)
        {
            throw new NotImplementedException();
        }

        internal static List<string> GetCodigosPostales()
        {
            return new List<string>();
        }

        internal static List<TipoUso> GetTiposDeUso()
        {
            return new List<TipoUso>();
        }

        internal static void AltaTipoUso(TipoUso tipoUso)
        {
            throw new NotImplementedException();
        }

        internal static void BajaTipoUso(TipoUso tipoUso)
        {
            throw new NotImplementedException();
        }

        internal static List<Importancia> GetImportancias()
        {
            return new List<Importancia>();
        }

        internal static Cliente GetEmpleado(string email)
        {
            throw new NotImplementedException();
        }

        internal static Cliente GetCliente(string email)
        {
            throw new NotImplementedException();
        }

        internal static void AltaEspecificacion(Especificacion especificacion)
        {
            throw new NotImplementedException();
        }

        internal static void ActualizarStockArmadoPedido(Dictionary<Componente, int> componenteCantidad)
        {
            throw new NotImplementedException();
        }

        internal static List<Pedido> GetPedidos()
        {
            return new List<Pedido>();
        }

        internal static void ModificarEspecificacion(Especificacion especificacion)
        {
            throw new NotImplementedException();
        }

        internal static int AltaPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        internal static void BajaEspecificacion(Especificacion especificacion)
        {
            throw new NotImplementedException();
        }

        internal static void AltaProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        internal static void BajaProveedor(int idProveedor)
        {
            throw new NotImplementedException();
        }

        internal static void ModificarProveedor(Proveedor proveedor)
        {
            return;
        }

        internal static Proveedor GetProveedorPorId(int id)
        {
            return new Proveedor();
        }

        internal static bool ValidarStock(DetallePedido detalle)
        {
            return true;
        }

        internal static Especificacion GetEspecificacionesPorTipoUso(TipoUso tipoUso)
        {
            return new Especificacion();
        }

        internal static Empleado BuscarEmpleadoMenosActivo()
        {
            return new Empleado();
        }

        internal static void BajaEmpleado(int idEmpleado)
        {
            return;
        }

        internal static void ModificarEmpleado(Empleado empleado)
        {
            return;
        }

        internal static void AltaEmpleado(Empleado empleado, string pass)
        {
            return;
        }

        internal static void AltaCliente(Cliente cliente, string pass)
        {
            return;
        }

        internal static List<Componente> GetComponentesConBajoStock()
        {
            return new List<Componente>();
        }
    }
}