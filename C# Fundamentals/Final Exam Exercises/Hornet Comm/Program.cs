namespace Hornet_Comm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> msgs = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> broadcasts = new Dictionary<string, List<string>>();

            string messagePattern = @"^(?<code>\d+) <-> (?<msg>[\w]+)$";
            string broadcastPattern = @"^(?<msg>[^0-9]+) <-> (?<freq>\w+)$";

            while (input != "Hornet is Green")
            {
                Match messageMatch = Regex.Match(input, messagePattern);
                Match broadcastMatch = Regex.Match(input, broadcastPattern);

                if(messageMatch.Success)
                {
                    char[] code = messageMatch.Groups["code"].Value.ToCharArray();
                    string message = messageMatch.Groups["msg"].Value;

                    code = code.Reverse().ToArray();

                    string newCode = new string(code);

                    if (!msgs.ContainsKey(newCode))
                    {
                        msgs[newCode] = new List<string>();
                        msgs[newCode].Add(message);
                    }
                    else
                    {
                        msgs[newCode].Add(message);
                    }
                }
                else if(broadcastMatch.Success)
                {
                    string message = broadcastMatch.Groups["msg"].Value;
                    char[] frequency = broadcastMatch.Groups["freq"].Value.ToCharArray();

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if(char.IsLower(frequency[i]))
                        {
                            frequency[i] = char.ToUpper(frequency[i]);
                        }
                        else if(char.IsUpper(frequency[i]))
                        {
                            frequency[i] = char.ToLower(frequency[i]);
                        }
                    }

                    string newFrequency = new string(frequency);

                    if(!broadcasts.ContainsKey(newFrequency))
                    {
                        broadcasts[newFrequency] = new List<string>();
                        broadcasts[newFrequency].Add(message);
                    }
                    else
                    {
                        broadcasts[newFrequency].Add(message);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if(broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var kvp in broadcasts)
                {
                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"{kvp.Key} -> {item}");
                    }
                }
            }
            Console.WriteLine("Messages:");
            if (msgs.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var kvp in msgs)
                {
                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"{kvp.Key} -> {item}");
                    }
                }
            }
        }
    }
}
