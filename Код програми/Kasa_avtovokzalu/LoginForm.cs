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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.DarkRed;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }
        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string str = Environment.ExpandEnvironmentVariables(@"%appdata%\BD\login.txt");
            //string str = @"C:\Users\user\AppData\Roaming\BD\login.txt";
            using (StreamReader r = new StreamReader(str))
            {
                for (string reader = r.ReadLine(); reader != null; reader = r.ReadLine())
                {
                    string[] data = reader.Split(' ');
                    if (loginField.Text == data[2] && passField.Text == data[3])
                    {
                        Account account = new Account(reader);
                        MainForm.Account = account;
                        ProgramForm form = new ProgramForm();
                        this.Hide();
                        form.Show();
                        return;
                    }
                }
                MessageBox.Show("Неверный логин или пароль");
                loginField.Text = passField.Text = "";
            }
        }

        private void labelReg_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }
    }
}
