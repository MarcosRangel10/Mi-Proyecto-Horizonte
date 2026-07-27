//Programa que imprime los números del 10 al 1 utilizando un bucle while
int numero = 10;
// while (numero >=1)
{
    Console.WriteLine(numero);
}

//Programa que imprime un saludo personalizado un número determinado de veces utilizando un bucle while
Console.WriteLine("¿Cual es tu nombre?");
string nombre = Console.ReadLine();
Console.WriteLine("¿Cuantas veces quieres que te salude?");
int repeticiones = Convert.ToInt32(Console.ReadLine());

while (repeticiones > 0)
{
    Console.WriteLine("Hola" + nombre);
    repeticiones--;
}


//Programa que imprime la tabla de multiplicar de un número determinado utilizando un bucle while
Console.WriteLine("¿Que tabla quieres ver?");
int tabla = Convert.ToInt32(Console.ReadLine());
int contador = 1;
 while(contador <=10)
{
    int resultado = tabla * contador;
    Console.WriteLine(tabla + " x " + contador + " = " + resultado);
    contador++;
}