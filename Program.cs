//Author: Garett Hicks
//Date: 2/6/2020
//Comments: This C# console application code demonstrates the use of arrays without user input. 

using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] my_array = new int[25];
                int fill_array = 0;
                int show = 1;

                foreach (int i in my_array)
                {
                    my_array[i] = fill_array;
                    Console.WriteLine("Element Value = " + show);
                    show += 1;
                }

            } //end of try
            catch
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
