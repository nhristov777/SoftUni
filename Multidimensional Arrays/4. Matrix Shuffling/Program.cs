using System;
using System.Collections.Generic;
using System.Linq;

namespace Sex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];
            ReadMatrix(matrix);

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] cmd = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmd.Length != 5) Console.WriteLine("Invalid input!");
                else
                {
                    if (cmd[0] != "swap") Console.WriteLine("Invalid input!");
                    else
                    {
                        int row1 = int.Parse(cmd[1]);
                        int col1 = int.Parse(cmd[2]);
                        int row2 = int.Parse(cmd[3]);
                        int col2 = int.Parse(cmd[4]);

                        if (row1 >= rows || row1 < 0 || col1 >= cols
                            || col1 < 0 || row2 >= rows || row2 < 0 || col2 >= cols || col2 < 0)
                            Console.WriteLine("Invalid input!");
                        else
                        {
                            string value1 = matrix[row1, col1];
                            string value2 = matrix[row2, col2];
                            matrix[row1, col1] = value2;
                            matrix[row2, col2] = value1;
                            PrintMatrix(matrix);
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] data = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}
