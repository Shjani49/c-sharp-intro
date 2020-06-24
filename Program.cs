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
        }
    }
}
