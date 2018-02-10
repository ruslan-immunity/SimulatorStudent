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
    /// Interaction logic for Self_development.xaml
    /// </summary>
    public partial class Self_dev : Window
    {
        List<Self_development.Self> selfdev = new List<Self_development.Self>();
        public Self_development.Self clickedSelf;
        MainWindow mw;
        public Self_dev(MainWindow MainW)
        {
            InitializeComponent();
            mw = MainW;
            selfdev.Add(new Self_development.Self("Написать HelloWorld", -20, 0, 10));
            selfdev.Add(new Self_development.Self("Прочесть книгу", -45, 0, 25));
            selfdev.Add(new Self_development.Self("Занятся фрилансом", -100, 100, 20));
            selfdev.Add(new Self_development.Self("Сходить на фирму", -300, 0, 100));

            button.Content = selfdev[0].Name;
            button1.Content = selfdev[1].Name;
            button2.Content = selfdev[2].Name;
            button3.Content = selfdev[3].Name;

            if (mw.stud.getKnowledge() < 150)
            {
                button1.IsEnabled = false;
                button1.Content += " | Need: 150+ Knowlenge";
            }
            if (mw.stud.getKnowledge() < 300)
            {
                button2.IsEnabled = false;
                button2.Content += " | Need: 300+ Knowlenge";
            }
            if (mw.stud.getKnowledge() < 400)
            {
                button3.IsEnabled = false;
                button3.Content += " | Need: 400+ Knowlenge";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            clickedSelf = selfdev[0];
            mw.stud.addAction();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            clickedSelf = selfdev[1];
            mw.stud.addAction();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            clickedSelf = selfdev[2];
            mw.stud.addAction();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            clickedSelf = selfdev[3];
            mw.stud.addAction();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            clickedSelf = new Self_development.Self("", 0, 0, 0);
            this.Close();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
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
