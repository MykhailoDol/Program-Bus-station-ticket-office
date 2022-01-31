using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa_avtovokzalu
{
    public partial class SearchForm : Form
    {
        
        public SearchForm()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchCity = forSearch.Text;
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            searchCity = ti.ToTitleCase(searchCity);

            bool a = true;
            Way node = MainForm.Way.head;
            for (; node != null; node = node.Next)
            {
                if (Array.IndexOf(node.Ways, searchCity) != -1 && searchCity != "" && int.Parse(node.Count) > 0)
                {
                    Ticket.SearchCity = searchCity;
                    Ticket.Login = MainForm.Account.Login;
                    Ticket.Num = node.Num;
                    a = false;
                }
            }
            if (a)
            {
                MessageBox.Show("Результаты не найдены");
                return;
            }
            MainForm.Form.openChildFormInPanel(new ResultForm());
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            Way node = MainForm.Way.head;
            for (; node != null; node = node.Next)
            {
                for (int i = 3; i < node.Ways.Length; i++)
                {
                    if (source.IndexOf(node.Ways[i]) == -1)
                    {
                        source.Add(node.Ways[i]);
                    }
                }
            }
            forSearch.AutoCompleteCustomSource = source;
            forSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            forSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
