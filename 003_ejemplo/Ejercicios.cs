using System;
public class Ejercicios
{
    static void Main()
    {
        /*
         1. Pide al Usuario su nombre y Dile "Bienvenido",
            seguido del nombre que haya introducido.
        */
        Console.WriteLine("Primer Ejercicio;");

        string nombreUsuario;
        Console.Write("Introduce tú nombre: ");
        nombreUsuario = Console.ReadLine();
        Console.Write("Bienvenido, ");
        Console.WriteLine(nombreUsuario);

        /*
         2. Pide al Usuario dos números realies (Decimales) 
            y muestra su división.
        */
        Console.WriteLine("Segundo Ejercicio;");

        double num1, num2;
        Console.Write("Introduce primer número real: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce segundo número real: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("La división de número real es de: ");
        Console.WriteLine(num1 / num2);

        /*
         3. Pide al Usuario dos números entero 
            y muestra su división y el resto de la divisón
        */
        Console.WriteLine("Tercer Ejercicio;");

        int num3, num4, resto;
        double dividir;
        Console.Write("Introduce Primer número entero: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce segundo número entero: ");
        num4 = Convert.ToInt32(Console.ReadLine());
        dividir = Convert.ToDouble(num3 / num4);
        resto = num3 % num4;
        Console.Write("El resultado de división es: ");
        Console.WriteLine(dividir);
        Console.Write("El resultado del resto de división es: ");
        Console.WriteLine(resto);
    }
}