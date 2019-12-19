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

namespace zadacha_v7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetAnswerClick(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtbxForA.Text);
            double b = Convert.ToDouble(txtbxForB.Text);
            double h = Convert.ToDouble(txtbxForH.Text);

            double x = a;
            double y;



            while (x <= b)
            {
                y = x - Math.Sin(x);
                string answer = $"\t{x}\t\t{y}\n";
                txtbxAnswer.Text += answer;
                x = x + h;
            }
        }
    }
}
