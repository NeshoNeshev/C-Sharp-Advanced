using System;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] cheesBoard = new char[n, n];
            FilMatrix(cheesBoard);
            //PrintMatrix(cheesBoard);
            int countReplacement = 0;

            int rowKiler = 0;
            int colKiler = 0;
            while (true)
            {
                int maxAtack = 0;
                for (int row = 0; row < cheesBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < cheesBoard.GetLength(1); col++)
                    {
                        int curentAtack = 0;
                        if (cheesBoard[row, col] == 'K')
                        {
                            curentAtack = GetAtacks(cheesBoard, row, col, curentAtack);
                            if (curentAtack > maxAtack)
                            {
                                maxAtack = curentAtack;
                                rowKiler = row;
                                colKiler = col;
                            }
                        }

                    }
                }
                if (maxAtack > 0)
                {
                    cheesBoard[rowKiler, colKiler] = '0';
                    countReplacement++;
                }
                else
                {
                    Console.WriteLine(countReplacement);
                    break;
                }
            }
        }

        private static int GetAtacks(char[,] cheesBoard, int row, int col, int curentAtack)
        {
            if (IsInside(cheesBoard, row - 2, col - 1) && cheesBoard[row - 2, col - 1] == 'K')
            {
                curentAtack++;
            }

            if (IsInside(cheesBoard, row - 2, col + 1) && cheesBoard[row - 2, col + 1] == 'K')
            {
                curentAtack++;
            }

            if (IsInside(cheesBoard, row - 1, col + 2) && cheesBoard[row - 1, col + 2] == 'K')
            {
                curentAtack++;
            }

            if (IsInside(cheesBoard, row - 1, col - 2) && cheesBoard[row - 1, col - 2] == 'K')
            {
                curentAtack++;
            }

            if (IsInside(cheesBoard, row + 2, col + 1) && cheesBoard[row + 2, col + 1] == 'K')
            {
                curentAtack++;
            }

            if (IsInside(cheesBoard, row + 2, col - 1) && cheesBoard[row + 2, col - 1] == 'K')
            {
                curentAtack++;
            }

            if (IsInside(cheesBoard, row + 1, col + 2) && cheesBoard[row + 1, col + 2] == 'K')
            {
                curentAtack++;
            }

            if (IsInside(cheesBoard, row + 1, col - 2) && cheesBoard[row + 1, col - 2] == 'K')
            {
                curentAtack++;
            }

            return curentAtack;
        }

        private static void PrintMatrix(char[,] cheesBoard)
        {
            for (int row = 0; row < cheesBoard.GetLength(0); row++)
            {
                for (int col = 0; col < cheesBoard.GetLength(1); col++)
                {
                    Console.Write(cheesBoard[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void FilMatrix(char[,] cheesBoard)
        {
            for (int row = 0; row < cheesBoard.GetLength(0); row++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cheesBoard.GetLength(1); col++)
                {
                    cheesBoard[row, col] = chars[col];
                }
            }
        }
        private static bool IsInside(char[,] board, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < board.GetLength(0)
                   && targetCol >= 0 && targetCol < board.GetLength(1);

        }
    }
}
