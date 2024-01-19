using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (num != 0 )
        {
            Console.WriteLine("Enter number: ");
            num= int.Parse(Console.ReadLine());
        
            if(num !=0 )
            {
            numbers.Add(num);
            }
            
        }  

        //Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Compute the average
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the max

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}      
    