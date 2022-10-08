using System;

class EjemploFunciones
{
	static void Main()
	{
		// ...
		Felicitar(10);
		
		// ...
		Felicitar(15);
		
		// ...
		Felicitar(20);
	}

	static void Felicitar(int admiraciones)
	{
		Console.Write("Lo estás haciendo bastante bien");

		for (int i = 0; i < admiraciones; i++)
		{
			Console.Write("!");
		}
		Console.WriteLine();
	}
}
