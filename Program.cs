
bool validador = true;

while (validador == true)
{
    Console.Clear();


    Ejercicios.color();
    Console.WriteLine(@"

 _____________________
/ ,-----------------. \
| |    1.05459 e -34| |
| `-----------------' |
| [@ ] On/Off  ###### |
|              ###### |
| [7] [8] [9] [C] [AC]|
|                     |
| [4] [5] [6] [X] [%] |
|                     |
| [1] [2] [3] [+] [-] |
|                     |
| [0] [.]  [EXP]  [=] |
\_____________________/


  1) indicacion si este es equilatero, Isósceles, Escaleno

  2) indicacion si este es Rectángulo, Acutángulo u Obtusángulo. 

  3) verificador de cuadrados

  4) generador de tabla de multiplicar

  5) generador web

  6)salir

");
    Ejercicios.color();

    Console.Write("ingrese el numero del ejercicio :");
    String entrada = Console.ReadLine();

    Ejercicios.color();

    if (entrada == "1") 
    {

        Ejercicios.Ejercicios_1();
    }
    else if (entrada == "2")
    {
        Ejercicios.Ejercicios_2();
    }
    else if (entrada == "3")
    {
        Ejercicios.Ejercicios_3();
    }
    else if (entrada == "4")
    {
        Ejercicios.Ejercicios_4();
    }
    else if (entrada == "5")
    {
        Ejercicio_5.Salida();
    }
    else if (entrada == "6")
    {
        validador = false;
    }
    else
    {
        Console.WriteLine("escriba algo valido porfavor");
    }
}

