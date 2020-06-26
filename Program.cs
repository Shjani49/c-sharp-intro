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
                    int firstNum = Int32.Parse( Console.ReadLine() );
                    Console.WriteLine(" Enter the Second Number to add: ");
                    int secondNum= Int32.Parse( Console.ReadLine() );
                    result = Addition( firstNum,secondNum );
                    Console.WriteLine("The result is :{0}",result);

                }
                else if( command == "subtraction")
                {
                     Console.WriteLine(" Enter the first Number to sub: ");
                    int firstNum = Int32.Parse( Console.ReadLine() );
                    Console.WriteLine(" Enter the Second Number to sub: ");
                    int secondNum= Int32.Parse( Console.ReadLine() );
                    result = Subtraction( firstNum,secondNum );
                    Console.WriteLine("The result is :{0}",result);
                }
                else if( command == "multiplication")
                {
                    Console.WriteLine(" Enter the first Number to sub: ");
                    int firstNum = Int32.Parse( Console.ReadLine() );
                    Console.WriteLine(" Enter the Second Number to sub: ");
                    int secondNum= Int32.Parse( Console.ReadLine() );
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
        
    }
}



