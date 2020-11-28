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
        Personalizar,
        Ayuda ,
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
            y = 20;

            Interfaz.Cuadrado(4, 3, 116, 38, ConsoleColor.DarkCyan);
            Interfaz.Cuadrado(2, 2, 120, 40, ConsoleColor.DarkCyan);

            Locate.PrintCenter(" THE  ADVENTURE  OF  THE", ConsoleColor.Green, row: 6);
            Locate.PrintCenter("LITTLE SQUARE", ConsoleColor.Green, row: 8);

            Locate.PrintTextColor(55,20,"1.",ConsoleColor.Red);
            Locate.PrintTextColor(55,22,"2.",ConsoleColor.Red);
            Locate.PrintTextColor(55,24,"3.",ConsoleColor.Red);
            Locate.PrintTextColor(55,26,"4.",ConsoleColor.Red);

            Locate.PrintTextColor(57, 20, " Jugar", ConsoleColor.Blue);
            Locate.PrintTextColor(57, 22, " Personalizar", ConsoleColor.Blue);
            Locate.PrintTextColor(57, 24, " Ayuda", ConsoleColor.Blue);
            Locate.PrintTextColor(57, 26, " Salir", ConsoleColor.Blue);

            Locate.Print(52,20,"-->");

            Interfaz.Cuadrado(49, 10, 28, 12, ConsoleColor.DarkCyan);
            Relleno();

            while (true)
            {
                keyinfo = Console.ReadKey(true);

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    option++;
                    option = ((int)option > 4) ? SelectOption.Salir : option;
                    Console.SetCursorPosition(52, y);
                    Console.Write("   ");
                    y += 2;
                    if (y > 26)
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
                        y = 26;
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

            Locate.PrintTextColor(num.Next(51, 72), num.Next(11,17),"ó",ConsoleColor.Green);
            Locate.PrintTextColor(num.Next(51, 72), num.Next(11,17),"■",ConsoleColor.Cyan);
        }

    }
}