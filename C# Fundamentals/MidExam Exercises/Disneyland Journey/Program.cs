namespace Disneyland_Journey
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            decimal tripPrice = decimal.Parse(Console.ReadLine());
            int monthsCnt = int.Parse(Console.ReadLine());

            decimal savedMoney = 0;

            for (int i = 1; i <= monthsCnt; i++)
            {
                if(i != 1 && i % 2 != 0)
                {
                    savedMoney -= savedMoney * 0.16m;
                }

                if(i % 4 == 0)
                {
                    savedMoney += savedMoney * 0.25m;
                }

                savedMoney += tripPrice * 0.25m;
            }

            if(savedMoney >= tripPrice)
            {
                decimal moneyLeft = savedMoney - tripPrice;

                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyLeft:F2}lv. for souvenirs.");
            }
            else
            {
                decimal neededMoney = tripPrice - savedMoney;

                Console.WriteLine($"Sorry. You need {neededMoney:f2}lv. more.");
            }
        }
    }
}
