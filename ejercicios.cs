using System;

public class Ejercicios
{
	public static void Ejercicios_1()
	{
		Console.Clear();

		int lado1, lado2, lado3 = 0;

		Console.WriteLine(@"

 _____________________
|  _________________  |
| | JO           0. | |
| |_________________| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|

");

		color();

		Console.Write("ingrese la longitud del primer lado del triangulo :");
        int.TryParse(Console.ReadLine() , out lado1);
		Console.Write("ingrese la longitud del Segundo lado del triangulo :");
		int.TryParse(Console.ReadLine(), out lado2);
		Console.Write("ingrese la longitud del tercer lado del triangulo :");
        int.TryParse(Console.ReadLine(), out lado3);

		color();

		if (lado1 == lado2 && lado2 == lado3)
        {
			Console.WriteLine("el triangulo que usted ingreso es un equilatero");
		}
		else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
		{
			Console.WriteLine("el triangulo que usted ingreso es un isoseles");
        }
        else
        {
			Console.Write("el triangulo que usted ingreso es un escaleno");
		}

		Console.ReadKey();
	}
	public static void Ejercicios_2()
	{
		Console.Clear();

		double lado1, lado2, lado3 = 0.0;

		color();
		Console.WriteLine(@"

 _____________________
|  _________________  |
| | JO           0. | |
| |_________________| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|

");

		color();

		Console.Write("ingrese el angulo del primer lado del triangulo :");
		double.TryParse(Console.ReadLine(), out lado1);
		Console.Write("ingrese el angulo del Segundo lado del triangulo :");
		double.TryParse(Console.ReadLine(), out lado2);
		Console.Write("ingrese el angulo del tercer lado del triangulo :");
		double.TryParse(Console.ReadLine(), out lado3);

		color();

		if (lado1 == 90.0 || lado2 == 90.0 || lado3 == 90.0 )
		{
			Console.WriteLine("el triangulo que usted ingreso es un triangulo Rectángulo");
		}
		else if (lado1 < 90.0 || lado2 < 90.0 || lado3 < 90.0)
		{
			Console.WriteLine("el triangulo que usted ingreso es un ACUTÁNGULO");
		}
		else if (lado1 > 90.0 || lado2 > 90.0 || lado3 > 90.0)
		{
			Console.WriteLine ("el triangulo que usted ingreso es un OBTUSÁNGULO");
		}
		else
		{
			Console.WriteLine("el triangulo que usted ingreso no es Rectángulo,ACUTÁNGULO ni OBTUSÁNGULO");
		}

		Console.ReadKey();
	}
	public static void Ejercicios_3()
	{
		Console.Clear();

		double lado1, lado2, lado3 , lado4 , operacion = 0;

		color();
		Console.WriteLine(@"

 _____________________
|  _________________  |
| | JO           0. | |
| |_________________| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|

");

		color();

		Console.Write("ingrese el angulo interior del primer lado del posible cuadrado :");
		double.TryParse(Console.ReadLine(), out lado1);
		Console.Write("ingrese el angulo interior del Segundo lado del  posible cuadrado :");
		double.TryParse(Console.ReadLine(), out lado2);
		Console.Write("ingrese el angulo interior del tercer lado del  posible cuadrado :");
		double.TryParse(Console.ReadLine(), out lado3);
		Console.Write("ingrese el angulo interior del cuarto lado del  posible cuadrado :");
		double.TryParse(Console.ReadLine(), out lado4);

		color();

		operacion = lado1 + lado2 + lado3 + lado4;

		if (operacion == 360.0)
		{
			Console.WriteLine("mediante los angulos que usted ingreso se puede determinal que la figura es un cuadrado");
		}else
		{
			Console.WriteLine("mediante los angulos que usted ingreso se puede determinal que la figura no es un cuadrado");
		}

		Console.ReadKey();
	}
	public static void Ejercicios_4()
	{
		Console.Clear();

		int entrada , operacion = 0;

		color();
		Console.WriteLine(@"

 _____________________
|  _________________  |
| | JO           0. | |
| |_________________| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|

");

		color();

		Console.Write("ingrese un numero :");
		int.TryParse(Console.ReadLine(), out entrada);

		color();

		for (int i = 0; i <= 12; i = i + 1)
		{
			operacion = entrada * i;
			Console.WriteLine(" {0} * {1} = {2} ",entrada,i,operacion);
			Thread.Sleep(500);

		}


		Console.ReadKey();
	}



public static void abrir(string uri)
    {

		var psi = new System.Diagnostics.ProcessStartInfo();
		psi.UseShellExecute = true;
		psi.FileName = uri;
		System.Diagnostics.Process.Start(psi);
	}

public static void color()
	{

		Random r = new Random();

		int coco = r.Next(1, 9);

		if (coco == 1)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
		}
		else if (coco == 2)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
		}
		else if (coco == 3)
		{
			Console.ForegroundColor = ConsoleColor.Green;
		}
		else if (coco == 4)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
		}
		else if (coco == 5)
		{
			Console.ForegroundColor = ConsoleColor.Magenta;
		}
		else if (coco == 6)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
		}
		else if (coco == 7)
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		else if (coco == 8)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
		}

		else if (coco == 9)
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
		}



	}
}
