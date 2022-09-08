using System;
using System.Collections.Generic;

namespace WebAppSmartAssembly
{
    public class Proveedor
    {
        public Proveedor()
        {
        }

        public List<Proveedor> GetProveedores()
        {
            return DAL.GetProveedores();
        }

        public List<Componente> GetComponentesAlaVenta()
        {
            return DAL.GetComponentesAlaVenta(Id);
        }

        public List<ItemCompra> GetComponentesMasBaratosPorProveedor()
        {
            var proveedores = new Proveedor().GetProveedores();
            var componentes = new Componente().GetComponentesConBajoStock();
            var componentesAcomprar = new List<ItemCompra>();
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
                componentesAcomprar.Add(new ItemCompra(componente, proveedorPrecioMasBajo));
            }
            return componentesAcomprar;
        }

        public Proveedor GetProveedorPorId(int id)
        {
            return DAL.GetProveedorPorId(id);
        }

        public int Id { get; set; }

        public int Nombre { get; set; }

        public int Email { get; set; }

        public int CBU { get; set; }
    }
}