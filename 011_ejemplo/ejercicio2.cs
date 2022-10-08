using System;

class Ejericios
{
    static void Main()
    {
        /*
		 * 2. Crea una función "ResovlerSegundoGrado", que
		 * calculará y mostrará las soluciones de una ecuación de
		 * segunod grado ax2 + bx + c = 0, a partir de los valores 
		 * de a, b y c (Puedes hallar la raíz de "n" con "Math.Sqrt(n)"
		*/
        double n1, n2, n3;
        Console.WriteLine("¡Hola! Vamos a resolver una ecuación de segundo grado:\n    ax² + bx + c = 0\n");
        Console.Write("Introduzce el coeficiente a: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduzce el coeficiente b: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduzce el coeficiente c: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        ResovlerSegundoGrado(n1, n2, n3);

    }

    static void ResovlerSegundoGrado(double a, double b, double c)
    {
        double n, x1, x2, raiz;

        n = (b * b) - 4 * a * c;

        if (n < 0)
        {
            Console.WriteLine("La ecuacion no tiene soluciones reales.");
        }
        else
        {
            raiz = Math.Sqrt(n);

            x1 = (-b + raiz) / (2 * a);

            if (n != 0)
            {
                x2 = (-b - raiz) / (2 * a);
                Console.WriteLine($"Las soluciones son x1={x1} y x2={x2}");
            }
            else Console.WriteLine($"La solución es x={x1}");
        }
    }
}
