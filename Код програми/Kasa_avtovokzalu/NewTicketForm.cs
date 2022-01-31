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
    public partial class NewTicketForm : Form
    {

        public NewTicketForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textName.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите имя пассажира");
                return;
            }
            if (textSurname.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите фамилию пассажира");
                return;
            }
            if (phoneNum.Text.Length < 10)
            {
                MessageBox.Show("Пожалуйста, введите полный номер телефона");
                return;
            }
            if (listNum.Text == "")
            {
                MessageBox.Show("Пожалуйста, выберите место в автобусе");
                return;
            }

            Ticket.Name = textName.Text;
            Ticket.Surname = textSurname.Text;
            Ticket.Phone = phoneNum.Text;
            Ticket.NumPlace = listNum.Text;
            Ticket.Add();

            for (Way node = MainForm.Way.head; node != null; node = node.Next)
            {
                if (node.Num == Ticket.Num)
                {
                    node.Count = (int.Parse(node.Count) - 1).ToString();
                }
            }
            MessageBox.Show("Покупка билета прошла успешно");
            this.Close();
        }

        private void phoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((!Char.IsDigit(number) || phoneNum.Text.Length >= 10) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void NewTicketForm_Load(object sender, EventArgs e)
        {
            printInfo();
            textName.Text = MainForm.Account.Name;
            textSurname.Text = MainForm.Account.Surname;
        }

        private void printInfo()
        {
            for (Way node = MainForm.Way.head; node != null; node = node.Next)
            {
                if (node.Num == Ticket.Num)
                {
                    ListNum(node.Count);
                    labelData.Text = $"Рейс №{node.Num} в {node.Time}, Харьков-{node.Ways[node.Ways.Length - 1]}," +
                        $" свободных мест: {node.Count}";
                }
            }

            for (Costs node = MainForm.Cost.head; node != null; node = node.Next)
            {
                if (Ticket.SearchCity == node.City)
                {
                    labelWay.Text = $"Откуда: ХАРЬКОВ        Куда: {Ticket.SearchCity.ToUpper()}" +
                        $"        Стоимость: {node.Cost}";
                    return;
                }
            }
            labelWay.Text = $"Откуда: ХАРЬКОВ        Куда: {Ticket.SearchCity.ToUpper()}";
        }

        private void ListNum(string num)
        {
            List<int> arr = new List<int>();

            for (Tickets node = MainForm.Tickets.head; node != null; node = node.Next)
            {
                if (node.Num == Ticket.Num)
                {
                    arr.Add(int.Parse(node.NumPlace));
                }
            }
            int count = arr.Count + int.Parse(num);
            for (int i = 1; i <= count; i++)
            {
                if (!arr.Contains(i))
                    listNum.Items.Add(i);
            }
            arr = new List<int>();
        }
    }
}
