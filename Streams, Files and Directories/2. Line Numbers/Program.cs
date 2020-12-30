using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] lines = File.ReadAllLines("text.txt");
            
                

            for (int i = 0; i < lines.Length; i++)
            {
                int letters = 0;
                int punctuations = 0;
                string newLine = lines[i];
                for (int j = 0; j < newLine.Length; j++)
                {
                    punctuations = PunctuationCount(punctuations, newLine, j);
                    letters = LetterCount(letters, newLine, j);
                }
                lines[i] = $"Line 1: {lines[i]} ({letters})({punctuations})";
                
            }
            File.WriteAllLines("../../../output.txt",lines);
            Console.WriteLine(File.ReadAllText("../../../output.txt") );
            
        }

        private static int LetterCount(int letters, string newLine, int j)
        {
            if (Char.IsLetter(newLine[j]))
            {
                letters++;
            }

            return letters;
        }

        private static int PunctuationCount(int punctuations, string newLine, int j)
        {
            if (Char.IsPunctuation(newLine[j]))
            {
                punctuations++;
            }

            return punctuations;
        }
    }
}
