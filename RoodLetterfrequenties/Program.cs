using System;
using System.Collections.Generic;

// Rood Letterfrequenties
// usage: dotnet RoodLetterfrequenties.dll nameoftextfile

namespace RoodLetterfrequenties
{
    class Program
    {
        static Dictionary<char, int> CountChar(string textctc)
        {
            Dictionary<char, int> CharFreq = new Dictionary<char, int>();

            foreach(char c in textctc)
            {
                if (!CharFreq.ContainsKey(c))
                {
                    CharFreq.Add(c, 1);
                }
                else if (CharFreq.ContainsKey(c))
                {
                    CharFreq[c] += 1;
                }
            }

            return CharFreq;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Letter frequenties:");
            //Console.WriteLine(args[0]);
            Dictionary<char, int> CharFreq = new Dictionary<char, int>();
            string text = System.IO.File.ReadAllText(args[0]);

            CharFreq = CountChar(text);

            foreach(char c in CharFreq.Keys)
            {
                Console.WriteLine("{0} komt {1} keer voor.", c, CharFreq[c]);
            }
        }
    }
}
