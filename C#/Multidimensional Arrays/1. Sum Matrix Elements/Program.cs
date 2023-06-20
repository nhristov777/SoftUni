using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantExhibition
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowcol = Console.ReadLine().Split(", ").ToArray();
            int rows = int.Parse(rowcol[0]);
            int cols = int.Parse(rowcol[1]);

            int[,] matrix = new int[rows, cols];

            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(", ")
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
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
    }
}