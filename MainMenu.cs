using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace Simple_Console_Game
{
    //Enumerado para Condicionar las Opciones del Menu
    public enum SelectOption
    {
        Jugar = 1,
        Ayuda,
        Salir
    }
   
    public class MainMenu
    {
        static int y = 20;
        static ConsoleKeyInfo keyinfo;//Lectura de Teclas

        //Creando Objeto de un tipo enumerado
        static SelectOption option = SelectOption.Jugar;

        //Menú mostrado al usuario el cual, retorna un objeto del tipo
        //enumerado SelectOption que será validado en la clase Init.cs
        public static SelectOption Menu()
        {
            Console.Clear();
            y = 24;

            Interfaz.Cuadrado(4, 3, 116, 38);
            Interfaz.Cuadrado();


            Locate.Print_Center(" THE  ADVENTURE  OF  THE", 6);
            Locate.Print_Center("LITTLE SQUARE", 8);

            Console.SetCursorPosition(55, 20);
            Console.Write("1. Jugar.");
            Console.SetCursorPosition(55, 22);
            Console.Write("2. Como se Juega ?");
            Console.SetCursorPosition(55, 24);
            Console.Write("3. Salir.");

            Console.SetCursorPosition(52, 20);
            Console.Write("-->");
            Console.SetCursorPosition(52, 20);

            Interfaz.Cuadrado(49, 10, 28, 12);
            Relleno();

            while (true)
            {
                keyinfo = Console.ReadKey();

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    option++;
                    option = ((int)option > 3) ? SelectOption.Salir : option;
                    Console.SetCursorPosition(52, y);
                    Console.Write("   ");
                    y += 2;
                    if (y > 24)
                    {
                        y = 20;
                        option = SelectOption.Jugar;
                    }
                    Console.SetCursorPosition(52, y);
                    Console.Write("-->");
                    Console.SetCursorPosition(51, y);
                }
                else if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    option--;
                    option = ((int)option < 1) ? SelectOption.Jugar : option;
                    Console.SetCursorPosition(52, y);
                    Console.Write("   ");
                    y -= 2;
                    if (y < 20)
                    {
                        y = 24;
                        option = SelectOption.Salir;
                    }

                    Console.SetCursorPosition(52, y);
                    Console.Write("-->");
                    Console.SetCursorPosition(51, y);
                }
                else if (keyinfo.Key == ConsoleKey.Enter)
                {
                    return option;
                }
                else
                {
                    Console.SetCursorPosition(52, y);
                    Console.Write("   ");
                    y = 20;
                    Console.SetCursorPosition(52, y);
                    Console.Write("-->");
                    Console.SetCursorPosition(51, y);
                }
            }
        }

        //Rellena un espacio en la pantalla
        static void Relleno(int width = 72, int height = 17)
        {
            //Posiciones libres
            //Eje x: desde 51,72
            //Eje y: desde 11,17
            string txt = "";
            int verify = 0;

            Random num = new Random();

            for (int alto = 11; alto < height; alto++)
            {
                for (int ancho = 51; ancho < width; ancho++)
                {
                     verify = num.Next(1,3);

                    switch (verify)
                    {
                         case 1:
                            txt = " ";
                           break;
                        case 2:
                             txt = "°";
                            break;
                    }
                    Locate.Print(ancho, alto, txt);
                }
            }

            Locate.Print(num.Next(51, 72), num.Next(11,17),"ó");
            Locate.Print(num.Next(51, 72), num.Next(11,17),"■");

            Console.SetCursorPosition(0, 0);//Reseteando cursor
        }

    }
}