public class Scripture
{
    public Reference _reference;
    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
    }

    public void HideRandomWords(int numbertoHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}