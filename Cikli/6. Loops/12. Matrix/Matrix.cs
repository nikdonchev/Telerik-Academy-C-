using System;

    class Matrix
    {
        static void Main()
        {
            int matrix = 0;
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0 && n < 20)
            {
                for (int rows = 1; rows <= n; rows++)
                {
                    Console.WriteLine();
                    for (int col = rows; col < rows + n; col++)
                    {
                        Console.Write("{0,5} ", col);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The number must be between interval 0 < n < 20");
            }
        }
    }

