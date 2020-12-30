using System;
using System.Collections.Generic;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[n[0], n[1]];

            string snake = Console.ReadLine();
            var array = snake.ToCharArray();
            Queue<char> queue = new Queue<char>(array);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 1)
                {
                    for (int col = matrix.GetLength(1); col > 0; col--)
                    {
                        char ch = queue.Dequeue();
                        matrix[row, col - 1] = ch;
                        queue.Enqueue(ch);
                    }
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char ch = queue.Dequeue();
                        matrix[row, col] = ch;
                        queue.Enqueue(ch);
                    }
                }

            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
