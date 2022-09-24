using System;

class BucleFor
{
    static void Main()
    {
        int i;

        // Ordenar los números
        for (i = 1; i <= 10; i = i + 1)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Ordenar los números al revés
        for (i = 10; i >= 1; i = i - 1)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Varias textos 5 repetir.
        for (i = 1; i <= 5; i++)
        {
            Console.Write("Hola");
        }
        Console.WriteLine();

        // Ordenar los números al revés
        for (i = 3; i >= 1; i = i - 1)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Números pares
        for (i = 4; i <= 10; i = i + 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Números multiples por 5
        for (i = 5; i <= 25; i += 5)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Bucle for No termino, Tiene problema con logica de programacion
        /*
        for (i = 5; i >= 5; i = i + 5)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        */
    }
}