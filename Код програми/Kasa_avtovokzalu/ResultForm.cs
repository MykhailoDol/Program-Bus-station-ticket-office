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
    public partial class ResultForm : Form
    {
        string searchCity = Ticket.SearchCity;
        BtnList buttons = new BtnList();
        public ResultForm()
        {
            InitializeComponent();
        }
        
        
        public void ResultForm_Load(object sender, EventArgs e)
        { 
            int count = 0;
            Way node = MainForm.Way.head;       
            labelLogo.Text = $"{searchCity}\nБлижайший рейс к даному пункту";
            for (; node != null; node = node.Next)
            {
                if (node.Ways.Contains(searchCity)  && int.Parse(node.Count) > 0)
                {
                    labelString.Text = $"Рейс №{node.Num} в {node.Time}, Харьков-{node.Ways[node.Ways.Length-1]}";
                    buttons.Add(int.Parse(node.Num));
                    count++;
                    buttonBuyTicket.Tag = node.Num;
                    node = node.Next;
                    break;
                }
            }
                int loc = 204;
            for (; node != null; node = node.Next)
            {
                if (node.Ways.Contains(searchCity) && int.Parse(node.Count) > 0)
                {

                    if (count == 1)
                    {
                        Label label1 = new Label
                        {
                            Font = labelLogo.Font,
                            Location = new Point(49, 152),
                            Text = "Другие рейсы",
                            AutoSize = true,
                            Tag = node.Num
                        };
                        this.Controls.Add(label1);
                    }
                    Label h1 = new Label
                    {
                        Font = labelString.Font,
                        Location = new Point(49, loc),
                        AutoSize = true,
                        Text = $"Рейс №{node.Num} в {node.Time}, Харьков-{node.Ways[node.Ways.Length - 1]}"
                    };
                    this.Controls.Add(h1);

                    Button button1 = new Button
                    {
                        Location = new Point(472, loc),
                        Size = buttonBuyTicket.Size,
                        Text = buttonBuyTicket.Text
                    };
                    buttons.Add(double.Parse(node.Num));

                    this.Controls.Add(button1);
                    loc += 40;
                    button1.Click += new EventHandler(button1_Click);
                    button1.Name = $"{count}";
                    count++;
                }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string a = button.Name;
                buttonBuyTicket.Tag = buttons[int.Parse(a)];
                newForm();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
          MainForm.Form.openChildFormInPanel(new SearchForm());
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            buttonBuyTicket.Tag = buttons[0];
            newForm();
        }

        void newForm()
        {
            Ticket.Num = buttonBuyTicket.Tag.ToString();
            NewTicketForm form = new NewTicketForm();
            form.ShowDialog();
        }
    }
}
