namespace StudentManagement
{
    public partial class Management : Form
    {
        List<Student> students = new List<Student>();
        public Management()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                int id = i;
                int age = 20 + i;
                string name = "Khang Clone " + i.ToString();
                string des = "Khang dep trai cute" + i.ToString();
                string phone = "123456789";
                string email = "email@email.com";
                var student = new Student(id, name, age, des, phone, email, DateTime.Now);
                students.Add(student);
            }

            dgvStudent.DataSource = new BindingSource() { DataSource = students };
            lableMes.Text = "";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Student student = Utils.ProcessInput(txtId.Text, txtName.Text, txtAge.Text, txtDes.Text, txtPhone.Text, txtEmail.Text, now);
            lableMes.Text = "";
            if (student != null)
            {
                if (students.Any(student => student.Id == int.Parse(txtId.Text)))
                {
                    lableMes.Text = "This id already exist in the database!";
                }
                else
                    students.Add(student);

            }
            else
            {
                lableMes.Text = "Invalid input, please refer to the rules book";
            }
            dgvStudent.DataSource = new BindingSource() { DataSource = students };
        }

        private void resetState()
        {
            txtId.Text = "";
            txtAge.Text = "";
            txtName.Text = "";
            txtDes.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";

            txtId.ReadOnly = false;
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex == dgv.Rows.Count - 1)
            {
                resetState();
            }
            else
            {
                // update input field
                var student = students[e.RowIndex];
                txtId.ReadOnly = true;
                txtId.Text = student.Id.ToString();
                txtAge.Text = student.Age.ToString();
                txtName.Text = student.Name.ToString();
                txtDes.Text = student.Description.ToString();
                txtEmail.Text = student.Email.ToString();
                txtPhone.Text = student.Phone.ToString();

                //update button state
                btnCreate.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Student student = Utils.ProcessInput(txtId.Text, txtName.Text, txtAge.Text, txtDes.Text, txtPhone.Text, txtEmail.Text, now);
            lableMes.Text = "";
            if (student != null)
            {
                int index = students.FindIndex(student => student.Id == int.Parse(txtId.Text));
                students[index] = student;
                resetState();
            }
            else
            {
                lableMes.Text = "Invalid input, please refer to the rules book";
            }
            dgvStudent.DataSource = new BindingSource() { DataSource = students };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = students.FindIndex(student => student.Id == int.Parse(txtId.Text));
            students.RemoveAt(index);
            resetState();
            dgvStudent.DataSource = new BindingSource() { DataSource = students };
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No empty input field\n" +
                "ID must be a natural number \n" +
                "Age must be a natural number and not greater than 120\n" +
                "Phone Number lenght is between 9 and 11\n" +
                "Email must follow this format 'email@email.com'", "Rules", MessageBoxButtons.OK);
        }
    }
}
