using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            ClearPhotoBtn.Visibility = Visibility.Hidden;
            CommandBinding binding = new CommandBinding();
            binding.Command = ApplicationCommands.Open;
            binding.Executed += Button_Click_2;
            CommandBindings.Add(binding);


            CommandBinding binding2 = new CommandBinding();
            binding2.Command = ApplicationCommands.Save;
            binding2.Executed += Button_Click_1;
            CommandBindings.Add(binding2);

            // Очистка коллекций прежних жестов команд
            ApplicationCommands.Open.InputGestures.Clear();
            ApplicationCommands.Save.InputGestures.Clear();

            // Добавление новых жестов клавиатуры Enter и Escape
            InputGesture input = new KeyGesture(Key.Enter);
            ApplicationCommands.Open.InputGestures.Add(input);


            InputGesture input2 = new KeyGesture(Key.Escape);
            ApplicationCommands.Save.InputGestures.Add(input2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            Avatar.Source = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));
            if (Avatar.Source != null)
            {
                ClearPhotoBtn.Visibility = Visibility.Visible;
            }
        }

        private void ClearPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            Avatar.Source = null;
            ClearPhotoBtn.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (EmailField.Text != null && PassField.Password != null && LoginField.Text != null)
            {
                if (!isValidEmail(EmailField.Text))
                {
                    MessageBox.Show("НЕ верный Email");
                }
                if (!isValidEmail(EmailField.Text))
                {
                    MessageBox.Show("НЕ верный Логин");
                }
                if (Avatar.Source == null)
                {
                    MessageBox.Show("Загрузите фото");
                }
            }
        }
       private bool isValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
        private bool isValidName(string Name)
        {
            string pattern = "[.\\-_a-z]+@([a-z][\\-a-z]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(Name, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
    }
}
