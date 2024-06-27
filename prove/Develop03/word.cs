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
       
        Console.Write(_word);
        
        
    }

    public void Hide()
    {
        _isVisible = false;
    }

    
    
    
    
    
    // public void HideThreeWords()
    // {
    //     Random random = _words.Where(Word => Word.IsVisible).ToList();

    //     for (int i = 0; i < Math.Min(3, visibleWords.Count); i++)
    //     {
    //         int indexToHide = random.Next(visibleWords.Count);
    //         visibleWords[indexToHide].ToggleVisiblility();
    //         visibleWords.RemoveAt(indexToHide);
    //     }
    // }


    // public override string ToString()
    // {
    //     if (_isVisible)
    //     {
    //         return new string('_', _word.Length);
    //     }
    //     else
    //     {
    //         return _word;
    //     }
    // }
}

// CreateWord()
// // Get and Set

// DisplayWord()