using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        
        Console.WriteLine($"My name is {last}, {first} {last}.");
    }
    
}