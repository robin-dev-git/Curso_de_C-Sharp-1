using System;

class Ejercicos
{
    static void Main()
    {
        /*
		 * 1. Pide al usuario una clave de acceso, esta vez con Do-While.
		 * No le dejes seguir hasta que introduzca la clave correcta
		 * (Por ejemplo, 1234)
		*/
        int clave;
        do
        {
            Console.Write("Digite tu número de clave acceso: ");
            clave = Convert.ToInt32(Console.ReadLine());
            if (clave != 1234) Console.WriteLine("No se permite acceso");
        }
        while (clave != 1234);
        Console.WriteLine("Bienvenido a Hackerman");

        /*
		 * 2. Crea una variante mejorada, que le pida tanto su "login"
		 * (nombre de usuario) como su "Password" (clave de acceso),
		 * y no le permita seguir hasta que ambos sean correctos.
		*/
        string password, login;
        do
        {
            Console.Write("Escribe tu Login: ");
            login = Console.ReadLine();
            Console.Write("Escribe tu Password: ");
            password = Console.ReadLine();

            if ((password != "abc123") || (login != "robinux")) Console.WriteLine("Login y/o Password son incorrectos.");

        } while ((password != "abc123") || (login != "robinux"));

        Console.WriteLine("Bienvenido a " + login);
    }
}
