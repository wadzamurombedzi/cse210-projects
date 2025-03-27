using System;

// Personal employment information
public class JournalEntry
{
    // C# rule = always start a member variable with an _underscore
    public int _entryNumber = 0;
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalEntry = "";

    public JournalEntry()
    {
    }

    // Method that displays the person's full name 
    public void Display()
    {
        Console.WriteLine($"\n{_dateTime}");
        Console.WriteLine($"Prompt: {_journalEntry}");
    }
}