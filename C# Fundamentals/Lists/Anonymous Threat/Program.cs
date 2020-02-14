namespace Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] inputArgs = input.Split();

                if(inputArgs[0] == "merge")
                {
                    int startIndex = Math.Max(0, int.Parse(inputArgs[1]));
                    int endIndex = Math.Min(data.Count - 1, int.Parse(inputArgs[2]));

                    for (int i = 0; i < data.Count; i++)
                    {
                        if(i == startIndex)
                        {
                            for (int k = startIndex + 1; k <= endIndex; k++)
                            {
                                data[startIndex] += data[startIndex + 1];
                                data.RemoveAt(startIndex + 1);
                            }

                            break;
                        }
                    }
                }
                else if(inputArgs[0] == "divide")
                {
                    int index = int.Parse(inputArgs[1]);
                    int partitions = int.Parse(inputArgs[2]);

                    string subString = data[index];

                    List<string> divided = new List<string>();

                    int newSubstringLength = subString.Length / partitions;
                    int longestSubstringLength = subString.Length % partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        string tempString = null;

                        for (int k = 0; k < newSubstringLength; k++)
                        {
                            tempString += subString[(i * newSubstringLength) + k];
                        }

                        if (i == partitions - 1 && longestSubstringLength != 0)
                        {
                            tempString += subString.Substring(subString.Length - longestSubstringLength);
                        }

                        divided.Add(tempString);
                    }

                    data.RemoveAt(index);
                    data.InsertRange(index, divided);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", data));
        }
    }
}
