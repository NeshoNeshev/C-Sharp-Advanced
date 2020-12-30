using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ");
            Queue<string> songsManipulated = new Queue<string>(songs);

            while (songsManipulated.Count != 0)
            {
                var comand = Console.ReadLine().Split();
                if (comand[0] == "Add")
                {
                    string song = comand[1];
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < comand.Length; i++)
                    {
                        sb.Append(comand[i] + " ");
                    }
                    if (songsManipulated.Contains(sb.ToString().TrimEnd()))
                    {
                        Console.WriteLine($"{sb.ToString()}is already contained!");
                    }
                    else
                    {
                        songsManipulated.Enqueue(sb.ToString().TrimEnd());
                    }
                }
                if (comand[0] == "Play")
                {
                    if (songsManipulated.Count > 0)
                    {
                        songsManipulated.Dequeue();
                    }
                }
                if (comand[0] == "Show")
                {
                    if (songsManipulated.Count > 0)
                    {
                        Console.WriteLine(string.Join(", ", songsManipulated));
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
