namespace Distance_Calculator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int stepsMade = int.Parse(Console.ReadLine());
            double stepLength = double.Parse(Console.ReadLine());
            double neededDistance = double.Parse(Console.ReadLine());

            double distance = 0;

            for (int i = 1; i <= stepsMade; i++)
            {
                if(i % 5 == 0)
                {
                    distance += stepLength - (stepLength * 0.30);
                }
                else
                {
                    distance += stepLength;
                }
            }

            distance /= 100;

            double percentCovered = distance / neededDistance * 100;

            Console.WriteLine($"You travelled {percentCovered:f2}% of the distance!");
        }
    }
}
