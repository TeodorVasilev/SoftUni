namespace Experience_Gaining
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());

            int battlesCnt = int.Parse(Console.ReadLine());

            double experience = 0;

            int battleCnt = 0;

            for (int i = 1; i <= battlesCnt; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    experiencePerBattle += experiencePerBattle * 0.15;
                }

                if(i % 5 == 0)
                {
                    experiencePerBattle -= experiencePerBattle * 0.10;
                }

                experience += experiencePerBattle;
                battleCnt++;

                if (experience >= neededExperience)
                    break;
            }

            if (experience >= neededExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleCnt} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience - experience:f2} more needed.");
            }
        }
    }
}
