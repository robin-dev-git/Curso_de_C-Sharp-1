using System;

class Ejericios
{
    static int Buscar(int[] datos, int n)
    {
        int i;
        int posicion = -1;
        for (i = 0; i < datos.Length; i++)
        {
            if (n == datos[i])
                posicion = i;  // Devolvemos la primera como 0
        }
        return posicion;
    }

    static void Main()
    {
        int[] numeros = { 3, 5, 7 };

        Console.WriteLine("El 3 está en la posición: "
            + Buscar(numeros, 3));

    }
}