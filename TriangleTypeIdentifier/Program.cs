using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Type Identifier");

            Console.Write("Enter side A: ");
            string inputA = Console.ReadLine();
            Console.Write("Enter side B: ");
            string inputB = Console.ReadLine();
            Console.Write("Enter side C: ");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c))
            {
                if (IsValidTriangle(a, b, c))
                {
                    string triangleType = GetTriangleType(a, b, c);
                    Console.WriteLine($"This is a(n): {triangleType} triangle.");
                }
                else
                {
                    Console.WriteLine("These sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input: Please enter numbers only.");
            }

        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Equilateral";
            else if (a == b || b == c || a == c)
                return "Isosceles";
            else
                return "Scalene";
        }
    }
}
