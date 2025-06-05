using jugador2.Equipables;
using Jugador2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugador2
{
    public class Program
    {
        public static PocionVida PocionVida = new PocionVida(); public static PocionMana PocionMana = new PocionMana();
        public static void Carga(Personaje Personaje)
        {
            Inventario Inventario = new Inventario();
            Console.WriteLine("Ingrese el Color del personaje");
            Personaje.CambiarColor(Console.ReadLine());
            Console.WriteLine("Ingrese la Vida del personaje");
            Personaje.Vida = int.Parse(Console.ReadLine()); Personaje.VidaInicial = Personaje.Vida;
            Console.WriteLine("Ingrese la Defensa del personaje");
            Personaje.Defensa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Fuerza del personaje");
            Personaje.Fuerza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Mana del personaje");
            Personaje.Mana = int.Parse(Console.ReadLine()); Personaje.ManaInicial = Personaje.Mana;
            Personaje.Inventario = Inventario; Inventario.personaje = Personaje;
            Personaje.Inventario.agregarItem(PocionVida);
            Personaje.Inventario.agregarItem(PocionMana);
        }
        public static void MostrarDatos(Personaje Personaje)
        {
            Console.WriteLine("---Personaje---");
            Console.WriteLine($"Color: {Personaje.Color}");
            Console.WriteLine($"Vida: {Personaje.Vida}");
            Console.WriteLine($"Defensa: {Personaje.Defensa}");
            Console.WriteLine($"Fuerza: {Personaje.Fuerza}");
            Console.WriteLine($"Mana: {Personaje.Mana}");
            Console.WriteLine("---Inventario---");
            foreach (Item item in Personaje.Inventario.Items)
            {
                Console.WriteLine($"- {item}");
            }
        }
        static void Main(string[] args)
        {
            Personaje Personaje1 = new Personaje();
            Console.WriteLine("Personaje 1"); Carga(Personaje1); Console.Clear();
            Personaje Personaje2 = new Personaje();
            Console.WriteLine("Personaje 2"); Carga(Personaje2);
            do
            {
                Console.Clear();
                Console.WriteLine("Personaje 1:"); MostrarDatos(Personaje1);
                Console.WriteLine("");
                Console.WriteLine("Personaje 2:"); MostrarDatos(Personaje2);
                Console.WriteLine("");
                Console.WriteLine("1- Cambiar de Color");
                Console.WriteLine("2- Recibir Daño");
                Console.WriteLine("3- Atacar");
                Console.WriteLine("4- Usar Poción");
                int Seleccion = int.Parse(Console.ReadLine()); Console.Clear();
                switch (Seleccion)
                {
                    case 1:
                        Console.WriteLine("A que color desea cambiar?");
                        Personaje1.CambiarColor(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Cuanto daño recibe?");
                        Console.WriteLine(Personaje1.RecibirDaño(int.Parse(Console.ReadLine())));
                        if (Personaje1.Vida <= 0)
                        {
                            Console.WriteLine("Moriste");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(Personaje1.Atacar(Personaje2));
                        if (Personaje2.Vida <= 0)
                        {
                            Console.WriteLine("Ganaste");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        int n = 0;
                        foreach (Item item in Personaje1.Inventario.Items)
                        {
                            Console.WriteLine($"{n}- {item}.");
                            n++;
                        }
                        Console.WriteLine("Que item quiere usar");
                        int itemSelect =int.Parse( Console.ReadLine());
                        switch (itemSelect)
                        {
                            case 1:
                                if (Personaje1.Inventario.Items[itemSelect] is IUsable usable)
                                {
                                    usable.Usar(Personaje1);
                                }
                                break;
                            case 2:
                                if (Personaje1.Inventario.Items[itemSelect] is IEquipable equipable)
                                {
                                    equipable.Equipar(Personaje1);
                                }
                                break;
                            case 3:
                                break;
                        }
                        

                        int Receptor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un Minimo");
                        PocionMana.Minimo = int.Parse(Console.ReadLine());
                        PocionVida.Minimo = PocionMana.Minimo;
                        Console.WriteLine("Ingrese un Maximo");
                        PocionMana.Maximo = int.Parse(Console.ReadLine());
                        PocionVida.Maximo = PocionMana.Minimo;
                        switch (Pocion)
                        {
                            case 1:
                                switch (Receptor)
                                {
                                    case 1:
                                        if (Personaje1.Inventario.Items.Contains(PocionVida) == true)
                                        {
                                            PocionVida.Usar(Personaje1);
                                            Personaje1.Inventario.removerItem(PocionVida);
                                        }
                                        else { Console.WriteLine($"El Personaje {Personaje1.Color} no tiene una Pocion de Vida"); Console.ReadKey(); }
                                        break;
                                    case 2:
                                        if (Personaje2.Inventario.Items.Contains(PocionVida) == true)
                                        {
                                            PocionVida.Usar(Personaje2);
                                            Personaje2.Inventario.removerItem(PocionVida);
                                        }
                                        else { Console.WriteLine($"El Personaje {Personaje2.Color} no tiene una Pocion de Vida"); Console.ReadKey(); }
                                        break;
                                }
                                break;
                            case 2:
                                switch (Receptor)
                                {
                                    case 1:
                                        if (Personaje1.Inventario.Items.Contains(PocionMana) == true)
                                        {
                                            PocionMana.Usar(Personaje1);
                                            Personaje1.Inventario.removerItem(PocionMana);
                                        }
                                        else { Console.WriteLine($"El Personaje {Personaje1.Color} no tiene una Pocion de Mana"); Console.ReadKey(); }
                                        break;
                                    case 2:
                                        if (Personaje2.Inventario.Items.Contains(PocionMana) == true)
                                        {
                                            PocionMana.Usar(Personaje2);
                                            Personaje2.Inventario.removerItem(PocionMana);
                                        }
                                        else { Console.WriteLine($"El Personaje {Personaje2.Color} no tiene una Pocion de Mana"); Console.ReadKey(); }
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("Elija una de las pociones manito");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Elija una de las opciones");
                        break;
                }
            } while (Personaje1.Vida != 0);
        }
    }   

}
