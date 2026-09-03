using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        // Create a list to store the numbers entered by the user
        // Repeatedly prompt the user to enter a number until they enter 0.
        // After the user enters 0, display the sum, average, and total number of entries (excluding the 0) to the console.
        // Use a do-while loop to implement this functionality.

        /*
            Stretch Challenge
            Have the user enter both positive and negative numbers, then find the smallest positive number (the positive number that is closest to zero).

            Sort the numbers in the list and display the new, sorted list. Hint: There are C# libraries that can help you here, try searching the internet for them.
        */
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter a Number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"The sum is: {numbers.Sum()}");
                Console.WriteLine($"The average is: {(float)numbers.Sum() / numbers.Count()}");
                Console.WriteLine($"The largest number is: {numbers.Max()}");
                Console.WriteLine($"The smallest positive number is: {numbers.Where(n => n > 0).Min()}");
                numbers.Sort();
                Console.WriteLine($"The sorted list is: [{string.Join(", ", numbers)}]");
                break;
            }
        } while (true);
    }
}