using System;

class Ejercicios
{
    static void Main()
    {
        //Pide al Usuario una clave de acceso. 
        //No le dejes seguir hasta introduzca la clave correcta
        // (Por ejemplo, 1234).
        int clave;
        Console.Write("Introduce tu número de clave acceso: ");
        clave = Convert.ToInt32(Console.ReadLine());

        while (clave != 1234)
        {
            Console.Write("Tu clave es incorrecta, vuevla digite tu número de clave acceso: ");
            clave = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("Bienvenido a Hackerman");
        Console.WriteLine("Ya termina el programa");
    }
}