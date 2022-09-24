using System;

class PruebaDeSwitch
{
    static void Main()
    {

        Console.Write("Introduce un número: ");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 2:
                System.Console.WriteLine("Es dos");
                break;
            case 3:
                System.Console.WriteLine("Es tres");
                break;
            case 4:
                System.Console.WriteLine("Es cuatro");
                break;
            case 5:
                System.Console.WriteLine("Es cinco");
                break;

            default:
                System.Console.WriteLine("No está entre el 2 y el 5");
                break;
        }

        System.Console.Write("Introduce el número de un día de la semana: ");
        int dia = Convert.ToInt32(System.Console.ReadLine());

        switch (dia)
        {
            case 1: System.Console.WriteLine("Lunes"); break;
            case 2: System.Console.WriteLine("Martes"); break;
            case 3: System.Console.WriteLine("Miércoles"); break;
            case 4: System.Console.WriteLine("Jueves"); break;
            case 5: System.Console.WriteLine("Viernes"); break;
            case 6: System.Console.WriteLine("Sábado"); break;
            case 7: System.Console.WriteLine("Domingo"); break;
            default: System.Console.WriteLine("No es un día válido."); break;
        }
    }
}