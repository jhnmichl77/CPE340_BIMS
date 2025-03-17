using MaterialSkin;
using MaterialSkin.Controls;

namespace CPE340_BIMS
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            Shared.Set(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
