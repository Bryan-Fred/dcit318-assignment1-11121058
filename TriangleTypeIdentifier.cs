using System;

namespace DCIT318Assignment1
{
    public class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.WriteLine("=== Triangle Type Identifier ===");

            double side1 = ReadSide("Enter length of side 1: ");
            double side2 = ReadSide("Enter length of side 2: ");
            double side3 = ReadSide("Enter length of side 3: ");

            // Optional: Check for triangle validity
            if (!IsValidTriangle(side1, side2, side3))
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
                return;
            }

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This is an Equilateral triangle.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("This is an Isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is a Scalene triangle.");
            }
        }

        private static double ReadSide(string prompt)
        {
            double side;
            Console.Write(prompt);
            string input = Console.ReadLine();

            while (!double.TryParse(input, out side) || side <= 0)
            {
                Console.Write("Invalid input. Please enter a positive number: ");
                input = Console.ReadLine();
            }

            return side;
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            // Triangle inequality theorem
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
