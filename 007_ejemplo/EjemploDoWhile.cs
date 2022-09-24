using System;

class EjemploDoWhile
{
    static void Main()
    {
        int n1, n2;
        Console.Write("Introduce un número: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 == 0) Console.WriteLine("No debe ser cero.\n");
        }
        while (n2 == 0);
        Console.WriteLine("Su División es: " + (n1 / n2));
    }
}
