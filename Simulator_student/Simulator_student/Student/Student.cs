using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_student.Student
{
    public class Student : People
    {
        public int Kurs { get; set; }
        public bool Scholarship { get; set; }
        public int Count_action { get; set; }
        public double Skills { get; set; }

        public Student()
        {
            this.Kurs = 1;
            this.Scholarship = true;
            this.Count_action = 0;
            this.Skills = 0;
            Clear_people();
        }

        public void set_parameters(int energy, double money, int knowledge, double skills)
        {
            this.Energy += energy;
            this.Money += money;
            this.Knowledge += knowledge;
            this.Skills += skills;
        }

        public void Clear()
        {
            this.Kurs = 1;
            this.Scholarship = true;
            this.Count_action = 0;
            this.Skills = 0;
            Clear_people();
        }

        //определить на какой по счету недели находится студент по количеству сделанных действий
        public int CountWeek()
        {
            return this.Count_action / 3 + 1;
        }

        // сдать экзамены --> +3 действия
        public void examAction()
        {
            this.Count_action += 3;
        }

        //scolarship
        public void check_scolarship()
        {
            // 3 action - 1 week
            if (Knowledge >= 275 && CountWeek() <= 8) this.Scholarship = true;// scolarship for the first semester
            else if (Knowledge >= 475 && CountWeek() <= 16) this.Scholarship = true; // scolarship for the second semester
            else this.Scholarship = false;
            earningScolarship(this.Scholarship);// Appendix to the budget of the scholarship, if good academic standing
        }

        public void earningScolarship(bool Scholarship)
        {
            // check scholarship
            if (Scholarship) Money += 825;
        }
    }
}
