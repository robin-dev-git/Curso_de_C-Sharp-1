using System;

class Ejericios
{
    static int Mayor(int num1, int num2)
    {

        if (num1 >= num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
    static void Main()
    {

        /*
		 * 2. Crea una función "Mayor", que devuelva el mayor
		 * de los dos números enteros que se le pasen como
		 * parámetros.
		*/
        Console.WriteLine(Mayor(2, 5));
    }
}
