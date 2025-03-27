using System;

public class JournalPrompt
{
    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the most strongest emotion I felt today?",
        "Did you read the Bible today?",
        "What did you have for lunch today?",
        "How many liters of water do you take a day?",
        "How many meals do you have a day?",
        "What did you had for breakfast?",
        "What is your favorite dish?"
    };

    public List<string> _journalPrompt = new List<string>(_prompt);
    public JournalPrompt()
    {
    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine("\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];

        return journalPrompt;
    }
}