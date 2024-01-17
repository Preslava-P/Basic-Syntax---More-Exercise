using System.Globalization;
using System.Threading.Channels;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main()
        {
            double currentBalance = double.Parse(Console.ReadLine());

            double balanceCopy = currentBalance;
            double gamePrice = 0.0;
            while(true)
            {
                string game = Console.ReadLine();
                if(game == "Game Time")
                {
                    break;
                }
                switch (game)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        if (balanceCopy >= gamePrice)
                        {
                            balanceCopy -= gamePrice;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        if (balanceCopy >= gamePrice)
                        {
                            balanceCopy -= gamePrice;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        if (balanceCopy >= gamePrice)
                        {
                            balanceCopy -= gamePrice;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        if (balanceCopy >= gamePrice)
                        {
                            balanceCopy -= gamePrice;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        if (balanceCopy >= gamePrice)
                        {
                            balanceCopy -= gamePrice;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        if (balanceCopy >= gamePrice)
                        {
                            balanceCopy -= gamePrice;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found!");
                        break;
                }

                if (balanceCopy == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${(currentBalance - balanceCopy):F2}. Remaining: ${balanceCopy:F2}");
        }
    }
}