namespace SoftUni_Course_Planning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> scheduledLessons = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] inputArgs = input.Split(":");

                string command = inputArgs[0];
                string lessonTitle = inputArgs[1];

                if(command == "Add")
                {
                    if(!scheduledLessons.Contains(lessonTitle))
                    {
                        scheduledLessons.Add(lessonTitle);
                    }
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(inputArgs[2]);

                    if(!scheduledLessons.Contains(lessonTitle))
                    {
                        scheduledLessons.Insert(index, lessonTitle);
                    }
                }
                else if(command == "Remove")
                {
                    if(scheduledLessons.Contains(lessonTitle))
                    {
                        if(scheduledLessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            scheduledLessons.RemoveAll(x => x == $"{lessonTitle}-Exercise");
                        }
                        scheduledLessons.Remove(lessonTitle);
                    }
                }
                else if(command == "Swap")
                {
                    string secondLessonTitle = inputArgs[2];

                    int lessonIndex = scheduledLessons.IndexOf(lessonTitle);
                    int secondLessonIndex = scheduledLessons.IndexOf(secondLessonTitle);

                    int lessonExerciseIndex = scheduledLessons.IndexOf($"{lessonTitle}-Exercise");
                    int secondLessonExerciseIndex = scheduledLessons.IndexOf($"{secondLessonTitle}-Exercise");

                    if(lessonIndex >= 0 && secondLessonIndex >= 0)
                    {
                        scheduledLessons[lessonIndex] = secondLessonTitle;
                        scheduledLessons[secondLessonIndex] = lessonTitle;

                        lessonIndex = scheduledLessons.IndexOf(lessonTitle);
                        secondLessonIndex = scheduledLessons.IndexOf(secondLessonTitle);

                        if(lessonExerciseIndex >= 0)
                        {
                            scheduledLessons.Insert(lessonIndex + 1, $"{lessonTitle}-Exercise");
                            scheduledLessons.RemoveAt(lessonExerciseIndex);
                        }

                        if(secondLessonExerciseIndex >= 0)
                        {
                            scheduledLessons.Insert(secondLessonIndex + 1, $"{secondLessonTitle}-Exercise");
                            scheduledLessons.RemoveAt(secondLessonExerciseIndex + 1);
                        }
                    }
                }
                else if(command == "Exercise")
                {
                    if(scheduledLessons.Contains(lessonTitle))
                    {
                        if(!scheduledLessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            int index = scheduledLessons.IndexOf(lessonTitle);

                            scheduledLessons.Insert(index + 1, $"{lessonTitle}-Exercise");
                        }
                    }
                    else
                    {
                        scheduledLessons.Add(lessonTitle);
                        scheduledLessons.Add($"{lessonTitle}-Exercise");
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < scheduledLessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{scheduledLessons[i]}");
            }
        }
    }
}
