using System;

class EjemploFuncion2
{
    static int duplicar(int n)
    {
        return n * 2;
    }

    static int sumar(int a, int b)
    {
        return a + b;
    }

    static int sumarHasta(int limite)
    {
        int suma = 0;
        for (int i = 0; i <= limite; i++)
        {
            suma += i;
        }
        return suma;
    }

    static void Main()
    {
        int x;

        Console.WriteLine(duplicar(4));
        x = duplicar(10);
        Console.WriteLine(x);
        Console.WriteLine(sumar(12, 23));
        Console.WriteLine(sumarHasta(5));
    }
}