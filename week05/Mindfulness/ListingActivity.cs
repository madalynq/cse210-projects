public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;
    private Random _rand = new Random();

    public ListingActivity(string name, string description, List<string> prompts)
        : base(name, description, 0)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("You may begin listing in: ");
        Countdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }
}