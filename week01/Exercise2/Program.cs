using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = " ";
        string sign = " ";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        
        }
        else if (grade >= 60)
        {
            letter = "D";
        
        }
        else
        {
            letter = "F";
        
        }
        int lastDigit = grade % 10;
        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        if (letter == "A" && grade >= 93)
        {
            sign = " ";
        }
        Console.WriteLine($"{letter}{sign}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}