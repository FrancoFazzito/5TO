using System.Collections.Generic;
using System.Linq;

namespace WebAppEcommerceSmartAssembly
{
    public class MultiIdioma
    {
        public MultiIdioma()
        {
            ItemsEntrada = DAL.GetEntradaControles();
        }

        public void CambiarIdioma(string nuevoIdioma)
        {
            var entradas = ItemsEntrada.Select(item => item.Idioma == nuevoIdioma);
            foreach (var item in ItemsEntrada)
            {

            }
        }

        public List<ItemMultiIdioma> ItemsEntrada { get; set; }
    }
}