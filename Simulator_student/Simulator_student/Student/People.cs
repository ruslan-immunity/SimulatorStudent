using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_student.Student
{
    public class People
    {
        string name;
        double money;
        int energy;
        double knowledge;

        public People()
        {
            name = "";
            energy = 1000;
            money = 800;
            knowledge = 100; //максимально 500
        }


        //Name
        public string getName()
        {
            return name;
        }
        public void setName(string Name)
        {
            this.name = Name;
        }

        //Money
        public double getMoney()
        {
            return money;
        }

        public void setMoney(double Money)
        {
            this.money += Money;
        }

        public void Clear_people()
        {
            name = "";
            energy = 1000;
            money = 800;
            knowledge = 100; //максимально 500
        }

        //Energy
        public int getEnergy()
        {
            return energy;
        }

        public void setEnergy(int Energy)
        {
            this.energy += Energy;
        }

        //Knowledge
        public double getKnowledge()
        {
            return knowledge;
        }

        public void setKnowledge(int Knowledge)
        {
            this.knowledge += Knowledge;
        }


    }
}
