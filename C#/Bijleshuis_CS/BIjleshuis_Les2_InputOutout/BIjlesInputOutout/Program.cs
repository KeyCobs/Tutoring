using System;
using System.Collections.Generic;

namespace BIjlesInputOutout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keuze;
            List<string> nummers = new List<string>();

           

            for (int i = 0; i < 3; i++)
            {
                keuze = Console.ReadLine(); 
                nummers.Add(keuze);
            }

            //     i = 0     zolang 10 < 10 gaan wij i - 1
            for (int i = nummers.Count; i > 0; i--)
            {
                //ronde 1: i= 10
                //ronde 2: i = 9
                Console.WriteLine(nummers[i]);
            }



            int nummer = 3;
            Num(3);
        }

        static public int Num(int x) //x = 3
        {
            x += 5;

            return x;
        }
    }
}
