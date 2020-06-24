using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two slashes mark the beginning of a single-line comment.
            // We are assigning a string value to a variable.
            string myName = "Shivani Jani";
            /* We begin multi-line comments eith a forward-slash and asterisk...

            Symbols between values or evaluations are considerd "operators."
            Below we are using the addition symbol to concatenate two strings.
            (Concatenatations means gluing two strings, or texts, together.)

            ...and We end multi-line comments with an asterisk followed by a forward-slash */
            Console.WriteLine("Hello, " + myName);

            Console.WriteLine("Please Enter Your Name...");
            // Assign variable 'userName' to a value entered by the user.
            string userName = Console.ReadLine();
            //Show the user we colleted the name.
            Console.WriteLine("You have entered: " + userName);
            // Instead of traditional concatenation using the addition opeartor...
            // We can use string interpolation(placeholder) to embed values in a string!
            Console.WriteLine("Hey {0}, You're Looking Great Today!", userName);
        }
    }
}
