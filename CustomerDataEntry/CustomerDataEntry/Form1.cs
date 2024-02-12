namespace CustomerDataEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string sex, hobbies, status;

            sex = (rdbMale.Checked) ? "Male" : "Female";

            if (chkReading.Checked && chkPainting.Checked)
                hobbies = "Reading and Painting";
            else if (chkReading.Checked)
                hobbies = "Reading";
            else if (chkPainting.Checked)
                hobbies = "Painting";
            else
                hobbies = "";

            status = (rdbMarried.Checked) ? "Married" : "Unmarried";

            PreviewCustomer prevCustomer = new PreviewCustomer();

            prevCustomer.SetValues(txtCustomerName.Text, cmbCountry.Text, sex, hobbies, status);

            prevCustomer.Show();
        }
    }
}
