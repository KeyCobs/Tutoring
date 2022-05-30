using System;

namespace Bijleshuis_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string merk = "Trek";
            Fietsband fb = new Fietsband("Jumbo Visma",merk);
            Fietsband hr = new Fietsband("quickstep");



            string[] tassen = new string[] { "Sporttas", "Schooltas", "" };

            fb.PrintTeam();
        }
    }
}
