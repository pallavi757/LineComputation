namespace Line_Comparison_Problem
{

    public class Example
    {

        static void Main(String[] args)
        {

            // point 1
            double x1 = 10;
            double y1 = 15;

            // point 2
            double x2 = 30;
            double y2 = 5;

            // Calculate distance between two points
            double len = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Length between two points :" + len);
        }
    }
}