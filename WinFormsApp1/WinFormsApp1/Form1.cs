namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string name, country, gender, hobbies, status = "";
            if (rdbMale.Checked)
            gender = "male";
            else
                gender = "Female";
            if (chbPainting.Checked)
                hobbies = "Painting";
            else if (chbPainting.Checked && chbReading.Checked)
                hobbies = "Painting, Reading";
            else if (chbReading.Checked)
                hobbies = "Reading";
            else
                hobbies = " ";

                PreviewCustomer customer  = new PreviewCustomer();
            customer.SetValues(txtName.Text);
            customer.SetValues(Show);
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}