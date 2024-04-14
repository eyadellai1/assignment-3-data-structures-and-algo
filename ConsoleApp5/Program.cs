using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Please enter the text: ");
        string text = Console.ReadLine();

        text = text.ToLower();
        string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }

        var mostUsedWords = wordCounts.OrderByDescending(kv => kv.Value).Take(10);
        var leastUsedWords = wordCounts.OrderBy(kv => kv.Value).Take(10);

        Console.WriteLine("\n10 Most Used Words:");
        foreach (var pair in mostUsedWords)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} times");
        }

        Console.WriteLine("\n10 Least Used Words:");
        foreach (var pair in leastUsedWords)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} times");
        }
    }
}
