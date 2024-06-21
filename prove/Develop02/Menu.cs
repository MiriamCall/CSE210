using System;

class Menu
{
    private int choice = 0;

    private Journal _journal = new Journal();
    
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
                Entry _entry = new Entry();
                // Add Entry
                    _entry.MakeEntry();
                    _entry.DisplayEntry();
                    _journal.AddEntry(_entry);
                    break;
                case 2:
                // Display Entries
                    _journal.DisplayEntries();
                    break;
                case 3:
                // Save Journal
                _journal.SaveJournal("journal.txt");

                break;
                case 4:
                // Load Journal
                _journal.LoadJournal("Journal.txt");
                break;
                case 5:
                // Exit
                Environment.Exit(0);
                break;
            }
        }
        }
        
    }

}