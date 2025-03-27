using System;

public class Journal
{
    // As in C# , the rule is to start a member variable with an (_) underscore

    public List<JournalEntry> _journal = new List<JournalEntry>();

    public Journal()
    {
    }

    // Way that displays person's first name and second name(family name)

    public void Display()
    {
        Console.WriteLine("\n ========== Journal Entries ==========");
        foreach (JournalEntry journal in _journal)
        {
            journal.Display();
        }
    }
}