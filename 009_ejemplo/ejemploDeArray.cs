using System;

class ejemploDeArray
{
    static void Main()
    {
        int i;
        int[] datos = new int[5];
        int dia;
        string nombreDia;

        for (i = 0; i < 5; i++)
        {
            Console.Write("Dime un datos: ");
            datos[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Los datos son: ");
        for (i = 0; i < 5; i++)
        {
            Console.Write(datos[i] + ", ");
        }

        Console.WriteLine("Los datos al revés son: ");
        for (i = 4; i >= 0; i--)
        {
            Console.Write(datos[i] + ", ");
        }
        Console.WriteLine();

        string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        Console.Write("Dime un número de día: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El nombre del día es: " + diasSemana[dia - 1]);

        Console.Write("Dime el nombre de un día: ");
        nombreDia = Console.ReadLine();

        int posicion = -1;
        for (i = 0; i < diasSemana.Length; i++) if (nombreDia == diasSemana[i]) posicion = i + 1;

        if (posicion == -1) System.Console.WriteLine("No encontrado");
        else System.Console.WriteLine("Encontrado en " + posicion);
    }
}