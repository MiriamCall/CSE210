// Got help from ChatGPT
class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(_words => new Word(word)).ToList();

    }

    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (Word word in _words)
        {
            Console.WriteLine(word);
        }
    }

    public bool HideWords()
    {
        Random random = new Random();
        List<_words> wordsToHide = _words.Where(wordsToHide => !wordsToHide.IsHidden).ToList();
        if (visibleWords.Count == 0)
        {
            return false;
        }

        int wordsToHide = Math.Min(3, visibleWords.Count);
        for (int i =0; i < wordsToHide; i++)
        {
            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
        return true;
    }
}

// Scripture()
// "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."

// CreateScripture()
// // Get and Set

// DisplayWords()

// DisplayScripture()

// HideWords()