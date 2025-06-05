using Jugador2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugador2
{
    public class Espada : Equipo
    {
        int AtaqueEspada = 10;
        public override void Equipar(Personaje personaje)
        {
            if (Equipacion = true)
            {
                personaje.Fuerza = personaje.Fuerza + AtaqueEspada;
            }
        }
        public override void Desequipar(Personaje personaje)
        {
            if (Equipacion = false)
            {
                personaje.Fuerza = personaje.Fuerza;
            }
        }
        public override string ToString()
        {
            return "Espada";
        }
    }
}
