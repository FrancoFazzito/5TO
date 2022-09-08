using System;
using System.Net.Mail;

namespace WebAppSmartAssembly
{
    internal class Factura
    {
        private readonly Pedido pedido;
        private readonly SmtpClient clienteSmtp;

        public Factura(Pedido pedido)
        {
            this.pedido = pedido;
            clienteSmtp = new SmtpClient();
        }

        public void GuardarFactura()
        {
            EnviarFactura();
            DAL.GuardarFactura(pedido);
        }

        private void EnviarFactura()
        {
            return;
        }

        public int Id { get; set; }
    }
}