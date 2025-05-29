using Jugador2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugador2
{
    public class Inventario
    {
        public Personaje personaje { get; set; }
        List<Item> items = new List<Item>();
        public void agregarItem(Item item)
        {
            items.Add(item);
            item.inventario = this;
        }
        public void removerItem(Item item)
        {
            items.Remove(item);
            item.inventario = null;
        }

    }
}
