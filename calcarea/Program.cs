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

    }
    }