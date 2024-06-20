using System;
class Entry 
{
    private List<string> _questions;
    private int _questionIndex;

    private string _response;

    private DateTime _date;

    // Constructor for Entry. Initializes the list of questions.
    public Entry()
    {
        _questions = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    // AddDate method that sets the date to the current date and time.
    public void AddDate()
    {
       
    }

    // AddResponse method that sets the response to the user's input.
    public void AddResponse()
    {
        
    }

    // GenerateRandomIndex method that generates a random question index.
    public void GenerateRandomIndex()
    {
        
    }

    // DisplayQuestion method that displays the question at the current question index.
    public void DisplayQuestion()
    {
        
    }

    public void DisplayDate()
    {
        
    }

    // DisplayResponse method that displays the response.
    public void DisplayResponse()
    {
        
    }

    // DisplayEntry method that displays the date, question, and response.
    public void DisplayEntry()
    {
        DisplayDate();
        DisplayQuestion();
        DisplayResponse();
    }

    // MakeEntry method that adds the date, 
    // displays the questions,
    // generates a random question, 
    // and adds the response.
    public void MakeEntry()
    {
        AddDate();
        GenerateRandomIndex();
        DisplayQuestion();
        AddResponse();
    }

}