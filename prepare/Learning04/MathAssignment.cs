class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problemSet;

    public MathAssignment(string name, string topic, string textbookSection, string problemSet) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problemSet = problemSet;
    }

    public string GetHomeWork()
    {
        return $"Section {_textbookSection} Problem Set {_problemSet}";
    }
}