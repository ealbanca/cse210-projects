using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        string user_entry= Console.ReadLine();

        int x = int.Parse (user_entry);
        
        if (x >= 90)
        {
            Console.Write("A");
        }
        else if (x>=80)
        {
            Console.Write("B");
        }
        else if(x>= 70)
        {
            Console.Write("C");
        }
        else if (x >= 60)
        {
            Console.Write("D");
        }
        else if (x < 60 )
        {
            Console.Write("F");
        }
    }
}