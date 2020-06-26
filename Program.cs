using System;

namespace c_sharp_intro
{

    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user.
            Console.WriteLine("please type: (add/subtraction/multiplication/exit)");
            string command;// Declare a variable.
            // Accept Commands.
            while ( ( command = Console.ReadLine()) != "exit" )
            {
                int result;
                if( command == "add")
                {
                    Console.WriteLine(" Enter the first Number to add: ");
                    int firstNum = CollectIntFromUser();
                    Console.WriteLine(" Enter the Second Number to add: ");
                    int secondNum= CollectIntFromUser();
                    result = Addition( firstNum,secondNum );
                    Console.WriteLine("The result is :{0}",result);

                }
                else if( command == "subtraction")
                {
                     Console.WriteLine(" Enter the first Number to sub: ");
                    int firstNum = CollectIntFromUser();
                    Console.WriteLine(" Enter the Second Number to sub: ");
                    int secondNum= CollectIntFromUser();
                    result = Subtraction( firstNum,secondNum );
                    Console.WriteLine("The result is :{0}",result);
                }
                else if( command == "multiplication")
                {
                    Console.WriteLine(" Enter the first Number to sub: ");
                    int firstNum = CollectIntFromUser();
                    Console.WriteLine(" Enter the Second Number to sub: ");
                    int secondNum= CollectIntFromUser();
                    result = Multiplication( firstNum,secondNum );
                    Console.WriteLine("The result is :{0}",result);
                }
                else 
                {
                    Console.WriteLine("Invalid Command,Pleae try again");
                }
                Console.WriteLine("Please try again: add/subtract/multiply/exit");
            }// End of While Loop.
        }
        static int Addition( int num1, int num2)
        {
            return num1 + num2;
        }
        static int Subtraction( int num1, int num2)
        {
            return num1 - num2;
        }
        static int Multiplication( int num1, int num2)
        {
            return num1 * num2;
        }

        static int CollectIntFromUser()
        {
            int intValue =0;
            bool error = true;
            while ( error == true)
            {
                string userValue = Console.ReadLine();
                try // Wrap potentially-failing code in a try - this will prevent an unhandled exception (fatal error for your program.)
                {
                     intValue = int.Parse(userValue); // attempt to convert the string..
                     error = false; // If we get here, we're good to return the int!
                    
                }
                catch ( Exception exception )
                { // We use "catch" to decide what happens if the "try" has an error !
                    Console.WriteLine("Inavalid value Entered. Please enter a number: "); 
                    Console.WriteLine(exception.Message); // The exception has its own error message - helpful to know what is failing!
                }
            }// End of the while loop.
            return intValue; // Ends execution of the method, and passesthe value back.
        }
        
    }
}



