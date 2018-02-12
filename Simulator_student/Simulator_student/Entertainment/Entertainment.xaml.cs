using System.Windows;
using System.Windows.Media;

namespace Simulator_student
{
    public partial class Entertainments
    {
        Student.Student student;
        string[] arr_name_tasks = { "Пограти в комп.гру", "Посидіти в соц.мережі", "Подивитися фільм", "Поспати" };

        public Entertainments(Student.Student stud)
        {
            InitializeComponent();

            student = stud;
            button.Content = arr_name_tasks[0];
            button1.Content = arr_name_tasks[1];
            button2.Content = arr_name_tasks[2];
            button3.Content = arr_name_tasks[3];

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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            student.set_parameters(50, 0, -20, 0);
            student.Count_action++;
            Window_Loaded(sender, e);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            student.set_parameters(60, 0, -25, 0);
            student.Count_action++;
            Window_Loaded(sender, e);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            student.set_parameters(80, 0, -30, 0);
            student.Count_action++;
            Window_Loaded(sender, e);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            student.set_parameters(150, 0, -5, 0);
            student.Count_action++;
            Window_Loaded(sender, e);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            label5.Content = student.Energy.ToString();
            label6.Content = student.Knowledge.ToString();
            label8.Content = student.Kurs.ToString();
            label7.Content = student.Skills.ToString();
            label9.Content = student.Money.ToString();
            label11.Content = student.CountWeek().ToString();
            check_energy();
        }
    }
}
