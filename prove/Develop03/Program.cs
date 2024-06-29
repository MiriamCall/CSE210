/*******************************************************************************************
* Source Program:
*   Scripture Memorization App
* Source Files:
*   Program.cs, Scripture.cs, Reference.cs, Word.cs
* Author:
*    Miriam Call
* Assistance:
*    Brother Godderidge, Grant Call, GitHub Copilot
* Summary:
*    The Scripture Memorization App helps users memorize scriptures by progressively
*    hiding words based on selected difficulty, Easy, Medium, Hard, and Legendary.
*    Users are presented with a scripture and words are hidden as they progress, promoting
*    memorization through repetition and recall. The process continues until the user
*    quits or memorizes the scripture fully, receiving a congratulatory message. This
*    method leverages active recall and spaced repetition, enhancing memorization.
* Extra Enhancements:
*    - Added levels of difficulty: Easy, Medium, Hard, and Legendary
*********************************************************************************************/

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", "3:7");
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        Scripture scripture = new Scripture(reference, text);
        Console.WriteLine("Welcome to the Scripture Memorization Program!\n");

        Console.WriteLine("Choose difficulty level:");
        Console.WriteLine("1. Easy (Hide one word at a time)");
        Console.WriteLine("2. Medium (Hide three words at a time)");
        Console.WriteLine("3. Hard (Hide six words at a time)");
        Console.WriteLine("4. Legendary (All words are hidden from the start!)");
        Console.Write("Enter your choice (1, 2, 3, 4): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid input. Please enter 1, 2, 3, or 4");
            Console.Write("Enter your choice (1, 2, 3, 4): ");
        }

        int wordsToHide = 100;
        switch (choice)
        {
            case 1:
                wordsToHide = 1;
                break;
            case 2:
                wordsToHide = 3;
                break;
            case 3:
                wordsToHide = 6;
                break;

            case 4:
                scripture.HideAllWords();
                break;
            default:
                wordsToHide = 1; // Default to easy level
                break;
        }

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

            scripture.RandomlyHideWords(wordsToHide);

            // Check if all words are hidden
            if (!scripture.HasVisibleWords())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nCongratulations! You have removed all the words and memorized the scripture.\n");
                break;
            }
        }
    }
}