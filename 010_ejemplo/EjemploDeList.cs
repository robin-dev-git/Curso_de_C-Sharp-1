using System;
using System.Collections.Generic;

class EjemploDeList
{
    static void Main()
    {
        int i;
		List<int> datos = new List<int>();
		int numero;
        
        do{
            Console.Write("Dime un dato (-1) para terminar: ");
           	numero = Convert.ToInt32(Console.ReadLine());
			if (numero != -1) datos.Add(numero);
        }
		while (numero != -1);

        System.Console.WriteLine("Los datos son:");
        for(i = 0; i < datos.Count; i++)
        {
            Console.Write(datos[i] + " ");
        }

		Console.WriteLine();
        Console.WriteLine("Los datos al revés son:");
        for(i = datos.Count-1; i >= 0; i--)
        {
            Console.Write(datos[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Dime un dato: ");
        int datoBuscar = Convert.ToInt32(Console.ReadLine());
    	
		if (datos.Contains(datoBuscar)) Console.WriteLine("Está");
		else Console.WriteLine("No encontrado");
	}
}
