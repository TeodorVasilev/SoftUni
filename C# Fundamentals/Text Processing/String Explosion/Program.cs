namespace String_Explosion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<char> text = Console.ReadLine().ToCharArray().ToList();

            for (int i = 0; i < text.Count; i++)
            {
                char letter = text[i];
                int reminder = 0;

                if(letter == '>')
                {
                    int index = i + 1;
                    bool parsed = int.TryParse(text[index].ToString(), out int power);

                    if(!parsed)
                    {
                        break;
                    }

                    for (int k = index; k < index + power + reminder; k++)
                    {
                        if(text[k] != '>')
                        {
                            text.RemoveAt(k);
                        }
                        else
                        {
                            reminder++;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join("", text));
        }
    }
}
