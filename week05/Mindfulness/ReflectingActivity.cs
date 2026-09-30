using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Working lists used to prevent repetition.
    private List<string> _unusedPrompts;
    private List<string> _unusedQuestions;

    private Random _random;

    public ReflectingActivity()
        : base(
            "Reflecting",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        )
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _unusedPrompts = new List<string>(_prompts);
        _unusedQuestions = new List<string>(_questions);

        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        // If every prompt has been used, refill the pool.
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        int index = _random.Next(_unusedPrompts.Count);

        string prompt = _unusedPrompts[index];

        // Remove the selected prompt so it cannot repeat.
        _unusedPrompts.RemoveAt(index);

        return prompt;
    }

    public string GetRandomQuestion()
    {
        // If every question has been used, refill the pool.
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        int index = _random.Next(_unusedQuestions.Count);

        string question = _unusedQuestions[index];

        // Remove the selected question so it cannot repeat.
        _unusedQuestions.RemoveAt(index);

        return question;
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Start each session with fresh pools.
        _unusedPrompts = new List<string>(_prompts);
        _unusedQuestions = new List<string>(_questions);

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.WriteLine($" --- {GetRandomPrompt()} ---");

        Console.WriteLine();
        Console.WriteLine(
            "When you have something in mind, press enter to continue."
        );

        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(
            "Now ponder on each of the following questions as they relate to this experience."
        );

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");

            ShowSpinner(5);

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}