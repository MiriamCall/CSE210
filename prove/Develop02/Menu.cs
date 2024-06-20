using System;

class Menu
{
    private int choice = 0;

    private Journal _journal = new Journal();
    private Entry entry = new Entry();
    
    public void DisplayMenu()
    {
        while (choice !=5) 
        {
        Console.WriteLine("1. Add Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Exit");

        string input = Console.ReadLine();
        if(int.TryParse(input, out choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"_question");
                    break;
                case 2:
                    _journal.DisplayEntries();
                    break;
                case 3:
                break;
                case 4:
                break;
            }
        }
        }
        
    }

}