using System;
using System.Runtime.InteropServices.Marshalling;

public class JournalEntry
{

    public DateTime _date = DateTime.Now;
    public string _prompt;
    public string _response;

    public void DisplayPrompt()
    {
        Prompt prompt = new Prompt();
        _prompt = prompt.JournalPrompt();
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
    }

    public void DisplayEntry()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
    }
}