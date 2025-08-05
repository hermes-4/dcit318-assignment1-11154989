using System;
namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Grade Calculator***"); 
            Console.Write("Enter a numerical grade (0 to 100): ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int score))
            {
                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid input: Grade must be from 0 and 100");
                }
                else
                {
                    string grade = GetGrade(score);
                    Console.WriteLine("The letter grade of " + score + " is " + grade + ".");

                }
            }
            else
            {
                Console.WriteLine("Invalid input: Please enter a valid number.");
            }

        }
       
        static string GetGrade(int score) {
            switch (score / 10)
            {
                case 10:
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                case 6:
                    return "D";
                default:
                    return "F";
            }
        } }
    }