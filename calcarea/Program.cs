internal class Program
{
    static double AreaRect(double x, double y)
    {
        double area = x * y;
        return area;
    }
    static double AreaCirc(double x)
    {
        double area = Math.PI * (x * x);
        return area;
    }

    static double AreaTrap(double x, double y, double z)
    {
        double area = ((x + y) * z) / 2;
        return area;
    }
    private static void Main(string[] args)
    {
        bool ejecutando = true;
        while (ejecutando)
        {
            MenuPrincipal();
            switch (SeleccionarOpcion())
            {
                case 1:
                    MenuCirculo();
                    break;
                case 2:
                    MenuTrap();
                    break;
                case 3:
                    MenuRectangulo();
                    break;
                case 4:
                    ejecutando = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }

    private static int SeleccionarOpcion()
    {
        Console.Write("Ingrese una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    private static void MenuPrincipal()
    {
        Console.WriteLine("Calculadora geométrica");
        Console.WriteLine("1. Área de un círculo");
        Console.WriteLine("2. Área de un trapecio");
        Console.WriteLine("3. Área de un rectángulo");
        Console.WriteLine("4. Salir");
    }

    private static void MenuCirculo()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"El área del círculo es: {AreaCirc(radio)}");
    }

    private static void MenuRectangulo()
    {
        Console.Write("Ingrese la base del rectángulo: ");
        double baseR = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del rectángulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"El área del rectángulo es: {AreaRect(baseR, altura)}");
    }

    private static void MenuTrap()
    {
        Console.Write("Ingrese la base mayor del rectángulo: ");
        double baseMy = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la base menor del rectángulo: ");
        double baseMn = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del rectángulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"El área del rectángulo es: {AreaTrap(baseMy, baseMn, altura)}");
    }
}