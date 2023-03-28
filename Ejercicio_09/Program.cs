internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "Ejercicio_9";

        Int32 largo = 0;
        Int32 respuesta = 0;
        bool seguir = true;

        do
        {

            Console.WriteLine("\nIngrese el largo de la piramide : ");
            largo = Int32.Parse(Console.ReadLine());


            for (int i = 0; i < largo+1; i++)
            {           
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nIngresar el largo para otra piramide ? 1-Si/2-No ");
            respuesta = Int32.Parse(Console.ReadLine());

            if(respuesta == 2)
            {
                seguir = false;
            }

            
        } while (seguir);

        Console.ReadKey();
    }
}