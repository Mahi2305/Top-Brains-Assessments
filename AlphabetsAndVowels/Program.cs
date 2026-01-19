using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first word :");
        string firstWord = Console.ReadLine();

        Console.WriteLine("Enter second word :");
        string secondWord = Console.ReadLine();

        string vowels = "aeiou";
        string word1 = firstWord.ToLower();
        string word2 = secondWord.ToLower();

        string afterTask1 = "";
        foreach (char c in word1)
        {
            if (vowels.Contains(c))
            {
                afterTask1 += firstWord[word1.IndexOf(c)];
            }
            else
            {
                if (!word2.Contains(c))
                    afterTask1 += firstWord[word1.IndexOf(c)];
            }
        }

        string result = "";
        for (int i = 0; i < afterTask1.Length; i++)
        {
            if (i == 0 || afterTask1[i] != afterTask1[i - 1])
                result += afterTask1[i];
        }

        Console.WriteLine(result);
    }
}
