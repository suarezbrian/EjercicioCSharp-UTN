using EjercicioClass01.Models;

internal class Program
{

    /*
        Crear la clase Creadora con los siguientes miembros:
        De clase:
        (-) fechaCreacionPrimerObjeto : DateTime;
        (-) contadorObjetosCreados : int;

        (+) ObtenerCantidadObjetosCreados() : int;
        * retorna el valor del atributo contadorObjetosCreados.

        Cosntructor (clase)
        * inicializa con la fecha actual (DateTime.Now) y con cero a sus atributos estáticos, según corresponda.

        De instancia:
        (-) fechaCreacion : DateTime;

        (+) ObtenerDiferencia() : string
        * retorna la diferencia (en milisegundos) entre la fechaCreacionPrimerObjeto y la fechaCreacion de la instancia actual.

        Constructor (instancia)
        * inicializa su atributo NO estático con la fecha actual (DateTime.Now).
        * incrementa en uno el atributo estático contadorObjetosCreados.

        En el Main:
        * crear 4 objetos y mostrar la diferencia de tiempos y cantidad de instancias creadas (ejecutado con F5)
        * realizar la misma tarea pero con una ejecución paso a paso (F11)
        * analizar resultados.
        * 
    */
    private static void Main(string[] args)
    {
        Creadora obj1 = new Creadora(DateTime.Now);
        Creadora obj2 = new Creadora(DateTime.Now);
        Creadora obj3 = new Creadora(DateTime.Now);
        Creadora obj4 = new Creadora(DateTime.Now);


        Console.WriteLine($"Cantidad de instancias Creadas {obj4.ObtenerCantidadObjetosCreados()}");
        Console.WriteLine(obj4.ObtenerDiferencia());


        Console.ReadKey();  
    }
}