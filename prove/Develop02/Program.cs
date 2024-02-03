/*Edwin Hared Albancando Robles*/
using System;

class Program
    {
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
                "Did you learn something new today? ",
                "What is a good advice you will give to someone? ",
                "What is the favorite part of your day? ",
                "What was something exciting you did today? ",
                "What is a challenge you have experinced and how you have overcome it? ",
                "How was your day?"                
        };
/* created a boolean to run while it's true (Has a value between 1-5)*/
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nWelcome to your Journal");
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                string prompt = GetRandomPrompt(prompts);
                journal.AddEntry(prompt);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if ( choice == "3")
            {
                journal.LoadFromFile();
            }
            else if (choice == "4")
            {
                journal.SaveToFile();
            }
            else if ( choice =="5")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine ("Invalid Choice");
            }
        }
            Console.WriteLine("See you next time!");
    }
/*Used the function random, to display a random prompt to user*/
    static string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
