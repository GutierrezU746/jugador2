using jugador2.Equipables;
using Jugador2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugador2
{
    public abstract class Equipo : Item, IEquipable
    {
        public bool Equipacion { get; set; }
        public abstract void Equipar(Personaje personaje);
        public abstract void Desequipar(Personaje personaje);
    }
}
