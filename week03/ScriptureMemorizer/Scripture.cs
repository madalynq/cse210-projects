using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numbertoHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numbertoHide)
        {
            int index = rand.Next(_words.Count);


            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
            if (IsCompletelyHidden()) break;
        }
    }

    public string GetDisplayText()
    {
        string verseText = "";
        foreach (var word in _words)
        {
            verseText += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + " " + verseText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.isHidden())
                return false;
        }
        return true;
    }
}