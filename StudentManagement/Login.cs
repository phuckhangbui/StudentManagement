namespace StudentManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Equals("admin") && password.Equals("1234"))
            {
                //sucess
                //MessageBox.Show("Dang nhap thanh cong","Thong bao", MessageBoxButtons.OK);
                this.Hide();
                Form frmanagement = new Management();
                frmanagement.ShowDialog();
            }
            else
            {
                //fail
                MessageBox.Show("Dang nhap that bai", "Thong bao", MessageBoxButtons.OK);
            }
        }
    }
}