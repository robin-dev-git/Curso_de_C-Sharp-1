using System;

class Ejericios
{
    static void Main()
    {
        /*
		 * 1. Crea una función "EscribirAsteriscos", que muestre
		 * en una misma línea de pantalla tantos asteriscos como
		 * indique un parámetro, que será un número entero.
		*/

        Console.Write("Escribe un número de Asteriscos: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Escribe un número de imprimido entre 1 y 20 veces: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if ((num > 0) && (num <= 20))
        {
            for (int i = 0; i < num; i++)
            {
                EscribirAsteriscos(num1);
                Console.Write("Lo estás haciendo muy bien");
                EscribirAsteriscos(num1);
                Console.WriteLine();
            }
        }
        else Console.WriteLine("Solo entre 1 y 20 de número..");

        Console.WriteLine("Ya termina de programar");
    }

    static void EscribirAsteriscos(int numero)
    {
        for (int i = 0; i < numero; i++)
        {
            Console.Write("*");
        }
    }
}
