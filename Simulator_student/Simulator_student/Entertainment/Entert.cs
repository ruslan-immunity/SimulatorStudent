using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_student.Entertainment
{
    public class Entert
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public int Profit { get; set; }
        public int Exp { get; set; }

        public Entert(string name, int energy, int profit, int exp)
        {
            Name = name;
            Energy = energy;
            Profit = profit;
            Exp = exp;
        }
    }
}
