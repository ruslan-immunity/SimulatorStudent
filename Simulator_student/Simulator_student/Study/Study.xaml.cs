using System;
using System.Windows;
using System.Windows.Media;

namespace Simulator_student
{
    public partial class Study
    {
        Student.Student student;
        string [] arr_name_tasks = { "Бути активним на парі", "Бути присутнім на парі", "Проспати/не підти", "Здати семестр. іспит" };

        public Study()
        {
            InitializeComponent();
        }

        public Study(Student.Student stud)
        {
            InitializeComponent();

            student = stud;
            button.Content = arr_name_tasks[0];
            button1.Content = arr_name_tasks[1];
            button2.Content = arr_name_tasks[2];
            button3.Content = arr_name_tasks[3];
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            student.set_parameters(-300, 0, 15, 5);
            student.Count_action++;
            Window_Loaded(sender, e);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            student.set_parameters(-150, 0, 10, 2);
            student.Count_action++;
            Window_Loaded(sender, e);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            student.set_parameters(20, 0, 0, 0);
            student.Count_action++;
            Window_Loaded(sender, e);
        }
        public void check_exam()
        {
            if (student.CountWeek() == 8 || student.CountWeek() == 16 && student.Energy > 0)
            {
                label12.Visibility = Visibility.Visible;
                if (student.Energy > 300)
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
            if (student.Energy <= 0)
            {
                label5.Foreground = Brushes.Red;
                button.IsEnabled = false;
                button1.IsEnabled = false;
                button2.IsEnabled = false;
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
            student.check_scolarship();
            label5.Content = student.Energy.ToString();
            label6.Content = student.Knowledge.ToString();
            label8.Content = student.Kurs.ToString();
            label7.Content = student.Skills.ToString();
            label9.Content = student.Money.ToString();
            label11.Content = student.CountWeek().ToString();
            check_exam();
            check_energy();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (student.CountWeek() == 8)
            {
                if (student.Knowledge >= 300)
                {
                    student.set_parameters(-300, 0, 0, 20);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Ваша оцінка 5!");

                }
                else if (student.Knowledge >= 275)
                {
                    student.set_parameters(-300, 0, 0, 15);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Ваша оцінка 4!");
                }
                else if (student.Knowledge < 275 && student.Knowledge >= 200)
                {
                    student.set_parameters(-300, 0, 0, 5);
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
                if (student.Knowledge >= 500)
                {
                    student.set_parameters(-300, 0, 0, 20);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Вітаємо, Ви закінчили перший курс! Ваша оцінка 5!");
                    student.Clear();
                    this.Close();
                }
                else if (student.Knowledge >= 475)
                {
                    student.set_parameters(-300, 0, 0, 15);
                    student.examAction();
                    Window_Loaded(sender, e);
                    MessageBox.Show("Вітаємо, Ви закінчили перший курс! Ваша оцінка 4!");
                    student.Clear();
                    this.Close();
                }
                else if (student.Knowledge < 375 && student.Knowledge >= 300)
                {
                    student.set_parameters(-300, 0, 0, 5);
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