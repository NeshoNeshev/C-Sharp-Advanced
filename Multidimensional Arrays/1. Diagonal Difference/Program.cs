using System;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int firstDiagonal = 0;
            int secondDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    firstDiagonal += matrix[row, col];
                    break;
                }
            }
            int c = 0;
            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                for (int row = c; row < matrix.GetLength(0); row++)
                {
                    secondDiagonal += matrix[col, row];
                    c++;
                    break;
                }
            }
            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
        }
    }
}
