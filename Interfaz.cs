using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Simple_Console_Game
{
    public class Interfaz
    {
        //Dibuja un Cuadrado en Pantalla
        public static void Cuadrado(int psx = 2, int psy = 2, int width = 120, int height = 40)
        {
            int max = 1;
            height -= 4;
            width -= 4;

            Console.SetCursorPosition(psx, psy);

            for (int alto = 0; alto < height; alto++)
            {
                for (int ancho = 0; ancho < width; ancho++)
                {
                    if (alto == 0)
                    {
                        if (ancho == 0)
                        {
                            Locate.Print(psx + ancho, psy + alto, "╔");
                        }
                        else if (ancho == width - max)
                        {
                            Locate.Print(psx + ancho, psy + alto, "╗");
                        }
                        else
                        {
                            Locate.Print(psx + ancho, psy + alto, "═");
                        }
                    }
                    else if (alto == height - max)
                    {
                        if (ancho == 0)
                        {
                            Locate.Print(psx + ancho, psy + alto, "╚");
                        }
                        else if (ancho == width - max)
                        {
                            Locate.Print(psx + ancho, psy + alto, "╝");
                        }
                        else
                        {
                            Locate.Print(psx + ancho, psy + alto, "═");
                        }
                    }
                    else
                    {
                        if (ancho == 0)
                        {
                            Locate.Print(psx + ancho, psy + alto, "║");
                        }
                        else if (ancho == width - max)
                        {
                            Locate.Print(psx + ancho, psy + alto, "║");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
        
    }
}