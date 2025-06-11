public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _rand = new Random();

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions)
        : base(name, description, 0)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow reflect on the following questions:");
        Spinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[_rand.Next(_questions.Count)];
            Console.WriteLine($"\n> {question}");
            Spinner(5);
        }

        DisplayEndingMessage();
    }
}