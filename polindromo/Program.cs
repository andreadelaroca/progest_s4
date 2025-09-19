using System;

class Program
{
    //funcion que vlalida si una palabra es palindromo
    static bool EsPalindromo(string palabra)
    {
        //eliminar caracteres no alfanumericos y convertir a minusculas
        var palabraLimpia = new string(palabra.Where(c => char.IsLetter(c)).ToArray()).ToLower();

        //Invertir la palabra limpia
        char[] caracteres = palabraLimpia.ToCharArray();
        Array.Reverse(caracteres);
        string palabraInvertida = new string(caracteres);

        //comparar la palabra limpia con la invertida
        return palabraLimpia == palabraInvertida;
    }

    static void Main()
    {
        Console.Write("Ingrese una palabra o frase: ");
        string palabra = Console.ReadLine();

        if (EsPalindromo(palabra))
        {
            Console.WriteLine($"\"{palabra}\" es un palindromo.");
        }
        else
        {
            Console.WriteLine($"\"{palabra}\" no es un palindromo.");
        }
    }
}
