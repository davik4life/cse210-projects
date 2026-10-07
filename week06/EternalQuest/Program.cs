using System;

/*
EXCEEDING REQUIREMENTS:

I added input validation to the main menu so that invalid menu input
does not immediately crash the program.

I also prevent completed Simple Goals and Checklist Goals from awarding
additional points after they have already been completed.

The program displays encouraging messages when goals are created,
recorded, saved, and loaded.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        manager.Start();
    }
}