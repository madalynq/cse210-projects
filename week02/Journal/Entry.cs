public class Entry
{
    public string _date;
    public string _entry;
    // exceeding requirements: added dinner
    public string _dinner;


    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Dinner that day: {_dinner}");
        Console.WriteLine($"Journal Entry: {_entry}\n");
    }
}