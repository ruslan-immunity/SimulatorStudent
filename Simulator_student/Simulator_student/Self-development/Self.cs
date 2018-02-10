using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_student.Self_development
{
    public class Self
    {
        string name;
        int eng,
            profit,
            exp;

        public Self(string _name, int _eng, int _profit, int _exp)
        {
            this.Name = _name;
            this.eng = _eng;
            this.profit = _profit;
            this.exp = _exp;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Eng
        {
            get
            {
                return eng;
            }

            set
            {
                eng = value;
            }
        }

        public int Profit
        {
            get
            {
                return profit;
            }

            set
            {
                profit = value;
            }
        }

        public int Exp
        {
            get
            {
                return exp;
            }

            set
            {
                exp = value;
            }
        }
    }
}
