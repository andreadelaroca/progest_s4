internal class Program
{
    static void Intercambiar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    private static void Main(string[] args)
    {
        Console.Write("Ingrese 'a': ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese 'b': ");
        int b = Convert.ToInt32(Console.ReadLine());

        Intercambiar(ref a, ref b);
        Console.WriteLine($"El valor de a es {a} y el valor de b es {b}");
    }
}