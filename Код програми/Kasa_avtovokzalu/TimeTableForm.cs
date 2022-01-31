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
    public partial class TimeTableForm : Form
    {
        public TimeTableForm()
        {
            InitializeComponent();
            openTimeTable();
        }
        public void openTimeTable()
        {
            for (Way node = MainForm.Way.head; node != null; node = node.Next)
            {
                listFreeSpace.Text += $"{node.Count}\n";
                listNum.Text += $"{node.Num}\n";
                listTime.Text += $"{node.Time}\n";
                listCities.Text += $"{node.Ways[node.Ways.Length-1]}\n";
                listAllCities.Text += $"{string.Join(" ", node.Ways, 0, node.Ways.Length-1)}\n";
            }
        }
    }
}
