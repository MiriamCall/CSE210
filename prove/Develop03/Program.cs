using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");


        DisplayMenu()

        ClearConsole()

        Quit()
    }
}




using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Example scripture
        Reference reference = new Reference("Proverbs", "3:5-6");
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        Scripture scripture = new Scripture(reference, text);
        
        while (true)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                if (!scripture.HideRandomWords())
                {
                    break;
                }
            }
        }

        Console.WriteLine("All words are hidden. Program will now exit.");
    }
}

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (Word word in _words)
        {
            Console.Write(word + " ");
        }
    }

    public bool HideRandomWords()
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden).ToList();

        if (visibleWords.Count == 0)
        {
            return false;
        }

        int wordsToHide = Math.Min(3, visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }

        return true;
    }
}

class Reference
{
    private string _book;
    private string _verse;

    public Reference(string book, string verse)
    {
        _book = book;
        _verse = verse;
    }

    public override string ToString()
    {
        return $"{_book} {_verse}";
    }
}

class Word
{
    private string _text;
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        _text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : _text;
    }
}
