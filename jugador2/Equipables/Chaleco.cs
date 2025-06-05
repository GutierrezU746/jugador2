using Jugador2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugador2
{
    public class Chaleco:Equipo
    {
        int DefensaChaleco = 20;
        public override void Equipar(Personaje personaje)
        {
            if (Equipacion = true)
            {
                personaje.Defensa = personaje.Defensa + DefensaChaleco;
            }
        }
        public override void Desequipar(Personaje personaje)
        {
            if (Equipacion = false)
            {
                personaje.Defensa = personaje.Defensa;
            }
        }
        public override string ToString()
        {
            return "Chaleco";
        }
    }
}
