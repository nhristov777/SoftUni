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
            char[,] matrix = new char[rows, cols];

            ReadMatrix(matrix, rows, cols);

            char symbol = char.Parse(Console.ReadLine());
            bool exists = false;
            int symbolRow = 0;
            int symbolCol = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        exists = true;
                        symbolRow = row;
                        symbolCol = col;
                        break;
                    }
                }
                if (exists) break;
            }
            if (exists) Console.WriteLine($"({symbolRow}, {symbolCol})");
            else Console.WriteLine($"{symbol} does not occur in the matrix");
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

        static void ReadMatrix(char[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}
