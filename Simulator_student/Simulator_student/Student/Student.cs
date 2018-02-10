using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_student.Student
{
    public class Student : People
    {
        int kurs;
        bool scholarship;
        int count_action;
        double skills;

        public Student()
        {
            kurs = 1;
            scholarship = true;
            count_action = 0;
            skills = 0;
        }

        public void Clear()
        {
            kurs = 1;
            scholarship = true;
            count_action = 0;
            skills = 0;
            Clear_people();
        }



        public int CountWeek()
        {
            return count_action / 3 + 1;
        }


        //action
        public int getAction()
        {
            return count_action;
        }

        public void addAction()
        {
            this.count_action++;
        }

        public void examAction()
        {
            this.count_action += 3;
        }

        //Kurs
        public int getKurs()
        {
            return kurs;
        }

        public void setKurs(int Kurs)
        {
            this.kurs = Kurs;
        }

        //Skills
        public double getSkills()
        {
            return skills;
        }

        public void setSkills(int Skills)
        {
            this.skills += Skills;
        }

        //Стипендия
        public void Scholarship()// 3 действия - 1 неделя
        {
            if (getKnowledge() >= 275 && CountWeek() == 8) scholarship = true;// стипендия за первый семестр
            else if (getKnowledge() >= 475 && CountWeek() == 16) scholarship = true; // стипендия за второй семестр
            else scholarship = false;
            getscholarship(scholarship);// добавление к бюджету стипендии стипендии, если хорошая успеваемость
        }

        public void getscholarship(bool Scholarship)
        {
            //добавление стипендии
            if (Scholarship) setMoney(825);
            else setMoney(0);
        }



    }
}
