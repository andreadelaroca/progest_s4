using System;

class Program
{
     static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 3: Determinar si el numero es par o impar.");
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (EsPar(numero))
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}