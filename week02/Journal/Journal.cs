public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    public void DisplayEntry()
    {
        Console.WriteLine("My Journal Entries:");
        foreach (Entry entry in _journal)
        {
            entry.DisplayEntry();
        }
    }
}