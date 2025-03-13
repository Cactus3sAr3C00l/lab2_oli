namespace lab2_oli
{
    public partial class Form1 : Form
    {

       
        float cost1, cost2;

        public
        bool opened = false;
        public Form1()
        {
            InitializeComponent();
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
                form2 = new Form2(cost1, this);
                form2.Show();
                opened = true;
            }
         
        }
    }
}
