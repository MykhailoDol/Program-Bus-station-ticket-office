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
    public partial class DeleteWayForm : Form
    {
        List<string> allWays = new List<string>();
        public DeleteWayForm()
        {
            InitializeComponent();
        }

        private void DeleteWayForm_Load(object sender, EventArgs e)
        {
            textNumAdd();
        }

        private void textNumAdd()
        {
            for (Way node = MainForm.Way.head; node != null; node = node.Next)
            {
                textNums.Items.Add(node.Num);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textNums.Text == "")
            {
                MessageBox.Show("Пожалуйста, выберите номер рейса");
                return;
            }
            
            DialogResult result = MessageBox.Show(
                     $"Вы уверены, что хотите удалить рейс под номером {textNums.Text}?",
                     "",
                     MessageBoxButtons.YesNoCancel,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
                MainForm.Way.Delete(textNums.Text);
            else
                return;
            MessageBox.Show("Рейс успешно удален!");

            textNums.Items.Clear();
            textNumAdd();
        }
    }
}
