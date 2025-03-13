using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_oli
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(float cost, Form1 form)
        {
            InitializeComponent();
            form1 = form;

        }

        //ok
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.opened = false;

        }
        //wybor procka
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
