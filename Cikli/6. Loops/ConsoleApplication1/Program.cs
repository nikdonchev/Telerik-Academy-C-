using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
                int matrix = 0;

                Console.Write("Enter matrix size: ");
                bool isNumber = Int32.TryParse(Console.ReadLine(), out matrix);
                Console.WriteLine();

                if (isNumber)
                {
                    for (int rows = 1; rows <= matrix; rows++)
                    {
                        Console.WriteLine();

                        for (int col = rows; col < rows + matrix; col++)
                        {
                            Console.Write("{0,3} ", col);
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Numbers only!!!");
                }
        }
    }
}

