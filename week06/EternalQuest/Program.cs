// EXCEEDING REQUIREMENTS:
// 1. Added Leveling System - User levels up every 1000 points.
// 2. Added Negative Goals - Lose points for bad habits.
// 3. Added colorful console output to encourage engagement.

using System;

class Program
{
    static void Main(string[] args)
    {
         int score = 0;
        int level = 1;
        string input = "";

        List<string> positiveGoals = new List<string> { "Exercise", "Read Scriptures", "Help Someone" };
        List<string> negativeGoals = new List<string> { "Procrastinate", "Skip Prayer", "Overuse Social Media" };

        Console.WriteLine("Welcome to EternalQuest!");
        Console.WriteLine("Type 'exit' to quit.");

        while (true)
        {
            Console.WriteLine("\nChoose a goal to complete:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Positive Goals:");
            Console.ResetColor();

            for (int i = 0; i < positiveGoals.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {positiveGoals[i]} (+500 pts)");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Negative Goals:");
            Console.ResetColor();

            for (int i = 0; i < negativeGoals.Count; i++)
            {
                Console.WriteLine($"  N{i + 1}. {negativeGoals[i]} (-300 pts)");
            }

            Console.Write("\nEnter your choice (e.g., 1 or N2): ");
            input = Console.ReadLine().ToLower();

            if (input == "exit")
                break;

            if (int.TryParse(input, out int choice))
            {
                if (choice >= 1 && choice <= positiveGoals.Count)
                {
                    score += 500;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Well done! +500 points for completing '{positiveGoals[choice - 1]}'");
                    Console.ResetColor();
                }
            }
            else if (input.StartsWith("n") && int.TryParse(input.Substring(1), out int nChoice))
            {
                if (nChoice >= 1 && nChoice <= negativeGoals.Count)
                {
                    score -= 300;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Oops! -300 points for doing '{negativeGoals[nChoice - 1]}'");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            int newLevel = (score / 1000) + 1;
            if (newLevel > level)
            {
                level = newLevel;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"🎉 Level Up! You've reached Level {level}!");
                Console.ResetColor();
            }

            Console.WriteLine($"Current Score: {score}, Level: {level}");
        }

        Console.WriteLine("\nThanks for playing EternalQuest!");
    }
}