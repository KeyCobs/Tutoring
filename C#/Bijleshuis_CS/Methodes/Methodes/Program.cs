using System;
using System.Collections.Generic;

namespace Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recap();

            //OefnSamen();
           // ExerciseMethods();
            ArrayAndListErrors();
            string[] naam = new string[5];
        }

        static public void OefnSamen()
        {
            Console.WriteLine("Voer een getal.");
            Console.WriteLine("1 naam");
            Console.WriteLine("2 voeg toe");
            Console.WriteLine("3 exit");
            List<string> namen = new List<string>();
            GeefNaam(); //returned naam

            //Voeg naam toe
            //print alle namen
        }

        static public string GeefNaam()
        {
           
            string naam = Console.ReadLine();
            return naam;
        }

        #region ErrorHandling

        static public void VariableErrors()
        {
            //int 4getllen = 4000;
            //int number = "3";
            //in getal = 2;
            //string name = "Name"
            //bool isActive = true;
        }
        static public void ArrayAndListErrors()
        {
            //Array[] arr = new Array[3];
            //Console.WriteLine(arr[2]);

            //List<string> list = new List<string>();
            //List<string>< l = new List<string,int>();

            //List<string> ml = new List<string> { "k", "j", "c" };
            //ml += "h";
            //ml.Add("h");
            ////ml.Remove;
        }
        //static public void MethodsError()
        //{
        //    Methode1();
        //    Methode2();
        //}

        public void Methode1()
        {
            return;
        }

        public int Methode2()
        {
            int vier = 4;
            if (2 == 3)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }
        #endregion

        #region methods
        static public void ExerciseMethods()
        {
            List<String> namen = new List<string>();

            PrintMenue();
            string input = Console.ReadLine();
            while (InputChoice(input))
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Please give me a name.");
                        namen.Add(AddName());
                        break;
                    case "2":
                        PrintNames(namen);
                        break;
                    default:
                        Console.WriteLine("Default was called please write a number 1,2,3");
                        break;
                }

                PrintMenue();
                input = Console.ReadLine();

            }

        }
        static public bool InputChoice(string input)
        {
            bool exit = Convert.ToInt32(input) == 3;
            return !exit;
        }
        static private string AddName()
        {
            return Console.ReadLine();
        }
        static private void PrintMenue()
        {
            Console.WriteLine("Please enter a number\n\n1:AddName\n2:Print all names\n3:Exit");
        }
        static private void PrintNames(List<string> n)
        {
            foreach (string e in n)
            {
                Console.Write(e + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        #endregion
        static public void Recap()
        {
            List<string> namen = new List<String> { "Kevin", "Charles", "Emille", "Rik", "Emma", "Lea" };
            #region antwoord 1
            Console.WriteLine(namen[3]);
            #endregion

            List<string> boodschappenlijst = new List<string> { "Appel", "melk", "vlees", "groente", "Water", "slagroom", "chips" };
            boodschappenlijst.Add(Console.ReadLine());
            boodschappenlijst.RemoveRange(2, 4);
            boodschappenlijst.Add("eieren");
            Console.WriteLine(boodschappenlijst[2]);
            foreach (var e in boodschappenlijst)
            {
                Console.WriteLine(e);
            }
            #region antwoord 2
            /*         
            chips
            Appel
            melk
            chips
            bessen
            eieren
             */
            #endregion
        }
    }
}
