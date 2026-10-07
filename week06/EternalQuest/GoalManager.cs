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
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;

                    case 2:
                        ListGoalDetails();
                        break;

                    case 3:
                        SaveGoals();
                        break;

                    case 4:
                        LoadGoals();
                        break;

                    case 5:
                        RecordEvent();
                        break;

                    case 6:
                        Console.WriteLine("Keep working on your Eternal Quest!");
                        break;

                    default:
                        Console.WriteLine("Please choose an option from 1 to 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine()!);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine()!;

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine()!;

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine()!);

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write(
                "How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine()!);

            Console.Write(
                "What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine()!);

            _goals.Add(
                new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("Goal created successfully!");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("You haven't created any goals yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You need to create a goal first.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()!);

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid goal.");
            return;
        }

        Goal goal = _goals[choice - 1];

        int earnedPoints = goal.RecordEvent();

        _score += earnedPoints;

        Console.WriteLine(
            $"Congratulations! You have earned {earnedPoints} points!");

        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine()!;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine()!;

        if (!File.Exists(filename))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);

                _goals.Add(
                    new SimpleGoal(
                        name,
                        description,
                        points,
                        isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(
                    new EternalGoal(
                        name,
                        description,
                        points));
            }
            else if (goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                _goals.Add(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus,
                        amountCompleted));
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}