using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        int option = 0;
        Journal myJournal = new Journal();
        //write out main display and loop through with options till exited
        while (option != 5)
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            option = int.Parse(Console.ReadLine());

            //get a response and add to journal
            if (option == 1)
            {
                JournalEntry entry = new JournalEntry();
                entry.DisplayPrompt();
                entry._response = Console.ReadLine();
                myJournal._entrys.Add(entry);
            }
            //display entry's
            if (option == 2)
            {
                myJournal.Display();
            }
            //save journal to file
            if (option == 3)
            {
                Console.WriteLine("Enter file name");
                myJournal._filename = Console.ReadLine();
                myJournal.SaveToFile();
            }
            //Load journal from file
            if (option == 4)
            {
                Console.WriteLine("Enter file name you wish to load from");
                myJournal._filename = Console.ReadLine();
                myJournal.LoadFromFile();
            }

        }

    }
}
