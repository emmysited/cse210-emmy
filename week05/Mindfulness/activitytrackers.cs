class ActivityTracker
{
    private Dictionary<string, int> log = new Dictionary<string, int>();

    public void LogActivity(string activity, int duration)
    {
        if (!log.ContainsKey(activity))
            log[activity] = 0;
        log[activity] += duration;
    }

    public void DisplayLog()
    {
        Console.WriteLine("\n--- Activity Log ---");
        foreach (var item in log)
        {
            Console.WriteLine($"{item.Key}: {item.Value} seconds");
        }
    }
}
