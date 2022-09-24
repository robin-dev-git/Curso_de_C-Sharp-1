using System;
class Ejercicios
{
    static void Main()
    {
        int i;
        // 1. Escribe los números del 10 al 20.
        for (i = 10; i <= 20; i++) Console.Write(i + " ");
        Console.WriteLine();
        // 2. Escribe los números del 15 al 10, descendiendo.
        for (i = 15; i >= 10; i--) Console.Write(i + " ");
        Console.WriteLine();
        // 3. Escribe los múltiplos del 3, desde 3 hasta 30.
        for (i = 3; i <= 30; i += 3) Console.Write(i + " ");
        Console.WriteLine();
        // 4. Escribe 10 veces "Hola".
        for (i = 1; i <= 10; i++) Console.Write("Hola");
        Console.WriteLine();
        // 5. Crea un "Bucle sin fin", que escriba continuamente "Hola".
        for (i = 10; i <= 20; i++) Console.Write(i + " ");
        Console.WriteLine();
    }
}
