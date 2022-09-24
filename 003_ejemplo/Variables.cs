using System;

class Variables
{
    static void Main()
    {
        string nombre;
        int num1, num2;
        double num3;

        Console.Write("Dime tu nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Dime un número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime otro número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime un número más (real): ");
        num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Hola, ");
        Console.WriteLine(nombre);

        Console.Write("La suma de dos entero es: ");
        Console.WriteLine(num1 + num2);

        Console.Write("El cuadrado del último número es: ");
        Console.WriteLine(num3 + num3);
    }
}
