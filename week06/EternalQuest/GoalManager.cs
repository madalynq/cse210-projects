using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save/Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;

                case "2":
                    ListGoalNames();
                    break;

                case "3":
                    CreateGoal();
                    break;

                case "4":
                    RecordEvent();
                    break;

                case "5":
                    HandleSaveLoad();
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The tpyes of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;

            default:
                Console.WriteLine("Invalid Choice.");
                break;

        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points! Total score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }
    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;

            string[] parts = lines[i].Split(':');
            if (parts.Length < 2)
            {
                Console.WriteLine($"Skipping invalid line: {lines[i]}");
                continue; // Prevent IndexOutOfRangeException
            }

            string type = parts[0];
            string[] data = parts[1].Split('|');

            switch (type)
            {
                case "SimpleGoal":
                    SimpleGoal sg = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                    if (data.Length > 3 && bool.TryParse(data[3], out bool isComplete))
                    {
                        // set _isComplete using reflection since it's private
                        typeof(SimpleGoal).GetField("_isComplete", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                            ?.SetValue(sg, isComplete);
                    }
                    _goals.Add(sg);
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;

                case "ChecklistGoal":
                    ChecklistGoal cg = new ChecklistGoal(data[0], data[1], int.Parse(data[2]),
                                                        int.Parse(data[3]), 0);
                    
                    if (data.Length > 4)
                    {
                        typeof(ChecklistGoal).GetField("_amountCompleted", BindingFlags.NonPublic | BindingFlags.Instance)
                            ?.SetValue(cg, int.Parse(data[4]));
                    }
                    _goals.Add(cg);
                    break;

                default:
                    Console.WriteLine($"Unknown goal type: {type}");
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
    
    private void HandleSaveLoad()
    {
        Console.WriteLine("1. Save Goals");
        Console.WriteLine("2. Load Goals");
        Console.Write("Choose an option: ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            SaveGoals();
        }
        else if (option == "2")
        {
            LoadGoals();
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
}