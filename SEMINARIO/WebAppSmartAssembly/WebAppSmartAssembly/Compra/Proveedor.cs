using System;
using System.Collections.Generic;

namespace WebAppSmartAssembly.RealizarCompra
{
    public class Proveedor
    {
        public Proveedor()
        {
        }

        public int Id { get; set; }

        public List<Proveedor> GetProveedores()
        {
            return DAL.GetProveedores();
        }

        public List<Componente> GetComponentesAlaVenta()
        {
            return DAL.GetComponentesAlaVenta(Id);
        }

        public List<ComponenteProveedor> GetComponentesMasBaratosPorProveedor()
        {
            var proveedores = new Proveedor().GetProveedores();
            var componentes = new Componente().GetComponentesConBajoStock();
            var componentesAcomprar = new List<ComponenteProveedor>();
            foreach (var componente in componentes)
            {
                decimal precioMasBajo = 0;
                Proveedor proveedorPrecioMasBajo = new Proveedor();
                foreach (var proveedor in proveedores)
                {
                    var componentesAlaVenta = proveedor.GetComponentesAlaVenta();
                    foreach (var componenteAlaVenta in componentesAlaVenta)
                    {
                        if (componenteAlaVenta.Precio <= precioMasBajo)
                        {
                            precioMasBajo = componenteAlaVenta.Precio;
                            proveedorPrecioMasBajo = proveedor;
                        }
                    }
                }
                componente.Precio = precioMasBajo;
                componentesAcomprar.Add(new ComponenteProveedor(componente, proveedorPrecioMasBajo));
            }
            return componentesAcomprar;
        }

        public Proveedor GetProveedorPorId(int id)
        {
            return DAL.GetProveedorPorId(id);
        }
    }
}