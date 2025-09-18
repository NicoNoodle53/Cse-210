using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask for first and last name
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("What is your first name? ");
        string Fname = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string Lname = Console.ReadLine();

        //Display name in format given
        Console.WriteLine($"Your name is {Lname}, {Fname} {Lname}.");
    }
}