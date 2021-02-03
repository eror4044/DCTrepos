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
using System.Windows.Threading;

namespace WPF_EXAM_RUSLAN
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();
        public int time = 0;
        public DateTime date1 = new DateTime();
        public Window2()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(timerTick);
     
        }
        private void timerTick(object sender, EventArgs e)
        {
            TextBlock.Text = date1.AddSeconds(time++).ToLongTimeString();
        }
        private void StopB_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void StartB_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void ClearB_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            TextBlock.Text = "00:00:00";
            time = 0;
        }
       
    }
}
