abstract class MindfulnessActivity
{
    public int Duration { get; protected set; }

    public void StartActivity()
    {
        ShowStartingMessage();
        RunActivity();
        ShowEndingMessage();
    }

    protected virtual void ShowStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting the {GetType().Name}.");
        Console.WriteLine(GetDescription());
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    protected virtual void ShowEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You completed the {GetType().Name} for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            foreach (char c in "|/-\\")
            {
                Console.Write(c);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void RunActivity();
    protected abstract string GetDescription();
}
