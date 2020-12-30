using System;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = FillMatrix(arr[0], arr[1]);

            while (true)
            {
                var comands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string comand = comands[0];
                if (comands.Contains("END"))
                {
                    break;
                }
                if (comands.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int first = int.Parse(comands[1]);
                int second = int.Parse(comands[2]);
                int third = int.Parse(comands[3]);
                int four = int.Parse(comands[4]);

                int validRow = matrix.GetLength(0);
                int validCol = matrix.GetLength(1);
                if (comand != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;

                }
                else if (first > validRow || first < 0 || second > validCol || second < 0 || third > validRow || third < 0 || four > validCol || four < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    string firstReplace = matrix[first, second];
                    string secondReplace = matrix[third, four];
                    matrix[first, second] = secondReplace;
                    matrix[third, four] = firstReplace;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        static string[,] FillMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var array = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = array[col];
                }
            }
            return matrix;
        }
    }
}
