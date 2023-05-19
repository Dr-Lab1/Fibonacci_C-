using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entrez un nombre entier positif : ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 0;

        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine("Le nombre de Fibonacci pour n={0} est {1}", n, b);
    }
}