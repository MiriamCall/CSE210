class Reference
{
    private string _book;
    private string _verse;

    public Reference(string book, string verse)
    {
        _book = book;
        _verse = verse;
    }

    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_verse}");
    }


}

// Reference()
// "1 Nephi 3:7"

// CreateReference()
// // Get and Set

// DisplayReference()