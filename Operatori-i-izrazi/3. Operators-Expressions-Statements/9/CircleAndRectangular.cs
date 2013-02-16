using System;

    class CircleAndRectangular
    {
        static void Main()
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
            bool inRectangle = ((-1 <= x) && (x <= 5)) && ((-1 <= y) && (y <= 1));
            if ( (inCircle == true) && ( inRectangle == true) )
            {
                Console.WriteLine("The point is in the circle and in the rectangle");
            }
            else if ( (inCircle == true) && ( inRectangle == false) )
            {
                Console.WriteLine("The point is in the circle and out of the rectangle");
            }
            else if ( (inCircle == false) && ( inRectangle == false) )
            {
                Console.WriteLine("The point is out of the circle and out of the rectangle");
            }
            else if ( (inCircle == false) && ( inRectangle == true) )
            {
                Console.WriteLine("The point is out of the circle and in the rectangle");
            }
        }
    }
