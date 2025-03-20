using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Списък с кандидати
        List<string> candidates = new List<string> { "Гошо", "Мартин", "Иван" };

        // Словар за гласовете
        Dictionary<string, int> votes = new Dictionary<string, int>();

        // Инициализиране на гласовете на всички кандидати с нула
        foreach (var candidate in candidates)
        {
            votes[candidate] = 0;
        }

        while (true)
        {
            // Показване на възможните кандидати
            Console.WriteLine("\nИзберете кандидат за гласуване:");
            for (int i = 0; i < candidates.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {candidates[i]}");
            }

            Console.WriteLine("Въведете номер на кандидат или 'exit' за край:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "exit")
                break;

            // Проверка дали въведеното е валиден номер на кандидат
            if (int.TryParse(input, out int voteChoice) && voteChoice >= 1 && voteChoice <= candidates.Count)
            {
                string selectedCandidate = candidates[voteChoice - 1];
                votes[selectedCandidate]++;
                Console.WriteLine($"Гласувахте за {selectedCandidate}.");
            }
            else
            {
                Console.WriteLine("Невалиден избор. Моля, изберете валиден номер.");
            }
        }

        // Показване на резултатите
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
