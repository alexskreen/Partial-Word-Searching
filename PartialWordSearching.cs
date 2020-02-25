using System;
using System.Collections.Generic;

public class PartialWordSearching
{
    public static void Main()
    {

        string[] words = { "spicy", "jalapeno", "bacon", "ipsum", "dolor", "amet", "rump", "burgdoggen", "shank", "biltong", "pork", "jerk", "Chicken", "buffalo", "ribeye", "ball", "tip", "Pastrami", "jowl", "filet" };


        List<string> partialMatches = new List<string> {};
        GatherUserWord();

    void GatherUserWord()
    {
        Console.WriteLine("Please enter a word to search our database: ");
        string UserWord = Console.ReadLine().ToLower();
        foreach (string word in words)
        {
            if (word.Contains(UserWord))
            {
                partialMatches.Add(word);
            }

        }
        if (partialMatches.Count == 0)
        {
            partialMatches.Add("Empty");
        }
        foreach (string match in partialMatches)
            Console.WriteLine(match);
    }
    }
}