//probando DateTime.Parse  
        DateTime fecha = DateTime.Parse("2021-10-10");
        Console.WriteLine(fecha.ToString("yyyy-MM-dd"));
        Console.WriteLine(fecha.ToString("dd-MM-yyyy"));
        //probando DateTime.ParseExact
        DateTime fecha2 = DateTime.ParseExact("10-10-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(fecha2.ToString("yyyy-MM-dd"));
        Console.WriteLine(fecha2.ToString("dd-MM-yyyy"));
        //probando DateTime Convert.ToDateTime
        DateTime fecha3 = Convert.ToDateTime("2021-10-10");
        Console.WriteLine(fecha3.ToString("yyyy-MM-dd"));
        Console.WriteLine(fecha3.ToString("dd-MM-yyyy"));
        //obtener formato del sistema
        Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
        Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern);
