using System;

namespace c_sharp_intro
{

    class Program
    {
        static void Main(string[] args)
        {
            // Guide the User...
            Console.WriteLine("Please enter add/subtract/multiply/exit:");

            // collect the user Input...
            string userInput;
            while ((userInput = Console.ReadLine()) != "exit") // Loops Until a user enters "exit" command.
            {
                // Switch statements are similar to if/else.
                switch (userInput) // Here we enter the value we want to test
                { // Cases are us telling the above against specific values.
                    case "add":
                        Console.WriteLine("Please enter first Number:");
                        int firstNum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter Second Number:");
                        int secondNum = Int32.Parse(Console.ReadLine());
                        int result = firstNum + secondNum;
                        Console.WriteLine(" The Addition is {0} + {1} = {2}", firstNum, secondNum, result);
                        break;
                    case "subtract":
                        Console.WriteLine("Please enter first Number:");
                        int firstNum1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter Second Number:");
                        int secondNum1 = Int32.Parse(Console.ReadLine());
                        int result1 = firstNum1 - secondNum1;
                        Console.WriteLine(" The subtraction is {0} - {1} = {2}", firstNum1, secondNum1, result1);
                        break;
                    case "multiply":
                        Console.WriteLine("Please enter first Number:");
                        int firstNum2 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter Second Number:");
                        int secondNum2 = Int32.Parse(Console.ReadLine());
                        int result2 = firstNum2 - secondNum2;
                        Console.WriteLine(" The Multiplication is {0} * {1} = {2}", firstNum2, secondNum2, result2);
                        break;
                    default:
                        Console.WriteLine(" Unrecognized operator/command entered.");
                        break;
                }// End of switch statement.
                Console.WriteLine("please enter a new command : add/subtract/multiply/exit.");

            }//End of while statement.

        }
    }
}



