using System;

class Ejercicios
{
    static void Main()
    {
        /*
            1. Pide al Usuario el número de un mes y responde su nombre.
            Por ejemplo, para el mes 3 deberás responder "Marzo". 
        */
        Console.Write("Introduce un número de mes: ");
        int mes = Convert.ToInt16(Console.ReadLine());

        switch (mes)
        {
            case 1: Console.WriteLine("Enero"); break;
            case 2: Console.WriteLine("Febrero"); break;
            case 3: Console.WriteLine("Marzo"); break;
            case 4: Console.WriteLine("Abril"); break;
            case 5: Console.WriteLine("Mayo"); break;
            case 6: Console.WriteLine("Junio"); break;
            case 7: Console.WriteLine("Julio"); break;
            case 8: Console.WriteLine("Agosto"); break;
            case 9: Console.WriteLine("Septiembre"); break;
            case 10: Console.WriteLine("Octubre"); break;
            case 11: Console.WriteLine("Novimebre"); break;
            case 12: Console.WriteLine("Diciembre"); break;

            default: Console.WriteLine("No es un mes válido"); break;
        }

        /*
            2. Pide al Usuario el número de un mes, en minisculas
            (Por ejemplo, "marzo") y responde cuántos días tiene (para "marzo", la respuesta sería 31).
        */
        Console.Write("Escribe un mes con miniscula: ");
        string mesDias = Console.ReadLine();

        switch (mesDias)
        {
            case "enero": Console.WriteLine("Enero de los días es 31"); break;
            case "febrero": Console.WriteLine("Febrero de los días es 28"); break;
            case "marzo": Console.WriteLine("Marzo de los días es 31"); break;
            case "abril": Console.WriteLine("Abril de los días es 30"); break;
            case "mayo": Console.WriteLine("Mayo de los días es 31"); break;
            case "junio": Console.WriteLine("Junio de los días es 30"); break;
            case "julio": Console.WriteLine("Julio de los días es 31"); break;
            case "agosto": Console.WriteLine("Agosto de los días es 31"); break;
            case "septiembre": Console.WriteLine("Septiembre de los días es 30"); break;
            case "octubre": Console.WriteLine("Octubre de los días es 31"); break;
            case "noviembre": Console.WriteLine("Novimebre de los días es 30"); break;
            case "diciembre": Console.WriteLine("Diciembre de los días es 31"); break;

            default: Console.WriteLine("No es un mes válido"); break;
        }
    }
}