using System;
using System.Collections.Generic;

namespace Chalres_Test_Answers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] namen = new string[5];

            //for (int i = 0; i < namen.Length; i++)
            //{
            //    namen[i] = Console.ReadLine();
            //}

            //foreach (string item in namen)
            //{
            //    Console.Write(item + " ");
            //}


            List<song> listSong = new List<song>();
            string input = "";

            while (input != "s")
            {
                song s = new song();
                Console.WriteLine("Voeg een titel van een nummer toe.");
                s.m_Titel = Console.ReadLine();


                Console.WriteLine("Wie schreef dit nummer?");
                s.m_Artist = Console.ReadLine();

                Console.WriteLine("Druk op s om te stoppen iets anders om verder tegaan");
                input = Console.ReadLine();
                listSong.Add(s);
            }

            CheckQueenSong(listSong);


        }
        static public void CheckQueenSong(List<song> s)
        {
            int c = 0;
            for (int i = 0; i < s.Count; i++)
            {
                if (s[i].m_Artist == "queen")
                {
                    c++;
                }
            }
            string[] s = new string

            if (c == 1)
            {
                Console.WriteLine("a");
            }
            else if (c > 1)
            {
                Console.WriteLine("b");
            }
            else
            {
                Console.WriteLine("c");
            }

        }
    }
}
