using System;
class PruebaDeIF
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int n = Convert.ToInt32(Console.ReadLine());

        /*
        >  Mayor que
        <  Menor que
        >= Mayor o igual que
        <= Menor o igual que
        == Igual a
        != Distinto de
        */

        if (n > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else
        {
            Console.WriteLine("El número es negativo ó cero.");
        }
        if (n < 0)
        {
            Console.WriteLine("EL número es negativo");
        }
        if (n == 5)
        {
            Console.WriteLine("El número 5 es igual a " + n);
        }
        if (n != 3)
        {
            Console.WriteLine("El número es distinto de " + n);
        }

        /*
            && es AND o Y
            || es OR o O
            ! es NOT o No
        */
        if ((n == 2) || (n == 3))
        {
            Console.WriteLine("El número es 2 o 3");
        }
        if ((n > 0) && (n % 2 == 0))
        {
            System.Console.WriteLine("El número es positivo y par");
        }
        if (!(n < 0))
        {
            System.Console.WriteLine("El número No es negativo");
        }

        // Usar varias condiciones IF y ELSE
        if (n == 2)
        {
            System.Console.WriteLine("Es dos");
        }
        else if (n == 3)
        {
            System.Console.WriteLine("Es tres");
        }
        else if (n == 4)
        {
            System.Console.WriteLine("Es cuatro");
        }
        else if (n == 5)
        {
            System.Console.WriteLine("Es cinco");
        }
        else
        {
            System.Console.WriteLine("No está entre el 2 y el 5");
        }

        // Ó sintaxis más ahorrar el tiempo y espacio de plantilla.
        if (n == 2) System.Console.WriteLine("Es dos");
        else if (n == 3) System.Console.WriteLine("Es tres");
        else if (n == 4) System.Console.WriteLine("Es cuatro");
        else if (n == 5) System.Console.WriteLine("Es cinco");
        else System.Console.WriteLine("No está entre el 2 y el 5");

        System.Console.Write("Introduce tú nombre: ");
        string nombre = Console.ReadLine();
        if (nombre == "Robin")
        {
            System.Console.WriteLine("Si eres " + nombre + ", bienvenido");
        }
        else
        {
            System.Console.WriteLine("Lo siento, No es tu nombre");
        }
    }
}