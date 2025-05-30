class ListingActivity : MindfulnessActivity
{
    private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void RunActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        Console.WriteLine("Start listing items (press Enter after each):");

        List<string> entries = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < end)
        {
            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entry))
                {
                    entries.Add(entry);
                }
            }
        }

        Console.WriteLine($"You listed {entries.Count} items!");
    }
}
