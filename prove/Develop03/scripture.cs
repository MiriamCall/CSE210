// Got help from ChatGPT
class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();

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

    // public bool HideWords()
    // {
    //     Random random = new Random();
    //     List<_words> wordsToHide = _words.Where(wordsToHide => !wordsToHide.IsHidden).ToList();
    //     if (visibleWords.Count == 0)
    //     {
    //         return false;
    //     }

    //     int wordsToHide = Math.Min(3, visibleWords.Count);
    //     for (int i =0; i < wordsToHide; i++)
    //     {
    //         Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
    //         wordToHide.Hide();
    //         visibleWords.Remove(wordToHide);
    //     }
    //     return true;
    // }
}
