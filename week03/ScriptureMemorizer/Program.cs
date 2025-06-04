using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("2 Nephi", 2, 25);
        Scripture scripture = new Scripture(reference, "Adam fell that men might be; and men are, that they might have joy.");
        Word word = new Word("example");
    }
}