using System;
using System.Collections.Generic;

/*
CREATIVITY / EXCEEDING REQUIREMENTS:

In addition to the required journal features, I added a mood field.
Whenever the user writes a journal entry, the program asks the user
to describe their mood. The mood is stored with the journal entry,
displayed on the screen, and saved to and loaded from the file.

I also added an entry counter when displaying the journal so the user
can see how many journal entries they have written.
*/

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today?",
            "What am I grateful for today?",
            "What was the biggest challenge I faced today?"
        };

        Random random = new Random();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("\nPlease enter a number between 1 and 5.\n");
                continue;
            }

            if (choice == 1)
            {
                int promptIndex = random.Next(prompts.Count);
                string selectedPrompt = prompts[promptIndex];

                Console.WriteLine();
                Console.WriteLine(selectedPrompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Console.Write("How would you describe your mood today? ");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = selectedPrompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                journal.AddEntry(newEntry);

                Console.WriteLine("\nYour journal entry has been added.\n");
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                try
                {
                    journal.LoadFromFile(fileName);
                    Console.WriteLine("\nJournal loaded successfully.\n");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("\nThe file could not be found.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nThere was a problem loading the file: {ex.Message}\n");
                }
            }

            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                try
                {
                    journal.SaveToFile(fileName);
                    Console.WriteLine("\nJournal saved successfully.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nThere was a problem saving the file: {ex.Message}\n");
                }
            }

            else if (choice == 5)
            {
                Console.WriteLine("\nThank you for using the Journal Program!");
            }

            else
            {
                Console.WriteLine("\nPlease choose a number between 1 and 5.\n");
            }
        }
    }
}