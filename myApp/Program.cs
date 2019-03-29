using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for minutes exercised
            System.Console.Write("Enter how many minutes you exercised: ");
            
            string input = System.Console.ReadLine();

            System.Console.Write("Mintes exercised: " + input);

            //Add minutes exercised to total
            //Display total minutes exercised to the screen
            //Repeat until the user quits
        }
    }
}
