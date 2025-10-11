using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        int option = 0;
        Journal myJournal = new Journal();
        while (option != 5)
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                JournalEntry entry = new JournalEntry();
                entry.DisplayPrompt();
                entry._response = Console.ReadLine();
                myJournal._entrys.Add(entry);
            }
        }

    }
}