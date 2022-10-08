using System;

class Ejercicios
{
	static void Main()
	{
		/* 1. Pide al usuario 10 números reales y luego
		* muéstralos en orden inverso (del último al primero)
		*/
		int mes;
		double[] datos1 = new double[10];
		for (int i = 0; i < 10; i++)
		{
			Console.Write("Dime un número: ");
			datos1[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Los números en orden:");
		for (int i = 0; i < 10; i++) Console.Write(datos1[i] + ", ");
		Console.WriteLine();
		Console.WriteLine("Los números en orden inverso");
		for (int i = 9; i >= 0; i--) Console.Write(datos1[i] + ", ");

		/* 2. Prepara un array con los nombres de los meses.
			Luego preguna al usuario un número y muestra 
			el nombre de ese mes, usando un array.
		*/
		Console.WriteLine();
		string[] meses = {
			"Enero", "Febrero", "Marzo", "Abril",
			"Mayo", "Junio", "Julio", "Agosto",
			"Septiembre", "Octubre", "Noviembre", "Diciembre"
		};
		Console.Write("Introduzce un número de mes: ");
		mes = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("El nombre del mes es: " + meses[mes - 1]);
	
		/* 3. A partir del array de nombres de meses, permite al
				usuario buscar el número de un cierto mes (por ejemplo,
				para "Marzo", el programa le deberá responder "3").
		*/
		Console.Write("Introduzce el nombre de un mes: ");
		string nombreMes = Console.ReadLine();
		int posicion = -1;
		for (int i = 0; i < meses.Length; i++)
		{
			if (nombreMes == meses[i])
			{
				posicion = i + 1;
			}
		}
		if (posicion == -1) Console.WriteLine("No se encontrado en mes");
		else Console.WriteLine("Encontrado el número de mes:  " + posicion);
	}
}
