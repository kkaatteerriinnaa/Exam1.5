using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class NewTask : Form
    {
        // Form1 f = new Form1();

        public NewTask()
        {
            InitializeComponent();
            Workers.Items.Add("User");

        }
        // Сохраняет данные в Data 
        private void Done_Click(object sender, EventArgs e)
        {
            Data.Descrioton = Description.Text;
            Data.dateTime = DT_FullData.Text;
            Data.Time = DT_Time.Text;

            Data.Workers = Workers.SelectedItem.ToString();
        }
        // Сохраняет данные о приоритете в Data
        private void Low_CheckedChanged(object sender, EventArgs e)
        {
            Data.Priority = "Приоритет низкий";
        }
        // Сохраняет данные о приоритете в Data
        private void Middle_CheckedChanged(object sender, EventArgs e)
        {
            Data.Priority = "Приоритет средний";
        }
        // Сохраняет данные о приоритете в Data
        private void Hight_CheckedChanged(object sender, EventArgs e)
        {
            Data.Priority = "Приоритет высокий";
        }
        // Добовление нового работника
        private void button1_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            if (worker.ShowDialog() == DialogResult.OK)
            {
                string Description = $"{Data.Workers}";
                Workers.Items.Add(Description);
            }
            worker.Dispose();
        }
    }
}
