using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace lab2_oli
{
    public partial class Form3 : Form
    {
        Form1 form1;
        float monitorCost = 0;
        public Form3(Form1 form)
        {

            form1 = form;
            InitializeComponent();

            textBox1.Enabled = false;
            listView1.Items.Add("Monitor AOC - 1200 zł");
            listView1.Items.Add("Monitor LG - 600 zł");
            listView1.Items.Add("Monitor BENQ - 780 zł");
            listView1.Items.Add("Monitor SAMSUNG - 1000 zł");
            listView1.MultiSelect = false;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.opened = false;

        }
        //ok
        private void button1_Click(object sender, EventArgs e)
        {
            form1.setMonitorCost(monitorCost);
            form1.opened = false;
            this.Close();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string monitor = selectedItem.Text;

                if (monitor.Contains("AOC"))
                    monitorCost = 1200;
                else if (monitor.Contains("LG"))
                    monitorCost = 600;
                else if (monitor.Contains("BENQ"))
                    monitorCost = 780;
                else if (monitor.Contains("SAMSUNG"))
                    monitorCost = 1000;

                textBox1.Text = monitorCost.ToString() + " zł";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.opened = false;
            this.Close();
        }
    }
}
