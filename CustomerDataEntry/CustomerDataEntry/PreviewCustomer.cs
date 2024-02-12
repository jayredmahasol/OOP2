namespace CustomerDataEntry
{
    public partial class PreviewCustomer : Form
    {
        public PreviewCustomer()
        {
            InitializeComponent();
        }

        public void SetValues(string name, string country, string sex, string hobbies, string status)
        {
            lblCustomerName.Text = name;
            lblCountryName.Text = country;
            lblSex.Text = sex;
            lblHobbies.Text = hobbies;
            lblStatus.Text = status;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}
