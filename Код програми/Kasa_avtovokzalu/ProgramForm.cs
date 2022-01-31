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
    public partial class ProgramForm : Form
    {
        public ProgramForm()
        {
            InitializeComponent();
            MainForm.Form = this;
            loadIn();
            MainForm.loadAll();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        public void ExitProgram()
        {
            MainForm.saveAll();
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
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new TimeTableForm());
        }

        private Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new SearchForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MyTicketsForm());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm.saveAll();
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void ProgramForm_Load(object sender, EventArgs e)
        {
            if (labelLogo.Text != "admin")
            {
                buttonAdd.Dispose();
                button1.Dispose();
            }
        }

        private void loadIn()
        {
            labelName.Text += MainForm.Account.Name;
            labelSurname.Text += MainForm.Account.Surname;
            labelLogo.Text = MainForm.Account.Login;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewWayForm form = new NewWayForm();
            form.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DeleteWayForm form = new DeleteWayForm();
            form.ShowDialog();
        }
    }
}
