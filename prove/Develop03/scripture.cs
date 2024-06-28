class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void Display()
    {
        _reference.DisplayReference();
        foreach (Word word in _words)
        {
            word.DisplayWord();
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public void HideAllWords()
    {
        foreach (Word word in _words)
        {
            word.HideWord();
        }
    }

    // Hide words randomly with a check for remaining words
    public void RandomlyHideWords(int numberToHide)
    {
        if (numberToHide == 100)
        {
            HideAllWords();
        }
        else
        {
            List<Word> visibleWords = _words.Where(word => word.IsVisible()).ToList();
            int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

            for (int i = 0; i < wordsToHide; i++)
            {
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].HideWord();
                // Remove the word from the list to avoid hiding it again
                visibleWords.RemoveAt(index);
            }
        }
    }

    // Reveal a random word
    public void RevealWord()
    {
        List<Word> hiddenWords = _words.Where(word => !word.IsVisible()).ToList();
        if (hiddenWords.Any())
        {
            int index = _random.Next(hiddenWords.Count);
            hiddenWords[index].RevealWord(); // Assuming RevealWord() changes the visibility state of the word to visible
        }
    }

    // Check if there are any visible words left
    public bool HasVisibleWords()
    {
        return _words.Any(word => word.IsVisible());
    }
}