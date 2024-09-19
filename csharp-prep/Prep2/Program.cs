using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score (0-100): ");
        int score = Convert.ToInt32(Console.ReadLine());

        string grade;
        string sign = ""; // Initialize sign variable

        if (score >= 90)
        {
            grade = "A";
            if (score < 97) // No A+
            {
                sign = "-";
            }
        }
        else if (score >= 80)
        {
            grade = "B";
            if (score % 10 >= 7)
            {
                sign = "+";
            }
            else if (score % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (score >= 70)
        {
            grade = "C";
            if (score % 10 >= 7)
            {
                sign = "+";
            }
            else if (score % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (score >= 60)
        {
            grade = "D";
            if (score % 10 >= 7)
            {
                sign = "+";
            }
            else if (score % 10 < 3)
            {
                sign = "-";
            }
        }
        else
        {
            grade = "F"; // No F+ or F-
        }

        Console.WriteLine($"Your grade is {grade}{sign}");
    }
}