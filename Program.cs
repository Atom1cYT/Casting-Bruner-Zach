using System;

namespace Casting_Bruner_Zach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks user to enter a whole number and assigns input to integer
            Console.WriteLine("Please enter a whole number!");
           int myFavNum = Convert.ToInt32(Console.ReadLine());
            // Prints favorite number to console
            Console.WriteLine("Your favorite number is " + myFavNum);
            // Asks user a true or false questions and assigns response to boolean
            Console.WriteLine ("Do you like video games?  (please enter  'true' or 'False')"); 
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            // Print the result of the questions asked
            Console.WriteLine($"It is {isTrue} that I like video games!");
        
        }
    }
}