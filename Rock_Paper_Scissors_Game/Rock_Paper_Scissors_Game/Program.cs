// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String PlayerChoice;
            String ComputerChoice;

            while (playAgain)
            {
                PlayerChoice = "";
                ComputerChoice = "";

                while (PlayerChoice != "ROCK" && PlayerChoice != "PAPER" && PlayerChoice != "SCISSORS")
                {

                    Console.Write("Enter ROCK ,PAPER or SCISSORS: ");
                    PlayerChoice = Console.ReadLine();
                    PlayerChoice = PlayerChoice.ToUpper();
                }
                //Console.WriteLine(PlayerChoice);

                switch (random.Next(1, 4))
                {
                    case 1:
                        ComputerChoice = "ROCK";
                        break;
                    case 2:
                        ComputerChoice = "PAPER";
                        break;
                    case 3:
                        ComputerChoice = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + PlayerChoice);
                Console.WriteLine("Computer: " + ComputerChoice);

                if (PlayerChoice == ComputerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (PlayerChoice == "ROCK" && ComputerChoice == "SCISSORS" || PlayerChoice == "PAPER" && ComputerChoice == "ROCK" || PlayerChoice == "SCISSORS" && ComputerChoice == "PAPER")
                {
                    Console.WriteLine("You wins!");
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                }

                Console.WriteLine("\nStarting next round...");
            }
        }
    }
}