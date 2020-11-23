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
        
        //Muestra una Barra de Carga en pantalla
        public static void BarraCarga(int tiempo_s = 2, bool cuadro = false)
        {
            Console.Clear();//Limpiando la consola

            tiempo_s *= 1000;//Conviertiendo segundos a milisegundos
            int cantidad = tiempo_s/100;
            int x = 50;

            if (cuadro)
            {
                Interfaz.Cuadrado();
            }
            Console.SetCursorPosition(50,24);
            for(int i = 0; i < 100; i++)
            {
                Locate.Print_Center("Loading "+i+" %.",18);
                if (i % 5 == 0)
                {
                    Locate.Print(x++,20,"█");
                }

                Thread.Sleep(cantidad);
            }
        }
    }
}