using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running run = new Running("03 Nov 2022", 30, 3.0);
        Cycling bike = new Cycling("03 Nov 2022", 30, 12.0);
        Swimming swim = new Swimming("03 Nov 2022", 30, 40);


        List<Activity> activities = new List<Activity> { run, bike, swim };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}