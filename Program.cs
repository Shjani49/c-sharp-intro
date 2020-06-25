using System;

namespace c_sharp_intro
{

    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter a number");
            int userInt = Int32.Parse(Console.ReadLine());
            if (  userInt > 10)
            {
                Console.WriteLine("Greater than 10.");
            }
            else if (  userInt > 5)
            {
                Console.WriteLine("Greater than 5 and less than 11.");
            }
            else if (  userInt < 0)
            {
                Console.WriteLine("A negative Number");
            }
            else
            {
                Console.WriteLine("Number is between 0 to 5");
            }
        }
    }
}

    

