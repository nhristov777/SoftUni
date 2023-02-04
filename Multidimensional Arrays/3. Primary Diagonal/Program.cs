using System;
using System.Collections.Generic;
using System.Linq;

namespace Sex
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int cols = size;
            int rows = size;
            int[,] matrix = new int[rows, cols];

            ReadMatrix(matrix, rows, cols);

            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == col) sum += matrix[row, col];
                }
            }

            Console.WriteLine(sum);
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
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
