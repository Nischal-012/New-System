namespace New_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
                {
                textBox3.UseSystemPasswordChar = true;
                }
            else
            {
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}