class Word
{
    private string _word;
    private bool _isVisible;

    public Word(string word)
    {
        _word = word;
        _isVisible = true;
    }

    public void DisplayWord()
    {
        if (_isVisible)
        {
            Console.Write(_word);
        }
        else
        {
            Console.Write(new string('_', _word.Length));
        }
    }

    public void HideWord()
    {
        _isVisible = false;
    }

    public bool IsVisible()
    {
        return _isVisible;
    }

        public void RevealWord()
    {
        _isVisible = true;
    }
}
