using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int myNumber = random.Next(1, 21);
            int attempt = 5;
            int yourNumber;
            string decision = "";         
            do
            {
                Console.WriteLine("Guess the number between 1 and 20");
                while (attempt > 0)
                {
                    bool parsedOrNot = int.TryParse(Console.ReadLine(), out yourNumber);
                    if (!parsedOrNot)
                    {
                        Console.WriteLine("Please, enter a integer number");
                    }
                    else if (myNumber == yourNumber)
                    {
                        Console.WriteLine("You Win!!!");
                        break;
                    }
                    else if (myNumber > yourNumber)
                    {
                        Console.WriteLine("My number is greather than that");
                        attempt--;
                    }
                    else if (myNumber < yourNumber)
                    {
                        Console.WriteLine("my number is less than that ");
                        attempt--;
                    }
                }
                if (attempt == 0)
                {
                    Console.WriteLine("you lose");
                }
                Console.WriteLine("do you want to play again? Yes/No");
                decision = Console.ReadLine();
                while (decision.ToLower() != "yes" && decision.ToLower() != "no")
                {
                    Console.WriteLine("please enter exactly \"yes\" or \"no\"");
                    decision = Console.ReadLine();
                }
                if (decision.ToLower() == "yes")
                    attempt = 5;
            } while (decision.ToLower()!="no");

            Console.WriteLine("thank you for playing");
                         
        }
    }
}
