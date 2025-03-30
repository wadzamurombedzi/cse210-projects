using System;
using System.Collections.Generic;

public class Scripture
{
    private DisplayReference _theRef;
    private ScriptureWord theText;
    private List<string> _listVerse = new();
    private List<string> _hiddenwords = new();
    private string[] _text;
    public Scripture(DisplayReference reference)
    {
        _theRef = reference;
        _text = _theRef.GetTheVerse().Split(" ");
        foreach (string word in _text)
        {
            theText = new ScriptureWord(word);
            _listVerse.Add(theText.GetRenderedText());
        }
    }

    public void HideWord (int number)
    {
        Random random = new();

        for (int x = 0; x < number; x++)
        {
            int randNum = random.Next(_listVerse.Count());
            string removeWord = _listVerse[randNum];

            if (removeWord != "_")
            {
                _hiddenwords.Add(removeWord);
            }
            if(removeWord == "_")
            {
                if(removeWord == "")
                {
                    randNum = random.Next(_listVerse.Count());
                }

                _listVerse.RemoveAt(randNum);
                theText.Hide();
                _listVerse.Insert(randNum, theText.GetRenderedText());
            }
        }
    }

    public bool IsAllWordHidden()
    {
        bool isIt = false;
        bool result = _listVerse.All(word => word == "");
        if(result)
        {
            isIt = true;
        }
        return isIt;
    }

    public void DisplayText()
    {
        string theRef = _theRef.GetFormattedReference();
        Console.WriteLine($"\n{theRef}\n{string.Join("", _listVerse)}\n");
    }
}