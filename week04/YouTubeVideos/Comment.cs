public class Comment
{
    public string _name;
    public string _comment;

    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_comment}");
    }
}