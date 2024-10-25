//Victor Núñez
// Date: 2024/04/19
//Manejo de excepciones
//https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception?view=net-8.0
//https://learn.microsoft.com/en-us/dotnet/api/system.exception?view=net-8.0
using System;
class Program
{
    static void Main(string[] args)
    { 
        try
        {
            Console.WriteLine("Ingrese un número del 1 al 7");
            int dia = int.Parse(Console.ReadLine());
            
            Console.WriteLine(getDiaSemana(dia));
        }
      
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("El número ingresado no es válido");
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("El valor ingresado no es un número");
            Console.WriteLine(e.Message);
        }
        //catch (Exception e)
        //{
        //    Console.WriteLine("Error\n"+e.GetType().Name);
        //    Console.WriteLine(e.Message);
        //}



    }

    static string getDiaSemana(int dia)
    {
        string diaSemana = "";
        switch (dia)
            {
                case 1:
                    diaSemana = "Lunes";
                    break;
                case 2:
                    diaSemana = "Martes";
                    break;
                case 3:
                    diaSemana = "Miercoles";
                    break;
                case 4:
                    diaSemana = "Jueves";
                    break;
                case 5:
                    diaSemana = "Viernes";
                    break;
                case 6:
                    diaSemana = "Sabado";
                    break;
                case 7:
                    diaSemana = "Domingo";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Dia no existente");
            }       
      
        return diaSemana;
    }//Fin de getDiaSemana
   
}