class ReflectionActivity : MindfulnessActivity
{
    private static readonly string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] questions = {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What could you learn from this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override string GetDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public override void RunActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < Duration)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine("> " + question);
            ShowSpinner(5);
            elapsed += 5;
        }
    }
}
