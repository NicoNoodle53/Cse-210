using System;

public class Journal
{
    public List<JournalEntry> _entrys = new List<JournalEntry>();

    public void Display()
    {
        foreach (JournalEntry entry in _entrys)
        {
            entry.DisplayEntry();
        }
    }
}