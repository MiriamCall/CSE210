using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference reference = new Reference("1 Nephi", "3:7");
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        
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
            // else{
            //     if (!scripture.HideWords())
            //     {
            //         break;
            //     }
            // }
        }
        Console.WriteLine("Congratulations! You have removed all the words and memorized the scripture. ");
        // DisplayMenu()

        // ClearConsole()

        // Quit()
    }
}