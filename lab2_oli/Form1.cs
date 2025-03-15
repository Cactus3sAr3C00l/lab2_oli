namespace lab2_oli
{
    public partial class Form1 : Form
    {


        float pc = 0, monitor = 0, budget = 4000;

        public
        bool opened = false;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;

        }

        public void setPCCost(float cost)
        {

            pc = cost;
            float tmp = cost + monitor;
            richTextBox1.Text = tmp.ToString();
        }
        public void setMonitorCost(float cost)
        {
            monitor = cost;
            float tmp = cost + pc;
            richTextBox1.Text = tmp.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //on click
        private void button1_Click(object sender, EventArgs e)
        {
            if (opened == false)
            {
                Form2 form2;
                form2 = new Form2(this, budget);
                form2.Show();
                opened = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opened == false)
            {
                Form3 form3;
                form3 = new Form3(this);
                form3.Show();
                opened = true;
            }
        }
    }
}
