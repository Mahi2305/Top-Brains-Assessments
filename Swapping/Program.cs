using System;

class Program
{
    // Method 1:Swap using ref
    static void SwapRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    // Method 2:Swap using out
    static void SwapOut(int a, int b, out int x, out int y)
    {
        x = a + b;
        y = x - b;
        x = x - y;
    }

    static void Main()
    {
        Console.Write("Enter first number for ref swap: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number for ref swap: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Swap (ref): n1 = " + n1 + ", n2 = " + n2);
        SwapRef(ref n1, ref n2);
        Console.WriteLine("After Swap (ref): n1 = " + n1 + ", n2 = " + n2);

        Console.Write("\nEnter first number for out swap: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number for out swap: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Swap (out): a = " + a + ", b = " + b);
        SwapOut(a, b, out int x, out int y);
        Console.WriteLine("After Swap (out): a = " + x + ", b = " + y);
    }
}
