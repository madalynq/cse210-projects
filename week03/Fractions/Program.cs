using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        // Fraction test1 = new Fraction();
        // Console.WriteLine("test1 created with no paramaters.");

        // Fraction test2 = new Fraction(6);
        // test2.SetTop(6);
        // Console.WriteLine(test2.GetTop());
        // Console.WriteLine("test2 created with one parameter(6).");


        // Fraction test3 = new Fraction(6, 7);
        // test3.SetTop(6);
        // test3.SetBottom(7);
        // Console.WriteLine(test3.GetBottom());
        // Console.WriteLine("test3 created with two parmeters(6,7).");


        Fraction test1 = new Fraction();
        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());

        Fraction test2 = new Fraction(5);
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());

        Fraction test3 = new Fraction(3, 4);
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());

        Fraction test4 = new Fraction(1, 3);
        Console.WriteLine(test4.GetFractionString());
        Console.WriteLine(test4.GetDecimalValue());


    
    }
}