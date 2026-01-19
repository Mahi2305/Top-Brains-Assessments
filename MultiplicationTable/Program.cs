using System;

class Program
{
    static int[] GetMultiplicationRow(int n, int upto)
    {
        int[] row = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        return row;
    }

    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter upto: ");
        int upto = int.Parse(Console.ReadLine());

        int[] result = GetMultiplicationRow(n, upto);

        Console.WriteLine("\nMultiplication Row:");
        foreach (int x in result)
        {
            Console.Write(x + " ");
        }
    }
}

