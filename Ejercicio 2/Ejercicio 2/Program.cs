//Ejercicio 2
Console.WriteLine(@"Dada la fecha actual extraer, el día, mes, año, y decir cuántos días faltan para
navidad y año nuevo.");

DateTime fechaActual = DateTime.Now;

    DateTime Navidad = new DateTime(fechaActual.Year, 12, 25);
    DateTime AñoNuevo = new DateTime(fechaActual.Year + 1, 1, 1);

    int diasParaNavidad = (Navidad - fechaActual).Days;
    int diasParaAñoNuevo = (AñoNuevo - fechaActual).Days;
    Console.WriteLine();
    Console.WriteLine($" Para Navidad restan {diasParaNavidad} dias");
    Console.WriteLine();
    Console.WriteLine($" Para Año Nuevo restan : {diasParaAñoNuevo} dias");

Console.WriteLine("Ing. Gutierrez");

