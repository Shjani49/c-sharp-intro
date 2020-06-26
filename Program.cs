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
            // We can use a foreach to iterate through the list to lists, one list at a time.
            foreach( string topic in topics )
            {
                   // Let's loop through this specific sub-list.
                   // for(int i=0; i< topic.Length; i++)
                    //{
                        // Output the current animal !
                        Console.WriteLine(" This animal: {0}",topic);
                   // }
                    
            }
        }
    }
}



