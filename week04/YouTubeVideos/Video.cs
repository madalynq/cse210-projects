public class Video
{
    public string _title;
    public string _author;
    public int _length;


    public List<Comment> _video = new List<Comment>();

    public void DisplayComment()
    {
        Console.WriteLine("Comments:");
        foreach (Comment comment in _video)
        {
            comment.DisplayComment();
        }
    }
}