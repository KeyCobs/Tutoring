using System;
using System.Collections.Generic;

namespace List_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string stop = "Stop";
            List<string> names = new List<string>();
            string input = Console.ReadLine();

            while (input != stop) //check 
            {
                names.Add(input); // opslaan
                input = Console.ReadLine(); // invoer

            }

            names.Sort();


            foreach (string elem in names)
                Console.WriteLine("Names are: {0}", elem);

            foreach(string elem in names)
            {

            }

        }
    }
}
