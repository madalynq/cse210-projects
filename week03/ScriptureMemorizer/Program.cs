using System;
using System.Text.Json;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scripture scripture = LoadRandomScripture("scriptures.json");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nAll words hidden or user quit. Thank you! Goodbye!");
    }
    
    static Scripture LoadRandomScripture(string filePath)
    {
        string json = File.ReadAllText(filePath);
        var scriptureList = JsonSerializer.Deserialize<List<ScriptureData>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Random rand = new Random();
        var randomScripture = scriptureList[rand.Next(scriptureList.Count)];

        var reference = new Reference(
            randomScripture.Book,
            randomScripture.Chapter,
            randomScripture.Verse,
            randomScripture.EndVerse
        );

        return new Scripture(reference, randomScripture.Text);
    }
}