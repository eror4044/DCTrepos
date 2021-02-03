namespace ShopApp
{
    partial class SignUp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterBtn = new System.Windows.Forms.Button();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.userPassTB = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.IncNameLabel = new System.Windows.Forms.Label();
            this.IncorrectPassLabel = new System.Windows.Forms.Label();
            this.InvalidPasslbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repeatPassTB = new System.Windows.Forms.TextBox();
            this.saveUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(12, 295);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(303, 58);
            this.enterBtn.TabIndex = 0;
            this.enterBtn.Text = "Войти";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(12, 65);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(303, 20);
            this.userNameTB.TabIndex = 1;
            // 
            // userPassTB
            // 
            this.userPassTB.Location = new System.Drawing.Point(12, 173);
            this.userPassTB.Name = "userPassTB";
            this.userPassTB.Size = new System.Drawing.Size(303, 20);
            this.userPassTB.TabIndex = 2;
            this.userPassTB.UseSystemPasswordChar = true;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(106, 39);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(103, 13);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "Имя пользователя";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(134, 157);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Location = new System.Drawing.Point(229, 359);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(86, 38);
            this.RegistrationBtn.TabIndex = 5;
            this.RegistrationBtn.Text = "Регистрация";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // IncNameLabel
            // 
            this.IncNameLabel.AutoSize = true;
            this.IncNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncNameLabel.Location = new System.Drawing.Point(13, 88);
            this.IncNameLabel.Name = "IncNameLabel";
            this.IncNameLabel.Size = new System.Drawing.Size(157, 13);
            this.IncNameLabel.TabIndex = 6;
            this.IncNameLabel.Text = "Не верное имя пользователя";
            this.IncNameLabel.Visible = false;
            // 
            // IncorrectPassLabel
            // 
            this.IncorrectPassLabel.AutoSize = true;
            this.IncorrectPassLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPassLabel.Location = new System.Drawing.Point(13, 196);
            this.IncorrectPassLabel.Name = "IncorrectPassLabel";
            this.IncorrectPassLabel.Size = new System.Drawing.Size(101, 13);
            this.IncorrectPassLabel.TabIndex = 7;
            this.IncorrectPassLabel.Text = "Не верный пароль";
            this.IncorrectPassLabel.Visible = false;
            // 
            // InvalidPasslbl
            // 
            this.InvalidPasslbl.AutoSize = true;
            this.InvalidPasslbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidPasslbl.Location = new System.Drawing.Point(13, 264);
            this.InvalidPasslbl.Name = "InvalidPasslbl";
            this.InvalidPasslbl.Size = new System.Drawing.Size(118, 13);
            this.InvalidPasslbl.TabIndex = 10;
            this.InvalidPasslbl.Text = "Пароли не совпадают";
            this.InvalidPasslbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Повторите пароль";
            this.label2.Visible = false;
            // 
            // repeatPassTB
            // 
            this.repeatPassTB.Location = new System.Drawing.Point(12, 241);
            this.repeatPassTB.Name = "repeatPassTB";
            this.repeatPassTB.Size = new System.Drawing.Size(303, 20);
            this.repeatPassTB.TabIndex = 8;
            this.repeatPassTB.Visible = false;
            // 
            // saveUserBtn
            // 
            this.saveUserBtn.Location = new System.Drawing.Point(12, 359);
            this.saveUserBtn.Name = "saveUserBtn";
            this.saveUserBtn.Size = new System.Drawing.Size(115, 37);
            this.saveUserBtn.TabIndex = 11;
            this.saveUserBtn.Text = "Зарегестрировать пользователя";
            this.saveUserBtn.UseVisualStyleBackColor = true;
            this.saveUserBtn.Visible = false;
            this.saveUserBtn.Click += new System.EventHandler(this.saveUserBtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 409);
            this.Controls.Add(this.saveUserBtn);
            this.Controls.Add(this.InvalidPasslbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.repeatPassTB);
            this.Controls.Add(this.IncorrectPassLabel);
            this.Controls.Add(this.IncNameLabel);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.userPassTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.enterBtn);
            this.Name = "SignUp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox userPassTB;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button RegistrationBtn;
        private System.Windows.Forms.Label IncNameLabel;
        private System.Windows.Forms.Label IncorrectPassLabel;
        private System.Windows.Forms.Label InvalidPasslbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repeatPassTB;
        private System.Windows.Forms.Button saveUserBtn;
        public System.Windows.Forms.TextBox userNameTB;
    }
}

