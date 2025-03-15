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
        float selectedProcessorPrice = 0, selectedDrivePrice;
        float currentB = 0;
        float change = 0;
        public Form2(Form1 form, float budget)
        {
            InitializeComponent();
            form1 = form;
            label4.Text = budget.ToString();
            currentB = budget;

            comboBox1.Items.Add("Intel i5 - 400 zł");
            comboBox1.Items.Add("AMD 5 - 500 zł");
            comboBox1.Items.Add("Intel i7 - 700 zł");

            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }


        //ok
        private void button1_Click(object sender, EventArgs e)
        {

            form1.setPCCost(selectedProcessorPrice + selectedDrivePrice);
            form1.opened = false;
            this.Close();
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.opened = false;

        }
        //wybor procka
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedItem = comboBox1.SelectedItem.ToString();


            switch (selectedItem)
            {
                case "Intel i5 - 400 zł":
                    selectedProcessorPrice = 400;
                    break;
                case "AMD 5 - 500 zł":
                    selectedProcessorPrice = 500;
                    break;
                case "Intel i7 - 700 zł":
                    selectedProcessorPrice = 700;
                    break;
                default:
                    MessageBox.Show("Nieznany procesor!");
                    return;
            }


            textBox1.Text = selectedProcessorPrice.ToString() + " zł";

            change = currentB - selectedDrivePrice - selectedProcessorPrice;

            label4.Text = change.ToString();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radiobutton_checked(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                selectedDrivePrice = 500;
                change = currentB - selectedDrivePrice - selectedProcessorPrice;
            }
            else if (radioButton2.Checked)
            {
                selectedDrivePrice = 800;
                change -= selectedDrivePrice;
                change = currentB - selectedDrivePrice - selectedProcessorPrice;
            }
            else if (radioButton3.Checked)
            {

                selectedDrivePrice = 1000;
                change = currentB - selectedDrivePrice - selectedProcessorPrice;

            }
            textBox2.Text = selectedDrivePrice.ToString() + " zł";
            label4.Text = change.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.opened = false;
            this.Close();
        }
    }

}
