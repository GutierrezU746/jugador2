using Jugador2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugador2.Equipables
{
    public interface IEquipable
    {
        void Equipar(Personaje personaje);
        void Desequipar(Personaje personaje);
    }
}
