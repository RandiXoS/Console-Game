using System;
using System.Timers;
using System.Threading;

namespace Simple_Console_Game
{
    public class Program
    {
        static void Main()
        {
            ConfigConsole();
            MainMenu.BarraCarga();

            SelectOption leer = MainMenu.Menu();

            switch (leer)
            {
                case SelectOption.Jugar: 
                    break;
                case SelectOption.Ayuda:
                    break;
                case SelectOption.Salir:
                    break;
                default:
                    break;
            }
            Console.Clear();
            Main();
            //Console.ReadLine();
        }

        //Configura el Tamaño de la Consola
        static void ConfigConsole()
        {
            Console.WindowWidth = 120;
            Console.WindowHeight = 41;
            Console.CursorVisible = false;
        }
    }
}
