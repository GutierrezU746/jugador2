using jugador2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugador2
{
    public class Personaje
    {
        public Inventario Inventario { get; set; } = new Inventario();
        public string Color;
        public int Vida,VidaInicial, Defensa, Fuerza, Mana, ManaInicial;

         
        public void CambiarColor(string NuevoColor)
        {
            Color = NuevoColor;
        }
        public int RecibirDaño(int Daño)
        {
            int DañoEfectivo = (Daño - Defensa);
            if (DañoEfectivo < 0)
            {
                DañoEfectivo = 0;
            }
            Vida -= DañoEfectivo;
            return DañoEfectivo;
        }
        public int Atacar(Personaje Personaje)
        {
            if (Mana > 0)
            {
                Mana -= 1;
                return Personaje.RecibirDaño(Fuerza);
            }
            else
            {
                Console.WriteLine("Sin maná");
                return 0;
            }
        }
    }
}
