using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");
            
            string input = System.Console.ReadLine();

            Console.WriteLine("You have currently excercised " + input + " minutes. Good job! :)");

            //Add minutes exercised to total
            //Display total minutes exercised to the screen
            //Repeat until the user quits
        }
    }
}
