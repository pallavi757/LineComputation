
using System;

namespace Line_Comparison_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 10;
            double y1 = 15;
            double x2 = 30;
            double y2 = 5;
            double Length_One = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of Line: " + Length_One);

            double x3 = 22;
            double y3 = 18;
            double x4 = 13;
            double y4 = 10;
            double Length_Second = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of Line: " + Length_Second);

            if (Length_One == Length_Second)
            {
                Console.WriteLine("Length are equal");
            }
            else
            {
                Console.WriteLine("Length are not equal");
            }
        }
    }
}
