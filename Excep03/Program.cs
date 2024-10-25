using System.Globalization;
using System.Reflection.Metadata;

class Program{
    static void Main(string[] args){
      
       try
        {
            Console.Write("Ingrese el nombre de la persona : ");
            string nombre = Console.ReadLine();
           
            Console.Write("Ingrese la fecha de nacimiento dd/MM/yyyy :");
            DateTime fechaNacimiento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
           
            Console.Write("Ingrese el sexo (M/F/I): ");
            char sexo = char.Parse(Console.ReadLine());
            
            Persona persona = new Persona(nombre, fechaNacimiento, sexo);
 
            persona.Mostrar();
        }
     
        catch (CustomException ce)
        {
            Console.WriteLine(ce.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.GetType().Name);
        }
    }
}
