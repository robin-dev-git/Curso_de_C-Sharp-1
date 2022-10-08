using System;
using System.Collections.Generic;

class Ejercicios
{
    static void Main()
    {
        /*
		1. Pide al usuario distintos textos, guárdalos en una
		lista y luego muestra todos ellos en orden inverso.
		*/
        List<string> textos = new List<string>();
        string letras;

        do
        {
            Console.Write("Escribe los textos que quieras, (salir) para terminar: ");
            letras = Console.ReadLine();
            if (letras != "salir")
            {
                textos.Add(letras);
            }
        } while (letras != "salir");

        Console.WriteLine("Los datos de textos son en orden:");
        for (int i = 0; i < textos.Count; i++)
        {
            Console.Write(textos[i] + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("Los datos de textos son en orden inverson:");
        for (int i = textos.Count - 1; i >= 0; i--)
        {
            Console.Write(textos[i] + ", ");
        }

        Console.WriteLine();
        /*
		2. Pide al usuario varios números enteros, guárdalos
		en una lista y luego permítele buscar si un cierto dato era
		parte de esos números iniciales.
		*/
        List<int> numero = new List<int>();
        int num;
        do
        {
            Console.Write("Introduzce un número entero, y para terminar (-1): ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num != -1)
            {
                numero.Add(num);
            }
        }
        while (num != -1);

        Console.WriteLine();

        Console.Write("Escribe te busca el número que te escribió era parte: ");
        int numBuscar = Convert.ToInt32(Console.ReadLine());

        if (numero.Contains(numBuscar))
        {
            Console.WriteLine("Ya encontrate");
        }
        else
        {
            Console.WriteLine("No se encontrado");
        }
    }
}
