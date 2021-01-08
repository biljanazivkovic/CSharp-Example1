using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.99;
            int y = 15;
            Console.WriteLine("Max: " + Math.Max(x, y));
            Console.WriteLine("Min: " + Math.Min(x, y));
            Console.WriteLine("Sqrt(x): " + Math.Sqrt(x));
            Console.WriteLine("Abs(x): " + Math.Abs(x));
            Console.WriteLine("Round(x): " + Math.Round(x));
        }
    }
}
