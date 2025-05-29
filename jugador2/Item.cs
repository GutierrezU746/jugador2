using Jugador2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugador2
{
    public abstract class Item 
    {
        public Inventario inventario;
        public abstract int Usar(Personaje Personaje);
    }
}
