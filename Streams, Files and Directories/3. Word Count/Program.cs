using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Text.txt");
            string[] words = File.ReadAllLines("Words.txt");

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            int counter = 0;

            for (int word = 0; word < words.Length; word++)
            {
                string w = words[word];
                for (int i = 0; i < lines.Length; i++)
                {
                    var currentLine = lines[i].Split();
                    for (int j = 0; j < currentLine.Length; j++)
                    {
                        StringBuilder sb = new StringBuilder();

                        foreach (var item in currentLine[j])
                        {
                            if (!Char.IsPunctuation(item))
                            {
                                sb.Append(item);
                            }
                        }
                        
                        if (w == sb.ToString().ToLower())
                        {
                            counter++;
                        }
                    }
                }
                wordsCount.Add(words[word], counter);
                words[word] = $"{words[word]} - {counter}";
                counter = 0;
            }
            var sorted = wordsCount.OrderByDescending(x => x.Value);
            List<string> lists = new List<string>();
            foreach (var item in sorted)
            {
                
                lists.Add($"{item.Key} - {item.Value}");
                
            }
            File.WriteAllLines("../../../actualResult.txt", words);
            File.WriteAllLines("../../../expextedResult.txt", lists);
            Console.WriteLine(File.ReadAllText("../../../actualResult.txt"));
            Console.WriteLine(File.ReadAllText("../../../expextedResult.txt"));
        }
    }
}
