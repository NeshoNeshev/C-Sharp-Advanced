using System;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            var matrix = new double[rows][];
            if (matrix.Length == 1)
            {
                return;
            }
            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                matrix[row] = new double[currentRow.Length];
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row][col] = currentRow[col];
                }
            }
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                    {
                        for (int col = 0; col < matrix[rowCurrent].Length; col++)
                        {
                            matrix[rowCurrent][col] = matrix[rowCurrent][col] * 2;
                        }
                    }
                }
                else
                {
                    for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                    {
                        for (int col = 0; col < matrix[rowCurrent].Length; col++)
                        {
                            matrix[rowCurrent][col] = matrix[rowCurrent][col] / 2;
                        }
                    }
                }
            }
            while (true)
            {
                var comand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (comand.Contains("End"))
                {
                    break;
                }
                int row = int.Parse(comand[1]);
                int col = int.Parse(comand[2]);
                double value = double.Parse(comand[3]);
                if (comand.Contains("Add"))
                {

                    if ((row >= 0 && row <= matrix.Length - 1) && (col >= 0 && col <= matrix[row].Length - 1))
                    {
                        matrix[row][col] += value;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (comand.Contains("Subtract"))
                {
                    if ((row >= 0 && row <= matrix.Length - 1) && (col >= 0 && col <= matrix[row].Length - 1))
                    {
                        matrix[row][col] -= value;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            foreach (double[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
