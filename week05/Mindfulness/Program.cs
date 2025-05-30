// EXCEEDING REQUIREMENTS:
// - Activity log tracks total time spent in each activity.
// - Ensures all prompts/questions are randomized.
// - All code follows OOP principles using inheritance, encapsulation, and polymorphism.

using System;

class Program
{
    static void Main(string[] args)
    {
         ActivityTracker tracker = new ActivityTracker();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Show Activity Log");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            MindfulnessActivity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    tracker.DisplayLog();
                    PauseWithMessage("Press Enter to continue...");
                    continue;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    Thread.Sleep(1000);
                    continue;
            }

            activity.StartActivity();
            tracker.LogActivity(activity.GetType().Name, activity.Duration);
        }
    }

    static void PauseWithMessage(string message)
    {
        Console.WriteLine(message);
        Console.ReadLine();
    }
}