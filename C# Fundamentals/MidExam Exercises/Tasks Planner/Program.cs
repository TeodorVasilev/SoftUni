namespace Tasks_Planner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> taskHours = Console.ReadLine().Split().Select(int.Parse).ToList();

            int droppedCnt = 0;
            int incompleteCnt = 0;
            int completedCnt = 0;

            for (int i = 0; i < taskHours.Count; i++)
            {
                if(taskHours[i] < 0)
                {
                    droppedCnt++;
                }
                else if(taskHours[i] == 0)
                {
                    completedCnt++;
                }
                else
                {
                    incompleteCnt++;
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];

                switch(command)
                {
                    case "Complete":
                        int index = int.Parse(inputArgs[1]);

                        if(IsIndexValid(taskHours, index))
                        {
                            taskHours[index] = 0;

                            completedCnt++;
                        }
                        break;
                    case "Change":
                        int changeIndex = int.Parse(inputArgs[1]);
                        int time = int.Parse(inputArgs[2]);

                        if (IsIndexValid(taskHours, changeIndex))
                        {
                            taskHours[changeIndex] = time;

                            completedCnt++;
                        }
                        break;
                    case "Drop":
                        int dropIndex = int.Parse(inputArgs[1]);

                        if(IsIndexValid(taskHours, dropIndex))
                        {
                            taskHours[dropIndex] = -1;
                            droppedCnt++;
                        }
                        break;
                    case "Count":
                        if(inputArgs[1] == "Completed")
                        {
                            Console.WriteLine(completedCnt);
                        }
                        else if(inputArgs[1] == "Incomplete")
                        {
                            Console.WriteLine(incompleteCnt);
                        }
                        else if(inputArgs[1] == "Dropped")
                        {
                            Console.WriteLine(droppedCnt);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var item in taskHours)
            {
                if(item > 0)
                {
                    Console.Write(item + " ");
                }
            }
        }

        static bool IsIndexValid(List<int> taskHours, int index)
        {
            if (index < taskHours.Count - 1 && index >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
