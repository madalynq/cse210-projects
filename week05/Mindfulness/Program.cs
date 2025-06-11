using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var breathing = new BreathingActivity(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly."
        );

        var reflecting = new ReflectingActivity(
            "Reflection Activity",
            "This activity will help you reflect on times when you showed strength.",
            new List<string> {
                "Think of a time when you helped someone in need.",
                "Think of a time when you stood up for someone else."
            },
            new List<string> {
                "Why was this experience meaningful to you?",
                "How did you feel when it was complete?",
                "What did you learn from it?"
            }
        );

        var listing = new ListingActivity(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by listing them.",
            new List<string> {
                "Who are people that you appreciate?",
                "What are your personal strengths?"
            }
        );
    
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": breathing.Run(); break;
                case "2": reflecting.Run(); break;
                case "3": listing.Run(); break;
                case "4": running = false; break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
}