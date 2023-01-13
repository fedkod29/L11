using System;
using System.Collections.Generic;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Footman> footmen = new List<Footman>();
            List<RoyalGuard> royalguards = new List<RoyalGuard>();

            string[] inputArray;

            Console.Write("Enter king's name: ");
            King king = new King(Console.ReadLine());


            Console.Write("Enter Royal Guard's names: ");
            inputArray = Console.ReadLine().Split(" ");

            for(int i = 0; i < inputArray.Length; i++)
            {
                royalguards.Add(new RoyalGuard(inputArray[i]));
                king.HelpKing += royalguards[i].Defend;
            }


            Console.Write("Enter Footman's names: ");
            inputArray = Console.ReadLine().Split(" ");

            for (int i = 0; i < inputArray.Length; i++)
            {
                footmen.Add(new Footman(inputArray[i]));
                king.HelpKing += footmen[i].Panic;
            }


            while (inputArray[0] != "END")
            {
                Console.Write("Enter your commands: ");
                inputArray = Console.ReadLine().Split(" ");

                if (inputArray.Length != 2)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (inputArray[0] == "Attack")
                {
                    king.Attack();
                }

                if (inputArray[0] == "Kill")
                {
                    foreach (Footman footman in footmen)
                    {
                        if (footman.Name == inputArray[1])
                        {
                            Console.WriteLine($"{footman.Name} attached");
                            footman.Helthpoint -= 1;
                        }
                            

                        if(footman.Helthpoint == 0)
                        {
                            Console.WriteLine($"{footman.Name} killed");
                            king.HelpKing -= footman.Panic;
                        }
                    }
                        


                    foreach (RoyalGuard royalGuard in royalguards)
                    {
                        if (royalGuard.Name == inputArray[1])
                        {
                            Console.WriteLine($"{royalGuard.Name} attached");
                            royalGuard.Helthpoint--;
                        }
                            

                        if (royalGuard.Helthpoint == 0)
                        {
                            Console.WriteLine($"{royalGuard.Name} killed");
                            king.HelpKing -= royalGuard.Defend;
                        }
                    }

                }
            }
        }
    }
}
