namespace Giftbox_Coverage
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double sideSize = double.Parse(Console.ReadLine());
            int paperSheetsCount = int.Parse(Console.ReadLine());
            double singleSheetCoverArea = double.Parse(Console.ReadLine());

            double boxArea = sideSize * sideSize * 6;

            double coveredArea = 0;

            for (int i = 1; i <= paperSheetsCount; i++)
            {
                if(i % 3 == 0)
                {
                    coveredArea += singleSheetCoverArea * 0.25;
                }
                else
                {
                    coveredArea += singleSheetCoverArea;
                }
            }

            double coveredPercentage = (coveredArea / boxArea) * 100;

            Console.WriteLine($"You can cover {coveredPercentage:f2}% of the box.");
        }
    }
}
