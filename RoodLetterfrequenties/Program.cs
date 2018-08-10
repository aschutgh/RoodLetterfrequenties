using System;
using System.Collections.Generic;

// Rood Letterfrequenties

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

        // FIXME: tekstbestand inlezen
        // FIXME: argument uitlezen

        static void Main(string[] args)
        {
            Dictionary<char, int> CharFreq = new Dictionary<char, int>();
            CharFreq = CountChar("Dit is een test.æ");

            foreach(char c in CharFreq.Keys)
            {
                Console.WriteLine("{0}    {1}", c, CharFreq[c]);
            }

            

        }
    }
}
