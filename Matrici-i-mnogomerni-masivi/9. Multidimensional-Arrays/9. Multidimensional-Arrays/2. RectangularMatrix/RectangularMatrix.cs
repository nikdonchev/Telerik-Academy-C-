﻿using System;

class RectangularMatrix
{
    static void PrintMatrix(int[,] matrix)
    {
        int max = matrix[0, 0];
        foreach (int cell in matrix) 
            max = Math.Max(max, cell);
        {
            int cellSize = (int)Math.Log10(max) + 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(Convert.ToString(matrix[i, j]).PadRight(cellSize, ' ') + (j != matrix.GetLength(1) - 1 ? " " : "\n"));
                }
            }
        }
    }

    static int MakeSum(int[,] matrix, int k, int row, int col)
    {
        int sum = 0;

        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                sum += matrix[row + i, col + j];
            }
        }

        return sum;
    }
    
    static void Main()
    {
        int[,] matrix = { { 43, 45, 45, 45 }, { 40, 250, 630, 50 }, { 5, 6, 7, 8 }, { 56, 45, 654, 56 } };
        int k = 3;

        int maxSum = int.MinValue, maxRow = -1, maxCol = -1;

        for (int i = 0; i <= matrix.GetLength(0) - k; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - k; j++)
            {
                int currentSum = MakeSum(matrix, k, i, j);

                if (currentSum >= maxSum)
                {
                    maxSum = currentSum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        int[,] result = new int[k, k];

        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                result[i, j] = matrix[maxRow + i, maxCol + j];
            }
        }

        PrintMatrix(result);
    }
}
