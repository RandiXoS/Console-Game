using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Simple_Console_Game
{
    //Esta clase tine como objetivo suplir funciones para facilitar la escritura
    //de caracteres en pantalla
    public static class Locate
    {
        
        //Imprime un cadena en la posición de pantalla que establezcas
        public static void Print(int psx, int psy, string caracter)
        {
                Console.SetCursorPosition(psx, psy);
                Console.Write(caracter);
        }

        //Imprime un caracter en la posición de pantalla que establezcas
        public static void Print(int psx, int psy, char caracter)
        {
                Console.SetCursorPosition(psx, psy);
                Console.Write(caracter);
        }
        
        //Imprime un Array en la posición de pantalla que establezcas
        public static void Print_Position(int psx, int psy, string[] caracter)
        {
                for (int i = 0; i < caracter.Length; i++)
                {
                    Console.SetCursorPosition(psx, psy++);
                    Console.Write(caracter[i]);
                } 
        }
        
        //Centraliza un cadena en pantalla
        public static void Print_Center(string caracter, int row = 19)
        {
            int column = 0;
            column = (Console.WindowWidth / 2) - (caracter.Length / 2); 
 
            Console.SetCursorPosition(column, row);
            Console.Write(caracter);
        }
        
        //Centraliza un Array en pantalla
        public static void Print_Center(string[] caracter, int row = 19)
        {
            int column = (Console.WindowWidth / 2) - (caracter.Length / 2);
            for (int i = 0; i < caracter.Length; i++)
            {
                Console.SetCursorPosition(column, row++);
                Console.Write(caracter[i]);
            }
        }
    }
}