internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "Ejercicio_1";
        Int32 numero = 0;
        Int32 numeroMax = 0;
        Int32 numeroMin = 0;
        Int32 contador = 0;
        float promedio = 0;


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un numero : ");
            numero = Int32.Parse(Console.ReadLine());

            if(i == 0 || numero > numeroMax)
            {
                numeroMax = numero;
            }

            if (i == 0 || numero < numeroMin)
            {
                numeroMin = numero;
            }

            contador += numero;
        }

        promedio = contador / 5;

        Console.WriteLine("El promedio es {0}, el maximo es {1}, el minimo es {2}", promedio, numeroMax, numeroMin);
        Console.ReadKey();
    }
}