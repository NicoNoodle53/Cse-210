using System;
using System.ComponentModel.DataAnnotations;

public class Journal
{
    //intiilaze list of entrys for journal
    public List<JournalEntry> _entrys = new List<JournalEntry>();

    public string _filename;

    //display each entry from journal
    public void Display()
    {
        foreach (JournalEntry entry in _entrys)
        {
            entry.DisplayEntry();
        }
    }

    //save journal to file
    public void SaveToFile()
    {
        Console.WriteLine("Saved to file");
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (JournalEntry entry in _entrys)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._response}");
            }
        }
    }

    //pull journal from file and add to journal
    public void LoadFromFile()
    {
        Console.WriteLine("Loading Journal");
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            JournalEntry entry = new JournalEntry();
            entry._date = DateTime.Parse(parts[0]);
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entrys.Add(entry);
        }
    }
}
