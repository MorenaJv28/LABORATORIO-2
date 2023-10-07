//Ejercicio 1
Console.WriteLine(@"1. Pedir las coordenadas del punto 1 (x, y) y radio en el centro (h, k) y calcular la
distancia");

Console.Write("Bienvenido a su calculadora");
Console.Write("============================");

Console.Write("Introduce la coordenada x: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce la coordenada y: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce la coordenada h: ");
double h = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce la coordenada k: ");
double k = Convert.ToDouble(Console.ReadLine());

double R = Math.Sqrt(Math.Pow(h - x1, 2) + Math.Pow(k - y1, 2));

Console.WriteLine($"La distancia de los puntos P({x1}, {y1}) y Q({h}, {k}) es: {R}");













