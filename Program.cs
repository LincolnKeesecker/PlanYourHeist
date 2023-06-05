using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static int Success = 0;
        static int Fail = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Team myTeam = new Team();
            Bank myBank = new Bank();
            NewMember(myTeam);
            myTeam.Info();
            Console.WriteLine();
            Console.WriteLine("How many trial runs would you like to run?");
            int trials = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("What is the Bank's difficulty level?");
            int difficulty = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < trials; i++)
            {
                myBank.difficultyLevel = difficulty;
                SuccessCheck(myBank, myTeam);
            }
            Console.WriteLine($"You have succeeded {Success} times");
            Console.WriteLine($"You have failed {Fail} times");
        }


        static void NewMember(Team team)
        {
            Console.WriteLine("Enter a new Team Member's Name: ");
            string name = Console.ReadLine();
            if (name == "") { return; }

            Console.WriteLine($"Enter {name}'s Skill Level: ");
            int skillLevel = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Enter {name}'s Courage Factor: ");
            float courageFactor = float.Parse(Console.ReadLine());

            Member newMember = new Member(name, skillLevel, courageFactor);

            team.Members.Add(newMember.Name, newMember);

            Console.WriteLine();
            Console.WriteLine("Add another Team Member? y/n");
            string response = Console.ReadLine();
            if (response.ToLower() == "y")
            {
                NewMember(team);
            }

        }
        static void SuccessCheck(Bank bank, Team team)
        {
            bank.LuckValue();

            Console.WriteLine($"Your Team's skill level is: {team.skillLevel()}");
            Console.WriteLine($"The Bank's difficulty level is: {bank.difficultyLevel}");

            if (bank.difficultyLevel < team.skillLevel())
            {
                Console.WriteLine("Your heist was successful!");
                Console.WriteLine();
                Success += 1;
            }
            else
            {
                Console.WriteLine("You have failed. Straight to jail!");
                Console.WriteLine();
                Fail += 1;
            }

        }
    }
}
