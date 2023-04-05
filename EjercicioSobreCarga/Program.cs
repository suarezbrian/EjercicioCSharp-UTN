using EjercicioSobreCarga.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Cosa cosa = new Cosa();
        Console.WriteLine(Cosa.Mostrar(cosa));

        cosa.EstablecerValor(102);
        cosa.EstablecerValor("Desde el metodo");
        cosa.EstablecerValor(DateTime.Now);
        Console.WriteLine(Cosa.Mostrar(cosa));

        cosa = new Cosa("SobreCarga");
        cosa = new Cosa(100,"SobreCarga");
        cosa = new Cosa(DateTime.Now, 101, "SobreCarga");
        Console.WriteLine(Cosa.Mostrar(cosa));


        Console.ReadKey();
    }
}