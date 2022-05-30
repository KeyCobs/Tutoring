using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijleshuis_Classes
{
    internal class Teams
    {
        public Teams(string naamTeam)
        {
            m_Team = naamTeam;
            m_TeamMembers = 50;
        }
        public void PrintInfoTeam()
        {
            Console.WriteLine(m_Team + " heeft " + m_TeamMembers + " ploefmaten");
        }

        public string m_Team;
        public int m_TeamMembers {  get; private set; }
    }
}
