using System;

class Program
{
    static void Main(string[] args)
    {
                Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;


        while (guess != magicNumber)
        {
            Console.Write("What is the number? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("The number is HIGHER than that");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("The number is LOWER than that");
            }
            else
            {
                Console.WriteLine("Correct! *cue Final Fantasy V victory theme yet again lol*");
            }
        }
    }
}