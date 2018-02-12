using System.Windows;

namespace Simulator_student
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Student.Student stud = new Student.Student();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Study study = new Study(stud);
            this.Hide();
            study.ShowDialog();
            this.Window_Loaded(sender, e);
            this.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Self_dev self = new Self_dev(stud);
            this.Hide();
            self.ShowDialog();
            this.Window_Loaded(sender, e);
            this.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Entertainments enter = new Entertainments(stud);
            this.Hide();
            enter.ShowDialog();
            this.Window_Loaded(sender, e);
            this.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            stud.check_scolarship();
            label5.Content = stud.Energy.ToString();
            label6.Content = stud.Knowledge.ToString();
            label8.Content = stud.Kurs.ToString();
            label7.Content = stud.Skills.ToString();
            label9.Content = stud.Money.ToString();
            label11.Content = stud.CountWeek().ToString();
            
        }
    }
}
