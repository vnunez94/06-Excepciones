using System;

public class Persona
{
    private string nombre;
    private DateTime fechaNacimiento;
    private char sexo;

    public Persona(string nombre, DateTime fechaNacimiento, char sexo)
    {
        SetNombre(nombre);
        SetFechaNacimiento(fechaNacimiento);
        SetSexo(sexo);
    }

    public void SetNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre no puede estar vacío o ser nulo");
        }
        this.nombre = nombre.Trim();
    }

    public string GetNombre()
    {
        return nombre;
    }

    public void SetFechaNacimiento(DateTime fechaNacimiento)
    {
        if (fechaNacimiento > DateTime.Now)
        {
            throw new ArgumentException("La fecha de nacimiento no puede estar en el futuro");
        }
        this.fechaNacimiento = fechaNacimiento.Date;
    }

    public DateTime GetFechaNacimiento()
    {
        return fechaNacimiento;
    }

    public int CalcularEdad()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - fechaNacimiento.Year;
        if (fechaNacimiento > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }

    public void SetSexo(char sexo)
    {
        sexo = char.ToUpper(sexo);
        if (sexo == 'M' || sexo == 'F' || sexo == 'I')
        {
            this.sexo = sexo;
        }
        else
        {
            throw new ArgumentException("Sexo no válido");
        }
    }

    public char GetSexo()
    {
        return sexo;
    }

    public virtual void Mostrar()
    {
        Console.WriteLine("=====================");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Edad: {CalcularEdad()}");
        Console.WriteLine($"Sexo: {sexo}");
    }

    public override string ToString()
    {
        return $"Nombre: {nombre}, Fecha de nacimiento: {fechaNacimiento}, Sexo: {sexo}";
    }
}
