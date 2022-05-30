using System;

namespace Bijleshuis_Les1_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bijles les 1
            //Console.Write(Formule(5) + "\n");

            //Bijles les 2
            Variabelen();
            ExerciseIfElse();

        }

        static private void DayOfTheWeek()
        {
            #region Methode 1
            DateTime dt = new DateTime();
            dt = dt.AddYears(1999 - 1);
            dt = dt.AddDays(28 - 1);
            dt = dt.AddMonths(3 - 1);
            Console.WriteLine(dt + " " + dt.DayOfWeek);
            #endregion
            #region Methode 2 (beste)
            DateTime dt2 = new DateTime(1999, 3, 28);
            Console.WriteLine(dt2 + " " + dt2.DayOfWeek);
            #endregion
        }
        static private double Formule(int num)
        {
            //x^2 - 5x + 4
            int x = 0;
            #region method 1
            int pwerOf = 2;
            for (int i = 1; i < pwerOf; i++)
            {
                int t = num;
                x += num * num;
            }
            int right = num * 5;
            right += 4;

            x -= right;
            Console.WriteLine(x);
            #endregion
            #region Method 2
            x = 0;
            double result = (Math.Pow(num, 2)) - ((5*num) + 4);
            Console.WriteLine(result);
            #endregion
            #region Method 3 (beste)
            return (Math.Pow(Convert.ToDouble(num), 2.0)) - ((5 * num) + 4);
            #endregion
        }
        static private void Variabelen()
        {
            Console.WriteLine("Oefening 1:");
            //Zoek de fouten
            string stringVar = "string \"Dit is een zin\" "; // de \ wordt geschreven zodat je " " kan schrijven in een string
            string stringCor = "string name = \"Dit is een zin\"";
            Console.WriteLine(stringVar + " -> " + stringCor);

            string doublePie = "double pie";
            string doublePieCor = "double pie = 0.0";
            Console.WriteLine(doublePie + " -> " + doublePieCor);

            string charLetter = "char letter = \"Aa\"";
            string charLetterCor = "char letter = 'A'";
            Console.WriteLine(charLetter + " -> " + charLetterCor);



            Console.WriteLine("\nOefening 2:"); //\n is een enter
            //Zet alles in variabelen. Welke naam geef je deze variabelen
            //13 + 7 - 90 = ?
            #region Methode1
            int getal1 = 13;
            int getal2 = 7;
            int getal3 = 90;

            Console.Write("Methode 1: ");
            Console.WriteLine(getal1 + getal2 - getal3);
            #endregion
            #region Methode2
            int x = 13;
            int y = 7;
            int z = 90;
            int resultaat = x + y - z;

            Console.Write("Methode 2: ");
            Console.WriteLine(resultaat);
            #endregion


            Console.WriteLine("\nOefening 3:");
            //Schrijf je naam + achternaam en je leeftijd in een zin en print deze uit. Gebruik variabelen!!!!
            #region Methode1
            string naam = "Kevin";
            string achternaam = "Jacobs";
            int leeftijd = 22;

            Console.Write("Methode 1: ");
            Console.WriteLine(naam + " " + achternaam + " " + leeftijd);
            #endregion
            #region Methode2
            string naam2 = "Kevin";
            string achternaam2 = "Jacobs";
            int leeftijd2 = 22; // je kan leeftijd 2 ook een string van maken dan hoef je geen .ToString() te gebruiken op regel 100. Maar aangezien dat leeftijd2 een getal is gebruik ik een integer.
            string zin = naam2 + " " + achternaam2 + " " + leeftijd2.ToString();

            Console.Write("Methode 2: ");
            Console.WriteLine(zin); 
            
            #endregion
        }
        static private void ExerciseIfElse()
        {
            Console.WriteLine("\nOefening 4: ");
            //Vraag een getal aan de gebruiker. En kijk of dit gelijk is aan een
            //willekeurige getal. En kijk dit na met if else.

            int input = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int rand = random.Next(0,5);

            if (input == rand)
            {
                Console.WriteLine("Getal is gelijk. Getal is: " + rand);
            }
            else
            {
                Console.WriteLine("Getallen zijn niet gelijk. Random is: " + rand + " input is " + input);
            }


            Console.WriteLine("\nOefening 5: ");
            //vraag de gebruiker om een nummer in te voeren tussen 0 - 10.
            //Als het getal niet tussen 0 - 10 is print je het volgende uit
            //"Getal is niet tussen de 0-10 getal is <nummer>".
            int inp = Convert.ToInt32(Console.ReadLine());

            if (!(inp > 0 && inp < 10)) // ! staat voor omgekeerde bij booleans dit wil zeggen dat !true gelijk is aan false
            {
                Console.WriteLine("Getal is niet tussen de 0-10 getal is " + inp);
            }




        }
    }
}

