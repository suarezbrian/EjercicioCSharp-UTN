using Ejercicio_I04.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Boligrafo azul = new Boligrafo(ConsoleColor.Blue, 100);
        Boligrafo rojo = new Boligrafo(ConsoleColor.Red, 50);
        string dibujo;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Bolígrafo azul: color {azul.ObtenerColor()}, tinta {azul.ObtenerTinta()}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Bolígrafo rojo: color {rojo.ObtenerColor()}, tinta {rojo.ObtenerTinta()}");

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        rojo.Pintar(50, out dibujo);
        Console.WriteLine(dibujo);        

        Console.ForegroundColor = ConsoleColor.Blue;
        azul.Pintar(10, out dibujo);
        Console.WriteLine(dibujo);

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Bolígrafo rojo: color {azul.ObtenerColor()}, tinta {azul.ObtenerTinta()}");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Bolígrafo rojo: color {rojo.ObtenerColor()}, tinta {rojo.ObtenerTinta()}");

        Console.WriteLine();
        rojo.Pintar(50, out dibujo);
        Console.WriteLine(dibujo);

        rojo.RecargarTinta();
        Console.WriteLine("Tinta Cargada al Maxinmo");

        Console.WriteLine();
        rojo.Pintar(50, out dibujo);
        Console.WriteLine(dibujo);
        Console.WriteLine($"Bolígrafo rojo: color {rojo.ObtenerColor()}, tinta {rojo.ObtenerTinta()}");

        Console.ReadKey();
    }
}