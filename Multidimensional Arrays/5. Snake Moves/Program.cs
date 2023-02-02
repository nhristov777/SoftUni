using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            string input = Console.ReadLine();
            char[] snake = input.Replace(" ", "").ToArray();
            int snakeIndex = 0;
            int row = 0;
            while (row < rows)
            {
                for (int col = 0; col < cols; col++)// or stacks
                {
                    matrix[row, col] = snake[snakeIndex].ToString();
                    snakeIndex++;
                    if (snakeIndex == snake.Length) snakeIndex = 0;
                }
                row++;
                if (row >= rows) break;
                for (int col = cols - 1; col >= 0; col--)
                {
                    matrix[row, col] = snake[snakeIndex].ToString();
                    snakeIndex++;
                    if (snakeIndex == snake.Length) snakeIndex = 0;
                }
                row++;
            }
            PrintMatrix(matrix);
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
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
