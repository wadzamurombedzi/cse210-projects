// The ScriptureWord has methods show thw word or hide and also verify 
// if it is hidden.

public class ScriptureWord
{
    private string _theWord;
    private bool _isHidden;

    public ScriptureWord(string text)
    {
        _theWord = text;
        _isHidden = false;
    }

    public string GetRenderedText()
    {
        if(_isHidden == true)
        {
            _theWord = "_";
        }
        return _theWord;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }
}