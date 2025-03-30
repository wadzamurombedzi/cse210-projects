// It keeps track of the book, chapter and verse 
// of the scripture reference.

public class DisplayReference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private string _theVerse;

    public DisplayReference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
    }

    public DisplayReference (string book, int chapter, int verse, int verses)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verses;
        _verseEnd = verses;
    }

    public string GetFormattedReference()
    {
        if (_verseEnd == 0)
        {
            return $"{_book} (_chapter);{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }

    public void SetVerse()
    {
        _theVerse = Console.ReadLine();
    }

    public string GetTheVerse()
    {
        return _theVerse;
    }
    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verseStart;
    }
    public int GetVerses_E()
    {
        return _verseEnd;
    }
}