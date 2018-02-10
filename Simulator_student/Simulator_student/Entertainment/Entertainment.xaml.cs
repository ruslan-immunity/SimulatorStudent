
using Simulator_student.Entertainment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Simulator_student
{
    /// <summary>
    /// Interaction logic for Entertainment.xaml
    /// </summary>
    public partial class Entertainments : Window
    {
        List<Entertainment.Entert> ent = new List<Entertainment.Entert>();
        public Entertainment.Entert clickedEntert;
        MainWindow mw;
        public Entertainments(MainWindow MW)
        {
            InitializeComponent();
            mw = MW;
            ent.Add(new Entert("Погамать в компуктер", 140, 0, -50));
            ent.Add(new Entert("Посидеть в интернете", 90, 0, -45));
            ent.Add(new Entert("Посмотреть кино", 70, 0, -35));
            ent.Add(new Entert("Поспать", 60, 0, -30));

            button.Content = ent[0].Name;
            button1.Content = ent[1].Name;
            button2.Content = ent[2].Name;
            button3.Content = ent[3].Name;

            if (mw.stud.getEnergy() > 150)
            {
                button1.IsEnabled = false;
                button1.Content += " | Need: 150- Energy";
            }
            if (mw.stud.getKnowledge() > 300)
            {
                button2.IsEnabled = false;
                button2.Content += " | Need: 300- Energy";
            }
            if (mw.stud.getKnowledge() < 600)
            {
                button3.IsEnabled = false;
                button3.Content += " | Need: 600- Energy";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            clickedEntert = ent[0];
            mw.stud.addAction();
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            clickedEntert = ent[1];
            mw.stud.addAction();
            Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            clickedEntert = ent[2];
            mw.stud.addAction();
            Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            clickedEntert = ent[3];
            mw.stud.addAction();
            Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            clickedEntert = new Entert("", 0, 0, 0);
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            label5.Content = mw.stud.getEnergy().ToString();
            label6.Content = mw.stud.getKnowledge().ToString();
            label8.Content = mw.stud.getKurs().ToString();
            label7.Content = mw.stud.getSkills().ToString();
            label9.Content = mw.stud.getMoney().ToString();
            label11.Content = mw.stud.CountWeek().ToString();
            mw.stud.Scholarship();
        }
    }
}
