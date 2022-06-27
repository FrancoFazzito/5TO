using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace WebAppSmartAssembly
{
    internal class Recibo
    {
        private SmtpClient clienteSmtp;

        public Recibo(Compra compra, Proveedor proveedor, List<Componente> componentesRecibidos)
        {
            Compra = compra;
            Proveedor = proveedor;
            ComponentesRecibidos = componentesRecibidos;
        }

        internal void EmitirRecibo()
        {
            DAL.GuardarRecibo();
            EnviarRecibo();
        }

        private void EnviarRecibo()
        {
            clienteSmtp = new SmtpClient();
        }

        public Proveedor Proveedor { get; }

        public List<Componente> ComponentesRecibidos { get; }
        public Compra Compra { get; }
    }
}