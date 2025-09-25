using System;

class Program
{

   //display welcom message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //get user name
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //get favorite number
    static int PromptUsesrNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string numbString = Console.ReadLine();
        int numb = int.Parse(numbString);
        return numb;
    }

    //get users birth year
    static void PromptUserBirthDate(out int year)
    {
        Console.WriteLine("Please enter the year you were born: ");
        string yearString = Console.ReadLine();
        year = int.Parse(yearString);
    }

    // square the number
    static int SquareNumber(int square)
    {
        square = square ^ 2;
        return square;
    }

    //display the results
    static void DisplayResult(int numb, string name, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(numb)}");
        Console.WriteLine($"{name}, you will turn {2025 - year} this year.");
    }
    static void Main(string[] args)
    {
        //call all the functions and initialize year
        int year = 0;
        DisplayWelcome();
        string name = PromptUserName();
        int numb = PromptUsesrNumber();
        PromptUserBirthDate(out year);
        DisplayResult(numb, name, year);
        
    }
}