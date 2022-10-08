using System;

class EjemploWhile
{
    static void Main()
    {
        int n1, n2;
        Console.Write("Introduce un número: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce otro número: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        // No debe usar Condicional con IF.
        while (n2 == 0)
        {
            Console.Write("No debe ser cero, vuelva introducir otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Su División es: " + (n1 / n2));
    }
}
