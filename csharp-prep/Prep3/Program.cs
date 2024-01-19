using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        int guess_number = -1;
        

        while ( guess_number != magic_number)
        {
            Console.WriteLine("what is your guest? ");
            guess_number = int.Parse(Console.ReadLine());

            if (guess_number > magic_number)
            {
            Console.WriteLine("lower ");
            }
            else if (guess_number< magic_number)
            {
            Console.WriteLine("higher");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }



    }
}