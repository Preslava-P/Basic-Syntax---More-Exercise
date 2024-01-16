/*
120
RoverWatch
Honored 2
Game Time

19.99
Reimen origin
RoverWatch
Zplinter Zell
Game Time

79.99
OutFall 4
RoverWatch Origins Edition
Game Time

 */


using System.Threading.Channels;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main()
        {
            double currentBalance = double.Parse(Console.ReadLine());

            double balance = 0;
            string command = Console.ReadLine();
            while (command != "Game Time")
            {
                double gamePrice = 0;
                string gameToBuy = Console.ReadLine();
                if (gameToBuy == "OutFall 4")
                {
                    gamePrice = 39.99;
                    if (balance >= gamePrice)
                    {
                        balance = currentBalance - gamePrice;
                        Console.WriteLine($"Bought {gameToBuy}");
                    }
                    else if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                }
                else if (gameToBuy == "CS: OG")
                {
                    gamePrice = 15.99;
                    if (balance >= gamePrice)
                    {
                        balance = currentBalance - gamePrice;
                        Console.WriteLine($"Bought {gameToBuy}");
                    }
                    else if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                }
                else if (gameToBuy == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                    if (balance >= gamePrice)
                    {
                        balance = currentBalance - gamePrice;
                        Console.WriteLine($"Bought {gameToBuy}");
                    }
                    else if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                }
                else if (gameToBuy == "Honored 2")
                {
                    gamePrice = 59.99;
                    if (balance >= gamePrice)
                    {
                        balance = currentBalance - gamePrice;
                        Console.WriteLine($"Bought {gameToBuy}");
                    }
                    else if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                }
                else if (gameToBuy == "RoverWatch")
                {
                    gamePrice = 29.99;
                    if (balance >= gamePrice)
                    {
                        balance = currentBalance - gamePrice;
                        Console.WriteLine($"Bought {gameToBuy}");
                    }
                    else if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                }
                else if (gameToBuy == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                    if (balance >= gamePrice)
                    {
                        balance = currentBalance - gamePrice;
                        Console.WriteLine($"Bought {gameToBuy}");
                    }
                    else if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    break;
                }
            }
            Console.WriteLine($"Total spent: {balance}. Remaining: {currentBalance - balance}");
        }
    }
}