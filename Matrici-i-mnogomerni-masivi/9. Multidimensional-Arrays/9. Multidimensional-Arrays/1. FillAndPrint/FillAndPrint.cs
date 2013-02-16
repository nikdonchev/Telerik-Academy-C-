using System;

class FillAndPrint
{
    public static void Main()
    {
        Console.Write("number rows and columns: ");
        int n = int.Parse(Console.ReadLine());
        PrintFirst(n);
        PrintSecond(n);
        PrintThird(n);
        PrintFourth(n);
    }

    public static void PrintMatrix(int[,] matrix, int n)
    {
        int maxLength = (n * n).ToString().Length;
        int currentLength;
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                currentLength = matrix[rows, cols].ToString().Length;
                Console.Write("{0} ", matrix[rows, cols].ToString().PadLeft(currentLength + (maxLength - currentLength) / 2).PadRight(maxLength));
            }

            Console.WriteLine();
        }
    }

    public static bool IsValidCell(int n, int x, int y)
    {
        return x >= 0 && x < n && y >= 0 && y < n;
    }

    public static void PrintFirst(int n)
    {
        Console.WriteLine();
        Console.WriteLine("First Matrix: ");

        int currentValue = 1;
        int[,] matrix = new int[n, n];
        for (int cols = 0; cols < n; cols++)
        {
            for (int rows = 0; rows < n; rows++)
            {
                matrix[rows, cols] = currentValue++;
            }
        }

        PrintMatrix(matrix, n);
    }

    public static void PrintSecond(int n)
    {
        Console.WriteLine();
        Console.WriteLine("Second Matrix: ");

        int currentValue = 1;
        int[,] matrix = new int[n, n];
        for (int cols = 0; cols < n; cols++)
        {
            if (cols % 2 == 0)
            {
                for (int rows = 0; rows < n; rows++)
                {
                    matrix[rows, cols] = currentValue++;
                }
            }
            else
            {
                for (int rows = n - 1; rows >= 0; rows--)
                {
                    matrix[rows, cols] = currentValue++;
                }
            }
        }

        PrintMatrix(matrix, n);
    }

    public static void PrintThird(int n)
    {
        Console.WriteLine();
        Console.WriteLine("Third Matrix: ");

        int x = n - 1;
        int y = 0;
        int[,] matrix = new int[n, n];
        for (int currentValue = 1; currentValue <= n * n; currentValue++)
        {
            matrix[x++, y++] = currentValue;

            if (x == n || y == n)
            {
                x--;
                if (y == n)
                {
                    x--;
                    y--;
                }

                while (x - 1 >= 0 && y - 1 >= 0)
                {
                    x--;
                    y--;
                }
            }
        }

        PrintMatrix(matrix, n);
    }

    public static void PrintFourth(int n)
    {
        Console.WriteLine();
        Console.WriteLine("Fourth Matrix: ");

        int x = 0;
        int y = 0;
        int direction = 0;
        int dx = 1;
        int dy = 0;
        int[,] matrix = new int[n, n];
        for (int currentValue = 1; currentValue <= n * n; currentValue++)
        {
            matrix[x, y] = currentValue;

            if (!IsValidCell(n, x + dx, y + dy) || matrix[x + dx, y + dy] > 0)
            {
                direction = (++direction) % 4;
                if (direction == 0)
                {
                    dx = 1;
                    dy = 0;
                }
                else if (direction == 1)
                {
                    dx = 0;
                    dy = 1;
                }
                else if (direction == 2)
                {
                    dx = -1;
                    dy = 0;
                }
                else if (direction == 3)
                {
                    dx = 0;
                    dy = -1;
                }
                else
                {
                    Console.WriteLine("Invalid direction value: {0}", direction);
                }
            }

            x += dx;
            y += dy;
        }

        PrintMatrix(matrix, n);
    }
}
