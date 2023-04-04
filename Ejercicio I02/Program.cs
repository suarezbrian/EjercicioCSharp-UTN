using Entidades;
using System;

internal class Program
{
    private static void Main(string[] args)
    { 
        PersonaI02 obj1 = new PersonaI02("Brian", new DateTime(1997, 12, 17), 40123432);
        obj1.MostrarDatos();
        obj1.MostrarSiEsMayor();
        PersonaI02 obj2 = new PersonaI02("Lucas", new DateTime(1987, 01, 27), 20153462);
        obj2.MostrarDatos();
        obj2.MostrarSiEsMayor();
        PersonaI02 obj3 = new PersonaI02("Dario", new DateTime(2017, 03, 07), 30127832);
        obj3.MostrarDatos();
        obj3.MostrarSiEsMayor();
        Console.ReadKey();
    }
}