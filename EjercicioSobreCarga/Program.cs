using EjercicioSobreCarga.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Cosa cosa = new Cosa();

        //cosa.EstablecerValor(10);
        //cosa.EstablecerValor("Texto");
        //cosa.EstablecerValor(DateTime.Now);

        Console.WriteLine(Cosa.Mostrar(cosa));

        Console.ReadKey();
    }
}