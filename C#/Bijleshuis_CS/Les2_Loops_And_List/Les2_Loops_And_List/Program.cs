using System;
using System.Collections.Generic;

namespace Les2_Loops_And_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oplossing oefening thuis
            string inputName = Console.ReadLine();
            string name = "Jan";
            Random random = new Random();
            int rand = random.Next(0, 120);
            string trueanswer = name + " is vandaag " + rand + " oud geworden";
            string FalseAnswer = "naam is " + inputName;
            if (inputName == name)
            {
                Console.WriteLine(trueanswer);
            }



            //oefening 1

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine(); // for enter next exercise

            //oefening 2

            int input = int.MinValue;
            while (input > 10 || input < 0)
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(input);



            //Arrays/Lists
            //Oefening 1
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int elem in numbers)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            //oefening 2
            List<string> namesList = new List<string> { "Ann", "Kevin", "Charles", "Tonia", "Cedric" };
            string greeting = "Welkom terug " + namesList[random.Next(0, namesList.Count - 1)];
            Console.WriteLine(greeting);




            ////Tic Tac Toe
            ////Variables
            //int[,] field = new int[3, 3] { {1,2,3 },{4,5,6 },{7,8,9 } };

            //Random tegenspeler = new Random();
            //bool isWinnaar = false;


            ////while (!isWinnaar)
            ////{
            //    PrintField(field);
            ////}



        }

        //static public void CheckWinnaar(int[,] f)
        //{
        //    //horizon
        //    for (int i = 0; i < 3; i++)
        //    {
               
        //    }
        //}

       static public void PrintField(int[,] f)
        {
            //print het veld uit
            for (int i = 0; i < f.GetLength(0); i++)
            {
                for (int j = 0; j < f.GetLength(1); j++)
                {
                    Console.Write(f[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
