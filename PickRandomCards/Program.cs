using PickRandomCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Card Picker");
        Console.Write("Enter the number of cards to pick:");
        string line = Console.ReadLine();

        // Parsing for integer
        while (line.ToString() != "0")
        {
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine("\nWould you like to enter another amount? (Y/N)");
                string last = Console.ReadLine();
                if (last == "Y" || last == "Yes")
                {
                    Console.Write("\nEnter the number of cards to pick:");
                    line = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.Write("\nThank you for utilizing the Card Picker! \nGoodbye");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.Write("You did not enter a number, enter the number of cards to pick:");
                line = Console.ReadLine();
            }
        }
        
    }
}