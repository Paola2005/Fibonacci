bool bandera = true;

while (bandera)
{
    Console.Clear();
    Console.WriteLine("||||||||||||||Ejercicios Fibonacci||||||||||||||");
    Console.WriteLine("1. Mostrar sucesion Fibonacci");
    Console.WriteLine("2. Numero Entero n");
    Console.WriteLine("3. Numero entero y saber si es Fibonacci");
    Console.WriteLine("4. Muestre los m primeros números de Fibonacci");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elija una opcion:");
    byte opcion = Convert.ToByte(Console.ReadLine());

    if (opcion == 1)
    {
        Fibonacci.Tabla();
    }
    else if (opcion == 2)
    {
        Fibonacci.ValorN();
    }
    else if (opcion == 3)
    {
        Fibonacci.NumeroEnteroysiesfibonacci();
    }
    else if (opcion == 4)
    {
        Fibonacci.NumerosM();
    }
    else if (opcion == 5)
    {
        bandera = false;
    }
    else
    {
        Console.WriteLine("Opción no válida. Por favor, elija nuevamente.");
    }

    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
}