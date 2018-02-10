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
    /// Interaction logic for Study.xaml
    /// </summary>
    public partial class Study : Window
    {
        Student.Student student;
        public Study()
        {
            InitializeComponent();
        }

        public Study(Student.Student stud)
        {
            InitializeComponent();
            student = stud;
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            student.setEnergy(-300);
            student.setKnowledge(15);
            student.setSkills(5);
            student.addAction();
            Window_Loaded(sender, e);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            student.setEnergy(-150);
            student.setKnowledge(10);
            student.setSkills(2);
            student.addAction();
            Window_Loaded(sender, e);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            student.setEnergy(10);
            student.addAction();
            Window_Loaded(sender, e);
        }
        public void check_exam()
        {
            if (student.CountWeek() == 8 || student.CountWeek() == 16)
            {
                label12.Visibility = Visibility.Visible;
                if (student.getEnergy() > 300)
                {
                    button.IsEnabled = false;
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = true;
                }
            }
            else
            {
                label12.Visibility = Visibility.Hidden;
                button.IsEnabled = true;
                button1.IsEnabled = true;
                button2.IsEnabled = true;
                button3.IsEnabled = false;
            }
        }

        public void check_energy()
        {
            if (student.getEnergy() <= 0)
            {
                label5.Foreground = Brushes.Red;
                button.IsEnabled = false;
                button1.IsEnabled = false;
                button2.IsEnabled = false;
                button3.IsEnabled = false;
            }
            else
            {
                button.IsEnabled = true;
                button1.IsEnabled = true;
                button2.IsEnabled = true;
                label5.Foreground = Brushes.Black;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            label5.Content = student.getEnergy().ToString();
            label6.Content = student.getKnowledge().ToString();
            label8.Content = student.getKurs().ToString();
            label7.Content = student.getSkills().ToString();
            label9.Content = student.getMoney().ToString();
            label11.Content = student.CountWeek().ToString();
            student.Scholarship();
            check_energy();
            check_exam();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (student.CountWeek() == 8)
            {
                if (student.getKnowledge() >= 300)
                {
                    student.setEnergy(-300);
                    student.setSkills(20);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Ваша оцінка 5!");
 
                }
                else if (student.getKnowledge() >= 275)
                {
                    student.setEnergy(-300);
                    student.setSkills(15);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Ваша оцінка 4!");
                }
                else if (student.getKnowledge() < 275 && student.getKnowledge() >= 200)
                {
                    student.setEnergy(-300);
                    student.setSkills(5);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Ваша оцінка 3!");
                }
                else
                {
                    MessageBox.Show("До побачення, Вас вигнали з коледжу! Гру закінчено");
                    student.Clear();                
                    this.Close();
                }

            }
            else
            {
                if (student.getKnowledge() >= 500)
                {
                    student.setEnergy(-300);
                    student.setSkills(20);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Вітаємо, Ви закінчили перший курс! Ваша оцінка 5!");
                    student.Clear();
                    this.Close();
                }
                else if (student.getKnowledge() >= 475)
                {
                    student.setEnergy(-300);
                    student.setSkills(15);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Вітаємо, Ви закінчили перший курс! Ваша оцінка 4!");
                    student.Clear();
                    this.Close();
                }
                else if (student.getKnowledge() < 375 && student.getKnowledge() >= 300)
                {
                    student.setEnergy(-300);
                    student.setSkills(15);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Вітаємо, Ви закінчили перший курс! Ваша оцінка 3!");
                    student.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("До побачення, Вас вигнали з коледжу! Гру закінчено");
                    student.Clear();
                    this.Close();
                }
            }
        }
    }
}
