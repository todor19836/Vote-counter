using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();
       
        while (true)
        {
            Console.Write("Глас за: ");
            string vote = Console.ReadLine().Trim();

            if (vote.ToLower() == "exit")
                break;

            if (votes.ContainsKey(vote))
                votes[vote]++;
            else
                votes[vote] = 1;
        }

        Console.WriteLine("\nРезултати от гласуването:");
        string winner = "";
        int maxVotes = 0;

        foreach (var entry in votes)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} гласа");
            if (entry.Value > maxVotes)
            {
                maxVotes = entry.Value;
                winner = entry.Key;
            }
        }

        Console.WriteLine($"\nПобедител: {winner} с {maxVotes} гласа!");
    }
}
