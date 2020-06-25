﻿using System;

namespace c_sharp_intro
{

    class Program
    {
        static void Main(string [] args)
        {
            int myNum = 3;
            while(myNum > 0) //Iterates/loops while the CONDITION IS TRUE.
            {
                    Console.WriteLine("Current number is : {0}", myNum);
                    myNum --;

            }

            /* For loops have 3 semi-colon-separted Components:
                1) Assignment
                2) [Termination]Condition
                3) Iteration
            */
            for(int i = 0; i < 6; i+= 2)
            {
                Console.WriteLine("Current (for) number is : {0}", i);
            }

            // If we need to iterate through a list, use foreach!
            string[] myList = { "cat", "turtle", "frog", "dog","lizard"} ;
            foreach ( string listItem in myList)
            {
                Console.WriteLine(" The current item is :{0}", listItem);

            }

        }
    }
}

    

