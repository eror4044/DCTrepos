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

namespace WPF_EXAM_RUSLAN
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2();
            win.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 win = new Window3();
            win.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 win = new Window4();
            win.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 win = new Window5();
            win.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window6 win = new Window6();
            win.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Window7 win = new Window7();
            win.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Window8 win = new Window8();
            win.Show();
        }
    }
}
