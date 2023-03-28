using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "Ejercicio_4";

        int numero = 0;
        int contador = 0;

        Console.Write("ingrese un numero : ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
           
            for (int j = 1; j <= (i / 2); j++)
            {
                if (i % j == 0)
                {
                    contador += j;
                }
            }

            if (contador == i)
            {
                Console.WriteLine("El numero {0} es perfecto", i);
            }

            contador = 0;
        }


        Console.ReadKey();
    }
}