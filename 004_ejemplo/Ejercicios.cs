using System;
class Ejercicios
{
    static void Main()
    {
        /*
            1. Pide al Usuario su nombre y responde "Acceso permitido" o "Acceso denegado",
            Según si ha introducido tu nombre u otro distinto.
        */
        System.Console.WriteLine("El usuario puede permitir entrada");
        System.Console.Write("Introduce tú nombre: ");
        string nombreU = Console.ReadLine();

        if (nombreU == "") System.Console.WriteLine("Por favor, debes introducir llena de texto");
        else if (nombreU == "Robinux") System.Console.WriteLine("Acceso permitido");
        else System.Console.WriteLine("Acceso denegado");

        /*
            2. Pide al Usuario dos número entero y muestra su 
            división en caso de que el segundo no sea cero
        */
        int num1, num2;
        System.Console.WriteLine("\nMuestro la división en caso:");
        System.Console.Write("Introduce un número: ");
        num1 = int.Parse(Console.ReadLine());
        System.Console.Write("Introduce otro número: ");
        num2 = int.Parse(Console.ReadLine());

        if ((num1 < 0) && (num2 < 0)) System.Console.WriteLine("Error, esto son negativos");
        else if ((num1 == 0) && (num2 == 0)) System.Console.WriteLine("Error, Los números son ceros");
        else System.Console.WriteLine($"El resultado de división es de: {(num1 / num2)}");

        /*
            3. Pide al Usuario dos número entero responde
            cuántos de ellos son positivos.
        */
        int num3, num4;
        System.Console.WriteLine("\nResponde cuántos de ellos son positivo;");
        System.Console.Write("Introduce un número: ");
        num3 = int.Parse(Console.ReadLine());
        System.Console.Write("Introduce otro número: ");
        num4 = int.Parse(Console.ReadLine());
        if ((num3 > 0) && (num4 > 0)) System.Console.WriteLine("Los números son positivos");
        else if ((num3 > 0) || (num4 > 0)) System.Console.WriteLine("Alguno número es positivo, otro no es positivo y/o el numero es cero. ");
        else System.Console.WriteLine("Los números no son positivos.");
    }
}