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
    public partial class NewWayForm : Form
    {
        public NewWayForm()
        {
            InitializeComponent();
        }

        private void textNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) || textNum.Text.Length >= 10) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textNumPas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) || textNumPas.Text.Length >= 3) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void NewWayForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                string o = $"{i}";
                if (i < 10)
                    o = "0" + o;
                if (i < 24)
                    textHour.Items.Add(o);
                textMinute.Items.Add(o);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNum.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите номер рейса");
                return;
            }
            if (textNumPas.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите количество мест");
                return;
            }
            if (textHour.Text == "" || textMinute.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите корректное время");
                return;
            }
            if (textWays.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите пункты направления");
                return;
            }
            if (textCost.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите цены");
                return;
            }
            if (textCost.Text.Split(' ').Length < textWays.Text.Split(',').Length)
            {
                MessageBox.Show("Введите цену поездки к каждому пункту.");
                return;
            }

            if (MainForm.Way.Check(textNum.Text))
            {
                MessageBox.Show("Рейс с таким номером уже существует");
                return;
            }

            WayList newWay = new WayList();
            string ways = String.Join("_", textWays.Text.Split(','));
            newWay.Add($"{textNumPas.Text}_{textNum.Text}_{textHour.Text}:{textMinute.Text}" +
                $"_{ways}");
            MainForm.Way.Sort(newWay.head);

            costNew();
            MessageBox.Show("Рейс успешно добавлен!");
            textCost.Text = textHour.Text = textMinute.Text = textNum.Text
                 = textNumPas.Text = textWays.Text = "";
        }


        private void costNew()
        {
            string[] allCities = textWays.Text.Split(',');
            string[] allCosts = textCost.Text.Split(' ');
            for (Costs node = MainForm.Cost.head; node != null; node = node.Next)
            {
                int i = Array.IndexOf(allCities, node.City);
                if (i != -1)
                {
                    node.Cost = allCosts[i];
                }
            }

            for (int i = 0; i < allCities.Length; i++)
            {
                int a = MainForm.Cost[allCities[i]];
                if (a == -1)
                {
                    MainForm.Cost.Add($"{allCities[i]}_{allCosts[i]}");
                }
            }
        }
    }
}
