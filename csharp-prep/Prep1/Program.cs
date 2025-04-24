using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("Please enter a grade: ");
        string grade = Console.ReadLine();

        if (int.Parse(grade) >= 90){
            Console.WriteLine("Your grade equates to an A");
        }
        
    }
}