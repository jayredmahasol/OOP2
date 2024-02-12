using System.Web;

namespace WinFormsApp1
{
    public partial class PreviewCustomer : Form
    {
        public PreviewCustomer()
        {
            InitializeComponent();
        }
        public void SetValues(string name, string country, string hobies, string gender, string status) 
        {
            lblName.Text = name;
            lblCountry.Text = country;
            lblGender.Text = gender; 
            lblHobies.Text = hobies;
            lblStatus.Text = status;
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }
    }
}