using System;

public class Fibonacci
{
    /* En palabras simples, la sucesión de Fibonacci comienza con 0 y 1, 
y los siguientes términos siempre son la suma de los dos anteriores.
En la siguiente tabla, podemos ver los números de Fibonacci desde el 
0-ésimo hasta el duodécimo. */

    public static void Tabla()
    {
        Console.WriteLine("Tabla deste el 0-esimo hasta el duodecimo");
        for (int i = 0; i <= 12; i++)
        {
            Console.Write($"{CalcularFibonacci(i)}");
        }
        Console.WriteLine();
    }

    public static long CalcularFibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long temp =a;
            a=b;
            b=temp+b;

        }
        return b;
    }

    /* Escriba un programa que reciba como entrada un número 
        entero e indique si es o no un númerode Fibonacci */
    static bool CuadradoPerfecto(int n){
        int raiz=(int)Math.Sqrt(n);
        return raiz*raiz==n;
    }

    static bool NumeroFibonacci(int numero){
        return CuadradoPerfecto(5*numero*numero+4)||CuadradoPerfecto(5*numero*numero-4);
    }
    public static void NumeroEnteroysiesfibonacci(){
        Console.Write("Ingrese un numero entero: ");
        if (int.TryParse(Console.ReadLine(),out int numero)){
            if(NumeroFibonacci(numero)){
                Console.WriteLine($"{numero} es un numero Fibonacci");
            }
            else{
                Console.WriteLine($"{numero} NO es un numero Fibonacci");
            }
        }
        else{
            Console.WriteLine("Por favor, ingrese un numero entero");
        }
    }

/* Escriba un programa que reciba como entrada un número entero 
n, y entregue como salida el n-ésimo número de Fibonacci */
    public static void ValorN (){
        Console.Write("Ingrese el valor de n:");
        if(int.TryParse(Console.ReadLine(),out int n)&&n>=0){
            long resultado=Fibonacci.CalcularFibonacci(n);
            Console.WriteLine($"El{n}-esimo numero de Fibonacci es:{resultado}");
        }
        else{
            Console.WriteLine("Por favor, ingrese un numero entero no negativo. ");
        }
    }

/* Escriba un programa que muestres los m primeros números de 
Fibonacci, donde m es un número
ingresado por el usuario: */
    public static void NumerosM ()
    {
        Console.Write("Ingrese la cantidad de números de Fibonacci que desea mostrar: ");
        
        if (int.TryParse(Console.ReadLine(), out int m) && m > 0)
        {
            MostrarPrimerosNFibonacci(m);
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo.");
        }
    }

    static void MostrarPrimerosNFibonacci(int m)
    {
        Console.WriteLine($"Los primeros {m} números de Fibonacci son:");

        for (int i = 0; i < m; i++)
        {
            Console.Write($"{CalcularFibonacci(i)} ");
        }
        Console.WriteLine();
    }
    
}