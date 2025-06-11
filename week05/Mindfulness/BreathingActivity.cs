public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description, 0) { }

    public void Run()
    {
        DisplayStartingMessage();

        int breatheInTime = 4;
        int breatheOutTime = 6;

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(breatheInTime);

            if (DateTime.Now >= endTime) break;

            Console.WriteLine("Breathe out...");
            Countdown(breatheOutTime);
        }

        DisplayEndingMessage();
    }
}