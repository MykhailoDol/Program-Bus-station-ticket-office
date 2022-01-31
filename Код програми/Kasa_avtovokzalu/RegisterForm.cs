using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa_avtovokzalu
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.DarkRed;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }
        Point lastPoint;
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelReg_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите имя");
                return;
            }
            if (surname.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите фамилию");
                return;
            }
            if (loginField.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите логин");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите пароль");
                return;
            }

            
            if (name.Text.IndexOf(' ') != -1)
            {
                MessageBox.Show("Пожалуйста, введите имя без пробелов");
                return;
            }
            if (surname.Text.IndexOf(' ') != -1)
            {
                MessageBox.Show("Пожалуйста, введите фамилию без пробелов");
                return;
            }
            if (loginField.Text.IndexOf(' ') != -1)
            {
                MessageBox.Show("Пожалуйста, введите логин без пробелов");
                return;
            }
            if (passField.Text.IndexOf(' ') != -1)
            {
                MessageBox.Show("Пожалуйста, введите пароль без пробелов");
                return;
            }

            string str = Environment.ExpandEnvironmentVariables(@"%appdata%\BD\login.txt");
            //string str = @"C:\Program Files\Common Files\BD\login.txt";

            using (StreamReader r = new StreamReader(str))
            {
                for (string reader = r.ReadLine(); reader != null; reader = r.ReadLine())
                {
                    if (reader.Split(' ')[2] == loginField.Text)
                    {
                        MessageBox.Show("Такой логин уже занят, введите другой");
                        return;
                    }
                }
            }

            using (StreamWriter r = new StreamWriter(str, true))
            {
                r.WriteLine($"{name.Text} {surname.Text} {loginField.Text} {passField.Text}");
            }
            MessageBox.Show("Аккаунт успешно создан");
            name.Text = surname.Text = loginField.Text = passField.Text = "";
        }
    }
}
