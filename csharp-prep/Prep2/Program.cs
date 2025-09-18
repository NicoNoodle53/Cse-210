using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade;
        Console.WriteLine("What is your grade? ");
        string gradeInText = Console.ReadLine();
        int grade = int.Parse(gradeInText);

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Great job your passing with a {letterGrade}. Keep it up!");
        }
        else
        {
            Console.WriteLine($"You are currently failing. You have a {letterGrade}. Keep trying you'll get there!");
        }
    }
}