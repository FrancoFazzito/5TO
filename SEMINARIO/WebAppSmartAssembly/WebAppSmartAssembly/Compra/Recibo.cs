using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace WebAppSmartAssembly.RealizarCompra
{
    internal class Recibo
    {
        private SmtpClient clienteSmtp;

        public Recibo(Proveedor proveedor, List<Componente> componentesRecibidos)
        {
            Proveedor = proveedor;
            ComponentesRecibidos = componentesRecibidos;
            clienteSmtp = new SmtpClient();
        }

        public Proveedor Proveedor { get; }
        public List<Componente> ComponentesRecibidos { get; }

        internal void EmitirRecibo()
        {
            DAL.GuardarRecibo();
            EnviarRecibo();
        }

        private void EnviarRecibo()
        {
            clienteSmtp = new SmtpClient();
        }
    }
}