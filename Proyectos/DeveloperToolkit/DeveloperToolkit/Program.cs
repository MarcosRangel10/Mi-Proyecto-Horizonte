//Programa de consola que permite al usuario elegir entre varias opciones, como saludar, mostrar la tabla de multiplicar o contar del 10 al 1.
bool salir = false;
while (salir == false)
{
    Console.WriteLine("====================================");
    Console.WriteLine("         DEVELOPER TOOLKIT          ");
    Console.WriteLine("====================================");
    Console.WriteLine();
    Console.WriteLine("1. Saludar");
    Console.WriteLine("2. Tabla de multiplicar");
    Console.WriteLine("3. Contador del 10 al 1");
    Console.WriteLine("4. Salir");
    Console.WriteLine();

    Console.Write("Selecciona una opción: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    if (opcion == 1)
    {
        Console.Write("¿Cuál es tu nombre? ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Hola " + nombre + ".\n");
    }
    else if (opcion == 2)
    {
        Console.WriteLine("¿Que tabla quieres ver?");
        int tabla = Convert.ToInt32(Console.ReadLine());
        int contador = 1;
        while (contador <= 10)
        {
            int resultado = tabla * contador;
            Console.WriteLine(tabla + " x " + contador + " = " + resultado);
            contador++;
        }
        Console.WriteLine();

    }
    else if (opcion == 3)
    {
        int numero = 10;
        while (numero >= 1)
        {
            Console.WriteLine(numero);
            numero--;
        }
        Console.WriteLine();
    }
    else if (opcion == 4)
    {
        salir = true;
    }
    else
    {
        Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
    }

}













