using System;
using System.Collections.Generic;
using System.Linq;

namespace Sex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowcol = Console.ReadLine().Split(", ").ToArray();
            int rows = int.Parse(rowcol[0]);
            int cols = int.Parse(rowcol[1]);

            int[,] matrix = new int[rows, cols];

            ReadMatrix(matrix, rows, cols);

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }

        }

        static void ReadMatrix(int[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(" ")
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}
