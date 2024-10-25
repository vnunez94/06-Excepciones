//UASD
//Víctor Núñez
//fecha: 19/04/2024
/*Manejo de excepcioe s en c#
clasico ejemplo de manejo de excepciones en c#
Dividir por cero
*/
using System;

namespace Excepciones01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int c = 0;
           
            try
            {
                c = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Resultado: " + c);
        }
    }
}