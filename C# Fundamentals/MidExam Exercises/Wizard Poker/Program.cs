namespace Wizard_Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();

            List<string> newDeck = new List<string>();

            string input = Console.ReadLine();

            while (input != "Ready")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];
                string cardName = commandArgs[1];

                if(command == "Add")
                {
                    if(!cards.Contains(cardName))
                    {
                        Console.WriteLine("Card not found.");
                    }
                    else
                    {
                        newDeck.Add(cardName);
                    }
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);

                    if (index >= 0 && index < newDeck.Count)
                    {
                        if (!cards.Contains(cardName))
                        {
                            Console.WriteLine("Error!");
                        }
                        else
                        {
                            newDeck.Insert(index, cardName);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (command == "Remove")
                {
                    if (!newDeck.Contains(cardName))
                    {
                        Console.WriteLine("Card not found.");
                    }
                    else
                    {
                        newDeck.Remove(cardName);
                    }
                }
                else if (command == "Swap")
                {
                    string secondCardName = commandArgs[2];

                    int firstCardIndex = newDeck.IndexOf(cardName);
                    int secondBookIndex = newDeck.IndexOf(secondCardName);

                    string temp = newDeck[firstCardIndex];
                    newDeck[firstCardIndex] = secondCardName;
                    newDeck[secondBookIndex] = temp;
                }
                else if (command == "Shuffle")
                {
                    newDeck.Reverse();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", newDeck));
        }
    }
}
