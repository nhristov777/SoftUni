using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaggedArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            ReadJagged(jagged);

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                    for (int col = 0; col < jagged[row].GetLength(0); col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                else
                {
                    for (int col = 0; col < jagged[row].GetLength(0); col++)
                        jagged[row][col] /= 2;
                    for (int col = 0; col < jagged[row + 1].GetLength(0); col++)
                        jagged[row + 1][col] /= 2;
                }
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmd = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmd[0];
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);
                if (row < 0 || row >= jagged.Length
                    || col < 0 || col >= jagged[row].GetLength(0))
                { }
                else
                {
                    if (command == "Add")
                        jagged[row][col] += value;
                    else if (command == "Subtract")
                        jagged[row][col] -= value;
                }
                input = Console.ReadLine();
            }
            PrintJagged(jagged);
        }
        /*static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }*/

        /*static void ReadMatrix(string[,] matrix)
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
        }*/

        static void ReadJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                string[] cols = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                jagged[row] = new int[cols.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(cols[col]);
                }
            }
        }

        static void PrintJagged(int[][] jagged)
        {
            foreach (var item in jagged)
                Console.WriteLine(string.Join(" ", item));
        }
    }
}
