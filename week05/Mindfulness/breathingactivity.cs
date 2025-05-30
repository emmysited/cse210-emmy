class BreathingActivity : MindfulnessActivity
{
    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void RunActivity()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            elapsed += 4;
            if (elapsed >= Duration) break;

            Console.Write("Breathe out... ");
            Countdown(4);
            elapsed += 4;
        }
    }
}
