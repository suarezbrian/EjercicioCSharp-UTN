using Ejercicio_I03.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Estudiante estudianteUno = new Estudiante("Jose", "Pepito", "0001");
        estudianteUno.GuardarPrimerParcial(6);
        estudianteUno.GuardarSegundoParcial(6);
        Console.WriteLine(estudianteUno.MostrarDatos());


        Estudiante estudianteDos = new Estudiante("Juan", "Garcia", "0002");
        estudianteDos.GuardarPrimerParcial(8);
        estudianteDos.GuardarSegundoParcial(9);
        Console.WriteLine(estudianteDos.MostrarDatos());


        Estudiante estudianteTres = new Estudiante("Perez", "Sanchez", "0002");
        estudianteTres.GuardarPrimerParcial(3);
        estudianteTres.GuardarSegundoParcial(2);
        Console.WriteLine(estudianteTres.MostrarDatos());

        Console.ReadKey();

    }
}