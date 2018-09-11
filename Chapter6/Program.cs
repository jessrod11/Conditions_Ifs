using System;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Condition Statements and If Statements

            string userName;
            int userAge;

            Console.WriteLine("Hello, User! What is your name?!");
            userName = Console.ReadLine();

            Console.WriteLine("Nice to meet you, {0}! How old are you?", userName);
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 0 || userAge > 100) // if user is under 0 and over 100 then this code will run.
            {
                Console.WriteLine("Uh-oh, {0}! One of three things are true here! You are a baby genius, you're way older than you look, or you entered the wrong age. Click enter to try again!", userName);
                Console.WriteLine("Age must be between 0 and 100");
                Console.ReadLine();
            }
            else if (userAge < 18) // if user is under 18 then this code will run.
            {
                Console.WriteLine("Sorry! You're under age!");
                Console.ReadLine();
            }

            else if (userAge < 21) // if user is under 21 then this code will run.
            {
                Console.WriteLine("You're legal, but not legal enough! Sorry, {0}!", userName);
                Console.ReadLine();
            }

            else // if user is over 21 then this code will run.
            {
                Console.WriteLine("Congratulations, {0}!", userName);
                Console.WriteLine("You can come to the party!");
                Console.ReadLine();
            }

        }
    }
}
