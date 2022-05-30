using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijleshuis_Classes
{
    internal class Fietsband
    {
        public Fietsband(string teamNaam,string merk = "")
        {
            Init(merk,teamNaam); //Geeft variablen waardes
        }

        private void Init(string merk, string teamNaam)
        {
            m_Merk = merk;
            m_AantalBanden = 2;
            m_Team = new Teams(teamNaam);
        }

        public void PrintTeam()
        {

            Console.WriteLine("Aantal banden: " + m_AantalBanden);
            Console.WriteLine("Merk: " + m_Merk);
            m_Team.PrintInfoTeam();
        }


        //private
        public int m_AantalBanden;
        public string m_Merk { get; private set; }
        private Teams m_Team; 


    }
}
