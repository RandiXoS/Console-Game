using System;
using System.Timers;
using System.Threading;

namespace Simple_Console_Game
{
    public class Program
    {
        static void Main()
        {
            //Console.SetWindowSize(120,41);
            Console.CursorVisible = false;
            Interfaz.BarraCarga();

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
            

            Console.ReadKey();
        }

    }
}
