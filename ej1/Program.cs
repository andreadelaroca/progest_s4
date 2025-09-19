// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // Declaración de variables
        double baseT = 0, altura = 0;

        // Bucle do para pedirle al usuario que introduzca la base
        do
        {
            Console.Write("Introduzca la base del tríangulo: ");
            baseT = Convert.ToDouble(Console.ReadLine());

            // Comprobación para que la base no sea negativa ni cero
            if (baseT <= 0)
            {
                Console.WriteLine("Error: la base no puede ser negativa");
            }
            // Si la base es mayor a cero, sale del bucle
            else break;
        } while (true);

        // Lo mismo que el bloque anterior, pero para la altura
        do
        {
            Console.Write("Introduzca la altura del tríangulo: ");
            altura = Convert.ToDouble(Console.ReadLine());
            if (altura <= 0)
            {
                Console.WriteLine("Error: la altura no puede ser negativa");
            }
            else break;
        } while (true);

        Console.WriteLine($"El área del triángulo es de: {CalcularAreaTriangulo(baseT, altura)}");
    }

    // Función encargada de calcular el área del triángulo
    static double CalcularAreaTriangulo(double baseT, double altura)
    {
        // Simplemente retorna la fórmula del área de un triágulo (base por altura entre dos)
        return (baseT * altura) / 2;
    }
}