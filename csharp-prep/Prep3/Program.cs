using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // Random number generator
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        // User picks magic number
        // Console.WriteLine("What is the magic number?");
        // int magicNumber = int.Parse(Console.ReadLine());

        int guess = 0;
        
        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            
            if (magicNumber > guess)
            {Console.WriteLine("Higher");
            }
            else if (magicNumber < guess){
                Console.WriteLine("Lower");

            }
            else{
                Console.WriteLine("You Guessed it!");
            }

        }
    }
}