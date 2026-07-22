Console.WriteLine("=======================================");
Console.WriteLine("      DEVELOPER TOOLKIT");
Console.WriteLine("=======================================");
Console.WriteLine();

Console.WriteLine("Selecciona una opción:");
Console.WriteLine("1. Saludar");
Console.WriteLine("2. Saber si eres mayor de edad");
Console.WriteLine("3. Salir");
Console.WriteLine();

Console.Write("Opción: ");

int opcion = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (opcion == 1)
{
    Console.Write("¿Cuál es tu nombre? ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Hola " + nombre + ".");
}

else if (opcion == 2)
{
    Console.Write("¿Cuál es tu edad? ");

    int edad = Convert.ToInt32(Console.ReadLine());

    if (edad >= 18)
    {
        Console.WriteLine("Eres mayor de edad.");
    }
    else
    {
        Console.WriteLine("Eres menor de edad.");
    }
}

else if (opcion == 3)
{
    Console.WriteLine("Hasta luego.");
}

else
{
    Console.WriteLine("La opción no existe.");
}

Console.WriteLine();
Console.WriteLine("Presiona ENTER para salir...");
Console.ReadLine();
