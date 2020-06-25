﻿using System;

namespace c_sharp_intro
{

    class Program
    {
        static void Main(string [] args)
        {
            // "=" is the assignment operator!
            // String datatype is used for text.
            string mystring = "This is a string";
            Console.WriteLine("Your Message is:"+ mystring );
            //Integer datatype is used for whole numbers(no decimals.)
            int myInt = 42;
            Console.WriteLine("Your Number is:"+ myInt );
            // Double datatype is used for decimal point numbers.
            double myDouble = 33.666;
            Console.WriteLine("Your Number is:"+ myDouble );
            //Boolean datatype is used for TRUE/FALSE values - think binary!
            bool myBool = true;

            // Subtraction operator is "-" (minus)
            Console.WriteLine(myInt - 10); //32

            //Mutiplication operator is "*" (multiply)
            Console.WriteLine(myInt*2); //84

            //Division operator is "/"(division")
            Console.WriteLine(myInt/2); //21

            // Modulus operator is "%"n(percent sign)
            Console.WriteLine(myInt % 13); //3

            // Addition operator is "+" (plus)
            // ***WAIT ! this is ALSO the concatenation opertor.
            Console.WriteLine(myInt + 8); //50

            Console.WriteLine("3" + "3"); //33

            Console.WriteLine("3" + 3); //??? 33
            Console.WriteLine(3 + "3"); ///??? 33
            Console.WriteLine(6 + 3 + "3"); ///??? 93

            //Output our variable.
            Console.WriteLine(myInt); // 42

            // A new assignment on existng variable.
            myInt = myInt +2 ;// 44
            Console.WriteLine(myInt); // 44

            //myInt = myInt + "2"; //We can't turn myInt into a string
            // We told C# that myInt would always be an int!

            myInt++; //The same as typing: myInt = myInt +1 ;
            Console.WriteLine(myInt); // 45
            myInt--; //The same as typing: myInt = myInt - 1 ;
            Console.WriteLine(myInt); // 44

            myInt += 3; // The same as typing: myInt = myInt +3 ;
            Console.WriteLine(myInt); // 47

            myInt -= 5; // The same as typing: myInt = myInt -5 ;
            Console.WriteLine(myInt); // 42




        }
    }
}
    

