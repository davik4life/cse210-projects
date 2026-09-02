using System;

class Program
{
    static void Main(string[] args)
    {
        /* 
            Write a program that determines the letter grade for a course according to the following scale:

            A >= 90
            B >= 80
            C >= 70
            D >= 60
            F < 60

        */
        Console.Write("What is your percentage grade? ");
        string studentGrade = Console.ReadLine();
        int grade = int.Parse(studentGrade);
        string exceptional = "A";
        string aMinus = "A-";
        string bPlus = "B+";
        string b = "B";
        string bMinus = "B-";
        string cPlus = "C+";
        string c = "C";
        string cMinus = "C-";
        string dPlus = "D";
        string d = "D";
        string dMinus = "D-";
        string f = "F";
        bool passed = grade >= 70;

        if (grade >= 90)
            {
                if (grade % 10 >= 3)
                    {
                        Console.WriteLine($"Congratulations! Your letter grade is {exceptional}.");
                    }
                else if (grade % 10 < 3)
                    {
                        Console.WriteLine($"Great Job! Your letter grade is {aMinus}.");
                    }
            }
        else if (grade >= 80)
            {
                if (grade % 10 >= 7)
                    {
                        Console.WriteLine($"Good Job! Your letter grade is {bPlus}.");
                    }
                else if (grade % 10 < 3)
                    {
                        Console.WriteLine($"Well Done! Your letter grade is {bMinus}.");
                    }
                else
                    {
                        Console.WriteLine($"Your letter grade is {b}.");
                    }
            }
        else if (grade >= 70)
            {
                if (grade % 10 >= 7)
                    {
                        Console.WriteLine($"Your letter grade is {cPlus}.");
                    }
                else if (grade % 10 < 3)
                    {
                        Console.WriteLine($"Your letter grade is {cMinus}.");
                    }
                else
                    {
                        Console.WriteLine($"Your letter grade is {c}");
                    }
            }
        else if (grade >= 60)
            {
                if (grade % 10 >= 7)
                    {
                        Console.WriteLine($"Your letter grade is {dPlus}.");
                    }
                else if (grade % 10 < 3)
                    {
                        Console.WriteLine($"Your letter grade is {dMinus}.");
                    }
                else
                    {
                        Console.WriteLine($"Your letter grade is {d}");

                    }
            }
        else
            {
                Console.WriteLine($"Your letter grade is {f}");
                Console.WriteLine($"You have earned an {f}");
            }

        if (passed)
            {
                Console.WriteLine("Congratulations! You have passed the course.");
            }
        else
            {
                Console.WriteLine("🥹 You have not passed the course. Better luck next time!");
            }
    }
}