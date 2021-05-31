using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIAE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_2(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_3(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { dateTimePicker1.Text, textBox1.Text, comboBox1.Text, textBox2.Text };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            float num = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                num += float.Parse(listView1.Items[i].SubItems[1].Text);
            }
            textBox3.Text = Convert.ToString(num);

            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";

        }

        private void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--) 
            {
                ListViewItem item = listView1.SelectedItems[i];
                listView1.Items.Remove(item);
                float num = 0;
                for (int k = 0; k < listView1.Items.Count; k++)
                {
                    num += float.Parse(listView1.Items[k].SubItems[1].Text);
                }
                textBox3.Text = Convert.ToString(num);

            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
