using System;
using System.Collections.Generic;

// Rood Letterfrequenties
// usage: dotnet RoodLetterfrequenties.dll nameoftextfile

namespace RoodLetterfrequenties
{
    class Program
    {
        static Dictionary<char, int> CountChar(string textctc, string avoidchars)
        {
            Dictionary<char, int> CharFreq = new Dictionary<char, int>();

            foreach(char c in textctc)
            {
                if (!avoidchars.Contains(c.ToString()))  
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
            }

            return CharFreq;
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Geef de naam van een tekstbestand als argument op.");
                Environment.Exit(0);
            }
            Console.WriteLine("Letter frequenties:");
            Dictionary<char, int> CharFreq = new Dictionary<char, int>();
            string snaos = " \t\n\r.:;-+()*&^%$#@!<>/?|\\,`~"; // spaces, newlines and other stuff...
            string text = System.IO.File.ReadAllText(args[0]);

            CharFreq = CountChar(text, snaos);

            foreach(char c in CharFreq.Keys)
            {
                Console.WriteLine("{0} komt {1} keer voor.", c, CharFreq[c]);
            }
        }
    }
}
