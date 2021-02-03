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

namespace WPF_EXAM_RUSLAN
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            Slider.Minimum = 1;
            Slider.Maximum = 7;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            switch (Convert.ToInt32(Slider.Value))
            {
                case 1:
                    { TextBox.Text = "Monday"; break; }
                case 2: 
                    { TextBox.Text = "Tuesday"; break; }
                case 3:
                    { TextBox.Text = "Wednesday"; break; }
                case 4:
                    { TextBox.Text = "Thursday"; break; }
                case 5:
                    { TextBox.Text = "Friday"; break; }
                case 6:
                    { TextBox.Text = "Saturday"; break; }
                case 7:
                    { TextBox.Text = "Sunday"; break; }


            }
        }
    }
}
