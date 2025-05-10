using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMsg();
        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int squared = SquaredNumber(favNum);

        DisplayResult(userName, squared);
    } 
        
    static void DisplayWelcomeMsg()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber() 
    {
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquaredNumber(int favNum)
    {
        int square = favNum * favNum;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}