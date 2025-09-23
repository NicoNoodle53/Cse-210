using System;

class Program
{
    static void Main(string[] args)
    {
        int newNumb = 1;
        int sum = 0;
        List<int> numb = new List<int>();
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        //Get list from user and end when 0 is entered then remove the 0
        while (newNumb != 0)
        {
            Console.WriteLine("Enter number:");
            string newNumbString = Console.ReadLine();
            newNumb = int.Parse(newNumbString);
            numb.Add(newNumb);
        }
        numb.RemoveAt(numb.Count - 1);
        //find the sum and average and print
        for (int i = 0; i < numb.Count; i++)
        {
            sum += numb[i];
        }
        double average = ((float)sum) / numb.Count;
        Console.WriteLine($"The sume is: {sum}");
        Console.WriteLine($"The average is: {average}");


        //find the largest number in the list
        int maxNumber = 0;
        foreach (int number in numb)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }

        }
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}