using System;

class Program
{
    static void Main(string[] args)
    {
        // Load scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        // Intro
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!\n");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplay());
            Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.AllWordsHidden())
            {
                scripture.HideRandomWords();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplay());
                Console.WriteLine("\nAll words are now hidden. Press ENTER to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}
