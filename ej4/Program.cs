using System;

class Program
{
    static void CalcularIVAyTotal(int cantidad, double precioUnitario)
    {
        double subtotal = cantidad * precioUnitario;
        double iva = subtotal * 0.15;
        double total = subtotal + iva;
        Console.WriteLine($"Cantidad de articulos: {cantidad}");
        Console.WriteLine($"Precio unitario: {precioUnitario}");
        Console.WriteLine($"El subtotal es: {subtotal}");
        Console.WriteLine($"El IVA es: {iva}");
        Console.WriteLine($"El total a pagar es: {total}");
    }
    
    static void Main()
    {
        Console.WriteLine("Ingrese el total de articulos: ");
        int cantidad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio unitario del articulo: ");
        double precioUnitario = Convert.ToDouble(Console.ReadLine());
        CalcularIVAyTotal(cantidad, precioUnitario);
    }
}
