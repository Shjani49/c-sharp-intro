using System;

namespace c_sharp_intro
{

    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Please tell us if you want to add or subtract: (add/ subtract)");
            string userOperator = Console.ReadLine();
            // Check if the use typed: add
            if( userOperator == "add")
            {
                Console.WriteLine("Please enter the first number: ");
                // @Link : https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                int firstNum = Int32.Parse(Console.ReadLine()); // Convert string to integer.

                Console.WriteLine("Please enter the second number: ");
                int secondNum = Int32.Parse(Console.ReadLine()); // Convert string to integer.
                // Calculate the result
                int result = firstNum + secondNum ;
                Console.WriteLine("{0} + {1} = {2}",firstNum, secondNum, result);
            }
            // Check "else" if user did not typed 
            else if( userOperator == "subtract")
            {
                Console.WriteLine("Please enter the first number: ");
                // @Link : https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                int firstNum = Int32.Parse(Console.ReadLine()); // Convert string to integer.

                Console.WriteLine("Please enter the second number: ");
                int secondNum = Int32.Parse(Console.ReadLine()); // Convert string to integer.
                // Calculate the result.
                int result = firstNum - secondNum ;
                Console.WriteLine("{0} - {1} = {2}",firstNum, secondNum, result);
                
            }
        }
    }
}

    

