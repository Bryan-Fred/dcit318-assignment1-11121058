using System;

namespace DCIT318Assignment1
{
    public class GradeCalculator
    {
        public static void Run()
        {
            Console.WriteLine("=== Grade Calculator ===");

            Console.Write("Enter your numerical grade (0 - 100): ");
            string input = Console.ReadLine();
            int grade;

            while (!int.TryParse(input, out grade) || grade < 0 || grade > 100)
            {
                Console.Write("Invalid input. Please enter a number between 0 and 100: ");
                input = Console.ReadLine();
            }

            char letterGrade;

            if (grade >= 90)
                letterGrade = 'A';
            else if (grade >= 80)
                letterGrade = 'B';
            else if (grade >= 70)
                letterGrade = 'C';
            else if (grade >= 60)
                letterGrade = 'D';
            else
                letterGrade = 'F';

            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }
    }
}
