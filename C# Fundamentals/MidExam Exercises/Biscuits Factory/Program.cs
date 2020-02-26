namespace Biscuits_Factory
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsProducedByWorker = int.Parse(Console.ReadLine());
            int workersCnt = int.Parse(Console.ReadLine());
            int competingFactoryBiscuitsForMonth = int.Parse(Console.ReadLine());

            int biscuitsPerDay = workersCnt * biscuitsProducedByWorker;

            double biscuitsPerMonth = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    biscuitsPerMonth += Math.Floor(biscuitsPerDay * 0.75);
                }
                else
                {
                    biscuitsPerMonth += biscuitsPerDay;
                }
            }

            Console.WriteLine($"You have produced {biscuitsPerMonth} biscuits for the past month.");

            bool producingMore = false;

            if(biscuitsPerMonth > competingFactoryBiscuitsForMonth)
            {
                producingMore = true;
            }

            if(producingMore)
            {
                double factoryDiff = biscuitsPerMonth - competingFactoryBiscuitsForMonth;

                double percentMore = (factoryDiff / competingFactoryBiscuitsForMonth) * 100;

                Console.WriteLine($"You produce {percentMore:f2} percent more biscuits.");
            }
            else
            {
                double factoryDiff = competingFactoryBiscuitsForMonth - biscuitsPerMonth;
                
                double percentLess = (factoryDiff / competingFactoryBiscuitsForMonth) * 100;

                Console.WriteLine($"You produce {percentLess:F2} percent less biscuits.");
            }
        }
    }
}
