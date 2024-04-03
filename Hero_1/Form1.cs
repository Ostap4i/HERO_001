namespace Hero_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? You want to leave?", "Submit Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this game we can choose characters, and they 1 vs 1, you can also choose cards for battle");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}