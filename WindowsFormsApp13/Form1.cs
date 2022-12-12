using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = Math.Pow(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), 2);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }
    }
}
