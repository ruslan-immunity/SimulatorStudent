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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Simulator_student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


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
            Self_dev self = new Self_dev(this);
            this.Hide();
            self.ShowDialog();
            stud.setEnergy(self.clickedSelf.Eng);
            stud.setKnowledge(self.clickedSelf.Exp);
            stud.setMoney(self.clickedSelf.Profit);
            this.Window_Loaded(sender, e);
            this.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Entertainments enter = new Entertainments(this);
            this.Hide();
            enter.ShowDialog();
            stud.setEnergy(enter.clickedEntert.Energy);
            stud.setKnowledge(enter.clickedEntert.Exp);
            stud.setMoney(enter.clickedEntert.Profit);
            this.Window_Loaded(sender, e);
            this.Show();
        }

        public Student.Student stud = new Student.Student();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            label5.Content = stud.getEnergy().ToString();
            label6.Content = stud.getKnowledge().ToString();
            label8.Content = stud.getKurs().ToString();
            label7.Content = stud.getSkills().ToString();
            label9.Content = stud.getMoney().ToString();
            label11.Content = stud.CountWeek().ToString();
            stud.Scholarship();
            
        }
    }
}
