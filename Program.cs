using System;

namespace c_sharp_intro
{

    class Program
    {
        static void Main(string[] args)
        {
            // 2 dimensional array !
           string[,] topics = { {"cat", "dog", "frog", "hedgehog"},
                                {"zebra","giraffe","lion","elephant"},
                                {"dolphine","octous","Shark","whale" }};
            // Loop through the rows...
            for( int row = 0; row<topics.GetLength(0); row++)
            {
                // Output Current Row...
                Console.WriteLine(" Starting row #{0}", row);  
                // Loop through columns in the current row...
                for(int column =0; column< topics.GetLength(1); column++)
                {
                    // Output Current Column...
                    Console.WriteLine(" Starting column #{0}", column);
                    // Output the current animal !
                    Console.WriteLine(" This animal: {0}",topics[row,column]);   
                } 
            }
        }
    }
}



