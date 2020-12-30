using System;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[arr[0], arr[1]];
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var array = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = array[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    string first = matrix[row, col];
                    string second = matrix[row, col - 1];
                    string third = matrix[row + 1, col];
                    string four = matrix[row + 1, col - 1];
                    if ((first == second) && (second == third) && (third == four))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
