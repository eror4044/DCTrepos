using System;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class SignUp : Form
    {
        private ShopDBModel users = new ShopDBModel();
        public static string UserName;

        public SignUp()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in users.Users)
            {
                if (item.login == userNameTB.Text && item.password == userPassTB.Text)
                {
                    Visible = false;
                    using (CutomerForm customerForm = new CutomerForm())
                    {
                        customerForm.ShowDialog();
                    }
                }
                else
                {
                    IncNameLabel.Visible = true;
                    IncorrectPassLabel.Visible = true;
                }
            }
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            saveUserBtn.Visible = true;
            repeatPassTB.Visible = true;
            userPassTB.UseSystemPasswordChar = false;
        }
        //сохранение пользователя в бд
        private void saveUserBtn_Click(object sender, EventArgs e)
        {
            if (userPassTB.Text == repeatPassTB.Text)
            {
                users.Users.Add(new User
                {
                    login = userNameTB.Text,
                    password = repeatPassTB.Text
                });
                MessageBox.Show($"Пользователь{userNameTB.Text} добавлен");
                repeatPassTB.Visible = false;
                InvalidPasslbl.Visible = false;
                users.SaveChanges();
            }
            else
            {
                InvalidPasslbl.Visible = true;
            }
        }
    }
}