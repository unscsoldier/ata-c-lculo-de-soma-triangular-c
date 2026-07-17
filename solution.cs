using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int soma = 0;
        int somaTotal = 0;

        for (int i = 1; i <= num; i++)
        {
            soma += i;
            somaTotal += soma;
        }

        Console.WriteLine(somaTotal);
    }
}