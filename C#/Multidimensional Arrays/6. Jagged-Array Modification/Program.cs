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

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] cmd = input.Split(" ");
                if (int.Parse(cmd[1]) >= size || int.Parse(cmd[2]) >= size
                    || int.Parse(cmd[1]) < 0 || int.Parse(cmd[2]) < 0)
                    Console.WriteLine("Invalid coordinates");
                else
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);
                    if (cmd[0] == "Add")
                    {
                        matrix[row, col] += value;
                    }
                    else if (cmd[0] == "Subtract")
                    {
                        matrix[row, col] -= value;
                    }
                }
                input = Console.ReadLine();
            }
            PrintMatrix(matrix);
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
