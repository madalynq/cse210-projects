using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What is something kind you did for someone today?",
        "What did you learn about yourself today?",
        "When did you feel peace today?",
        "What’s something small that brought you joy today?",
        "Did you notice someone else showing kindness today?",
        "What was one moment you felt proud of today?",
        "When did you feel closest to God or the Spirit today?",
        "What’s one thing you’re looking forward to tomorrow?",
        "How did you show love to someone today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
