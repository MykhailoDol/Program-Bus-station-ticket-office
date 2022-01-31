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
    public partial class MyTicketsForm : Form
    {
        DialogResult result;
        string Num;
        List<string> buttons = new List<string>();

        public MyTicketsForm()
        {
            InitializeComponent();
        }

        private void MyTicketsForm_Load(object sender, EventArgs e)
        {
            MyTickets();
        }
        private void MyTickets()
        {
            int loc = 70;
            int count = 0;
            labelTicket.Text = "";

            for (Tickets node = MainForm.Tickets.head; node != null; node = node.Next)
            {
                if (node.Login == MainForm.Account.Login)
                {
                    labelTicket.Text += $"Пассажир: {node.Name} {node.Surname}," +
                        $" номер телефона: {node.Phone};" +
                        $" Харьков-{node.SearchCity}; Рейс №{node.Num}; Место №{node.NumPlace}\n\n";
                    Button button1 = new Button
                    {
                        Location = new Point(12, loc),
                        Text = "Вернуть"
                    };
                    buttons.Add($"{node.Num}_{node.NumPlace}");

                    this.Controls.Add(button1);
                    loc += 35;
                    button1.Click += new EventHandler(button1_Click);
                    button1.Name = $"{count}";
                    count++;
                }
            }
            if(labelTicket.Text == "")
                labelTicket.Text = "У вас пока нет купленных билетов";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string a = button.Name;
                string[] a1 = buttons[int.Parse(a)].Split('_');
                Num = a1[0];
                result = MessageBox.Show(
                     "Вы уверены, что хотите вернуть этот билет?",
                     "",
                     MessageBoxButtons.YesNoCancel,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    MainForm.Tickets.Delete(a1);
                    Delete(a1[0]);
                    button.Dispose();
                }
            }
        }

        private void Delete(string value)
        {
            foreach (var control in this.Controls)
            {
                Button btn = control as Button;
                if(btn != null)
                    btn.Dispose();
            }
            buttons = new List<string>();
            MyTickets();
            foreach (var control in this.Controls)
            {
                Button btn = control as Button;
                if (btn != null && btn.Name == $"{buttons.Count}")
                    btn.Dispose();
            }

            for (Way node = MainForm.Way.head; node != null; node = node.Next)
            {
                if (node.Num == value)
                {
                    node.Count = (int.Parse(node.Count) + 1).ToString();
                }
            }
        }
    }
}
