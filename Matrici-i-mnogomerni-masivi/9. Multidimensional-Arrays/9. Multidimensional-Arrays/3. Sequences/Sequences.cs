﻿using System;

class Sequences
{
    static void PrintMatrix(string[,] matrix)
    {
        int cellSize = matrix[0, 0].Length;
        foreach (string cell in matrix) cellSize = Math.Max(cellSize, cell.Length);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j].PadRight(cellSize, ' ') + (j != matrix.GetLength(1) - 1 ? " " : "\n"));
            }
        }
    }

    static bool IsTraversable(string[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
    }

    static int maxSum = 0;
    static string maxValue;

    static int[,] directions = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { 1, -1 } };

    static void Dfs(string[,] matrix, bool[,,] used, int row, int col)
    {
        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            if (used[row, col, direction]) continue;

            int currentSum = 0;
            int row2 = row, col2 = col;

            while (IsTraversable(matrix, row2, col2) && matrix[row, col] == matrix[row2, col2])
            {
                currentSum++;

                used[row2, col2, direction] = true;

                row2 += directions[direction, 0];
                col2 += directions[direction, 1];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxValue = matrix[row, col];
            }
        }
    }

    static void Main()
    {
        string[,] matrix = { { "az", "tre", "az", "tert" }, { "tr", "sam", "az", "sam" }, { "rt", "tr", "trrf", "ti" } };
        
        bool[,,] used = new bool[matrix.GetLength(0), matrix.GetLength(1), directions.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Dfs(matrix, used, i, j);
            }
        }

        PrintMatrix(matrix);
        Console.WriteLine(maxValue + " " + maxSum);
    }
}