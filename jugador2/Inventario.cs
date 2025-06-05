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
        public Personaje personaje;
        public List<Item> Items = new List<Item>();

        public void agregarItem(Item item)
        {
            Items.Add(item);
            item.inventario = this;
        }
        public void removerItem(Item item)
        {
            Items.Remove(item);
            item.inventario = null;
        }
    }
}
