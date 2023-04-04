internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "Ejercicio_03";

        Boolean esPrimo = false;

        Console.Write("ingrese un numero : ");
        bool success = int.TryParse(Console.ReadLine(), out Int32 numero);


        Console.WriteLine("Numeros primos: \n");
        for (Int32 i = 2; i < numero; i++)
        {
            esPrimo = true;
            for (Int32 j = 2; j < i; j++)
            {
                if ((i % j) == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo) 
            {
                Console.Write(i + " ");
            }
        }

        Console.ReadKey();
    }
}