using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference _reference;
    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (var word in splitWords)
        {
            _words.Add(new Word(word));
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
        return false;
    }
}