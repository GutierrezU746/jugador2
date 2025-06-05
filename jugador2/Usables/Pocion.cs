using Jugador2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugador2
{
    public abstract class Pocion:Item,IUsable
    {
        public int Minimo;
        public int Maximo;
        public abstract int Usar(Personaje personaje);
    }
}
