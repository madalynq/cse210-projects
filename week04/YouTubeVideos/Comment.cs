public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string text)
    {
        _name = name;
        _comment = text;
    }

    public void Display()
    {
        Console.WriteLine($"- {_name}: {_comment}");
    }
}