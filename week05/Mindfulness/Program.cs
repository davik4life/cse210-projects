using System;
// EXCEEDING REQUIREMENTS:
// To exceed the core requirements, I implemented a non-repeating
// random selection system in the Reflecting Activity. Prompts and
// reflection questions are removed from their available pools after
// being selected, preventing them from repeating until every item in
// that pool has been used. Once all items have been used, the pool
// resets. The pools are also reset at the beginning of each new
// Reflecting Activity session.
class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1-4.");
                Thread.Sleep(1500);
            }
        }
    }
}