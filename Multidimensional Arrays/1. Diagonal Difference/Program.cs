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

            ReadMatrix(matrix);

            int primary = 0;
            int col;
            for (int row = 0; row < rows; row++)
            {
                for (col = 0; col < cols; col++)
                {
                    if (row == col) primary += matrix[row, col];
                }
            }
            int secondary = 0;
            col = 0;
            for (int row = rows - 1; row >= 0; row--)
            {
                secondary += matrix[row, col];
                col++;
            }
            int difference = Math.Abs(primary - secondary);
            Console.WriteLine(difference);
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

        static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine().Split(" ")
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}