using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_student.Student
{
    public class People
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public double Money { get; set; }
        public int Knowledge { get; set; }

        public People()
        {
            this.Name = "";
            this.Energy = 1000;
            this.Money = 800;
            this.Knowledge = 100; //max 500
        }

        public void Clear_people()
        {
            this.Name = "";
            this.Energy = 1000;
            this.Money = 800;
            this.Knowledge = 100; //max 500
        }
    }
}
